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

namespace MATE_DISCRETAS
{
    /// <summary>
    /// Lógica de interacción para _2terminos.xaml
    /// </summary>
    public partial class _2terminos : UserControl
    {
        public _2terminos()
        {
            InitializeComponent();
        }

        public class Proposisiciones
        {
            public string uno { get; set; }
            public string dos { get; set; }
            public string tres { get; set; }
            public string cuatro { get; set; }
            public string cinco { get; set; }



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




            if (ver_Copy2.Text == "q+p" | ver_Copy2.Text == "q+r" | ver_Copy2.Text == "q+s" |
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

                if (ver_result2.Text == "+(q+p)" | ver_result2.Text == "+(q+r)" | ver_result2.Text == "+(q+s)" |
                 ver_result2.Text == "+(p+q)" | ver_result2.Text == "+(p+r)" | ver_result2.Text == "+(p+s)" |
                  ver_result2.Text == "+(r+q)" | ver_result2.Text == "+(r+q)" | ver_result2.Text == "+(r+s)" |
                   ver_result2.Text == "+(s+q)" | ver_result2.Text == "+(s+q)" | ver_result2.Text == "+(s+r)")
                {
                    tablasuma1.Visibility = Visibility.Hidden;
                    tablasuma2.Items.Clear();

                    Proposisiciones tempPro11 = new Proposisiciones();
                    tempPro11.dos = prop2.Text;
                    tempPro11.uno = prop1.Text;
                    tempPro11.tres = ver_Copy2.Text;
                    tempPro11.cuatro = ver_result2.Text;
                    tempPro11.cinco = ver_resultadofinal.Text;
                    tablasuma2.Items.Add(tempPro11);
                    Proposisiciones tempPro21 = new Proposisiciones();
                    tempPro21.uno = "v";
                    tempPro21.dos = "v";
                    tempPro21.tres = "v";
                    tempPro21.cuatro = "v";
                    tempPro21.cinco = "v";
                    tablasuma2.Items.Add(tempPro21);
                    Proposisiciones tempPro31 = new Proposisiciones();
                    tempPro31.uno = "f";
                    tempPro31.dos = "f";
                    tempPro31.tres = "f";
                    tempPro31.cuatro = "f";
                    tempPro31.cinco = "f";
                    tablasuma2.Items.Add(tempPro31);
                    Proposisiciones tempPro41 = new Proposisiciones();
                    tempPro41.uno = "v";
                    tempPro41.dos = "f";
                    tempPro41.tres = "v";
                    tempPro41.cuatro = "v";
                    tempPro41.cinco = "v";
                    tablasuma2.Items.Add(tempPro41);
                    Proposisiciones tempPro51 = new Proposisiciones();
                    tempPro51.uno = "f";
                    tempPro51.dos = "v";
                    tempPro51.tres = "v";
                    tempPro51.cuatro = "v";
                    tempPro51.cinco = "v";
                    tablasuma2.Items.Add(tempPro51);




                }
                else if (ver_result2.Text == "+(q*p)" | ver_result2.Text == "+(q*r)" | ver_result2.Text == "+(q*s)" |
                ver_result2.Text == "+(p*q)" | ver_result2.Text == "+(p*r)" | ver_result2.Text == "+(p*s)" |
                 ver_result2.Text == "+(r*q)" | ver_result2.Text == "+(r*q)" | ver_result2.Text == "+(r*s)" |
                  ver_result2.Text == "+(s*q)" | ver_result2.Text == "+(s*q)" | ver_result2.Text == "+(s*r)")
                {
                    tablasuma1.Visibility = Visibility.Hidden;
                    tablasuma2.Items.Clear();

                    Proposisiciones tempPro11 = new Proposisiciones();
                    tempPro11.dos = prop2.Text;
                    tempPro11.uno = prop1.Text;
                    tempPro11.tres = ver_Copy2.Text;
                    tempPro11.cuatro = ver_result2.Text;
                    tempPro11.cinco = ver_resultadofinal.Text;
                    tablasuma2.Items.Add(tempPro11);
                    Proposisiciones tempPro21 = new Proposisiciones();
                    tempPro21.uno = "v";
                    tempPro21.dos = "v";
                    tempPro21.tres = "v";
                    tempPro21.cuatro = "v";
                    tempPro21.cinco = "v";
                    tablasuma2.Items.Add(tempPro21);
                    Proposisiciones tempPro31 = new Proposisiciones();
                    tempPro31.uno = "f";
                    tempPro31.dos = "f";
                    tempPro31.tres = "f";
                    tempPro31.cuatro = "f";
                    tempPro31.cinco = "f";
                    tablasuma2.Items.Add(tempPro31);
                    Proposisiciones tempPro41 = new Proposisiciones();
                    tempPro41.uno = "v";
                    tempPro41.dos = "f";
                    tempPro41.tres = "v";
                    tempPro41.cuatro = "f";
                    tempPro41.cinco = "v";
                    tablasuma2.Items.Add(tempPro41);
                    Proposisiciones tempPro51 = new Proposisiciones();
                    tempPro51.uno = "f";
                    tempPro51.dos = "v";
                    tempPro51.tres = "v";
                    tempPro51.cuatro = "f";
                    tempPro51.cinco = "v";
                    tablasuma2.Items.Add(tempPro51);




                }

            }






            
            ver_term2.Text = "";
            ver_result2.Text = "";
            ver_Copy4.Text = "";
            ver_Copy3.Text = "";
            ver.Text = "";
            ver_Copy.Text = "";
            ver_Copy1.Text = "";
            ver_Copy2.Text = "";
            ver_resultadofinal.Text = "";
            ver_prop4term2.Text = "";

            prop1.SelectedIndex = -1;
            prop2.SelectedIndex = -1;
            signo.SelectedIndex = -1;
            prop3term2.SelectedIndex = -1;
            prop4term2.SelectedIndex = -1;
            signo2.SelectedIndex = -1;




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
                    ver_resultadofinal.Text = ver_resultadofinal.Text + "p";

                    break;
                case 1:
                    ver.Text = ver.Text + "q";
                    ver_Copy2.Text = ver_Copy2.Text + "q";
                    ver_resultadofinal.Text = ver_resultadofinal.Text + "q";
                    break;
                case 2:
                    ver.Text = ver.Text + "r";
                    ver_Copy2.Text = ver_Copy2.Text + "r";
                    ver_resultadofinal.Text = ver_resultadofinal.Text + "r";
                    break;
                case 3:
                    ver.Text = ver.Text + "s";
                    ver_Copy2.Text = ver_Copy2.Text + "s";
                    ver_resultadofinal.Text = ver_resultadofinal.Text + "s";
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
                    ver_resultadofinal.Text = ver_resultadofinal.Text + "p";
                    break;
                case 1:
                    ver_Copy.Text = ver_Copy.Text + "q";
                    ver_Copy2.Text = ver_Copy2.Text + "q";
                    ver_resultadofinal.Text = ver_resultadofinal.Text + "q";
                    break;
                case 2:
                    ver_Copy.Text = ver_Copy.Text + "r";
                    ver_Copy2.Text = ver_Copy2.Text + "r";
                    ver_resultadofinal.Text = ver_resultadofinal.Text + "r";
                    break;
                case 3:
                    ver_Copy.Text = ver_Copy.Text + "s";
                    ver_Copy2.Text = ver_Copy2.Text + "s";
                    ver_resultadofinal.Text = ver_resultadofinal.Text + "s";
                    break;
            }

        }

        private void signo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            switch (signo.SelectedIndex)
            {
                case 0:

                    ver_Copy2.Text = ver_Copy2.Text + "+";
                    ver_resultadofinal.Text = ver_resultadofinal.Text + "+";
                    break;
                case 1:

                    ver_Copy2.Text = ver_Copy2.Text + "*";
                    ver_resultadofinal.Text = ver_resultadofinal.Text + "*";
                    break;
                case 2:

                    ver_Copy2.Text = ver_Copy2.Text + "/";
                    ver_resultadofinal.Text = ver_resultadofinal.Text + "/";
                    break;
                case 3:

                    ver_Copy2.Text = ver_Copy2.Text + "-";
                    ver_resultadofinal.Text = ver_resultadofinal.Text + "-";
                    break;
            }


        }

       
        private void Prop3term2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (prop3term2.SelectedIndex)
            {
                case 0:
                    ver_term2.Text = ver_term2.Text + "(p";
                    ver_result2.Text = ver_result2.Text + "(p";
                    ver_resultadofinal.Text = ver_resultadofinal.Text + "(p";
                    break;
                case 1:
                    ver_term2.Text = ver_term2.Text + "(q";
                    ver_result2.Text = ver_result2.Text + "(q";
                    ver_resultadofinal.Text = ver_resultadofinal.Text + "(q";
                    break;
                case 2:
                    ver_term2.Text = ver_term2.Text + "(r";
                    ver_result2.Text = ver_result2.Text + "(r";
                    ver_resultadofinal.Text = ver_resultadofinal.Text + "(r";
                    break;
                case 3:
                    ver_term2.Text = ver_term2.Text + "(s";
                    ver_result2.Text = ver_result2.Text + "(s";
                    ver_resultadofinal.Text = ver_resultadofinal.Text + "(s";
                    break;
            }
        }

        private void signo2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            switch (signo2.SelectedIndex)
            {
                case 0:

                    ver_result2.Text = ver_result2.Text + "+";
                    ver_resultadofinal.Text = ver_resultadofinal.Text + "+";

                    break;
                case 1:

                    ver_result2.Text = ver_result2.Text + "*";
                    ver_resultadofinal.Text = ver_resultadofinal.Text + "*";

                    break;
                case 2:

                    ver_result2.Text = ver_result2.Text + "/";
                    ver_resultadofinal.Text = ver_resultadofinal.Text + "/";

                    break;
                case 3:

                    ver_result2.Text = ver_result2.Text + "-";
                    ver_resultadofinal.Text = ver_resultadofinal.Text + "-";

                    break;
            }
        }

        private void Prop4term2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (prop4term2.SelectedIndex)
            {
                case 0:
                    ver_result2.Text = ver_result2.Text + "p)";
                    ver_prop4term2.Text = ver_prop4term2.Text + "p)";
                    ver_resultadofinal.Text = ver_resultadofinal.Text + "p)";
                    break;
                case 1:
                    ver_result2.Text = ver_result2.Text + "q)";
                    ver_prop4term2.Text = ver_prop4term2.Text + "q)";
                    ver_resultadofinal.Text = ver_resultadofinal.Text + "q)";
                    break;
                case 2:
                    ver_result2.Text = ver_result2.Text + "r)";
                    ver_prop4term2.Text = ver_prop4term2.Text + "r)";
                    ver_resultadofinal.Text = ver_resultadofinal.Text + "r)";
                    break;
                case 3:
                    ver_result2.Text = ver_result2.Text + "s)";
                    ver_prop4term2.Text = ver_prop4term2.Text + "s)";
                    ver_resultadofinal.Text = ver_resultadofinal.Text + "s)";
                    break;
            }

        }

        private void Borrar_Click(object sender, RoutedEventArgs e)
        {
            ver_resultadofinal.Text = ver_resultadofinal.Text.Substring(0, ver_resultadofinal.Text.Count() - 1);

        }

        private void signoextra_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch(signoextra.SelectedIndex)
            { 
            case 0:
                ver_signoconector.Text = "+";
                ver_resultadofinal.Text = "+";
                    ver_result2.Text = "+";
                    break;
                case 1:
                    ver_signoconector.Text = "*";
                    ver_resultadofinal.Text = "*";
                    ver_result2.Text = "*";
                    break;
            }
            
        }
    }
}
