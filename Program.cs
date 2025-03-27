using System.Drawing;

Console.WriteLine("Vítejte v aplikaci pro výběr Pokémonů!");
Console.ForegroundColor = ConsoleColor.Yellow; 
Console.WriteLine(@"                                  ,'\
    _.----.        ____         ,'  _\   ___    ___     ____
_,-'       `.     |    |  /`.   \,-'    |   \  /   |   |    \  |`.
\      __    \    '-.  | /   `.  ___    |    \/    |   '-.   \ |  |
 \.    \ \   |  __  |  |/    ,','_  `.  |          | __  |    \|  |
   \    \/   /,' _`.|      ,' / / / /   |          ,' _`.|     |  |
    \     ,-'/  /   \    ,'   | \/ / ,`.|         /  /   \  |     |
     \    \ |   \_/  |   `-.  \    `'  /|  |    ||   \_/  | |\    |
      \    \ \      /       `-.`.___,-' |  |\  /| \      /  | |   |
       \    \ `.__,'|  |`-._    `|      |__| \/ |  `.__,'|  | |   |
        \_.-'       |__|    `-._ |              '-.|     '-.| |   |
                                `'                            '-._|");

string[] pokemoni = { "Pikachu", "Charmander", "Bulbasaur", "Squirtle", "Eevee", "Jigglypuff", "Mewtwo", "Snorlax" };

Console.WriteLine("Dostupní Pokémoni:");
for (int i = 0; i < pokemoni.Length; i++)
{
    Console.WriteLine($"{i + 1}. {pokemoni[i]}");
}

Console.Write("Vyberte Pokémona: ");
string vybranyPokemon = Console.ReadLine();

if (pokemoni.Contains(vybranyPokemon))
{
    
    Console.WriteLine($"Vybrali jste si Pokémona: {vybranyPokemon}!");
    
    switch (vybranyPokemon)
    {
        case "Pikachu":
            Console.ForegroundColor = ConsoleColor.Yellow; 
            Console.WriteLine("Typ: Elektrický");
            Console.WriteLine("Schopnosti: Statická elektřina, Blesk");
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine(@"       \:.             .:/
        \``._________.''/ 
         \             / 
 .--.--, / .':.   .':. \
/__:  /  | '::' . '::' |
   / /   |`.   ._.   .'|
  / /    |.'         '.|
 /___-_-,|.\  \   /  /.|
      // |''\.;   ;,/ '|
      `==|:=         =:|
         `.          .'
          :-._____.-:
          `''       `''");
            
            break;

        case "Charmander":
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Typ: Ohnivý");
            Console.WriteLine("Schopnosti: Plamenný ocas, Ohnivý dech");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine(@"");
            break;

        case "Bulbasaur":
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Typ: Travní/Jedovatý");
            Console.WriteLine("Schopnosti: Růst rostlin, Jedovatý prach");
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine(@"");
            break;

        case "Squirtle":
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Typ: Vodní");
            Console.WriteLine("Schopnosti: Vodní dělo, Skořápkový štít");
            Console.BackgroundColor = ConsoleColor.Blue;
            break;

        case "Eevee":
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Typ: Normální");
            Console.WriteLine("Schopnosti: Adaptace, Rychlý útok");
            Console.BackgroundColor = ConsoleColor.White;
            break;

        case "Jigglypuff":

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Typ: Normální/Vílí");
            Console.WriteLine("Schopnosti: Zpěv, Roztomilost");
            Console.BackgroundColor = ConsoleColor.Magenta;
            break;

        case "Mewtwo":
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Typ: Psychický");
            Console.WriteLine("Schopnosti: Telekineze, Psychický útok");
            Console.BackgroundColor = ConsoleColor.Cyan;
            break;

        case "Snorlax":
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("Typ: Normální");
            Console.WriteLine("Schopnosti: Imunita, Spánek");
            Console.BackgroundColor = ConsoleColor.DarkGray;
            break;
    }
}
else
{
    Console.WriteLine("Neplatná volba! Neexistující Pokémon:" + vybranyPokemon);
}

Console.WriteLine("Stiskněte libovolnou klávesu pro ukončení...");
Console.ReadKey();




