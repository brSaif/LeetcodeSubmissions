public class Solution {
    
       
    public int LargestRectangleArea(int[] heights) {
    
        Stack<int> myStack = new Stack<int>();  //  stack for keeping track of bars position        
        int topStack;                           //  To store top of stack
        int maxArea = 0;                       //  initial maximum area         
        int newArea;                           //  getting area with top bar
 
        int total = heights.Length;
        int i = 0;
            
	    while (i < total)       //  working with all bars
        {        
            if ((myStack.Count == 0) || heights[myStack.Peek()] <= heights[i])  //  if the current bar's height is bigger or 
                                                                                //  equal than the top of stack
                myStack.Push(i++); 
 
            else    //  if the current bar's height is less than the top of stack
            {
                
                topStack = myStack.Pop();  
             
                newArea = heights[topStack] * ((myStack.Count == 0) ? i : i - myStack.Peek() - 1);   //  finding the new area
 
                // update max area, if needed
                if (maxArea < newArea) maxArea = newArea;                       	
            }              
        }
 
        //  finding area for the rest of the bars still in stack
    
        while (myStack.Count != 0)
        {
            
            topStack = myStack.Pop();
            newArea = heights[topStack] * ((myStack.Count == 0)? i : i - myStack.Peek() - 1);
 
            if (maxArea < newArea) maxArea = newArea;
        }
 
        return maxArea;
    }
    
}