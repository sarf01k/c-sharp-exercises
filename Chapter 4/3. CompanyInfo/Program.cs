namespace CompanyInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Company name: ");
            string companyName = Console.ReadLine();

            Console.Write("Address: ");
            string address = Console.ReadLine();

            Console.Write("Phone: ");
            ulong phone = ulong.Parse(Console.ReadLine());

            Console.Write("Fax: ");
            ulong fax = ulong.Parse(Console.ReadLine());

            Console.Write("Website: ");
            string website = Console.ReadLine();

            Console.Write("\nManager name: ");
            string managerName = Console.ReadLine();

            Console.Write("Manager surname: ");
            string managerSurname = Console.ReadLine();

            Console.Write("Manager phone: ");
            ulong managerPhone = ulong.Parse(Console.ReadLine());

            Console.WriteLine(
                "\nCompany name: {1}{0}Address: {2}{0}Phone: {3:3## ### ####}{0}Fax: {4:###-###-####}{0}" + 
                "Website:{5}{0}Manager name: {6}{0}Manager surname: {7}{0}" + 
                "Manager phone: {8:### ### ####}{0}", Environment.NewLine, companyName, address, phone, fax, website,
                managerName, managerSurname, managerPhone);
        }
    }
}