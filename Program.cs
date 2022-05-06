// 1. Показать вторую цифру трёхзначного числа


System.Console.WriteLine();
int number = new Random().Next(100, 1000);

System.Console.WriteLine($"Второй цифрой числа {number} является {number / 10 % 10} ");

System.Console.WriteLine(); 


// 2. Показать последнюю цифру трёхзначного числа 

int num = new Random().Next(100, 1000);

System.Console.WriteLine($"Последней цифрой числа {number} является цифра {number%10}");
System.Console.WriteLine();


// 3. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

System.Console.WriteLine();

int dayNumber = new Random().Next(1, 8);
string[] Days = { "понедельник", "вторник", "среда", "четверг", "пятница", "суббота", "воскресенье" };
string txtResult = "";

if (dayNumber > 5) txtResult = $". Ура! Это выходной день!";
else txtResult = $", рабочий день.";

System.Console.WriteLine();
System.Console.WriteLine($"{dayNumber}-й день недели - это {Days[dayNumber - 1]}{txtResult}");
System.Console.WriteLine();