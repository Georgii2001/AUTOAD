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
    public partial class Form3 : Form
    {
    

        public Form3()
        { 
            InitializeComponent();
        }
        private void Form3_Load_1(object sender, EventArgs e)
        {
        }

        private void bRemove_Click_1(object sender, EventArgs e)
        {
            AutoAd anunt = new AutoAd()
            {
                Id = int.Parse(lId.Text),
                Tip = lTip.Text,
                Marca = lMarca.Text,
                Model = lModel.Text,
                Pret = double.Parse(lPret.Text),
                AnFabricatie = int.Parse(lAn.Text),
                Combustibil = lCombustibil.Text,
                Descriere = rtbDescriere.Text,
                Poze = Form2.PozeAd
            };
       
            Form1.ListaAnunturi.Remove(anunt);
            Form1.ListaAnunturi.DeleteOnDisk(anunt);
            Form1.UpdateGrid(Form1.ListaAnunturi);
            this.Hide();

        }
        public static int  ok = 0;
         
        private void bModifica_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            ok = 1;
            Form2.LoadComboBox();
            f2.tbId.Text = lId.Text;
            if (lTip.Text == "Vanzare")  Form2.cbTip.SelectedIndex = 0;
            else   Form2.cbTip.SelectedIndex = 1;
            f2.tbMarca.Text = lMarca.Text;
            f2.tbModel.Text = lModel.Text;
            f2.tbPret.Text = lPret.Text;
            f2.tbAnFabricatie.Text = lAn.Text;
            f2.tbCombustibil.Text = lCombustibil.Text;
            f2.rtbDescriere.Text = rtbDescriere.Text;
            this.Hide();
            f2.ShowDialog();

        }

        private void pbPoza2_Click(object sender, EventArgs e)
        {
            Image image = pbPoza.Image;
            pbPoza.Image = pbPoza2.Image;
            pbPoza2.Image = image;
        }

        private void pbPoza3_Click(object sender, EventArgs e)
        {
            Image image = pbPoza.Image;
            pbPoza.Image = pbPoza3.Image;
            pbPoza3.Image = image;
        }

        private void pbPoza4_Click(object sender, EventArgs e)
        {
            Image image = pbPoza.Image;
            pbPoza.Image = pbPoza4.Image;
            pbPoza4.Image = image;
        }
    }
}
    
