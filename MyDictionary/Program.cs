namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            var phoneCodes = new Dictionary<int, string>()
            {
                {312,"Ankara"},
                {482,"Mardin"},
                {322,"Adana"},
                {412,"Diyarbakır"},
                {424,"Elazığ"},
                {442,"Erzurum"},
                {326,"Hatay"},
            };
            phoneCodes.Add(212,"İstanbul(Avr)");
            foreach (var phoneCity in phoneCodes)
            {
                Console.WriteLine(phoneCity);
            }
        }
        
    }
}

