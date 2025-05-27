namespace LOGIN____REGISTER
{
    using System.IO;
    using System.Linq.Expressions;

    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();
        }

        private void textLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void linkLabelRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void BotonRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formulario = new REGISTRARSE();
            formulario.Show();


        }

        private void BotonIniciarSesion_Click(object sender, EventArgs e)
        { 
            this.Hide();
            try
            {
                TextReader Inicio = new StreamReader(Path.Combine(@"C:\Users\USUARIO1\source\repos\LOGIN && REGISTER\LOGIN && REGISTER\bin\Debug\REGISTRO\", textLogin.Text + ".txt"));
                if (Inicio.ReadLine() == textPassword.Text)
                {
                    Form formulario = new INVENTARIO();
                    formulario.Show();
                }
                else
                {
                    MessageBox.Show("No se pudo iniciar sesion");
                    this.Hide();
                    Form Formulario = new LOGIN();
                    Formulario.Show();
                }
            }
            catch (Exception z)
            {
                MessageBox.Show("Hubo un error" + z, "Error");
                
            }
        }
        private void textPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
