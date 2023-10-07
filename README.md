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

In an IDE like ***Visual Studio*** or ***JetBrains Rider*** you should can start it manual with the start button.

+ To start it from the command line / terminal open a terminal inside the project directory and enter the following command:
```
dotnet run 
```
  + that will run the application locally.
+ When you want to start from everywhere:
  + open a terminal and enter this command:
  ```
  dotnet run --project /your/path/to/TikTakToe_Game.sln
  ```
  + you have to put your own path to the project in the command

After you started the solution you should see something like this in your browser:
![example of the game field and main page](/TikTakToe_Game/pictures/gameFieldExample.png)

## How to use the project?

+ If you don't know how to play TikTakToe then you can look the rules up [here](https://www.thesprucecrafts.com/tic-tac-toe-game-rules-412170)!
+ For more information follow the instruction in the application!

## Credits

The _idea_ to create games like this digital I got from @hoss-green!

### Materials

As I said, I went trough an understanding process and what helped the most was [this](https://www.youtube.com/watch?v=YYjCgsIQr3I) video from Sameer Saini, great video!😁

## License

_MIT License_

_Copyright (c) 2023 **Matti**_
_
Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:_

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
