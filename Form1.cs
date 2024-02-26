using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Trackbar_Cambio_tamaño_fuente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void trckBar1_Scroll_Scroll(object sender, EventArgs e)
        {
            int newSize = trckBar1_Scroll.Value;
            label1.Font = new System.Drawing.Font(label1.Font.FontFamily, Math.Max(1, newSize));
            label1.Text = "Tamaño de fuente: " + newSize.ToString();
        }
    }
    
}
