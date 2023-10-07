# TikTakToe_CSharp
Possibility the play tik tak toe in the browser.

## What does it do?

The application opens on port 5010 in http and https a page with a playing field and an information about the game state.

### What technologies did I use?
- For **styling** I used [bootstrap 5](https://getbootstrap.com/docs/5.0/getting-started/introduction/) because it has a nice, basic library to customize your website page.
- As **framework** [ASP.NET Core](https://learn.microsoft.com/en-us/aspnet/core/introduction-to-aspnet-core?view=aspnetcore-7.0) with its MVC web application was a good decision in case of reliability, speed and its cross platform features.
- To **store to data** of a game I simply make a use of the [.NET IO](https://learn.microsoft.com/en-us/dotnet/standard/io/) library to temporarily store its information in a textfile.

### Challenges

+ I had to first find my way with the [MVC-model](https://www.geeksforgeeks.org/mvc-design-pattern/) and try things out:
  + For example the [IActionResult](https://learn.microsoft.com/en-us/aspnet/core/web-api/action-return-types?view=aspnetcore-7.0) functions in a controller
  + ... the embedding of dependencies to elements of the [razorpage](https://learn.microsoft.com/en-us/aspnet/core/razor-pages/?view=aspnetcore-7.0&tabs=visual-studio) and a model property to interact with the player
  + At first find a way to hold ot store a object trough out the runtime although a controller and actions can't store a object

## Installation

In a IDE like ***Visual Studio*** or ***JetBrains Rider*** you should can start it manual with the start button.

+ To start it from the command line / terminal open a terminal inside the project directory and enter the following command:
```
dotnet run 
```
  + that will run the application locally.
+ When you want to start from everywhere:
  + open a terminal and enter this command:
  ```
  dotnet run --project /C/example/TikTakToe_Game.sln
  ```

After you started the solution you should see something like this in your browser:
![example of the game field and main page](/TikTakToe_Game/pictures/Screenshot 2023-10-07 at 17.52.02.png)
