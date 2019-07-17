# Overview

- Pre-reqs
    - Latest `.net core sdk` - [Download](https://github.com/SamirBanjanovic/SamirBanjanovic.CodeLouisville.CSharp.Projects.Docs.git)
    - Your favorite Git tool
        - Git - [Download](https://git-scm.com/downloads)
        - GitKraken  - [Download](https://www.gitkraken.com/git-client)
        - GitHub Desktop (macOS, Windows) - [Download](https://desktop.github.com/)
- Project 1:

    - Creating a new `Console` application
    - Introduction to `classes`
    - Introduction to handling `user input`
    - Introduction to `nuget packages`

- Project 2 [Builds on project 1]:
    - Git branching
    - Extend user input to request correct value `(validation?)`
    - Introduction to `Collections` and `loops`
    - Introduction to `nullable DateTime`



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
