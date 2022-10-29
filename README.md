# Documentation of BookShop
This book management project is built using ASP.NET Core, where I have used various server-side validations along with client-side validations. I used "Toastr" for the CRUD completion notification. And the design is taken from the bootswatch.com theme.

## What technologies have been used to create the application?
1. ASP.NET Core 6.
2. Entity Framework Core.
3. MS SQL server.
4. Bootstrap
5. Toastr
6. Code-First approach.

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

- **Notification :** I used "Toastr" for the CRUD completion notification ( *Screenshot 1.2* ). To know more details about Toastr You can visit <a href="https://github.com/CodeSeven/toastr" target="_blank">here</a>.

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
