/*
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да
*/
/*
Console.Write("Enter Number: ");
string? number = Console.ReadLine();

void CheckingNumber(string number){
  if (number[0]==number[4] || number[1]==number[3]){
    Console.WriteLine($"Your Number: {number} - is polindrom.");
  }
  else Console.WriteLine($"Your Number: {number} - is Not a polindrom.");
}

if (number!.Length == 5){
  CheckingNumber(number);
}
else Console.WriteLine($"Enter the right number");
*/

// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
/*

int x1 = Coordinate("x", "A");
int y1 = Coordinate("y", "A");
int z1 = Coordinate("z", "A");
int x2 = Coordinate("x", "B");
int y2 = Coordinate("y", "B");
int z2 = Coordinate("z", "B");

int Coordinate(string coorName, string pointName)
{
    Console.Write($"Enter the coordinates : {coorName} point - {pointName}: ");
    return Convert.ToInt16(Console.ReadLine());
}

double Decision(double x1, double x2, 
                double y1, double y2, 
                double z1, double z2){
  return Math.Sqrt(Math.Pow((x2-x1), 2) + 
                   Math.Pow((y2-y1), 2) + 
                   Math.Pow((z2-z1), 2));
}

double segmentLength =  Math.Round (Decision(x1, x2, y1, y2, z1, z2), 2 );

Console.WriteLine($"The Lenght is -  {segmentLength}");

*/

