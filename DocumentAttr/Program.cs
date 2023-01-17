using Document.Attributes;
using Document.Domain;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace DocumentAttr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            //GetDocs();

            Bezao bezao = new Bezao("bhm");
            MemberInfo info = typeof(Bezao);

            object[] attrib = info.GetCustomAttributes(typeof(DocumentAttribute), false);
            foreach (Object attribute in attrib)
            {
                DocumentAttribute b = (DocumentAttribute)attribute;
                //CompanyAttribute b = new CompanyAttribute();
                Console.WriteLine($"{b.Fullname}, {b.Description}");
                //Console.WriteLine($"{attribute.Name}, {b.Location}");
            }

            Console.ReadKey();
        }
    }
}