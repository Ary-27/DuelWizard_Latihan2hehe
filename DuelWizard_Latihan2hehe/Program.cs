using System;
using System.Xml;

Wizard wizardA = new Wizard("Aryzz", 20);
Wizard wizardB = new Wizard("Kokomi", 30);

Console.WriteLine("Permainan Dimulai...\n");
Console.WriteLine("Statistik Awal");
wizardA.ShowStats();
wizardB.ShowStats();

string pilihan;

while (true)
{

    Console.Clear();

    Console.WriteLine($"1. {wizardA.Name} menyerang {wizardB.Name}");
    Console.WriteLine($"2. {wizardB.Name} menyerang {wizardA.Name}");
    Console.WriteLine($"3. {wizardA.Name} melakukan heal");
    Console.WriteLine($"4. {wizardB.Name} melakukan heal");

    Console.WriteLine("\nPilih (1/2/3/4)");
    pilihan = Console.ReadLine();

    if (pilihan == "1")
    {
        wizardA.Attack(wizardB);
    }
    else if (pilihan == "2")
    {
        wizardB.Attack(wizardA);
    }
    else if (pilihan == "3")
    {
        wizardA.Heal();
    }
    else if (pilihan == "4")
    {
        wizardB.Heal();
    }
    else
    {
        Console.WriteLine("Pilihan tidak valid. Silakan pilih 1, 2, 3, atau 4.");
        continue;
    }
    if (wizardA.Energy <= 0 || wizardB.Energy <= 0)
    {
        Console.WriteLine("Permainan Selesai!");
        if (wizardA.Energy > wizardB.Energy)
        {
            Console.WriteLine($"{wizardB.Name} Berhasil dikalahkan");
            Console.WriteLine($"{wizardA} Pemenangnya");
        }
        else
        {
            Console.WriteLine($"{wizardA.Name} Berhasil dikalahkan");
            Console.WriteLine($"{wizardB} Pemenangnya");
        }
        break;
    }

    Console.ReadLine();
}

//wizardA.Attack(wizardB);
//wizardB.Attack(wizardA);
//wizardA.Attack(wizardB);
//wizardB.Heal();

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

    //Method Heal
    public void Heal()
    {
        if (Energy >= 100)
        {
            Console.WriteLine($"Gagal melakukan heal. Energi sudah full");
        }
        else
        {
            if (Energy > 95)
            {
                Energy = 100;
            }
            else
            {
                Energy += 10;
            }
        Console.WriteLine($"{Name} melakukan heal. Energi sekarang menjadi: {Energy}");
        }
    }
}
