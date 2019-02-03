using System;


class program
{
  bool isNum(int n)
  {
  if(n == 1)
  { 
   return true;
  }
  return false;
  }

  static void Main() 
 {
  program func = new program();
  Console.WriteLine(func.isNum(1));
 }
}
