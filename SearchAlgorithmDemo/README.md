# Weeks 11 and 12:
In weeks 11 and 12, I learned about searching and sorting algorithms. Since some of the searching algorithms require the data set to be sorted prior to searching, I decided to make the two in the same solution. 

## Sorting
I learned about six different sorting algorithms in week 11:

**Bubble Sort Psuedocode**

    Bubblesort(Data: values[])

        // Repeat until the array is sorted.

        Boolean: not_sorted = True

        While (not_sorted)        
            not_sorted = False
            For i = 0 To <length of values> - 1
                If (values[i] < values[i - 1]) Then
                    Data: temp = values[i]
                    values[i] = values[i - 1]
                    values[i - 1] = temp
                    not_sorted = True
                End If
            Next i
        End While

    End Bubblesort  

**Insertion Sort Psuedocode**
            
````
Insertionsort(Data: values[])
                    // Starting loop
               For i = 0 To <length of values> - 1
                   // Move item i into position
                   //in the sorted part of the array
                   < Find  the first index j where
                     j < i and values[j] > values[i].>
                   <Move the item into position j.>
               Next i
            
            End Insertionsort
````


**Selection Sort Psuedocode**
````
            Selectionsort(Data: values[])
                For i = 0 To <length of values> - 1
                    // Find the item that belongs in position i.
                    <Find the smallest item with index j >= i.>
                    <Swap values[i] and values[j].>
                Next i
            End Selectionsort  
````
**Heap Sort Psuedocode**
````
Heapsort(Data: values[])
        <Turn the array into a heap.>

        For i = <length of values> - 1 To 0 Step -1
            // Swap the root item and the last item.
            Data: temp = values[0]
            values[0] = values[i]
            values[i] = temp

            <Consider the item in position i to be removed from the heap,
             so the heap now holds i - 1 items. Push the new root value
             down into the heap to restore the heap property.>
        Next i
    End Heapsort  
````
**Quick Sort Psuedocode**
````
    Quicksort(Data: values[], lo, hi) is
        if lo < hi then
            p := pivot(values, lo, hi)
            left, right := partition(values, p, lo, hi)  // note: multiple return values
            quicksort(values, lo, left - 1)
            quicksort(values, right + 1, hi)
    End Quicksort  
````
**Merge Sort Psuedocode**
````
    Mergesort(Data: values[], Data: scratch[], Integer: start, Integer: end)
        // If the array contains only one item, it is already sorted.

    If (start == end) Then Return

        // Break the array into left and right halves.
        Integer: midpoint = (start + end) / 2

        // Call Mergesort to sort the two halves.
        Mergesort(values, scratch, start, midpoint)
        Mergesort(values, scratch, midpoint + 1, end)

        // Merge the two sorted halves.
        Integer: left_index = start
        Integer: right_index = midpoint + 1
        Integer: scratch_index = left_index
        While ((left_index <= midpoint) And (right_index <= end))
            If (values[left_index] <= values[right_index]) Then
                scratch[scratch_index] = values[left_index]
                left_index = left_index + 1
            Else
                scratch[scratch_index] = values[right_index]
                right_index = right_index + 1
            End If
            scratch_index = scratch_index + 1    End While

        // Finish copying whichever half is not empty.
        For i = left_index To midpoint
            scratch[scratch_index] = values[i]
            scratch_index = scratch_index + 1
        Next i
        For i = right_index To end

    scratch[scratch_index] = values[i]
            scratch_index = scratch_index + 1
        Next i
        // Copy the values back into the original values array.
        For i = start To end
            values[i] = scratch[i]
        Next i
    End Mergesort
````
## Searching
I learned about three different sorting algorithms in week 12:

**Linear Search Psuedocode**
````
Begin
1) Set i = 0
2) If Li = T, go to line 4
3) Increase i by 1 and go to line 2
4) If i < n then return i
End
````
**Binary Search Psuedocode**
````
function binary_search(A, n, T) is
    L := 0
    R := n − 1
    while L ≤ R do
        m := floor((L + R) / 2)
        if A[m] < T then
            L := m + 1
        else if A[m] > T then
            R := m − 1
        else:
            return m
    return unsuccessful
````
**Interpolation Search Psuedocode**
````
InterpolationSearch(data[], searchtarget, lowindex, highindex)
1) See if data[lowindex+highindex/2] = searchtarget
2) If it is a match, return that middle index
3) If it is not a match, use the probe position equation to make a key
4) Divide the list using the probing key and find the new middle
5) If the search target is greater than middle, search in higher sub-list.
6) If search target is smaller than middle, search in lower sub-list.
7) Recursively repeat until a match is found, return index
