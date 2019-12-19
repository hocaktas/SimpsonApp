using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace SimpsonApp
{
    class AnaPencere:Form
    {
        Image resim;
        public AnaPencere(int genislik, int yukseklik)
        {
            
            this.Width = genislik;
            this.Height = yukseklik;
            resim = Image.FromFile("android.jpg");
            Paint += AnaPencere_Paint;


        }

        private void AnaPencere_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(resim, 0, 0);
        }
    }
}
