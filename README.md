# WolffGoals

# App Instructions

### run "dotnet install" so all the proper packages are downloaded

### Enter "dotnet run" in the terminal

### Open a new terminal and enter "httprepl https://localhost:{PORT}"
-Fill the port section with the first localhost port shown after running "dotnet run" in the other terminal

### httprepl allows the user to interact with the app with the following commands
-"ls" will show all Controllers available

-"cd {CONTROLLER}" will show all routes and functionality available with that controller. e.g. "cd Goal"

-Once in a controller you can interact with it by typing the following commands
* "get" (This will return all goals)
* "get {ID}" (This will return the goal with specified ID. e.g. "get 2"
* "post -c "{"content": "{GOAL NAME HERE}", "isComplete": {BOOL}}"" (This will greate a goal in the database) e.g. "post -c "{"content": "Mow the lawn", "isComplete": false}""
* "put 3 -c "{"id": {DESIRED GOAL ID},"content": "{UPDATE GOAL NAME}", "isComplete": {BOOL}}"" (This will find the existing goal and update it) e.g. "put 3 -c "{"id": 3,"content": "Mow the back lawn", "isComplete": false}""
* "delete {ID}" (This will find the goal with the specified ID and delete it from the database) e.g. "delete 3"

### In order to unit test simply run "dotnet test" and everything in the "TestClass.cs" file will execute

This should properly demonstrate CRUD functionality with a unit test.
