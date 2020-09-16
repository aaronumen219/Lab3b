using System;

class MainClass {
  public static void Main (string[] args) {
  
  Console.WriteLine("Enter salesperson name");
  string name = Console.ReadLine();

  Console.WriteLine("Enter sales amount");
  double sales = Convert.ToDouble(Console.ReadLine());

  double salescommission = Convert.ToDouble(200 + (0.09 * sales));

  Console.WriteLine("Sales comission for " + name + " is $" + salescommission);

  if  (sales < 3000)
    {
  
      Console.WriteLine("Performance is poor");

    }
    else if (sales >= 3000 && sales < 5000)
    {
      Console.WriteLine("Performance is average");
    }
    else if (sales >= 5000 && sales < 10000)
    {
    
      Console.WriteLine("Performance is good");

    }
    else if (sales >= 10000 && sales < 15000)
    {
    
      Console.WriteLine("Performance is excellent");

    }

    else

    {
      Console.WriteLine("Performance is outstanding");
    }




  }
}