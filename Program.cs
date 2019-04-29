using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab_8_and_9
{
    public class Program
    {
        public static void Main()
        { 
            Student student1 = new Student()
            {
                studentID = 1,
                Name = "Gene Robinson",
                Hometown = "Detroit, MI",
                FavoriteFood = "Steak",
                FavoriteColor = "Red",
                FavoriteAnimal = "Wolves"
            };

            Student student2 = new Student()
            {
                studentID = 2,
                Name = "Brian Willard",
                Hometown = "Miami, FL",
                FavoriteFood = "BBQ Chicken",
                FavoriteColor = "Green",
                FavoriteAnimal = "Dolphins"
            };

            Student student3 = new Student()
            {
                studentID = 3,
                Name = "Monica Smith",
                Hometown = "New York City, NY",
                FavoriteFood = "Swordfish",
                FavoriteColor = "Black",
                FavoriteAnimal = "Hawks"
            };

            Student student4 = new Student()
            {
                studentID = 4,
                Name = "Angela Sain",
                Hometown = "Phoenix, AZ",
                FavoriteFood = "Tacos",
                FavoriteColor = "Purple",
                FavoriteAnimal = "Lions"
            };

            Student student5 = new Student()
            {
                studentID = 5,
                Name = "Calvin Jones",
                Hometown = "Los Angeles, CA",
                FavoriteFood = "Pulled Pork",
                FavoriteColor = "BLue",
                FavoriteAnimal = "Gorillas"
            };

            

            while (true)
            {
               Console.WriteLine("Welcome to our C# class. Which student ID would you like to learn about? (enter a number 1-5): ");
               
               int answer = Convert.ToInt32(Console.ReadLine());
               if (answer == 1) 
               {
                   Console.WriteLine($"Student 1 is {student1.Name}. Do you want to know {student1.Name}'s Hometown, Favorite Food, Color, or Animal?");
                    {
                        string answer2 = Console.ReadLine().ToLower();
                        if (answer2 == "hometown")
                        {
                            Console.WriteLine($"{student1.Name} hometown is {student1.Hometown}. Would you like to know more? (enter yes or no)");
                            while(true)
                            {
                                string answer3 = Console.ReadLine().ToLower();
                                if (answer3 == "yes") break;
                                if (answer3 == "no") return;
                            }
                        }
                        if (answer2 == "favorite food" || answer2 == "food")
                        {
                            Console.WriteLine($"{student1.Name} favorite food is {student1.FavoriteFood}. Would you like to know more? (enter yes or no)");
                            while (true)
                            {
                                string answer3 = Console.ReadLine().ToLower();
                                if (answer3 == "yes") break;
                                if (answer3 == "no") return;
                            }
                        }
                        if (answer2 == "favorite color" || answer2 == "color")
                        {
                            Console.WriteLine($"{student1.Name} favorite food is {student1.FavoriteColor}. Would you like to know more? (enter yes or no)");
                            while (true)
                            {
                                string answer3 = Console.ReadLine().ToLower();
                                if (answer3 == "yes") break;
                                if (answer3 == "no") return;
                            }
                        }
                        if (answer2 == "favorite animal" || answer2 == "animal")
                        {
                            Console.WriteLine($"{student1.Name} favorite food is {student1.FavoriteAnimal}. Would you like to know more? (enter yes or no)");
                            while (true)
                            {
                                string answer3 = Console.ReadLine().ToLower();
                                if (answer3 == "yes") break;
                                if (answer3 == "no") return;
                            }
                        }
                    }
               }
               else if (answer == 2)
               { 
                   Console.WriteLine($"Student 2 is {student2.Name}. Do you want to know {student2.Name}'s Hometown, Favorite Food, Color, or Animal?");
                   
                   string answer2 = Console.ReadLine().ToLower();
                   if (answer2 == "hometown")
                   {
                       Console.WriteLine($"{student2.Name} hometown is {student2.Hometown}. Would you like to know more? (enter yes or no)");
                       while (true)
                       {
                           string answer3 = Console.ReadLine().ToLower();
                           if (answer3 == "yes") break;
                           if (answer3 == "no") return;
                       }
                   }
                   if (answer2 == "favorite food" || answer2 == "food")
                   {
                       Console.WriteLine($"{student2.Name} favorite food is {student2.FavoriteFood}. Would you like to know more? (enter yes or no)");
                       while (true)
                       {
                           string answer3 = Console.ReadLine().ToLower();
                           if (answer3 == "yes") break;
                           if (answer3 == "no") return;
                       }
                   }
                   if (answer2 == "favorite color" || answer2 == "color")
                   {
                       Console.WriteLine($"{student2.Name} favorite food is {student2.FavoriteColor}. Would you like to know more? (enter yes or no)");
                       while (true)
                       {
                           string answer3 = Console.ReadLine().ToLower();
                           if (answer3 == "yes") break;
                           if (answer3 == "no") return;
                       }
                   }
                   if (answer2 == "favorite animal" || answer2 == "animal")
                   {
                       Console.WriteLine($"{student2.Name} favorite food is {student2.FavoriteAnimal}. Would you like to know more? (enter yes or no)");
                       while (true)
                       {
                           string answer3 = Console.ReadLine().ToLower();
                           if (answer3 == "yes") break;
                           if (answer3 == "no") return;
                       }
                   }
               }
               else if (answer == 3)
               {
                   Console.WriteLine($"Student 3 is {student3.Name}. Do you want to know {student3.Name}'s Hometown, Favorite Food, Color, or Animal?");

                   string answer2 = Console.ReadLine().ToLower();
                   if (answer2 == "hometown")
                   {
                       Console.WriteLine($"{student3.Name} hometown is {student3.Hometown}. Would you like to know more? (enter yes or no)");
                       while (true)
                       {
                           string answer3 = Console.ReadLine().ToLower();
                           if (answer3 == "yes") break;
                           if (answer3 == "no") return;
                       }
                   }
                   if (answer2 == "favorite food" || answer2 == "food")
                   {
                       Console.WriteLine($"{student3.Name} favorite food is {student3.FavoriteFood}. Would you like to know more? (enter yes or no)");
                       while (true)
                       {
                           string answer3 = Console.ReadLine().ToLower();
                           if (answer3 == "yes") break;
                           if (answer3 == "no") return;
                       }
                   }
                   if (answer2 == "favorite color" || answer2 == "color")
                   {
                       Console.WriteLine($"{student3.Name} favorite food is {student3.FavoriteColor}. Would you like to know more? (enter yes or no)");
                       while (true)
                       {
                           string answer3 = Console.ReadLine().ToLower();
                           if (answer3 == "yes") break;
                           if (answer3 == "no") return;
                       }
                   }
                   if (answer2 == "favorite animal" || answer2 == "animal")
                   {
                       Console.WriteLine($"{student3.Name} favorite food is {student3.FavoriteAnimal}. Would you like to know more? (enter yes or no)");
                       while (true)
                       {
                           string answer3 = Console.ReadLine().ToLower();
                           if (answer3 == "yes") break;
                           if (answer3 == "no") return;
                       }
                   }
               }
               else if (answer == 4)
               {
                   Console.WriteLine($"Student 4 is {student4.Name}. Do you want to know {student4.Name}'s Hometown, Favorite Food, Color, or Animal?");

                   string answer2 = Console.ReadLine().ToLower();
                   if (answer2 == "hometown")
                   {
                       Console.WriteLine($"{student4.Name} hometown is {student4.Hometown}. Would you like to know more? (enter yes or no)");
                       while (true)
                       {
                           string answer3 = Console.ReadLine().ToLower();
                           if (answer3 == "yes") break;
                           if (answer3 == "no") return;
                       }
                   }
                   if (answer2 == "favorite food" || answer2 == "food")
                   {
                       Console.WriteLine($"{student4.Name} favorite food is {student4.FavoriteFood}. Would you like to know more? (enter yes or no)");
                       while (true)
                       {
                           string answer3 = Console.ReadLine().ToLower();
                           if (answer3 == "yes") break;
                           if (answer3 == "no") return;
                       }
                   }
                   if (answer2 == "favorite color" || answer2 == "color")
                   {
                       Console.WriteLine($"{student4.Name} favorite food is {student4.FavoriteColor}. Would you like to know more? (enter yes or no)");
                       while (true)
                       {
                           string answer3 = Console.ReadLine().ToLower();
                           if (answer3 == "yes") break;
                           if (answer3 == "no") return;
                       }
                   }
                   if (answer2 == "favorite animal" || answer2 == "animal")
                   {
                       Console.WriteLine($"{student4.Name} favorite food is {student4.FavoriteAnimal}. Would you like to know more? (enter yes or no)");
                       while (true)
                       {
                           string answer3 = Console.ReadLine().ToLower();
                           if (answer3 == "yes") break;
                           if (answer3 == "no") return;
                       }
                   }
               }
               else if (answer == 5)
               {
                   Console.WriteLine($"Student 2 is {student5.Name}. Do you want to know {student5.Name}'s Hometown, Favorite Food, Color, or Animal?");

                   string answer2 = Console.ReadLine().ToLower();
                   if (answer2 == "hometown")
                   {
                       Console.WriteLine($"{student5.Name} hometown is {student5.Hometown}. Would you like to know more? (enter yes or no)");
                       while (true)
                       {
                           string answer3 = Console.ReadLine().ToLower();
                           if (answer3 == "yes") break;
                           if (answer3 == "no") return;
                       }
                   }
                   if (answer2 == "favorite food" || answer2 == "food")
                   {
                       Console.WriteLine($"{student5.Name} favorite food is {student5.FavoriteFood}. Would you like to know more? (enter yes or no)");
                       while (true)
                       {
                           string answer3 = Console.ReadLine().ToLower();
                           if (answer3 == "yes") break;
                           if (answer3 == "no") return;
                       }
                   }
                   if (answer2 == "favorite color" || answer2 == "color")
                   {
                       Console.WriteLine($"{student5.Name} favorite food is {student5.FavoriteColor}. Would you like to know more? (enter yes or no)");
                       while (true)
                       {
                           string answer3 = Console.ReadLine().ToLower();
                           if (answer3 == "yes") break;
                           if (answer3 == "no") return;
                       }
                   }
                   if (answer2 == "favorite animal" || answer2 == "animal")
                   {
                       Console.WriteLine($"{student5.Name} favorite food is {student5.FavoriteAnimal}. Would you like to know more? (enter yes or no)");
                       while (true)
                       {
                           string answer3 = Console.ReadLine().ToLower();
                           if (answer3 == "yes") break;
                           if (answer3 == "no") return;
                       }
                   }
               }
               else
               {
                    Console.WriteLine("Invalid entry. Please try again.");
               }
                Console.ReadLine();
            }
        }
    }

    public class Student
    {
        public int studentID { get; set; }
        public string Name { get; set; }
        public string Hometown { get; set; }
        public string FavoriteFood { get; set; }
        public string FavoriteColor { get; set; }
        public string FavoriteAnimal { get; set; }
    }
}
