using CrystalDecisions.CrystalReports.Engine;
using Inventory_Management_System.Helpers;
using Inventory_Management_System.Models;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.PerformanceData;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management_System.Services
{
    //InventoryDB
    internal static class DatabaseService
    {
        internal const string ConnectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=InventoryDB;Integrated Security=True;";

        public static DataTable GetProducts()
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = new System.Data.SqlClient.SqlConnection(ConnectionString))
            {


                const string sql = "SELECT * FROM Inventory.Products";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            dataTable.Load(reader);


                            reader.Close();
                        }
                    }
                    catch
                    {
                        MessageBox.Show("The requested order could not be loaded into the form.");
                    }
                    finally
                    {
                        connection.Close();
                    }

                }
            }

            return dataTable;
        }

        public static Product GetProduct(int id)
        {
            Product product = null;
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                const string sql = @"
            SELECT ProductID, ProductName, Description, QuantityInStock, Price, Category, SupplierName
            FROM Inventory.Products
            WHERE ProductID = @Id";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                reader.Read();
                                product = new Product
                                {
                                    Id = reader.GetInt32(reader.GetOrdinal("ProductID")),
                                    Name = reader.GetString(reader.GetOrdinal("ProductName")),
                                    Description = reader.IsDBNull(reader.GetOrdinal("Description")) ? null : reader.GetString(reader.GetOrdinal("Description")),
                                    Quantity = reader.GetInt32(reader.GetOrdinal("QuantityInStock")),
                                    Price = (float)reader.GetDecimal(reader.GetOrdinal("Price")),
                                    Category = reader.IsDBNull(reader.GetOrdinal("Category")) ? null : reader.GetString(reader.GetOrdinal("Category")),
                                    Supplier = reader.GetString(reader.GetOrdinal("SupplierName"))
                                };
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error loading product: {ex.Message}");
                    }
                }
            }
            return product ?? new Product();
        }

        public static void AddProduct(Product product)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                const string sql = "EXEC sp_set_session_context @key = 'UserID', @value = @User_ID,  @read_only = 1; INSERT INTO Inventory.Products (ProductName, Description, QuantityInStock, Price, Category, SupplierName) VALUES (@Name, @Description, @Quantity, @Price, @Category, @Supplier)";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@User_ID", AuthServices.MainUser.Id);
                    command.Parameters.AddWithValue("@Name", product.Name);
                    command.Parameters.AddWithValue("@Description", product.Description);
                    command.Parameters.AddWithValue("@Quantity", product.Quantity);
                    command.Parameters.AddWithValue("@Price", product.Price);
                    command.Parameters.AddWithValue("@Category", product.Category);
                    command.Parameters.AddWithValue("@Supplier", product.Supplier);
                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                    catch
                    {
                        MessageBox.Show("The product could not be added to the database.");
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }

        public static void UpdateProduct(Product product)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                const string sql = "EXEC sp_set_session_context @key = 'UserID', @value = @User_ID,  @read_only = 1; UPDATE Inventory.Products SET ProductName = @Name, Description = @Description, QuantityInStock = @Quantity, Price = @Price, Category = @Category, SupplierName = @Supplier WHERE ProductID = @Id";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@User_ID", AuthServices.MainUser.Id);
                    command.Parameters.AddWithValue("@Id", product.Id);
                    command.Parameters.AddWithValue("@Name", product.Name);
                    command.Parameters.AddWithValue("@Description", product.Description);
                    command.Parameters.AddWithValue("@Quantity", product.Quantity);
                    command.Parameters.AddWithValue("@Price", product.Price);
                    command.Parameters.AddWithValue("@Category", product.Category);
                    command.Parameters.AddWithValue("@Supplier", product.Supplier);
                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                    catch
                    {
                        MessageBox.Show("The product could not be updated in the database.");
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }

        public static void DeleteProduct(int id)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                const string sql = "EXEC sp_set_session_context @key = 'UserID', @value = @User_ID,  @read_only = 1; DELETE FROM Inventory.Products WHERE ProductID = @Id";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@User_ID", AuthServices.MainUser.Id);
                    command.Parameters.AddWithValue("@Id", id);
                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                    catch
                    {
                        MessageBox.Show("The product could not be deleted from the database.");
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }

        public static DataTable SearchProducts(string name = "", string category = "", StockStatus stock = StockStatus.HIGH_STOCK)
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                string sql = "SELECT * FROM Inventory.Products WHERE 1 = 1";
                if (!string.IsNullOrEmpty(name))
                {
                    sql += " AND ProductName LIKE @Name";
                }
                if (!string.IsNullOrEmpty(category))
                {
                    sql += " AND Category = @Category";
                }

                if (stock == StockStatus.HIGH_STOCK)
                {
                    sql += " AND QuantityInStock >= 100";
                }
                else if(stock == StockStatus.LOW_STOCK)
                {
                    sql += " AND QuantityInStock > 0 AND QuantityInStock < 100";
                }
                else
                {
                    sql += " AND QuantityInStock <= 0";
                }
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    if (!string.IsNullOrEmpty(name))
                    {
                        command.Parameters.AddWithValue("@Name", $"%{name}%");
                    }
                    if (!string.IsNullOrEmpty(category))
                    {
                        command.Parameters.AddWithValue("@Category", category);
                    }
                    if (stock > 0)
                    {
                        command.Parameters.AddWithValue("@Stock", stock);
                    }
                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            dataTable.Load(reader);
                            reader.Close();
                        }
                    }
                    catch
                    {
                        MessageBox.Show("The requested products could not be loaded into the form.");
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
            return dataTable;
        }

        public static DataTable GetUsers()
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                const string sql = "SELECT * FROM Inventory.Users";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            dataTable.Load(reader);
                            reader.Close();
                        }
                    }
                    catch
                    {
                        MessageBox.Show("The requested order could not be loaded into the form.");
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
            return dataTable;
        }

        public static void AddUser(User user)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                const string sql = "INSERT INTO Inventory.Users (Username, PasswordHash, IsAdmin) VALUES (@Username, @PasswordHash, @IsAdmin)";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@Username", user.Username);
                    command.Parameters.AddWithValue("@PasswordHash", user.Password);
                    command.Parameters.AddWithValue("@IsAdmin", user.IsAdmin);
                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                    catch
                    {
                        MessageBox.Show("The user could not be added to the database.");
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }

        public static User GetUser(string username)
        {
            User user = null;

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                const string sql = "SELECT UserID, Username, PasswordHash, IsAdmin FROM Inventory.Users WHERE Username = @Username";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);

                    try
                    {
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                reader.Read();

                                user = new User
                                {
                                    Id = reader.GetInt32(reader.GetOrdinal("UserID")),
                                    Username = reader.GetString(reader.GetOrdinal("Username")),
                                    Password = reader.GetString(reader.GetOrdinal("PasswordHash")),
                                    IsAdmin = reader.GetBoolean(reader.GetOrdinal("IsAdmin"))
                                };
                                reader.Close();
                                // Set the session context for UserID
                                using (SqlCommand setSessionCommand = new SqlCommand("EXEC sp_set_session_context @key = 'UserID', @value = @UserID,  @read_only = 1", connection))
                                {
                                    setSessionCommand.Parameters.AddWithValue("@UserID", user.Id);
                                    setSessionCommand.ExecuteNonQuery();
                                }

                                using (SqlCommand setSessionCommand = new SqlCommand("SELECT CAST(SESSION_CONTEXT(N'UserID') AS INT );", connection))
                                {
                                    var x = setSessionCommand.ExecuteReader();
                                    x.Read();
                                    int y = x.GetInt32(0);

                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"The user could not be found in the database. Error: {ex.Message}");
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }

            return user;
        }

        public static DataTable GetAuditLog()
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                const string sql = "SELECT * FROM Inventory.AuditLogs";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            dataTable.Load(reader);
                            reader.Close();
                        }
                    }
                    catch
                    {
                        MessageBox.Show("The requested order could not be loaded into the form.");
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
            return dataTable;

        }
    }
}
