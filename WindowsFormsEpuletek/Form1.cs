using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsEpuletek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Csaladihaz Kossuth = new Csaladihaz("Kossuth utca 3.", 88, new string[] {"tégla", "fa", "beton"}, DateTime.Parse("2021-11-30"), DateTime.Parse("2021-12-30"), 4, true, new string[]{ "cserép"});
            Csaladihaz Petofi = new Csaladihaz("Petőfi utca 2.", 120, new string[] { "tégla", "fa", "beton" }, DateTime.Parse("2021-12-6"), DateTime.Parse("2022-2-6"), 5, false, new string[] { "cserép" });
            Tombhaz Csapo = new Tombhaz("Csapó utca 80.", 35, new string[] { "beton", "panel" }, DateTime.Parse("2021-12-30"), DateTime.Parse("2022-2-27"), 32, new string[] { "társasház" }, true);
            Tombhaz Bercsenyi = new Tombhaz("Bercsényi utca 12.", 55, new string[] { "beton", "tégla" }, DateTime.Parse("2021-12-10"), DateTime.Parse("2021-12-30"), 15, new string[] { "társasház" }, true);

            listBox_Epuletek.Items.Add(Kossuth);
            listBox_Epuletek.Items.Add(Petofi);
            listBox_Epuletek.Items.Add(Csapo);
            listBox_Epuletek.Items.Add(Bercsenyi);

        }

        private void listBox_Epuletek_SelectedIndexChanged(object sender, EventArgs e)
        {
            var kiv = listBox_Epuletek.SelectedItem;
            if (kiv.GetType() == typeof(Csaladihaz))
            {
                label_tipus.Text = "Családi ház";
                label_tipus.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
                label9.Visible = true;
                label10.Visible = true;
                label11.Visible = true;

                textBox_cim.Visible = true;
                textBox_alapterulet.Visible = true;
                textBox_anyag.Visible = true;
                textBox_kezdet.Visible = true;
                textBox_vege.Visible = true;
                textBox_ottelok.Visible = true;
                textBox_garazs.Visible = true;
                textBox_teto.Visible = true;

                Csaladihaz item = (Csaladihaz)kiv;
                textBox_cim.Text = item.Cim;
                textBox_alapterulet.Text = item.Alapterulet.ToString();
                textBox_anyag.Text = item.Epitesianyag.ToString();
                textBox_kezdet.Text = item.Kezdet.ToString("yyyy-MM-dd");
                textBox_vege.Text = item.Vege.ToString("yyyy-MM-dd");
                textBox_ottelok.Text = item.Ottelok.ToString();
                if (item.Garazs == true)
                {
                    textBox_garazs.Text = "Van";
                }
                else
                {
                    textBox_garazs.Text = "Nincs";
                }
                textBox_teto.Text = item.Teto.ToString();


            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
