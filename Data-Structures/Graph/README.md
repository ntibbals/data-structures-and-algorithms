# Graph

### Challenge

- Create a Graph Class that includes a AddNode() method, AddEdge() method, GetNodes() method, GetNeighbors() method, and GetSize() method.

- The time efficiency of the AddNode method is O(1) as it will add the Node directly to the list within the Graph. The space efficiency is O(1) as we are only adding one node within the Graph each instance.

- The time efficiency of the AddEdge method is O(1) as it will add the Edge directly to the list within the Graph. The space efficiency is O(1) as we are only adding one edge in between two given nodes within the Graph each instance.

- The time efficiency of the GetNodes method is O(n) as it will traverse every Node wtihin the graph. The space efficiency is O(n) as we are instantiating a new List which is the entirety of the nodes within the graph.

- The time efficiency of the GetNeighbors method is O(n) as it will iterate over each edge connected to the given vertex. The space efficiency is O(n) as we are instantiating a new List with the given edges.

- The time efficeincy of the GetSize method is O(1) as we are simply grabbing a property of the graph. The space efficiency is O(1) as we are not instantiating any additional memory.

- The time efficiency of the BreadthFirst traversal is O(n) as it will traverse at most, every node within the graph. The space efficiency is O(n) as we are instantiating additional memory to hold an ordered list of the nodes visited.

### Visual (BreadthFirst)

![SCREENSHOT](https://github.com/ntibbals/data-structures-and-algorithms/blob/master/Data-Structures/Graph/whiteboard.JPG)