#1. Given an array arr[ ] of size n, the task is to find the largest element in the given array. [12,15,2,19,5] 
```python
def largest(arr):
	new_arr = arr.sort()
	return new_arr[-1]

def largest(arr):
	return max(arr)

def largest(arr):
	max_num = arr[0]
	for i in arr:
		if i>max_num:
			max_num = i
	return max_num
```


#2. find the Second largest element in the given array. 
```python
def second_largest(arr):
	arr.sort
	max_num = arr[-2]
```

#3.Check if the Array is Sorted : We are given an array containing n elements. 
Our task is to check whether the array is sorted in ascending (non-decreasing/increasing) order or not. [3,7,15,60,90,99] 
```python

def check_sorted(arr):
	for i in range(len(arr)-1):
		if arr[i] < arr[i+1]:
			return True
	return False
	
// don't know which works or if any works at all

def check_sorted(arr):
	for i in range(len(arr)-1):
		if arr[i] > arr[i+1]
			return False
	return True
	
```

#4.Our Task: Given an array (or string), the task is to reverse the array. 
Examples : 
Input : arr[] = {1, 2, 3} 
Output : arr[] = {3, 2, 1} 
Input : arr[] = {4, 5, 1, 2}
Output : arr[] = {2, 1, 5, 4} 
```python
def reverse_array(arr):
	arr.reverse()

```

#5.Remove Duplicates from a Sorted Array !!! 
Our Task: Given a sorted array, the task is to remove the duplicate elements from the array. 
Ex1: 
Input : arr[] = {2, 2, 2, 2, 2} 
Output : arr[] = {2} 
new size = 1 
Ex2: 
Input : arr[] = {1, 2, 2, 3, 4, 4, 4, 5, 5} 
Output : arr[] = {1, 2, 3, 4, 5} 
new size = 5 
```python
def remove_duplicates(arr):
	if len(arr) == 0:
		return 0
		
	visited = {}
	size = 0
	
	for i in range(len(arr)):
		if arr[i] not in visited:
			visited[arr[i]] = True    // no idea how that works, how do you add a value to a hashmap
			arr[size] = arr[i]
		size+=1
		
	return size

def remove_duplicates(arr):
	if len(arr) == 0:
		return 0
		
	visited = set()
	size = 0

	for i in arr:
		if i not in visited:
			visited.add(i)
		size+=1
		
	return size
```

#6.Move Zeros to End !!! 
Our Task: Given a sorted array, the task is to remove the duplicate elements from the array. 
Examples: 
Input: arr[] = {1, 2, 0, 0, 0, 3, 6} Output: 1 2 3 6 0 0 0 
Input: arr[] = {0, 1, 9, 8, 4, 0, 0, 2, 7, 0, 6, 0, 9} Output: 1 9 8 4 2 7 6 9 0 0 0 0 0 
```python
def move_zeros(arr):
	l, r = 0, len(arr)-1
	while l<r:
		if arr[l] == 0 and arr[r]!=0:
			arr[l],arr[r] = arr[l], arr[r]
			l+=1, r-=1
		else:
			r-=1

	return arr
```

#7 Left Rotate an Array by One !!! 
Our Task: Given an array, the task is to Left Rotate an Array by One. 
What is meant by the Left Rotation of an Array by One? Left Rotation means a rotation that happens Counter-Clockwise (anticlockwise). The elements are moved counterclockwise by one, which results in the elements moving back by one position from their initial position. 
Example: 
Input: arr[] = {1,2,3,4,5} Output: arr[] = {2,3,4,5,1} 
Input: arr[] = {30,5,20} Output: arr[] = {5,20,30} 
```python
def left_rotate_by_one(arr):
	temp= arr[0]
	for i in range(len(arr)-1):
		arr[i]= arr[i+1]
	arr[len(arr)-1] = temp

	return arr

```

#8. Left Rotate an Array by D Places !!! 
Our Task: Given an array, the task is to Left Rotate an Array by D places. 
What is meant by the Left Rotation of an Array by D places? Left Rotation means a rotation that happens Counter-Clockwise (anticlockwise). The elements are moved counterclockwise by D number of places, which results in the elements moving back by D positions from their initial position. 
Examples: 
Input: arr[] = {1, 2, 3, 4, 5, 6, 7}, d = 2 Output: 3 4 5 6 7 1 2 
Input: arr[] = {3, 4, 5, 6, 7, 1, 2}, d=2 Output: 5 6 7 1 2 3 4 
```python
def left_rotate(arr, d):
	return (arr[d:-1]) +(arr[0:d]) //list slicing

```

#9 Find the Leaders in an Array !!! 
Our Task: Given an array, the task is to write a program to print all the LEADERS in the array. 
What is a Leader? An element is a leader if it is greater than all the elements to its right side. And the rightmost element is always a leader. 
For example: 
Input: arr[] = {16, 17, 4, 3, 5, 2}, Output: 17, 5, 2 
Input: arr[] = {1, 2, 3, 4, 5, 2}, Output: 5, 2 
```python
def leader(arr):
	leaders=[] 
	last_leader = arr[-1]                //the last value is always a leader
	leaders.append(last_leader)

	for i in range(len(arr)-2, -1, -1):  //count and decrement from the last value
		if arr[i] > last_leader:      // any value greater than the last leader is the new last leader
			last_leader = arr[i]
			leaders.append(last_leader)  // append the values

	return leaders.reverse()
```

#10: Maximum Difference Problem with Order !!! 
Our Task: Given an array arr[] of integers, find out the maximum difference between any two elements such that the larger element appears after the smaller number. 
Examples : 
Input : arr = {2, 3, 10, 6, 4, 8, 1} 
Output : 8 
Explanation : The maximum difference is between 10 and 2. 
Input : arr = {7, 9, 5, 6, 3, 2} 
Output : 2 
Explanation : The maximum difference is between 9 and 7.
```python
def maximum_differene(arr):
	max_value = arr[len(arr)-1]
	max_difference = 0

	for i in range(len(arr)-2, -1, -1):
		if arr[i]<max_value:
			max_diff=max(max_diff, max_value-arr[i])
		else:
			max_value = arr[i]

	return max_difference
	
```

