# Backend netcoreapp3.1

Basic Authentication (username: user, password: pass)


Run project in Visual Studtio, IIS Express
https://localhost:44380/ or

"dotnet run" console command in project directory
https://localhost:5001/

```
POST: 
https://localhost:44380/company/create
```
```
POST: 
https://localhost:44380/company/search 
(Auth not needed)
```
```
PUT:
https://localhost:44380/company/update/{id}
```
```
DELETE:
https://localhost:44380/company/delete/{id}
```
Additional:

GET:
```
https://localhost:44380/company 
```
or
```
https://localhost:44380/company/{id}
```
