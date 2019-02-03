using System;

class Solution
{
  public int simpleArraySum(int[] ar){
  int count = 0;
  foreach(int i in ar){
    count = count + i;
  }
  	
  return count;	 
  }

  static void Main()
  {
   int[] arr = {1,2,3,4,5};
   Solution sol = new Solution();
   var i = 2;  
 
   Console.WriteLine(i);

  }
}
