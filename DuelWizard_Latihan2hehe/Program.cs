Wizard wizardA = new Wizard("Aryzz", 20);
Wizard wizardB = new Wizard("Kokomi", 1000);

Console.WriteLine("Permainan Dimulai...\n");
Console.WriteLine("Statistik Awal");
wizardA.ShowStats();
wizardB.ShowStats();

wizardA.Attack(wizardB);
wizardB.Attack(wizardA);

wizardA.ShowStats();
wizardB.ShowStats();

Console.WriteLine("Permainan Selesaiiii CIHUYYYYY");

public class Wizard
{
    //Field
    public string Name;
    public int Energy;
    public int Damage;


    //Constructor
    public Wizard(string name, int damage)
    {
        Name = name;
        Energy = 100;
        Damage = damage;
    }

    //Deklarasi Method
    public void ShowStats()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Energy: {Energy}\n");
    }

    public void Attack(Wizard enemyObj)
    {
        enemyObj.Energy -= Damage;
        Console.WriteLine($"{Name} menyerang {enemyObj.Name}");
        Console.WriteLine($"Sisa energy {enemyObj.Name}: {enemyObj.Energy}\n");
    }
}
