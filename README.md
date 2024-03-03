# Data Structures Learning Software: Technical Documentation
**Group 8A:**   
Ravi Lahare, 210101086  
Ravi Ranjan Kumar, 210101087  
Ridhiman Kaur Dhindsa, 210101088   
Riya Mittal, 210101089   
Sachin Kumar Gautam, 210101090   
Sahil Jaiswal, 210101091   
  
**Date:** 4 March 2024

## How to run
1) Open the project directory in Visual Studio 2010.  
2) Press the `Run` button in the toolbar at the top, or press F5.   
3) The software starts running. Create an account and enter the desired inputs.  

## Description
Developed a data structures learning software named Algorithmic Atlas, designed to teach students the fundamental concepts of data structures through step-by-step explanations, interactive modules, and engaging graphics. Inputs in all interactive exercises are restricted to be numerical and in the range of -1000 to 1000. Indices and sizes of data structures shall not exceed 10 since it is only for understanding purposes. **Error handling** has also been included, which covers the following cases:  
1) `Out of range:` If any of the numbers entered, whether numerical or index-based, is outside the above mentioned range, this error is displayed. Also, if after performing the calculation the result is beyond the range, this error is displayed.  
2) `Invalid input:` If the entered input is not in numeric format or there is a syntax error, this error is displayed. Eg: 12.3.53, abcdef etc.    
3) `Login/authentication errors:`  If the user enters wrong user ID or password, or the account does not exist, then the login page displays appropriate error.  

## Tools used
* Visual Studio 2010 as the development environment.   
* Visual Basic Windows Forms Application for developing the application. (Complete with inline comments)   
* MarkDown for the Technical documentation.  
* GUI design made using [Figma](https://www.figma.com/file/KoIvhZNhhFpdArQwbBMgyU/DSA-software?type=design&node-id=0-1&mode=design&t=35tHnp4uflnzK6D4-0).    
* User Documentation available in PDF format.  
* SDLC Model used for development - Incremental models such as Rapid Application Development (RAD) model.  

## Structure of the application
The following is the order of opening of pages:  
Login/Signup page --> Home page --> Tutorial page (indivdual topic) --> Quiz page  

* Login/Signup page: User logs in with details, or signs up if account does not exist. Then he/she is directed to the home page.  
* Home page: Lists all tutorial modules from which user can choose which one to learn about. Progress indicator for each module is displayed.
* Tutorial page: Comprehensively covers content relating to the topic along with interactive features to visualize the operations on data structures. Includes a quiz with each topic to test understanding.  
* Quiz page: Displays questions one at a time, with 4 options. Net score is displayed at the end of the quiz.  
* Database: Consists of 3 tables- User details (id, password, username), storing progress metrics (user id, module name, points scored), storing quiz questions (module name, question number, question, options, correct 
answer).     

## Functions used
Each button has its own defining function.

*Inputs for Event Handler functions:*  
* **ByVal sender As System.Object:** This parameter represents the object that raised the event. In this case, it represents the button that was clicked. The ByVal keyword indicates that the parameter is passed by value, meaning that a copy of the object's reference is passed to the subroutine.  
* **ByVal e As System.EventArgs:** This parameter represents the event arguments associated with the event. In this case, it represents the EventArgs object associated with the Click event. The ByVal keyword indicates that the parameter is passed by value, meaning that a copy of the EventArgs object is passed to the subroutine.    

### 1) Login button:
`login_btn_Click()`   
**Inputs:** Event handling parameters as stated above.   
**Outputs:** Sends user input to database, authenticates them, and opens home page if authentication successful. Displays appropriate error on authentication failure.       

### 2) Sign Up button:
`signup_Click()`   
**Inputs:** Event handling parameters as stated above.   
**Outputs:** Stores user input in database and opens home page.     

### 3) Module buttons:
`modulename_btn_Click()`  
**Inputs:** Event handling parameters as stated above.   
**Outputs:** Opens the respective topic's tutorial page.    

### 4) Data Structure Buttons:
#### Arrays
`insert_btn_Click()`  
**Inputs:** Event handling parameters as stated above.   
**Outputs:** Inserts the element specified at the end of array.  
`access_btn_Click()`  
**Inputs:** Event handling parameters as stated above.   
**Outputs:** Displays the element present at specified index.  
`update_btn_Click()`  
**Inputs:** Event handling parameters as stated above.   
**Outputs:** Updates the element present at specified index.  
`sum_btn_Click()`  
**Inputs:** Event handling parameters as stated above.   
**Outputs:** Calculates the sum of all elements present in array currently.  
`reset_btn_Click()`  
**Inputs:** Event handling parameters as stated above.   
**Outputs:** Clears all input fields and output displays.  

#### Vectors
`insert_btn_Click()`  
**Inputs:** Event handling parameters as stated above.   
**Outputs:** Inserts the element specified at the end of vector (push_back function).  
`access_btn_Click()`  
**Inputs:** Event handling parameters as stated above.   
**Outputs:** Displays the element present at specified index.  
`update_btn_Click()`  
**Inputs:** Event handling parameters as stated above.   
**Outputs:** Updates the element present at specified index, highlighted in red.  
`remove_btn_Click()`  
**Inputs:** Event handling parameters as stated above.   
**Outputs:** Deletes the element present at specified index. (erase function).   
`reset_btn_Click()`  
**Inputs:** Event handling parameters as stated above.   
**Outputs:** Clears all input fields and output displays.  

#### Linked Lists
`insert_btn_Click()`  
**Inputs:** Event handling parameters as stated above.   
**Outputs:** Inserts the element specified at the end of linked list.  
`search_btn_Click()`  
**Inputs:** Event handling parameters as stated above.   
**Outputs:** Searches for the element specified, by carrying out linear search from the linked list head. Displays error if not found.   
`update_btn_Click()`  
**Inputs:** Event handling parameters as stated above.   
**Outputs:** First carries out linear search from head and then updates the element specified, highlighted in red. Displays error if not found.    
`delete_btn_Click()`  
**Inputs:** Event handling parameters as stated above.   
**Outputs:** First carries out linear search from head and then deletes the element specified. Displays error if not found.     
`reset_btn_Click()`  
**Inputs:** Event handling parameters as stated above.   
**Outputs:** Clears all input fields and output displays.

#### Insertion Sort
bntSort_Click
**Inputs:** Event handling parameters as stated above.   
**Outputs:** Displays the array and sorts it visually using the insertion sort algorithm.

#### Bubble Sort
bntSort_Click
**Inputs:** Event handling parameters as stated above.   
**Outputs:** Displays the array and sorts it visually using the bubble sort algorithm.

#### Selection Sort
bntSort_Click
**Inputs:** Event handling parameters as stated above.   
**Outputs:** Displays the array and sorts it visually using the selection sort algorithm.

#### Linear Search
btnLoad_Click
**Inputs:** Event handling parameters as stated above.   
**Outputs:** Displays the sorted array given as input.
btnSort_Click
**Inputs:** Event handling parameters as stated above.   
**Outputs:** Takes an integer to find as input and performs linear search on the array visually.

#### Binary Search
btnLoad_Click
**Inputs:** Event handling parameters as stated above.   
**Outputs:** Displays the sorted array given as input.
btnSort_Click
**Inputs:** Event handling parameters as stated above.   
**Outputs:** Takes an integer to find as input and performs binary search on the array visually.

#### Stacks
`StackPush_btn_Click`  
**Inputs:** Event handling parameters as stated above.   
**Outputs:** Inserts the element specified at the top of stack (push function).  
`StackPop_btn_Click`  
**Inputs:** Event handling parameters as stated above.   
**Outputs:** Deletes the top element of stack. (pop function).   
`StackTop_btn_Click`  
**Inputs:** Event handling parameters as stated above.   
**Outputs:** Prints the top element of Stack.

#### Queues
`enqueue_btn_Click`  
**Inputs:** Event handling parameters as stated above.   
**Outputs:** Inserts the element specified at the back of queue (push function).  
`dequeue_btn_Click`  
**Inputs:** Event handling parameters as stated above.   
**Outputs:** Deletes the front element of queue. (pop function). 

### 5) Back button: 
`back_btn_Click()`  
**Inputs:** Event handling parameters as stated above.   
**Outputs:** Goes to previous page.    

### 6) Take Quiz button:
`quiz_btn_Click()`  
**Inputs:** Event handling parameters as stated above.   
**Outputs:** Opens respective topic quiz which displays questions one at a time.       

<!--
### 7) Show Code button: 
`code_btn_Click()`  
**Inputs:** Event handling parameters as stated above.   
**Outputs:** Reads the last line of display as the second number to be operated on, and performs validation checks on it. Then calculates the result and rounds off to 7 decimal places.  
-->
