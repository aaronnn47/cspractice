using System;

class Solution
{
  public int simpleArraySum(int[] ar){
  var count = 0;
  foreach(int i in ar){
    count = count + i;
  }
  	
  return count;	 
  }

  static void Main()
  {
   int[] arr = {1,2,3,4,5,6};
   Solution sol = new Solution();
   
   Console.WriteLine(sol.simpleArraySum(arr));

  }
}
