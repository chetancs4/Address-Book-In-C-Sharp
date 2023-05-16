namespace AddressBooks
{
    class AddressBookEntry
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
    }

    class AddressBook
    {
        public List<AddressBookEntry> entries;

        public AddressBook()
        {
            entries = new List<AddressBookEntry>();
        }

        public void AddEntry(AddressBookEntry entry)
        {
            entries.Add(entry);
        }

        public void RemoveEntry(AddressBookEntry entry)
        {
            entries.Remove(entry);
        }

        public void PrintAllEntries()
        {
            foreach (var entry in entries)
            {
                Console.WriteLine("Name: " + entry.Name);
                Console.WriteLine("Phone Number: " + entry.PhoneNumber);
                Console.WriteLine("Email: " + entry.Email);
                Console.WriteLine("--------------------------------");
            }
        }
    }

    class Program
    {
        static void Main()
        {
            AddressBook addressBook = new AddressBook();

            while (true)
            {
                Console.WriteLine("Address Book Menu");
                Console.WriteLine("-----------------");
                Console.WriteLine("1. Add Entry");
                Console.WriteLine("2. Remove Entry");
                Console.WriteLine("3. Print All Entries");
                Console.WriteLine("4. Exit");

                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter name: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter phone number: ");
                        string phoneNumber = Console.ReadLine();
                        Console.Write("Enter email: ");
                        string email = Console.ReadLine();

                        AddressBookEntry entry = new AddressBookEntry
                        {
                            Name = name,
                            PhoneNumber = phoneNumber,
                            Email = email
                        };

                        addressBook.AddEntry(entry);
                        Console.WriteLine("Entry added successfully!");
                        break;

                    case 2:
                        Console.WriteLine("Enter the name of the entry to remove: ");
                        string entryName = Console.ReadLine();

                        AddressBookEntry entryToRemove = addressBook.entries.Find(x => x.Name == entryName);

                        if (entryToRemove != null)
                        {
                            addressBook.RemoveEntry(entryToRemove);
                            Console.WriteLine("Entry removed successfully!");
                        }
                        else
                        {
                            Console.WriteLine("Entry not found.");
                        }

                        break;

                    case 3:
                        Console.WriteLine("All Entries:");
                        addressBook.PrintAllEntries();
                        break;

                    case 4:
                        Console.WriteLine("Exiting the program...");
                        return;

                    default:
                        Console.WriteLine("Invalid choice! Please try again.");
                        break;
                }

                Console.WriteLine();
            }
        }
    }

}