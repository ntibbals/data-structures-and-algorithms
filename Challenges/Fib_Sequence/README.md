# Fibonacci Sequence

#Challenge

- Given an integer, application will return the nth number in the Fibonacci sequence.

#Big O

- The time and space of this method is O(n). This is due to it only iterating through a for loop based on the array we've instantiated based on the input plus one. The given solution is optimized and will do only n steps yet is still exponential.

#Insights

- I first took a recursion approach but after some due diligence identified that the big O was ineffecient. After some more reasearch into concepts like memoization, I found that I could utilize an array based on the golden ratio principles.

#Resources

https://en.wikipedia.org/wiki/Memoization
https://en.wikipedia.org/wiki/Golden_ratio
