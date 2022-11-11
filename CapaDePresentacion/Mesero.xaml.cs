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

namespace Resto2
{
    /// <summary>
    /// Lógica de interacción para Mesero.xaml
    /// </summary>
    public partial class Mesero : Window
    {
        public Mesero()
        {
            InitializeComponent();
        }
        
        private void Limpiar_mesa_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Mesa liberada");
        }

        private void Limpiar_mesa1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Mesa liberada ");
        }

        private void Limpiar_mesa2_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Mesa liberada ");
        }

        private void Limpiar_mesa3_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Mesa liberada ");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Session Cerrada Correctamente ");
            //MainWindow mainWindow = new MainWindow();
            //this.Close();
            //mainWindow.ShowDialog();
        }
    }
}
