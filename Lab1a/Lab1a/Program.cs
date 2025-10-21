using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("Який ваш улюблений фільм?");
        string favFilm = Console.ReadLine().Trim().ToLower();
        Console.WriteLine($"Ваш улюблений фільм: {favFilm}");

        switch (favFilm)
        {
            case "титанік":
                Console.WriteLine("О, класика! Справжня історія про кохання і самопожертву.");
                break;
            case "матриця":
                Console.WriteLine("Ви філософ у душі! Любите роздуми про реальність і технології.");
                break;
            case "володар перснів":
                Console.WriteLine("Фантазія, пригоди і справжня дружба — чудовий вибір!");
                break;
            case "гаррі поттер":
                Console.WriteLine("Магія дитинства! Ваша душа відкрита для чудес.");
                break;
            case "месники":
                Console.WriteLine("Ви фанат епічних битв і героїв — сила та командна робота надихають!");
                break;
            case "інтерстеллар":
                Console.WriteLine("Ви мрієте про космос і глибокий сенс буття. Дуже розумний вибір!");
                break;
            case "шрек":
                Console.WriteLine("Ви маєте чудове почуття гумору і любите, коли добро перемагає зло!");
                break;
            default:
                Console.WriteLine("Цікавий вибір! Треба буде подивитися цей фільм");
                break;
        }
    }
}

