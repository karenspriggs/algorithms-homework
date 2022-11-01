### Week 8:
This week I learned about different data structures, including arrays, maps, queues, and stacks. I did so by creating an application that reads in data from a text file and stores it in instances of all four of those different data structures. I also included comments that explain what each data structure does, how it works, what the pros and cons are, and how they can be used. 

### Arrays
An array is a data structure with a fixed length, where each element takes up a space that was established in memory when the array was instantiated. 
Arrays can have up to 32 dimensions (layers of arrays within arrays), however the one in the application I wrote is just 1 dimensional. They are more efficient to use than lists, due to their fixed size and "predetermined" spaces for elements. If you want a flexible collection of objects where the size of the collection will change, it is best to use a list instead.

### Maps
Maps and dictionaries are data structures that pair values with keys, which allows developers to access the data in each pair by specifying they key (the key is like an index). Any kind of data type can be used for keys or values, which makes it very flexible, but also ensures that the best possible case is O(1), while the worst case is O(n), since the keys are not ordered. You also cannot find the key for a value without looking through the entire data set.
            
### Stacks
 A stack is a data structure in which elements are accessed via a first in, last out order. They are very fast, only requiring O(1) time and resources to process. The main downside of using a stack is that there is no random access to items within the stack, you cannot look at something in a specific index
without popping items on top of it (like stacks).
            
### Queues
A queue is data structure in which elements are accessed in via a first in, first out order. All queue operations are very fast and efficient, only taking O(1) time to procest, but the main downside of using a queue is that there is no random access to items within the queue since you cannot look at something in a specific indexw ithout dequeueing items before it. Queues are best in situations where you need to know what order in which data has been received, such as requests or commands.
