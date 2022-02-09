using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AUTOAD;
using AutoAdModel;


namespace AutoAdUI
{
    public partial class Form2 : Form
    {
        public static List<string> PozeAd = new List<string>();
        public static int nrPoza ;
        public static void LoadComboBox()
        {
            foreach (var item in Enum.GetValues(typeof(TipAnunt)))
            {
                cbTip.Items.Add(item);
            }
        }
        public Form2()
        {
            InitializeComponent();
           
        }
        private void Form2_Load(object sender, EventArgs e)
        {   if (Form3.ok == 0)
            {
                LoadComboBox();
                tbId.Text = (Form1.ListaAnunturi.Count() + 1).ToString();
            }
            tbId.Enabled = false;
            PozeAd.Clear();
            PozeAd.Add(tbId.Text);
            nrPoza = 0;
        }
        
        private void bBrowser_Click(object sender, EventArgs e)
        {
            
            if (nrPoza == 5)
                MessageBox.Show("Nu poti adauga mai mult de 4 poze!");
            else
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "Image Files(*.jpg;.jpeg;.bmp;)|*.jpg;.jpeg;.bmp;";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    PozeAd.Add(open.FileName.ToString());
                    nrPoza++;
                    if(rbPoze.Text=="1")
                        rbPoze.Text = nrPoza.ToString() + " poza adaugata! ";
                    else  rbPoze.Text = nrPoza.ToString()+ " poze adaugate! ";
                   
                }
            }
            
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbId.Text))
            {
                MessageBox.Show("id-ul nu poate lipsii");
                return;
            }

            if (string.IsNullOrEmpty(tbMarca.Text))
            {
                MessageBox.Show("Marca nu poate lipsii");
                return;
            }

            if (string.IsNullOrEmpty(tbAnFabricatie.Text))
            {
                MessageBox.Show("Anul Fabricației nu poate lipsii");
                return;
            }

            if (string.IsNullOrEmpty(tbCombustibil.Text))
            {
                MessageBox.Show("Combustibilul nu poate lipsii");
                return;
            }

            if (string.IsNullOrEmpty(tbModel.Text))
            {
                MessageBox.Show("Modelul nu poate lipsii");
                return;
            }

            if (string.IsNullOrEmpty(tbPret.Text))
            {
                MessageBox.Show("Pretul nu poate lipsii");
                return;
            }
            AutoAd anunt = new AutoAd()
            {
                Id = int.Parse(tbId.Text),
                Tip = cbTip.SelectedItem.ToString(),
                Marca = tbMarca.Text,
                Model = tbModel.Text,
                Pret = double.Parse(tbPret.Text),
                AnFabricatie = int.Parse(tbAnFabricatie.Text),
                Combustibil = tbCombustibil.Text,
                Descriere = rtbDescriere.Text,
                Poze = PozeAd

            };
            try
            {
                Form1.ListaAnunturi.Remove(anunt);
            }
            catch { } 
            Form1.ListaAnunturi.Add(anunt);
            Form1.ListaAnunturi.SaveOnDisk(anunt);
            Form1.UpdateGrid(Form1.ListaAnunturi);
            this.Hide();
         }


        // VALIDARI 

        private void tbPret_Validated(object sender, EventArgs e)
        {

            try
            {
                decimal n = decimal.Parse(tbPret.Text);
                if (n < 1)
                {
                    MessageBox.Show("Pretul trebuie sa fie un numar pozitiv");
                    ((TextBox)sender).Focus();
                }
            }
            catch
            {
                MessageBox.Show("Introduceti o valoare numerica");
                ((TextBox)sender).Focus();
            }

        }

        private void tbAnFabricatie_Validated(object sender, EventArgs e)
        {
            try
            {
                int n = int.Parse(tbAnFabricatie.Text);
                if (n< 1950 || n>DateTime.Now.Year)
                {
                    MessageBox.Show("Anul este incorect");
                    ((TextBox)sender).Focus();
                }
            }
            catch
            {
                MessageBox.Show("Introduceti o valoare numerica");
                ((TextBox)sender).Focus();
            }
        }
    }
}
