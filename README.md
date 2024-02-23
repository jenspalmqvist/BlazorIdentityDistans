# BlazorIdentity

Filer vi �ndrat i det h�r projektet:

Server:

Program.cs <- Lagt till BlazoredSessionStorage och UserService som builder.Services
Data/ApplicationUser.cs <- Lagt till en property f�r att koppla �hop Items med v�r user
Data/UserService.cs <- Ny fil, inneh�ller metoder som l�ter oss spara �ndringar i v�r user
Models/Item.cs <- Ny fil, inneh�ller en klassdefinition f�r Item
Components/Pages/ItemsPage.razor <- Ny fil, inneh�ller inputf�lt och logik f�r att l�gga till nya Items i v�r ApplicationUser.Items

Client:

Program.cs <- Lagt till BlazoredSessionStorage
Models/ClientItem.cs <- Ny fil, inneh�ller en definition f�r hur vi vill att de items vi skickar till Client ska se ut.
Pages/OrderConfirmation.razor <- Ny fil, inneh�ller logik f�r att lyfta ut data om v�ra items och visa upp dem i en lista.