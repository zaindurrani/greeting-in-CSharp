namespace firstc_
{
    internal class Program
    {//just for practice

        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Beep();
            Console.WriteLine("Hello, everyone");

            /*hile (true)
             {
                 Console.Beep();
                        Console.SetCursorPosition(0, 0);

             }*/
            Console.WriteLine("Please enter your name :");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name);
            Console.ReadKey();
        }
    }
}