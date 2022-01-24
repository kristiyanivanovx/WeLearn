# WeLearn

Repository for the WeLearn project.
The idea is for it to be a platform where everyone can share their self-made lectures/lessons and learn from the other ones available.
Primary focus is on students in primary/secondary school and respectively, their teachers. 

## Functionalities and characteristics
- Administrator user role, only select few are in it and can moderate a large part of the contents, regardless if particular one is their creation or not - creating, reading, updating, deleting (soft and hard deletion).
- Lessons - creating, reading, updating, deleting, reporting, sending to email. Every lesson has files (in a zip archive), video material, category and appropriate grade attached to it that can be changed. There is an option for the lesson to be sent to a particular email address using SendGrid. An lesson is not publicly accessible through "View all" and "All categories" if it hasn't been approved by the administrators. Users can soft delete their lessons, but hard deletion option is given to administrators only.
- Comments - creating, reading, updating, deleting, reporting. Comments are related to a particular lesson. Users can soft delete their comments, but hard deletion option is given to administrators only.
- Reports - creating, reading, updating, deleting. An user can report a comment or a lesson. Users can soft delete their reports, but hard deletion option is given to administrators only.
- Live chat using SignalR, it is cleaned automatically every month with Hangfire.
- Contact us page with email sending functionality realized using SendGrid.

## Technologies used
- .NET - C#, ASP.NET Core MVC, Entity Framework Core, SignalR, ML.NET
- PostgreSQL (Microsoft SQL Server in earlier development)
- AutoMapper
- Hangfire
- SendGrid
- Cloudinary
- Plyr 
- HTML5, CSS3, Bootstrap 4, SB Admin 2
- JavaScript, jQuery, luxon
- Git, GitHub
- Heroku
- Docker

## Deployed version
- https://welearn-bg.herokuapp.com/

## Deployment strategy
- Docker is used for containerization. The resulting images are pushed to Heroku. Server used is Kestrel.

## Docker
- To build the docker image, execute ```docker build -t app .``` inside ```/src/```.
- To run the docker image, execute ```docker run -p 80:80 -it app``` inside ```/src/```.

## How to use 
- Navigate around, create new lessons, reports, comments and moderate them through the administration.
- An user cannot edit and delete another one's comments, reports and lessons.
- The application has live chat functionality, realized with SignalR and websockets. Using Hangfire, every month the messages and chats are getting deleted/cleaned - the reason being that we can accumulate a lot of them and they are not that important.

### User credentials: Head Admin role
- Username: HeadAdmin
- Password: admin_Pass123%
- Email: welearnbg@gmail.com

### User credentials: Admin role
- Username: RegularAdmin
- Password: User_qwerty_1234%
- Email: default@gmail.com

### User credentials: Teacher role
- Username: Peter85
- Password: Peter_1234_#pass
- Email: peter.856@gmail.com

### User credentials: User
- Username: #todo
- Password: #todo
- Email: #todo

## Installation instructions

### External logins
For the Goolge Authentication option to work you need to configure it.

* In the Credentials page of the Google console (https://console.developers.google.com/apis/credentials), after creating an project, select ```CREATE CREDENTIALS``` > ```OAuth client ID```.
* In the Application type dialog, select ```Web application```. Provide a ```Name``` for it.
* In the Authorized redirect URIs section, select ```ADD URI``` to set the redirect URI. Example redirect URIs: https://localhost:{PORT}/signin-google, http://localhost:{PORT}/signin-google, where the {PORT} placeholder is the application's port.
Select the CREATE button.
* Save the Client ID and Client Secret for use in the app's configuration - ```/src/WeLearn.Web/appsettings.json```.
* Make sure to change this line in ```_Layout.cshtml``` - ```<meta name="google-signin-client_id" content="your-client-id-here.apps.googleusercontent.com">``` to include your Client Id.

Additional information and documentation:
https://docs.microsoft.com/en-us/aspnet/core/security/authentication/social/google-logins?view=aspnetcore-5.0
https://developers.google.com/identity/sign-in/web/sign-in

### SendGrid
For the email sending functionality to work, you need to obtain a SendGrid Api Key and create a Sender.
Create your account at https://signup.sendgrid.com/ or use existing one.

From ```Marketing``` select ```Senders``` then ```Create New Sender```.
Use the email you registered with for "Reply To" and "From Email Address" - all three of them need to be identical. 
Save that sender and verify it.
Change the ```ApplicationAdministratorEmail``` value in ```WeLearn.Common/Constants.cs``` to be your own.

From ```Settings``` select ```API Keys```, then ```Create API Key```

|  API Key Name   | API Key Permissions |
|:---------------:|:-------------------:|
| Your Key's Name |     Full Access     |

Copy your key and paste it in SendGrid:ApiKey section of the ```/src/WeLearn.Web/appsettings.json``` file.

### PostgreSQL (detailed explanation below)
1. Follow the link and pick the version that suits your OS: https://www.postgresql.org/download/
2. You need to create an user and a database with the following credentials:
- Port: 5432
- Database: WeLearn
- Username: postgres
- Password: root

### Cloudinary (optional)
#### Only needed for when running the application with the Production environment switch on. Skip if you are going to run it in Developmemt only.
1. You need to sign up for Cloudinary (free plan will do just fine) - https://cloudinary.com/users/register/free
2. Copy your ```API Environment variable``` and store it for later

### Windows / Mac
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
7. Run the application with Ctrl + F5
8. Trust the certificate

Note: If you are not using Visual Studio, you may need to set an environment variable, use this
```set ASPNETCORE_ENVIRONMENT=Development```

### Linux - Tested on Ubuntu 20.04
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
sudo -u postgres psql WeLearn
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

### Training your own recommendations model with ML.NET
1. Make sure you have some users and these users have liked moderate amount of lessons with one or more users.
2. Open the ```/src/Services/WeLearn.Services.Data/ExportDataService.cs``` class. Change the test data (step ```3.```) to reflect your version of the data. ```(UserId <=> LessonId)```
3. In a terminal, change your directory to ```/src/Services/WeLearn.Services.Data/``` and type ```dotnet run```. Couple of things happen:
   - The data is exported to an ```csv``` file (step ```1```) in the ```/src/Services/WeLearn.Services.Data/Data/``` directory. 
   - The Machine Learning model for recommendations is trained and exported (step ```2```). 
   - Some test data is set up to test what recommendations would the model give (step ```3```).
   - The model is being tested. It shows what recommendations it would give based on past likings of lessons (step ```4```).

The results I've got on my development machine. Score is the likeliness for that user to find the lesson interesting.
With more data, the predictions will be better, more certain.

<img src="./documents/ML-Generated-Recommendations.png">

Now you've exported some data, trained a Machine Learning model and got some data. Great!
For training models using the web application's user interface, something a bit different is done.
Using HangFire, every day the data is exported to an csv file, and then the model is trained over that data. 

### Training your own recommendations model with ML.NET - User interface version with HangFire
1. Run the application - the ```WeLearn.Web``` project.
2. After it has started up, log in with the administrator account and visit the ```http://localhost:5000/hangfire/recurring``` page.
3. Run/trigger the ```GetLikesInformationJob``` job. In the ```/WeLearn.Web/Data/``` directory, a new file is created - ```UsersInLessons.csv```.
4. Run/trigger the ```TrainRecommendationModelJob``` job. In the ```/WeLearn.Web/Data/``` directory, a new file is created - ```WeLearnLessonsModel.zip```.

Now, every time you check your recommendations you will see the lessons that are most likely to pique your interest.
By default he data is collected every hour, and the model is trained once a day.

### Notes
- You can run with ```ASPNETCORE_ENVIRONMENT=Production``` too, but you will need to configure Cloudinary for this one.
- ```CLOUDINARY_URL``` is the value we saved earlier (optional).
- ```CLOUDINARY_URL``` is the value we saved earlier (optional).
- For security measures, Cloudinary will not allow us to download the zip files that are getting uploaded, unless the account is permitted to. Contacting support service is required. - https://cloudinary.com/documentation/image_delivery_options#blocked_delivery_formats_for_security/.

The application should be running on the address shown in the terminal's output.

For Ubuntu, you may need additional codecs for playing the video files.

## Acknowledgements
Some of the many resources used for creating this project:
- https://stackoverflow.com/a/59860450/13146140
- https://stackoverflow.com/a/2776689/13146140
- https://stackoverflow.com/a/48599532/13146140
- https://stackoverflow.com/questions/55832888/how-to-create-drop-down-list-from-database-in-asp-net-core-mvc
- https://www.youtube.com/watch?v=Bmm9X-YZtG4
- https://www.youtube.com/watch?v=5iN1jhr6yQI
- https://www.youtube.com/watch?v=gQMT4al2Grg
- https://www.youtube.com/watch?v=Hy9G30nncMM
- https://alexcodetuts.com/2019/05/22/how-to-seed-users-and-roles-in-asp-net-core/
- https://stackoverflow.com/a/57440303/13146140
- https://www.softwaredeveloper.blog/multi-project-dotnet-core-solution-in-docker-image
- https://www.youtube.com/watch?v=msRJdf5AfoI
- https://www.xsprogram.com/content/multiple-radio-button-groups-in-mvc-4-razor.html
- https://www.youtube.com/watch?v=dluB5VE1m1k
- https://github.com/NikolayIT/ArtificialIntelligencePlayground/tree/master/ML.NET/Recommendation/SoftUniCoursesRecommendation
- https://www.w3schools.com/howto/howto_css_custom_checkbox.asp

Structure influenced by:
- https://github.com/NikolayIT/ASP.NET-Core-Template
- https://www.youtube.com/watch?v=hD6RI0J4mt0

## Credits

Videos, images from https://pexels.com and https://unsplash.com
- Login, register forms/pages - https://colorlib.com/wp/template/login-form-15/
- Chat design - https://codepen.io/FilipRastovic/pen/pXgqKK & https://youtu.be/fCpw5i_2IYU