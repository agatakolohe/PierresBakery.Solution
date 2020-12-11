# Pierre's Bakery

<div align="center">
<img src="https://github.com/agatakolohe.png" width="200px" height="auto" >
</div>

#### Test-Driven Development with C# Independent Project for Epicodus, 12-11-2020

#### By Agata Kolodziej

## Description

Seventh independent project for Epicodus to demonstrate my understanding of C# basics, console applications and test-driven development. It is a console application that will prompt the user with a welcome message along with the cost for both Bread and Pastry offered at Pierre's Bakery. User will be able to specify how many loaves of bread and how many pastries they would like. The application will return the total cost of the order.

## Specifications

<details>
  <summary>Expand Specs</summary>

### Describe: Bread()

| Test                                                      | Expect                                             |
| --------------------------------------------------------- | -------------------------------------------------- |
| It will instantiate a Bread object with Bread constructor | public Bread(int breadQuantity);                   |
| It will calculate bread cost                              | BreadCost(Single loaf for $5 or Buy 2 get 1 free); |

### Describe: Pastry()

| Test                                                        | Expect                             |
| ----------------------------------------------------------- | ---------------------------------- |
| It will instantiate a Pastry object with Pastry constructor | public Pastry(int pastryQuantity); |
| It will calculate pastry cost                               | PastryCost(1 for $2 or 3 for $5);  |

</details>

## Setup/Installation Requirements

##### Software Requirements

1. Internet browser
2. A code editor such as VSCode to view and edit the code

##### Open Locally

- Click on the link to my repository: [My Repository](https://github.com/agatakolohe/PierresBakery.Solution.git)
- Click on the green "Code" button and copy the repository URL
- Open your terminal and use the command `git clone REPO URL HERE` into the directory you would like to clone the repository
- Open in text editor to view code and make changes

##### Installing REPL

- To install and use REPL open your terminal and use the command `dotnet tool install -g dotnet-script`
- To exit REPL press Ctrl + C

##### Installing Packages

- Navigate to the Bakery.Tests folder in the command line
- Use the command `dotnet restore`

##### Run Console Application

- Navigate to the Bakery folder in the command line
- Use the command `dotnet build` to compile the code
- Use the command `dotnet run` to execute the compiled code
  - Enter the number of loaves and pasteries you would like to order
  - Enjoy the console application!
  - To exit press Ctrl + C

## Known Bugs

No known bugs

## Support and Contact Details

If any errors or bugs occur delete both bin and obj folders and follow the installation instructions again. or please email me, <agatakolohe@gmail.com>

## Technologies Used

- C# 7.3
- .NET Core 2.2
- REPL
- VS Code
- GitHub

### License

This software is licensed under the [MIT License](https://choosealicense.com/licenses/mit/).

Copyright (c) 2020 Agata Kolodziej
