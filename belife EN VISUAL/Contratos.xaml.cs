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
    /// Lógica de interacción para Contratos.xaml
    /// </summary>
    public partial class Contratos : MetroWindow
    {
        static String connectionString = @"Server=LAPTOP-81O535IB\SQLEXPRESS;Database=belife;Trusted_Connection=True;";

        public Contratos()

        {
            InitializeComponent();
            btnbuscar.IsEnabled = false;
            btnborrar.IsEnabled = false;

            SqlConnection conexion = new SqlConnection();

            SqlCommand comando = new SqlCommand();

            SqlDataAdapter Adaptador = new SqlDataAdapter();

            DataSet DS = new DataSet();




            conexion.ConnectionString = @"Server=LAPTOP-81O535IB\SQLEXPRESS;Database=belife;Trusted_Connection=True;";
            conexion.Open();
            comando.CommandText = "Select* From contrato";

            comando.Connection = conexion;

            Adaptador.SelectCommand = comando;

            Adaptador.Fill(DS);

            datagridcontratos.ItemsSource = DS.Tables[0].DefaultView;

            conexion.Close();
        }

        private void datafridcontratos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtbuscarc.Text.Length >= 3)
            {
                btnbuscar.IsEnabled = true;
                btnborrar.IsEnabled = true;
            }
            else
            {
                btnbuscar.IsEnabled = false;
                btnborrar.IsEnabled = false;
            }
        }

        private void btnbuscar_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection conexion = new SqlConnection();

            SqlCommand comando = new SqlCommand();

            SqlDataAdapter Adaptador = new SqlDataAdapter();

            DataSet DS = new DataSet();

            conexion.ConnectionString = @"Server=LAPTOP-81O535IB\SQLEXPRESS;Database=belife;Trusted_Connection=True";

            conexion.Open();

            comando.CommandText = "Select* FROM contrato WHERE numero = '" + txtbuscarc.Text + "'";


            comando.Connection = conexion;

            Adaptador.SelectCommand = comando;

            Adaptador.Fill(DS);

            datagridcontratos.ItemsSource = DS.Tables[0].DefaultView;

            conexion.Close();
        }

        private async void btnborrar_Click(object sender, RoutedEventArgs e)
        {
            int flag = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(null, connection);
                command.CommandText = "DELETE FROM contrato WHERE numero ='" + txtbuscarc.Text + "'";


                connection.Open();
                flag = command.ExecuteNonQuery();

                if (flag == 1)
                {
                    await this.ShowMessageAsync("Exito", "El contrato se ha eliminado correctamente");
                    this.Hide();
                    Contratos c = new Contratos();
                    c.Show();
                }
                else
                {
                    await this.ShowMessageAsync("Error", "El contrato no se ha podido eliminar");
                }


                connection.Close();

                
            }
        }

        private void btnactualizar_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            formulario_cucontrato fc = new formulario_cucontrato();
            fc.Show();
        }

        private void Tile_Click_3(object sender, RoutedEventArgs e)
        {
            this.Hide();
            menuxaml m = new menuxaml("Keiro Esteban Palomera Avila");
            m.Show();
        }

        private void txtbuscarc_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            validar.Solonumeros(e);
        }
    }
}


