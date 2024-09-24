using System.Reflection.Metadata;

fråga();

static void fråga()
{
    int score = 0;
    Console.WriteLine("Kollar du på fotboll?\n a)Ja \n b)Nej \n c)Lite");
    string tall = Console.ReadLine();
    tall = tall.ToLower();


    if (tall == "a")
    {
        score++;
        Console.WriteLine("Va kul då.\n Vem är den bästa fotbollspelaren i värden \n a)Messi \n b)Ronaldo \n c)Neymar");

        tall = Console.ReadLine();
        tall = tall.ToLower();

        if (tall == "a")
        {
            Console.WriteLine("Du bajs skaffa liv");
        }
        else if (tall == "b")
        {
            Console.WriteLine("Vilken legend due, respekt!");
            score++;
        }

        else if (tall == "c")
        {
            Console.WriteLine("Det är bra men tyvärr inte rätt svar.");
        }
        else
        {
            Console.WriteLine("Är du dum? Svara korrekt.");
        }
    }
    else
    {

        Console.WriteLine("Är du dum? Svara korrekt.");
        Console.ReadLine();
        fråga();
    }
    if (tall == "b")
    {
        Console.WriteLine("Är han verkligen bäst? \n a)Ja no shit \n b)Jag skoja \n c)Messi bäst");
        tall = Console.ReadLine();
        tall = tall.ToLower();

        if (tall == "a")
        {
            Console.WriteLine("Min broder det är rätt svar, Victory!");
            score++;
        }
        else if (tall == "b")
        {
            Console.WriteLine("Nahh u trippin, Game Over!");
        }

        else if (tall == "c")
        {
            Console.WriteLine("Gå här ifrån (Game Over)");
        }
        else
        {
            Console.WriteLine("Är du dum? Svara korrekt.");
        }
    }

    

    //else
    //{

    //  Console.WriteLine("Är du dum? Svara korrekt.");
    //Console.ReadLine(); fråga();
    //}
    if (score == 1)
    {
        Console.WriteLine("1 av 3. Det är bra svar men, du kan säkert bättre!");
    }

    else if (score == 2)
    {
        Console.WriteLine("2 av 3 rätt. Försök igen!");
    }

    else if (score == 3)
    {
        Console.WriteLine("3 av 3. Grattis alla rätt.");
    }
}
Console.ReadLine();


// string name = "Renat";

// bool isAlive = name == "Renat";

// int hp = 66 + 33;

// hp = hp + 1;

// Console.WriteLine($"Du har {hp} hp kvar");

// if (hp > 0)
// {
//     Console.WriteLine("yay! Du lever!");
// }
