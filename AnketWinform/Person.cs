using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace AnketWinform
{
    public class Person
    {

        public static List<Person> All = new List<Person>();
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Ataadi { get; set; }
        public string Olke { get; set; }
        public string Sheher { get; set; }
        public string Telefon { get; set; }
        public string Cins { get; set; }


        public Person()
        {

        }

        public static Person Search(string name)
        {
            ReadJson();
            foreach (var item in All)
            {
                if(item.Ad==name)
                {
                    return item;
                }
            }
            return null;
        }
        public static void WriteJson()
        {
            string fileName = "../../../Persons.json";
            string json = JsonConvert.SerializeObject(All, Formatting.Indented);
            File.WriteAllText(fileName, json);
           
        }

        public static void ReadJson()
        {
            string fileName = "../../../Persons.json";
            if (File.Exists(fileName))
            {
                string json = File.ReadAllText(fileName);
               All = JsonConvert.DeserializeObject<List<Person>>(json);
               
               
            }
         
        }


        public Person(string ad,string soyad,string ataadi,string olke,string sheher,string tel,string cins)
        {
            Ad= ad;
            Soyad= soyad;
            Ataadi= ataadi;
            Olke= olke;
            Sheher= sheher;
            Telefon=tel;
            Cins= cins;
            ReadJson();
            All.Add(this);
            WriteJson();

        }
    }
}
