the storeperson class is abstract and described as below

there is a single static field that is decorated with the protected modifier

ID - this int field represents the id of the next customer or employee. this is used in the constructor to generate sequential id for  objects. It is initialized to 100_000 at declaration

Properties: 
1. cell -  this string property represents the cell number of this store person
2. name - this string property represents the name of this store person
3. ID - this string property represents the species of this animal

Constructor:
StorePerson(string name, string cell) - takes two arguments and does the following
a. asssigns the arguments to the appropriate properties
b. assigns a string version of the static field ID to the property ID
c. Increments the static field ID

===========================
The customer class inherits from the storeperson classs and is described below
Properties: 
1. credit -  this double property represents the credit limit of this customer. the getter is public and there is no setter.


Constructor:
Customer(string name, string cell, double credit = 500) - takes two arguments and an optional double argument and does the following
a. calls the parent constructor with appropriate arguments
b. assigs the other argument to the appropriate property

Methods:
public override string tostring() - returns a string representing the customer
=================================
The employee class inherits from the storeperson classs and is described below
Properties: 
1. salary -  this double property represents the salary  of the employee. the getter is public and there is no setter.


Constructor:
Employee(string name, string cell, double salary = 2500) - takes two arguments and an optional double argument and does the following
a. calls the parent constructor with appropriate arguments
b. assigs the other argument to the appropriate property

Methods:
public override string tostring() - returns a string representing this employee

=====================================
The store class is described below

all the members of this class are static
there is a single private field
1. people - the List<StorePerson> field represents a colelction of customers and employees associated with this store.

there is a single static Constructor:
Store() as with all static constructors, yuo may not have any arguemnts. the constructor initializes the field people to a collection of 10 customer and employee objects. Customers will have a credit property while employees will have a salary property


Methods:
1. public static void Show() - this method displayes all the objects in the people collection. sample Outoput below
100000 Gokulraj 123-4567 Credit: $500
100001 Amy 123-6789 Salary: $2500

2. public static void Show(string name) - thhis method displayes all the objects in the people collection whose name matches the argument. 

3. public static void Show(int length) - thhis method displayes all the objects in the people collection whose name is longer than the argument. 

4. public static void Show(double amount) - thhis method displayes all the employees in the people collection whose salary exceeds the argument. 

5. public static void Save(string filename) - thhis method will serialize all the objects in the people collection to the specified file. you must use JavaScriptSerializer

=========================================
