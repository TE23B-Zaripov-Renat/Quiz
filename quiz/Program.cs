fråga();

static void fråga(){

Console.WriteLine ("Kollar du på fotboll?\n a)Ja \n b)Nej \n c)Lite");
string tall = Console.ReadLine();
tall = tall.ToLower();


if (tall == "a")
{
    Console.WriteLine("Va kul då.\n Vem är den bästa fotbollspelaren i värden \n a)Messi \n b)Ronaldo \n c)Neymar");

    tall = Console.ReadLine();
    tall = tall.ToLower();

     if (tall == "a")
    {
        Console.WriteLine("Du bajs skaffa liv");
    }
    else if (tall == "b")
        Console.WriteLine("Vilken legend due, respekt!");
    
    else if (tall == "c")
        Console.WriteLine("Det är bra men tyvärr inte rätt svar.");
    else
    {
        Console.WriteLine("Är du dum? Svara korrekt.");
    }
}
else
    {

        Console.WriteLine("Är du dum? Svara korrekt.");
        Console.ReadLine(); fråga();
    }
}
// string name = "Renat";

// bool isAlive = name == "Renat";

// int hp = 66 + 33;

// hp = hp + 1;

// Console.WriteLine($"Du har {hp} hp kvar");

// if (hp > 0)
// {
//     Console.WriteLine("yay! Du lever!");
// }
