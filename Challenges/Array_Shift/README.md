### Insert and Shift an Array

# Collaborators
-Carlos Roberto Castillo
-Nate Tibbals

## Challenge

Write a method that takes in an array and a value to be added. Without utilizing any built-in methods, return an array with the new value added at the middle index.

## BIG O

The time and space efficiency of this algorithm is O(n). In C# you cannot alter the size of an existing array and therefore need to create a new array to insert the added variable.

## White board layout

![SCREENSHOT](https://github.com/ntibbals/data-structures-and-algorithms/blob/master/assets/array_shift.JPG)

# Insights

We found we needed to alter the conditional statement within our for loop to identify if the array length is less than the midpoint, insert. If else the array is equal to midpoint, add variable number, then add one to index and insert old array index, else add old array to new array at index plus one.
