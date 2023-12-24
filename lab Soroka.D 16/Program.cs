// 14 Вариант Уровень сложности Базовый

Army army = new Army();
try
{
    Console.Write("Введите вид войск: ");
    army.Troop = Console.ReadLine();
    Console.Write("Введите численность войск: ");
    army.Population = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество баллов вооруженности: ");
    army.Armament = Convert.ToInt32(Console.ReadLine());
}
catch (Exception err)
{
    Console.WriteLine(err.Message);
}

Console.WriteLine($"Вип войск: {army.Troop} | Q = {army.Q():F2}");


ChildArmy childArmy = new ChildArmy();
try
{
    Console.Write("Введите вид войск: ");
    childArmy.Troop = Console.ReadLine();
    Console.Write("Введите численность войск: ");
    childArmy.Population = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество баллов вооруженности: ");
    childArmy.Armament = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите Опыт: ");
    childArmy.P = Convert.ToInt32(Console.ReadLine());
}
catch (Exception err)
{
    Console.WriteLine(err.Message);
}

Console.WriteLine($"Событие: {childArmy.Troop} | Q = {childArmy.Q():F2}");

public class Army
{
    public string? Troop { get; set; }
    public int Population { get; set; }
    public int Armament { get; set; }

    public Army(string? troop, int population, int armament)
    {
        Troop = troop;
        Population = population;
        Armament = armament;
    }

    public Army()
    {
        Troop = "";
        Population = 0;
        Population = 0;
    }

    public double Q()
    {
        return 0.3 * Population + 0.7 * Armament;
    }
}

public class ChildArmy : Army
{
    public int P { get; set; }

    public ChildArmy(string? troop, int population, int armament, int p)
        : base(troop, population, armament)
    {
        P = p;
    }

    public ChildArmy()
    {
        P = 0;
    }


    public new double Q()
    {
        return base.Q() * (P + 1);
    }
}