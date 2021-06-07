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
using System.Windows.Shapes;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using MahApps.Metro.Behaviours;
using System.Data.SqlClient;

namespace metrowpf
{
    /// <summary>
    /// Lógica de interacción para Registro.xaml
    /// </summary>
    public partial class Registro : MetroWindow
    {

        
        static String connectionString = @"Server=LAPTOP-81O535IB\SQLEXPRESS;Database=BeLife;Trusted_Connection=True;";

        public Registro()
        {
            InitializeComponent();
            btnregistrar.IsEnabled =false;
            cbxestadocivil.IsEnabled = false;
            cbxsexo.IsEnabled = false;
        }
        Conexion c = new Conexion();
        private void btnregistrar_Click(object sender, RoutedEventArgs e)
        {
         
           Conexion.Agregarcliente(txtrut.Text, txtnombre.Text, txtapellido.Text, txtfechanacimiento.Text,int.Parse(cbxsexo.Text),int.Parse(cbxestadocivil.Text), pbcontraseña.Password);
            this.Hide();
            Listadoclientes lc = new Listadoclientes();
            lc.Show();
            
        }

        private void txtemail_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtrut.Text.Length >= 9 && txtrut.Text.Length <= 10 && txtnombre.Text.Length > 0 && txtnombre.Text.Length <= 20
                 && txtapellido.Text.Length > 0 && txtapellido.Text.Length <= 20 && txtfechanacimiento.Text.Length == 10 &&
                 pbcontraseña.Password.Length >= 8)
            {
                btnregistrar.IsEnabled = true;
                cbxsexo.IsEnabled = true;
                cbxestadocivil.IsEnabled = true;
            }
            else
            {
                btnregistrar.IsEnabled = false;
                cbxestadocivil.IsEnabled = false;
                cbxsexo.IsEnabled = false;
            }

        }

        private void txtusuario_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtrut.Text.Length >= 9 && txtrut.Text.Length<=10  && txtnombre.Text.Length >0 && txtnombre.Text.Length <=20
                && txtapellido.Text.Length>0 && txtapellido.Text.Length<=20 &&txtfechanacimiento.Text.Length==10 &&
                pbcontraseña.Password.Length >= 8)
            {
                btnregistrar.IsEnabled = true;
                cbxsexo.IsEnabled = true;
                cbxestadocivil.IsEnabled = true;
            }
            else
            {
                btnregistrar.IsEnabled = false;
                cbxestadocivil.IsEnabled = false;
                cbxsexo.IsEnabled = false;
            }
        }

        private void pbcontraseña_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (txtrut.Text.Length >= 9 && txtrut.Text.Length <= 10 && txtnombre.Text.Length > 0 && txtnombre.Text.Length <= 20
                && txtapellido.Text.Length > 0 && txtapellido.Text.Length <= 20 && txtfechanacimiento.Text.Length == 10 &&
                pbcontraseña.Password.Length >= 8)
            {
                btnregistrar.IsEnabled = true;
                cbxsexo.IsEnabled = true;
                cbxestadocivil.IsEnabled = true;
            }
            else
            {
                btnregistrar.IsEnabled = false;
                cbxestadocivil.IsEnabled = false;
                cbxsexo.IsEnabled = false;
            }
        }

        private void MetroWindow_Loaded(object sender, RoutedEventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand comando = new SqlCommand("Select idsexo from sexo", connection);
                connection.Open();
                SqlDataReader registro = comando.ExecuteReader();
                while (registro.Read())
                {
                    cbxsexo.Items.Add(registro["idsexo"].ToString());
                }
                connection.Close();
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand comando = new SqlCommand("Select idestadocivil from estadocivil", connection);
                connection.Open();
                SqlDataReader registro = comando.ExecuteReader();
                while (registro.Read())
                {
                    cbxestadocivil.Items.Add(registro["idestadocivil"].ToString());
                }
                connection.Close();
            }
        }

        private void cbxsexo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void cbxestadocivil_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private async void btnayuda2_Click(object sender, RoutedEventArgs e)
        {
            await this.ShowMessageAsync("Informacion Estado Civil", "1.-Soltero , 2.-Casado , 3.-Divorciado , 4.-Viudo");

        }

        private async void Button_Click_1(object sender, RoutedEventArgs e)
        {
            await this.ShowMessageAsync("Informacion Sexo", "1.-Hombre , 2.-Mujer");
        }

        private async void btnayudafn_Click(object sender, RoutedEventArgs e)
        {
            await this.ShowMessageAsync("Informacion ", "Esta y todas fechas deben ingresarse en formato mes/dia/año");
        }

        private void Tile_Click_3(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Listadoclientes lc = new Listadoclientes();
            lc.Show();
        }

        private void pbcontraseña_PassworChanged(object sender, RoutedEventArgs e)
        {
            if (txtrut.Text.Length >= 9 && txtrut.Text.Length <= 10 && txtnombre.Text.Length > 0 && txtnombre.Text.Length <= 20
                && txtapellido.Text.Length > 0 && txtapellido.Text.Length <= 20 && txtfechanacimiento.Text.Length == 10 &&
                pbcontraseña.Password.Length >= 8)
            {
                btnregistrar.IsEnabled = true;
                cbxsexo.IsEnabled = true;
                cbxestadocivil.IsEnabled = true;
            }
            else
            {
                btnregistrar.IsEnabled = false;
                cbxestadocivil.IsEnabled = false;
                cbxsexo.IsEnabled = false;
            }
        }

        private void txtfechanacimiento_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            int key = (int)e.Key;

            e.Handled = !(key >= 34 && key <= 43 ||
                          key >= 74 && key <= 83 ||
                          key == 2);
        }

        private void txtapellido_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            validar.Sololetras(e);
        }

        private void txtnombre_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            validar.Sololetras(e);
        }
    }
        }
    
    
    

