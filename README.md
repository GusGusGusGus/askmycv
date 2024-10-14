# AskMyCV App 

## AI powered Job Board 🤖💼🚀🛠️ 

### Features: 
- User profiles with Description, Looking For, Interests, Photo Gallery and Messages
- Paged Users' List with Filters
- Paged Job Posts List with Filters
- Members I like / Members who like me Lists
- Details Edit page
- Login/Logout User
- Register new User
- Email confirmation and password reset
- Messages List
- User Online Notifications
- Instant message chat - AI POWERED
- Client cache for improved performance
- 3 Different user Roles: Admin, Moderator and Member
- Admin area to manage user permissions (WIP: manage photos)
- Much more to come!...


## [Live demo coming soon]()


### Client: 
*Angular 18* 🅰️
### Server: 
*.Net 7* #️⃣
### ORM: 
*Entity Framework Core* 🦄
### DB: 
*PostgreSQL* 🐘

### Development Notes: 
Install pgAdmin or some other DBMS to manage PortgreSQL locally
Install docker desktop for your OS and run a docker postgres image in your machine with the command:
`docker run --name askmycv-local-dev -e POSTGRES_USER=YourPostgreSQLUser -e POSTGRES_PASSWORD=YourPostgresPasswordHere -p 5432:5432 -d postgres:latest`
In the API project's root, reate an appsettings.Development.json file and add the connection string to the postgres container:
` "ConnectionStrings": {  "DefaultConnection": "Server=localhost; Port=5432; User id=YourPostgreSQLUser; Password=YourPasswordHere; Database=yourDBName" } `
as well as your Sendgrid Email Server Key: 
` "SendGridKey": "verySecretKeyHere", "SupportEmail": "yourOwnServiceEmail@yourDomain.com", `
and the baseUrl for your client on dev:
` "BaseUrl": "https://localhost:4200/", `
and respective copies on your production settings.


### Deployment Notes: 
For the client, run `ng build --configuration production` to generate the dist folder. 
My instance is deployed to AZURE. Create an account and login locally. 
Create respective azure resources.
Publish app. (TO DO)
Push: `git push origin main`


### Post-Deployment Notes: 
(TO DO)


