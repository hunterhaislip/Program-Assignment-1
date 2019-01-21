/*
 * Hunter Haislip
 * 1/21/19
 * Programming_Assignment_1.Program
 * My file for the first assignment
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Assignment_1
{
    class Program
    {
        abstract class Item
        {
            private string Name;
            private string Type;
            public double Weight = 20;
            public double ShelfLife = 20;
            public int ItemsLeft = 20;

            public void GetName(string Run)
                //Allows other classes to access the Name variable
            {
                Name = Run;
            }

            public void GetType(string Forward)
            {
                //Allows other classes to access the Type variable
                Type = Forward;
            }

            public virtual void Restock()
            {
                //Restocks an item, increases it by 5 and the shelflife by 10.5
                int TotalItem;
                double TotalLife;

                TotalItem = ItemsLeft + 5;
                TotalLife = ShelfLife + 10.5;
                Console.WriteLine("An item has been restocked, you now have " + TotalItem + " in the store");
                Console.WriteLine("The shelf life has increased for item " + Name + " and is now " + TotalLife);
                Console.WriteLine();
            }

            public virtual int Sell(int Items)
            {
                //Removes one item 
                ItemsLeft = Items;
                ItemsLeft--;
                Console.WriteLine("An item has been sold, you now have " + ItemsLeft + " left in the store");
                Console.WriteLine();
                return ItemsLeft;
            }

            public virtual void Info()
            {
                //Basic info function
                Console.WriteLine("Name: " + Name);
                Console.WriteLine("Type: " + Type);
                Console.WriteLine("Weight: " + Weight + " pounds");
                Console.WriteLine("ShelfLife: " + ShelfLife + " years");
                Console.WriteLine("Number of Items left: " + ItemsLeft);
                Console.WriteLine();
            }
        }


        class Book : Item
        {
            public void BookName()
            {
                //Asks for a name and sets the Name 
                string NewName;
                Console.WriteLine("Please enter a name for the book");
                NewName = Console.ReadLine();
                GetName(NewName);
            }

            public void GotType()
            {
                //Sets the Type
                string HEY = "Book";
                GetType(HEY);
            }

            public override void Info()
            {
                //OverRides the Info base function
                Weight = 0.5;
                ShelfLife = 100;
                ItemsLeft = 9;

                BookName();
                GotType();
                base.Info();
            }
        }


        class Movie : Item
        {
            public void MovieName()
            {
                string NewName;
                Console.WriteLine("Please enter a name for the movie");
                NewName = Console.ReadLine();
                GetName(NewName);
            }

            public void GotType()
            {
                string HEY = "Movie";
                GetType(HEY);
            }

            public override void Info()
            {
                //Overrides the Info base function
                Weight = 1.2;
                ShelfLife = 15;
                ItemsLeft = 36;

                MovieName();
                GotType();
                base.Info();
            }
        }



        class Speakers : Item
        {
            public void SpeakerName()
            {
                string NewName;
                Console.WriteLine("Please enter a name for the speakers");
                NewName = Console.ReadLine();
                GetName(NewName);
            }

            public void GotType()
            {
                string HEY = "Speakers";
                GetType(HEY);
            }

            public override void Info()
            {
                Weight = 10;
                ShelfLife = 2;
                ItemsLeft = 12;

                SpeakerName();
                GotType();
                base.Info();
            }
        }


        static void Main(string[] args)
            {
            Console.WriteLine("Welcome to the Stock Storage!");
            Console.WriteLine("Please select an item from below");
            Console.WriteLine("B = Book");
            Console.WriteLine("M = Movie");
            Console.WriteLine("S = Speakers");
            Console.WriteLine("Q = Quit Program");
            Console.WriteLine();
            string Select;
            Select = Console.ReadLine();
            while(Select != "Q")
            {
                if (Select == "B")
                {
                    Book New = new Book();
                    string Option;
                    //Basic menu for the function
                    Console.WriteLine("What would you like to do?");
                    Console.WriteLine("R = Restock");
                    Console.WriteLine("S = Sold a book");
                    Console.WriteLine("I = Info of the books");
                    Console.WriteLine("Or any other key to go back to the main menu");
                    Console.WriteLine();
                    Option = Console.ReadLine();

                    if (Option == "R")
                    {
                        New.Restock();
                    }

                    else if (Option == "S")
                    {
                        New.Sell(9);
                    }

                    else if (Option == "I")
                    {
                        New.Info();
                    }

                    else
                    {
                        Console.WriteLine("Please select an item from below");
                        Console.WriteLine("B = Book");
                        Console.WriteLine("M = Movie");
                        Console.WriteLine("S = Speakers");
                        Console.WriteLine("Q = Quit Program");
                        Console.WriteLine();
                        Select = Console.ReadLine();
                    }
                }


                if (Select == "M")
                {
                    Movie New = new Movie();
                    string Option;
                    Console.WriteLine("What would you like to do?");
                    Console.WriteLine("R = Restock");
                    Console.WriteLine("S = Sell a movie");
                    Console.WriteLine("I = Info of the Movie");
                    Console.WriteLine("Or any other key to go back to the main menu");
                    Console.WriteLine();
                    Option = Console.ReadLine();

                    if (Option == "R")
                    {
                        New.Restock();
                    }

                    else if (Option == "S")
                    {
                        New.Sell(36);
                    }

                    else if (Option == "I")
                    {
                        New.Info();
                    }

                    else
                    {
                        Console.WriteLine("Please select an item from below");
                        Console.WriteLine("B = Book");
                        Console.WriteLine("M = Movie");
                        Console.WriteLine("S = Speakers");
                        Console.WriteLine("Q = Quit Program");
                        Console.WriteLine();
                        Select = Console.ReadLine();
                    }
                }


                if (Select == "S")
                {
                    Speakers New = new Speakers();
                    string Option;
                    Console.WriteLine("What would you like to do?");
                    Console.WriteLine("R = Restock");
                    Console.WriteLine("S = Sold a book");
                    Console.WriteLine("I = Info of the books");
                    Console.WriteLine("Or any other key to go back to the main menu");
                    Console.WriteLine();
                    Option = Console.ReadLine();

                    if (Option == "R")
                    {
                        New.Restock();
                    }

                    else if (Option == "S")
                    {
                        New.Sell(12);
                    }

                    else if (Option == "I")
                    {
                        New.Info();
                    }

                    else
                    {
                        Console.WriteLine("Please select an item from below");
                        Console.WriteLine("B = Book");
                        Console.WriteLine("M = Movie");
                        Console.WriteLine("S = Speakers");
                        Console.WriteLine("Q = Quit Program");
                        Console.WriteLine();
                        Select = Console.ReadLine();
                    }
                }

            }

            }
    }
}
