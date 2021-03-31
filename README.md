# Flunt Extensions for ASP.NET
This package add some extensions for your ASP.NET application to easy handle Flunt notifications.

### Flunt
Flunt is a fluent way to use Notification Pattern with your entities, concentrating every change you made and easy accessing it when you need.


| Package |  Version | Downloads |
| ------- | ----- | ----- |
| `Flunt.Extensions.AspNet` | [![NuGet](https://img.shields.io/nuget/v/Flunt.Extensions.AspNet.svg)](https://nuget.org/packages/Flunt.Extensions.AspNet) | [![Nuget](https://img.shields.io/nuget/dt/Flunt.Extensions.AspNet.svg)](https://nuget.org/packages/Flunt.Extensions.AspNet) |


### Dependencies
* .NET 5.0
* ASP.NET MVC 2.0.0
* Flunt 2.0.3

### Instalation
This package is available through Nuget Packages: https://www.nuget.org/packages/Flunt.Extensions.AspNet


**Nuget**
```
Install-Package Flunt.Extensions.AspNet
```

**.NET CLI**
```
dotnet add package Flunt.Extensions.AspNet
```

## How to use
```csharp
public class MyRequest : Notifiable<Notification>
{
    public string Name { get; set; }

    public MyRequest(string name)
    {
        AddNotifications(
            new Contract<Notification>()
                .Requires()
                .IsNotNull(name, "Name", "Name cannot be null")
        );
    }
}

[HttpGet]
public Task<IActionResult> Get([FromBody] MyRequest request)
{
    // Using the ModelState Extension will add
    // all notifications to your ModelState
    ModelState.AddNotifications(request.Notifications);
}

```

## About the Art
All logo, icons, colors and fonts were provided with love by Gregory Buso