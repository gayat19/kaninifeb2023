using Microsoft.VisualBasic;
using System.Xml.Linq;

namespace XMLLinqApp
{
    internal class Program
    {
        void XMLtoLINQ()
        {
            var filename = "Books.xml";
            var dirName = Directory.GetCurrentDirectory();
           
            var myXml = XElement.Load(Path.Combine(dirName,filename));
            //var priceOfKarthibanBook = (from b in myXml.Descendants("BOOK") 
            //                            where b.Attribute("ID").Value=="B002" 
            //                            select b.Element("PRICE").Value).ToList()[0];
            
            var priceOfKarthibanBook = myXml.Descendants("BOOK").
                FirstOrDefault(x => x.Attribute("ID").Value == "B002").Element("PRICE").Value;
            //foreach (var item in priceOfKarthibanBook)
            //{
            //    Console.WriteLine(item);
            //}
            Console.WriteLine(priceOfKarthibanBook);
        }
        static void Main(string[] args)
        {
            new Program().XMLtoLINQ();
            Console.WriteLine("Hello, World!");
        }
    }
}