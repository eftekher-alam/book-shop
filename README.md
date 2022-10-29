# Documentation of BookShop
This book management project is built using ASP.NET Core, where I have used various server-side validations along with client-side validations. I used "Toastr" for the CRUD completion notification. And the design is taken from the bootswatch.com theme.

## What technologies have been used to create the application?
1. ASP.NET Core 6.
2. Entity Framework Core.
3. MS SQL server.
4. Bootstrap
5. Toastr
6. Code-First approach.

## What are the requirements to run the web application?
Make sure that mentioned below components are installed on your computer.
1. .NET 6 [Download Link](https://dotnet.microsoft.com/en-us/download/dotnet/6.0)
2. SQL Server 2019  [Download Link](https://www.microsoft.com/en-sg/sql-server/sql-server-downloads)
3. Visual Studio 2022 [Download Link](https://visualstudio.microsoft.com/vs/)

## How to run the web application?
1. Open **ExpenseTracker.sln** file with Visual Studio
2. Go to **Build -> Build Solution**
3. Go to **View -> Other Windows -> Package Manager Console**
4. In the **Package Manager** Console run the following command ```update-database``` It will create a new database in the name **eftekher** in your database, if doesn't exist previously.
5. ```Ctrl + F5``` or go to **Solution Explorer -> Views (Expand the folder) -> Home (Expand the folder) -> Index   (Right click) -> View in browser**

## How is the database designed?
<p align="center">
  <img src="Screenshots\0.1_DatabaseDiagram.png" width="820" height="440"><br/>
  <i>0.1 Database Diagram</i>
</p>

- **Database :** The database was designed by the code first approach. Here I have two tables one is Categories and another one is Books. The relation between those tables is One-to-Many. In the Categories table, the primary key is Id (Id is one of the column of the Categories table) on the other hand in the Books table primary key is Id(Id is one of the column of Books table) whereas the foreign key is CategoryId. ( *Screenshot 0.1* )

## what are the features of BookShop web application?
<h2 align="center">Home Page</h2>

<p align="center">
  <img src="Screenshots\1.1_HomePage.png" width="820" height="440"><br/>
  <i>1.1 Home Page</i>
</p>

- **Home :** This is the home page of this web application where the total book, total category, and total book category wise is shown( *Screenshot 1.1* ).

<h2 align="center">Special Feature</h2>

<p align="center">
  <img src="Screenshots\2.6_Notification.png" width="820" height="440"><br/>
  <i>1.2 Notification</i>
</p>

- **Notification :** I used "Toastr" for the CRUD completion notification ( *Screenshot 1.2* ). To know more details about Toastr You can visit [here](https://github.com/CodeSeven/toastr)

<h2 align="center">Book</h2>

<p align="center">
  <img src="Screenshots\2.1_BookList.png" width="820" height="440"><br/>
  <i>2.1 Book Index</i>
</p>

- **Book Index :** The book index page, shows the list of all the books( *Screenshot 2.1* ). There is a special feature that is explained in the later section.

<p align="center">
  <img src="Screenshots\2.2_CategoryWiseBook.png" width="820" height="440"><br/>
  <i>2.2 Category Wise Book List</i>
</p>

- **Category Wise Book List :** If you select a category from the category select list and click the show button then you will see the list of books for the specific category( *Screenshot 2.2* ).

<p align="center">
  <img src="Screenshots\2.3_BookCreate.png" width="820" height="440"><br/>
  <i>2.3 Create Book</i>
</p>

- **Create Book :** On the Book Create View, you can create a new book at a time ( *Screenshot 2.3* ). 

<p align="center">
  <img src="Screenshots\2.3_ClientSideValidation.png" width="820" height="440"><br/>
  <i>2.3 Client-Side Validation</i>
</p>

- **Client-Side Validation :** I have implemented client-side validation. If you give invalid input, before hitting the server side it will give an error on the client side ( *Screenshot 2.3* ). Point to be noted that I also used server-side validation but I explained various special server-side validation only in the later section.

<p align="center">
  <img src="Screenshots\2.4_ServerSideValidation.png" width="820" height="440"><br/>
  <i>2.4 Server-Side Validation</i>
</p>

<p align="center">
  <img src="Screenshots\2.5_ServerSideValidation.png" width="820" height="440"><br/>
  <i>2.5 Server-Side Validation</i>
</p>

- **Server-Side Validation :** If you put the same input in the "Title" and "Author" input fields then it will give you an error message that these two inputs can not be the same ( *Screenshot 2.4* ). Another special feature of the Create View is, you can not record a new book that already exists. If your give a book title that already exists, it will show an error message ( *Screenshot 2.5* ).

<p align="center">
  <img src="Screenshots\2.7_BookEdit.png" width="820" height="440"><br/>
  <i>2.6 Update Book</i>
</p>

- **Update :** On the Book Update View, you can edit a book record at a time ( *Screenshot 2.6* ).

<p align="center">
  <img src="Screenshots\2.8_BookDelete.png" width="820" height="440"><br/>
  <i>2.7 Delete Book</i>
</p>

- **Delete :** You will be able to delete a selected book by the Delete View ( *Screenshot 2.7* ).

## what are the features of ExpenseTracker web application?
<h2 align="center">Category</h2>

<p align="center">
  <img src="Screenshots\3.1_CategoryList.png" width="820" height="440"><br/>
  <i>3.1_Category List</i>
</p>

- **Index :** The category index page, shows the list of all the categories ( *Screenshot 3.1* ).

<p align="center">
  <img src="Screenshots\3.2_CategoryCreate.png" width="820" height="440"><br/>
  <i>3.2 Category Create</i>
</p>

- **Create :** On the Category Create View, you can create a new expense category at a time ( *Screenshot 3.2* ). 

<p align="center">
  <img src="Screenshots\3.3_CategoryEdit.png" width="820" height="440"><br/>
  <i>3.3 Category Edit</i>
</p>

- **Update :** On the Category Update View, you can edit an expense category that already is recorded in database ( *Screenshot 3.3* ).

<p align="center">
  <img src="Screenshots\3.4_CategoryDelete.png" width="820" height="440"><br/>
  <i>3.4 Category Delete</i>
</p>

- **Delete :** Selected category can be deleted here ( *Screenshot 3.4* ).
