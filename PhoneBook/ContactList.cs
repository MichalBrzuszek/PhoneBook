namespace PhoneBook
{
     class ContactList
    {
        public List<Contact> Contacts { get; set; } = new List<Contact>();

        public void AddContact(Contact contact)
        {
            Contacts.Add(contact);
        }

        public void DisplayContactDetails(Contact contact)
        {
            Console.WriteLine($"Contact : {contact.Name} : {contact.PhoneNumber}");
        }

        public void DisplayContactDetails(List<Contact> contacts)
        {
            foreach(Contact contact in contacts)
            {
                DisplayContactDetails(contact);
            }
        }

        public void DisplayContact(string number)
        {
            var contact = Contacts.FirstOrDefault(c => c.PhoneNumber == number);

            if(contact == null)
            {
                Console.WriteLine("Contact not found");
            }
            else
            {
                DisplayContactDetails(contact);
            }
        }

        public void DisplayList()
        {
            DisplayContactDetails(Contacts);
        }

        public void SearchContact(string search)
        {
            var contact = Contacts.Where(c => c.Name.Contains(search)).ToList();

            DisplayContactDetails(contact);
        }

    }
}
