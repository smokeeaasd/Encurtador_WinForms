using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encurtador
{
    public partial class Form1 : Form
    {
        private const string TOKEN = "c83f202f5b7b507e37404ea97ce3e36025ef5e4d";
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnEncurtar_Click(object sender, EventArgs e)
        {
            var encurtado = await Encurtador.Encurtar(TOKEN, entryLink.Text);

            linkEncurtado.Text = encurtado.ToString();
        }
    }
}
