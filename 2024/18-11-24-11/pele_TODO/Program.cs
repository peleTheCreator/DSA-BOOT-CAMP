/// <summary>
/// #1 Given an array arr[ ] of size n, the task is to find the largest element in the given array
/// </summary>
/// <param name="array">[12,15,2,19,5]</param>
/// <returns>the largest element(int)</returns>
int LargestElementInAnArray(int[] array)
{
    //assume the largest is at index o
    int largest = array[0];


    //loop thru and compare with the largest starting from the second index
    for (int i = 1; i < array.Length; i++)
    {
        //if it greater the largest replace it.
        if (array[i] > largest)
            largest = array[i];
    }
    return largest;
}

Console.WriteLine($"LargestElementInAnArray : {LargestElementInAnArray(new int[] { 12, 15, 2, 19, 5 })} ");



/// <summary>
/// #2 Given an array arr[ ] of size n, the task is to find the Second largest element in the given array.
/// </summary>
/// <param name="array">[12,15,2,19,5]</param>
/// example :
/// [12,15,2,19,5] return 12
/// [5,5,5]  return -1 cause no second largest element
/// <returns>the second larges element(int)</returns>


int SecondLargestElementInArray(int[] array)
{
    //assume largest is at index 0
    int largest = 0;

    //second largest is unknown
    int secondlargest = -1;

    //explanation:
    //treat as one stream of data and consider all possible scenerio
    // scenerios:
    // if a[i] > a[largest]  then largest is not longer at index 0 so we can assume : sl = largest & largest = i
    //if a[i] == a[largest] : we ignore
    // if a[i] < a[largest] : 
    //if sl = -1 :  update to sl = i
    // if sl = i : ignore
    // if sl < i : sl = i

    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > array[largest])
        {
            secondlargest = largest;
            largest = i;
        }
        else if (array[i] != array[largest])
        {
            if (secondlargest == -1 || array[i] > array[secondlargest])
                secondlargest = i;
        }
    }
    return array[secondlargest];
}

Console.WriteLine($"SecondLargestElementInArray : {SecondLargestElementInArray(new int[] { 12, 15, 2, 19, 5 })} ");

/// <summary>
/// #3.Check if the Array is Sorted : We are given an array containing n elements. Our task is to check whether the array is sorted in ascending (non-decreasing/increasing) order or not..
/// </summary>
/// <param name="array">[3,7,15,60,90,99]</param>
/// <returns>true or false</returns>
bool IsArraySorted(int[] array)
{
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < array[i - 1])
            return false;
    }

    return true;
}


Console.WriteLine($"IsArraySorted : {IsArraySorted(new int[] { 3, 7, 15, 60, 90, 99 })} ");


/// <summary>
///#4.Our Task: Given an array (or string), the task is to reverse the array.
/// </summary>
/// <param name="array"></param>
/// the idea is to reverse the array without creating a new array by swapping both ends
/// dont use extra array, space complexity is o(1)
/// <returns>the reverse of the array(int)</returns>
void ReveresedArray(int[] array)
{
    int low = 0, high = array.Length - 1;

    while (low < high)
    {
        int temp = array[low];
        array[low] = array[high];
        array[high] = temp;

        low++;
        high--;
    }


    Console.WriteLine("ReveresedArray: ");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + " ");
    }
}

ReveresedArray(new int[] { 3, 7, 15, 60, 90, 99 });



/// <summary>
///#5.Remove Duplicates from a Sorted Array
/// </summary>
/// <param name="array"></param>
/// dont use extra array, space complexity is o(1)
/// <returns>array with duplicate removed</returns>
void RemoveDuplicateFromSortedArray(int[] array)
{
    int res = 1;


    for (int i = 1; i < array.Length; i++)
    {
        if (array[res - 1] != array[i])
        {
            array[res] = array[i];
            res++;
        }
    }

    Console.WriteLine("RemoveDuplicateFromSortedArray: ");
    for (int i = 0; i < res; i++)
    {
        Console.Write(array[i] + " ");
    }
}
RemoveDuplicateFromSortedArray(new int[] { 1, 2, 2, 3, 4, 4, 4, 5, 5 });


/// <summary>
///#6 Our Task: Move Zeros to End !!!
///input : {0, 1, 9, 8, 4, 0, 0, 2, 7, 0, 6, 0, 9}
///output : 1 9 8 4 2 7 6 9 0 0 0 0 0
/// </summary>
/// <param name="array"></param>
/// <returns>re</returns>
/// 
void push_zeros_to_end(int[] array)
{
    var p = 0;

    for (int i = 0; i <= array.Length - 1; i++)
    {
        if (array[i] != 0)
        {
            int temp = array[i];
            array[i] = array[p];
            array[p] = temp;
            p++;

        }

    }
    Console.WriteLine();
    Console.Write("push_zeros_to_end: ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}
push_zeros_to_end(new int[] { 0, 1, 9, 8, 4, 0, 0, 2, 7, 0, 6, 0, 9 });


//#7 Left Rotate an Array by One !!!
void Left_rotate_array_by_one(int[] array)
{
    int temp = array[0];

    for (int i = 1; i < array.Length; i++)
    {
        array[i - 1] = array[i];
    }
    array[array.Length - 1] = temp;

    Console.WriteLine();
    Console.Write("Left_rotate_array_by_one: ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

Left_rotate_array_by_one(new int[] { 0, 1, 9, 8, 4, 0, 0, 2, 7, 0, 6, 0, 9 });


/// <summary>
///#8. Left Rotate an Array by D Places !!!
///Input: arr[] = {1, 2, 3, 4, 5, 6, 7}, d = 2
///Output: 3 4 5 6 7 1 2
/// </summary>
/// <param name="array"></param>
/// <returns>re</returns>
void Left_rotate_array_by_D_place(int[] array, int d)
{
    int[] temp = new int[d];

    //save the first two in a temp array
    for (int i = 0; i < d; i++)
        temp[i] = array[i];

    //rearrange from the postion d to the array
    for (int i = d; i <= array.Length -1; i++)
        array[i-d] = array[i];

    //insert the remaning data in temp into the array
    for(int i = 0 ; i < d; i++)
        array[array.Length- d+i] = temp[i];

    Console.WriteLine();
    Console.Write("Left_rotate_array_by_D_place: ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}
Left_rotate_array_by_D_place(new int[] { 1, 2, 3, 4, 5, 6, 7 }, 2);


/// <summary>
///#9. An element is a leader if it is greater than all the elements to its right side. And the rightmost element is always a leader.
///Input: {16, 17, 4, 3, 5, 2}
///Output: 17, 5, 2
/// </summary>
/// <param name="array"></param>
/// <returns>re</returns>


void FindTheLeadersInAnArray(int[] array)
{

}
