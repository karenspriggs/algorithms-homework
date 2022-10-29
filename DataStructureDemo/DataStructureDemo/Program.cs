using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace DataStructureDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            FileReader.fileName = "data.txt";

            // An array is a data structure with a fixed length, where each element takes up a space that was established in memory when the array was instantiated
            // Arrays can have up to 32 dimensions (layers of arrays within arrays), but this one is just 1 dimension
            // Arrays are more efficient to use than lists, due to their fixed size and "predetermined" spaces for elements
            // If you want a flexible collection of objects where the size of the collection will change, it is best to use a list instead
            // However, if you know what size the collection will be beforehand, an array would be much better since it is more efficient
            string[] ArrayOutput = FileReader.ReadDataFromFileToArray();

            // Maps and dictionaries are data structures that pair values with keys, which allows developers to access the data in each pair by specifying they key (the key is like an index)
            // Any kind of data type can be used for keys or values, which makes it very flexible
            // This means that the best possible case is O(1), but the worst case is O(n), since the keys are not ordered
            // You cannot find the key for a value without looking through the entire data set
            // I used a dictionary in a game project where I had something like a Pokedex, so I could display a monster on the screen that corresponded with the one the player
            // had selected to view the page for
            Dictionary<int, string> MapOutput = FileReader.ReadDataFromFileToList();

            // A stack is a data structure in which elements are accessed via a first in, last out order
            // Stacks are very fast, only requiring O(1) time and resources to process
            // The main downside of using a stack is that there is no random access to items within the stack, you cannot look at something in a specific index
            // Without popping items on top of it (like stacks)
            // C# uses a call stack to keep track of which functions have been run already so it can tell which function was not completed, since a function's
            // invocation adds it to the stack and its completion removes it
            Stack<string> StackOutput = FileReader.ReadDataFromFileToStack();

            // A queue is data structure in which elements are accessed in via a first in, first out order
            // All queue operations are very fast and efficient, only taking O(1) time to process
            // The main downside of using a queue is that there is no random access to items within the queue, you cannot look at something in a specific index
            // Without dequeueing items before it
            // Queues are best in situations where you need to know what order in which data has been received, such as requests or commands
            // For example: web servers use queues to keep track of commands, CPUS use queues to know which processes to run in which order, etc
            Queue<string> QueueOutput = FileReader.ReadDataFromFileToQueue();

            foreach (string str in ArrayOutput)
            {
                Console.WriteLine(str);
            }

            foreach (KeyValuePair<int, string> pair in MapOutput)
            {
                Console.WriteLine($"{pair.Key} {pair.Value}");
            }

            foreach(string str in StackOutput)
            {
                Console.WriteLine(str);
            }

            foreach (string str in QueueOutput)
            {
                Console.WriteLine(str);
            }

            Console.ReadKey();
        }
    }

    public static class FileReader
    {
        public static string fileName;

        public static string[] ReadDataFromFileToArray()
        {
            List<string> output = new List<string>();
            string[] ArrayOutput;
            int arraySize = 0;

            StreamReader streamReader = new StreamReader(fileName);
            streamReader.BaseStream.Seek(0, SeekOrigin.Begin);

            string element = streamReader.ReadLine();

            while (element != null)
            {
                output.Add(element);
                element = streamReader.ReadLine();
                arraySize++;
            }

            ArrayOutput = new string[arraySize];

            for (int i = 0; i < arraySize; i++)
            {
                ArrayOutput[i] = output[i];
            }

            return ArrayOutput;
        }

        public static Dictionary<int, string> ReadDataFromFileToList()
        {
            Dictionary<int, string> output = new Dictionary<int, string>();
            int currentIndex = 0;

            StreamReader streamReader = new StreamReader(fileName);
            streamReader.BaseStream.Seek(0, SeekOrigin.Begin);

            string element = streamReader.ReadLine();

            while (element != null)
            {
                output.Add(currentIndex, element);
                element = streamReader.ReadLine();
                currentIndex++;
            }

            return output;
        }

        public static Stack<string> ReadDataFromFileToStack()
        {
            Stack<string> output = new Stack<string>();

            StreamReader streamReader = new StreamReader(fileName);
            streamReader.BaseStream.Seek(0, SeekOrigin.Begin);

            string element = streamReader.ReadLine();

            while (element != null)
            {
                output.Push(element);
                element = streamReader.ReadLine();
            }

            return output;
        }

        public static Queue<string> ReadDataFromFileToQueue()
        {
            Queue<string> output = new Queue<string>();

            StreamReader streamReader = new StreamReader(fileName);
            streamReader.BaseStream.Seek(0, SeekOrigin.Begin);

            string element = streamReader.ReadLine();

            while (element != null)
            {
                output.Enqueue(element);
                element = streamReader.ReadLine();
            }

            return output;
        }
    }
}
