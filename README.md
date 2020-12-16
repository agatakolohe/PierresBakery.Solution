# Pierre's Bakery

<div align="center">
<img src="https://github.com/agatakolohe.png" width="200px" height="auto" >
</div>
<p align="center">Test-Driven Development with C# Independent Project for Epicodus, 12-11-2020</p>
<p align="center"> By Agata Kolodziej</p>

## Description

Seventh independent project for Epicodus to demonstrate my understanding of C# basics, console applications and test-driven development. It is a console application that will prompt the user with a welcome message along with the cost for both bread and pastry offered at Pierre's Bakery. User will be able to specify how many loaves of bread and how many pastries they would like. The application will return the total cost of the order.

## Specifications

<details>
  <summary>Expand Specs</summary>

### Describe: Bread()

| Test                                                      | Expect                           |
| --------------------------------------------------------- | -------------------------------- |
| It will instantiate a Bread object with Bread constructor | public Bread(int breadQuantity); |
| It will calculate bread cost. A single loaf is $5         | BreadCost(1 loaf).ToEqual(5);    |
| It will calculate bread deal cost. Buy 2 get 1 free       | BreadCost(3 loaves).ToEqual(10); |

### Describe: Pastry()

| Test                                                          | Expect                              |
| ------------------------------------------------------------- | ----------------------------------- |
| It will instantiate a Pastry object with Pastry constructor   | public Pastry(int pastryQuantity);  |
| It will calculate pastry cost. One pastry is $2               | PastryCost(1 pastry).ToEqual(2);    |
| It will calculate pastry deal cost. 3 for $5                  | PastryCost(3 pastries).ToEqual(5);  |
| It will calculate pastry cost with deal. 1 for $2 and3 for $5 | PastryCost(7 pastries).ToEqual(12); |

</details>

## Setup/Installation Requirements

##### Software Requirements

1. Internet browser
2. A code editor such as VSCode to view and edit the code
3. .NET or follow along with the Installing .NET instructions to install .NET

##### Open Locally

- Click on the link to my repository: [My Repository](https://github.com/agatakolohe/PierresBakery.Solution.git)
- Click on the green "Code" button and copy the repository URL
- Open your terminal and use the command `git clone REPO URL HERE` into the directory you would like to clone the repository
- Open in text editor to view code and make changes

##### Installing .NET

In order to run the application, please install .NET for your computer to recognize the `dotnet` command.

1. Download [.NET Core SDK (Software Development Kit)](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.106-macos-x64-installer). Clicking this link will prompt a file download for your particular OS from Microsoft.
2. Open the file. Follow the installation steps.
3. Confirm the installation is successful by opening your terminal and running the command `dotnet --version`. The response should be something similar to this:`2.2.105`. This means it was successfully installed.

##### Installing Packages

- Navigate to the Bakery.Tests folder in the command line
- Use the command `dotnet restore`

##### Run Console Application

- Navigate to the Bakery folder in the command line
- Use the command `dotnet build` to compile the code
- Use the command `dotnet run` to execute the compiled code
  - Enter the type of bread, number (int) of loaves, and pasteries you would like to order
  - Enjoy the console application!
  - To exit press Ctrl + C

##### Run Tests

- Navigate to Bakery.Tests folder in the command line
- Use the command `dotnet test` to run tests on all test methods
  - Total tests: 7

## Known Bugs

No known bugs

## Support and Contact Details

If any errors or bugs occur with installation delete both bin and obj folders and follow the Installing Packages and Run Console Application instructions again. Get help or report a bug you have found in the .NET platform at [.NET Support](https://dotnet.microsoft.com/platform/support). Or please email me, <agatakolohe@gmail.com>.

## Technologies Used

- C# 7.3
- .NET Core 2.2
- REPL
- [ASCII Art Generator](https://www.ascii-art-generator.org/)
- VS Code
- GitHub

### License

This software is licensed under the [MIT License](https://choosealicense.com/licenses/mit/).

Copyright (c) 2020 Agata Kolodziej
