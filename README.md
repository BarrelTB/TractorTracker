# Tractor Tracker -- Tracktor
### Purpose:
To organize and manage agriculture equipment status, maintenance, as well as relational location and employee assignment. 

### Application:
A traditional MVC application built on .Net Core, integrated with Entity Framework for DB transactions and Migrations as well as AutoMapper for object-object mapping needs to reduce code redundancy and object field-field matching.

### Architecture:
Currently a simple layered architecture consisting of the following:
#### Solution
1. Core - DB Transaction, and Business Logic live here
2. Application - Data Transfer Objects and standard service operations live here
3. Web - Controllers and Views live here
#### Database
SQL Database run on localhost, managed mostly by EntityFramework

### In Development:
1. Expanding services and models to meet base needs
2. Building out UI Views to meet business needs of equipment management.
3. Implementing Repositories where necessary for advanced DB transactions.
4. Stored Procedures for overall data pull/tracking

### In the future:
1. Advanced/true authentication (OAuth, JWT, 2FA, or other)
2. Implement multiple access roles and authorization
