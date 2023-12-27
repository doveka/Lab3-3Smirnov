try
{
    Console.Write("Введите x:");    
    double x=int.Parse(Console.ReadLine());
    double s = 0;
    for (int i = 1; i <= x; i++)
        s += Math.Pow(x, 3) / 3 + Math.Pow(x, 5) / 15 + Math.Pow(x, 7) / 35 / i;
    Console.Write($"S={s:F2}");
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}
// не смог разобраться, но вроде так :(((