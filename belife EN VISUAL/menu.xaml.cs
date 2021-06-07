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
using System.Windows.Threading;
using System.Timers;
using System.Windows.Automation.Peers;
using System.Diagnostics;
using System.Web.UI.WebControls;
using System.Windows.Media.TextFormatting;

namespace metrowpf
{
    /// <summary>
    /// Lógica de interacción para menuxaml.xaml
    /// </summary>
    public partial class menuxaml : MetroWindow
    {

        static String connectionString = @"Server=LAPTOP-81O535IB\SQLEXPRESS;Database=BeLife;Trusted_Connection=True;";


        public menuxaml(string nombre)
        {
            InitializeComponent();

            lblnombre.Content = nombre;
            lblusuario.Content = nombre;

            startclock();
            btnaceptar.IsEnabled = false;
            pbconnueva.IsEnabled = false;
            pbconnuevare.IsEnabled = false;
            txtfechanacimiento.IsEnabled = false;
            txtfechaingreso.IsEnabled = false;
            cbxestadocivil.IsEnabled = false;
            cbxsexo.IsEnabled = false;
            btnactualizar.IsEnabled = false;

        }


        private void startclock()
        {
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(0);
            timer.Tick += tickevent;
            timer.Start();

        }

        private void tickevent(object sender, EventArgs e)
        {
            lbldatetime.Content = DateTime.Now.ToString();
        }

        public void mostrar(string nombre, string email)
        {

        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Tile_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Listadoclientes lc = new Listadoclientes();
            lc.Show();
        }

        private void Tile_Click_1(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Tile_Click_2(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Contratos c = new Contratos();
            c.Show();
        }

        private void Tile_Click_3(object sender, RoutedEventArgs e)
        {
            this.Hide();
            formulario_cucontrato fc = new formulario_cucontrato();
            fc.Show();
        }

       


        private void timer1_tick(object sender, EventArgs e)
        {

        }
        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
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

        private void Tile_Click_5(object sender, RoutedEventArgs e)
        {
            this.Hide();
            planes p = new planes();
            p.Show();

        }

        private void Tile_Click_6(object sender, RoutedEventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cm = new SqlCommand("select *from administrador where rutadmin=@rutadmin", connection);
                cm.Parameters.AddWithValue("@rutadmin", "18483574-1");
                connection.Open();
                SqlDataReader registro = cm.ExecuteReader();
                if (registro.Read())
                {
                    lblrut.Content = registro["rutadmin"].ToString();
                    lblfechai.Content = registro["fechaingreso"].ToString();
                }
                else
                {

                }
                connection.Close();
                flyperfil.IsOpen = true;
            }
        }

        private void Tile_Click_7(object sender, RoutedEventArgs e)
        {

        }

        private void btncamcont_Click_1(object sender, RoutedEventArgs e)
        {
            flyperfil.IsOpen = false;
            flycambcontra.IsOpen = true;
        }

        private async void btnaceptar_Click(object sender, RoutedEventArgs e)
        {
            int flag = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {



                SqlCommand command = new SqlCommand(null, connection);
                command.CommandText = "update administrador set contraseña =@contraseñan where contraseña=@contraseña";
                command.Parameters.AddWithValue("@contraseñan", pbconnuevare.Password);
                command.Parameters.AddWithValue("@contraseña", pbconactual.Password);
                connection.Open();
                flag = command.ExecuteNonQuery();

                if (flag == 1)
                {
                    await this.ShowMessageAsync("Exito", "La contraseña  ha sido actualizada correctamente");
                    flycambcontra.IsOpen = false;
                }
                else
                {
                    await this.ShowMessageAsync("Error", "La contraseña no ha podido actualizarse , intentelo de nuevo");
                }




                connection.Close();
            }
        }



        private void pbconnuevare_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (pbconnuevare.Password.Length>=8 && pbconnuevare.Password == pbconnueva.Password)
            {
                btnaceptar.IsEnabled = true;
            }
            else if (pbconnuevare.Password != pbconnueva.Password)
            {
                btnaceptar.IsEnabled = false;
            }
        }

        private void pbconnueva_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (pbconnueva.Password.Length>=8)
            {
                pbconnuevare.IsEnabled = true;
                
            }
            else if (pbconnuevare.Password != pbconnueva.Password)
            {

                pbconnuevare.IsEnabled = false;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Process proceso = new Process();
            proceso.StartInfo.FileName = @"C:\Users\keiro\source\repos\metrowpf\Manual\manual belife.rtf";
            proceso.Start();
        }

        private void Tile_Click_8(object sender, RoutedEventArgs e)
        {
            flyproayuda.IsOpen = true;
        }



        private async void btnactualizar_Click(object sender, RoutedEventArgs e)
        {
            int flag = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(null, connection);
                command.CommandText = "update administrador set nombre_completo=@nombre,fechanacimiento=@fechanacimiento,fechaingreso=@fechaingreso,idsexo=@idsexo,idestadocivil=@idestadoc where rutadmin=@rutadmin";
                command.Parameters.AddWithValue("@nombre", txtnombre.Text);
                command.Parameters.AddWithValue("@fechanacimiento", txtfechanacimiento.Text);
                command.Parameters.AddWithValue("@fechaingreso", txtfechaingreso.Text);
                command.Parameters.AddWithValue("@idsexo", int.Parse(cbxsexo.Text));
                command.Parameters.AddWithValue("@idestadoc", int.Parse(cbxestadocivil.Text));
                command.Parameters.AddWithValue("@rutadmin", lblrut.Content);
                connection.Open();
                flag = command.ExecuteNonQuery();

                if (flag == 1)
                {
                    await this.ShowMessageAsync("Exito", "Sus datos  han sido actualizados correctamente");
                    await this.ShowMessageAsync("Informacion", "Inicie sesion nuevamente por favor");
                    this.Hide();
                    MainWindow mw = new MainWindow();
                    mw.Show();
                }
                else
                {
                    await this.ShowMessageAsync("Error", "Sus datos no han podido actualizarse , intentelo de nuevo");
                }


                connection.Close();
            }
        }

        private void cbxestadocivil_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (txtfechanacimiento.Text.Length == 10 || txtfechaingreso.Text.Length == 10)
            {
                btnactualizar.IsEnabled = true;
            }
            else
            {
                btnactualizar.IsEnabled = false;
            }
        }

        private void cbxsexo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (txtfechanacimiento.Text.Length == 10 || txtfechaingreso.Text.Length == 10)
            {
                btnactualizar.IsEnabled = true;
            }
            else
            {
                btnactualizar.IsEnabled = false;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            flyprocambinfo.IsOpen = true;
            flyperfil.IsOpen = false;
        }

        private void txtnombre_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void pbconactual_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (pbconactual.Password.Length >= 8)
            {
                
                pbconnueva.IsEnabled = true;
            }
            else
            {
                
                pbconnueva.IsEnabled = false;
            }
        }

        private void txtnombre_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            if(txtnombre.Text.Length>0 && txtnombre.Text.Length <= 30)
            {
                txtfechaingreso.IsEnabled = true;
                txtfechanacimiento.IsEnabled = true;
                cbxsexo.IsEnabled = true;
                cbxestadocivil.IsEnabled = true;
            }
            else
            {
                txtfechanacimiento.IsEnabled = false;
                txtfechaingreso.IsEnabled = false;
                cbxestadocivil.IsEnabled = false;
                cbxsexo.IsEnabled = false;
            }
        }

        private void txtfechanacimiento_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtfechanacimiento.Text.Length== 10 || txtfechaingreso.Text.Length==10)
            {
                btnactualizar.IsEnabled = true;
            }
            else
            {
                btnactualizar.IsEnabled = false;
            }
        }

        private void txtfechaingreso_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtfechanacimiento.Text.Length == 10 || txtfechaingreso.Text.Length == 10)
            {
                btnactualizar.IsEnabled = true;
            }
            else
            {
                btnactualizar.IsEnabled = false;
            }
        }

        private void txtnombre_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            validar.Sololetras(e);
        }

        private void txtfechanacimiento_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
             
        }

        private void txtfechanacimiento_KeyDown(object sender, KeyEventArgs e)
        {
           
          
                }

        private void PreviewTextImput(object sender, TextCompositionEventArgs e)
        {
           
        }

        private void PreviewKeyDownFn(object sender, KeyEventArgs e)
        {
            int key = (int)e.Key;

            e.Handled = !(key >= 34 && key <= 43 ||
                          key >= 74 && key <= 83 ||
                          key == 2);
        }

        private void txtfechaingreso_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            int key = (int)e.Key;

            e.Handled = !(key >= 34 && key <= 43 ||
                          key >= 74 && key <= 83 ||
                          key == 2);
        }
    }
        }
    

   
    
    




