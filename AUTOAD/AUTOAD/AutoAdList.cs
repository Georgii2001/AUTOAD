using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoAdModel
{
    public class AutoAdList
    {
        public List<AutoAd> Anunturi;

        public AutoAdList()
        {
            Anunturi = new List<AutoAd>();
        }
        public int Count() {
            return Anunturi.Count;
        } 
        //BUTOANE
        public void Add(AutoAd anunt)
        {
            if (Anunturi.Contains(anunt))
              throw new Exception($" Anuntul [{anunt}] exista deja!");
            Anunturi.Add(anunt);
        }

        public void Remove(AutoAd anunt)
        {
            if (!Anunturi.Contains(anunt))
            {
                throw new Exception($"Anuntul [{anunt.Id}] nu exista!");
            }
            Anunturi.Remove(anunt);
            
        }
        //ORDONARE
        List<AutoAd> AnunturiCautate = new List<AutoAd>();

        public void SortByPret()
        {
            if (AnunturiCautate.Count > 0)
                Anunturi = AnunturiCautate.OrderBy(anunt => anunt.Pret).ToList();
            else
            Anunturi = Anunturi.OrderBy(anunt => anunt.Pret).ToList();
        }

        public void SortByAnFab()
        {
            if (AnunturiCautate.Count > 0)
                Anunturi = AnunturiCautate.OrderByDescending(anunt => anunt.AnFabricatie).ToList();
            else
                Anunturi = Anunturi.OrderByDescending(anunt => anunt.AnFabricatie).ToList();
        }
        public void SortById()
        {
            Anunturi = Anunturi.OrderBy(anunt => anunt.Id).ToList();
        }

        //CAUTARE

      

        public List<AutoAd> SearchByPretMinPrice(int min)
        {
            if(AnunturiCautate.Count>0)
                return AnunturiCautate = AnunturiCautate.Where(anunt => anunt.Pret >= min).ToList();
            return  AnunturiCautate = Anunturi.Where(anunt => anunt.Pret >= min).ToList();
        }

        public List<AutoAd> SearchByPretMaxPrice(int max)
        {
            if (AnunturiCautate.Count > 0)
                return AnunturiCautate = AnunturiCautate.Where(anunt => anunt.Pret <= max).ToList();
            return AnunturiCautate = Anunturi.Where(anunt => anunt.Pret <= max).ToList();
        }

        public List<AutoAd> SearchByPretMaxYear(int max)
        {
            if (AnunturiCautate.Count > 0)
                return AnunturiCautate = AnunturiCautate.Where(anunt => anunt.AnFabricatie <= max).ToList();
            return AnunturiCautate = Anunturi.Where(anunt => anunt.AnFabricatie <= max).ToList();
        }

        public List<AutoAd> SearchByPretMinYear(int min)
        {
            if (AnunturiCautate.Count > 0)
                return AnunturiCautate = AnunturiCautate.Where(anunt => anunt.AnFabricatie >= min).ToList();
            return AnunturiCautate = Anunturi.Where(anunt => anunt.AnFabricatie >= min).ToList();
        }
       
        public List<AutoAd> SearchByModel(string Model)
        {

            if (AnunturiCautate.Count == 0)
                foreach (var anunt in Anunturi)
                {
                    if (anunt.Model.ToLower() == Model.ToLower())
                    {
                        AnunturiCautate.Add(anunt);

                    }
                }
            else {
                foreach (var anunt in Anunturi)
                {
                    if (anunt.Model.ToLower() != Model.ToLower())
                    {
                        AnunturiCautate.Remove(anunt);

                    }
                }

            }
                return AnunturiCautate;

        }


        public List<AutoAd> SearchByTip(string tip)
        {
            if (AnunturiCautate.Count == 0)
                foreach (var anunt in Anunturi)
                {
                    if (anunt.Tip == tip)
                    {
                        AnunturiCautate.Add(anunt);

                    }
                }
            else {
                foreach (var anunt in Anunturi)
                {
                    if (anunt.Tip != tip)
                    {
                        AnunturiCautate.Remove(anunt);

                    }
                }
            }

            return AnunturiCautate;
           
        }
        //Anunt potrivit 
        public AutoAd AnuntPotrivit(string x)
        {

            foreach (AutoAd anunt in Anunturi) {
                if (anunt.Poze[0] == x)
                    return anunt;
            }
            return null;
        }
       //OPERATII
        public void SaveOnDisk(AutoAd anunt)
        {
             
            var folderParent = ConfigurationManager.AppSettings["FilePath"];
            if (!Directory.Exists("Anunt_" + anunt.Id))
            {
                string pathString = Path.Combine(folderParent, "Anunt_" + anunt.Id);
               
                    Directory.CreateDirectory(pathString);
                    string fileName = "Anunt_" + anunt.Id + ".json";
                    File.WriteAllText(Path.Combine(pathString, fileName), JsonConvert.SerializeObject(anunt));
            }
            else throw new Exception($" Id-ul  [{anunt.Id}] exista deja!");
        }
            

        public void DeleteOnDisk(AutoAd anunt)
        {
            /*  -- cum sa muti poza in calea ta 
            var txtFiles = Directory.EnumerateFiles(sourceDirectory, "*.txt");

            foreach (string currentFile in txtFiles)
            {
                string fileName = currentFile.Substring(sourceDirectory.Length + 1);
                Directory.Move(currentFile, Path.Combine(archiveDirectory, fileName));
            }
            */
            var folderParent = ConfigurationManager.AppSettings["FilePath"];
            string pathString = Path.Combine(folderParent, "Anunt_" + anunt.Id);

            string[] files = Directory.GetFiles(pathString);

            foreach (string file in files)
            {
                File.SetAttributes(file, FileAttributes.Normal);
                File.Delete(file);
            }

            Directory.Delete(pathString);
        }

        public  void LoadFromDisk()
        {
            var folderParent = ConfigurationManager.AppSettings["FilePath"];
            string[] folderChilds = Directory.GetDirectories(folderParent, "*");
             AutoAd anunt ;
            foreach (string folderChild in folderChilds)
            {
                var fInfo = new DirectoryInfo(folderChild);
                var content = Path.Combine(folderChild, $"{fInfo.Name}.json");

                anunt = JsonConvert.DeserializeObject<AutoAd>(File.ReadAllText(content));
                Anunturi.Add(anunt);

            }

        }
  
        public override string ToString()
       {
         return JsonConvert.SerializeObject(Anunturi);
       }
       
    }
}

