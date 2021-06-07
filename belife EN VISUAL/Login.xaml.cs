using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using MahApps.Metro.Behaviours;
using System.Data.SqlClient;
using System.Web;
using System.Data;
using System.Web.UI.WebControls;

namespace metrowpf
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        SqlConnection con =new SqlConnection(@"Server=LAPTOP-81O535IB\SQLEXPRESS;Database=belife;Trusted_Connection=True;");


        internal static class Login
        {
            internal static string usuarioLogeado { get; set; }
        }

        public MainWindow()
        {
            InitializeComponent();
            btniniciar.IsEnabled = false;
        }

        private void btniniciar_Click(object sender, RoutedEventArgs e)

        {
            logear(txtrut.Text, pbcontraseña.Password);
       
        }

        public async void logear(string rut, string contraseña)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select nombre_completo,rutadmin,contraseña from administrador where rutadmin=@rutadmin and contraseña = @contraseña", con);
                cmd.Parameters.AddWithValue("@rutadmin", rut);
                cmd.Parameters.AddWithValue("@contraseña", contraseña);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count== 1)
                {
                    await this.ShowMessageAsync("Exito", "Ha iniciado sesion correctamente");
                    this.Hide();
                    new menuxaml(dt.Rows[0][0].ToString()).Show();
                    




                }
                else
                {
                    await this.ShowMessageAsync("Error", "Rut y/o cliente incorrectos");
                }
            }
            catch(Exception e)
            {
                await this.ShowMessageAsync("Error "," "+(e.Message));
            }
            finally
            {
                con.Close();
            }
        }

        private void btnregistrar_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Registro r = new Registro();
            r.Show();
        }

        private void txtusuario_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtrut.Text.Length >=9 &&(txtrut.Text.Length<=10 && (pbcontraseña.Password.Length >= 8)))
            {
                btniniciar.IsEnabled = true;
            }
            else
            {
                btniniciar.IsEnabled = false;
            }
        }

        private void pbcontraseña_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if(txtrut.Text.Length >= 9 && (txtrut.Text.Length <= 10 && (pbcontraseña.Password.Length >= 8)))
            {
                btniniciar.IsEnabled = true;
            }
            else
            {
                btniniciar.IsEnabled = false;
            }
        }
    }
}

