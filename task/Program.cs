// Написать программу, которая из имеющегося массива строк, формирует массив строк
// длина которых меньше либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать.

void EnterArray(string[] args)
    {
      string[] array; 
      int count; 
      string s;
      string[] array2; 
      Console.WriteLine("Введите строки:");
      count = 0; 
      array = new string[count]; 
      do
      {
        s = Console.ReadLine();
        if (s!="")
        {
          count++;
          array2 = new string[count];
          for (int i = 0; i < array2.Length - 1; i++)
          array2[i] = array[i];
          array2[count - 1] = s;
          array = array2;
        }
      } while (s != "");
      Console.WriteLine("Вывод массива из введенных строк: ");
      for (int i = 0; i < array.Length; i++)
      {
      Console.WriteLine("array[{0}] = {1}", i, array[i]);
      }
    }
EnterArray(args);