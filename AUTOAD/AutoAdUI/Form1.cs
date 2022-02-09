using AUTOAD;
using AutoAdModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoAdUI
{
    public partial class Form1 : Form
    {
       
        public static AutoAdList ListaAnunturi { get; set; }
       


        public Form1()
        {
            Font = new Font(Font.Name, 8.25f * 96f / CreateGraphics().DpiX, Font.Style, Font.Unit, Font.GdiCharSet, Font.GdiVerticalFont);
            ListaAnunturi = new AutoAdList();
            InitializeComponent();
           
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            ListaAnunturi.LoadFromDisk();
            ListaAnunturi.SortById();
            UpdateGrid(ListaAnunturi);

            foreach (var item in Enum.GetValues(typeof(TipAnunt)))
            {
                TipCautare.Items.Add(item);
            }       
            pRefresh.SizeMode = PictureBoxSizeMode.StretchImage;
           //   dataGridView1.Rows.Clear();
        }

        public static void UpdateGrid(AutoAdList ListaAnunturi)
        {
            
            var bindigList = new BindingList<AutoAd>(ListaAnunturi.Anunturi);
            dataGridView1.DataSource = new BindingSource(bindigList, null);
        }


        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
       

            Form3 f3 = new Form3();
            f3.lId.Text= dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            f3.lTip.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            f3.lMarca.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            f3.lModel.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            string pret = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            f3.lPret.Text = pret ;
            f3.lPretVechi.Text = (int.Parse(pret) + 100).ToString() ;
            f3.lAn.Text =dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            f3.lCombustibil.Text =dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            f3.rtbDescriere.Text = "    " + dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            AutoAd anunt = ListaAnunturi.AnuntPotrivit(f3.lId.Text);
            f3.pbPoza.SizeMode = PictureBoxSizeMode.StretchImage;
                    f3.pbPoza.Image = Image.FromFile(anunt.Poze[1]);
                
                     if (anunt.Poze.Count-1 > 1)
                    {

                        f3.pbPoza2.SizeMode = PictureBoxSizeMode.StretchImage;
                        f3.pbPoza2.Image = Image.FromFile(anunt.Poze[2]);
                     }
                    if (anunt.Poze.Count-1 > 2)
                    {
                        f3.pbPoza3.SizeMode = PictureBoxSizeMode.StretchImage;
                        f3.pbPoza3.Image = Image.FromFile(anunt.Poze[3]);
                    }
                    if (anunt.Poze.Count-1 > 3)
                    {
                        f3.pbPoza4.SizeMode = PictureBoxSizeMode.StretchImage;
                        f3.pbPoza4.Image = Image.FromFile(anunt.Poze[4]);
                    }

            f3.ShowDialog();           
        }

        // BUTOANE
        private void bAnunt_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            ListaAnunturi.SortById();
            UpdateGrid(ListaAnunturi);
   
        }

        //ORDONARE 

        List<AutoAd> AnunturiCautate = new List<AutoAd>();
        private void prețOrdonare_Click(object sender, EventArgs e)
        {
           
            ListaAnunturi.SortByPret();
            UpdateGrid(ListaAnunturi);
        }

        private void anFabricațieOrdonare_Click(object sender, EventArgs e)
        {
            ListaAnunturi.SortByAnFab();
            UpdateGrid(ListaAnunturi);
        }
        //CAUTARE

        private void ModelCautare_Click(object sender, EventArgs e)
        {
            ModelCautare.Clear();

        }

        
        private void UpdateDataGridViewCautare()
        {
            try
            {
                var bindigList = new BindingList<AutoAd>(AnunturiCautate);
                dataGridView1.DataSource = new BindingSource(bindigList, null);
            }
            catch
            {
                MessageBox.Show("Nu exista anunturi!");
            }
        }

        private void ModelCautare_MouseLeave(object sender, EventArgs e)
        {
            if ( ModelCautare.Text!= "Model" )
            {
                string model = ModelCautare.Text;
                AnunturiCautate = ListaAnunturi.SearchByModel(model);
                UpdateDataGridViewCautare();
            }
            if (String.IsNullOrEmpty(ModelCautare.Text))
                UpdateGrid(ListaAnunturi);

        }

        private void TipCautare_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tip = TipCautare.SelectedItem.ToString();
            AnunturiCautate = ListaAnunturi.SearchByTip(tip);
            UpdateDataGridViewCautare();

        }

        private void mtbminPret_Click(object sender, EventArgs e)
        {
            mtbminPret.Clear();
        }

        private void mtbminPret_MouseLeave(object sender, EventArgs e)
        {

            try
            {
                int min = int.Parse(mtbminPret.Text);
                AnunturiCautate = ListaAnunturi.SearchByPretMinPrice(min);
                UpdateDataGridViewCautare();
            }
            catch { }
            if (String.IsNullOrEmpty(mtbminPret.Text))
                UpdateGrid(ListaAnunturi);
        }

        private void mtbmaxPret_Click(object sender, EventArgs e)
        {

            mtbmaxPret.Clear();
        }

        private void mtbmaxPret_MouseLeave(object sender, EventArgs e)
        {
            try
            {
                int max = int.Parse(mtbmaxPret.Text);
                AnunturiCautate = ListaAnunturi.SearchByPretMaxPrice(max);
                UpdateDataGridViewCautare();
            }
            catch { }
            if (String.IsNullOrEmpty(mtbmaxPret.Text))
                UpdateGrid(ListaAnunturi);

        }

        private void tbMinAn_Click(object sender, EventArgs e)
        {
            tbMinAn.Clear();
        }

        private void tbMaxAn_Click(object sender, EventArgs e)
        {
            tbMaxAn.Clear();
        }

        private void tbMinAn_MouseLeave(object sender, EventArgs e)
        {
            try
            {
                int min = int.Parse(tbMinAn.Text);
                AnunturiCautate = ListaAnunturi.SearchByPretMinYear(min);
                UpdateDataGridViewCautare();
            }
            catch { }
            if (String.IsNullOrEmpty(tbMinAn.Text))
                UpdateGrid(ListaAnunturi);
        }

        private void tbMaxAn_MouseLeave(object sender, EventArgs e)
        {
            
            try
            {
                int max = int.Parse(tbMaxAn.Text);
                AnunturiCautate = ListaAnunturi.SearchByPretMaxYear(max);
                UpdateDataGridViewCautare();
            }
            catch { }
            if (String.IsNullOrEmpty(tbMaxAn.Text))
                UpdateGrid(ListaAnunturi);
        }

        private void mscautare_Click(object sender, EventArgs e)
        {
            ModelCautare.Text = "Model";
            tbMinAn.Text = "Minim";
            tbMaxAn.Text = "Maxim";
            mtbmaxPret.Text = "Maxim";
            mtbminPret.Text= "Minim";
        }

        private void ModelCautare_Click_1(object sender, EventArgs e)
        {
            ModelCautare.Clear();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}

