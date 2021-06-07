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
using System.Data;
using System.Data.SqlClient;
using ControlzEx.Standard;

namespace metrowpf
{
    /// <summary>
    /// Lógica de interacción para formulario_cucontrato.xaml
    /// </summary>
    public partial class formulario_cucontrato : MetroWindow
    {
        static String connectionString = @"Server=LAPTOP-81O535IB\SQLEXPRESS;Database=belife;Trusted_Connection=True;";
        public formulario_cucontrato()
        {
            InitializeComponent();
            txtfechacreacion.IsEnabled = false;
            txtrutcliente.IsEnabled = false;
            txtcodigoplan.IsEnabled = false;
            txtfechainiciovigencia.IsEnabled = false;
            txtfechafinvigencia.IsEnabled = false;
            cbxvigente.IsEnabled = false;
            cbxdeclaracion.IsEnabled = false;
            txtprimaanual.IsEnabled = false;
            txtprimamensual.IsEnabled = false;
            txtobservaciones.IsEnabled = false;
            btnactualizarc.IsEnabled = false;
            btncrearc.IsEnabled = false;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Txtnumeroc_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtnumero.Text.Length >= 3)
            {
                txtfechacreacion.IsEnabled = true;
                txtrutcliente.IsEnabled = true;
                txtcodigoplan.IsEnabled = true;
                txtfechainiciovigencia.IsEnabled = true;
                txtfechafinvigencia.IsEnabled = true;
                txtprimaanual.IsEnabled = true;
                txtprimamensual.IsEnabled = true;
                txtobservaciones.IsEnabled = true;
                
            }
            else
            {
                txtfechacreacion.IsEnabled = false;
                txtrutcliente.IsEnabled = false;
                txtcodigoplan.IsEnabled = false;
                txtfechainiciovigencia.IsEnabled = false;
                txtfechafinvigencia.IsEnabled = false;
                txtprimaanual.IsEnabled = false;
                txtprimamensual.IsEnabled = false;
                txtobservaciones.IsEnabled = false;
            }
        }

        private void Txt_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Txtfechacreacion_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(txtfechacreacion.Text.Length==10 || txtrutcliente.Text.Length>=9 && txtrutcliente.Text.Length<=10
                ||txtcodigoplan.Text.Length>=5 &&txtcodigoplan.Text.Length<=7|| txtfechainiciovigencia.Text.Length==10
                ||txtfechafinvigencia.Text.Length==10 ||txtprimaanual.Text.Length>0||txtprimamensual.Text.Length>0
                ||txtobservaciones.Text.Length>3)
            {
                btnactualizarc.IsEnabled = true;
                btncrearc.IsEnabled = true;
                cbxdeclaracion.IsEnabled = true;
                cbxvigente.IsEnabled = true;
            }
            else
            {
                btnactualizarc.IsEnabled = false;
                btncrearc.IsEnabled = false;
                cbxdeclaracion.IsEnabled = false;
                cbxvigente.IsEnabled = false;
            }
        }

        private void Txtrutcliente_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtfechacreacion.Text.Length == 10 || txtrutcliente.Text.Length >= 9 && txtrutcliente.Text.Length <= 10
                || txtcodigoplan.Text.Length >= 5 && txtcodigoplan.Text.Length <= 7 || txtfechainiciovigencia.Text.Length == 10
                || txtfechafinvigencia.Text.Length == 10 || txtprimaanual.Text.Length > 0 || txtprimamensual.Text.Length > 0
                || txtobservaciones.Text.Length > 3)
            {
                btnactualizarc.IsEnabled = true;
                btncrearc.IsEnabled = true;
                cbxdeclaracion.IsEnabled = true;
                cbxvigente.IsEnabled = true;
            }
            else
            {
                btnactualizarc.IsEnabled = false;
                btncrearc.IsEnabled = false;
                cbxdeclaracion.IsEnabled = false;
                cbxvigente.IsEnabled = false;
            }
        }

        private void txtcodigoplan_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtfechacreacion.Text.Length == 10 || txtrutcliente.Text.Length >= 9 && txtrutcliente.Text.Length <= 10
                || txtcodigoplan.Text.Length >= 5 && txtcodigoplan.Text.Length <= 7 || txtfechainiciovigencia.Text.Length == 10
                || txtfechafinvigencia.Text.Length == 10 || txtprimaanual.Text.Length > 0 || txtprimamensual.Text.Length > 0
                || txtobservaciones.Text.Length > 3)
            {
                btnactualizarc.IsEnabled = true;
                btncrearc.IsEnabled = true;
                cbxdeclaracion.IsEnabled = true;
                cbxvigente.IsEnabled = true;
            }
            else
            {
                btnactualizarc.IsEnabled = false;
                btncrearc.IsEnabled = false;
                cbxdeclaracion.IsEnabled = false;
                cbxvigente.IsEnabled = false;
            }
        }

        private void txtfechainiciovigencia_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtfechacreacion.Text.Length == 10 || txtrutcliente.Text.Length >= 9 && txtrutcliente.Text.Length <= 10
                || txtcodigoplan.Text.Length >= 5 && txtcodigoplan.Text.Length <= 7 || txtfechainiciovigencia.Text.Length == 10
                || txtfechafinvigencia.Text.Length == 10 || txtprimaanual.Text.Length > 0 || txtprimamensual.Text.Length > 0
                || txtobservaciones.Text.Length > 3)
            {
                btnactualizarc.IsEnabled = true;
                btncrearc.IsEnabled = true;
                cbxdeclaracion.IsEnabled = true;
                cbxvigente.IsEnabled = true;
            }
            else
            {
                btnactualizarc.IsEnabled = false;
                btncrearc.IsEnabled = false;
                cbxdeclaracion.IsEnabled = false;
                cbxvigente.IsEnabled = false;
            }
        }

        private void txtfechafinvigencia_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtfechacreacion.Text.Length == 10 || txtrutcliente.Text.Length >= 9 && txtrutcliente.Text.Length <= 10
                || txtcodigoplan.Text.Length >= 5 && txtcodigoplan.Text.Length <= 7 || txtfechainiciovigencia.Text.Length == 10
                || txtfechafinvigencia.Text.Length == 10 || txtprimaanual.Text.Length > 0 || txtprimamensual.Text.Length > 0
                || txtobservaciones.Text.Length > 3)
            {
                btnactualizarc.IsEnabled = true;
                btncrearc.IsEnabled = true;
                cbxdeclaracion.IsEnabled = true;
                cbxvigente.IsEnabled = true;
            }
            else
            {
                btnactualizarc.IsEnabled = false;
                btncrearc.IsEnabled = false;
                cbxdeclaracion.IsEnabled = false;
                cbxvigente.IsEnabled = false;
            }
        }

        private void TxextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtprimaanual_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtfechacreacion.Text.Length == 10 || txtrutcliente.Text.Length >= 9 && txtrutcliente.Text.Length <= 10
                || txtcodigoplan.Text.Length >= 5 && txtcodigoplan.Text.Length <= 7 || txtfechainiciovigencia.Text.Length == 10
                || txtfechafinvigencia.Text.Length == 10 || txtprimaanual.Text.Length > 0 || txtprimamensual.Text.Length > 0
                || txtobservaciones.Text.Length > 3)
            {
                btnactualizarc.IsEnabled = true;
                btncrearc.IsEnabled = true;
                cbxdeclaracion.IsEnabled = true;
                cbxvigente.IsEnabled = true;
            }
            else
            {
                btnactualizarc.IsEnabled = false;
                btncrearc.IsEnabled = false;
                cbxdeclaracion.IsEnabled = false;
                cbxvigente.IsEnabled = false;
            }
        }

        private void txtprimamensual_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtfechacreacion.Text.Length == 10 || txtrutcliente.Text.Length >= 9 && txtrutcliente.Text.Length <= 10
                            || txtcodigoplan.Text.Length >= 5 && txtcodigoplan.Text.Length <= 7 || txtfechainiciovigencia.Text.Length == 10
                            || txtfechafinvigencia.Text.Length == 10 || txtprimaanual.Text.Length > 0 || txtprimamensual.Text.Length > 0
                            || txtobservaciones.Text.Length > 3)
            {
                btnactualizarc.IsEnabled = true;
                btncrearc.IsEnabled = true;
                cbxdeclaracion.IsEnabled = true;
                cbxvigente.IsEnabled = true;
            }
            else
            {
                btnactualizarc.IsEnabled = false;
                btncrearc.IsEnabled = false;
                cbxdeclaracion.IsEnabled = false;
                cbxvigente.IsEnabled = false;
            }
        }

        private void Txtobservaciones_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtfechacreacion.Text.Length == 10 || txtrutcliente.Text.Length >= 9 && txtrutcliente.Text.Length <= 10
                || txtcodigoplan.Text.Length >= 5 && txtcodigoplan.Text.Length <= 7 || txtfechainiciovigencia.Text.Length == 10
                || txtfechafinvigencia.Text.Length == 10 || txtprimaanual.Text.Length > 0 || txtprimamensual.Text.Length > 0
                || txtobservaciones.Text.Length > 3)
            {
                btnactualizarc.IsEnabled = true;
                btncrearc.IsEnabled = true;
                cbxdeclaracion.IsEnabled = true;
                cbxvigente.IsEnabled = true;
            }
            else
            {
                btnactualizarc.IsEnabled = false;
                btncrearc.IsEnabled = false;
                cbxdeclaracion.IsEnabled = false;
                cbxvigente.IsEnabled = false;
            }
        }

        private async void btnactualizarc_Click(object sender, RoutedEventArgs e)
        {
            int flag = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(null, connection);
                command.CommandText = "update contrato set numero='" + txtnumero.Text + "',fechacreacion= '" + txtfechacreacion.Text + "',rutcliente= '"+txtrutcliente.Text+"',codigoplan= '"+txtcodigoplan.Text+"',fechainiciovigencia= '"+txtfechainiciovigencia.Text+"',fechafinvigencia= '"+txtfechafinvigencia.Text+"',vigente= '"+int.Parse(cbxvigente.Text)+"',declaracionsalud= '"+int.Parse(cbxdeclaracion.Text)+"',primaanual='"+float.Parse(txtprimaanual.Text)+"',primamensual= '"+float.Parse(txtprimamensual.Text)+"',observaciones= '"+txtobservaciones+"' where numero='" + txtnumero.Text+ "'";

                connection.Open();
                flag = command.ExecuteNonQuery();

                if (flag == 1)
                {
                    await this.ShowMessageAsync("Exito","El contrato  ha sido actualizado correctamente");
                    this.Hide();
                    Contratos c = new Contratos();
                    c.Show();
                }
                else
                {
                    await this.ShowMessageAsync("Error","El contrato no ha podido actualizarse , intentelo de nuevo");
                }


                connection.Close();
            }
        }

        private async void btncrearc_Click(object sender, RoutedEventArgs e)
        {
            Conexion.Agregarcontrato(txtnumero.Text, txtfechacreacion.Text, txtrutcliente.Text, txtcodigoplan.Text,txtfechainiciovigencia.Text,txtfechafinvigencia.Text,int.Parse(cbxvigente.Text), int.Parse(cbxdeclaracion.Text), float.Parse(txtprimaanual.Text), float.Parse(txtprimamensual.Text), txtobservaciones.Text);
            await this.ShowMessageAsync("Mensaje", "Se ha creado un nuevo contrato");
            this.Hide();
            Contratos c = new Contratos();
            c.Show();

        }

        private void ComboBoxItem_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void Tile_Click_3(object sender, RoutedEventArgs e)
        {
            this.Hide();
            menuxaml m = new menuxaml("Keiro Esteban Palomera Avila");
            m.Show();
        }

        private void txtnumero_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            validar.Solonumeros(e);
        }

        private void txtfechacreacion_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            int key = (int)e.Key;

            e.Handled = !(key >= 34 && key <= 43 ||
                          key >= 74 && key <= 83 ||
                          key == 2);
        }

        private void txtfechainiciovigencia_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            int key = (int)e.Key;

            e.Handled = !(key >= 34 && key <= 43 ||
                          key >= 74 && key <= 83 ||
                          key == 2);
        }

        private void txtfechafinvigencia_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            int key = (int)e.Key;

            e.Handled = !(key >= 34 && key <= 43 ||
                          key >= 74 && key <= 83 ||
                          key == 2);
        }
    }
}
