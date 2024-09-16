## Easy Contact

> A simple contact manager built with ASP.NET Core MVC. Add, update, and manage your contacts efficiently.

This project provides a straightforward way to handle contact lists, allowing users to create, view, and manage their contacts. It's built using **ASP.NET Core MVC** with Entity Framework Core for database management.

### Features

- Add, view, update, and delete contacts.
- Mark contacts as active or inactive.
- Store contact information such as name and phone number.

### Getting Started 

Follow these instructions to set up and run the project on your local machine.

* **Prerequisites**
   - [.NET SDK 6.0+](https://dotnet.microsoft.com/download/dotnet/6.0)
   - [SQL Server Express](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) or any other SQL Server instance
   - [Git](https://git-scm.com/) (to clone the repository)

### Installation

1. Clone the repository:
   ```bash
   git clone https://github.com/luis-domingues/easy-contact.git
   cd easy-contact
   ```
   
2. Restore the dependencies:
   ```bash
   dotnet restore
   ```
   
3. Configure the database connection string:
   - Open the `appsettings.json` file located in the root of the project.
   - Modify the `DefaultConnection` in the `"ConnectionStrings"` section to point to your SQL Server instance.
  
### Running the Application
```bash
dotnet run
```

### Testing
You can manually test the application by navigating to the main page and adding contacts using the UI.

## Contributing 🤝
Feel free to open issues or submit pull requests if you'd like to contribute.

## License 📃
This project is licensed under the MIT License - see the [LICENSE]() file for details.
