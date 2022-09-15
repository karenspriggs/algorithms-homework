using System;
using System.Collections.Generic;

// Constant O(1)
// This is an example of an algorithm described by the O notation O(1) since it only looks at the first element of the 
// inputted data set, and as such will always take up the same amount of time/resources no matter how long that array of integers is
public bool IsFirstElementEqualToOne(int[] elements){
    return elements[0] == 1;
}

// Linear O(n)
// This is an example of an algorithm described by the O notation O(n) since it adds up all the elements in the array and 
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

