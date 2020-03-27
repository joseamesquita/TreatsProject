# _C# Advanced Databases and Authentication_

#### _03.27.2020_

#### By _**Jose Amesquita**_

## Description

_This C# web application was designed to help market our friend Pierre's Sweet and Savory Treats. The purpose of this application is to demonstrate user authentication and represent many-to-many relationship. This application will allow the user to create an account through the website and be able to login into their account to navigate through Pierre's Sweet and Savory Treat. Hope you enjoy!_

## Setup/Installation Requirements

1. visit https://github.com/joseamesquita/VendorOrder.git
2. click the green button: Clone or download 
3. select copy and open terminal from your desktop
4. on terminal browse to your desktop: cd Desktop
5. type: 'git clone https://github.com/joseamesquita/TreatsProject.git'
6. type: 'code .' to view all source code on Visual Studio Code
7. within the directory on the terminal type 'dotnet restore' to run the program
8. within the directory on the terminal type 'dotnet ef database update' to run the program
9. within the directory on the terminal type 'dotnet run' to run the program
10. open a browser and copy and paste ```http://localhost:5000/ or http://localhost:5001/``` from the terminal. 
11. if you would like to application to stop running type ```Ctrl + C```

## Specs

Behavior | Input | Output
--- | --- | ---
program displays home page with the ability to create an account | select create account | return page with authentication | 
user selects register | user inputs their email, password, confirm password | return page with successfully registered and prompts to home page | 
user select all treats | user selects add new treats and selects add to cart | returns options of one treat with selected flavors as well |
user select all flavors | user selects add new flavors and selects add to cart | returns options of one flavor with selected treats as well |


## Known Bugs

_This application is under-developed and is currently improving._

## Support and contact details

_Please reach out to me if you have any questions or any concerns with this application. email: joseamesquita11@gmail.com_

## Technologies Used

* C#
* _Git_
* _VSCode_
* _MVC_
* _.NET Core 2.2_ 
* _Enitity Core Framework_
* _MySQL_

### License

*This is licensed by MIT.*

Copyright (c) 2016 **_Jose Amesquita_**