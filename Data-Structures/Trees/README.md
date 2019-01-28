# Trees

## Challenge

- Create a Node class that has properties for the value stored in the Node, and a pointer to the next node. Create a Stack class that has a top property. This object should be aware of a default empty value assigned to top. Define a method called push, a method called pop, and a method called peek. Create a Queue class that has a front propety and a rear property. For the Queue class, create a enqueue method, dequeue method and a peek method.

## Approach and Efficiency

- When Push() is applied the time efficiency is O(1) as regardless of the size of the stack, the method will always insert this at the top node. The space efficiency is O(1) as you will always add to the same space regardless of the amount.

- When Pop() is applied the time and efficiency is O(1) because regardless of the size of the stack, the method will always remove the top node. In addition, the space efficiency is O(1) as no additional memory is instantiated.

- The Peak() method has a time and space efficiency as o(1) as it will simply return the top node.

- When Enqueue() is applied the time efficiency is O(1) as regardless of the size of the queue, the method will always insert this at the rear node. The space efficiency is O(1) as you will always add to the same space regardless of the amount.
 
- When Denqueue() is applied the time efficiency is O(1) as regardless of the size of the queue, the method will alwaysremove the front node. The space efficiency is O(1) as no additional memory is instantiated.

- The Peak() method has a time and space efficiency as o(1) as it will simply return the Front node.