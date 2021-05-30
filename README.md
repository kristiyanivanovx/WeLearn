# WeLearn

Repository for the WeLearn project.
The idea is for it to be a platform where everyone can share their self-made lectures/lessons and learn from the other ones available.
Primary focus is on students in primary/secondary school and respectively, their teachers. 

## The application has the following functionalities and characteristics:
- Administrator user role, only select few are in it and can moderate a large part the contents, regardless if particular one is their creation or not.
- Posts -> creating, reading, updating, deleting
-- Every post has files (as zip), video material, category and appropriate grade attached to it that can be changed
- Comments -> creating, reading, updating, deleting
- Reports (comment reports and post reports) -> creating, reading, updating, deleting
- Live chat, that is cleaned weekly with Hangfire

## Technologies used
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

## Acknowledgements
Some of the (many) resources used for creating this project:
- https://stackoverflow.com/a/59860450/13146140
- https://stackoverflow.com/a/2776689/13146140
- https://stackoverflow.com/questions/55832888/how-to-create-drop-down-list-from-database-in-asp-net-core-mvc
- https://www.youtube.com/watch?v=Bmm9X-YZtG4
- https://www.youtube.com/watch?v=5iN1jhr6yQI
- https://www.youtube.com/watch?v=gQMT4al2Grg
- https://alexcodetuts.com/2019/05/22/how-to-seed-users-and-roles-in-asp-net-core/

Structure influenced by:
- https://github.com/NikolayIT/ASP.NET-Core-Template
- https://www.youtube.com/watch?v=hD6RI0J4mt0

# Deployed Version
- https://welearn-bg.herokuapp.com/

# Contact Info
- Private message me on Facebook or LinkedIn, we can exchange information like mobile phone numbers or emails there.

# LinkedIn 
- TBA

# How to use 
- Navigate around, create new lessons, reports, comments and moderate them through the administration.
- An user cannot edit and delete another one's comments, reports and lessons if he is not the creator
- The application has live chat functionality, realized with SignalR and websockets. Using Hangfire in production, every week the messages and chats are getting deleted/cleaned, the reason being that we can accumulate a lot of them and they are not that important at all. Another option is for the clean period to be monthly, weekly seems often.

## User Credentials: Administrator
- Username: welearnbg@gmail.com
- Password: admin_Pass123%
- Email: welearnbg@gmail.com

## User Credentials: Regular user
- Username: Username
- Password: User_qwerty_1234%
- Email: default@gmail.com

# Installation Instructions

## External logins
For the Goolge Authentication option to work you need to configure it. Follow the guide:
https://developers.google.com/identity/sign-in/web/sign-in

You need to create new credentials and to change them in the ```/src/WeLearn.Web/appsettings.json``` file and make sure to change this line in ```_Layout.cshtml```- ```<meta name="google-signin-client_id" content="your-client-id-here.apps.googleusercontent.com">```
At the ```Create Credentials > OAuth client ID``` step, in ```Authorized redirect URIs > URIs *``` section add "https://localhost:port/signin-google" and "http://localhost:port/signin-google", where port is the port that you access the webapp from. For example ```44332``` or ```44333```.

Additional information:
https://docs.microsoft.com/en-us/aspnet/core/security/authentication/social/google-logins?view=aspnetcore-5.0

## SendGrid
For the contacts functionality to work, you need to obtain a SendGrid Api Key.
Create your account at https://signup.sendgrid.com/ or use existing one.

From ```Marketing``` select ```Senders``` then ```Create New Sender```
Add a sender and verify it.
Use welearnbg@gmail.com for "Reply To" and "From Email Address".
...or add your own - it is recommended for the "Reply To", "From Email Address" and the email you've registered with all to be identical. In that case, change the email address in ```ContactsController.cs``` to be your own - (await this.emailSender.SendEmailAsync("welearnbg@gmail.com", ...)).

From ```Settings``` select ```API Keys``` then ```Create API Key```
API Key Name - WeLearn
API Key Permissions - Full Access

Copy your key and paste it in SendGrid:ApiKey section of the ```/src/WeLearn.Web/appsettings.json``` file.

## PostgreSQL (detailed explanation below)
1. Follow the link and pick the version that suits your OS: https://www.postgresql.org/download/
2. You need to create an user and a database with the following credentials:
- Port: 5432
- Database: WeLearn
- Username: postgres
- Password: root

## Cloudinary (optional)
### Only needed for when running the app with the Production environment switch on. Skip if you are going to run it in Developmemt only.
1. You need to sign up for Cloudinary (free plan will do just fine) - https://cloudinary.com/users/register/free
2. Copy your ```API Environment variable``` and store it for later

## Windows / Mac
1. Install/Update Visual Studio 2019 Community / Visual Studio for Mac, latest edition - https://visualstudio.microsoft.com/downloads/
2. Add the module "ASP.NET and web development"
3. Additional modules than may be required ".NET desktop development", ".NET Core cross-platform development"
4. Configuring PostgreSQL - download the installer which has a version of 13.3.
- Follow the wizard, when asked about components select the 4 of them (PostgreSQL Server, pgAdmin 4, Stack Builder, Command Line Tools)
- When asked about a password, provide ```root```
- When asked about a port, leave it on ```5432```
- You don't need to proceed with the Stack Builder
- Start pgAdmin 4, create new server - from General set the name to ```postgres```, from Connection set Host name to ```localhost```, set password to ```root``` and click Save
- Click on that server and then Create, after that Database...
- Name the database ```WeLearn``` and click Save

5. Set ```WeLearn.Web``` as a startup project
6. Build the application with Ctrl + Shift + B
7. Run the app with Ctrl + B
8. Trust the certificate

Note: If you are not using Visual Studio, you may need to set an environment variable, use this
```set ASPNETCORE_ENVIRONMENT=Development```

## Linux - Tested on Ubuntu 20.04
1. Pick your IDE / code editor of choice or install Visual Studio Code - https://code.visualstudio.com/
2. Download the source code
3. Run the following commands
```
sudo apt-get update
sudo apt-get upgrade
```
4. Configuring PostgreSQL - run the following commands
```
sudo apt update
sudo apt install postgresql postgresql-contrib
sudo -u postgres createdb WeLearn
sudo -u postgres psql Welearn
\password
root
root
```
5. Make sure to install the .NET 5 SDK (https://docs.microsoft.com/en-us/dotnet/core/install/linux)

6. Run the following commands inside /src/
```
dotnet restore
dotnet build
dotnet publish -c Release
cd WeLearn.Web/bin/Release/net5.0/publish
export ASPNETCORE_ENVIRONMENT=Development
export CLOUDINARY_URL=cloudinary://example:xyz@123456
dotnet WeLearn.Web.dll
```

## Notes
- You can run with ```ASPNETCORE_ENVIRONMENT=Production``` too, but you will need to configure Cloudinary for this one.
- CLOUDINARY_URL is the value we saved earlier.
- For security measures, Cloudinary will not allow us to download the zip files that are getting uploaded, unless the account is permitted to - https://cloudinary.com/documentation/image_delivery_options#blocked_delivery_formats_for_security/.

The app should be running on the address shown in the terminal's output.

For Ubuntu, you may need additional codecs for playing the video files.
