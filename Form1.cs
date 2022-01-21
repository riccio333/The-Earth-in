using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Earth_in
{
    public partial class The_Earth_In : Form
    {
        public The_Earth_In()
        {
            InitializeComponent();
            MaximizeBox = false;
        }

        private void lbl_title_Click(object sender, EventArgs e)
        {

        }

        private void lbl_select_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbx_planets.SelectedIndex == -1)
            {
                this.Size = new Size(811, 220);
            }
            else
            {
                this.Size = new Size(811, 583);
            }

            OnMercury();
            OnVenus();
            OnMoon();
            OnMars();
            OnJupiter();
            OnSaturn();
            OnIo();
            OnEuropa();
            OnTitan();
            OnUranus();
            OnNeptune();
            OnTriton();
            OnPluto();
        }

        private void OnMercury()
        {
            if (cbx_planets.SelectedIndex==0)
            {
                double EarthsOnMercury = (6.083 * (Math.Pow(10, 19))) / (1.08321 * (Math.Pow(10, 21)));
                double MercuryOnEarth = (1.08321 * (Math.Pow(10, 21))) / (6.083 * (Math.Pow(10, 19)));

                lbl_EarthIn.Text = "In " + cbx_planets.Text + " can fit " + EarthsOnMercury.ToString("0.000") + " Earths";
                lbl_secondary.Text = "and in the Earth can fit " + MercuryOnEarth.ToString("0.0") + " mercury";

                comparison_image.SizeMode = PictureBoxSizeMode.StretchImage;
                comparison_image.Image = Properties.Resources.mercury;
                comparison_image.Location = new Point(202, 218);
                comparison_image.Size = new Size(396, 287);
            }
        }

        private void OnVenus()
        {
            if (cbx_planets.SelectedIndex == 1)
            {
                double EarthsOnVenus = (9.2843 * (Math.Pow(10, 20))) / (1.08321 * (Math.Pow(10, 21)));
                double VenusOnEarth = (1.08321 * (Math.Pow(10, 21))) / (9.2843 * (Math.Pow(10, 20)));

                lbl_EarthIn.Text= "In " + cbx_planets.Text + " can fit " + EarthsOnVenus.ToString("0.00") + " Earths";
                lbl_secondary.Text = "and in the Earth can fit " + VenusOnEarth.ToString("0.0") + " venus";

                comparison_image.SizeMode = PictureBoxSizeMode.StretchImage;
                comparison_image.Image = Properties.Resources.venus;
                comparison_image.Location = new Point(156, 227);
                comparison_image.Size = new Size(500, 263);
            }
        }

        private void OnMoon()
        {
            if(cbx_planets.SelectedIndex == 2)
            {
                double EarthsOnMoon = (2.1958 * (Math.Pow(10, 19))) / (1.08321 * (Math.Pow(10, 21)));
                double MoonsOnEarth = (1.08321 * (Math.Pow(10, 21))) / (2.1958 * (Math.Pow(10, 19)));

                lbl_EarthIn.Text = "In " + cbx_planets.Text + " can fit " + EarthsOnMoon.ToString("0.000") + " Earths";
                lbl_secondary.Text = "and in the Earth can fit " + MoonsOnEarth.ToString("0.0") + " moons";

                comparison_image.SizeMode = PictureBoxSizeMode.StretchImage;
                comparison_image.Image = Properties.Resources.moon;
                comparison_image.Location = new Point(224, 234);
                comparison_image.Size = new Size(352, 277);
            }
        }

        private void OnMars()
        {
            if(cbx_planets.SelectedIndex == 3)
            {
                double EarthsOnMars = (1.6318 * (Math.Pow(10, 20))) / (1.08321 * (Math.Pow(10, 21)));
                double MarsOnEarth = (1.08321 * (Math.Pow(10, 21))) / (1.6318 * (Math.Pow(10, 20)));

                lbl_EarthIn.Text = "In " + cbx_planets.Text + " can fit " + EarthsOnMars.ToString("0.000") + " Earths";
                lbl_secondary.Text = "and in the Earth can fit " + MarsOnEarth.ToString("0.0") + " mars";

                comparison_image.SizeMode = PictureBoxSizeMode.StretchImage;
                comparison_image.Image = Properties.Resources.mars;
                comparison_image.Location = new Point(204, 239);
                comparison_image.Size = new Size(400, 260);
            }
        }

        private void OnJupiter()
        {
            if(cbx_planets.SelectedIndex == 4)
            {
                double EarthsOnJupiter = (1.43128 * (Math.Pow(10, 24))) / (1.08321 * (Math.Pow(10, 21)));

                lbl_EarthIn.Text = "In " + cbx_planets.Text + " can fit " + EarthsOnJupiter.ToString("0.00") + " Earths";
                lbl_secondary.Text = "";

                comparison_image.SizeMode = PictureBoxSizeMode.StretchImage;
                comparison_image.Image = Properties.Resources.jupiter;
                comparison_image.Location = new Point(172, 196);
                comparison_image.Size = new Size(473, 350);
            }
        }

        private void OnIo()
        {
            if(cbx_planets.SelectedIndex == 5)
            {
                double EarthsOnIo = (2.53 * (Math.Pow(10, 19))) / (1.08321 * (Math.Pow(10, 21)));
                double IoOnEarth = (1.08321 * (Math.Pow(10, 21))) / (2.53 * (Math.Pow(10, 19)));

                lbl_EarthIn.Text = "In " + cbx_planets.Text + " can fit " + EarthsOnIo.ToString("0.000") + " Earths";
                lbl_secondary.Text = "and in the Earth can fit " + IoOnEarth.ToString("0.0") + " Io";

                comparison_image.SizeMode = PictureBoxSizeMode.StretchImage;
                comparison_image.Image = Properties.Resources.io;
                comparison_image.Location = new Point(155, 195);
                comparison_image.Size = new Size(500, 337);
            }
        }

        private void OnEuropa()
        {
            if( cbx_planets.SelectedIndex == 6)
            {
                double EarthsOnEuropa = (1.593 * (Math.Pow(10, 19))) / (1.08321 * (Math.Pow(10, 21)));
                double EuropaOnEarth = (1.08321 * (Math.Pow(10, 21))) / (1.593 * (Math.Pow(10, 19)));

                lbl_EarthIn.Text = "In " + cbx_planets.Text + " can fit " + EarthsOnEuropa.ToString("0.000") + " Earths";
                lbl_secondary.Text = "and in the Earth can fit " + EuropaOnEarth.ToString("0.0") + " Europa";

                comparison_image.SizeMode = PictureBoxSizeMode.StretchImage;
                comparison_image.Image = Properties.Resources.europa;
                comparison_image.Location = new Point(155, 195);
                comparison_image.Size = new Size(500, 337);
            }
        }

        private void OnSaturn()
        {
            if(cbx_planets.SelectedIndex == 7)
            {
                double EarthsOnSaturn = (8.27 * (Math.Pow(10, 23))) / (1.08321 * (Math.Pow(10, 21)));

                lbl_EarthIn.Text = "In " + cbx_planets.Text + " can fit " + EarthsOnSaturn.ToString("0.00") + " Earths";
                lbl_secondary.Text = "";

                comparison_image.SizeMode = PictureBoxSizeMode.StretchImage;
                comparison_image.Image = Properties.Resources.saturn;
                comparison_image.Location = new Point(92, 205);
                comparison_image.Size = new Size(639, 282);
            }
        }

        private void OnTitan()
        {
            if(cbx_planets.SelectedIndex == 8)
            {
                double EarthsOnTitan = (7.16 * (Math.Pow(10, 19))) / (1.08321 * (Math.Pow(10, 21)));
                double TitanOnEarth = (1.08321 * (Math.Pow(10, 21))) / (7.16 * (Math.Pow(10, 19)));

                lbl_EarthIn.Text = "In " + cbx_planets.Text + " can fit " + EarthsOnTitan.ToString("0.000") + " Earths";
                lbl_secondary.Text = "and in the Earth can fit " + TitanOnEarth.ToString("0.0") + " Titan";

                comparison_image.SizeMode = PictureBoxSizeMode.StretchImage;
                comparison_image.Image = Properties.Resources.titan;
                comparison_image.Location = new Point(155, 195);
                comparison_image.Size = new Size(500, 337);
            }
        }

        private void OnUranus()
        {
            if(cbx_planets.SelectedIndex == 9)
            {
                double EarthsOnUranus = (6.833 * (Math.Pow(10, 22))) / (1.08321 * (Math.Pow(10, 21)));

                lbl_EarthIn.Text = "In " + cbx_planets.Text + " can fit " + EarthsOnUranus.ToString("0.00") + " Earths";
                lbl_secondary.Text = "";

                comparison_image.SizeMode = PictureBoxSizeMode.StretchImage;
                comparison_image.Image = Properties.Resources.uranus;
                comparison_image.Location = new Point(172, 205);
                comparison_image.Size = new Size(445, 326);
            }
        }

        private void OnNeptune()
        {
            if(cbx_planets.SelectedIndex == 10)
            {
                double EarthsOnNeptune = (6.254 * (Math.Pow(10, 22))) / (1.08321 * (Math.Pow(10, 21)));

                lbl_EarthIn.Text = "In " + cbx_planets.Text + " can fit " + EarthsOnNeptune.ToString("0.00") + " Earths";
                lbl_secondary.Text = "";

                comparison_image.SizeMode = PictureBoxSizeMode.StretchImage;
                comparison_image.Image = Properties.Resources.neptune;
                comparison_image.Location = new Point(172, 191);
                comparison_image.Size = new Size(465, 341);
            }
        }

        private void OnTriton()
        {
            if(cbx_planets.SelectedIndex == 11)
            {
                double EarthsOnTriton = (1.0384 * (Math.Pow(10, 19))) / (1.08321 * (Math.Pow(10, 21)));
                double TritonOnEarth = (1.08321 * (Math.Pow(10, 21))) / (1.0384 * (Math.Pow(10, 19)));

                lbl_EarthIn.Text = "In " + cbx_planets.Text + " can fit " + EarthsOnTriton.ToString("0.000") + " Earths";
                lbl_secondary.Text = "and in the Earth can fit " + TritonOnEarth.ToString("0.0") + " Triton";

                comparison_image.SizeMode = PictureBoxSizeMode.StretchImage;
                comparison_image.Image = Properties.Resources.triton;
                comparison_image.Location = new Point(172, 205);
                comparison_image.Size = new Size(457, 308);
            }
        }

        private void OnPluto()
        {
            if(cbx_planets.SelectedIndex == 12)
            {
                double EarthsOnPluto = (6.39 * (Math.Pow(10, 18))) / (1.08321 * (Math.Pow(10, 21)));
                double PlutoOnEarth = (1.08321 * (Math.Pow(10, 21))) / (6.39 * (Math.Pow(10, 18)));

                lbl_EarthIn.Text = "In " + cbx_planets.Text + " can fit " + EarthsOnPluto.ToString("0.000") + " Earths";
                lbl_secondary.Text = "and in the Earth can fit " + PlutoOnEarth.ToString("0.0") + " Pluto";

                comparison_image.SizeMode = PictureBoxSizeMode.StretchImage;
                comparison_image.Image = Properties.Resources.pluto;
                comparison_image.Location = new Point(181, 185);
                comparison_image.Size = new Size(444, 357);
            }
        }

        private void lab_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/riccio333/The-Earth-In");
        }
    }
}
