using System;
using System.Collections.Generic;

namespace Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            //string reverseWord = "";
            //string word = Console.ReadLine();

            //Stack<char> myStack = new Stack<char>(word);

            //while (myStack.Count > 0)
            //{
            //    reverseWord += myStack.Pop();

            //}
            //Console.WriteLine(reverseWord);



            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


            //PhoneBook phoneBook = new PhoneBook();


            //phoneBook.AddContact("Eli", "555-1234");
            //phoneBook.AddContact("Veli", "555-5678");


            //Console.WriteLine("Datalar:");
            //foreach (var contact in phoneBook.ButunDatalar())
            //{
            //    Console.WriteLine($"{contact.Key}: {contact.Value}");
            //}


            //string foundNumber = phoneBook.contaktim("Eli");
            //if (foundNumber != null)
            //{
            //    Console.WriteLine("Elinin nomresi: " + foundNumber);
            //}
            //else
            //{
            //    Console.WriteLine("Bele data yoxdur");
            //}


            //phoneBook.RemoveContact("Veli");


            //Console.WriteLine("Butun datalar:");
            //foreach (var contact in phoneBook.ButunDatalar())
            //{
            //    Console.WriteLine($"{contact.Key}: {contact.Value}");
            //}



            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


            //Student student = new Student();

            //student.AddBal("Math", 77);
            //student.AddBal("Math", 85);
            //student.AddBal("Math", 90);
            //student.AddBal("Science", 75);


            //student.BalSil("Math", 85);


            //Console.WriteLine("Math dersinin ortalama bali: " + student.OrtalamaBal("Math"));


            //Console.WriteLine("Math dersinin ballari:");
            //List<int> mathGrades = student.ButunBallar("Math");
            //foreach (int grade in mathGrades)
            //{
            //    Console.WriteLine(grade);
            //}


            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


            //Invertory inventory = new Invertory();


            //inventory.AddProduct("Notebook", 5);
            //inventory.AddProduct("Mouse", 10);


            //inventory.RemoveProduct("Mouse");


            //inventory.UpdateQuantity("Notebook", 3);


            //Console.WriteLine("Notebook mehsulun stokdaki sayi " + inventory.GetQuantityByProduct("Notebook"));


            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


            SocialMedia socialMedia = new SocialMedia();

            
            socialMedia.AddFriend("user1", "user2");
            socialMedia.AddFriend("user1", "user3");
            socialMedia.AddFriend("user2", "user3");

            Console.WriteLine("user1'in butun dostlar");
            List<string> user1Friends = socialMedia.GetAllFriendsByUsername("user1");
            foreach (string friend in user1Friends)
            {
                Console.WriteLine(friend);
            }

            Console.WriteLine("user1'den user2'ni silmek:");
            socialMedia.RemoveFriend("user1", "user2");
            user1Friends = socialMedia.GetAllFriendsByUsername("user1");
            foreach (string friend in user1Friends)
            {
                Console.WriteLine(friend);
            }


        }
    }
}
