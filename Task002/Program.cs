/*Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

Console.WriteLine("Введите число 1");
string numberStr1 = Console.ReadLine();
int number1 = Convert.ToInt32(numberStr1);

Console.WriteLine("Введите число 2");
string numberStr2 = Console.ReadLine();
int number2 = Convert.ToInt32(numberStr2);

Console.WriteLine("Введите число 3");
string numberStr3 = Console.ReadLine();
int number3 = Convert.ToInt32(numberStr3);

if(number1 > number2 && number1 > number3) {
    Console.WriteLine($"{number1} наибольшее число");
}
else if(number2 > number1 && number2 > number3) {
    Console.WriteLine($"{number2} наибольшее число");
}
else if(number3 > number1 && number3 > number2) {
    Console.WriteLine($"{number3} наибольшее число");
}