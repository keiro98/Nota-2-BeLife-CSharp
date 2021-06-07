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
using System.Data;

namespace metrowpf
{
    /// <summary>
    /// Lógica de interacción para Listadoclientes.xaml
    /// </summary>
    public partial class Listadoclientes : MetroWindow
    {
        static String connectionString = @"Server=LAPTOP-81O535IB\SQLEXPRESS;Database=belife;Trusted_Connection=True;";

        public Listadoclientes()
        {
            InitializeComponent();
            //Hacemos que algunos elementos inicien apagados
            btnbuscar.IsEnabled = false;
            btneliminar.IsEnabled = false;
            txtnombre.IsEnabled = false;
            txtapellido.IsEnabled = false;
            txtfechanac.IsEnabled = false;
            cbxestadocivil.IsEnabled = false;
            cbxsexo.IsEnabled = false;
            pbcontraseña.IsEnabled = false;
            btnactualizar.IsEnabled = false;
            //fin del apagado de elementos

            //inicio del rellenado del datagrid
            SqlConnection conexion = new SqlConnection();

            SqlCommand comando = new SqlCommand();

            SqlDataAdapter Adaptador = new SqlDataAdapter();

            DataSet DS = new DataSet();


           

            conexion.ConnectionString = @"Server=LAPTOP-81O535IB\SQLEXPRESS;Database=belife;Trusted_Connection=True;";
            conexion.Open();
            comando.CommandText = "Select* From CLIENTE";

            comando.Connection = conexion;

            Adaptador.SelectCommand = comando;

            Adaptador.Fill(DS);

            datagridcliente.ItemsSource = DS.Tables[0].DefaultView;

            conexion.Close();
        }
        //fin del rellenado del datagrid


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection conexion = new SqlConnection();

            SqlCommand comando = new SqlCommand();

            SqlDataAdapter Adaptador = new SqlDataAdapter();

            DataSet DS = new DataSet();

            conexion.ConnectionString = @"Server=LAPTOP-81O535IB\SQLEXPRESS;Database=belife;Trusted_Connection=True";
           
            conexion.Open();

            comando.CommandText = "Select* FROM cliente WHERE rutcliente = '" + txtbuscar.Text + "'";
            

            comando.Connection = conexion;

            Adaptador.SelectCommand = comando;

            Adaptador.Fill(DS);

            datagridcliente.ItemsSource = DS.Tables[0].DefaultView;

            conexion.Close();
        }
    







        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtbuscar.Text.Length >= 9 && txtbuscar.Text.Length <= 10)
            {
                btnbuscar.IsEnabled = true;
                btneliminar.IsEnabled = true;
            }
            else
            {
                btnbuscar.IsEnabled = false;
                btneliminar.IsEnabled = false;
            }
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

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
                SqlCommand comando = new SqlCommand("Select idestadocivil from EstadoCivil", connection);
                connection.Open();
                SqlDataReader registro = comando.ExecuteReader();
                while (registro.Read())
                {
                    cbxestadocivil.Items.Add(registro["idestadocivil"].ToString());
                }
                connection.Close();
            }
        }
        


            private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Listadoclientes lc = new Listadoclientes();
            lc.Show();
                }

        private void cbxfiltro_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private async void btneliminar_Click(object sender, RoutedEventArgs e)
        {
            int flag = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(null, connection);
                command.CommandText = "DELETE FROM cliente WHERE rutcliente ='" + txtbuscar.Text + "'";


                connection.Open();
                flag = command.ExecuteNonQuery();

                if (flag == 1)
                {
                    await this.ShowMessageAsync("Exito","El cliente se ha eliminado correctamente");
                    this.Hide();
                    Listadoclientes lc = new Listadoclientes();
                    lc.Show();

                }
                else
                {
                    await this.ShowMessageAsync("Error" ,"El cliente no se ha podido eliminar");
                }


                connection.Close();
            }
        }

        private void btnmodificarc_Click(object sender, RoutedEventArgs e)
        {
            flypro.IsOpen = true;
        }

        private async void btnactualizar_Click(object sender, RoutedEventArgs e)
        {
            int flag = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(null, connection);
                command.CommandText = "update cliente set nombres ='" + txtnombre.Text + "',apellidos= '" + txtapellido.Text + "',fechanacimiento= '" + txtfechanac.Text + "',idsexo= '" + int.Parse(cbxsexo.Text) + "',idestadocivil= '" + int.Parse(cbxestadocivil.Text) + "',contraseña= '" + pbcontraseña.Password + "' where rutcliente='" + txtrut.Text + "'";

                connection.Open();
                flag = command.ExecuteNonQuery();

                if (flag == 1)
                {
                    await this.ShowMessageAsync("Exito", "El cliente  ha sido actualizado correctamente");
                    this.Hide();
                    Listadoclientes lc = new Listadoclientes();
                    lc.Show();
                }
                else
                {
                    await this.ShowMessageAsync("Error", "El cliente no ha podido actualizarse , intentelo de nuevo");
                }


                connection.Close();
            }
        }

        private void btncrearc_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Registro r = new Registro();
            r.Show();

        }

        private void cbxsexo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void cbxestadocivil_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Tile_Click_3(object sender, RoutedEventArgs e)
        {
            this.Hide();
            menuxaml mx = new menuxaml("Keiro Esteban Palomera Avila");
            mx.Show();
        }

        private void txtrut_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(txtrut.Text.Length>=9 && txtrut.Text.Length<=10)
            {
                txtnombre.IsEnabled = true;
                txtapellido.IsEnabled = true;
                txtfechanac.IsEnabled = true;
                pbcontraseña.IsEnabled = true;
            }
            else
            {
                txtnombre.IsEnabled = false;
                txtapellido.IsEnabled = false;
                txtfechanac.IsEnabled = false;
                pbcontraseña.IsEnabled = false;
            }
        }

        private void txtnombre_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(txtnombre.Text.Length>0 && txtnombre.Text.Length<=20 ||txtapellido.Text.Length>0 && txtapellido.Text.Length<=20
                || txtfechanac.Text.Length == 10 || pbcontraseña.Password.Length >= 8)
            {
                btnactualizar.IsEnabled = true;
                cbxestadocivil.IsEnabled = true;
                cbxsexo.IsEnabled = true;
            }
            else
            {
                btnactualizar.IsEnabled = false;
                cbxsexo.IsEnabled = false;
                cbxestadocivil.IsEnabled = false;
            }
                
        }

        private void txtnombre_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            validar.Sololetras(e);
        }

        private void txtapellido_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            validar.Sololetras(e);
        }

        private void txtfechanac_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            int key = (int)e.Key;

            e.Handled = !(key >= 34 && key <= 43 ||
                          key >= 74 && key <= 83 ||
                          key == 2);
        }

        private void txtapellido_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtnombre.Text.Length > 0 && txtnombre.Text.Length <= 20 || txtapellido.Text.Length > 0 && txtapellido.Text.Length <= 20
                || txtfechanac.Text.Length == 10 || pbcontraseña.Password.Length >= 8)
            {
                btnactualizar.IsEnabled = true;
                cbxestadocivil.IsEnabled = true;
                cbxsexo.IsEnabled = true;
            }
            else
            {
                btnactualizar.IsEnabled = false;
                cbxsexo.IsEnabled = false;
                cbxestadocivil.IsEnabled = false;
            }
        }

        private void txtfechanac_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtnombre.Text.Length > 0 && txtnombre.Text.Length <= 20 || txtapellido.Text.Length > 0 && txtapellido.Text.Length <= 20
                || txtfechanac.Text.Length == 10 || pbcontraseña.Password.Length >= 8)
            {
                btnactualizar.IsEnabled = true;
                cbxestadocivil.IsEnabled = true;
                cbxsexo.IsEnabled = true;
            }
            else
            {
                btnactualizar.IsEnabled = false;
                cbxsexo.IsEnabled = false;
                cbxestadocivil.IsEnabled = false;
            }
        }

        private void pbcontraseña_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (txtnombre.Text.Length > 0 && txtnombre.Text.Length <= 20 || txtapellido.Text.Length > 0 && txtapellido.Text.Length <= 20
                || txtfechanac.Text.Length == 10 || pbcontraseña.Password.Length >= 8)
            {
                btnactualizar.IsEnabled = true;
                cbxestadocivil.IsEnabled = true;
                cbxsexo.IsEnabled = true;
            }
            else
            {
                btnactualizar.IsEnabled = false;
                cbxsexo.IsEnabled = false;
                cbxestadocivil.IsEnabled = false;
            }
        }
    }
}
