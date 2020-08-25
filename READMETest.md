<h1 align='center'><img width='900' height='450' src=''><br>


**<h1 align = 'center'>**


*<h2 align ='center'>*


<h3 align ='center'>•<a href='#requirements'> Requirements</a> •<a href='#setup'> Setup</a> •<a href='#technologies-used'> Technologies</a> •<a href='#❤️contributors'> Contributors</a> •<a href='#known-bugs'> Bugs</a> •<a href='#specifications'> Specs</a> •<a href='#cloning'> Cloning</a> •<a href='#postman-api-requests'> API</a></h3>


<h3 align='center'></h3>

# **SPECIFICATIONS**

insert your markdown table from [Markdown Table Generator](https://www.tablesgenerator.com/markdown_tables) right here!

# **REQUIREMENTS**

_[Visual Studio Code](https://code.visualstudio.com/)_

_[MySql Workbench](https://www.mysql.com/products/workbench/)_

# **SETUP**

## **CLONING**

* Copy the repo link as shown in the image below

![cloning](https://coding-assets.s3-us-west-2.amazonaws.com/img/clone.gif 'How to clone repo')

* Paste the link in the field provided by VsCode as thown in the image below

* You will be prompted to open the directory once you have cloned it. Select 'open'

![cloning](https://coding-assets.s3-us-west-2.amazonaws.com/img/clone-github2.gif 'Cloning from Github within VSCode')

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

# **TECHNOLOGIES USED**

_[Javascript](https://developer.mozilla.org/en-US/docs/Web/JavaScript)_

_[CSS](https://en.wikipedia.org/wiki/Cascading_Style_Sheets)_

_[MySql Workbench](https://www.mysql.com/products/workbench/)_

<br>

# **KNOWN BUGS**


_** as of:** _

<br>

# **INSTALL**

## **INSTALLING WITH NODE**


with the root project folder open in your code editor, execute the following in your terminal:

``cd ProjectName``

``npm install``

``npm run build``

<br>

## **INSTALLING WITH DOTNET**


with the root project folder open in your code editor, execute the following in your terminal:

``cd ProjectName``

``dotnet restore``

``dotnet build``

``dotnet watch run``

<br>

# **❤️Contributors**

| [<img src='https://coding-assets.s3-us-west-2.amazonaws.com/linked-in-images/ben-russell.jpeg' width='160px;'/><br /><sub><b>Ben Russell</b></sub>](https://www.linkedin.com/in/ben-russell36/)<br />

| [<img src='https://coding-assets.s3-us-west-2.amazonaws.com/linked-in-images/beverly-potts.jpeg' width='160px;'/><br /><sub><b>Beverly Potts</b></sub>](https://www.linkedin.com/in/beverlypotts/)<br />

| [<img src='https://coding-assets.s3-us-west-2.amazonaws.com/linked-in-images/brittany-lindgren.jpeg' width='160px;'/><br /><sub><b>Brittany Lindgren</b></sub>](https://www.linkedin.com/in/brittanylindgren/)<br />

<br>

<br>

![alt text][logo]

[logo]: https://img.shields.io/bower/l/bootstrap 'MIT License'