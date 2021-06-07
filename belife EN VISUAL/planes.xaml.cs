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
    /// Lógica de interacción para planes.xaml
    /// </summary>
    public partial class planes :MetroWindow
    {
        static String connectionString = @"Server=LAPTOP-81O535IB\SQLEXPRESS;Database=belife;Trusted_Connection=True;";

        public planes()
        {
            InitializeComponent();
            //Hacemos algunos elementos inicien apagados
            btnbuscarp.IsEnabled = false;
            btneliminarp.IsEnabled = false;
            btncreaplan.IsEnabled = false;
            btnmodificarp.IsEnabled = false;
            txtnombrep.IsEnabled = false;
            txtaprimabase.IsEnabled = false;
            txtpolizaactual.IsEnabled = false;
            //fin


            //Lenar Datos datagrid
            SqlConnection conexion = new SqlConnection();

            SqlCommand comando = new SqlCommand();

            SqlDataAdapter Adaptador = new SqlDataAdapter();

            DataSet DS = new DataSet();

            conexion.ConnectionString = @"Server=LAPTOP-81O535IB\SQLEXPRESS;Database=belife;Trusted_Connection=True;";
            conexion.Open();
            comando.CommandText = "Select idplan,nombre,primabase,polizaActual From [Plan]";

            comando.Connection = conexion;

            Adaptador.SelectCommand = comando;

            Adaptador.Fill(DS);

            dgplanes.ItemsSource = DS.Tables[0].DefaultView;

            conexion.Close();
            //Fin del llenado de datos del datagrid
        }

        private void Tile_Click_3(object sender, RoutedEventArgs e)
        {
            this.Hide();
            menuxaml m = new menuxaml("Keiro Esteban Palonera Avila");
            m.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection conexion = new SqlConnection();

            SqlCommand comando = new SqlCommand();

            SqlDataAdapter Adaptador = new SqlDataAdapter();

            DataSet DS = new DataSet();

            conexion.ConnectionString = @"Server=LAPTOP-81O535IB\SQLEXPRESS;Database=belife;Trusted_Connection=True";

            conexion.Open();

            comando.CommandText = "Select* FROM [plan] WHERE idplan=@idplan";
            comando.Parameters.AddWithValue("@idplan", txtbuscarp.Text);

            comando.Connection = conexion;

            Adaptador.SelectCommand = comando;

            Adaptador.Fill(DS);

            dgplanes.ItemsSource = DS.Tables[0].DefaultView;

            conexion.Close();
        }
    

        private async void btneliminar_Click(object sender, RoutedEventArgs e)
        {
            int flag = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(null, connection);
                command.CommandText = "DELETE FROM [plan] WHERE idplan =@idplan";
                command.Parameters.AddWithValue("@idplan", txtbuscarp.Text);

                connection.Open();
                flag = command.ExecuteNonQuery();

                if (flag == 1)
                {
                    await this.ShowMessageAsync("Exito", "El plan se ha eliminado exitosamente");
                    this.Hide();
                    planes p = new planes();
                    p.Show();

                }
                else
                {
                    await this.ShowMessageAsync("Error", "El plan no se ha podido eliminar,intentelo de nuevo");
                }


                connection.Close();
            }
        }

        private void btncrearc_Click(object sender, RoutedEventArgs e)
        {
            FCrearmodificarplan.IsOpen = true;
        }

        private async void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Conexion.Agregarplan(txtidplan.Text, txtnombrep.Text, float.Parse(txtaprimabase.Text), txtpolizaactual.Text);
            await this.ShowMessageAsync("Mensaje", "Se ha creado un nuevo plan");
            this.Hide();
            planes p = new planes();
            p.Show();
        }

        private async void Button_Click_2(object sender, RoutedEventArgs e)
        {
            int flag = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(null, connection);
                command.CommandText = "update [plan] set nombre=@nombre,primabase=@primab,polizaActual=@polizaActual  where idplan=@idplan";
                command.Parameters.AddWithValue("@idplan",txtidplan.Text);
                command.Parameters.AddWithValue("@nombre",txtnombrep.Text);
                command.Parameters.AddWithValue("@primab",float.Parse(txtaprimabase.Text));
                command.Parameters.AddWithValue("@polizaActual",txtpolizaactual.Text);
                connection.Open();
                flag = command.ExecuteNonQuery();

                if (flag == 1)
                {
                    await this.ShowMessageAsync("Exito", "El plan  ha sido actualizado correctamente");
                    this.Hide();
                    planes p = new planes();
                    p.Show();
                }
                else
                {
                    await this.ShowMessageAsync("Error", "El plan no ha podido actualizarse , intentelo de nuevo");
                }


                connection.Close();
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(txtbuscarp.Text.Length>=5 && txtbuscarp.Text.Length <= 7)
            {
                btnbuscarp.IsEnabled = true;
                btneliminarp.IsEnabled = true;
            }
            else
            {
                btnbuscarp.IsEnabled = false;
                btneliminarp.IsEnabled = false;
            }
                
        }

        private void txtidplan_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(txtidplan.Text.Length>=5 && txtidplan.Text.Length <= 7)
            {
                txtnombrep.IsEnabled = true;
                txtaprimabase.IsEnabled = true;
                txtpolizaactual.IsEnabled = true;
            }
            else
            {
                txtnombrep.IsEnabled = false;
                txtaprimabase.IsEnabled = false;
                txtpolizaactual.IsEnabled = false;
            }
        }

        private void txtnombrep_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(txtnombrep.Text.Length >=4 &&txtnombrep.Text.Length<=15||txtaprimabase.Text.Length>0 && txtaprimabase.Text.Length<=4
            || txtpolizaactual.Text.Length == 12)
            {
                btncreaplan.IsEnabled = true;
                btnmodificarp.IsEnabled = true;
            }
            else
            {
                btncreaplan.IsEnabled = false;
                btnmodificarp.IsEnabled = false;
            }
        }

        private void txtaprimabase_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtnombrep.Text.Length >= 4 && txtnombrep.Text.Length <= 15 || txtaprimabase.Text.Length > 0 && txtaprimabase.Text.Length <= 4
           || txtpolizaactual.Text.Length == 12)
            {
                btncreaplan.IsEnabled = true;
                btnmodificarp.IsEnabled = true;
            }
            else
            {
                btncreaplan.IsEnabled = false;
                btnmodificarp.IsEnabled = false;
            }
        }

        private void txtpolizaactual_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtnombrep.Text.Length >= 4 && txtnombrep.Text.Length <= 15 || txtaprimabase.Text.Length > 0 && txtaprimabase.Text.Length <= 4
           || txtpolizaactual.Text.Length == 12)
            {
                btncreaplan.IsEnabled = true;
                btnmodificarp.IsEnabled = true;
            }
            else
            {
                btncreaplan.IsEnabled = false;
                btnmodificarp.IsEnabled = false;
            }
        }

        private void txtnombrep_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            validar.Sololetras(e);
        }
    }
}
