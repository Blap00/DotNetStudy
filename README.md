# DotNetStudy

# Guide to create a new App
<code>
- dotnet new console --name="NameAPP" 
- cd "NameApp"
- dotnet build
</code>

We started with 
<code>
- dotnet new mvc --name=mvcApp
- dotnet buld
- dotnet run
</code>
This 'code' gave us the run app url it gave me; 
<code>
PS C:\Users\56941\Dropbox\PC\Documents\GitHub\DotNetStudy\mvcApp> dotnet run
Compilando...
info: Microsoft.Hosting.Lifetime[14]
      Now listening on: https://localhost:7289
info: Microsoft.Hosting.Lifetime[14]
      Now listening on: http://localhost:5289
info: Microsoft.Hosting.Lifetime[0]
      Application started. Press Ctrl+C to shut down.
info: Microsoft.Hosting.Lifetime[0]
      Hosting environment: Development
info: Microsoft.Hosting.Lifetime[0]
      Content root path: C:\Users\56941\Dropbox\PC\Documents\GitHub\DotNetStudy\mvcApp\
</code>

Over LaunchSettings.json it were
<code>
{
  "iisSettings": {
    "windowsAuthentication": false,
    "anonymousAuthentication": true,
    "iisExpress": {
      "applicationUrl": "http://localhost:4208",
      "sslPort": 44330
    } // This SSL PORT IS THE PORT OF IISExpress
  },
  "profiles": {
    "mvcApp": {
      "commandName": "Project",
      "dotnetRunMessages": true,
      "launchBrowser": true,
      "applicationUrl": "https://localhost:7289;http://localhost:5289", //I change there to; localhost:5001;localhost5000
      "environmentVariables": {
        "ASPNETCORE_ENVIRONMENT": "Development"
      }
    }, //The profile ones is for Developer purpose
    "IIS Express": {
      "commandName": "IISExpress",
      "launchBrowser": true,
      "environmentVariables": {
        "ASPNETCORE_ENVIRONMENT": "Development"
      }
    }
  }
}
</code>