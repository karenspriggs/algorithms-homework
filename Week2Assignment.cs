using System;
using System.Collections.Generic;

// Constant O(1)
// This is an example of an algorithm described by the O notation O(1), or constant time, since it only looks at the first element of the 
// inputted data set, and as such will always take up the same amount of time/resources no matter how long that array of integers is
public bool IsFirstElementEqualToOne(int[] elements){
    return elements[0] == 1;
}

// Linear O(n)
// This is an example of an algorithm described by the O notation O(n), or linear time, since it adds up all the elements in the array and 
// returns the sum, the amount of numbers added together is the same as the amount of elements (elements and amount of steps
// have a linear relationship)
public int ReturnSumOfIntegerArray(int[] elements){
    int result = 0;

    foreach (var element in elements)
    {
        result += element;
    }

    return result;
}

// Quadratic O(n^2)  
// This is an example of an algorithm described by the O notation O(n^2), or quadratic time, since it calculates the product of every combination
// of numbers in a collection of integers, which means that the total amount of results (products) generated is equal to that of the size of the 
// data set squared. 
public void ProductsOfAllElements(int[] elements){
    foreach(var firstFactor in elements){
        foreach (var secondFactor in elements){
            Console.WriteLine($"The product of {firstFactor} and {secondFactor} is {firstFactor * secondFactor}");
        }
    }
}