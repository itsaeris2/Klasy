using Klasy_pocz;
Random g = new Random();
int h = g.Next(2014, 2026);
Console.WriteLine(h);
Auto a = new Auto(90.050, "Vol", "BMW", 2021);
bool menu = true;
int i = 1;
while (menu != false)
{
    Console.WriteLine("Wybierz 1-Kup 2-Przetestuj(prowadz) 3-Opis 4-Promocja wyjscie 5");
    if (int.TryParse(Console.ReadLine(), out int wybor))
    {

        switch (wybor)

        {
            case 1:
                Console.WriteLine("Kupiłeś samochód za");
                menu = false;
                break;
            case 2:
                Auto.Prowadz();
                Auto.Zatrzymaj();
                break;
            case 3:
                Auto.Opisz();
                break;
            case 4:
                Auto.Promocja();
                break;
            case 5:
                Console.WriteLine("Podaj model");
                string model  = Console.ReadLine()!;
                Console.WriteLine("Podaj marke");
                string marka = Console.ReadLine()!;
                
                
                Auto drugie = new Auto(50.000, model, marka, );
                break;
            case 6:
                menu = false;
                break;
        }
    }
    else
    {
        Console.WriteLine("To nie jest liczba");
    }
}
