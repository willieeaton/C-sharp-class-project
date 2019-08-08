# Overview

Each project builds on the previous, so it's essential that each one is completed successfully.

### Prerequisites

- `.net core sdk` - [Download](https://github.com/SamirBanjanovic/SamirBanjanovic.CodeLouisville.CSharp.Projects.Docs.git)
- `Git` - [Download](https://git-scm.com/downloads)
- ??? `Visual Studio` - [Download](https://visualstudio.microsoft.com/vs/community/)
  - ??? Download appropriate version for your OS
- __Optional__ - A Git UI 
    - GitKraken  - [Download](https://www.gitkraken.com/git-client)
    - GitHub Desktop (macOS, Windows) - [Download](https://desktop.github.com/)
# Project summaries

### Project 1:
- Creating a new `Console` application
- Introduction to `classes`
- Introduction to handling `user input`
- Introduction to `nuget packages`
  - Wonder if need to cover this now?

### Project 2:
- Git branching ??? Super important but how indepth do we need to be?
- User input validation - `?`
- Introduction to `loops`
- Introduction to `Collections`

### Project 3:
- Saving input to a file (json)
- Loading objects from a file (json)
- Updating objects from a file (json)


# Project 1

In this project we will create a simple application that prompts the user for input fields to populate a student object.  When the input is complete we will display the information back to the user in a nicely formatted grid. ??? Maybe introduce them to the project on day 1, even if its just here is the project you will be working on in the next few weeks?

- Create a new `Console` application and name it `[YourName].CodeLou.ExcerciseProject`
- ??? Thoughts on using the ole one project and having several branches technique?

`dotnet new console -n [YourName].CodeLou.ExcerciseProject`

- Create a new `class` and name it `Student` - make sure it's in the `Student.cs` file
- ??? Maybe have this class created 
- Add the following `properties` to your `Student` class
    - `StudentId` as `integer`
    - `FirstName` as `string`
    - `LastName` as `string`
    - `ClassName` as `string`
    - `StartDate` as `DateTime`
    - `LastlassCompleted` as `string`
    - `LastClassCompletedOn` as Datetime
