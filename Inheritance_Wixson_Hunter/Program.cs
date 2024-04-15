        using System;
        
        namespace Inheritance_Wixson_Hunter
{
        class Program
    {
        static void Main(string[] args)
        {
            FPS myFPS = new FPS("E", "Zombcube");


            Console.WriteLine(myFPS.Describe());
            myFPS.PlayGame();

            FPS csGo = new FPS("M", "CS:GO");
            Console.WriteLine(csGo.Describe());
            csGo.PlayGame();

        }



    }
}