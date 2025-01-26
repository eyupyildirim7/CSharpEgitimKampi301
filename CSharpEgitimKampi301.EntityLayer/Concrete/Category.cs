using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.EntityLayer.Concrete
{
    public class Category

    {
        //Bunun birincil anahtar oldugunu ve otamatik artan oldugunu bildirmek adina sinifin ismi ayni ve sonuna id getirilmelidir.

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public bool CategoryStatus { get; set; }
        public List<Product> Products { get; set; }

    }
}
//field-EnvironmentVariableTarget-Property

//int x; --> Field