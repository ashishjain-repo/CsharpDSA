# Create ASP.NET Core MVC Project
TO create a empty project for ASP.NET Core MVC, we have to run this command: `dotnet new mvc` we can use other options to tell the sdk to where to create the file, but this will just create the project in the present working directory.

# Running the project
We can run the project in many ways and with different available commands. We can look for the specific configured commands for the build in the `Properties` folder which `contains launchsettings.json`. In this file you can find http and https versions that we can use to run. Tu run one of those version we can specify using this command `dotnet run --launch-profile [version]`.

# Project Directory Structure
`bin` folder contain the file that are generated during the build that helps the project run. `Controllers` folder contains that files that help you control the project, so whenever a request is made that request goes through the files in the controller folder. This controller is also used to redirect to the requested pages or getting the result that is being requested. Whenever that page is request there is a methods that contains all the logic and return the views to the client. `Models` folder contains the file that are classes that contains the bits of data that we wants for our application, and it also interacts with Database to get that data.