using System;

class Solution
{
  static int simpleArraySum(int[] ar){
  int count = 0;
  for(int i = 0; i < ar.length;i++){
  count = ar[i] + count;
  }	
  return count;	 
  }

  static void Main()
  {

   Solution sol = new Solution();
   Console.WriteLine(sol.simpleArraySum([1,2,3,4,5]);

  }
}
