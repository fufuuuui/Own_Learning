    int hero = 10;
    int enemy = 10;

do
{

    Random atk = new Random();
    int atks_damage = atk.Next(1, 10);
    int atk_damage_mons = atk.Next(1, 5);

    enemy -= atks_damage;
    hero -= atk_damage_mons;

    Console.WriteLine($"Monster was damaged and lost {atks_damage} health and now has {enemy} health.");
    if (enemy < 0) break;
    Console.WriteLine($"Hero was damaged and lost {atk_damage_mons} health and now has {hero} health");
    if (hero < 0) break;

} while (hero > 0 && enemy > 0);

if (hero <= 0)
    Console.WriteLine("You been defeated");
else if (enemy <= 0)
    Console.WriteLine("Hero wins!");
        
// Better code learn it

// int hero = 10;
// int monster = 10;

// Random dice = new Random();

// do
// {
//     int roll = dice.Next(1, 11);
//     monster -= roll;
//     Console.WriteLine($"Monster was damaged and lost {roll} health and now has {monster} health.");

//     if (monster <= 0) continue;

//     roll = dice.Next(1, 11);
//     hero -= roll;
//     Console.WriteLine($"Hero was damaged and lost {roll} health and now has {hero} health.");

// } while (hero > 0 && monster > 0);

// Console.WriteLine(hero > monster ? "Hero wins!" : "Monster wins!");
