using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoAdModel
{
    public class AutoAd
    {
        public int Id { get; set; }
        public string Tip { get; set; }
        public string Marca { get; set; }
        public string Model { get; set; }
        public double Pret { get; set; }
        public int AnFabricatie { get; set; }
        public string Combustibil { get; set; }
        public string Descriere { get; set; }
        public  List<string> Poze { get; set; }

  
        public override bool Equals(object obj)
        {
            if (!(obj is AutoAd))
            {
                return false;
            }

            return (obj as AutoAd).Id == Id;
        }

    }

  
}

