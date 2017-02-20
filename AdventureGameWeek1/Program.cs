/*Censoring America
 * by Alexis Marts, Spring 2016
 * 
 */

using System;

namespace Adventure
{
    public static class Game
    {
        static string CharacterName = "Jane Doe";

            public static void StartGame()
        {
            Console.WriteLine("Censoring America");
            Console.WriteLine("Welcome to a world over run with censorship by the orange man. Help get twitter freedom back for the EPA, NASA, National Parks, and more!");
            NameCharacter();
        }

        static void NameCharacter()
        {
            Console.WriteLine("what would you like your character's name to be?");
            CharacterName = Console.ReadLine();
            Console.WriteLine("Awesome! Your character is now named " + CharacterName + "!");
        }
        class Item
        {

        }
        class Program
        {
            static void Main()
            {
                Game.StartGame();
                Console.Read();
            }
        }
    }
}
