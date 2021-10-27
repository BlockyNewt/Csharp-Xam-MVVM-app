# Csharp Xam MVVM app

A simple communications app using C# and Xamarin to allow cross platform between Apple and Android devices. I utilized the C# prism framework and MVVM (Model View Viewmodel) design when creating this app.

Mechanics in the app
1. Login
3. Account creation
4. Relays account creation information to server to check if account name and or email address is already in use before creation
5. While logged in it pings the server and back to the device to check if you are still connected. If not it logs you out from the server side and will reconnect when device is connected again.
6. Adding profile image
7. Adding profile bio
8. Adding other users to favorites list for finding the people you need to message quickly
9. Sending links
10. Changing the apps language between English and Japanese
11. Database is used with the server when collecting and sending data to the client side.
