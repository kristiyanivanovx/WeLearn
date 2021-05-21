# WeLearn

Repository for the WeLearn project.
The idea is for it to be a platform where everyone can share their self-made lectures/lessons and learn from the other ones available.
Primary focus is on students in primary/secondary school and respectively, their teachers. 

The application has the following functionalities and characteristics:
- Administrator user role, only select few are in it and can moderate a large part the contents, regardless if particular one is their creation or not.
- Posts -> creating, reading, updating, deleting
-- Every post has files (as zip), video material, category and appropriate grade attached to it that can be changed
- Comments -> creating, reading, updating, deleting
- Reports (comment reports and post reports) -> creating, reading, updating, deleting

Technologies used:
- ASP.NET Core 5
- C#
- Entity Framework Core
- Microsoft SQL Server 
- PostgreSQL
- AutoMapper
- Hangfire
- Cloudinary
- Plyr 
- HTML5, CSS3, Bootstrap 4
- JavaScript, jQuery
- Git, GitHub
- Heroku
- Docker

Some of the (many) resources used for creating this project:
- https://stackoverflow.com/a/59860450/13146140
- https://stackoverflow.com/questions/55832888/how-to-create-drop-down-list-from-database-in-asp-net-core-mvc
- https://www.youtube.com/watch?v=Bmm9X-YZtG4
- https://www.youtube.com/watch?v=5iN1jhr6yQI&t=8311s
- https://alexcodetuts.com/2019/05/22/how-to-seed-users-and-roles-in-asp-net-core/

Structure influenced by:
- https://github.com/NikolayIT/ASP.NET-Core-Template
- https://www.youtube.com/watch?v=hD6RI0J4mt0

# Deployed Version
- https://welearn-bg.herokuapp.com/

# Contact Info
- Private message me on Facebook or LinkedIn, we can exchange information like mobile phone numbers or emails there

# LinkedIn 
- TBA

# How to use 
- Navigate around, create new lessons, reports, comments and moderate them through the administration.

## User Credentials: Administrator
- Username: welearnbg@gmail.com
- Password: admin_Pass123%
– Email: welearnbg@gmail.com

## User Credentials: Regular user
- Username: Username
- Password: User_qwerty_1234%
- Email: default@gmail.com

# Installation Instructions

## PostgreSQL
1. Follow the link and pick the version that suits your OS: https://www.postgresql.org/download/
2. You need to create an user and a database with the following credentials:
- Port: 5432
- Database: WeLearn
- Username: postgres
- Password: root

## Windows / Mac
1. Install/Update Visual Studio 2019 Community, latest edition - https://visualstudio.microsoft.com/downloads/
2. Add the module "ASP.NET and web development"
3. Additional modules than may be required ".NET desktop development", ".NET Core cross-platform development"

# Linux (Tested on Manjaro)
1. Pick your IDE / code editor of choice or install Visual Studio Code - https://code.visualstudio.com/
2. Make sure to install the following modules ...

## Run thsese commands inside /src/
dotnet restore
dotnet build
dotnet run
