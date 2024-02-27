# OtpTask
- This is ASP.NET Core Project
- Based on .Net 6
- Based on MVC Pattern


#Setup Instructions

#To set up the project:

    -Install SQLite3 and add it to the Windows environment path.
    -Restore packages.
    -Utilize the Update-Database command in the Package Manager Console to create the database.sqlite3 dbMain.db.
    -Modify the connection string in appsettings and Program.cs.
    -Populate records into the Genre Table (e.g., Action, Drama) for dropdown lists.

#Flow of Operations

#The application workflow includes:

    -Registration
    -Confirmation email sent to the user's email address
    -Login with first-time setup of Two-Factor Authentication (2FA) by scanning a QR code using Google Authenticator
    -Subsequent logins require insertion of the generated OTP (TOTP)
    -Password reset functionality accessible via the username
    -Forgot Password option triggers the sending of a reset email 

#Technologies Utilized

    ASP.NET (.NET 6)
    Entity Framework (EF) Core
    LINQ
    ASP.NET Identity
    SQLite as the database backend

---------------------------
#Features

1-CRUD Operations

    -Create, Read, Update, Delete (CRUD) for Movies and Genres

2-Other Features

    -Activation email using the EmailSender service.
    -Forgot Password using EmailSender service.

#Authentication Operations

    -Login
    -Logoff
    -Registration
    -Password Reset
    -Multi-Factor Authentication (MFA) with support for keys and QR codes
    -Database locking mechanism after failed login attempts
