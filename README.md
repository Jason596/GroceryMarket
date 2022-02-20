## Grocery Market

The project implements a class library for point-of-sale scanning system
that accepts an arbitrary ordering of products, and calculating the total
price for the products.


### The solution contains 3 projects

- GroceryMart (Console application for execute the class library - main entry)
- PointOfSaleTerminal (Class library)
- PointOfSaleTerminalTests (Tests for class library)


### How to run the console application
When you run console application, it will ask you few question to set up the initial price 
for each product, e.g today's unit price, volume price and quantity for the each product. 

*If you enter value with 0, the following default value will be used.* 

| Product Code | Price |
|--------------| ----- |
| A            | $1.25  each, or 3 for $3.00 |
| B            | $4.25 |
| C            | $1.00  or $5 for a six-pack|
| D            | $0.75 |
---------------------------------

Example 1:
```
Starting the Grocery Market Program...
Please enter the unit price for product A for today.
0

Please enter the volume price for product A (enter as "volume price" format).
0 0

Please enter the unit price for product B for today.
0

Please enter the unit price for product C for today.
0

Please enter the volume price for product C (enter as "volume price" format).
0 0

Please enter the unit price for product D for today.
0
```

Example 2:
```
Starting the Grocery Market Program...

Please enter the unit price for product A for today.
1.5

Please enter the volume price for product A (enter as "volume price" format).
5 2

Please enter the unit price for product B for today.
1 

Please enter the unit price for product C for today.
2

Please enter the volume price for product C (enter as "volume price" format).
3 5

Please enter the unit price for product D for today.
2
```
After setting up the price, you can enter the scanning products as following.
- Currently the system only have 4 product(A,B,C,D)
- enter a or A will work the same
- the application will return the correct final price. 
- and it will ask your if you want continue to scan another products. 
- You can enter "no" to exit the program.
```
Please scan the product...
ccccccc

The products we have scanned are ccccccc
The total grocery price is $6.00

Continue check out, please enter yes/no.
yes


Please scan the product...
```


### Future improvement

- Better error handling 
- Change the price model to be a generic class
- Add method to add new product
 


