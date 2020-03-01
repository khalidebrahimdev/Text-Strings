using System;

namespace Text_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            var fullname = "Khalid Ebrahim ";

            Console.WriteLine("Trim: '{0}'", fullname.Trim());
            Console.WriteLine("ToUpper: '{0}'", fullname.Trim().ToUpper());

            var index = fullname.IndexOf(' ');

            var firstName = fullname.Substring(0, index);
            var lastName = fullname.Substring(index + 1);

            Console.WriteLine("FirstName: " + firstName);
            Console.WriteLine("LastName: " + lastName);

            var names = fullname.Split(' ');

            Console.WriteLine("FirstName: " + names[0]);
            Console.WriteLine("LastName: " + names[1]);

            var newString = fullname.Replace("Khalid", "Khalid1");
            Console.WriteLine(newString);


            if(String.IsNullOrWhiteSpace(" "))
            {
                Console.WriteLine("Invalid");
            }

            var str = "25";

            var age = Convert.ToByte(str);

            Console.WriteLine(age);


            float price = 29.95f;
            var outprice = price.ToString("C0");
            Console.WriteLine(outprice);


        }
    }
}
