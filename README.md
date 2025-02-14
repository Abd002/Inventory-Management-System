### **Dependencies**
   - Install-Package MetroModernUI
   - MetroSet_UI
   - Telerik    
   - CrystalDecisions

# **Inventory Management System**
- ### Using the Observer pattern and the MVVM architecture.
- ### Using a separate database in SQL Server to abstract the database from the program.
- ### Using simple authentication using users table and setting the db session context each time we open a connection to be able to retreive the current logged in user inside the AuditLog triggers.

### **Configurations**
- StockEnum in Helpers/StockEnum.cs to set the threshold for searching.
- In Crystal Reports, you can adjust the low stock threshold (default < 10).
- Connection string int Services/DatabaseService.cs

## Small brief about all files
-
    ```
    .
    │   SQLQuery.sql                   # Database schema (tables, triggers)
    │
    ├───Inventory Management System    # Main project folder
    │   │   App.config                 
    │   │   CrystalReport.rpt          # Crystal Report template file
    │   │   Program.cs                 # Main entry point of the application
    │   │
    │   ├───Helpers                     # Utility classes and enums
    │   │       RelayCommand.cs         # Implementation of ICommand for MVVM pattern
    │   │       StockEnum.cs            # Enum for stock-related values
    │   │       Utilities.cs            # Common helper methods used in the project
    │   │
    │   ├───Models                      # Data models representing database entities
    │   │       Product.cs              # Model for Product entity
    │   │       User.cs                 # Model for User entity
    │   │
    │   ├───Resources                   # (images, icons)
    │   │
    │   ├───Services                    
    │   │       AuthServices.cs         # Authentication used
    │   │       DatabaseService.cs      # database operations
    │   │
    │   ├───ViewModel                   # ViewModels for MVVM pattern
    │   │       AddProductViewModel.cs  # ViewModel for adding products
    │   │       EditProductModelView.cs # ViewModel for editing products
    │   │       LoginViewModel.cs       # ViewModel for login screen
    │   │       ProductViewModel.cs     # ViewModel for viewing,adding,editing products using dataGridView
    │   │       RadGridViewModel.cs     # ViewModel for viewing data
    │   │       RegisterViewModel.cs    # ViewModel for user registration
    │   │       ReportViewModel.cs      # ViewModel for CrystalReports
    │   │
    │   └───Views                       # UI views for different features
    │       ├───AddProduct              # Views for adding products
    │       ├───Admin                   # Admin dashboard
    │       ├───EditProduct             # Views for editing products
    │       ├───Home                    # Home screen 
    │       ├───LogIn                   # User login 
    │       ├───Products                # Views for managing product listings
    │       ├───RadGrid                 # Views for managing product listings using RadGrid
    │       ├───Register                # User registration 
    │       └───Report                  # Report generation 

    
## Screens from running application
* Login 
    ![Local Image](./img/Login.PNG)
* Register
    ![Local Image](./img/Register.PNG)
* Home 
    ![Local Image](./img/Home.PNG)
* Products using RadGrid
    ![Local Image](./img/Products_usingRadGrid.PNG)
* Adding Product 
    ![Local Image](./img/Adding_Products.PNG)
* Admin dashboard
    ![Local Image](./img/Admin.PNG)
* Report
    ![Local Image](./img/Report.PNG)

- ### Refrences
    - https://www.youtube.com/watch?v=CCSOmEEC_28
    - https://learn.microsoft.com/en-us/visualstudio/data-tools/create-a-simple-data-application-by-using-adonet?view=vs-2022&tabs=csharp
    - https://www.youtube.com/watch?v=UG0NOT-nlmI&t=141s