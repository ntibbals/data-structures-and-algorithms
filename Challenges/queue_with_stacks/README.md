# Queue with Stacks

# Challenge

- Create a PseudoQueue class that will implement the standard queue interface but will internally only utilize 2 Stack objects. Create a enqueue(value) method which inserts a value into PseudoQueue using FIFO. Create a dequeue() method which extracts a value from PsqeudoQueue using FIFO as well.

# Big O

- The both the time and space efficiency of Enqueue(value) is O(1) as it will always add a value to the top of the stack.

- The time efficiency of Dequeue is O(h). The algorithm will traverse the height of the stack in order to identify the proper node to dequeue. During this process, it may utilize another stack to pop and push with however, the additional stack is a constant thererfore rather than O(2h), it is simply O(h).

# Insights

- We first had a difficult time identifying what approach to take as you can do utilize both stacks on either the Enqueue method or the Dequeue method. We needed some additional refactoring while coding in order to account for the push/pop from one stack BACK into the original stack.

# Visuals
![WHITE-BOARD]()
