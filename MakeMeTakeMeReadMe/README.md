<h1 align='center'><img width='900' height='450' src='https://coding-assets.s3-us-west-2.amazonaws.com/backgrounds/factory.solution.background6.jpg'><br>


**<h1 align = 'center'>a title**


*<h2 align ='center'>THIS IS MY VERY PUNNY TAGLINE*


<h3 align ='center'>•<a href='#requirements'> Requirements</a> •<a href='#setup'> Setup</a> •<a href='#technologies-used'> Technologies</a> •<a href='#❤️contributors'> Contributors</a> •<a href='#known-bugs'> Bugs</a> •<a href='#app-settings'> AppSettings</a> •<a href='#database-with-migrations'> Database</a> •<a href='#postman-api-requests'> API</a></h3>


<h3 align='center'>about section right here this is the place you need to put text so it looks like you know what you are doing this should be a little longer so I will type some more.</h3>

# **REQUIREMENTS**

_[Postman](https://www.postman.com/)_

_[Visual Studio Code](https://code.visualstudio.com/)_

_[MySql Workbench](https://www.mysql.com/products/workbench/)_

_[.Net Core v2.2](https://dotnet.microsoft.com/download/dotnet-core/2.2)_

# **SETUP**

# **APP SETTINGS**

**You need to update your username and password in the appsettings.json file.**

_By default these are set to user:root and an empty password. If you are unsure, refer to the settings for your MySqlWorkbench._

![appsettings](https://coding-assets.s3-us-west-2.amazonaws.com/img/app-settings.png)

<br>

<br>

# **POSTMAN API REQUESTS**

## TO GET AN ITEM

* Open Postman

* Set your request to type 'GET'

* http://localhost:5000/api/items/ (for index of all)

* http://localhost:5000/api/items/id (for specific item details)

* Hit Send

## TO ADD AN ITEM

* Open Postman

* Set your request to type 'POST'

* http://localhost:5000/api/items/

* Select Body Tab

* Select Raw Radio Button

* Select JSON from dropdown

* Write your addition to the database in the following format

<br>

``{itemId: 1, itemName: 'Mark', itemDate: '8/13/2020', itemDetails: 'big''}``

* Hit Send

## TO EDIT AN ITEM

* Open Postman

* Make a GET request for the id you wish to edit

* http://localhost:5000/api/items/id

* You can select the returned item data and paste that into your request body section for editing.

* Once you have completed your edits.

* Set your request to Put

* Hit Send

## TO DELETE AN ITEM

* Open Postman

* Set your route in Postman to the id you wish to delete

* Set your request to Delete

* Hit Send

<br>

<br>

# **DATABASE WITH MIGRATIONS**

``cd ProjectName``

``dotnet restore``

``dotnet build``

``dotnet ef database update``

``dotnet watch run``

<br>

<br>

# **TECHNOLOGIES USED**

_[Adobe Photoshop](https://www.adobe.com/products/photoshop.html/)_

_[Javascript](https://developer.mozilla.org/en-US/docs/Web/JavaScript)_

_[CSS](https://en.wikipedia.org/wiki/Cascading_Style_Sheets)_

_[Bootstrap](https://getbootstrap.com/)_

_[MySql Workbench](https://www.mysql.com/products/workbench/)_

<br>

<br>

# **KNOWN BUGS**


_**no bugs as of:** 8/9/2020_

<br>

<br>

# **❤️Contributors**

| [<img src='https://coding-assets.s3-us-west-2.amazonaws.com/linked-in-images/allison-sadin.jpeg' width='160px;'/><br /><sub><b>Allison Sadin</b></sub>](https://www.linkedin.com/in/allison-sadin-pdx/)<br />

| [<img src='https://coding-assets.s3-us-west-2.amazonaws.com/linked-in-images/thomas-glenn.jpeg' width='160px;'/><br /><sub><b>Thomas Glenn</b></sub>](https://www.linkedin.com/in/glennergy/)<br />

| [<img src='https://coding-assets.s3-us-west-2.amazonaws.com/linked-in-images/tristan-emmerson.jpeg' width='160px;'/><br /><sub><b>Tristan Emmerson</b></sub>](https://www.linkedin.com/in/tristan-emmerson/)<br />

<br>

<br>

keyword a keyword 2 keyword three a keyword 4 a keyword 5 k6

<br>

<br>

![alt text][logo]

[logo]: https://img.shields.io/bower/l/bootstrap 'MIT License'