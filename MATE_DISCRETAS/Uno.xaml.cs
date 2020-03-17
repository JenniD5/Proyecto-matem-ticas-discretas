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
        public class Proposisiciones
        {
            public string uno { get; set; }
            public string dos { get; set; }
            public string tres { get; set; }
            public string cuatro { get; set; }



        }

        public class suma2proposiciones
        {
            public string unopro;
            public string dospro;
            public string resultado;

            public string v;
            public string f;
        }

        public class limpiar
        {

        }




        private void Btnsuma_Click(object sender, RoutedEventArgs e)
        {


        }


        private void Suma_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Igual_Click(object sender, RoutedEventArgs e)
        {
            tablasuma1.Visibility = Visibility.Visible;


             
            if (ver_Copy2.Text == "q+p" | ver_Copy2.Text == "q+r" | ver_Copy2.Text == "q+s"|
               ver_Copy2.Text == "p+q" | ver_Copy2.Text == "p+r" | ver_Copy2.Text == "p+s" |
                ver_Copy2.Text == "r+q" | ver_Copy2.Text == "r+q" | ver_Copy2.Text == "r+s" |
                 ver_Copy2.Text == "s+q" | ver_Copy2.Text == "s+q" | ver_Copy2.Text == "s+r")
            {
                tablasuma1.Items.Clear();

                Proposisiciones tempPro = new Proposisiciones();
                tempPro.dos = prop2.Text;
                tempPro.uno = prop1.Text;
                tempPro.tres = ver_Copy2.Text;
                tablasuma1.Items.Add(tempPro);
                Proposisiciones tempPro2 = new Proposisiciones();
                tempPro2.uno = "v";
                tempPro2.dos = "v";
                tempPro2.tres = "v";
                tablasuma1.Items.Add(tempPro2);
                Proposisiciones tempPro3 = new Proposisiciones();
                tempPro3.uno = "f";
                tempPro3.dos = "f";
                tempPro3.tres = "f";
                tablasuma1.Items.Add(tempPro3);
                Proposisiciones tempPro4 = new Proposisiciones();
                tempPro4.uno = "v";
                tempPro4.dos = "f";
                tempPro4.tres = "v";
                tablasuma1.Items.Add(tempPro4);
                Proposisiciones tempPro5 = new Proposisiciones();
                tempPro5.uno = "f";
                tempPro5.dos = "v";
                tempPro5.tres = "v";
                tablasuma1.Items.Add(tempPro5);

            }

            else if (ver_Copy2.Text == "q*p" | ver_Copy2.Text == "q*r" | ver_Copy2.Text == "q*s" |
              ver_Copy2.Text == "p*q" | ver_Copy2.Text == "p*r" | ver_Copy2.Text == "p*s" |
              ver_Copy2.Text == "r*q" | ver_Copy2.Text == "r*q" | ver_Copy2.Text == "r*s" |
              ver_Copy2.Text == "s*q" | ver_Copy2.Text == "s*q" | ver_Copy2.Text == "s*r")
            {
                tablasuma1.Items.Clear();

                Proposisiciones tempPro = new Proposisiciones();
                tempPro.dos = prop2.Text;
                tempPro.uno = prop1.Text;
                tempPro.tres = ver_Copy2.Text;
                tablasuma1.Items.Add(tempPro);
                Proposisiciones tempPro2 = new Proposisiciones();
                tempPro2.uno = "v";
                tempPro2.dos = "v";
                tempPro2.tres = "v";
                tablasuma1.Items.Add(tempPro2);
                Proposisiciones tempPro3 = new Proposisiciones();
                tempPro3.uno = "f";
                tempPro3.dos = "f";
                tempPro3.tres = "f";
                tablasuma1.Items.Add(tempPro3);
                Proposisiciones tempPro4 = new Proposisiciones();
                tempPro4.uno = "v";
                tempPro4.dos = "f";
                tempPro4.tres = "f";
                tablasuma1.Items.Add(tempPro4);
                Proposisiciones tempPro5 = new Proposisiciones();
                tempPro5.uno = "f";
                tempPro5.dos = "v";
                tempPro5.tres = "f";
                tablasuma1.Items.Add(tempPro5);

            }




            ver.Text = "";
            ver_Copy.Text = "";
            ver_Copy1.Text = "";
            ver_Copy2.Text = "";



        }

        private void Multiplicacion_Click(object sender, RoutedEventArgs e)
        {
            ver_Copy1.Text = ver_Copy1.Text + "*";
            ver_Copy2.Text = ver_Copy2.Text + "*";
        }

        private void prop1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            switch (prop1.SelectedIndex)
            {
                case 0:
                    ver.Text = ver.Text + "p";
                    ver_Copy2.Text = ver_Copy2.Text + "p";
                    break;
                case 1:
                    ver.Text = ver.Text + "q";
                    ver_Copy2.Text = ver_Copy2.Text + "q";
                    break;
                case 2:
                    ver.Text = ver.Text + "r";
                    ver_Copy2.Text = ver_Copy2.Text + "r";
                    break;
                case 3:
                    ver.Text = ver.Text + "s";
                    ver_Copy2.Text = ver_Copy2.Text + "s";
                    break;
            }
        }

        private void prop2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (prop2.SelectedIndex)
            {
                case 0:
                    ver_Copy.Text = ver_Copy.Text + "p";
                    ver_Copy2.Text = ver_Copy2.Text + "p";
                    break;
                case 1:
                    ver_Copy.Text = ver_Copy.Text + "q";
                    ver_Copy2.Text = ver_Copy2.Text + "q";
                    break;
                case 2:
                    ver_Copy.Text = ver_Copy.Text + "r";
                    ver_Copy2.Text = ver_Copy2.Text + "r";
                    break;
                case 3:
                    ver_Copy.Text = ver_Copy.Text + "s";
                    ver_Copy2.Text = ver_Copy2.Text + "s";
                    break;
            }

        }

        private void signo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            switch (signo.SelectedIndex)
            {
                case 0:

                    ver_Copy2.Text = ver_Copy2.Text + "+";
                    break;
                case 1:

                    ver_Copy2.Text = ver_Copy2.Text + "*";
                    break;
                case 2:

                    ver_Copy2.Text = ver_Copy2.Text + "/";
                    break;
                case 3:

                    ver_Copy2.Text = ver_Copy2.Text + "-";
                    break;
            }


        }
    }
}
