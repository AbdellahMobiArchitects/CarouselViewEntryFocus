using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Mobile.Models
{
    public class Monkey : BindableObject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string Details { get; set; }
        public string ImageUrl { get; set; }


        public static List<Monkey> GetMonkeys()
        {
            return new List<Monkey>
            {
                new Monkey { Id=1, Name = "Rhesus macaque" , Details = "", Location = "", ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/d/d6/Rhesus_macaque_%28Macaca_mulatta_mulatta%29%2C_male%2C_Gokarna.jpg/330px-Rhesus_macaque_%28Macaca_mulatta_mulatta%29%2C_male%2C_Gokarna.jpg"},
                new Monkey {Id=2, Name = "Mandrill" , Details = "", Location = "", ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/e/ed/Mandrill_Albert_September_2015_Zoo_Berlin_%282%29.jpg"},
                new Monkey {Id=3, Name = "Panamanian White-faced Capuchin" , Details = "", Location = "", ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/4/40/Capuchin_Costa_Rica.jpg/1200px-Capuchin_Costa_Rica.jpg"},
            };
        }
    }
}
