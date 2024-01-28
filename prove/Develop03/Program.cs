using System;
using System.Net.Quic;

class Program
{
    static void Main(string[] args)
    {
        string resp = "";

        Console.Write("What is the name of the book? ");
        string book = Console.ReadLine();

        Console.Write("What is the chapter? ");
        int chapter = int.Parse(Console.ReadLine());

        Console.Write("What is the first verse? ");
        int firstVerse = int.Parse(Console.ReadLine());

        Console.Write("What is the last verse?(If is just one verse, type '0') ");
        int lastVerse = int.Parse(Console.ReadLine());

        Console.Write("Please enter the verse(text): ");
        string txt = Console.ReadLine();

        if(lastVerse != 0){
            Reference refer = new Reference(book,chapter,firstVerse,lastVerse);

            Word w = new Word(txt);

            Scripture s = new Scripture(refer, w.GetDisplayText());

            do{
                Console.Clear();
                Console.WriteLine(refer.GetDisplayText() + s.GetDisplayText());
                Console.WriteLine("Press Enter to continue or type 'quit' to end: ");
                resp = Console.ReadLine();
                s.HideRandomWords();
                bool quit = s.IsCompletelyHidden();
                if (quit == true){
                    Console.WriteLine(refer.GetDisplayText() + s.GetDisplayText());
                    resp = "quit";
                } else {
                    resp = "";
                }
            } while(resp != "quit");

        } else{
            Reference refer = new Reference(book,chapter,firstVerse);

            Word w = new Word(txt);

            Scripture s = new Scripture(refer, w.GetDisplayText());

            do{
                Console.Clear();
                Console.WriteLine(refer.GetDisplayText() + s.GetDisplayText());
                Console.WriteLine("Press Enter to continue or type 'quit' to end: ");
                resp = Console.ReadLine();
                s.HideRandomWords();
                bool quit = s.IsCompletelyHidden();
                if (quit == true){
                    Console.WriteLine(refer.GetDisplayText() + s.GetDisplayText());
                    resp = "quit";
                } else {
                    resp = "";
                }
            } while(resp != "quit");
        };


        
    }
}