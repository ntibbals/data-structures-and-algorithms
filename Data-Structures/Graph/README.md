# Graph

### Challenge

- Create a Graph Class that includes a AddNode() method, AddEdge() method, GetNodes() method, GetNeighbors() method, and GetSize() method.

#### Approach and Efficiency

- The time efficiency of the AddNode method is O(1) as it will add the Node directly to the list within the Graph. The space efficiency is O(1) as we are only adding one node within the Graph each instance.

- The time efficiency of the AddEdge method is O(1) as it will add the Edge directly to the list within the Graph. The space efficiency is O(1) as we are only adding one edge in between two given nodes within the Graph each instance.

- The time efficiency of the GetNodes method is O(n) as it will traverse every Node wtihin the graph. The space efficiency is O(n) as we are instantiating a new List which is the entirety of the nodes within the graph.

- The time efficiency of the GetNeighbors method is O(n) as it will iterate over each edge connected to the given vertex. The space efficiency is O(n) as we are instantiating a new List with the given edges.

- The time efficeincy of the GetSize method is O(1) as we are simply grabbing a property of the graph. The space efficiency is O(1) as we are not instantiating any additional memory.

- The time efficiency of the BreadthFirst traversal is O(n) as it will traverse at most, every node within the graph. The space efficiency is O(n) as we are instantiating additional memory to hold an ordered list of the nodes visited.

#### Descripton of API

##### AddNode method

- The AddNode() method takes in a vertices and adds the node directly into the graph.

##### AddEdge method

- The AddEdge() method takes in a starting Vertex and an ending vertex along with a weight. The method then adds the edge in between the given vertices.

##### GetNodes Method

- The GetNodes() method retreives all nodes in a given graph.

##### GetNeighbors Method

- The GetNeighbors() method takes in a vertex and finds all conjoining Edges attached to given Vertex. It then returns a list of found Edges.

##### GetSize Method

- The GetSize() method retreives the size of a given graph.

#### BreadFirst

- The BreadFirst() method takes in a given Node within a graph. It then performs a breadth firt traversal based on the the starting point of the node given. It will then return a list of nodes traversed.
### Visual (BreadthFirst)

![SCREENSHOT](https://github.com/ntibbals/data-structures-and-algorithms/blob/master/Data-Structures/Graph/whiteboard.JPG)