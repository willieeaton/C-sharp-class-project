# Overview

Each project builds on the previous, so it's essential that each one is completed successfully.

### Prerequisites

- `.net core sdk` - [Download](https://github.com/SamirBanjanovic/SamirBanjanovic.CodeLouisville.CSharp.Projects.Docs.git)
- `Git` - [Download](https://git-scm.com/downloads)
- __Optional__ - A Git UI 
    - GitKraken  - [Download](https://www.gitkraken.com/git-client)
    - GitHub Desktop (macOS, Windows) - [Download](https://desktop.github.com/)
# Project summaries

### Project 1:
- Creating a new `Console` application
- Introduction to `classes`
- Introduction to handling `user input`
- Introduction to `nuget packages`
#

### Project 2:
- Git branching
- User input validation - `?`
- Introduction to `loops`
- Introduction to `Collections`
#

# Project 1

In this project we will create a simple application that prompts the user for input fields to populate a student object.  When the input is complete we will display the information back to the user in a nicely formatted grid.

- Create a new `Console` application and name it `[YourName].CodeLou.ExcerciseProject`

`dotnet new console -n [YourName].CodeLou.ExcerciseProject`

- Create a new `class` and name it `Student` - make sure it's in the `Student.cs` file
- Add the following `properties` to your `Student` class
    - `StudentId` as `integer`
    - `FirstName` as `string`
    - `LastName` as `string`
    - `ClassName` as `string`
    - `StartDate` as `DateTime`
    - `LastlassCompleted` as `string`
    - `LastClassCompletedOn` as Datetime
