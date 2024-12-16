using System;
class methods
{
    //Non value returing method without parameters
    public void Test1()              //static in behaviour
    {
        int x = 5;
        for (int i = 0; i < 10; i++)
            Console.WriteLine($"{x}* {i} = {x * i}");
    }

//Non value returing method with parameters
{
    public void Test1(int x, int ub)    //dynamic in behaviour
    {
        for (int i = 0; i < ub; i++)   //ub-upperbound test(5,12)
            Console.WriteLine($"{x}* {i} = {x * i}");
    }
  // value returing method without parameters
  {
    public string Test3()        //static in behaviour
    {
        string str = "Hello world";
        str = str.ToUpper();
        return str;
    }
}
// value returing method with parameters
{
    public string Test4(string str)        //dynamic in behaviour 
{
    
    str = str.ToUpper();
    return str;
}
}
}
    
}