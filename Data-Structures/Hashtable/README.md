# Hash Table

### Challenge

- Create a Hash Table Class that includes a hash method, add method, get method and contains method.

- The time efficiency of the Hash method  is O(n) as it wil iterate through the length ofthe key. THe space efficiency is O(1) as we are only creating an integer for a key.

- The time efficiency of the Add method  without a collision is O(1) as it will add the value at the index of the given key. If a collision occurs, it will be an O(n) in order to place the key value pair within the correct node. THe space efficiency is O(1) as we are only adding a key value pair within one position in the table.

- The time efficiency of the Get method  without a key located in one of the collided linked lists is O(1) as it will retrieve the value at the index of the given key. If it is a key located at a collided position, it will be an O(n) in order to find the key value pair within the correct node. The space efficiency is O(1) as we are not adding any additional memory.

- The time efficiency of the Contains method  without a key located in one of the collided linked lists is O(1) as it will return true or false if it exists. If it is a key located at a collided position, it will be an O(n) in order to find the key value pair within the correct node. The space efficiency is O(1) as we are not adding any additional memory.

### Visual
![SCREENSHOT]()
