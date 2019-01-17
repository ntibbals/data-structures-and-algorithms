# Find K-th From the End

# Challenge

- Given a variable of k, write a method that takes in k as a parameter and returns the node's value that is k from the end of the linked list.

# Big O

- The time efficiency of this method is O(n- k) as you traverse the list twice. However, the second traversal is up the the value of k.

- The space efficiency is O(1) as we are not creating anything new.

# Insights

- We first created a solution that simply found the position of k from the end in the linked list. I then refactored the second while loop to run based on the initial count of the list, less variable count which then counts down until we've reach the node we are looking to capture the value of.

# Visuals
![WHITE-BOARD](https://github.com/ntibbals/data-structures-and-algorithms/blob/master/Challenges/Ll_kth_from_end/whiteboard.png)
![SCREENSHOT](https://github.com/ntibbals/data-structures-and-algorithms/blob/master/Challenges/Ll_kth_from_end/screenshot.PNG)