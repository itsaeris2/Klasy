using Klasy_pocz;

Auto a = new Auto(90050, "vol", "BMW", 2021);

bool menu = true;

while (menu != false)
{
    Console.WriteLine("1 - Kup 2 przetestuj 3 opis");
    Console.WriteLine("4 - Promocja 5 wyjście 6 znajdź auto(dodaj)");


    if (int.TryParse(Console.ReadLine(), out int wybor))
    {
        switch (wybor)
        {
            case 1:
                Console.WriteLine("Kupiono samochód");
                menu = false;
                break;

            case 2:
                a.Prowadz();
                a.Zatrzymaj();
                break;

            case 3:
                a.Opisz();
                break;

            case 4:
                a.Promocja();
                break;

            case 5:
                menu = false;
                break;

            case 6:
                a = DodajAuto();
                break;

            default:
                Console.WriteLine("źle wybrane");
                break;
        }
    }
}