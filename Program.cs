using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnverSOft_CSV
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = ConfigurationManager.AppSettings["File"].ToString();


            using (var reader = new StreamReader(path))
            {
                string fileinfo = reader.ReadToEnd();

                reader.Close();
                reader.Close();
                OrderByFrequencyThenAlphabaticalOrder( fileinfo);
                //WriteErrorLog(fileToLoad + "loaded");
                //Console.WriteLine(fileToLoad + "loaded");

            }
        }

        public static void OrderByFrequencyThenAlphabaticalOrder(string content)
        {
            List<string> list = content.Split(';').ToList();

        }
        public static void AddressesSortedAlphabeticallyByStreetName(string content)
        {

        }
        public static void FrequencyFirstDescendingAndThenAlphabeticallyAscendingAlphabaticalOrder(string content)
        {

        }
        public static void ListOfNames(string content)
        {

        }

        public static void FirstList(string content)
        {

        }
    }
}
