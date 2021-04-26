# Getting Started
To run this project you only need to type
```
  npm install in clientapp
  dotnet run in root folder
```

Front-end runs automatically on dotnet run thanks to

```
services.AddSpaStaticFiles(configuration =>
{
  configuration.RootPath = "ClientApp/build";
});
```
## Important note

Through a very busy weekend I couldn't complete whole project, only setup architect of backend and basic for frontend