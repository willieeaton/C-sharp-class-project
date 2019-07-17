# Overview

- Pre-reqs
    - Ensure all students have installed `.net core sdk` since guidance through command line is easier
    - Ensure students understand Git
- Project 1:
    - Creating a new `Console` application
    - Introduction to `classes`
    - Introduction to handling `user input`
- Project 2 [Builds on project 1]:
    - Git branching
    - Extend user input to request correct value `(validation?)`
    - Introduction to `Collections` and `loops`
    - Introduction to `nullable DateTime`



# Project 1

In this project we will create a `Student` class with a basic set of properties.
- Create a new `Console` application 
    - Name it `[YourName].CodeLou.ExcerciseProject`
        - Using command line (macOS, Linux, Winows):    
        `dotnet new console -n [YourName].CodeLou.ExcerciseProject`
        - Visual Studio Windows:
            `File > New > Project > Console Application`

            __Screen shot of VS__

    
- Create a new `class` and name it `Student` in a `Student.cs` file
- Add the following `properties` to your `Student` class
    - `StudentId` as `integer`
    - `FirstName` as `string`
    - `LastName` as `string`
    - `ClassName` as `string`
    - `StartDate` as `DateTime`
    - `LastlassCompleted` as `string`
    - `LastClassCompletedOn` as Datetime
