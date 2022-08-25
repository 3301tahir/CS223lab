# .NET Windows Forms Application - A Product Management System

#### Classes
* `MySQLConnection.cs` - Handles SQL Server connectivity
* `Product.cs` - Product model class
* `Program.cs` - Project main class

#### Custom User Controls
* `UCProductCard.cs`

#### Forms
* `FormLogin.cs`
* `FormMain.cs` - Main MDI parent form that launches all other forms
* `FormManageProducts.cs` - Add, update, and delete are all done here
* `FormSearch.cs` - Allows user to search by product name
* `FormDisplay.cs` - Dynamically displays all products using UCProductCard
* `FormPCDetails.cs` - Details page that is triggered by click on UCProductCard
* `FormSQLConn.cs` - Tests SQL Server connection

#### Other
* `SQLQueries.sql` - Used SQL queries log
* `cs223labDB.bak` - Product database backup
