using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursovaya
{
    class Library
    {
        private static Dictionary<int,Clients> clients;
        private static Dictionary<int,Books> books;
        public Library(Dictionary<int,Clients> clients1, Dictionary<int, Books> books1)
        {
            clients = clients1;
            books = books1;
          
        }

        public static Dictionary<int,Books> Books
        {
            get
            {
                return books;
            }
        }
        public static void Add_Book(int key,string name, string author, DateTime date_of_publishing, int number_of_copies)
        {
            Books book = new Books(key,name, author, date_of_publishing, number_of_copies);
            Books.Add(key,book);
        }
        public static void Delete_Book(int key)
        {
            Books.Remove(key);
        }

        public static void Add_To_Library(Dictionary<int,Clients> clients, int key, Clients client)
        {
            if (!clients.ContainsKey(key)) clients.TryAdd(key,client);
        }
        public static void Print_Information_About_Clients()
        {
            foreach (var client in clients)
            {
                Console.WriteLine($"Номер: {client.Key}  Информация: {client.Value}");
            }
        }

        public static void Print_Information_About_Books()
        {
            foreach (var book in books)
            {
                Console.WriteLine($"Номер: {book.Key}  Информация: {book.Value}");
            }
        }


        public static void Get_Book(Clients clients, Books books)
        {
            //if someone's number is in Cards:
            //writes in card example "А.С.Пушкин "Дубровский" жанр... 1845 (год публикации) 12.11.2022(дата, когда взяли книгу) 12.12.2022(дата возврата) cтатус: книга взята\ вернули"
            //else if card starts with S or T:
            //create new card 
            //else: write "Неверный ввод" and try again

        }

        public static void Pass_Book(Clients clients, Books books)
        {

        }
    }
}