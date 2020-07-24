# Pierre's Bakery MVC

#### Latest version date 7/24/2020

#### By Deryck Jackson

## Description

A website for tracking vendors and orders for a faux bakery.

## Specifications

1. **Behavior:** Program will create an object for the vendor class with Name, Desc and a list of orders
    * **Input Example:**
    * **Output Example:** Vendor { Name: Joe, Desc: Joe's mufflers shop, List<Order> {} }

2. **Behavior:** Program will create an object for the order class with Title, Desc, Price and Date
    * **Input Example:**
    * **Output Example:** Order { Title: bread order, Desc: 5 bread, Price: 20, Date: 7/24/2020}

3. **Behavior:** Program will add new orders to associated vendor object it is created on.
    * **Input Example:** *New Order* Joe
    * **Output Example:** List<Order> { OrderObject }


## Setup and Installation

Software Requirements
1. .NET framework
2. A code editor (Visual Studio Code, Atom, etc.)

Acquire The Repo:
1. Click the 'Clone or Download Button
2. Alternately, Clone via Bash/GitBash: `git clone {repo}`

Editting the Code Base:
1. Open the project in your code editor; with Bash, this is done by navigating to the project directory, then `code .`
2. If you wish to run testing, you'll need the testing packages: navigate into the .Tests folder, and run `dotnet restore`

Running the program:
1. To run the program, you'll need to compile the code: `dotnet build`. This will create a compiled application in the bin/ folder.
2. Alternately, you can run the program directly with `dotnet run`.

## Bugs

No bugs

## Tech used

* C#
* ASP.NET MVC

### License

This project is licensed under the [MIT License](https://opensource.org/licenses/MIT).

Copyright (c) 2020 Deryck Jackson
