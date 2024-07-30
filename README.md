<!-- 
goal is to create a fullstack webb app for a blog site
backend will be done in .Net 8, web api, EF Core, SQL Server
frontend will be done in react with javascript
deploy with azure static web apps
 -->

 <!-- Create an api for blog, this must handle all crud functions-->

 <!-- 
 CRUD
 Create
 Read
 Update
 Delete
 -->

 <!-- in this app the user should be able to login so we need a login page -->


<!-- create account page, blog page of published items, dashboard page(this is the profile page with edit, delete, publish and unpublish your blog post) -->

<!-- SQL Server from azure for our database -->

<!-- folder structure -->

<!-- controllers//folders
    UserController: this will handle all of your user interactions
    all of our endpoints will be in this controller
 -->


 <!-- Login//endpoints

    AddUser//endpoint
    UpdateUser//endpoint
    DeleteUser//endpoint
  -->

  <!-- BlogController
  
    AddBlogItems//endpoint C
    GetAllBlogItems//endpoint R
    GetAllBlogItemsByCategory//endpoint
    GetAllBlogItemsByTags//
    GetAllBlogItemsByDate//
    UpdateBlogItems//endpoint U
    DeleteBlogItems//endpoint D

   -->


<!------------------------------------------------- Models -------------------------------------------------->

<!-- Model Folder  -->

<!-- UserModel

    id int
    username string
    Salt string
    Hash string

 -->

 <!-- BlogItemModel
 
    id int
    UserId int
    PublisherName string
    Title string
    Image string
    Description string
    Date string
    Category string
    IsPublished bool
    IsDelete bool

  -->

  <!-------------------------- Items that will be saved to our database are above -------------------------------------->

<!--

  LogInModel
    Username string
    Password string

  CreateAccountModel
    Id int
    Username string
    password string

  PasswordModel
    Salt string
    Hash string

 -->

<!-- Services//Folder

    UserService//file
        GetUserByUsername
        Login
        AddUser
        DeleteUser

    BlogItemService
        AddBlogItems
        GetAllBlogItemsByCategory//functions(methods)
        GetAllBlogItemsByTag
        GetAllBlogItemsByDate
        UpdateBlogItems
        DeleteBlogItems
        GetUserById
    
 -->

 <!-- PasswordServices//file

        Hash password

        Very hash password
 
  -->