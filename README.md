# TwentyFourDaysIn.StazorPages.Heartcore

A very simple implementation [StazorPages](https://github.com/emmanueltissera/stazorpages) and [StazorPages.Heartcore](https://github.com/emmanueltissera/stazorpages.heartcore) for an article published on [https://24days.in/umbraco-cms](https://24days.in/umbraco-cms).

This sample allows for the creation of static HTML pages using [ASP.NET Core 5.0](https://docs.microsoft.com/en-us/aspnet/core/release-notes/aspnetcore-5.0) with [Umbraco Heartcore](https://umbraco.com/products/umbraco-heartcore/).

## Prerequisites

* Visual Studio 2019 version 16.8.2 or higher
* ASP.NET Core 5.0

## Getting Started

Once you have cloned this repo, complete the following steps:

### With Visual Studio 2019

* Open the solution with `TwentyFourDaysIn.StazorPages.Heartcore.sln`.
* In Solution Explorer, right-click the solution and select `Restore NuGet Packages`.
* Run the solution using `IIS Express` 

### With .NET Core CLI

* Switch to the root of your cloned project
* Run the project using `dotnet run --project TwentyFourDaysIn.StazorPages.Heartcore\TwentyFourDaysIn.StazorPages.Heartcore.csproj`

## Sample Pages

Once the solution is running, you can visit the following URLs on your local machine and see corresponding static files created inside `AppData\Pages` folder.

### Running with IIS Express

* [https://localhost:44340/cafes/melbourne-cbd/](https://localhost:44340/cafes/melbourne-cbd/)
* [https://localhost:44340/cafes/sydney/](https://localhost:44340/cafes/sydney/)

### Running with Kestrel

* [https://localhost:5001/cafes/melbourne-cbd/](https://localhost:5001/cafes/melbourne-cbd/)
* [https://localhost:5001/cafes/sydney/](https://localhost:5001/cafes/sydney/)

For other cafe page URLs, visit [Lord Lamington's cafe listing](https://lordlamingtonheartcore.azurewebsites.net/cafes/).


## Contributing
Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change.

## License
[MIT](https://choosealicense.com/licenses/mit/)