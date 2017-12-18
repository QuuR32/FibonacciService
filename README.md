# FibonacciService
LemonWay Challenge WebService

Hey there,
I just finished your challenge.
Here are few steps to follow in case of emrgency. If those don't help, feel free to send me a message at quurnet@gmail.com
```
1) Clone or download the project

2) Open the solution "FibonacciService.sln"
  Let's see if the solution compiles : press Ctrl+Maj+B
        It compiles         -->    Great! You can jump straight to the section (4)
        You get errors      -->    Don't panic! Just follow the steps in section (3)

3) I'm using the Newtonsoft.Json package, you can install it from the NuGet Package Manager, it's easy

First let verify your "packages.config" file
Open the "packages.config" file of the "FibonacciService" project
Spot the line [<package id="Newtonsoft.Json" version="10.0.3" targetFramework="net35" />]
Delete the line, we'll reinstall the package from scratch
Save the file (Ctrl+S)
    
  3.2) In the visual studio menu, click "Tools"
  3.3) Then "NuGet Package Manager" > Manage NuGet Packages for Solution
  3.4) Search for "Newtonsoft.Json" in the "Browse" section
  3.5) On the right side, check the "FibonacciService" and "WindowsFormsApp1" projects
  3.6) Click "Install" right below
  3.7) That should install it for your, try recompile the solution to see
  3.8) If you still have an error at this point --> quurnet@gmail.com
  
4) Now you can run my WebService.
  4.1) Right click on the "Service.asmx" file in the "FibonacciService" project and click "Set as Start Page"
  4.2) Run the solution (Ctrl+F5)
  4.3) A web page "Service Web Service" should open
```
Now the web service is running, you can try to set "ConsoleApp1" as startup project and run it, it should display a
console window and after 2 seconds display "55" [fibonacci(10)].
You can do the same with the "WindowsFormsApp1" project for more features.

Hope that will suit you. Let me know if you have any question, I'll be happy to answer them...
