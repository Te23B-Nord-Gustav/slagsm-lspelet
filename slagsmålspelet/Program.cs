int test = 5;
Random generator = new Random();


while (test > 0)
{
    int hp1 = 10;
    int hp2 = 10;


    Console.WriteLine("tja de slagsmål spelet");
    Console.WriteLine("vad är spelare etts namn");
    string p1 = Console.ReadLine();
    Console.WriteLine("vad är spelare tvås namn");
    string p2 = Console.ReadLine();

    Thread.Sleep(1500);

    while (hp1 > 0 && hp2 > 0) 
    {
        int dmg1 = generator.Next(3);
        Console.WriteLine(hp1 + "-" + dmg1 + " " + p1 +" hp = " + hp1);
        hp1 -= dmg1;
    
        int dmg2 = generator.Next(3);
        Console.WriteLine(hp1 + "-" + dmg1 + " " + p2 +" hp = " + hp1);
        hp2 -= dmg2;

        Console.WriteLine("->");

        if (hp1 == 0)
        {
            Console.WriteLine(p2 + " van fighten");
        
        }
        else if (hp2 == 0)
        {
            Console.WriteLine(p1 + " van fighten");
        
        }
        else if (hp2 == 0 && hp1 == 0)
        {
            Console.WriteLine("Woah vilken anomaly " +p1+"&"+p2+ " Träffa varandra samtidigt samtidigt de blev lika");
            Console.WriteLine("Ingen van!!");
        }
        Thread.Sleep(500);


        

    }
    test--;
}


Console.ReadLine();