//Напишите программу, которая на вход
//принимает два целых числа и проверяет,
//является ли первое число квадратом второго.
//a = 25, b = 5 => да
//a = 2, b = 10 => нет
//a = 9, b = -3 => да
//a = -3, b = 9 => нет


//Console.WriteLine("введите число");
//int num1 = int.Parse(Console.ReadLine());
//Console.WriteLine("введите число");
//int num2 = int.Parse(Console.ReadLine());
//if(num1 == num2 * num2)
//{
  //  Console.WriteLine("Да");
//}
//else
//{
//    Console.WriteLine("Нет");
//}



//Напишите программу, которая на вход принимает
//целое число N, а на выходе показывает все целые
//числа в промежутке от -N до N.
//Примеры
//4 => -4, -3, -2, -1, 0, 1, 2, 3, 4
//2 => -2, -1, 0, 1, 2

Console.WriteLine("введите число");
int num = int.Parse(Console.ReadLine());

int negNam = -1 * num;

while(negNam <= num)
{
    Console.Write(negNam);
    Console.Write(" ");
    negNam = negNam + 1;
    //negNam+=1;
    //negNam++;
}