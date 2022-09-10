Console.WriteLine("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());

void GetDashbord(int num)
{
    for (int count = 1; count <= Math.Abs(num); count++)
    {
        Console.WriteLine($"куб числа {count} = {Math.Pow(count, 3)}");
    }
}
GetDashbord(num);