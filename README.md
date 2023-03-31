## US National Parks API

#### By Asia Kaplanyan

## Technologies Used

* C#
* .NET
* ASP.Net
* Entity Framework

## Description

An API for US National Parks exploration.

## How To Run This Project

### Install Tools

Install the tools that are introduced in [this series of lessons on LearnHowToProgram.com](https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c).

If you have not already, install the `dotnet-ef` tool by running the following command in your terminal:

```
dotnet tool install --global dotnet-ef --version 6.0.0
```

### Set Up and Run Project

1. Clone this repo.
2. Open the terminal and navigate to this project's production directory called "Parks".
3. Within the production directory "Parks", create two new files: `appsettings.json` and `appsettings.Development.json`.
4. Within `appsettings.json`, put in the following code. Make sure to replacing the `uid` and `pwd` values in the MySQL database connection string with your own username and password for MySQL. For the LearnHowToProgram.com lessons, we always assume the `uid` is `root` and the `pwd` is `epicodus`.

```json
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=parks_api;uid=[YOUR-USER-NAME];pwd=[YOUR-PASSWORD];"
  }
}
```

5. Within `appsettings.Development.json`, add the following code:

```json
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft": "Trace",
      "Microsoft.AspNetCore": "Information",
      "Microsoft.Hosting.Lifetime": "Information"
    }
  }
}
```

6. Create the database using the migrations in the Parks API project. Open your shell (e.g., Terminal or GitBash) to the production directory "Parks", and run `dotnet ef database update`. You may need to run this command for each of the branches in this repo. 
    - To optionally create a migration, run the command `dotnet ef migrations add MigrationName` where `MigrationName` is your custom name for the migration in UpperCamelCase. To learn more about migrations, visit the LHTP lesson [Code First Development and Migrations](https://www.learnhowtoprogram.com/c-and-net-part-time/many-to-many-relationships/code-first-development-and-migrations).
7. Within the production directory "Parks", run `dotnet watch run --launch-profile "Parks-Production"` in the command line to start the project in production mode with a watcher. 
8. To optionally further build out this project in development mode, start the project with `dotnet watch run` in the production directory "Parks".
9. Use your program of choice to make API calls. In your API calls, use the domain _http://localhost:5000_. Keep reading to learn about all of the available endpoints.

## Testing the API Endpoints

You are welcome to test this API via [Postman](https://www.postman.com/), [curl](https://curl.se/), or [the ASP.NET Core MVC frontend "Parks Client"](https://github.com/asyakap/ParksClient.Solution) create to work with this API. 

If you want to use the Parks Client, an ASP.NET Core MVC application, follow the setup instructions in the README of [this repo](https://github.com/asyakap/ParksClient.Solution). 

### Available Endpoints

```
GET http://localhost:5000/api/parks/
GET http://localhost:5000/api/parks/{id}
GET http://localhost:5000/api/parks/page/{page} - Further Exploration 
POST http://localhost:5000/api/parks/
PUT http://localhost:5000/api/parks/{id}
DELETE http://localhost:5000/api/parks/{id}
```

Note: `{id}` is a variable and it should be replaced with the id number of the park you want to GET, PUT, or DELETE. For GET .../page/{page}, {page} indicates the page number you wish to view. 

#### Optional Query String Parameters for GET Request

GET requests to `http://localhost:5000/api/parks/` can optionally include query strings to filter or search parks. For example:

| Parameter   | Type        |  Required    | Description |
| ----------- | ----------- | -----------  | ----------- |
| name        | String      | not required | Returns parks with a matching name value |


The following query will return all parks with the name "Olympic":

```
GET http://localhost:5000/api/parks?name=Olympic
```

As a part of the further exploration, pagination was implemented in this project. All parks entries were broken down into pages with 2 parks on each page. The following query will return the second page with 2 parks on it:

```
GET http://localhost:5000/api/parks/page/2
```

You can include multiple query strings by separating them with an `&`:

```
GET http://localhost:5000/api/parks?name=Olympic&location=Washington
```

#### Additional Requirements for POST Request

When making a POST request to `http://localhost:5000/api/parks/`, you need to include a **body**. Here's an example body in JSON:

```json
    {
      "name": "Olympic National Park",
      "location": "Olympic Peninsula, Washington",
      "description": "This park on the Olympic Peninsula includes a wide range of ecosystems from Pacific shoreline to temperate rainforests to the glaciated alpine peaks of the Olympic Mountains, the tallest of which is Mount Olympus.",
      "interestingFacts": "The Hoh and Quinault Rainforests are the wettest areas in the contiguous United States, with the Hoh receiving an average of almost 12 ft (3.7 m) of rain every year.",
      "popularSights": "The Hoh Rainforest, Hurricane Ridge, Lake Crescent."
    }
```

#### Additional Requirements for PUT Request

When making a PUT request to `http://localhost:5000/api/park/{id}`, you need to include a **body** that includes the park's `parkId` property. Here's an example body in JSON:

```json
    {
      "parkId": 11,
      "name": "Olympic National Park",
      "location": "Olympic Peninsula, Washington",
      "description": "This park on the Olympic Peninsula includes a wide range of ecosystems from Pacific shoreline to temperate rainforests to the glaciated alpine peaks of the Olympic Mountains, the tallest of which is Mount Olympus.",
      "interestingFacts": "The Hoh and Quinault Rainforests are the wettest areas in the contiguous United States, with the Hoh receiving an average of almost 12 ft (3.7 m) of rain every year.",
      "popularSights": "The Hoh Rainforest, Hurricane Ridge, Lake Crescent."
    }
```

And here's the PUT request we would send the previous body to:

```
http://localhost:5000/api/park/1
```

Notice that the value of `parkId` needs to match the id number in the URL. In this example, they are both 1.

## Known Bugs

* No known issues.

## License
Enjoy the site! If you have questions or suggestions for fixing the code, please contact me!

[MIT](https://github.com/git/git-scm.com/blob/main/MIT-LICENSE.txt)

MIT License Copyright (c) 2023 Asia Kaplanyan
 Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
