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

namespace MATE_DISCRETAS
{
    /// <summary>
    /// Lógica de interacción para Uno.xaml
    /// </summary>
    public partial class Uno : Window
    {
        public Uno()
        {
            InitializeComponent();

        }
        

        private void terminosextra2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (terminosextra2.SelectedIndex)
            {

                case 0:
                    terminosgrid.Children.Clear();
                    terminosgrid.Children.Add(new _1termino());

                   break;

                case 1:
                    terminosgrid.Children.Clear();
                    terminosgrid.Children.Add(new _2terminos());
                    break;
                case 2:
                    terminosgrid.Children.Clear();
                    terminosgrid.Children.Add(new equivalencias());
                    break;

            }
        }
    }
}
