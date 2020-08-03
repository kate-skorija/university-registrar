# _University Registrar_

#### _C# ASP.NET Core MVC and EF Core practice for Epicodus, 08.03.2020_

#### By _**Brittany Lindgren & Kate Skorija**_


## Description

_Welcome administrators! Use this application to keep track of students and courses._ 

## Specifications

| Behavior   |   Input   |  Output |  Met? (Y/N)  |
|----------|:-------------:|------:|-----------:|
| Program should add a student to the database along with their date of enrollment | student: Tim, doe: Nov 12th 2020 | Table: Students, Column1: StudentId = 1, Column2: StudentName = Time, Column3: DateOfEnrollment = Nov 12th 2020 | N |
| Program should add a course to the database along with a course number | course: Coding 101, number: CS101 | Table: Courses, Column1: CourseId = 1, Column2: CourseName = Coding 101, Column3: CourseNumber = CS101 | N |
| Program should associate a student to a course | Tim, Coding101 | Table: CoursesStudents, Column 1: CoursesStudentsId = 1, Column2: StudentId = 1, Column3: CourseId = 1, Column 4: Course Object, Column 5: Student Object | N |


## Stretch Goals
| Behavior   |   Input   |  Output |  Met? (Y/N)  |
|----------|:-------------:|------:|-----------:|



## Setup/Installation Requirements

  1. Follow this [link to the project repository](PUT LINK HERE) on GitHub.  
  2. Click on the "Clone or download" button to copy the project link.     
  3. If you are comfortable with the command line, you can copy the project link and clone it through your command line with the command `git clone`. Otherwise, I recommend choosing "**Download ZIP**".     
   4. Once the ZIP file has finished downloading, you can right click on the file to view the zip folder in your downloads.     
  5. Right click on the project ZIP folder that you have just downloaded and choose the option "**Copy To...**", then choose the location where you would like to save this folder.      
  6. Navigate to the final location where you have chosen to save the project folder.      
  7. To view the code itself, right click, choose **open with...** and open using a text editor such as VS Code or Atom, etc.
  8. Once you are inside of your text editor, open the terminal. If you are in VS Code for example, this can be done by clicking on `Terminal` at the top of the editor and then selecting `New Terminal`. **You can navigate to different directories in the project by typing `cd DirectoryName` to go down into specific directories or `cd ..` to go back up one directory. 
  9. Navigate to the DIRECTORYNAME directory by typing `cd Restaurant` in your terminal and hitting `enter`. Then type the command `dotnet restore`,`dotnet build`, then `dotnet run` into your terminal and hit enter. You should see files appear inside of your bin folder. The bin folder should appear greyed out. 
  10. Click on the link provided after you see `now listening on: ... ` appear in your terminal.


#### Additional Setup/Installation Notes:

* You will need to configure the MySQL Workbench database in order to run this project. See directions directly below.   
* Do not alter the bin/ or obj/ directories or any of the files in them.

#### Configure the MySQL Workbench Database:
* Install MySQL and MySQL Workbench first. During installation of MySQL you will be asked to create a password. This is important! Take note of your password. Once you have installed MySQL and MySQL Workbenck, start MySQL by entering `mysql -uroot -p+_yourpassword_` in the terminal. Example: password is `tomato`, enter `mysql -uroot ptomato`. If this doesn't work in your terminal, try using your computer's command line interface application. If you are successful, you will see a message in the terminal, ending with the line `mysql>`. Once you have succesfully completed these steps, follow the instructions below.
1. Open MySQL Workbench and double click on the grey box under the line `MySQL Connections` (this box should say `mamp` and have some text and numbers ending in `:3306`). This will launch the MySQL Workbench. You may be prompted to enter the same password that you used in the previous step (ex: `tomato`). 
2. You should see an icon in the upper left that looks like a little piece of paper with the letters `SQL` and a + sign. Hover over the icon and confirm that this is the 'create a new SQL tab for executing queries' icon. Once confirmed, double click the icon.
3. Enter the following (excluding the ``` at the beginning and end of the code) text into the window for the SQL File tab.

``` SQL HERE ```

4. Click 'execute' (this may appear as a lightening bolt icon).

## Known Bugs

| Bug : Message |  Situation  | Resolved (Y/N) |  How was the issue resolved?  |
| ------- | ----- | ------ | ------- |


## Support and contact details

_Please feel free to contact the authors through GitHub (LINDGRENBA, kate_skorija) with any feedback, questions or concerns._


## Technologies Used

* C#
* .NET-Core 2.2
* ASP.NET Core MVC
* Visual Studio Code
* Git Version Control
* GitHub


### License

*This site is licensed under the MIT license.*

Copyright (c) 2020 **_{Brittany Lindgren & Kate Skorija}_**