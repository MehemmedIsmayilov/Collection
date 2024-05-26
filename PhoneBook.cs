using System;
using System.Collections.Generic;
using System.Text;

namespace Collection
{
    class PhoneBook
    {
        public Dictionary<string, string> Contacts { get; set; }

        public PhoneBook()
        {

            Contacts = new Dictionary<string, string>();
        }

        public void AddContact(string name, string number)
        {
            Contacts.Add(name,number);
        }

        public void RemoveContact(string name)
        {
            if (Contacts.ContainsKey(name))
            {
                Contacts.Remove(name);
            }
            else
            {
                Console.WriteLine($"{name} Bu adda data yoxdur");
            }
        }

        public Dictionary<string, string> ButunDatalar()
        {
            return Contacts;
        }

        public string contaktim(string name)
        {
            if (Contacts.ContainsKey(name))
            {
                return Contacts[name];
            }
            else
            {
                return null;
            }
        }
    }
}
