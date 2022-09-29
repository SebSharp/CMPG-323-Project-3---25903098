# CMPG-323-Project-3---25903098
Architectural Patterns &amp; Web Application

## What is a WebApp?

A Web application (Web app) is an application program that is stored on a remote server and delivered over the Internet through a browser interface. Web services are Web apps by definition and many, although not all, websites contain Web apps. According to Web.AppStorm editor Jarel Remick, any website component that performs some function for the user qualifies as a Web app.

Source: <cite>[https://www.pluralsight.com/guides/how-to-use-gitignore-file](https://www.techtarget.com/searchsoftwarequality/definition/Web-application-Web-app)</cite>

## Project 3
For Prject 3 we were expected to create a WebAppApp and host it on Azure where we are expected to understand architectural patterns as well as pay
specific attention to implementing coding principles and design patterns – aligning to the
requirements of the project.

## How to use the Project
The project can be accessed via this link hosted on Azure: https://25903098project3devicemanagementwebapp.azurewebsites.net/

The user would simply create an account (register), then they are able to view the online database of a Connected Office. This provides the user with a view of devices, zones and categories for this office. Users can then add. remove or edit any of the devices, categories or zones in the connected office.

This is done via API calls, managed by controllers each with their own Repository class and interface. These repositories get instantiated by a Generic repository ensuring that we follow proper design principles.


