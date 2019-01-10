### Binary Search through Array

## Collaborators
- Nate Tibbals
- Carlos Roberto Castillo

## Challenge

- Write a method that takes in a sorted array and a search key. Utilize the search key to create a binary search method to identify where in the array the search key is located. If it is not located on the array, return -1.

## BIG O

- The time and space efficiency of this algorithm is O(log n). The method utilizes a while loop and balances binary search principles to reduce the search in half after each loop.

## White board layout

![SCREENSHOT](https://github.com/ntibbals/data-structures-and-algorithms/blob/master/assets/array_binary_search.JPG)

## Insights

- Once the while loop condition is false, it will break the while loop. As such, the fall safe for if the search key is not located in the array is not necessary in the while loop as depicted above. You can remove the return -1 and then change the final else if statement to simply if.
