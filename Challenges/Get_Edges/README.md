# Get Edges

### Challenge

- Create a Method that takes in a graph and an array of city names. Without utilizing any built-in methods, return whether the full trip is possible with direct flights and how much it would cost.

### Big O

- The time efficiency of the method is O(n) as it will need to find all possible edges associated up with the given cities. The space efficiency of the method is O(n) as we are instantiating additional memory to hold the edge and city names as nodes based on graph.
### Visual 

![SCREENSHOT](https://github.com/ntibbals/data-structures-and-algorithms/blob/master/Challenges/Get_Edges/whiteboard.JPG)

### Insights

- I changed my code in building out two helper nodes to utilizes in my get neighbor methods to determine if any possible edges exist with the given combinations of the two cities. I ran into a blocker when I determined my GetNeghbor method is not only built off of the vertices, a necessary Graph property needs to be associated with the given Node/Vertex in order to find the edge. I need to either refactor my get neighbor method within my graph or find a way to associate up the given property with the node upon creation but ran out of time debugging.