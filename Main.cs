// If you are a programmer editing the code, use these for graphics: ░ ▒ ▓ █ ▀ ▄ ▌ ▐

using System;
using System.Threading;
using System.Media;

class main {
    public static void Main(String[] args) {
        Console.Clear();
        Console.WriteLine(" ");
        Console.WriteLine("█       █  █████   ████    ████   █████   ███  █   █  ██ ");
        Console.WriteLine("██     ██    █    █    █  █    █    █    █   █ ██  █     ");
        Console.WriteLine("█ █   █ █    █     ██      ██       █    █   █ █ █ █     ");
        Console.WriteLine("█  █ █  █    █       ██      ██     █    █   █ █  ██     ");
        Console.WriteLine("█   █   █  █████  ████    ████    █████   ███  █   █  ██ ");
        Console.WriteLine("                                                         ");
        Console.WriteLine(" ████   █   █  ███                                       ");
        Console.WriteLine("█    █  █   █  █  █                                      ");
        Console.WriteLine(" ██     █   █  ███                                       ");
        Console.WriteLine("   ██   █   █  █  █                                      ");
        Console.WriteLine("████     ███   ███                                       ");
        Console.ReadKey();
        Console.Clear();
		Random rnd = new Random();
        int subSpot = rnd.Next(1, 3);
        var guess = "a";
        Console.Clear();
        Console.WriteLine(" ");
        Console.WriteLine("              |>");
        Console.WriteLine("              |");
        Console.WriteLine("           __________");
        Console.WriteLine(" __________|        | _______");
        Console.WriteLine(" |                         /");
        Console.WriteLine(" |                        /");
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Console.WriteLine("          A                      ");
        Console.WriteLine("                           B     ");
        Console.WriteLine("  C                              ");
        Console.WriteLine("There is a submarine, You have to shoot it down. You only have 1 missile left.");
        Console.WriteLine("Pick the spot you suspect the submarine is at: A, B, or C?");
        guess = Console.ReadLine();
        Console.WriteLine("Positioning missile...");
        Thread.Sleep(2000);
        Console.WriteLine("Firing in 5 seconds...");
        Thread.Sleep(1000);
        Console.WriteLine("Firing in 4 seconds...");
        Thread.Sleep(1000);
        Console.WriteLine("Firing in 3 seconds...");
        Thread.Sleep(1000);
        Console.WriteLine("Firing in 2 seconds...");
        Thread.Sleep(1000);
        Console.WriteLine("Firing in 1 seconds...");
        Thread.Sleep(1000);
        Console.WriteLine("Firing now!");
        Thread.Sleep(1000);
        Console.Clear();
        Console.WriteLine(" ");
        Console.WriteLine("              |>");
        Console.WriteLine("              |");
        Console.WriteLine("           __________");
        Console.WriteLine(" __________|        | ______");
        Console.WriteLine(" |                         /");
        Console.WriteLine(" |                        /");
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Console.WriteLine("          A                      ");
        Console.WriteLine("                           B     ");
        Console.WriteLine("  C                              ");
        if (guess == "A") {
            Thread.Sleep(1000);
            Console.SetCursorPosition(10, 8);
            Console.Write("X");
            Thread.Sleep(1000);
            Console.SetCursorPosition(10, 8);
            Console.Write(" ");
            Thread.Sleep(1000);
            Console.Clear();
            Console.SetCursorPosition(0, 11);
            if (subSpot == 1) {
                Console.WriteLine("You got it! You were promoted to Captian!");
            } else {
                Console.WriteLine("You didn't get it. Every plank of your ship was shredded into a million pieces!");
            }
            Console.WriteLine("Thanks for playing!");
            Thread.Sleep(5000);
            return;
        } else if (guess == "B") {
            Thread.Sleep(1000);
            Console.SetCursorPosition(27, 9);
            Console.Write("X");
            Thread.Sleep(1000);
            Console.SetCursorPosition(27, 9);
            Console.Write(" ");
            Thread.Sleep(1000);
            Console.Clear();
            Console.SetCursorPosition(0, 11);
            if (subSpot == 2) {
                Console.WriteLine("You got it! You were promoted to Captian!");
            } else {
                Console.WriteLine("You didn't get it. Every plank of your ship was shredded into a million pieces!");
            }
            Console.WriteLine("Thanks for playing!");
            Thread.Sleep(5000);
            return;
        } else if (guess == "C") {
            Thread.Sleep(1000);
            Console.SetCursorPosition(2, 10);
            Console.Write("X");
            Thread.Sleep(1000);
            Console.SetCursorPosition(2, 10);
            Console.Write(" ");
            Thread.Sleep(1000);
            Console.Clear();
            Console.SetCursorPosition(0, 11);
            if (subSpot == 3) {
                Console.WriteLine("You got it! You were promoted to Captian!");
            } else {
                Console.WriteLine("You didn't get it. Every plank of your ship was shredded into a million pieces!");
            }
            Console.WriteLine("Thanks for playing!");
            Thread.Sleep(5000);
            return;
        } else {
            Console.WriteLine("You ended up chosing a place that was not A, B, or C so the ship malfunctioned and exploded");
            Console.WriteLine("Thanks for playing!");
            Thread.Sleep(5000);
            return;
        }
        // Thanks for spending a few minutes to play this!
        //                               - Derpkitty120002
    }
}