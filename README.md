# BlazorIdentity

Filer vi ändrat i det här projektet:

Server:

Program.cs <- Lagt till BlazoredSessionStorage och UserService som builder.Services
Data/ApplicationUser.cs <- Lagt till en property för att koppla ihop Items med vår user
Data/UserService.cs <- Ny fil, innehåller metoder som låter oss spara ändringar i vår user
Models/Item.cs <- Ny fil, innehåller en klassdefinition för Item
Components/Pages/ItemsPage.razor <- Ny fil, innehåller inputfält och logik för att lägga till nya Items i vår ApplicationUser.Items

Client:

Program.cs <- Lagt till BlazoredSessionStorage
Models/ClientItem.cs <- Ny fil, innehåller en definition för hur vi vill att de items vi skickar till Client ska se ut.
Pages/OrderConfirmation.razor <- Ny fil, innehåller logik för att lyfta ut data om våra items och visa upp dem i en lista.



Angående SessionStorage:

När användaren "slutför" sitt köp, skriv in all information som behövs i Client-sidan i SessionStorage med
userId som nyckel, och hämta ut det i Client.