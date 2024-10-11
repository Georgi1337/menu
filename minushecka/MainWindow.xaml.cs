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

namespace minushecka
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void meIt1_Click(object sender, RoutedEventArgs e)
        {
            meIt1.Background = Brushes.DarkBlue;
        }

        private void meIt2_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Легенда гласит о творце всего сущего(ну тоесть о саздателе этой WpF) когда-то давно он ... ладно хватит и этого");
        }

        private void meIt3_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void tol1_Click(object sender, RoutedEventArgs e)
        {
            tol1.Background = Brushes.DarkBlue;
        }

        private void tol2_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Легенда гласит о творце всего сущего(ну тоесть о саздателе этой WpF) когда-то давно он ... ладно хватит и этого");
        }

        private void tol3_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
