namespace Practical_Work_2_Enrique
{
    public partial class Form1 : Form
    {
        private bool app;

        private string nombreusr;
        private string contrasenausr;

        States state = new States();

        public Form1(States states)
        {
            this.state = states;
            this.app = true;
            
            InitializeComponent();
            CenterToScreen();
        }

        private void L_txtbox_User_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.state.ChangeForm(3);
            this.Close();
        }

        private void btn_login_click(object sender, EventArgs e)
        {
            bool login = false;
            string username = textbox_user.Text;
            string password = textbox_passwd.Text;

            string path = "users.txt";

            StreamReader sr = new StreamReader(path);

            string line = "";

            while ((line = sr.ReadLine()) != null)
            {
                string[] palabras = line.Split(';');

                this.nombreusr = palabras[1];
                this.contrasenausr = palabras[3];

                // Verificar las credenciales (ejemplo básico)
                if (username == this.nombreusr && password == this.contrasenausr)
                {
                    login = true;

                    // Mostrar la calculadora u otro formulario deseado

                    this.state.ChangeForm(4);
                    this.Close();
                }
            }

            if (login == true)
            {
                MessageBox.Show("Nombre de usuario y contraseña Correctos.", "Inicio de sesión Correcto", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else 
            {
                MessageBox.Show("Nombre de usuario o contraseña incorrectos. Por favor, inténtelo de nuevo.", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textbox_passwd_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.state.ChangeForm(2);
            this.Close();
        }
    }
}