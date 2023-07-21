## Freelance Management Web Application and API Documentation

# Introduction
The Freelance Management Web Application is a tool that allows users to manage a list of freelancers. The application includes a frontend built with React, and it communicates with a backend API developed using ASP.NET Core. This document provides an overview of the application's features, API endpoints, and instructions for testing the API using Postman.

# Freelance Management Web Application
The frontend of the Freelance Management Web Application is developed using React, a popular JavaScript library for building user interfaces. It allows users to perform CRUD (Create, Read, Update, Delete) operations on freelancers' data. Here are the key components of the frontend:

# Employee Component (employee.js):

This component displays the list of freelancers in a table.
Users can search for freelancers based on their skillsets using the search bar.
Users can add, edit, and delete freelancers using buttons available in each row of the table.
API Integration:

The frontend communicates with the backend API to fetch, add, update, and delete freelancer data.
Freelance Management API (FreelancerController)
The backend of the Freelance Management Web Application is developed using ASP.NET Core. It provides RESTful API endpoints for managing freelancer data. The FreelancerController handles HTTP requests and interacts with the database to perform CRUD operations. Here are the API endpoints:

# GET /api/Freelancer:

Retrieves all freelancers' data from the database.
Responds with a JSON array containing freelancer details (ID, username, email, phone, skillsets, and hobby).

# POST /api/Freelancer:

Creates a new freelancer in the database.
Expects a JSON object with the following properties: username, email, phone, skillsets, and hobby.
Responds with a message indicating successful creation.

# PUT /api/Freelancer:

Updates an existing freelancer's data in the database.
Expects a JSON object with the following properties: usernameId (ID of the freelancer), username, email, phone, skillsets, and hobby.
Responds with a message indicating successful update.

# DELETE /api/Freelancer/{usernameId}:

Deletes a freelancer from the database based on the provided ID (usernameId).
Responds with a message indicating successful deletion.

# Usage of Postman for API Testing
Postman is a powerful tool that simplifies API testing. It allows you to send HTTP requests and view responses, making it ideal for testing the Freelance Management API. Here's how to use Postman to test the API endpoints:

Install Postman: Download and install Postman from the official website (https://www.postman.com/downloads/) and launch the application.

Import API Requests: Import the API requests provided for testing by following these steps:

Click on the "Import" button in Postman.
Select the "Link" tab and enter the API URL: http://localhost:5260/api/Freelancer
Click "Continue" and then "Import" to add the API requests to Postman.
Testing API Endpoints:

Use the imported requests to test the API endpoints as follows:
Send a GET request to retrieve all freelancers' data.
Send a POST request to create a new freelancer (modify the request body as required).
Send a PUT request to update an existing freelancer (modify the request body as required).
Send a DELETE request with the appropriate ID (usernameId) to delete a freelancer.
Observe Responses: After executing each request, observe the response in the lower part of the Postman window. The responses will indicate whether the operations were successful or if there are any errors.

# Conclusion
The Freelance Management Web Application provides a user-friendly interface for managing a list of freelancers. The React frontend communicates with the ASP.NET Core backend API to perform CRUD operations on freelancer data. By following the instructions for API testing using Postman, developers can ensure that the API functions as expected and deliver a robust and reliable web application for freelance management.
