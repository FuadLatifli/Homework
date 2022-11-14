#region task 4
using System;

int x = 1, y = 2, z = 5;
if (x > y && x > z)
{
    Console.WriteLine("X is the largest!");

}
else if (y > x && y > z)
{
    Console.WriteLine("Y is the largest!");
}
else 
{ Console.WriteLine("Z is the largest!");
}
#endregion

#region task 2
int n = 7;
    int i=1;
while (i <= n) { Console.Write("{0} ", i++); }
Console.WriteLine();
#endregion

#region task 5
int num = 25;
int u = 1;
while (u <= num)
{
    if (u % 2 != 0)
    {
        Console.WriteLine(u);
    }
    u++;
}
#endregion

#region task 3
int number =225;
if (number >= 70)
{
    Console.Write("{0} ", number / 70 * 3);

    Console.WriteLine();
}
else
{
    Console.Write("{0} ", 70-number);

    Console.WriteLine();
}
#endregion 