  {
 
        int a, b;
 
        Console.WriteLine("Введите два числа : ");
 
        a = Convert.ToInt32(Console.ReadLine());
 
        b = Convert.ToInt32(Console.ReadLine());
 
        if (a > b)
 
        {
 
            Console.WriteLine("{0} наибольшее число", a);
 
        }
 
        else
 
        {
 
            Console.WriteLine("{0} наибольшее число ", b);
 
        }
 
        Console.ReadLine();
 
    }
   // Задача 2.
    {
            int[] ABCArr = new int[3];
            bool isEven = false;
            for (int i = 0; i < ABCArr.Length; i++)
            {
                Console.Write("Введите число {0} : ", i);
                if (((ABCArr[i] = Convert.ToInt32(Console.ReadLine())) % 2 == 0) && isEven == false)
                    isEven = true;
            }
            Array.Sort(ABCArr);
            if (ABCArr[1] == ABCArr[0] || ABCArr[1] == ABCArr[2])
                Console.WriteLine("Невозможно определить максимальный/минимальный элемент");
            else
            {
                if (isEven)
                    Console.WriteLine("Максимальное значение = {0}", ABCArr.Max());
                else
                    Console.WriteLine("Минимальное значение = {0}", ABCArr.Min());
            }
        }
        //задача 3
        {
Console.WriteLine("Введите число: ");
int c = Convert.ToInt32(Console.ReadLine());
if (c % 2 == 0) Console.WriteLine("Число четное");
else Console.WriteLine("Число нечетное");
}

  //Задача 4
  
  
 {
  Console.WriteLine("Введите число: ");
      int n = Convert.ToInt32(Console.ReadLine());
      for (int i = 2; i <= n; i += 2) {
          Console.Write(i + " ");
      }
  }




