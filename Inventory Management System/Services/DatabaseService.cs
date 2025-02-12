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
        internal const string ConnectionString = "";

        public static DataTable GetProducts()
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = new System.Data.SqlClient.SqlConnection(ConnectionString))
            {


                const string sql = "SELECT * FROM InventoryDB.Products";

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

        public static void AddProduct(Product product)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                const string sql = "INSERT INTO InventoryDB.Products (Name, Description, Quantity, Price, Category, Supplier) VALUES (@Name, @Description, @Quantity, @Price, @Category, @Supplier)";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
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
                const string sql = "UPDATE InventoryDB.Products SET Name = @Name, Description = @Description, Quantity = @Quantity, Price = @Price, Category = @Category, Supplier = @Supplier WHERE Id = @Id";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
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
                const string sql = "DELETE FROM InventoryDB.Products WHERE Id = @Id";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
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

        public static DataTable GetUsers()
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                const string sql = "SELECT * FROM InventoryDB.Users";
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
                const string sql = "INSERT INTO InventoryDB.Users (Username, Password, Email, IsAdmin) VALUES (@Username, @Password, @Email, @IsAdmin)";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@Username", user.Username);
                    command.Parameters.AddWithValue("@Password", user.Password);
                    command.Parameters.AddWithValue("@Email", user.Email);
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
                const string sql = "SELECT Id, Username, Password, Name, Email FROM InventoryDB.Users WHERE Username = @Username";

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
                                    Id = reader.GetInt32(reader.GetOrdinal("Id")),
                                    Username = reader.GetString(reader.GetOrdinal("Username")),
                                    Password = reader.GetString(reader.GetOrdinal("Password")),
                                    Email = reader.GetString(reader.GetOrdinal("Email"))
                                };
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
    }

}
