// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. Не использовать Math.Pow

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

int Exponentiation(int numA, int numB){

  int result = 1;

  for(int i=1; i <= numB; i++){

    result = result * numA;
  }
    
    return result;
}

  Console.Write("Введите значение- A: ");

  int numA = Convert.ToInt32(Console.ReadLine());

  Console.Write("Введите значение- B: ");

  int numB = Convert.ToInt32(Console.ReadLine());

  int exponentiation = Exponentiation(numA, numB);

  Console.WriteLine("Результат: " + exponentiation);

