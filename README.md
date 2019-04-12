# Don't Wine About It
#### *Author: Andrew Curtis*

## Description

This is an ASP.NET Core web app that uses the MVC architectural pattern. The app models a website of a fictitious wine shop called "Don't Wine About It" and is designed to assist customers in finding the perfect wine. 

The app reads from a data source in the form of a CSV file that contains data on wines such as country of origin, description, point rating, and price. It then uses LINQ to query and filter the data based on the desired wine price and rating input by the user and then outputs the results that match the user's search onto a separate page view. 


## Running This App on Your Computer

To run this app yourself, clone this repository to your local machine.
```
$ git clone https://github.com/amjcurtis/Lab10_MVC.git
```

#### To run the program from Visual Studio:
Select `File` -> `Open` -> `Project/Solution`

Next navigate to the location where you cloned the repository.

Select and open `Lab10_MVC.sln`


## Visuals

***[Visuals forthcoming]***

##### Home Page View
![Image 1]()

##### Wine Results View
![Image 2]()


## Change Log

##### v1.1

`2019-03-29`: Built out class structure based on converted JSON, added comments/pseudocode for planning

`2019-04-01`: Wrote code to read and deserialize JSON; wrote LINQ queries; added basic UI

`2019-04-11`: Finish controller, method for reading CSV and filtering and rendering results for user; add further styling.

## Attribution

Andrew Roska ([Roketsu86](https://github.com/Roketsu86)) showed me how to read in a CSV file in a single elegant query using System.File and LINQ. He also pointed me to the .Skip() and .Take() methods. 
