using Interface_2_7.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface_2_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            ServetCetin Sc = new ServetCetin();
            MessageBox.Show(Savunma(Sc));

            Fernandao F = new Fernandao();
            MessageBox.Show(SutCek(F, 20.15f, 45));

            Hagi H = new Hagi();
          
            Calim(H, 15);
      

            Muslera M = new Muslera();
            M.Toptut();
            MessageBox.Show(TopTut(M));
            
        }
        private string SutCek(ISutCekebilable sut,float hiz,float mesafe)
        {
            return sut.SutCek(hiz,mesafe);
        }
        private string Savunma(ISavunaBilable Svn)
        {
            return Svn.SavunmaYap();
        }
        private string TopTut(ITopTutabilable top)
        {
            return top.Toptut();
        }
    private string Calim(IOyunKurabilable kur,float hiz)
        {


            return kur.CalimAt(hiz);
        }
    }
}
