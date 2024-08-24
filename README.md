# Hotel Management System

## Overview

The Hotel Management System is a Windows Forms Application built using C# and MySQL. The application provides a user-friendly interface for hotel receptionists to manage guests, rooms, and reservations.

## Features

- **User Authentication:** Users can log in with existing credentials. (If you don't have them, create them in the database)
- **Dashboard:** Access to a home page with an overview of key information.
- **Manage Guests:** Add, update, or delete guest information.
- **Manage Rooms:** Add, update, or delete room details.
- **Manage Reservations:** Add, update, or delete reservations.
- **Database Integration:** All data is stored and managed using a MySQL database.

## Installation

### Prerequisites

- .NET Framework
- MySQL Server
- Visual Studio

### Steps

1. **Clone the repository:**

    ```sh
    git clone https://github.com/yourusername/hotel-management-system.git
    ```

2. **Open the project:**

    Open the solution file (`HotelManagementSystem.sln`) in Visual Studio.

3. **Configure the database:**

    Update the connection string in the `App.config` file with your MySQL database credentials.

    ```xml
    <connectionStrings>
        <add name="MySqlConnectionString" 
             connectionString="server=YOUR_SERVER;database=YOUR_DATABASE;uid=YOUR_USERNAME;pwd=YOUR_PASSWORD;" 
             providerName="MySql.Data.MySqlClient" />
    </connectionStrings>
    ```


4. **Build and run the application:**

    Build the solution in Visual Studio and run the application.

## Usage

### Login

- Enter your username and password to log in to the system.
- Upon successful login, you will be redirected to the dashboard.

### Dashboard

- The dashboard provides an overview of the system, including quick links to manage guests, rooms, and reservations.

### Manage Guests

- Navigate to the 'Guests' section.
- Add a new guest by filling out the form and clicking 'Add'.
- Update an existing guest by selecting them from the list, modifying the details, and clicking 'Update'.
- Delete a guest by selecting them from the list and clicking 'Delete'.

### Manage Rooms

- Navigate to the 'Rooms' section.
- Add a new room by filling out the form and clicking 'Add'.
- Update an existing room by selecting it from the list, modifying the details, and clicking 'Update'.
- Delete a room by selecting it from the list and clicking 'Delete'.

### Manage Reservations

- Navigate to the 'Reservations' section.
- Add a new reservation by filling out the form and clicking 'Add'.
- Update an existing reservation by selecting it from the list, modifying the details, and clicking 'Update'.
- Delete a reservation by selecting it from the list and clicking 'Delete'.

## Contributing

If you would like to contribute to this project, please fork the repository and submit a pull request. 


## Acknowledgements

- [MySQL](https://www.mysql.com/)
- [Visual Studio](https://visualstudio.microsoft.com/)
