This application was developed for Web 
Application module, as coursework portfolio project @ WIUT by student ID: 00016532"

KeyStoreAPI
This is the backend API for the KeyStore application. The API provides endpoints for managing users, including CRUD operations (Create, Read, Update, Delete)


Installation
To set up the project locally, follow these steps:

Clone the repository:
git clone https://github.com/00016532/KeyStoreAPI.git


Navigate to the project folder:
cd KeyStoreAPI


Install dependencies:
Run the following command to install the required Node.js dependencies:
npm install


Set up the database:
This API uses a MongoDB or MySQL database (depending on your setup). You'll need to configure the database connection.

MongoDB:
Set the MongoDB URI in the .env file.
DB_URI=mongodb://localhost:27017/keystore
MySQL (Optional):

Update the .env file with MySQL credentials if using MySQL. Run the application:
After installing the dependencies and setting up the database, you can start the application:

npm start

This will start the API on http://localhost:5000.

API Endpoints
Base URL: http://localhost:5000/api/
GET /Users
Get a list of all users.

Request:

GET /api/Users
Response:

[
  {
    "userID": 1,
    "username": "john_doe",
    "email": "john.doe@example.com",
    "role": "Admin",
    "createdAt": "2024-12-01T12:34:56Z"
  },
  ...
]
GET /Users/{id}
Get a specific user by ID.

GET /api/Users/{id}

{
  "userID": 1,
  "username": "john_doe",
  "email": "john.doe@example.com",
  "role": "Admin",
  "createdAt": "2024-12-01T12:34:56Z"
}



 POST /Users
Create a new user.

POST /api/Users

{
  "username": "jane_doe",
  "password": "hashed_password",
  "email": "jane.doe@example.com",
  "role": "User"
}

response :

{
  "userID": 2,
  "username": "jane_doe",
  "email": "jane.doe@example.com",
  "role": "User",
  "createdAt": "2024-12-05T12:34:56Z"
}




PUT /Users/{id}
Update an existing user's information.

Request:

PUT /api/Users/{id}
Request Body:

{
  "username": "jane_doe_updated",
  "password": "new_hashed_password",
  "email": "jane.doe.updated@example.com",
  "role": "Admin"
}


Response:


{
  "userID": 2,
  "username": "jane_doe_updated",
  "email": "jane.doe.updated@example.com",
  "role": "Admin",
  "createdAt": "2024-12-05T12:34:56Z"
}



DELETE /Users/{id}
Delete a user by ID.


Request:


DELETE /api/Users/{id}

{
  "message": "User deleted successfully."
}
Authentication
Currently, this API does not include authentication..

Error Handling
The API will return appropriate HTTP status codes for each response.

200 OK: Successful request.
201 Created: Resource successfully created.
400 Bad Request: Invalid request data.
404 Not Found: The requested resource does not exist.
500 Internal Server Error: An unexpected error occurred on the server.

Swagger: For API documentation and testing.
