








//Задача 41. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
/*
Console.Write("Введите размер массива ");

int size = (Convert.ToInt32(Console.ReadLine()));
int count = 0;
for (int i=0; i < size; i++)
{
Console.Write("Введите элемент массива ");
int elementMassiv = (Convert.ToInt32(Console.ReadLine()));
if (elementMassiv > 0) count= count+1;
}
Console.WriteLine("В массиве "+count+" положительных чисел");
*/

//задача 41. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
/*
Console.Write("Введите размер массива ");

int size = (Convert.ToInt32(Console.ReadLine()));
int count = 0;
int [] array = new int [size];

for (int i=0; i < size; i++)
{
Console.Write("Введите элемент массива ");
array[i]= (Convert.ToInt32(Console.ReadLine()));
if (array[i] > 0) count= count+1;
}

Console.WriteLine("В массиве " + count + " положительных чисел");

*/

// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

Console.WriteLine("Уравнение y=k1*x+b1");

Console.WriteLine("Введите коэффициент k1");
double K1 = (Convert.ToInt32(Console.ReadLine()));

Console.WriteLine("Введите коэффициент b1");
double B1 = (Convert.ToInt32(Console.ReadLine()));

Console.WriteLine("Уравнение y=k2*x+b2");

Console.WriteLine("Введите коэффициент k2");
double K2 = (Convert.ToInt32(Console.ReadLine()));

Console.WriteLine("Введите коэффициент b2");
double B2 = (Convert.ToInt32(Console.ReadLine()));

double X = (B2-B1)/(K1-K2);
double y = K1*X+B1;

Console.Write(X+" ; ");
Console.Write(y);






