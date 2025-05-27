using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace LOGIN____REGISTER
{
    public partial class REGISTRARSE : Form
    {
        public REGISTRARSE()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BotonRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            try
            {
                TextWriter RegistrarUsurio = new StreamWriter(Path.Combine(@"C:\Users\USUARIO1\source\repos\LOGIN && REGISTER\LOGIN && REGISTER\bin\Debug\REGISTRO\" + textBox1.Text + ".txt"), true);
                RegistrarUsurio.WriteLine(textBox2.Text);
                RegistrarUsurio.Close();
                Form formulario = new LOGIN();
                formulario.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("No fue posible registrarse");
            }
        }

        private void REGISTRARSE_Load(object sender, EventArgs e)
        {

        }
    }
}
