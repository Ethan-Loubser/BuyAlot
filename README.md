INDEX
1.	App description
2.	Instructions on Operating system
3.	Types and versions of programs used
4.	Instructions on using the application
5.	Error handling
6.	Bibliography
7.	Sample data

1 App description
BuyAlot is an e-commerce application on which users can buy or add various products.

2 Operating System
The BuyAlot application is written only for the Android OS.

3 Types and versions of programs used
-	Emulator used = Pixel 5 – API 33 (Android 13.0 – API 33)
-	Visual Studio 2022
-	Adobe Photoshop 2020
-	SQLite (Visual Studio addon)
-	SQLite.Net (Visual Studio addon)

4 Instructions on using the Application
  1.	Create account
    1.1.	Upon executing the application, user will be met with the “LogInPage”. If the user does not already have an account, they must first tap on the “Create account” button.
    ![image](https://github.com/user-attachments/assets/bd9bc5cf-73d0-4228-bb08-09cc482c109b)

    1.2.	This will direct them to the “CreateAccountPage”, which includes six Textboxes in which the user must enter the specified details.
    1.3.	Once all textboxes have been filled out the user can tap on the “Create Account” button to create an account. The user will be notified upon successful creation of the account and will then be redirected back to the “LogInPage”.
    ![image](https://github.com/user-attachments/assets/aa6a3373-9c2e-4b7f-a23f-23e079fe6d03)

  2.	Log in
    2.1.	User can enter their created Email address and password in the “Email” and “Password” Textboxes on the “LogInPage”.
    ![image](https://github.com/user-attachments/assets/be088fde-772d-4e24-ba7d-5e624cf754d7)

    2.2.	They may then proceed to tap on the “LogIn” button, which will validate their entered email address and password. Upon successful validation the user will be directed to the “buyAlotHubPage”, which is the main page.
    ![image](https://github.com/user-attachments/assets/6962b8b4-208d-4824-a5cf-5b98fc870436)

  3.	Add product
    3.1.	On the “buyAlotHubPage”, user can click on the “Add Product” button, which will direct them to the “AddProductPage”.
    3.2.	On the “AddProductPage”, user will be presented with six textboxes, one of which are the read only “Product ID” texbox.
    3.3.	User must enter the details of the product to be added in the specified textboxes.
    3.4.	Afterwards the user may tap on the “Add Product” button to add the product to the buyAlot product database.
    ![image](https://github.com/user-attachments/assets/29037ae0-cee0-44cb-803b-c4a9499fc36d)

  4.	View products
    4.1.	On the “buyAlotHubPage”, user can click on the “View Products” button.
    ![image](https://github.com/user-attachments/assets/9ab3d16b-a024-45f2-a952-d3d43f17cf0d)

    which will direct them to the “ProductHubPage”.
    ![image](https://github.com/user-attachments/assets/01b7683f-85fa-4d1e-9156-a2bb3448c54d)

    4.2.	On the “ProductHubPage”, user will be met with the “Hot categories” section, which includes popular categories.
    ![image](https://github.com/user-attachments/assets/2c8330c9-10c0-437a-8906-c7c4b8525a4c)

    4.3.	User can tap on one of the “Hot categories” which will direct them to the “CatProductsPage”, displaying the products within the chosen category.
    ![image](https://github.com/user-attachments/assets/cac30e88-505c-4d82-ba6a-de9ba4854d6c)

    4.4.	User can also tap on the “Show All” button on the top-right of the “Hot categories” section, which will direct them to the “CategoriesPage”.
    ![image](https://github.com/user-attachments/assets/6759b180-7f7a-47c5-af08-167440c01c4d)

    4.5.	On the “CategoriesPage” the user will be presented with the different Categories of products available on the buyAlot application. Tapping on one will direct them to the “CatProductsPage”, which will display the products within the chosen category.
    ![image](https://github.com/user-attachments/assets/65b14d24-55a9-4b28-a246-77538ea21432)

    4.6.	Each product can slide to the left which will expose a “Delete” button, to delete the product from the buyAlot database.
    ![image](https://github.com/user-attachments/assets/d0affb93-6b97-41bb-9dfd-771de0f0e5dc)

    4.7.	Tapping on one of the products will direct the user to the “ProdDetailPage” where they will be met with an “Add to cart” button.
    ![image](https://github.com/user-attachments/assets/2f24b1f7-0b97-4f0c-b54f-895bab0d4e90)

    4.8.	Tapping on the “Add to cart” button will add the selected product to the cart of the logged in user. 

    4.9.	Right below the “Hot Categories” section on the “ProductHubPage” is the “Recommended products” sections, which displays various popular products on which the user can tap. This will also direct them to the “ProdDetailPage”.
    ![image](https://github.com/user-attachments/assets/2edd3d49-c900-48e6-9e8a-31d1f60a05c3)

    4.10.	Alternatively, the user may use the Search bar at the top of the “ProductHubPage”.
    ![image](https://github.com/user-attachments/assets/380a5f43-8789-4de7-a1fb-079433635f5f)

    which will direct them to the “SearchPage”, where they can search for specific products.
    ![image](https://github.com/user-attachments/assets/e34a73c1-c109-42ad-9287-5fe33cca4f74)

    4.11.	User can also access the “SearchPage” by tapping on the “All Products” button in the flyout menu.
    ![image](https://github.com/user-attachments/assets/b87460c5-2038-498a-b428-d584673961db)

  5.	View Cart
    5.1.	On the “buyAlotHubPage”, user can tap on the “View Cart” button.
    	![image](https://github.com/user-attachments/assets/39f9242e-7c15-423f-8a41-86944b17fd6c)

     this will direct them to the “CartPage”, where they can view the items they have added to their cart.
      ![image](https://github.com/user-attachments/assets/f043f5ee-504b-4ea5-8488-8acc4265302a)

    5.2.	On the “CartPage”, user can swipe products to the left to expose a “Remove” button, which can be used to remove products from the cart.
    ![image](https://github.com/user-attachments/assets/5f990c10-e455-4967-ab76-b32b5b7ef938)

  6.	Log out
    6.1.	User can tap on the “Log out” button in the flyout menu, which will log them out and direct them back to the “LogInPage”.
    ![image](https://github.com/user-attachments/assets/4ccb845a-0259-461c-b9fa-2b4221f40846)

5 Error handling
-	Sometimes upon initial execution of the application a bug might occur where a user will be directed to the “CreateAccountPage” instead of the “buyAlotHubPage” when tapping on the “Log In” button.
The fix for this bug, is to stop debugging and then restart it.

-	When looking for products using the search bar or categories, the products might not always load as soon as the page appears.
If this happens the page has to be refreshed, to do this tap and hold at the top of the page and slide down as you would on a mobile device.

