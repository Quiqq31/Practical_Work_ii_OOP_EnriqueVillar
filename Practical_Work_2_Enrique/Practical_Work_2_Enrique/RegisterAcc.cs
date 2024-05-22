using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practical_Work_2_Enrique
{
    public partial class RegisterAcc : Form
    {
        private string NewName;
        private string NewUserName;
        private string NewEmail;
        private string NewPassword1;
        private string NewPassword2;

        private bool exist;

        private List<Usuario> users = new List<Usuario>();

        private States state = new States();

        public RegisterAcc(States states)
        {
            this.state = states;
            CargarDeFichero();

            InitializeComponent();
            CenterToScreen();
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            try
            {
                this.NewName = textbox_name.Text;
                this.NewUserName = textbox_user.Text;
                this.NewEmail = textbox_email.Text;
                this.NewPassword1 = textbox_passwd.Text;
                this.NewPassword2 = textbox_repeat_passwd.Text;

                if (NewName == "" || NewUserName == "" || NewEmail == "" || NewPassword1 == "" || NewPassword2 == "") // si hay algun campo vacio
                {
                    MessageBox.Show("No fields can be empty. Please try again.");
                }
                else // si no hay ningun campo vacio
                {

                    if (NewName == NewUserName) // error nombre de usuario y nombre personal son iguales
                    {
                        MessageBox.Show("Name and Username cannot be the same. Please try again.");
                        return;
                    }

                    if (NewPassword1.Length >= 8) // comprobamos la longitud de la contraseña, minimo 8 caracteres
                    {

                        int i = 0;
                        int numero = 0;
                        int mayuscula = 0;
                        int minuscula = 0;
                        int simbolo = 0;
                        foreach (char c in NewPassword1) // comprobamos que la contraseña tenga al menos un numero, una letra mayuscula, una minuscula y un caracter especial
                        {

                            if(char.IsDigit(c) || char.IsUpper(c) || char.IsLower(c) || char.IsSymbol(c)) // si se cumple alguna de la condiciones
                            {
                                i++;
                                if (char.IsDigit(c))
                                {
                                    numero++;
                                }else if (char.IsUpper(c))
                                {
                                    mayuscula++;
                                }else if (char.IsLower(c))
                                {
                                    minuscula++;
                                }else if (char.IsSymbol(c))
                                {
                                    simbolo++;
                                }
                            }

                            if (i >= 8) // si se cumplen las 4 condiciones
                            {
                                if (numero >= 1 && mayuscula >= 1 && minuscula >= 1 && simbolo >= 1) // si se cumplen las 4 condiciones
                                {
                                    break;
                                }
                                else
                                {
                                    MessageBox.Show("Password must contain at least one number, one uppercase letter, one lowercase letter and one special character. Please try again.");
                                    return;
                                }
                            }
                        }

                        if (NewPassword1 != NewPassword2)
                        {
                            MessageBox.Show("Passwords do not match. Please try again.");
                            return;
                        }
                    }

                    if(!checkBox1.Checked)
                    {
                        MessageBox.Show("You must accept the terms and conditions. Please try again.");
                        return;
                    }

                    foreach(Usuario u in users)
                    {
                        if(u.GetName() == textbox_name.Text || u.GetUName() == textbox_user.Text)
                        {
                            this.exist = true;
                        }
                    }


                    if(exist == false)
                    {
                        Usuario usr = new Usuario(NewName, NewUserName, NewEmail, NewPassword1);
                        users.Add(usr);

                        ActualizarCuentas(usr);

                        this.state.ChangeForm(1);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(" ERROR: A user already exists with these attributes");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.state.ChangeForm(1);
            this.Close();
        }

        public void ActualizarCuentas(Usuario usr)
        {
            string path = "users.txt";
            StreamWriter sw = File.AppendText(path);

            sw.WriteLine(usr.Print());

            sw.Close();

            MessageBox.Show("User registered successfully.");

            this.Close();
        }

        public void CargarDeFichero()
        {
            string path = "users.txt";

            StreamReader sr = new StreamReader(path);

            string linea = "";

            while ((linea = sr.ReadLine()) != null)
            {
                string[] palabras = linea.Split(';');

                Usuario usr = new Usuario(palabras[0], palabras[1], palabras[2], palabras[3]);
                this.users.Add(usr);
            }

            sr.Close();
        }
    }
}
