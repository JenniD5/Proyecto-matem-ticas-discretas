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
    /// Lógica de interacción para equivalencias.xaml
    /// </summary>
    public partial class equivalencias : UserControl
    {
        public equivalencias()
        {
            InitializeComponent();
        }

        private void prop1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (prop1.SelectedIndex)
            {
                case 0:
                    ver.Text = ver.Text + "p";
                    ver_Copy2.Text = ver_Copy2.Text + "p";
                    resultado1.Text = resultado1.Text + "p";




                    break;
                case 1:
                    ver.Text = ver.Text + "q";
                    ver_Copy2.Text = ver_Copy2.Text + "q";
                    resultado1.Text = resultado1.Text + "q";

                    break;
                case 2:
                    ver.Text = ver.Text + "r";
                    ver_Copy2.Text = ver_Copy2.Text + "r";
                    resultado1.Text = resultado1.Text + "r";

                    break;
                case 3:
                    ver.Text = ver.Text + "s";
                    ver_Copy2.Text = ver_Copy2.Text + "s";
                    resultado1.Text = resultado1.Text + "s";

                    break;
                case 4:
                    ver.Text = ver.Text + "-p";
                    ver_Copy2.Text = ver_Copy2.Text + "-p";
                    ver_Copy1.Text = ver_Copy1.Text = "-p";
                    resultado1.Text = resultado1.Text + "-p";
                    break;
                case 5:
                    ver_Copy2.Text = ver_Copy2.Text + "-q";
                    ver.Text = ver.Text + "-q";
                    resultado1.Text = resultado1.Text + "-q";
                    break;
                case 6:
                    ver_Copy2.Text = ver_Copy2.Text + "-r";
                    ver.Text = ver.Text + "-r";
                    resultado1.Text = resultado1.Text + "-r";
                    break;
                case 7:
                    ver_Copy2.Text = ver_Copy2.Text + "-s";
                    ver.Text = ver.Text + "-s";
                    resultado1.Text = resultado1.Text + "-s";
                    break;
            }
        
    }

        private void signo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (signo.SelectedIndex)
            {
                case 0:

                    ver_Copy2.Text = ver_Copy2.Text + "+";
                    resultado1.Text = resultado1.Text + "+";

                    break;
                case 1:

                    ver_Copy2.Text = ver_Copy2.Text + "*";
                    resultado1.Text = resultado1.Text + "*";

                    break;
                case 2:

                    ver_Copy2.Text = ver_Copy2.Text + "/";

                    break;
                case 3:

                    ver_Copy2.Text = ver_Copy2.Text + "-";

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
                    resultado1.Text = resultado1.Text + "p";

                    break;
                case 1:
                    ver_Copy.Text = ver_Copy.Text + "q";
                    ver_Copy2.Text = ver_Copy2.Text + "q";
                    resultado1.Text = resultado1.Text + "q";

                    break;
                case 2:
                    ver_Copy.Text = ver_Copy.Text + "r";
                    ver_Copy2.Text = ver_Copy2.Text + "r";
                    resultado1.Text = resultado1.Text + "r";

                    break;
                case 3:
                    ver_Copy.Text = ver_Copy.Text + "s";
                    ver_Copy2.Text = ver_Copy2.Text + "s";
                    resultado1.Text = resultado1.Text + "s";

                    break;

                case 4:
                    ver_Copy.Text = ver.Text + "-p";
                    ver_Copy2.Text = ver_Copy2.Text + "-p";
                    resultado1.Text = resultado1.Text + "-p";
                    break;
                case 5:
                    ver_Copy2.Text = ver_Copy2.Text + "-q";
                    ver_Copy.Text = ver.Text + "-q";
                    resultado1.Text = resultado1.Text + "-q";
                    break;
                case 6:
                    ver_Copy2.Text = ver_Copy2.Text + "-r";
                    ver_Copy.Text = ver.Text + "-r";
                    resultado1.Text = resultado1.Text + "-r";
                    break;
                case 7:
                    ver_Copy2.Text = ver_Copy2.Text + "-s";
                    ver_Copy.Text = ver.Text + "-s";
                    resultado1.Text = resultado1.Text + "-s";
                    break;
            }
        }
        public class Proposisiciones
        {
            public string uno { get; set; }
            public string dos { get; set; }
            public string tres { get; set; }
            public string cuatro { get; set; }
            public string cinco { get; set; }
            public string seis { get; set; }
            public string siete { get; set; }








        }

        public class signos
        {
            public string signop { get; set; }

            public string signoq { get; set; }
            public string signor { get; set; }
            public string signoss { get; set; }

        }

        public class suma2proposiciones
        {
            public string unopro;
            public string dospro;
            public string resultado;

            public string v;
            public string f;
        }
        private void Igual_Click(object sender, RoutedEventArgs e)
        {
            tablasuma1.Visibility = Visibility.Visible;






            if (resultado1.Text == "p+q" && resultado2.Text == "q+p" || resultado1.Text == "p+r" && resultado2.Text == "r+p" || resultado1.Text == "p+s" && resultado2.Text == "s+p" ||
                resultado1.Text == "q+p" && resultado2.Text == "p+q" || resultado1.Text == "q+r" && resultado2.Text == "r+q" || resultado1.Text == "q+s" && resultado2.Text == "s+q" ||
                resultado1.Text == "r+q" && resultado2.Text == "p+r")
            /*(resultado1.Text == "q+p" | resultado1.Text == "q+r" | resultado1.Text == "q+s" |
              resultado1.Text == "p+q" | ver_Copy2.Text == "p+r" | resultado1.Text == "p+s" |
               resultado1.Text == "r+q" | ver_Copy2.Text == "r+q" | resultado1.Text == "r+s" |
                resultado1.Text == "s+q" | resultado1.Text == "s+q" | resultado1.Text == "s+r")
               

         */

            /*{

            if (resultado2.Text == "q+p" | resultado2.Text == "q+r" | resultado2.Text == "q+s" |
              resultado2.Text == "p+q" | resultado2.Text == "p+r" | resultado2.Text == "p+s" |
               resultado2.Text == "r+q" | resultado2.Text == "r+q" | resultado2.Text == "r+s" |
                resultado2.Text == "s+q" | resultado2.Text == "s+q" | resultado2.Text == "s+r")*/
            {
                tablasuma1.Visibility = Visibility.Visible;
                tablasuma1.Items.Clear();
                Proposisiciones tempPro = new Proposisiciones();
                tempPro.dos = prop2.Text;
                tempPro.uno = prop1.Text;
                tempPro.tres = resultado1.Text;

                tempPro.cuatro = resultado2.Text;
                tablasuma1.Items.Add(tempPro);
                Proposisiciones tempPro2 = new Proposisiciones();
                tempPro2.dos = "v";
                tempPro2.uno = "f";
                tempPro2.tres = "v";
                tempPro2.cuatro = "v";
                tablasuma1.Items.Add(tempPro2);
                Proposisiciones tempPro3 = new Proposisiciones();
                tempPro3.dos = "f";
                tempPro3.uno = "v";
                tempPro3.tres = "v";
                tempPro3.cuatro = "v";
                tablasuma1.Items.Add(tempPro3);
                Proposisiciones tempPro4 = new Proposisiciones();
                tempPro4.dos = "v";
                tempPro4.uno = "v";
                tempPro4.tres = "v";
                tempPro4.cuatro = "v";
                tablasuma1.Items.Add(tempPro4);
                Proposisiciones tempPro5 = new Proposisiciones();
                tempPro5.dos = "f";
                tempPro5.uno = "f";
                tempPro5.tres = "f";
                tempPro5.cuatro = "f";
                tablasuma1.Items.Add(tempPro5);
                resoluciondeteorema.Text = resoluciondeteorema.Text + "el teorema es verdadero";

                /* Proposisiciones tempPro = new Proposisiciones();
                 tempPro.dos = prop2.Text;
                 tempPro.uno = prop1.Text;
                 tempPro.tres = resultado1.Text;
                 tempPro.cuatro = prop3.Text;
                 tempPro.cinco = prop4.Text;
                 tempPro.seis = resultado2.Text;

                 tablasuma1.Items.Add(tempPro);
                 Proposisiciones tempPro2 = new Proposisiciones();
                 tempPro2.uno = "v";
                 tempPro2.dos = "v";
                 tempPro2.tres = "v";
                 tempPro2.cuatro = "v";
                 tempPro2.cinco="v";
                 tempPro2.seis = "v";

                 tablasuma1.Items.Add(tempPro2);
                 Proposisiciones tempPro3 = new Proposisiciones();
                 tempPro3.uno = "f";
                 tempPro3.dos = "f";
                 tempPro3.tres = "f";
                 tempPro3.cuatro = "f";
                 tempPro3.cinco = "f";
                 tempPro3.seis = "f";

                 tablasuma1.Items.Add(tempPro3);
                 Proposisiciones tempPro4 = new Proposisiciones();
                 tempPro4.uno = "v";
                 tempPro4.dos = "v";
                 tempPro4.tres = "v";
                 tempPro4.cuatro = "f";
                 tempPro4.cinco = "v";
                 tempPro4.seis = "v";

                 tablasuma1.Items.Add(tempPro4);
                 Proposisiciones tempPro5 = new Proposisiciones();
                 tempPro5.uno = "f";
                 tempPro5.dos = "f";
                 tempPro5.tres = "f";
                 tempPro5.cuatro = "v";
                 tempPro5.cinco = "f";
                 tempPro5.seis = "f";

                 tablasuma1.Items.Add(tempPro5);


                 Proposisiciones tempPro6 = new Proposisiciones();
                 tempPro6.uno = "v";
                 tempPro6.dos = "v";
                 tempPro6.tres = "f";
                 tempPro6.cuatro = "v";
                 tempPro6.cinco = "v";
                 tempPro6.seis = "v";

                 tablasuma1.Items.Add(tempPro6);

                 Proposisiciones tempPro7 = new Proposisiciones();
                 tempPro7.uno = "f";
                 tempPro7.dos = "f";
                 tempPro7.tres = "v";
                 tempPro7.cuatro = "f";
                 tempPro7.cinco = "f";
                 tempPro7.seis = "f";

                 tablasuma1.Items.Add(tempPro7);

                 Proposisiciones tempPro8 = new Proposisiciones();
                 tempPro8.uno = "v";
                 tempPro8.dos = "v";
                 tempPro8.tres = "f";
                 tempPro8.cuatro = "f";
                 tempPro8.cinco = "v";
                 tempPro8.seis = "v";

                 tablasuma1.Items.Add(tempPro8);*/





            }


            else if (resultado1.Text == "p*q" && resultado2.Text == "q*p" || resultado1.Text == "p*r" && resultado2.Text == "r*p" || resultado1.Text == "p*s" && resultado2.Text == "s*p" ||
                 resultado1.Text == "q*p" && resultado2.Text == "p*q" || resultado1.Text == "q*r" && resultado2.Text == "r*q" || resultado1.Text == "q*s" && resultado2.Text == "s*q" ||
                 resultado1.Text == "r*q" && resultado2.Text == "q*r" || resultado1.Text == "r*p" && resultado2.Text == "p*r" || resultado1.Text == "r*s" && resultado2.Text == "s*r" ||
                 resultado1.Text == "s*p" && resultado2.Text == "p*s" || resultado1.Text == "s*r" && resultado2.Text == "r*s" || resultado1.Text == "s*q" && resultado2.Text == "q*s" )
              {
                tablasuma1.Visibility = Visibility.Visible;
                tablasuma1.Items.Clear();
                Proposisiciones tempPro = new Proposisiciones();
                tempPro.dos = prop2.Text;
                tempPro.uno = prop1.Text;
                tempPro.tres = resultado1.Text;

                tempPro.cuatro = resultado2.Text;
                tablasuma1.Items.Add(tempPro);
                Proposisiciones tempPro2 = new Proposisiciones();
                tempPro2.dos = "v";
                tempPro2.uno = "f";
                tempPro2.tres = "f";
                tempPro2.cuatro = "f";
                tablasuma1.Items.Add(tempPro2);
                Proposisiciones tempPro3 = new Proposisiciones();
                tempPro3.dos = "f";
                tempPro3.uno = "v";
                tempPro3.tres = "f";
                tempPro3.cuatro = "f";
                tablasuma1.Items.Add(tempPro3);
                Proposisiciones tempPro4 = new Proposisiciones();
                tempPro4.dos = "v";
                tempPro4.uno = "v";
                tempPro4.tres = "v";
                tempPro4.cuatro = "v";
                tablasuma1.Items.Add(tempPro4);
                Proposisiciones tempPro5 = new Proposisiciones();
                tempPro5.dos = "f";
                tempPro5.uno = "f";
                tempPro5.tres = "f";
                tempPro5.cuatro = "f";
                tablasuma1.Items.Add(tempPro5);

                resoluciondeteorema.Text = resoluciondeteorema.Text + "el teorema es verdadero";
            }
            else if (resultado1.Text == "p+q" && resultado2.Text == "q*p" || resultado1.Text == "p+r" && resultado2.Text == "r*p" || resultado1.Text == "p+s" && resultado2.Text == "s*p" ||
                resultado1.Text == "q+p" && resultado2.Text == "p*q" || resultado1.Text == "q+r" && resultado2.Text == "r*q" || resultado1.Text == "q+s" && resultado2.Text == "s*q" ||
                resultado1.Text == "r+q" && resultado2.Text == "q*r" || resultado1.Text == "r+p" && resultado2.Text == "p*r" || resultado1.Text == "r+s" && resultado2.Text == "s*r" ||
                resultado1.Text == "s+p" && resultado2.Text == "p*s" || resultado1.Text == "s+r" && resultado2.Text == "r*s" || resultado1.Text == "s+q" && resultado2.Text == "q*s")
                {
                    tablasuma1.Visibility = Visibility.Visible;
                    tablasuma1.Items.Clear();
                    Proposisiciones tempPro = new Proposisiciones();
                    tempPro.dos = prop2.Text;
                    tempPro.uno = prop1.Text;
                    tempPro.tres = resultado1.Text;

                    tempPro.cuatro = resultado2.Text;
                    tablasuma1.Items.Add(tempPro);
                    Proposisiciones tempPro2 = new Proposisiciones();
                    tempPro2.dos = "v";
                    tempPro2.uno = "v";
                    tempPro2.tres = "v";
                    tempPro2.cuatro = "v";
                    tablasuma1.Items.Add(tempPro2);
                    Proposisiciones tempPro3 = new Proposisiciones();
                    tempPro3.dos = "f";
                    tempPro3.uno = "f";
                    tempPro3.tres = "f";
                    tempPro3.cuatro = "f";
                    tablasuma1.Items.Add(tempPro3);
                    Proposisiciones tempPro4 = new Proposisiciones();
                    tempPro4.dos = "v";
                    tempPro4.uno = "f";
                    tempPro4.tres = "v";
                    tempPro4.cuatro = "f";
                    tablasuma1.Items.Add(tempPro4);
                    Proposisiciones tempPro5 = new Proposisiciones();
                    tempPro5.dos = "f";
                    tempPro5.uno = "v";
                    tempPro5.tres = "v";
                    tempPro5.cuatro = "f";
                    tablasuma1.Items.Add(tempPro5);

                    resoluciondeteorema.Text = resoluciondeteorema.Text + "el teorema es falso";
                }
            else if (resultado1.Text == "p*q" && resultado2.Text == "q+p" || resultado1.Text == "p*r" && resultado2.Text == "r+p" || resultado1.Text == "p*s" && resultado2.Text == "s+p" ||
               resultado1.Text == "q*p" && resultado2.Text == "p+q" || resultado1.Text == "q*r" && resultado2.Text == "r+q" || resultado1.Text == "q*s" && resultado2.Text == "s+q" ||
               resultado1.Text == "r*q" && resultado2.Text == "q+r" || resultado1.Text == "r*p" && resultado2.Text == "p+r" || resultado1.Text == "r*s" && resultado2.Text == "s+r" ||
               resultado1.Text == "s*p" && resultado2.Text == "p+s" || resultado1.Text == "s*r" && resultado2.Text == "r+s" || resultado1.Text == "s*q" && resultado2.Text == "q+s")
            {
                tablasuma1.Visibility = Visibility.Visible;
                tablasuma1.Items.Clear();
                Proposisiciones tempPro = new Proposisiciones();
                tempPro.dos = prop2.Text;
                tempPro.uno = prop1.Text;
                tempPro.tres = resultado1.Text;

                tempPro.cuatro = resultado2.Text;
                tablasuma1.Items.Add(tempPro);
                Proposisiciones tempPro2 = new Proposisiciones();
                tempPro2.dos = "v";
                tempPro2.uno = "v";
                tempPro2.tres = "v";
                tempPro2.cuatro = "v";
                tablasuma1.Items.Add(tempPro2);
                Proposisiciones tempPro3 = new Proposisiciones();
                tempPro3.dos = "f";
                tempPro3.uno = "f";
                tempPro3.tres = "f";
                tempPro3.cuatro = "f";
                tablasuma1.Items.Add(tempPro3);
                Proposisiciones tempPro4 = new Proposisiciones();
                tempPro4.dos = "v";
                tempPro4.uno = "f";
                tempPro4.tres = "f";
                tempPro4.cuatro = "v";
                tablasuma1.Items.Add(tempPro4);
                Proposisiciones tempPro5 = new Proposisiciones();
                tempPro5.dos = "f";
                tempPro5.uno = "v";
                tempPro5.tres = "f";
                tempPro5.cuatro = "v";
                tablasuma1.Items.Add(tempPro5);

                resoluciondeteorema.Text = resoluciondeteorema.Text + "el teorema es falso";
            }

            else if (resultado1.Text=="p+q" || resultado1.Text == "p+r" || resultado1.Text == "p+s" || resultado1.Text == "q+p" || resultado1.Text == "r+p" || resultado1.Text == "s+sp")
            {
                if(resultado2.Text=="p+r" || resultado2.Text=="p+s" || resultado2.Text =="r+p" || resultado2.Text=="s+p" || resultado2.Text=="q+p" || resultado2.Text == "p+q")
                {
                    tablasuma1.Visibility = Visibility.Visible;
                    tablasuma1.Items.Clear();
                    Proposisiciones tempPro = new Proposisiciones();
                    tempPro.dos = prop2.Text;
                    tempPro.uno = prop1.Text;
                    tempPro.tres = prop4.Text;
                    tempPro.cuatro = resultado1.Text;
                    tempPro.cinco = resultado2.Text;

                    tablasuma1.Items.Add(tempPro);
                    Proposisiciones tempPro2 = new Proposisiciones();
                    tempPro2.dos = "v";
                    tempPro2.uno = "v";
                    tempPro2.tres = "v";
                    tempPro2.cuatro = "v";
                    tempPro2.cinco = "v";
                    tablasuma1.Items.Add(tempPro2);
                    Proposisiciones tempPro3 = new Proposisiciones();
                    tempPro3.dos = "f";
                    tempPro3.uno = "f";
                    tempPro3.tres = "f";
                    tempPro3.cuatro = "f";
                    tempPro3.cinco = "f";
                    tablasuma1.Items.Add(tempPro3);
                    Proposisiciones tempPro4 = new Proposisiciones();
                    tempPro4.dos = "v";
                    tempPro4.uno = "v";
                    tempPro4.tres = "f";
                    tempPro4.cuatro = "v";
                    tempPro4.cinco = "v";
                    tablasuma1.Items.Add(tempPro4);
                    Proposisiciones tempPro5 = new Proposisiciones();
                    tempPro5.dos = "f";
                    tempPro5.uno = "f";
                    tempPro5.tres = "v";
                    tempPro5.cuatro = "f";
                    tempPro5.cinco = "f";
                    tablasuma1.Items.Add(tempPro5);
                    Proposisiciones tempPro6 = new Proposisiciones();
                    tempPro6.dos = "v";
                    tempPro6.uno = "f";
                    tempPro6.tres = "v";
                    tempPro6.cuatro = "v";
                    tempPro6.cinco = "v";
                    tablasuma1.Items.Add(tempPro6);
                    Proposisiciones tempPro7 = new Proposisiciones();
                    tempPro7.dos = "f";
                    tempPro7.uno = "v";
                    tempPro7.tres = "f";
                    tempPro7.cuatro = "v";
                    tempPro7.cinco = "v";
                    tablasuma1.Items.Add(tempPro7);
                    Proposisiciones tempPro8 = new Proposisiciones();
                    tempPro8.dos = "v";
                    tempPro8.uno = "f";
                    tempPro8.tres = "f";
                    tempPro8.cuatro = "v";
                    tempPro8.cinco = "v";
                    tablasuma1.Items.Add(tempPro8);
                    Proposisiciones tempPro9 = new Proposisiciones();
                    tempPro9.dos = "v";
                    tempPro9.uno = "f";
                    tempPro9.tres = "f";
                    tempPro9.cuatro = "v";
                    tempPro9.cinco = "v";
                    tablasuma1.Items.Add(tempPro9);
                    resoluciondeteorema.Text = resoluciondeteorema.Text + "el teorema es verdadero";
                }
            }

           
            else if (resultado1.Text == "q+p" || resultado1.Text == "q+r" || resultado1.Text == "q+s" || resultado1.Text == "p+q" || resultado1.Text == "r+q" || resultado1.Text == "s+q")
            {
                if (resultado2.Text == "q+r" || resultado2.Text == "q+s" || resultado2.Text == "q+p" || resultado2.Text == "r+q" || resultado2.Text == "s+q" || resultado2.Text == "p+q")

                {
                    tablasuma1.Visibility = Visibility.Visible;
                    tablasuma1.Items.Clear();
                    Proposisiciones tempPro = new Proposisiciones();
                    tempPro.dos = prop2.Text;
                    tempPro.uno = prop1.Text;
                    tempPro.tres = prop4.Text;
                    tempPro.cuatro = resultado1.Text;
                    tempPro.cinco = resultado2.Text;

                    tablasuma1.Items.Add(tempPro);
                    Proposisiciones tempPro2 = new Proposisiciones();
                    tempPro2.dos = "v";
                    tempPro2.uno = "v";
                    tempPro2.tres = "v";
                    tempPro2.cuatro = "v";
                    tempPro2.cinco = "v";
                    tablasuma1.Items.Add(tempPro2);
                    Proposisiciones tempPro3 = new Proposisiciones();
                    tempPro3.dos = "f";
                    tempPro3.uno = "f";
                    tempPro3.tres = "f";
                    tempPro3.cuatro = "f";
                    tempPro3.cinco = "f";
                    tablasuma1.Items.Add(tempPro3);
                    Proposisiciones tempPro4 = new Proposisiciones();
                    tempPro4.dos = "v";
                    tempPro4.uno = "v";
                    tempPro4.tres = "f";
                    tempPro4.cuatro = "v";
                    tempPro4.cinco = "v";
                    tablasuma1.Items.Add(tempPro4);
                    Proposisiciones tempPro5 = new Proposisiciones();
                    tempPro5.dos = "f";
                    tempPro5.uno = "f";
                    tempPro5.tres = "v";
                    tempPro5.cuatro = "f";
                    tempPro5.cinco = "f";
                    tablasuma1.Items.Add(tempPro5);
                    Proposisiciones tempPro6 = new Proposisiciones();
                    tempPro6.dos = "v";
                    tempPro6.uno = "f";
                    tempPro6.tres = "v";
                    tempPro6.cuatro = "v";
                    tempPro6.cinco = "v";
                    tablasuma1.Items.Add(tempPro6);
                    Proposisiciones tempPro7 = new Proposisiciones();
                    tempPro7.dos = "f";
                    tempPro7.uno = "v";
                    tempPro7.tres = "f";
                    tempPro7.cuatro = "v";
                    tempPro7.cinco = "v";
                    tablasuma1.Items.Add(tempPro7);
                    Proposisiciones tempPro8 = new Proposisiciones();
                    tempPro8.dos = "v";
                    tempPro8.uno = "f";
                    tempPro8.tres = "f";
                    tempPro8.cuatro = "v";
                    tempPro8.cinco = "v";
                    tablasuma1.Items.Add(tempPro8);
                    Proposisiciones tempPro9 = new Proposisiciones();
                    tempPro9.dos = "v";
                    tempPro9.uno = "f";
                    tempPro9.tres = "f";
                    tempPro9.cuatro = "v";
                    tempPro9.cinco = "v";
                    tablasuma1.Items.Add(tempPro9);
                    resoluciondeteorema.Text = resoluciondeteorema.Text + "el teorema es verdadero";
                }
            }
           
            else if (resultado1.Text == "r+p" || resultado1.Text == "r+q" || resultado1.Text == "r+s" || resultado1.Text == "p+r" || resultado1.Text == "q+r" || resultado1.Text == "s+r")
            {
                if (resultado2.Text == "r+q" || resultado2.Text == "r+s" || resultado2.Text == "r+p" || resultado2.Text == "q+r" || resultado2.Text == "s+r" || resultado2.Text == "p+r")

                {
                    tablasuma1.Visibility = Visibility.Visible;
                    tablasuma1.Items.Clear();
                    Proposisiciones tempPro = new Proposisiciones();
                    tempPro.dos = prop2.Text;
                    tempPro.uno = prop1.Text;
                    tempPro.tres = prop4.Text;
                    tempPro.cuatro = resultado1.Text;
                    tempPro.cinco = resultado2.Text;

                    tablasuma1.Items.Add(tempPro);
                    Proposisiciones tempPro2 = new Proposisiciones();
                    tempPro2.dos = "v";
                    tempPro2.uno = "v";
                    tempPro2.tres = "v";
                    tempPro2.cuatro = "v";
                    tempPro2.cinco = "v";
                    tablasuma1.Items.Add(tempPro2);
                    Proposisiciones tempPro3 = new Proposisiciones();
                    tempPro3.dos = "f";
                    tempPro3.uno = "f";
                    tempPro3.tres = "f";
                    tempPro3.cuatro = "f";
                    tempPro3.cinco = "f";
                    tablasuma1.Items.Add(tempPro3);
                    Proposisiciones tempPro4 = new Proposisiciones();
                    tempPro4.dos = "v";
                    tempPro4.uno = "v";
                    tempPro4.tres = "f";
                    tempPro4.cuatro = "v";
                    tempPro4.cinco = "v";
                    tablasuma1.Items.Add(tempPro4);
                    Proposisiciones tempPro5 = new Proposisiciones();
                    tempPro5.dos = "f";
                    tempPro5.uno = "f";
                    tempPro5.tres = "v";
                    tempPro5.cuatro = "f";
                    tempPro5.cinco = "f";
                    tablasuma1.Items.Add(tempPro5);
                    Proposisiciones tempPro6 = new Proposisiciones();
                    tempPro6.dos = "v";
                    tempPro6.uno = "f";
                    tempPro6.tres = "v";
                    tempPro6.cuatro = "v";
                    tempPro6.cinco = "v";
                    tablasuma1.Items.Add(tempPro6);
                    Proposisiciones tempPro7 = new Proposisiciones();
                    tempPro7.dos = "f";
                    tempPro7.uno = "v";
                    tempPro7.tres = "f";
                    tempPro7.cuatro = "v";
                    tempPro7.cinco = "v";
                    tablasuma1.Items.Add(tempPro7);
                    Proposisiciones tempPro8 = new Proposisiciones();
                    tempPro8.dos = "v";
                    tempPro8.uno = "f";
                    tempPro8.tres = "f";
                    tempPro8.cuatro = "v";
                    tempPro8.cinco = "v";
                    tablasuma1.Items.Add(tempPro8);
                    Proposisiciones tempPro9 = new Proposisiciones();
                    tempPro9.dos = "v";
                    tempPro9.uno = "f";
                    tempPro9.tres = "f";
                    tempPro9.cuatro = "v";
                    tempPro9.cinco = "v";
                    tablasuma1.Items.Add(tempPro9);
                    resoluciondeteorema.Text = resoluciondeteorema.Text + "el teorema es verdadero";
                }
            }
            
            else if (resultado1.Text == "s+p" || resultado1.Text == "s+q" || resultado1.Text == "s+r" || resultado1.Text == "p+s" || resultado1.Text == "q+s" || resultado1.Text == "r+s")
            {
                if (resultado2.Text == "s+q" || resultado2.Text == "s+r" || resultado2.Text == "s+p" || resultado2.Text == "q+s" || resultado2.Text == "r+s" || resultado2.Text == "p+s")

                {
                    tablasuma1.Visibility = Visibility.Visible;
                    tablasuma1.Items.Clear();
                    Proposisiciones tempPro = new Proposisiciones();
                    tempPro.dos = prop2.Text;
                    tempPro.uno = prop1.Text;
                    tempPro.tres = prop4.Text;
                    tempPro.cuatro = resultado1.Text;
                    tempPro.cinco = resultado2.Text;

                    tablasuma1.Items.Add(tempPro);
                    Proposisiciones tempPro2 = new Proposisiciones();
                    tempPro2.dos = "v";
                    tempPro2.uno = "v";
                    tempPro2.tres = "v";
                    tempPro2.cuatro = "v";
                    tempPro2.cinco = "v";
                    tablasuma1.Items.Add(tempPro2);
                    Proposisiciones tempPro3 = new Proposisiciones();
                    tempPro3.dos = "f";
                    tempPro3.uno = "f";
                    tempPro3.tres = "f";
                    tempPro3.cuatro = "f";
                    tempPro3.cinco = "f";
                    tablasuma1.Items.Add(tempPro3);
                    Proposisiciones tempPro4 = new Proposisiciones();
                    tempPro4.dos = "v";
                    tempPro4.uno = "v";
                    tempPro4.tres = "f";
                    tempPro4.cuatro = "v";
                    tempPro4.cinco = "v";
                    tablasuma1.Items.Add(tempPro4);
                    Proposisiciones tempPro5 = new Proposisiciones();
                    tempPro5.dos = "f";
                    tempPro5.uno = "f";
                    tempPro5.tres = "v";
                    tempPro5.cuatro = "f";
                    tempPro5.cinco = "f";
                    tablasuma1.Items.Add(tempPro5);
                    Proposisiciones tempPro6 = new Proposisiciones();
                    tempPro6.dos = "v";
                    tempPro6.uno = "f";
                    tempPro6.tres = "v";
                    tempPro6.cuatro = "v";
                    tempPro6.cinco = "v";
                    tablasuma1.Items.Add(tempPro6);
                    Proposisiciones tempPro7 = new Proposisiciones();
                    tempPro7.dos = "f";
                    tempPro7.uno = "v";
                    tempPro7.tres = "f";
                    tempPro7.cuatro = "v";
                    tempPro7.cinco = "v";
                    tablasuma1.Items.Add(tempPro7);
                    Proposisiciones tempPro8 = new Proposisiciones();
                    tempPro8.dos = "v";
                    tempPro8.uno = "f";
                    tempPro8.tres = "f";
                    tempPro8.cuatro = "v";
                    tempPro8.cinco = "v";
                    tablasuma1.Items.Add(tempPro8);
                    Proposisiciones tempPro9 = new Proposisiciones();
                    tempPro9.dos = "v";
                    tempPro9.uno = "f";
                    tempPro9.tres = "f";
                    tempPro9.cuatro = "v";
                    tempPro9.cinco = "v";
                    tablasuma1.Items.Add(tempPro9);
                    resoluciondeteorema.Text = resoluciondeteorema.Text + "el teorema es verdadero";
                }
            }
         



            //multiplicacion con no mas de 3 proposiciones 


            else if (resultado1.Text == "p*q" || resultado1.Text == "p*r" || resultado1.Text == "p*s" || resultado1.Text == "q*p" || resultado1.Text == "r*p" || resultado1.Text == "s*p") 
            {
                if (resultado2.Text == "p*r" || resultado2.Text == "p*s" || resultado2.Text == "p*q" || resultado2.Text == "r*p" || resultado2.Text == "s*p" || resultado2.Text == "q*p")
                {
                    tablasuma1.Visibility = Visibility.Visible;
                    tablasuma1.Items.Clear();
                    Proposisiciones tempPro = new Proposisiciones();
                    tempPro.dos = prop2.Text;
                    tempPro.uno = prop1.Text;
                    tempPro.tres = prop4.Text;
                    tempPro.cuatro = resultado1.Text;
                    tempPro.cinco = resultado2.Text;

                    tablasuma1.Items.Add(tempPro);
                    Proposisiciones tempPro2 = new Proposisiciones();
                    tempPro2.dos = "v";
                    tempPro2.uno = "v";
                    tempPro2.tres = "v";
                    tempPro2.cuatro = "v";
                    tempPro2.cinco = "v";
                    tablasuma1.Items.Add(tempPro2);
                    Proposisiciones tempPro3 = new Proposisiciones();
                    tempPro3.dos = "f";
                    tempPro3.uno = "f";
                    tempPro3.tres = "f";
                    tempPro3.cuatro = "f";
                    tempPro3.cinco = "f";
                    tablasuma1.Items.Add(tempPro3);
                    Proposisiciones tempPro4 = new Proposisiciones();
                    tempPro4.dos = "v";
                    tempPro4.uno = "v";
                    tempPro4.tres = "f";
                    tempPro4.cuatro = "v";
                    tempPro4.cinco = "f";
                    tablasuma1.Items.Add(tempPro4);
                    Proposisiciones tempPro5 = new Proposisiciones();
                    tempPro5.dos = "f";
                    tempPro5.uno = "f";
                    tempPro5.tres = "v";
                    tempPro5.cuatro = "f";
                    tempPro5.cinco = "f";
                    tablasuma1.Items.Add(tempPro5);
                    Proposisiciones tempPro6 = new Proposisiciones();
                    tempPro6.dos = "v";
                    tempPro6.uno = "f";
                    tempPro6.tres = "v";
                    tempPro6.cuatro = "f";
                    tempPro6.cinco = "f";
                    tablasuma1.Items.Add(tempPro6);
                    Proposisiciones tempPro7 = new Proposisiciones();
                    tempPro7.dos = "f";
                    tempPro7.uno = "v";
                    tempPro7.tres = "f";
                    tempPro7.cuatro = "f";
                    tempPro7.cinco = "f";
                    tablasuma1.Items.Add(tempPro7);
                    Proposisiciones tempPro8 = new Proposisiciones();
                    tempPro8.dos = "v";
                    tempPro8.uno = "f";
                    tempPro8.tres = "f";
                    tempPro8.cuatro = "f";
                    tempPro8.cinco = "f";
                    tablasuma1.Items.Add(tempPro8);
                    Proposisiciones tempPro9 = new Proposisiciones();
                    tempPro9.dos = "f";
                    tempPro9.uno = "v";
                    tempPro9.tres = "v";
                    tempPro9.cuatro = "f";
                    tempPro9.cinco = "f";
                    tablasuma1.Items.Add(tempPro9);
                    resoluciondeteorema.Text = resoluciondeteorema.Text + "el teorema es falso";
                }
            }

            
            if (resultado1.Text == "q*p" || resultado1.Text == "q*r" || resultado1.Text == "q*s" || resultado1.Text == "p*q" || resultado1.Text == "r*q" || resultado1.Text == "s*q")
            {
                if (resultado2.Text == "q*r" || resultado2.Text == "q*s" || resultado2.Text == "q*p" || resultado2.Text == "r*q" || resultado2.Text == "s*q" || resultado2.Text == "p*q")

                {
                    tablasuma1.Visibility = Visibility.Visible;
                    tablasuma1.Items.Clear();
                    Proposisiciones tempPro = new Proposisiciones();
                    tempPro.dos = prop2.Text;
                    tempPro.uno = prop1.Text;
                    tempPro.tres = prop4.Text;
                    tempPro.cuatro = resultado1.Text;
                    tempPro.cinco = resultado2.Text;

                    tablasuma1.Items.Add(tempPro);
                    Proposisiciones tempPro2 = new Proposisiciones();
                    tempPro2.dos = "v";
                    tempPro2.uno = "v";
                    tempPro2.tres = "v";
                    tempPro2.cuatro = "v";
                    tempPro2.cinco = "v";
                    tablasuma1.Items.Add(tempPro2);
                    Proposisiciones tempPro3 = new Proposisiciones();
                    tempPro3.dos = "f";
                    tempPro3.uno = "f";
                    tempPro3.tres = "f";
                    tempPro3.cuatro = "f";
                    tempPro3.cinco = "f";
                    tablasuma1.Items.Add(tempPro3);
                    Proposisiciones tempPro4 = new Proposisiciones();
                    tempPro4.dos = "v";
                    tempPro4.uno = "v";
                    tempPro4.tres = "f";
                    tempPro4.cuatro = "v";
                    tempPro4.cinco = "f";
                    tablasuma1.Items.Add(tempPro4);
                    Proposisiciones tempPro5 = new Proposisiciones();
                    tempPro5.dos = "f";
                    tempPro5.uno = "f";
                    tempPro5.tres = "v";
                    tempPro5.cuatro = "f";
                    tempPro5.cinco = "f";
                    tablasuma1.Items.Add(tempPro5);
                    Proposisiciones tempPro6 = new Proposisiciones();
                    tempPro6.dos = "v";
                    tempPro6.uno = "f";
                    tempPro6.tres = "v";
                    tempPro6.cuatro = "f";
                    tempPro6.cinco = "f";
                    tablasuma1.Items.Add(tempPro6);
                    Proposisiciones tempPro7 = new Proposisiciones();
                    tempPro7.dos = "f";
                    tempPro7.uno = "v";
                    tempPro7.tres = "f";
                    tempPro7.cuatro = "f";
                    tempPro7.cinco = "f";
                    tablasuma1.Items.Add(tempPro7);
                    Proposisiciones tempPro8 = new Proposisiciones();
                    tempPro8.dos = "v";
                    tempPro8.uno = "f";
                    tempPro8.tres = "f";
                    tempPro8.cuatro = "f";
                    tempPro8.cinco = "f";
                    tablasuma1.Items.Add(tempPro8);
                    Proposisiciones tempPro9 = new Proposisiciones();
                    tempPro9.dos = "f";
                    tempPro9.uno = "v";
                    tempPro9.tres = "v";
                    tempPro9.cuatro = "f";
                    tempPro9.cinco = "f";
                    tablasuma1.Items.Add(tempPro9);
                    resoluciondeteorema.Text = resoluciondeteorema.Text + "el teorema es falso";
                }
            }
          
            if (resultado1.Text == "r*p" || resultado1.Text == "r*q" || resultado1.Text == "r*s" || resultado1.Text == "p*r" || resultado1.Text == "q*r" || resultado1.Text == "s*r")
            {
                if (resultado2.Text == "r*q" || resultado2.Text == "r*s" || resultado2.Text == "r*p" || resultado2.Text == "q*r" || resultado2.Text == "s*r" || resultado2.Text == "p*r")

                {
                    tablasuma1.Visibility = Visibility.Visible;
                    tablasuma1.Items.Clear();
                    Proposisiciones tempPro = new Proposisiciones();
                    tempPro.dos = prop2.Text;
                    tempPro.uno = prop1.Text;
                    tempPro.tres = prop4.Text;
                    tempPro.cuatro = resultado1.Text;
                    tempPro.cinco = resultado2.Text;

                    tablasuma1.Items.Add(tempPro);
                    Proposisiciones tempPro2 = new Proposisiciones();
                    tempPro2.dos = "v";
                    tempPro2.uno = "v";
                    tempPro2.tres = "v";
                    tempPro2.cuatro = "v";
                    tempPro2.cinco = "v";
                    tablasuma1.Items.Add(tempPro2);
                    Proposisiciones tempPro3 = new Proposisiciones();
                    tempPro3.dos = "f";
                    tempPro3.uno = "f";
                    tempPro3.tres = "f";
                    tempPro3.cuatro = "f";
                    tempPro3.cinco = "f";
                    tablasuma1.Items.Add(tempPro3);
                    Proposisiciones tempPro4 = new Proposisiciones();
                    tempPro4.dos = "v";
                    tempPro4.uno = "v";
                    tempPro4.tres = "f";
                    tempPro4.cuatro = "v";
                    tempPro4.cinco = "f";
                    tablasuma1.Items.Add(tempPro4);
                    Proposisiciones tempPro5 = new Proposisiciones();
                    tempPro5.dos = "f";
                    tempPro5.uno = "f";
                    tempPro5.tres = "v";
                    tempPro5.cuatro = "f";
                    tempPro5.cinco = "f";
                    tablasuma1.Items.Add(tempPro5);
                    Proposisiciones tempPro6 = new Proposisiciones();
                    tempPro6.dos = "v";
                    tempPro6.uno = "f";
                    tempPro6.tres = "v";
                    tempPro6.cuatro = "f";
                    tempPro6.cinco = "f";
                    tablasuma1.Items.Add(tempPro6);
                    Proposisiciones tempPro7 = new Proposisiciones();
                    tempPro7.dos = "f";
                    tempPro7.uno = "v";
                    tempPro7.tres = "f";
                    tempPro7.cuatro = "f";
                    tempPro7.cinco = "f";
                    tablasuma1.Items.Add(tempPro7);
                    Proposisiciones tempPro8 = new Proposisiciones();
                    tempPro8.dos = "v";
                    tempPro8.uno = "f";
                    tempPro8.tres = "f";
                    tempPro8.cuatro = "f";
                    tempPro8.cinco = "f";
                    tablasuma1.Items.Add(tempPro8);
                    Proposisiciones tempPro9 = new Proposisiciones();
                    tempPro9.dos = "f";
                    tempPro9.uno = "v";
                    tempPro9.tres = "v";
                    tempPro9.cuatro = "f";
                    tempPro9.cinco = "f";
                    tablasuma1.Items.Add(tempPro9);
                    resoluciondeteorema.Text = resoluciondeteorema.Text + "el teorema es falso";
                }
            }
                        


            if (resultado1.Text == "s*p" || resultado1.Text == "s*q" || resultado1.Text == "s*r" || resultado1.Text == "p*s" || resultado1.Text == "q*s" || resultado1.Text == "r*s")
            {
                if (resultado2.Text == "s*q" || resultado2.Text == "s*r" || resultado2.Text == "s*p" || resultado2.Text == "q*s" || resultado2.Text == "r*s" || resultado2.Text == "p*s")

                {
                    tablasuma1.Visibility = Visibility.Visible;
                    tablasuma1.Items.Clear();
                    Proposisiciones tempPro = new Proposisiciones();
                    tempPro.dos = prop2.Text;
                    tempPro.uno = prop1.Text;
                    tempPro.tres = prop4.Text;
                    tempPro.cuatro = resultado1.Text;
                    tempPro.cinco = resultado2.Text;

                    tablasuma1.Items.Add(tempPro);
                    Proposisiciones tempPro2 = new Proposisiciones();
                    tempPro2.dos = "v";
                    tempPro2.uno = "v";
                    tempPro2.tres = "v";
                    tempPro2.cuatro = "v";
                    tempPro2.cinco = "v";
                    tablasuma1.Items.Add(tempPro2);
                    Proposisiciones tempPro3 = new Proposisiciones();
                    tempPro3.dos = "f";
                    tempPro3.uno = "f";
                    tempPro3.tres = "f";
                    tempPro3.cuatro = "f";
                    tempPro3.cinco = "f";
                    tablasuma1.Items.Add(tempPro3);
                    Proposisiciones tempPro4 = new Proposisiciones();
                    tempPro4.dos = "v";
                    tempPro4.uno = "v";
                    tempPro4.tres = "f";
                    tempPro4.cuatro = "v";
                    tempPro4.cinco = "f";
                    tablasuma1.Items.Add(tempPro4);
                    Proposisiciones tempPro5 = new Proposisiciones();
                    tempPro5.dos = "f";
                    tempPro5.uno = "f";
                    tempPro5.tres = "v";
                    tempPro5.cuatro = "f";
                    tempPro5.cinco = "f";
                    tablasuma1.Items.Add(tempPro5);
                    Proposisiciones tempPro6 = new Proposisiciones();
                    tempPro6.dos = "v";
                    tempPro6.uno = "f";
                    tempPro6.tres = "v";
                    tempPro6.cuatro = "f";
                    tempPro6.cinco = "f";
                    tablasuma1.Items.Add(tempPro6);
                    Proposisiciones tempPro7 = new Proposisiciones();
                    tempPro7.dos = "f";
                    tempPro7.uno = "v";
                    tempPro7.tres = "f";
                    tempPro7.cuatro = "f";
                    tempPro7.cinco = "f";
                    tablasuma1.Items.Add(tempPro7);
                    Proposisiciones tempPro8 = new Proposisiciones();
                    tempPro8.dos = "v";
                    tempPro8.uno = "f";
                    tempPro8.tres = "f";
                    tempPro8.cuatro = "f";
                    tempPro8.cinco = "f";
                    tablasuma1.Items.Add(tempPro8);
                    Proposisiciones tempPro9 = new Proposisiciones();
                    tempPro9.dos = "f";
                    tempPro9.uno = "v";
                    tempPro9.tres = "v";
                    tempPro9.cuatro = "f";
                    tempPro9.cinco = "f";
                    tablasuma1.Items.Add(tempPro9);
                    resoluciondeteorema.Text = resoluciondeteorema.Text + "el teorema es falso";
                } //10
            }
                


            if (resultado1.Text == "p+q" || resultado1.Text == "q+p" || resultado1.Text == "p+r" || resultado1.Text == "r+p" || resultado1.Text == "p+s" || resultado1.Text == "s+p")  //suma y mulyiplicacion con 3 proposiciones     //////////////////////////
            {
                if (resultado2.Text == "p*r" || resultado2.Text == "p*s" || resultado2.Text == "r*p" || resultado2.Text == "s*p" || resultado2.Text == "p*q" || resultado2.Text == "q*p")
                {
                    tablasuma1.Visibility = Visibility.Visible;
                    tablasuma1.Items.Clear();
                    Proposisiciones tempPro = new Proposisiciones();
                    tempPro.dos = prop2.Text;
                    tempPro.uno = prop1.Text;
                    tempPro.tres = prop4.Text;
                    tempPro.cuatro = resultado1.Text;
                    tempPro.cinco = resultado2.Text;
                    tablasuma1.Items.Add(tempPro);
                    Proposisiciones tempPro2 = new Proposisiciones();
                    tempPro2.dos = "v";
                    tempPro2.uno = "v";
                    tempPro2.tres = "v";
                    tempPro2.cuatro = "v";
                    tempPro2.cinco = "v";
                    tablasuma1.Items.Add(tempPro2);
                    Proposisiciones tempPro3 = new Proposisiciones();
                    tempPro3.dos = "f";
                    tempPro3.uno = "f";
                    tempPro3.tres = "f";
                    tempPro3.cuatro = "f";
                    tempPro3.cinco = "f";
                    tablasuma1.Items.Add(tempPro3);
                    Proposisiciones tempPro4 = new Proposisiciones();
                    tempPro4.dos = "v";
                    tempPro4.uno = "v";
                    tempPro4.tres = "f";
                    tempPro4.cuatro = "v";
                    tempPro4.cinco = "f";
                    tablasuma1.Items.Add(tempPro4);
                    Proposisiciones tempPro5 = new Proposisiciones();
                    tempPro5.dos = "f";
                    tempPro5.uno = "f";
                    tempPro5.tres = "v";
                    tempPro5.cuatro = "f";
                    tempPro5.cinco = "f";
                    tablasuma1.Items.Add(tempPro5);
                    Proposisiciones tempPro6 = new Proposisiciones();
                    tempPro6.dos = "v";
                    tempPro6.uno = "f";
                    tempPro6.tres = "v";
                    tempPro6.cuatro = "v";
                    tempPro6.cinco = "f";
                    tablasuma1.Items.Add(tempPro6);
                    Proposisiciones tempPro7 = new Proposisiciones();
                    tempPro7.dos = "f";
                    tempPro7.uno = "v";
                    tempPro7.tres = "f";
                    tempPro7.cuatro = "v";
                    tempPro7.cinco = "f";
                    tablasuma1.Items.Add(tempPro7);
                    Proposisiciones tempPro8 = new Proposisiciones();
                    tempPro8.dos = "v";
                    tempPro8.uno = "f";
                    tempPro8.tres = "f";
                    tempPro8.cuatro = "v";
                    tempPro8.cinco = "f";
                    tablasuma1.Items.Add(tempPro8);
                    Proposisiciones tempPro9 = new Proposisiciones();
                    tempPro9.dos = "f";
                    tempPro9.uno = "v";
                    tempPro9.tres = "v";
                    tempPro9.cuatro = "v";
                    tempPro9.cinco = "f";
                    tablasuma1.Items.Add(tempPro9);
                    resoluciondeteorema.Text = resoluciondeteorema.Text + "el teorema es falso";
                }
            }
          
            //1
            if (resultado1.Text == "q+r" || resultado1.Text == "r+q" || resultado1.Text == "q+s" || resultado1.Text == "s+q" || resultado1.Text == "q+p" || resultado1.Text == "p+q")
            {
                if (resultado2.Text == "q*p" || resultado2.Text == "q*s" || resultado2.Text == "q*p" || resultado2.Text == "p*q" || resultado2.Text == "s*q" || resultado2.Text == "p*q")
                {
                    tablasuma1.Visibility = Visibility.Visible;
                    tablasuma1.Items.Clear();
                    Proposisiciones tempPro = new Proposisiciones();
                    tempPro.dos = prop2.Text;
                    tempPro.uno = prop1.Text;
                    tempPro.tres = prop4.Text;
                    tempPro.cuatro = resultado1.Text;
                    tempPro.cinco = resultado2.Text;

                    tablasuma1.Items.Add(tempPro);
                    Proposisiciones tempPro2 = new Proposisiciones();
                    tempPro2.dos = "v";
                    tempPro2.uno = "v";
                    tempPro2.tres = "v";
                    tempPro2.cuatro = "v";
                    tempPro2.cinco = "v";
                    tablasuma1.Items.Add(tempPro2);
                    Proposisiciones tempPro3 = new Proposisiciones();
                    tempPro3.dos = "f";
                    tempPro3.uno = "f";
                    tempPro3.tres = "f";
                    tempPro3.cuatro = "f";
                    tempPro3.cinco = "f";
                    tablasuma1.Items.Add(tempPro3);
                    Proposisiciones tempPro4 = new Proposisiciones();
                    tempPro4.dos = "v";
                    tempPro4.uno = "v";
                    tempPro4.tres = "f";
                    tempPro4.cuatro = "v";
                    tempPro4.cinco = "f";
                    tablasuma1.Items.Add(tempPro4);
                    Proposisiciones tempPro5 = new Proposisiciones();
                    tempPro5.dos = "f";
                    tempPro5.uno = "f";
                    tempPro5.tres = "v";
                    tempPro5.cuatro = "f";
                    tempPro5.cinco = "f";
                    tablasuma1.Items.Add(tempPro5);
                    Proposisiciones tempPro6 = new Proposisiciones();
                    tempPro6.dos = "v";
                    tempPro6.uno = "f";
                    tempPro6.tres = "v";
                    tempPro6.cuatro = "v";
                    tempPro6.cinco = "f";
                    tablasuma1.Items.Add(tempPro6);
                    Proposisiciones tempPro7 = new Proposisiciones();
                    tempPro7.dos = "f";
                    tempPro7.uno = "v";
                    tempPro7.tres = "f";
                    tempPro7.cuatro = "v";
                    tempPro7.cinco = "f";
                    tablasuma1.Items.Add(tempPro7);
                    Proposisiciones tempPro8 = new Proposisiciones();
                    tempPro8.dos = "v";
                    tempPro8.uno = "f";
                    tempPro8.tres = "f";
                    tempPro8.cuatro = "v";
                    tempPro8.cinco = "f";
                    tablasuma1.Items.Add(tempPro8);
                    Proposisiciones tempPro9 = new Proposisiciones();
                    tempPro9.dos = "f";
                    tempPro9.uno = "v";
                    tempPro9.tres = "v";
                    tempPro9.cuatro = "v";
                    tempPro9.cinco = "f";
                    tablasuma1.Items.Add(tempPro9);
                    resoluciondeteorema.Text = resoluciondeteorema.Text + "el teorema es falso";
                }
            }
            //3
           
            if (resultado1.Text == "r+p" || resultado1.Text == "r+q" || resultado1.Text == "r+s" || resultado1.Text == "p+r" || resultado1.Text == "q+r" || resultado1.Text == "s+r")
            {
                if (resultado2.Text == "r*q" || resultado2.Text == "r*s" || resultado2.Text == "r*p" || resultado2.Text == "q*r" || resultado2.Text == "s*r" || resultado2.Text == "p*r")
                {
                    tablasuma1.Visibility = Visibility.Visible;
                    tablasuma1.Items.Clear();
                    Proposisiciones tempPro = new Proposisiciones();
                    tempPro.dos = prop2.Text;
                    tempPro.uno = prop1.Text;
                    tempPro.tres = prop4.Text;
                    tempPro.cuatro = resultado1.Text;
                    tempPro.cinco = resultado2.Text;

                    tablasuma1.Items.Add(tempPro);
                    Proposisiciones tempPro2 = new Proposisiciones();
                    tempPro2.dos = "v";
                    tempPro2.uno = "v";
                    tempPro2.tres = "v";
                    tempPro2.cuatro = "v";
                    tempPro2.cinco = "v";
                    tablasuma1.Items.Add(tempPro2);
                    Proposisiciones tempPro3 = new Proposisiciones();
                    tempPro3.dos = "f";
                    tempPro3.uno = "f";
                    tempPro3.tres = "f";
                    tempPro3.cuatro = "f";
                    tempPro3.cinco = "f";
                    tablasuma1.Items.Add(tempPro3);
                    Proposisiciones tempPro4 = new Proposisiciones();
                    tempPro4.dos = "v";
                    tempPro4.uno = "v";
                    tempPro4.tres = "f";
                    tempPro4.cuatro = "v";
                    tempPro4.cinco = "f";
                    tablasuma1.Items.Add(tempPro4);
                    Proposisiciones tempPro5 = new Proposisiciones();
                    tempPro5.dos = "f";
                    tempPro5.uno = "f";
                    tempPro5.tres = "v";
                    tempPro5.cuatro = "f";
                    tempPro5.cinco = "f";
                    tablasuma1.Items.Add(tempPro5);
                    Proposisiciones tempPro6 = new Proposisiciones();
                    tempPro6.dos = "v";
                    tempPro6.uno = "f";
                    tempPro6.tres = "v";
                    tempPro6.cuatro = "v";
                    tempPro6.cinco = "f";
                    tablasuma1.Items.Add(tempPro6);
                    Proposisiciones tempPro7 = new Proposisiciones();
                    tempPro7.dos = "f";
                    tempPro7.uno = "v";
                    tempPro7.tres = "f";
                    tempPro7.cuatro = "v";
                    tempPro7.cinco = "f";
                    tablasuma1.Items.Add(tempPro7);
                    Proposisiciones tempPro8 = new Proposisiciones();
                    tempPro8.dos = "v";
                    tempPro8.uno = "f";
                    tempPro8.tres = "f";
                    tempPro8.cuatro = "v";
                    tempPro8.cinco = "f";
                    tablasuma1.Items.Add(tempPro8);
                    Proposisiciones tempPro9 = new Proposisiciones();
                    tempPro9.dos = "f";
                    tempPro9.uno = "v";
                    tempPro9.tres = "v";
                    tempPro9.cuatro = "v";
                    tempPro9.cinco = "f";
                    tablasuma1.Items.Add(tempPro9);
                    resoluciondeteorema.Text = resoluciondeteorema.Text + "el teorema es falso";
                }
            }
            //4
            
              
            
            if (resultado1.Text == "s+p" || resultado1.Text == "s+q" || resultado1.Text == "s+r" || resultado1.Text == "p+s" || resultado1.Text == "q+s" || resultado1.Text == "r+s")
            {
                if (resultado2.Text == "s*q" || resultado2.Text == "s*r" || resultado2.Text == "s*p" || resultado2.Text == "q*s" || resultado2.Text == "r*s" || resultado2.Text == "p*s")
                {
                    tablasuma1.Visibility = Visibility.Visible;
                    tablasuma1.Items.Clear();
                    Proposisiciones tempPro = new Proposisiciones();
                    tempPro.dos = prop2.Text;
                    tempPro.uno = prop1.Text;
                    tempPro.tres = prop4.Text;
                    tempPro.cuatro = resultado1.Text;
                    tempPro.cinco = resultado2.Text;

                    tablasuma1.Items.Add(tempPro);
                    Proposisiciones tempPro2 = new Proposisiciones();
                    tempPro2.dos = "v";
                    tempPro2.uno = "v";
                    tempPro2.tres = "v";
                    tempPro2.cuatro = "v";
                    tempPro2.cinco = "v";
                    tablasuma1.Items.Add(tempPro2);
                    Proposisiciones tempPro3 = new Proposisiciones();
                    tempPro3.dos = "f";
                    tempPro3.uno = "f";
                    tempPro3.tres = "f";
                    tempPro3.cuatro = "f";
                    tempPro3.cinco = "f";
                    tablasuma1.Items.Add(tempPro3);
                    Proposisiciones tempPro4 = new Proposisiciones();
                    tempPro4.dos = "v";
                    tempPro4.uno = "v";
                    tempPro4.tres = "f";
                    tempPro4.cuatro = "v";
                    tempPro4.cinco = "f";
                    tablasuma1.Items.Add(tempPro4);
                    Proposisiciones tempPro5 = new Proposisiciones();
                    tempPro5.dos = "f";
                    tempPro5.uno = "f";
                    tempPro5.tres = "v";
                    tempPro5.cuatro = "f";
                    tempPro5.cinco = "f";
                    tablasuma1.Items.Add(tempPro5);
                    Proposisiciones tempPro6 = new Proposisiciones();
                    tempPro6.dos = "v";
                    tempPro6.uno = "f";
                    tempPro6.tres = "v";
                    tempPro6.cuatro = "v";
                    tempPro6.cinco = "f";
                    tablasuma1.Items.Add(tempPro6);
                    Proposisiciones tempPro7 = new Proposisiciones();
                    tempPro7.dos = "f";
                    tempPro7.uno = "v";
                    tempPro7.tres = "f";
                    tempPro7.cuatro = "v";
                    tempPro7.cinco = "f";
                    tablasuma1.Items.Add(tempPro7);
                    Proposisiciones tempPro8 = new Proposisiciones();
                    tempPro8.dos = "v";
                    tempPro8.uno = "f";
                    tempPro8.tres = "f";
                    tempPro8.cuatro = "v";
                    tempPro8.cinco = "f";
                    tablasuma1.Items.Add(tempPro8);
                    Proposisiciones tempPro9 = new Proposisiciones();
                    tempPro9.dos = "f";
                    tempPro9.uno = "v";
                    tempPro9.tres = "v";
                    tempPro9.cuatro = "v";
                    tempPro9.cinco = "f";
                    tablasuma1.Items.Add(tempPro9);
                    resoluciondeteorema.Text = resoluciondeteorema.Text + "el teorema es falso";
                }
            }
            //5
            


            //multiplicacion y suma con 3 proposiciones
         


            if (resultado1.Text == "p*q"|| resultado1.Text == "p*r" || resultado1.Text == "p*s" || resultado1.Text == "q*p" || resultado1.Text == "r*p" || resultado1.Text == "s*p")
            {
                if (resultado2.Text == "p+r" || resultado2.Text == "p+s" || resultado2.Text == "p+q" || resultado2.Text == "r+p" || resultado2.Text == "s+p" || resultado2.Text == "q+p")
                {
                    tablasuma1.Visibility = Visibility.Visible;
                    tablasuma1.Items.Clear();
                    Proposisiciones tempPro = new Proposisiciones();
                    tempPro.dos = prop2.Text;
                    tempPro.uno = prop1.Text;
                    tempPro.tres = prop4.Text;
                    tempPro.cuatro = resultado1.Text;
                    tempPro.cinco = resultado2.Text;

                    tablasuma1.Items.Add(tempPro);
                    Proposisiciones tempPro2 = new Proposisiciones();
                    tempPro2.dos = "v";
                    tempPro2.uno = "v";
                    tempPro2.tres = "v";
                    tempPro2.cuatro = "v";
                    tempPro2.cinco = "v";
                    tablasuma1.Items.Add(tempPro2);
                    Proposisiciones tempPro3 = new Proposisiciones();
                    tempPro3.dos = "f";
                    tempPro3.uno = "f";
                    tempPro3.tres = "f";
                    tempPro3.cuatro = "f";
                    tempPro3.cinco = "f";
                    tablasuma1.Items.Add(tempPro3);
                    Proposisiciones tempPro4 = new Proposisiciones();
                    tempPro4.dos = "v";
                    tempPro4.uno = "v";
                    tempPro4.tres = "f";
                    tempPro4.cuatro = "v";
                    tempPro4.cinco = "v";
                    tablasuma1.Items.Add(tempPro4);
                    Proposisiciones tempPro5 = new Proposisiciones();
                    tempPro5.dos = "f";
                    tempPro5.uno = "f";
                    tempPro5.tres = "v";
                    tempPro5.cuatro = "f";
                    tempPro5.cinco = "v";
                    tablasuma1.Items.Add(tempPro5);
                    Proposisiciones tempPro6 = new Proposisiciones();
                    tempPro6.dos = "v";
                    tempPro6.uno = "f";
                    tempPro6.tres = "v";
                    tempPro6.cuatro = "f";
                    tempPro6.cinco = "v";
                    tablasuma1.Items.Add(tempPro6);
                    Proposisiciones tempPro7 = new Proposisiciones();
                    tempPro7.dos = "f";
                    tempPro7.uno = "v";
                    tempPro7.tres = "f";
                    tempPro7.cuatro = "f";
                    tempPro7.cinco = "f";
                    tablasuma1.Items.Add(tempPro7);
                    Proposisiciones tempPro8 = new Proposisiciones();
                    tempPro8.dos = "v";
                    tempPro8.uno = "f";
                    tempPro8.tres = "f";
                    tempPro8.cuatro = "f";
                    tempPro8.cinco = "v";
                    tablasuma1.Items.Add(tempPro8);
                    Proposisiciones tempPro9 = new Proposisiciones();
                    tempPro9.dos = "f";
                    tempPro9.uno = "v";
                    tempPro9.tres = "v";
                    tempPro9.cuatro = "f";
                    tempPro9.cinco = "v";
                    tablasuma1.Items.Add(tempPro9);
                    resoluciondeteorema.Text = resoluciondeteorema.Text + "el teorema es falso";
                }
            }
            //6
            
            if (resultado1.Text == "q*p" || resultado1.Text == "q*r" || resultado1.Text == "q*s" || resultado1.Text == "p*q" || resultado1.Text == "r*q" || resultado1.Text == "s*q")
            {
            if (resultado2.Text == "q+r" || resultado2.Text == "q+s" || resultado2.Text == "q+p" || resultado2.Text == "r+q" || resultado2.Text == "s+q" || resultado2.Text == "p+q")
                {



                        tablasuma1.Visibility = Visibility.Visible;
                        tablasuma1.Items.Clear();
                        Proposisiciones tempPro = new Proposisiciones();
                        tempPro.dos = prop2.Text;
                        tempPro.uno = prop1.Text;
                        tempPro.tres = prop4.Text;
                        tempPro.cuatro = resultado1.Text;
                        tempPro.cinco = resultado2.Text;

                        tablasuma1.Items.Add(tempPro);
                        Proposisiciones tempPro2 = new Proposisiciones();
                        tempPro2.dos = "v";
                        tempPro2.uno = "v";
                        tempPro2.tres = "v";
                        tempPro2.cuatro = "v";
                        tempPro2.cinco = "v";
                        tablasuma1.Items.Add(tempPro2);
                        Proposisiciones tempPro3 = new Proposisiciones();
                        tempPro3.dos = "f";
                        tempPro3.uno = "f";
                        tempPro3.tres = "f";
                        tempPro3.cuatro = "f";
                        tempPro3.cinco = "f";
                        tablasuma1.Items.Add(tempPro3);
                        Proposisiciones tempPro4 = new Proposisiciones();
                        tempPro4.dos = "v";
                        tempPro4.uno = "v";
                        tempPro4.tres = "f";
                        tempPro4.cuatro = "v";
                        tempPro4.cinco = "v";
                        tablasuma1.Items.Add(tempPro4);
                        Proposisiciones tempPro5 = new Proposisiciones();
                        tempPro5.dos = "f";
                        tempPro5.uno = "f";
                        tempPro5.tres = "v";
                        tempPro5.cuatro = "f";
                        tempPro5.cinco = "v";
                        tablasuma1.Items.Add(tempPro5);
                        Proposisiciones tempPro6 = new Proposisiciones();
                        tempPro6.dos = "v";
                        tempPro6.uno = "f";
                        tempPro6.tres = "v";
                        tempPro6.cuatro = "f";
                        tempPro6.cinco = "v";
                        tablasuma1.Items.Add(tempPro6);
                        Proposisiciones tempPro7 = new Proposisiciones();
                        tempPro7.dos = "f";
                        tempPro7.uno = "v";
                        tempPro7.tres = "f";
                        tempPro7.cuatro = "f";
                        tempPro7.cinco = "f";
                        tablasuma1.Items.Add(tempPro7);
                        Proposisiciones tempPro8 = new Proposisiciones();
                        tempPro8.dos = "v";
                        tempPro8.uno = "f";
                        tempPro8.tres = "f";
                        tempPro8.cuatro = "f";
                        tempPro8.cinco = "v";
                        tablasuma1.Items.Add(tempPro8);
                        Proposisiciones tempPro9 = new Proposisiciones();
                        tempPro9.dos = "f";
                        tempPro9.uno = "v";
                        tempPro9.tres = "v";
                        tempPro9.cuatro = "f";
                        tempPro9.cinco = "v";
                        tablasuma1.Items.Add(tempPro9);
                        resoluciondeteorema.Text = resoluciondeteorema.Text + "el teorema es falso";
                    
                }
            }
            //7
           
            if (resultado1.Text == "r*p" || resultado1.Text == "r*q" || resultado1.Text == "r*s" || resultado1.Text == "p*r" || resultado1.Text == "q*r" || resultado1.Text == "s*r")
            {
                if (resultado2.Text == "r+q" || resultado2.Text == "r+s" || resultado2.Text == "r+p" || resultado2.Text == "q+r" || resultado2.Text == "s+r" || resultado2.Text == "p+r")
                {


                    tablasuma1.Visibility = Visibility.Visible;
                    tablasuma1.Items.Clear();
                    Proposisiciones tempPro = new Proposisiciones();
                    tempPro.dos = prop2.Text;
                    tempPro.uno = prop1.Text;
                    tempPro.tres = prop4.Text;
                    tempPro.cuatro = resultado1.Text;
                    tempPro.cinco = resultado2.Text;

                    tablasuma1.Items.Add(tempPro);
                    Proposisiciones tempPro2 = new Proposisiciones();
                    tempPro2.dos = "v";
                    tempPro2.uno = "v";
                    tempPro2.tres = "v";
                    tempPro2.cuatro = "v";
                    tempPro2.cinco = "v";
                    tablasuma1.Items.Add(tempPro2);
                    Proposisiciones tempPro3 = new Proposisiciones();
                    tempPro3.dos = "f";
                    tempPro3.uno = "f";
                    tempPro3.tres = "f";
                    tempPro3.cuatro = "f";
                    tempPro3.cinco = "f";
                    tablasuma1.Items.Add(tempPro3);
                    Proposisiciones tempPro4 = new Proposisiciones();
                    tempPro4.dos = "v";
                    tempPro4.uno = "v";
                    tempPro4.tres = "f";
                    tempPro4.cuatro = "v";
                    tempPro4.cinco = "v";
                    tablasuma1.Items.Add(tempPro4);
                    Proposisiciones tempPro5 = new Proposisiciones();
                    tempPro5.dos = "f";
                    tempPro5.uno = "f";
                    tempPro5.tres = "v";
                    tempPro5.cuatro = "f";
                    tempPro5.cinco = "v";
                    tablasuma1.Items.Add(tempPro5);
                    Proposisiciones tempPro6 = new Proposisiciones();
                    tempPro6.dos = "v";
                    tempPro6.uno = "f";
                    tempPro6.tres = "v";
                    tempPro6.cuatro = "f";
                    tempPro6.cinco = "v";
                    tablasuma1.Items.Add(tempPro6);
                    Proposisiciones tempPro7 = new Proposisiciones();
                    tempPro7.dos = "f";
                    tempPro7.uno = "v";
                    tempPro7.tres = "f";
                    tempPro7.cuatro = "f";
                    tempPro7.cinco = "f";
                    tablasuma1.Items.Add(tempPro7);
                    Proposisiciones tempPro8 = new Proposisiciones();
                    tempPro8.dos = "v";
                    tempPro8.uno = "f";
                    tempPro8.tres = "f";
                    tempPro8.cuatro = "f";
                    tempPro8.cinco = "f";
                    tablasuma1.Items.Add(tempPro8);
                    Proposisiciones tempPro9 = new Proposisiciones();
                    tempPro9.dos = "f";
                    tempPro9.uno = "v";
                    tempPro9.tres = "v";
                    tempPro9.cuatro = "f";
                    tempPro9.cinco = "v";
                    tablasuma1.Items.Add(tempPro9);
                    resoluciondeteorema.Text = resoluciondeteorema.Text + "el teorema es falso";
                }
            }//8
           
            if (resultado1.Text == "s*p" || resultado1.Text == "s*q" || resultado1.Text == "s*r" || resultado1.Text == "p*s" || resultado1.Text == "q*s" || resultado1.Text == "r*s")
            {
                if (resultado2.Text == "s+q" || resultado2.Text == "s+r" || resultado2.Text == "s+p" || resultado2.Text == "q+s" || resultado2.Text == "r+s" || resultado2.Text == "p+s")
                {


                    tablasuma1.Visibility = Visibility.Visible;
                    tablasuma1.Items.Clear();
                    Proposisiciones tempPro = new Proposisiciones();
                    tempPro.dos = prop2.Text;
                    tempPro.uno = prop1.Text;
                    tempPro.tres = prop4.Text;
                    tempPro.cuatro = resultado1.Text;
                    tempPro.cinco = resultado2.Text;

                    tablasuma1.Items.Add(tempPro);
                    Proposisiciones tempPro2 = new Proposisiciones();
                    tempPro2.dos = "v";
                    tempPro2.uno = "v";
                    tempPro2.tres = "v";
                    tempPro2.cuatro = "v";
                    tempPro2.cinco = "v";
                    tablasuma1.Items.Add(tempPro2);
                    Proposisiciones tempPro3 = new Proposisiciones();
                    tempPro3.dos = "f";
                    tempPro3.uno = "f";
                    tempPro3.tres = "f";
                    tempPro3.cuatro = "f";
                    tempPro3.cinco = "f";
                    tablasuma1.Items.Add(tempPro3);
                    Proposisiciones tempPro4 = new Proposisiciones();
                    tempPro4.dos = "v";
                    tempPro4.uno = "v";
                    tempPro4.tres = "f";
                    tempPro4.cuatro = "v";
                    tempPro4.cinco = "v";
                    tablasuma1.Items.Add(tempPro4);
                    Proposisiciones tempPro5 = new Proposisiciones();
                    tempPro5.dos = "f";
                    tempPro5.uno = "f";
                    tempPro5.tres = "v";
                    tempPro5.cuatro = "f";
                    tempPro5.cinco = "v";
                    tablasuma1.Items.Add(tempPro5);
                    Proposisiciones tempPro6 = new Proposisiciones();
                    tempPro6.dos = "v";
                    tempPro6.uno = "f";
                    tempPro6.tres = "v";
                    tempPro6.cuatro = "f";
                    tempPro6.cinco = "v";
                    tablasuma1.Items.Add(tempPro6);
                    Proposisiciones tempPro7 = new Proposisiciones();
                    tempPro7.dos = "f";
                    tempPro7.uno = "v";
                    tempPro7.tres = "f";
                    tempPro7.cuatro = "f";
                    tempPro7.cinco = "f";
                    tablasuma1.Items.Add(tempPro7);
                    Proposisiciones tempPro8 = new Proposisiciones();
                    tempPro8.dos = "v";
                    tempPro8.uno = "f";
                    tempPro8.tres = "f";
                    tempPro8.cuatro = "f";
                    tempPro8.cinco = "f";
                    tablasuma1.Items.Add(tempPro8);
                    Proposisiciones tempPro9 = new Proposisiciones();
                    tempPro9.dos = "f";
                    tempPro9.uno = "v";
                    tempPro9.tres = "v";
                    tempPro9.cuatro = "f";
                    tempPro9.cinco = "v";
                    tablasuma1.Items.Add(tempPro9);
                    resoluciondeteorema.Text = resoluciondeteorema.Text + "el teorema es falso";
                }
            }
            //9
            



            //sumas con la primera y la ultima proposicion igual         COLOCAR FALSOS Y VERDADEROS CORRECTAMENTE 
            //10
            if (resultado1.Text == "-p+p" || resultado1.Text == "-p+q" || resultado1.Text == "-p+r" || resultado1.Text == "-p+s" || resultado1.Text == "p+-p" || resultado1.Text == "q+-p" || resultado1.Text == "r+-p" || resultado1.Text == "s+-p" ||
                resultado1.Text == "-q+p" || resultado1.Text == "-q+q" || resultado1.Text == "-q+r" || resultado1.Text == "-q+s" || resultado1.Text == "p+-q" || resultado1.Text == "q+-q" || resultado1.Text == "r+-q" || resultado1.Text == "s+-q" ||
                resultado1.Text == "-r+p" || resultado1.Text == "-r+q" || resultado1.Text == "-r+r" || resultado1.Text == "-r+s" || resultado1.Text == "p+-r" || resultado1.Text == "q+-r" || resultado1.Text == "r+-r" || resultado1.Text == "s+-r" ||
                resultado1.Text == "-s+p" || resultado1.Text == "-s+q" || resultado1.Text == "-s+r" || resultado1.Text == "-s+s" || resultado1.Text == "p+-s" || resultado1.Text == "q+-s" || resultado1.Text == "r+-s" || resultado1.Text == "s+-s" ||
                resultado1.Text == "-p*p" || resultado1.Text == "-p*q" || resultado1.Text == "-p*r" || resultado1.Text == "-p*s" || resultado1.Text == "p*-p" || resultado1.Text == "q*-p" || resultado1.Text == "r*-p" || resultado1.Text == "s*-p" ||
                resultado1.Text == "-q*p" || resultado1.Text == "-q*q" || resultado1.Text == "-q*r" || resultado1.Text == "-q*s" || resultado1.Text == "p*-q" || resultado1.Text == "q*-q" || resultado1.Text == "r*-q" || resultado1.Text == "s*-q" ||
                resultado1.Text == "-r*p" || resultado1.Text == "-r*q" || resultado1.Text == "-r*r" || resultado1.Text == "-r*s" || resultado1.Text == "p*-r" || resultado1.Text == "q*-r" || resultado1.Text == "r*-r" || resultado1.Text == "s*-r" ||
                resultado1.Text == "-s*p" || resultado1.Text == "-s*q" || resultado1.Text == "-s*r" || resultado1.Text == "-s*s" || resultado1.Text == "p*-s" || resultado1.Text == "q*-s" || resultado1.Text == "r*-s" || resultado1.Text == "s*-s" 
                )
            {
                if (resultado2.Text == "-p+p" || resultado2.Text == "-p+q" || resultado2.Text == "-p+r" || resultado2.Text == "-p+s" || resultado2.Text == "p+-p" || resultado2.Text == "q+-p" || resultado2.Text == "r+-p" || resultado2.Text == "s+-p" ||
                    resultado2.Text == "-q+p" || resultado2.Text == "-q+q" || resultado2.Text == "-q+r" || resultado2.Text == "-q+s" || resultado2.Text == "p+-q" || resultado2.Text == "q+-q" || resultado2.Text == "r+-q" || resultado2.Text == "s+-q" ||
                    resultado2.Text == "-r+p" || resultado2.Text == "-r+q" || resultado2.Text == "-r+r" || resultado2.Text == "-r+s" || resultado2.Text == "p+-r" || resultado2.Text == "q+-r" || resultado2.Text == "r+-r" || resultado2.Text == "s+-r" ||
                    resultado2.Text == "-s+p" || resultado2.Text == "-s+q" || resultado2.Text == "-s+r" || resultado2.Text == "-s+s" || resultado2.Text == "p+-s" || resultado2.Text == "q+-s" || resultado2.Text == "r+-s" || resultado2.Text == "s+-s" ||
                    resultado2.Text == "-p*p" || resultado2.Text == "-p*q" || resultado2.Text == "-p*r" || resultado2.Text == "-p*s" || resultado2.Text == "p*-p" || resultado2.Text == "q*-p" || resultado2.Text == "r*-p" || resultado2.Text == "s*-p" ||
                    resultado2.Text == "-q*p" || resultado2.Text == "-q*q" || resultado2.Text == "-q*r" || resultado2.Text == "-q*s" || resultado2.Text == "p*-q" || resultado2.Text == "q*-q" || resultado2.Text == "r*-q" || resultado2.Text == "s*-q" ||
                    resultado2.Text == "-r*p" || resultado2.Text == "-r*q" || resultado2.Text == "-r*r" || resultado2.Text == "-r*s" || resultado2.Text == "p*-r" || resultado2.Text == "q*-r" || resultado2.Text == "r*-r" || resultado2.Text == "s*-r" ||
                    resultado2.Text == "-s*p" || resultado2.Text == "-s*q" || resultado2.Text == "-s*r" || resultado2.Text == "-s*s" || resultado2.Text == "p*-s" || resultado2.Text == "q*-s" || resultado2.Text == "r*-s" || resultado2.Text == "s*-s" ||
                    resultado2.Text == "p+q"  || resultado2.Text == "p+r"  || resultado2.Text == "p+s" || resultado2.Text == "p+p"   || resultado2.Text == "q+r"  || resultado2.Text == "q+s"  || resultado2.Text == "q+p"  || resultado2.Text == "q+q" ||
                    resultado2.Text == "r+q"  || resultado2.Text == "r+r"  || resultado2.Text == "r+s" || resultado2.Text == "r+p"   || resultado2.Text == "s+p"  || resultado2.Text == "s+q"  || resultado2.Text == "s+r" || resultado2.Text == "s+s"
                )
                {

                   

                    if (resultado1.Text == "-p+p" || resultado1.Text == "-p+q" || resultado1.Text == "-p+r" || resultado1.Text == "-p+s" || resultado1.Text == "-q+p" || resultado1.Text == "-q+q" || resultado1.Text == "-q+r" || resultado1.Text == "-q+s" ||
                       resultado1.Text == "-r+p" || resultado1.Text == "-r+q" || resultado1.Text == "-r+r" || resultado1.Text == "-r+s" || resultado1.Text == "-s+p" || resultado1.Text == "-s+q" || resultado1.Text == "-s+r" || resultado1.Text == "-s+s" || 
                       resultado1.Text == "p+-p" || resultado1.Text == "p+-q" || resultado1.Text == "p+-r" || resultado1.Text == "p+-s" || resultado1.Text == "q+-p" || resultado1.Text == "q+-q" || resultado1.Text == "q+-r" || resultado1.Text == "q+-s" ||
                       resultado1.Text == "r+-p" || resultado1.Text == "r-+q" || resultado1.Text == "r+-r" || resultado1.Text == "r+-s" || resultado1.Text == "s+-p" || resultado1.Text == "s+-q" || resultado1.Text == "s+-r" || resultado1.Text == "s+-s")
                    {
                        if (resultado2.Text == "p+q" || resultado2.Text == "p+r" || resultado2.Text == "p+s" || resultado2.Text == "p+p" || resultado2.Text == "q+r" || resultado2.Text == "q+s" || resultado2.Text == "q+p" || resultado2.Text == "q+q" ||
                           resultado2.Text == "r+q" || resultado2.Text == "r+r" || resultado2.Text == "r+s" || resultado2.Text == "r+p" || resultado2.Text == "s+p" || resultado2.Text == "s+q" || resultado2.Text == "s+r" || resultado2.Text == "s+s"
                           )

                        {
                            tablasuma1.Visibility = Visibility.Visible;
                            tablasuma1.Items.Clear();
                            tablasuma2.Visibility = Visibility.Hidden;
                            Proposisiciones tempPro = new Proposisiciones();

                            if (prop1.SelectedIndex == 0)
                            {
                                tempPro.uno = "p";
                            }
                            if (prop1.SelectedIndex == 1)
                            {
                                tempPro.uno = "q";
                            }
                            if (prop1.SelectedIndex == 2)
                            {
                                tempPro.uno = "r";
                            }
                            if (prop1.SelectedIndex == 3)
                            {
                                tempPro.uno = "s";
                            }
                            if (prop1.SelectedIndex == 4)
                            {
                                tempPro.uno = "p";
                            }
                            if (prop1.SelectedIndex == 5)
                            {
                                tempPro.uno = "q";
                            }
                            if (prop1.SelectedIndex == 6)
                            {
                                tempPro.uno = "r";
                            }
                            if (prop1.SelectedIndex == 7)
                            {
                                tempPro.uno = "s";
                            }


                            if (prop2.SelectedIndex == 0)
                            {
                                tempPro.dos = "p";
                            }
                            if (prop2.SelectedIndex == 1)
                            {
                                tempPro.dos = "q";
                            }
                            if (prop2.SelectedIndex == 2)
                            {
                                tempPro.dos = "r";
                            }
                            if (prop2.SelectedIndex == 3)
                            {
                                tempPro.dos = "s";
                            }

                            if (prop2.SelectedIndex == 4)
                            {
                                tempPro.dos = "p";
                            }
                            if (prop2.SelectedIndex == 5)
                            {
                                tempPro.dos = "q";
                            }
                            if (prop2.SelectedIndex == 6)
                            {
                                tempPro.dos = "r";
                            }
                            if (prop2.SelectedIndex == 7)
                            {
                                tempPro.dos = "s";
                            }



                            // tempPro.tres= prop3.Text;

                            if (prop1.SelectedIndex == 4 || prop2.SelectedIndex == 4 || prop3.SelectedIndex == 4 || prop4.SelectedIndex == 4)
                            {
                                tempPro.cuatro = "-p";
                            }
                            if (prop1.SelectedIndex == 5 || prop2.SelectedIndex == 5 || prop3.SelectedIndex == 5 || prop4.SelectedIndex == 5)
                            {
                                tempPro.cuatro = "-q";
                            }
                            if (prop1.SelectedIndex == 6 || prop2.SelectedIndex == 6 || prop3.SelectedIndex == 6 || prop4.SelectedIndex == 6)
                            {
                                tempPro.cuatro = "-r";
                            }
                            if (prop1.SelectedIndex == 7 || prop2.SelectedIndex == 7 || prop3.SelectedIndex == 7 || prop4.SelectedIndex == 7)
                            {
                                tempPro.cuatro = "-s";
                            }



                            if (prop3.SelectedIndex == 0 || prop4.SelectedIndex == 0)
                            {
                                tempPro.tres = "p";
                            }
                            if (prop3.SelectedIndex == 1 || prop4.SelectedIndex == 1)
                            {
                                tempPro.tres = "q";
                            }
                            if (prop3.SelectedIndex == 2 || prop4.SelectedIndex == 2)
                            {
                                tempPro.tres = "r";
                            }
                            if (prop3.SelectedIndex == 3 || prop4.SelectedIndex == 3)
                            {
                                tempPro.tres = "s";
                            }




                            //tempPro.cuatro = prop4.Text;
                            tempPro.cinco = resultado1.Text;
                            tempPro.seis = resultado2.Text;
                            tablasuma1.Items.Add(tempPro);
                            //b
                            if (prop1.SelectedIndex == 4 && prop3.SelectedIndex == 0 || prop1.SelectedIndex == 5 && prop3.SelectedIndex == 1 || prop1.SelectedIndex == 6 && prop3.SelectedIndex == 2 || prop1.SelectedIndex == 7 && prop3.SelectedIndex == 3 )
                            {
                                Proposisiciones tempPro2 = new Proposisiciones();
                                tempPro2.uno = "v";
                                tempPro2.dos = "v";
                                tempPro2.tres = "v";
                                tempPro2.cuatro = "f";
                                tempPro2.cinco = "v";
                                tempPro2.seis = "v";
                                tablasuma1.Items.Add(tempPro2);
                                Proposisiciones tempPro3 = new Proposisiciones();
                                tempPro3.uno = "f";
                                tempPro3.dos = "f";
                                tempPro3.tres = "f";
                                tempPro3.cuatro = "v";
                                tempPro3.cinco = "v";
                                tempPro3.seis = "f";
                                tablasuma1.Items.Add(tempPro3);
                                Proposisiciones tempPro4 = new Proposisiciones();
                                tempPro4.uno = "v";
                                tempPro4.dos = "v";
                                tempPro4.tres = "f";
                                tempPro4.cuatro = "f";
                                tempPro4.cinco = "f";
                                tempPro4.seis = "v";
                             
                                tablasuma1.Items.Add(tempPro4);
                                Proposisiciones tempPro5 = new Proposisiciones();
                                tempPro5.uno = "f";
                                tempPro5.dos = "f";
                                tempPro5.tres = "v";
                                tempPro5.cuatro = "v";
                                tempPro5.cinco = "v";
                                tempPro5.seis = "v";
                              
                                tablasuma1.Items.Add(tempPro5);
                                Proposisiciones tempPro6 = new Proposisiciones();
                                tempPro6.uno = "v";
                                tempPro6.dos = "f";
                                tempPro6.tres = "v";
                                tempPro6.cuatro = "f";
                                tempPro6.cinco = "f";
                                tempPro6.seis = "v";
                                tablasuma1.Items.Add(tempPro6);
                                Proposisiciones tempPro7 = new Proposisiciones();
                                tempPro7.uno = "f";
                                tempPro7.dos = "v";
                                tempPro7.tres = "f";
                                tempPro7.cuatro = "v";
                                tempPro7.cinco = "v";
                                tempPro7.seis = "f";
                               tablasuma1.Items.Add(tempPro7);
                                Proposisiciones tempPro8 = new Proposisiciones();
                                tempPro8.uno = "v";
                                tempPro8.dos = "f";
                                tempPro8.tres = "f";
                                tempPro8.cuatro = "f";
                                tempPro8.cinco = "f";
                                tempPro8.seis = "v";
                                tablasuma1.Items.Add(tempPro8);
                                Proposisiciones tempPro9 = new Proposisiciones();
                                tempPro9.uno = "f";
                                tempPro9.dos = "v";
                                tempPro9.tres = "v";
                                tempPro9.cuatro = "v";
                                tempPro9.cinco = "f";
                                tempPro9.seis = "v";
                                tablasuma1.Items.Add(tempPro9);
                                resoluciondeteorema.Text = resoluciondeteorema.Text + "el teorema es falso";
                            }

                            //a
                            if (prop1.SelectedIndex == 4 && prop4.SelectedIndex == 0 || prop1.SelectedIndex == 5 && prop4.SelectedIndex == 1 || prop1.SelectedIndex == 6 && prop4.SelectedIndex == 2 || prop1.SelectedIndex == 7 && prop4.SelectedIndex == 3)
                            {

                                {
                                    Proposisiciones tempPro2 = new Proposisiciones();
                                    tempPro2.uno = "v";
                                    tempPro2.dos = "v";
                                    tempPro2.tres = "v";
                                    tempPro2.cuatro = "f";
                                    tempPro2.cinco = "v";
                                    tempPro2.seis = "v";
                                    tablasuma1.Items.Add(tempPro2);
                                    Proposisiciones tempPro3 = new Proposisiciones();
                                    tempPro3.uno = "f";
                                    tempPro3.dos = "f";
                                    tempPro3.tres = "f";
                                    tempPro3.cuatro = "v";
                                    tempPro3.cinco = "v";
                                    tempPro3.seis = "f";
                                    tablasuma1.Items.Add(tempPro3);
                                    Proposisiciones tempPro4 = new Proposisiciones();
                                    tempPro4.uno = "v";
                                    tempPro4.dos = "v";
                                    tempPro4.tres = "f";
                                    tempPro4.cuatro = "f";
                                    tempPro4.cinco = "f";
                                    tempPro4.seis = "v";
                                    tempPro4.siete = "v";
                                    tablasuma1.Items.Add(tempPro4);
                                    Proposisiciones tempPro5 = new Proposisiciones();
                                    tempPro5.uno = "f";
                                    tempPro5.dos = "f";
                                    tempPro5.tres = "v";
                                    tempPro5.cuatro = "v";
                                    tempPro5.cinco = "v";
                                    tempPro5.seis = "f";
                                  
                                    tablasuma1.Items.Add(tempPro5);
                                    Proposisiciones tempPro6 = new Proposisiciones();
                                    tempPro6.uno = "v";
                                    tempPro6.dos = "f";
                                    tempPro6.tres = "v";
                                    tempPro6.cuatro = "f";
                                    tempPro6.cinco = "f";
                                    tempPro6.seis = "v";
                                    tablasuma1.Items.Add(tempPro6);
                                    Proposisiciones tempPro7 = new Proposisiciones();
                                    tempPro7.uno = "f";
                                    tempPro7.dos = "v";
                                    tempPro7.tres = "f";
                                    tempPro7.cuatro = "v";
                                    tempPro7.cinco = "v";
                                    tempPro7.seis = "v";
                                    tablasuma1.Items.Add(tempPro7);
                                    Proposisiciones tempPro8 = new Proposisiciones();
                                    tempPro8.uno = "v";
                                    tempPro8.dos = "f";
                                    tempPro8.tres = "f";
                                    tempPro8.cuatro = "f";
                                    tempPro8.cinco = "f";
                                    tempPro8.seis = "v";
                                    tablasuma1.Items.Add(tempPro8);
                                    Proposisiciones tempPro9 = new Proposisiciones();
                                    tempPro9.uno = "f";
                                    tempPro9.dos = "v";
                                    tempPro9.tres = "v";
                                    tempPro9.cuatro = "v";
                                    tempPro9.cinco = "f";
                                    tempPro9.seis = "v";
                                    tablasuma1.Items.Add(tempPro9);
                                    resoluciondeteorema.Text = resoluciondeteorema.Text + "el teorema es falso";
                                }
                            }

                            //c
                            if (prop2.SelectedIndex == 4 && prop3.SelectedIndex == 0 || prop2.SelectedIndex == 5 && prop3.SelectedIndex == 1 || prop2.SelectedIndex == 6 && prop3.SelectedIndex == 2 || prop2.SelectedIndex == 7 && prop3.SelectedIndex == 3)
                            {
                                Proposisiciones tempPro2 = new Proposisiciones();
                                tempPro2.uno = "v";
                                tempPro2.dos = "v";
                                tempPro2.tres = "v";
                                tempPro2.cuatro = "f";
                                tempPro2.cinco = "v";
                                tempPro2.seis = "v";
                                tablasuma1.Items.Add(tempPro2);
                                Proposisiciones tempPro3 = new Proposisiciones();
                                tempPro3.uno = "f";
                                tempPro3.dos = "f";
                                tempPro3.tres = "f";
                                tempPro3.cuatro = "v";
                                tempPro3.cinco = "v";
                                tempPro3.seis = "f";
                                tablasuma1.Items.Add(tempPro3);
                                Proposisiciones tempPro4 = new Proposisiciones();
                                tempPro4.uno = "v";
                                tempPro4.dos = "v";
                                tempPro4.tres = "f";
                                tempPro4.cuatro = "f";
                                tempPro4.cinco = "f";
                                tempPro4.seis = "v";

                                tablasuma1.Items.Add(tempPro4);
                                Proposisiciones tempPro5 = new Proposisiciones();
                                tempPro5.uno = "f";
                                tempPro5.dos = "f";
                                tempPro5.tres = "v";
                                tempPro5.cuatro = "v";
                                tempPro5.cinco = "v";
                                tempPro5.seis = "f";

                                tablasuma1.Items.Add(tempPro5);
                                Proposisiciones tempPro6 = new Proposisiciones();
                                tempPro6.uno = "v";
                                tempPro6.dos = "f";
                                tempPro6.tres = "v";
                                tempPro6.cuatro = "v";
                                tempPro6.cinco = "v";
                                tempPro6.seis = "v";
                                tablasuma1.Items.Add(tempPro6);
                                Proposisiciones tempPro7 = new Proposisiciones();
                                tempPro7.uno = "f";
                                tempPro7.dos = "v";
                                tempPro7.tres = "f";
                                tempPro7.cuatro = "f";
                                tempPro7.cinco = "f";
                                tempPro7.seis = "v";
                                tablasuma1.Items.Add(tempPro7);
                                Proposisiciones tempPro8 = new Proposisiciones();
                                tempPro8.uno = "v";
                                tempPro8.dos = "f";
                                tempPro8.tres = "f";
                                tempPro8.cuatro = "v";
                                tempPro8.cinco = "v";
                                tempPro8.seis = "v";
                                tablasuma1.Items.Add(tempPro8);
                                Proposisiciones tempPro9 = new Proposisiciones();
                                tempPro9.uno = "f";
                                tempPro9.dos = "v";
                                tempPro9.tres = "v";
                                tempPro9.cuatro = "f";
                                tempPro9.cinco = "f";
                                tempPro9.seis = "v";
                                tablasuma1.Items.Add(tempPro9);
                                resoluciondeteorema.Text = resoluciondeteorema.Text + "el teorema es falso";
                            }

                            //d
                            if (prop2.SelectedIndex == 4 && prop4.SelectedIndex == 0 || prop2.SelectedIndex == 5 && prop4.SelectedIndex == 1 || prop2.SelectedIndex == 6 && prop4.SelectedIndex == 2 || prop2.SelectedIndex == 7 && prop4.SelectedIndex == 3)
                            {

                                
                                    Proposisiciones tempPro2 = new Proposisiciones();
                                    tempPro2.uno = "v";
                                    tempPro2.dos = "v";
                                    tempPro2.tres = "v";
                                    tempPro2.cuatro = "f";
                                    tempPro2.cinco = "v";
                                    tempPro2.seis = "v";
                                    tablasuma1.Items.Add(tempPro2);
                                    Proposisiciones tempPro3 = new Proposisiciones();
                                    tempPro3.uno = "f";
                                    tempPro3.dos = "f";
                                    tempPro3.tres = "f";
                                    tempPro3.cuatro = "v";
                                    tempPro3.cinco = "v";
                                    tempPro3.seis = "f";
                                    tablasuma1.Items.Add(tempPro3);
                                    Proposisiciones tempPro4 = new Proposisiciones();
                                    tempPro4.uno = "v";
                                    tempPro4.dos = "v";
                                    tempPro4.tres = "f";
                                    tempPro4.cuatro = "f";
                                    tempPro4.cinco = "f";
                                    tempPro4.seis = "v";
                                    tempPro4.siete = "v";
                                    tablasuma1.Items.Add(tempPro4);
                                    Proposisiciones tempPro5 = new Proposisiciones();
                                    tempPro5.uno = "f";
                                    tempPro5.dos = "f";
                                    tempPro5.tres = "v";
                                    tempPro5.cuatro = "v";
                                    tempPro5.cinco = "v";
                                    tempPro5.seis = "v";

                                    tablasuma1.Items.Add(tempPro5);
                                    Proposisiciones tempPro6 = new Proposisiciones();
                                    tempPro6.uno = "v";
                                    tempPro6.dos = "f";
                                    tempPro6.tres = "v";
                                    tempPro6.cuatro = "v";
                                    tempPro6.cinco = "v";
                                    tempPro6.seis = "v";
                                    tablasuma1.Items.Add(tempPro6);
                                    Proposisiciones tempPro7 = new Proposisiciones();
                                    tempPro7.uno = "f";
                                    tempPro7.dos = "v";
                                    tempPro7.tres = "f";
                                    tempPro7.cuatro = "f";
                                    tempPro7.cinco = "f";
                                    tempPro7.seis = "v";
                                    tablasuma1.Items.Add(tempPro7);
                                    Proposisiciones tempPro8 = new Proposisiciones();
                                    tempPro8.uno = "v";
                                    tempPro8.dos = "f";
                                    tempPro8.tres = "f";
                                    tempPro8.cuatro = "v";
                                    tempPro8.cinco = "v";
                                    tempPro8.seis = "f";
                                    tablasuma1.Items.Add(tempPro8);
                                    Proposisiciones tempPro9 = new Proposisiciones();
                                    tempPro9.uno = "f";
                                    tempPro9.dos = "v";
                                    tempPro9.tres = "v";
                                    tempPro9.cuatro = "f";
                                    tempPro9.cinco = "f";
                                    tempPro9.seis = "v";
                                    tablasuma1.Items.Add(tempPro9);
                                    resoluciondeteorema.Text = resoluciondeteorema.Text + "el teorema es falso";
                                
                            }


                           

                        }

                        if (resultado2.Text == "p+-p" || resultado2.Text == "p+-q" || resultado2.Text == "p+-r" || resultado2.Text == "p+-s" || resultado2.Text == "q+-p" || resultado2.Text == "q+-q" || resultado2.Text == "q+-r" || resultado2.Text == "q+-s" ||
                           resultado2.Text == "r+-p" || resultado2.Text == "r+-q" || resultado2.Text == "r+-r" || resultado2.Text == "r+-s" || resultado2.Text == "s+-p" || resultado2.Text == "s+-q" || resultado2.Text == "s+-r" || resultado2.Text == "s+-s" ||
                           resultado2.Text == "-p+p" || resultado2.Text == "-p+q" || resultado2.Text == "-p+r" || resultado2.Text == "-p+s" || resultado2.Text == "-q+p" || resultado2.Text == "-q+q" || resultado2.Text == "-q+r" || resultado2.Text == "-q+s" ||
                           resultado2.Text == "-r+p" || resultado2.Text == "-r+q" || resultado2.Text == "-r+r" || resultado2.Text == "-r+s" || resultado2.Text == "-s+p" || resultado2.Text == "-s+q" || resultado2.Text == "-s+r" || resultado2.Text == "-s+s" )

                        {
                            tablasuma1.Visibility = Visibility.Visible;
                            tablasuma1.Items.Clear();
                            tablasuma2.Visibility = Visibility.Hidden;
                            Proposisiciones tempPro = new Proposisiciones();

                            if (prop1.SelectedIndex == 0)
                            {
                                tempPro.uno = "p";
                            }
                            if (prop1.SelectedIndex == 1)
                            {
                                tempPro.uno = "q";
                            }
                            if (prop1.SelectedIndex == 2)
                            {
                                tempPro.uno = "r";
                            }
                            if (prop1.SelectedIndex == 3)
                            {
                                tempPro.uno = "s";
                            }
                            if (prop1.SelectedIndex == 4)
                            {
                                tempPro.uno = "p";
                            }
                            if (prop1.SelectedIndex == 5)
                            {
                                tempPro.uno = "q";
                            }
                            if (prop1.SelectedIndex == 6)
                            {
                                tempPro.uno = "r";
                            }
                            if (prop1.SelectedIndex == 7)
                            {
                                tempPro.uno = "s";
                            }


                            if (prop2.SelectedIndex == 0)
                            {
                                tempPro.dos = "p";
                            }
                            if (prop2.SelectedIndex == 1)
                            {
                                tempPro.dos = "q";
                            }
                            if (prop2.SelectedIndex == 2)
                            {
                                tempPro.dos = "r";
                            }
                            if (prop2.SelectedIndex == 3)
                            {
                                tempPro.dos = "s";
                            }

                            if (prop2.SelectedIndex == 4)
                            {
                                tempPro.dos = "p";
                            }
                            if (prop2.SelectedIndex == 5)
                            {
                                tempPro.dos = "q";
                            }
                            if (prop2.SelectedIndex == 6)
                            {
                                tempPro.dos = "r";
                            }
                            if (prop2.SelectedIndex == 7)
                            {
                                tempPro.dos = "s";
                            }



                            // tempPro.tres= prop3.Text;

                            if (prop1.SelectedIndex == 4 || prop2.SelectedIndex == 4 || prop3.SelectedIndex == 4 || prop4.SelectedIndex == 4)
                            {
                                tempPro.cuatro = "-p";
                            }
                            if (prop1.SelectedIndex == 5 || prop2.SelectedIndex == 5 || prop3.SelectedIndex == 5 || prop4.SelectedIndex == 5)
                            {
                                tempPro.cuatro = "-q";
                            }
                            if (prop1.SelectedIndex == 6 || prop2.SelectedIndex == 6 || prop3.SelectedIndex == 6 || prop4.SelectedIndex == 6)
                            {
                                tempPro.cuatro = "-r";
                            }
                            if (prop1.SelectedIndex == 7 || prop2.SelectedIndex == 7 || prop3.SelectedIndex == 7 || prop4.SelectedIndex == 7)
                            {
                                tempPro.cuatro = "-s";
                            }



                            if (prop3.SelectedIndex == 0 || prop4.SelectedIndex == 0)
                            {
                                tempPro.tres = "p";
                            }
                            if (prop3.SelectedIndex == 1 || prop4.SelectedIndex == 1)
                            {
                                tempPro.tres = "q";
                            }
                            if (prop3.SelectedIndex == 2 || prop4.SelectedIndex == 2)
                            {
                                tempPro.tres = "r";
                            }
                            if (prop3.SelectedIndex == 3 || prop4.SelectedIndex == 3)
                            {
                                tempPro.tres = "s";
                            }




                            //tempPro.cuatro = prop4.Text;
                            tempPro.cinco = resultado1.Text;
                            tempPro.seis = resultado2.Text;
                            tablasuma1.Items.Add(tempPro);
                            //paso 2 



                            //a
                            if (prop1.SelectedIndex == 4 && prop4.SelectedIndex == 4 || prop1.SelectedIndex == 5 && prop4.SelectedIndex == 5 || prop1.SelectedIndex == 6 && prop4.SelectedIndex == 6 || prop1.SelectedIndex == 7 && prop4.SelectedIndex == 7 ||
                                prop1.SelectedIndex == 4 && prop3.SelectedIndex == 4 || prop1.SelectedIndex == 5 && prop3.SelectedIndex == 5 || prop1.SelectedIndex == 6 && prop3.SelectedIndex == 6 || prop1.SelectedIndex == 7 && prop3.SelectedIndex == 7)
                            {


                                Proposisiciones tempPro2 = new Proposisiciones();
                                tempPro2.uno = "v";
                                tempPro2.dos = "v";
                                tempPro2.tres = "v";
                                tempPro2.cuatro = "f";
                                tempPro2.cinco = "v";
                                tempPro2.seis = "v";
                                tablasuma1.Items.Add(tempPro2);
                                Proposisiciones tempPro3 = new Proposisiciones();
                                tempPro3.uno = "f";
                                tempPro3.dos = "f";
                                tempPro3.tres = "f";
                                tempPro3.cuatro = "v";
                                tempPro3.cinco = "v";
                                tempPro3.seis = "f";
                                tablasuma1.Items.Add(tempPro3);
                                Proposisiciones tempPro4 = new Proposisiciones();
                                tempPro4.uno = "v";
                                tempPro4.dos = "v";
                                tempPro4.tres = "f";
                                tempPro4.cuatro = "f";
                                tempPro4.cinco = "f";
                                tempPro4.seis = "v";
                                tempPro4.siete = "v";
                                tablasuma1.Items.Add(tempPro4);
                                Proposisiciones tempPro5 = new Proposisiciones();
                                tempPro5.uno = "f";
                                tempPro5.dos = "f";
                                tempPro5.tres = "v";
                                tempPro5.cuatro = "v";
                                tempPro5.cinco = "v";
                                tempPro5.seis = "f";

                                tablasuma1.Items.Add(tempPro5);
                                Proposisiciones tempPro6 = new Proposisiciones();
                                tempPro6.uno = "v";
                                tempPro6.dos = "f";
                                tempPro6.tres = "v";
                                tempPro6.cuatro = "f";
                                tempPro6.cinco = "f";
                                tempPro6.seis = "v";
                                tablasuma1.Items.Add(tempPro6);
                                Proposisiciones tempPro7 = new Proposisiciones();
                                tempPro7.uno = "f";
                                tempPro7.dos = "v";
                                tempPro7.tres = "f";
                                tempPro7.cuatro = "v";
                                tempPro7.cinco = "v";
                                tempPro7.seis = "v";
                                tablasuma1.Items.Add(tempPro7);
                                Proposisiciones tempPro8 = new Proposisiciones();
                                tempPro8.uno = "v";
                                tempPro8.dos = "f";
                                tempPro8.tres = "f";
                                tempPro8.cuatro = "f";
                                tempPro8.cinco = "f";
                                tempPro8.seis = "v";
                                tablasuma1.Items.Add(tempPro8);
                                Proposisiciones tempPro9 = new Proposisiciones();
                                tempPro9.uno = "f";
                                tempPro9.dos = "v";
                                tempPro9.tres = "v";
                                tempPro9.cuatro = "v";
                                tempPro9.cinco = "f";
                                tempPro9.seis = "v";
                                tablasuma1.Items.Add(tempPro9);
                                resoluciondeteorema.Text = resoluciondeteorema.Text + "el teorema es falso";

                            }

                            //b
                            if (prop2.SelectedIndex == prop4.SelectedIndex || prop2.SelectedIndex == prop3.SelectedIndex)
                            {


                                Proposisiciones tempPro2 = new Proposisiciones();
                                tempPro2.uno = "v";
                                tempPro2.dos = "v";
                                tempPro2.tres = "v";
                                tempPro2.cuatro = "f";
                                tempPro2.cinco = "v";
                                tempPro2.seis = "v";
                                tablasuma1.Items.Add(tempPro2);
                                Proposisiciones tempPro3 = new Proposisiciones();
                                tempPro3.uno = "f";
                                tempPro3.dos = "f";
                                tempPro3.tres = "f";
                                tempPro3.cuatro = "v";
                                tempPro3.cinco = "v";
                                tempPro3.seis = "f";
                                tablasuma1.Items.Add(tempPro3);
                                Proposisiciones tempPro4 = new Proposisiciones();
                                tempPro4.uno = "v";
                                tempPro4.dos = "v";
                                tempPro4.tres = "f";
                                tempPro4.cuatro = "f";
                                tempPro4.cinco = "f";
                                tempPro4.seis = "v";
                                tempPro4.siete = "v";
                                tablasuma1.Items.Add(tempPro4);
                                Proposisiciones tempPro5 = new Proposisiciones();
                                tempPro5.uno = "f";
                                tempPro5.dos = "f";
                                tempPro5.tres = "v";
                                tempPro5.cuatro = "v";
                                tempPro5.cinco = "v";
                                tempPro5.seis = "f";

                                tablasuma1.Items.Add(tempPro5);
                                Proposisiciones tempPro6 = new Proposisiciones();
                                tempPro6.uno = "v";
                                tempPro6.dos = "f";
                                tempPro6.tres = "v";
                                tempPro6.cuatro = "v";
                                tempPro6.cinco = "v";
                                tempPro6.seis = "v";
                                tablasuma1.Items.Add(tempPro6);
                                Proposisiciones tempPro7 = new Proposisiciones();
                                tempPro7.uno = "f";
                                tempPro7.dos = "v";
                                tempPro7.tres = "f";
                                tempPro7.cuatro = "f";
                                tempPro7.cinco = "f";
                                tempPro7.seis = "f";
                                tablasuma1.Items.Add(tempPro7);
                                Proposisiciones tempPro8 = new Proposisiciones();
                                tempPro8.uno = "v";
                                tempPro8.dos = "f";
                                tempPro8.tres = "f";
                                tempPro8.cuatro = "v";
                                tempPro8.cinco = "v";
                                tempPro8.seis = "v";
                                tablasuma1.Items.Add(tempPro8);
                                Proposisiciones tempPro9 = new Proposisiciones();
                                tempPro9.uno = "f";
                                tempPro9.dos = "v";
                                tempPro9.tres = "v";
                                tempPro9.cuatro = "f";
                                tempPro9.cinco = "f";
                                tempPro9.seis = "v";
                                tablasuma1.Items.Add(tempPro9);
                                resoluciondeteorema.Text = resoluciondeteorema.Text + "el teorema es falso";

                            }


                          /*  if (prop1.SelectedIndex == 4 && prop3.SelectedIndex == 0 || prop1.SelectedIndex == 5 && prop3.SelectedIndex == 1 || prop1.SelectedIndex == 6 && prop3.SelectedIndex == 2 || prop1.SelectedIndex == 7 && prop3.SelectedIndex == 3 ||
                                 prop1.SelectedIndex == 4 && prop4.SelectedIndex == 0 || prop1.SelectedIndex == 5 && prop4.SelectedIndex == 1 || prop1.SelectedIndex == 6 && prop4.SelectedIndex == 2 || prop1.SelectedIndex == 7 && prop4.SelectedIndex == 3)
                            {
                                Proposisiciones tempPro2 = new Proposisiciones();
                                tempPro2.uno = "f";
                                tempPro2.dos = "f";
                                tempPro2.tres = "f";
                                tempPro2.cuatro = "f";
                                tempPro2.cinco = "f";
                                tempPro2.seis = "f";
                                tempPro2.siete = "f";
                                tablasuma1.Items.Add(tempPro2);
                                Proposisiciones tempPro3 = new Proposisiciones();
                                tempPro3.uno = "f";
                                tempPro3.dos = "f";
                                tempPro3.tres = "f";
                                tempPro3.cuatro = "v";
                                tempPro3.cinco = "v";
                                tempPro3.seis = "v";
                                tempPro3.siete = "f";
                                tablasuma1.Items.Add(tempPro3);
                                Proposisiciones tempPro4 = new Proposisiciones();
                                tempPro4.uno = "v";
                                tempPro4.dos = "v";
                                tempPro4.tres = "f";
                                tempPro4.cuatro = "f";
                                tempPro4.cinco = "f";
                                tempPro4.seis = "f";
                                tempPro4.siete = "v";
                                tablasuma1.Items.Add(tempPro4);
                                Proposisiciones tempPro5 = new Proposisiciones();
                                tempPro5.uno = "f";
                                tempPro5.dos = "f";
                                tempPro5.tres = "v";
                                tempPro5.cuatro = "v";
                                tempPro5.cinco = "v";
                                tempPro5.seis = "v";
                                tempPro5.siete = "v";
                                tablasuma1.Items.Add(tempPro5);
                                Proposisiciones tempPro6 = new Proposisiciones();
                                tempPro6.uno = "v";
                                tempPro6.dos = "f";
                                tempPro6.tres = "v";
                                tempPro6.cuatro = "f";
                                tempPro6.cinco = "v";
                                tempPro6.seis = "v";
                                tempPro6.siete = "v";
                                tablasuma1.Items.Add(tempPro6);
                                Proposisiciones tempPro7 = new Proposisiciones();
                                tempPro7.uno = "f";
                                tempPro7.dos = "v";
                                tempPro7.tres = "f";
                                tempPro7.cuatro = "v";
                                tempPro7.cinco = "f";
                                tempPro7.seis = "v";
                                tempPro7.siete = "v";
                                tablasuma1.Items.Add(tempPro7);
                                Proposisiciones tempPro8 = new Proposisiciones();
                                tempPro8.uno = "v";
                                tempPro8.dos = "f";
                                tempPro8.tres = "f";
                                tempPro8.cuatro = "f";
                                tempPro8.cinco = "v";
                                tempPro8.seis = "v";
                                tempPro8.siete = "v";
                                tablasuma1.Items.Add(tempPro8);
                                Proposisiciones tempPro9 = new Proposisiciones();
                                tempPro9.uno = "f";
                                tempPro9.dos = "v";
                                tempPro9.tres = "v";
                                tempPro9.cuatro = "v";
                                tempPro9.cinco = "f";
                                tempPro9.seis = "v";
                                tempPro9.siete = "v";
                                tablasuma1.Items.Add(tempPro9);
                                resoluciondeteorema.Text = resoluciondeteorema.Text + "el teorema es falso";
                            }
                            else if (prop2.SelectedIndex == 4 && prop4.SelectedIndex == 0 || prop2.SelectedIndex == 5 && prop4.SelectedIndex == 1 || prop2.SelectedIndex == 6 && prop4.SelectedIndex == 2 || prop2.SelectedIndex == 7 && prop4.SelectedIndex == 3 ||
                                prop2.SelectedIndex == 4 && prop3.SelectedIndex == 0 || prop2.SelectedIndex == 5 && prop3.SelectedIndex == 1 || prop2.SelectedIndex == 6 && prop3.SelectedIndex == 2 || prop2.SelectedIndex == 7 && prop3.SelectedIndex == 3)
                            {
                                Proposisiciones tempPro2 = new Proposisiciones();
                                tempPro2.uno = "v";
                                tempPro2.dos = "v";
                                tempPro2.tres = "v";
                                tempPro2.cuatro = "f";
                                tempPro2.cinco = "f";
                                tempPro2.seis = "f";
                                // tempPro2.siete = "hola";
                                tablasuma1.Items.Add(tempPro2);
                                Proposisiciones tempPro3 = new Proposisiciones();
                                tempPro3.uno = "f";
                                tempPro3.dos = "f";
                                tempPro3.tres = "f";
                                tempPro3.cuatro = "v";
                                tempPro3.cinco = "v";
                                tempPro3.seis = "v";
                                // tempPro3.siete = "f";
                                tablasuma1.Items.Add(tempPro3);
                                Proposisiciones tempPro4 = new Proposisiciones();
                                tempPro4.uno = "v";
                                tempPro4.dos = "v";
                                tempPro4.tres = "f";
                                tempPro4.cuatro = "f";
                                tempPro4.cinco = "f";
                                tempPro4.seis = "f";
                                // tempPro4.siete = "v";
                                tablasuma1.Items.Add(tempPro4);
                                Proposisiciones tempPro5 = new Proposisiciones();
                                tempPro5.uno = "f";
                                tempPro5.dos = "f";
                                tempPro5.tres = "v";
                                tempPro5.cuatro = "v";
                                tempPro5.cinco = "v";
                                tempPro5.seis = "v";
                                // tempPro5.siete = "v";
                                tablasuma1.Items.Add(tempPro5);
                                Proposisiciones tempPro6 = new Proposisiciones();
                                tempPro6.uno = "v";
                                tempPro6.dos = "f";
                                tempPro6.tres = "v";
                                tempPro6.cuatro = "f";
                                tempPro6.cinco = "v";
                                tempPro6.seis = "v";
                                // tempPro6.siete = "v";
                                tablasuma1.Items.Add(tempPro6);
                                Proposisiciones tempPro7 = new Proposisiciones();
                                tempPro7.uno = "f";
                                tempPro7.dos = "v";
                                tempPro7.tres = "f";
                                tempPro7.cuatro = "v";
                                tempPro7.cinco = "f";
                                tempPro7.seis = "v";
                                //tempPro7.siete = "v";
                                tablasuma1.Items.Add(tempPro7);
                                Proposisiciones tempPro8 = new Proposisiciones();
                                tempPro8.uno = "v";
                                tempPro8.dos = "f";
                                tempPro8.tres = "f";
                                tempPro8.cuatro = "f";
                                tempPro8.cinco = "v";
                                tempPro8.seis = "v";
                                //tempPro8.siete = "v";
                                tablasuma1.Items.Add(tempPro8);
                                Proposisiciones tempPro9 = new Proposisiciones();
                                tempPro9.uno = "f";
                                tempPro9.dos = "v";
                                tempPro9.tres = "v";
                                tempPro9.cuatro = "v";
                                tempPro9.cinco = "f";
                                tempPro9.seis = "v";
                                //  tempPro9.siete = "v";
                                tablasuma1.Items.Add(tempPro9);
                                resoluciondeteorema.Text = resoluciondeteorema.Text + "el teorema es falso";
                            }*/
                        }


                    }


                //listo

                    if (resultado1.Text == "p*-p" || resultado1.Text == "p*-q" || resultado1.Text == "p*-r" || resultado1.Text == "p*-s" || resultado1.Text == "q*-p" || resultado1.Text == "q*-q" || resultado1.Text == "q*-r" || resultado1.Text == "q*-s" ||
                        resultado1.Text == "r*-p" || resultado1.Text == "r*-q" || resultado1.Text == "r*-r" || resultado1.Text == "r*-s" || resultado1.Text == "s*-p" || resultado1.Text == "s*-q" || resultado1.Text == "s*-r" || resultado1.Text == "s*-s")
                    {
                        if (resultado2.Text == "p*-p" || resultado2.Text == "p*-q" || resultado2.Text == "p*-r" || resultado2.Text == "p*-s" || resultado2.Text == "q*-p" || resultado2.Text == "q*-q" || resultado2.Text == "q*-r" || resultado2.Text == "q+-s" ||
                           resultado2.Text == "r*-p" || resultado2.Text == "r*-q" || resultado2.Text == "r*-r" || resultado2.Text == "r*-s" || resultado2.Text == "s*-p" || resultado2.Text == "s*-q" || resultado2.Text == "s*-r" || resultado2.Text == "s+-s" ||
                           resultado2.Text == "-p*p" || resultado2.Text == "-p+q" || resultado2.Text == "-p*r" || resultado2.Text == "-p*s" || resultado2.Text == "-q*p" || resultado2.Text == "-q*q" || resultado2.Text == "-q*r" || resultado2.Text == "-q+s" ||
                           resultado2.Text == "-r*p" || resultado2.Text == "-r*q" || resultado2.Text == "-r*r" || resultado2.Text == "-r*s" || resultado2.Text == "-s*p" || resultado2.Text == "-s*q" || resultado2.Text == "-s*r" || resultado2.Text == "-s+s")

                        {

                            Proposisiciones tempPro2 = new Proposisiciones();
                            tempPro2.uno = "v";
                            tempPro2.dos = "v";
                            tempPro2.tres = "v";
                            tempPro2.cuatro = "f";
                            tempPro2.cinco = "f";
                            tempPro2.seis = "f";
                            tablasuma1.Items.Add(tempPro2);
                            Proposisiciones tempPro3 = new Proposisiciones();
                            tempPro3.uno = "f";
                            tempPro3.dos = "f";
                            tempPro3.tres = "f";
                            tempPro3.cuatro = "v";
                            tempPro3.cinco = "f";
                            tempPro3.seis = "f";
                            tablasuma1.Items.Add(tempPro3);
                            Proposisiciones tempPro4 = new Proposisiciones();
                            tempPro4.uno = "v";
                            tempPro4.dos = "v";
                            tempPro4.tres = "f";
                            tempPro4.cuatro = "f";
                            tempPro4.cinco = "f";
                            tempPro4.seis = "f";
                            tablasuma1.Items.Add(tempPro4);
                            Proposisiciones tempPro5 = new Proposisiciones();
                            tempPro5.uno = "f";
                            tempPro5.dos = "f";
                            tempPro5.tres = "v";
                            tempPro5.cuatro = "v";
                            tempPro5.cinco = "f";
                            tempPro5.seis = "v";
                            tablasuma1.Items.Add(tempPro5);
                            Proposisiciones tempPro6 = new Proposisiciones();
                            tempPro6.uno = "v";
                            tempPro6.dos = "f";
                            tempPro6.tres = "v";
                            tempPro6.cuatro = "v";
                            tempPro6.cinco = "v";
                            tempPro6.seis = "v";
                            tablasuma1.Items.Add(tempPro6);
                            Proposisiciones tempPro7 = new Proposisiciones();
                            tempPro7.uno = "f";
                            tempPro7.dos = "v";
                            tempPro7.tres = "f";
                            tempPro7.cuatro = "f";
                            tempPro7.cinco = "f";
                            tempPro7.seis = "f";
                            tablasuma1.Items.Add(tempPro7);
                            Proposisiciones tempPro8 = new Proposisiciones();
                            tempPro8.uno = "v";
                            tempPro8.dos = "f";
                            tempPro8.tres = "f";
                            tempPro8.cuatro = "v";
                            tempPro8.cinco = "v";
                            tempPro8.seis = "f";
                            tablasuma1.Items.Add(tempPro8);
                            Proposisiciones tempPro9 = new Proposisiciones();
                            tempPro9.uno = "f";
                            tempPro9.dos = "v";
                            tempPro9.tres = "v";
                            tempPro9.cuatro = "f";
                            tempPro9.cinco = "f";
                            tempPro9.seis = "f";
                            tablasuma1.Items.Add(tempPro9);
                            resoluciondeteorema.Text = resoluciondeteorema.Text + "el teorema es falso";
                        }
                    }


                    if (resultado1.Text == "-p*p" || resultado1.Text == "-p*q" || resultado1.Text == "-p*r" || resultado1.Text == "-p*s" || resultado1.Text == "-q*p" || resultado1.Text == "-q*q" || resultado1.Text == "-q*r" || resultado1.Text == "-q*s" ||
                        resultado1.Text == "-r*p" || resultado1.Text == "-r*q" || resultado1.Text == "-r*r" || resultado1.Text == "-r*s" || resultado1.Text == "-s*p" || resultado1.Text == "-s*q" || resultado1.Text == "-s*r" || resultado1.Text == "-s*s")
                    {
                        if (resultado2.Text == "p*-p" || resultado2.Text == "p*-q" || resultado2.Text == "p*-r" || resultado2.Text == "p*-s" || resultado2.Text == "q*-p" || resultado2.Text == "q*-q" || resultado2.Text == "q*-r" || resultado2.Text == "q+-s" ||
                           resultado2.Text == "r*-p" || resultado2.Text == "r*-q" || resultado2.Text == "r*-r" || resultado2.Text == "r*-s" || resultado2.Text == "s*-p" || resultado2.Text == "s*-q" || resultado2.Text == "s*-r" || resultado2.Text == "s+-s" ||
                           resultado2.Text == "-p*p" || resultado2.Text == "-p+q" || resultado2.Text == "-p*r" || resultado2.Text == "-p*s" || resultado2.Text == "-q*p" || resultado2.Text == "-q*q" || resultado2.Text == "-q*r" || resultado2.Text == "-q+s" ||
                           resultado2.Text == "-r*p" || resultado2.Text == "-r*q" || resultado2.Text == "-r*r" || resultado2.Text == "-r*s" || resultado2.Text == "-s*p" || resultado2.Text == "-s*q" || resultado2.Text == "-s*r" || resultado2.Text == "-s+s")

                        {

                            Proposisiciones tempPro2 = new Proposisiciones();
                            tempPro2.uno = "v";
                            tempPro2.dos = "v";
                            tempPro2.tres = "v";
                            tempPro2.cuatro = "f";
                            tempPro2.cinco = "f";
                            tempPro2.seis = "f";
                            tablasuma1.Items.Add(tempPro2);
                            Proposisiciones tempPro3 = new Proposisiciones();
                            tempPro3.uno = "f";
                            tempPro3.dos = "f";
                            tempPro3.tres = "f";
                            tempPro3.cuatro = "v";
                            tempPro3.cinco = "f";
                            tempPro3.seis = "f";
                            tablasuma1.Items.Add(tempPro3);
                            Proposisiciones tempPro4 = new Proposisiciones();
                            tempPro4.uno = "v";
                            tempPro4.dos = "v";
                            tempPro4.tres = "f";
                            tempPro4.cuatro = "f";
                            tempPro4.cinco = "f";
                            tempPro4.seis = "f";
                            tablasuma1.Items.Add(tempPro4);
                            Proposisiciones tempPro5 = new Proposisiciones();
                            tempPro5.uno = "f";
                            tempPro5.dos = "f";
                            tempPro5.tres = "v";
                            tempPro5.cuatro = "v";
                            tempPro5.cinco = "f";
                            tempPro5.seis = "v";
                            tablasuma1.Items.Add(tempPro5);
                            Proposisiciones tempPro6 = new Proposisiciones();
                            tempPro6.uno = "v";
                            tempPro6.dos = "f";
                            tempPro6.tres = "v";
                            tempPro6.cuatro = "f";
                            tempPro6.cinco = "f";
                            tempPro6.seis = "f";
                            tablasuma1.Items.Add(tempPro6);
                            Proposisiciones tempPro7 = new Proposisiciones();
                            tempPro7.uno = "f";
                            tempPro7.dos = "v";
                            tempPro7.tres = "f";
                            tempPro7.cuatro = "v";
                            tempPro7.cinco = "v";
                            tempPro7.seis = "v";
                            tablasuma1.Items.Add(tempPro7);
                            Proposisiciones tempPro8 = new Proposisiciones();
                            tempPro8.uno = "v";
                            tempPro8.dos = "f";
                            tempPro8.tres = "f";
                            tempPro8.cuatro = "f";
                            tempPro8.cinco = "f";
                            tempPro8.seis = "f";
                            tablasuma1.Items.Add(tempPro8);
                            Proposisiciones tempPro9 = new Proposisiciones();
                            tempPro9.uno = "f";
                            tempPro9.dos = "v";
                            tempPro9.tres = "v";
                            tempPro9.cuatro = "v";
                            tempPro9.cinco = "v";
                            tempPro9.seis = "v";
                            tablasuma1.Items.Add(tempPro9);
                            resoluciondeteorema.Text = resoluciondeteorema.Text + "el teorema es falso";
                        }
                    }


                    //multiplicaciones


                    if (resultado1.Text == "-p+p" || resultado1.Text == "-p+q" || resultado1.Text == "-p+r" || resultado1.Text == "-p+s" || resultado1.Text == "-q+p" || resultado1.Text == "-q+q" || resultado1.Text == "-q+r" || resultado1.Text == "-q+s" ||
                          resultado1.Text == "-r+p" || resultado1.Text == "-r+q" || resultado1.Text == "-r+r" || resultado1.Text == "-r+s" || resultado1.Text == "-s+p" || resultado1.Text == "-s+q" || resultado1.Text == "-s+r" || resultado1.Text == "-s+s" ||
                          resultado1.Text == "p+-p" || resultado1.Text == "p+-q" || resultado1.Text == "p+-r" || resultado1.Text == "p+-s" || resultado1.Text == "q+-p" || resultado1.Text == "q+-q" || resultado1.Text == "q+-r" || resultado1.Text == "q+-s" ||
                          resultado1.Text == "r+-p" || resultado1.Text == "r-+q" || resultado1.Text == "r+-r" || resultado1.Text == "r+-s" || resultado1.Text == "s+-p" || resultado1.Text == "s+-q" || resultado1.Text == "s+-r" || resultado1.Text == "s+-s")
                    {
                        if (resultado2.Text == "p+q" || resultado2.Text == "p+r" || resultado2.Text == "p+s" || resultado2.Text == "p+p" || resultado2.Text == "q+r" || resultado2.Text == "q+s" || resultado2.Text == "q+p" || resultado2.Text == "q+q" ||
                           resultado2.Text == "r+q" || resultado2.Text == "r+r" || resultado2.Text == "r+s" || resultado2.Text == "r+p" || resultado2.Text == "s+p" || resultado2.Text == "s+q" || resultado2.Text == "s+r" || resultado2.Text == "s+s"
                           )

                        {
                            tablasuma1.Visibility = Visibility.Visible;
                            tablasuma1.Items.Clear();
                            tablasuma2.Visibility = Visibility.Hidden;
                            Proposisiciones tempPro = new Proposisiciones();

                            if (prop1.SelectedIndex == 0)
                            {
                                tempPro.uno = "p";
                            }
                            if (prop1.SelectedIndex == 1)
                            {
                                tempPro.uno = "q";
                            }
                            if (prop1.SelectedIndex == 2)
                            {
                                tempPro.uno = "r";
                            }
                            if (prop1.SelectedIndex == 3)
                            {
                                tempPro.uno = "s";
                            }
                            if (prop1.SelectedIndex == 4)
                            {
                                tempPro.uno = "p";
                            }
                            if (prop1.SelectedIndex == 5)
                            {
                                tempPro.uno = "q";
                            }
                            if (prop1.SelectedIndex == 6)
                            {
                                tempPro.uno = "r";
                            }
                            if (prop1.SelectedIndex == 7)
                            {
                                tempPro.uno = "s";
                            }


                            if (prop2.SelectedIndex == 0)
                            {
                                tempPro.dos = "p";
                            }
                            if (prop2.SelectedIndex == 1)
                            {
                                tempPro.dos = "q";
                            }
                            if (prop2.SelectedIndex == 2)
                            {
                                tempPro.dos = "r";
                            }
                            if (prop2.SelectedIndex == 3)
                            {
                                tempPro.dos = "s";
                            }

                            if (prop2.SelectedIndex == 4)
                            {
                                tempPro.dos = "p";
                            }
                            if (prop2.SelectedIndex == 5)
                            {
                                tempPro.dos = "q";
                            }
                            if (prop2.SelectedIndex == 6)
                            {
                                tempPro.dos = "r";
                            }
                            if (prop2.SelectedIndex == 7)
                            {
                                tempPro.dos = "s";
                            }



                            // tempPro.tres= prop3.Text;

                            if (prop1.SelectedIndex == 4 || prop2.SelectedIndex == 4 || prop3.SelectedIndex == 4 || prop4.SelectedIndex == 4)
                            {
                                tempPro.cuatro = "-p";
                            }
                            if (prop1.SelectedIndex == 5 || prop2.SelectedIndex == 5 || prop3.SelectedIndex == 5 || prop4.SelectedIndex == 5)
                            {
                                tempPro.cuatro = "-q";
                            }
                            if (prop1.SelectedIndex == 6 || prop2.SelectedIndex == 6 || prop3.SelectedIndex == 6 || prop4.SelectedIndex == 6)
                            {
                                tempPro.cuatro = "-r";
                            }
                            if (prop1.SelectedIndex == 7 || prop2.SelectedIndex == 7 || prop3.SelectedIndex == 7 || prop4.SelectedIndex == 7)
                            {
                                tempPro.cuatro = "-s";
                            }



                            if (prop3.SelectedIndex == 0 || prop4.SelectedIndex == 0)
                            {
                                tempPro.tres = "p";
                            }
                            if (prop3.SelectedIndex == 1 || prop4.SelectedIndex == 1)
                            {
                                tempPro.tres = "q";
                            }
                            if (prop3.SelectedIndex == 2 || prop4.SelectedIndex == 2)
                            {
                                tempPro.tres = "r";
                            }
                            if (prop3.SelectedIndex == 3 || prop4.SelectedIndex == 3)
                            {
                                tempPro.tres = "s";
                            }




                            //tempPro.cuatro = prop4.Text;
                            tempPro.cinco = resultado1.Text;
                            tempPro.seis = resultado2.Text;
                            tablasuma1.Items.Add(tempPro);
                            //b
                            if (prop1.SelectedIndex == 4 && prop3.SelectedIndex == 0 || prop1.SelectedIndex == 5 && prop3.SelectedIndex == 1 || prop1.SelectedIndex == 6 && prop3.SelectedIndex == 2 || prop1.SelectedIndex == 7 && prop3.SelectedIndex == 3)
                            {
                                Proposisiciones tempPro2 = new Proposisiciones();
                                tempPro2.uno = "v";
                                tempPro2.dos = "v";
                                tempPro2.tres = "v";
                                tempPro2.cuatro = "f";
                                tempPro2.cinco = "v";
                                tempPro2.seis = "v";
                                tablasuma1.Items.Add(tempPro2);
                                Proposisiciones tempPro3 = new Proposisiciones();
                                tempPro3.uno = "f";
                                tempPro3.dos = "f";
                                tempPro3.tres = "f";
                                tempPro3.cuatro = "v";
                                tempPro3.cinco = "v";
                                tempPro3.seis = "f";
                                tablasuma1.Items.Add(tempPro3);
                                Proposisiciones tempPro4 = new Proposisiciones();
                                tempPro4.uno = "v";
                                tempPro4.dos = "v";
                                tempPro4.tres = "f";
                                tempPro4.cuatro = "f";
                                tempPro4.cinco = "f";
                                tempPro4.seis = "v";

                                tablasuma1.Items.Add(tempPro4);
                                Proposisiciones tempPro5 = new Proposisiciones();
                                tempPro5.uno = "f";
                                tempPro5.dos = "f";
                                tempPro5.tres = "v";
                                tempPro5.cuatro = "v";
                                tempPro5.cinco = "v";
                                tempPro5.seis = "v";

                                tablasuma1.Items.Add(tempPro5);
                                Proposisiciones tempPro6 = new Proposisiciones();
                                tempPro6.uno = "v";
                                tempPro6.dos = "f";
                                tempPro6.tres = "v";
                                tempPro6.cuatro = "f";
                                tempPro6.cinco = "f";
                                tempPro6.seis = "v";
                                tablasuma1.Items.Add(tempPro6);
                                Proposisiciones tempPro7 = new Proposisiciones();
                                tempPro7.uno = "f";
                                tempPro7.dos = "v";
                                tempPro7.tres = "f";
                                tempPro7.cuatro = "v";
                                tempPro7.cinco = "v";
                                tempPro7.seis = "f";
                                tablasuma1.Items.Add(tempPro7);
                                Proposisiciones tempPro8 = new Proposisiciones();
                                tempPro8.uno = "v";
                                tempPro8.dos = "f";
                                tempPro8.tres = "f";
                                tempPro8.cuatro = "f";
                                tempPro8.cinco = "f";
                                tempPro8.seis = "v";
                                tablasuma1.Items.Add(tempPro8);
                                Proposisiciones tempPro9 = new Proposisiciones();
                                tempPro9.uno = "f";
                                tempPro9.dos = "v";
                                tempPro9.tres = "v";
                                tempPro9.cuatro = "v";
                                tempPro9.cinco = "f";
                                tempPro9.seis = "v";
                                tablasuma1.Items.Add(tempPro9);
                                resoluciondeteorema.Text = resoluciondeteorema.Text + "el teorema es falso";
                            }

                            //a
                            if (prop1.SelectedIndex == 4 && prop4.SelectedIndex == 0 || prop1.SelectedIndex == 5 && prop4.SelectedIndex == 1 || prop1.SelectedIndex == 6 && prop4.SelectedIndex == 2 || prop1.SelectedIndex == 7 && prop4.SelectedIndex == 3)
                            {

                                {
                                    Proposisiciones tempPro2 = new Proposisiciones();
                                    tempPro2.uno = "v";
                                    tempPro2.dos = "v";
                                    tempPro2.tres = "v";
                                    tempPro2.cuatro = "f";
                                    tempPro2.cinco = "v";
                                    tempPro2.seis = "v";
                                    tablasuma1.Items.Add(tempPro2);
                                    Proposisiciones tempPro3 = new Proposisiciones();
                                    tempPro3.uno = "f";
                                    tempPro3.dos = "f";
                                    tempPro3.tres = "f";
                                    tempPro3.cuatro = "v";
                                    tempPro3.cinco = "v";
                                    tempPro3.seis = "f";
                                    tablasuma1.Items.Add(tempPro3);
                                    Proposisiciones tempPro4 = new Proposisiciones();
                                    tempPro4.uno = "v";
                                    tempPro4.dos = "v";
                                    tempPro4.tres = "f";
                                    tempPro4.cuatro = "f";
                                    tempPro4.cinco = "f";
                                    tempPro4.seis = "v";
                                    tempPro4.siete = "v";
                                    tablasuma1.Items.Add(tempPro4);
                                    Proposisiciones tempPro5 = new Proposisiciones();
                                    tempPro5.uno = "f";
                                    tempPro5.dos = "f";
                                    tempPro5.tres = "v";
                                    tempPro5.cuatro = "v";
                                    tempPro5.cinco = "v";
                                    tempPro5.seis = "f";

                                    tablasuma1.Items.Add(tempPro5);
                                    Proposisiciones tempPro6 = new Proposisiciones();
                                    tempPro6.uno = "v";
                                    tempPro6.dos = "f";
                                    tempPro6.tres = "v";
                                    tempPro6.cuatro = "f";
                                    tempPro6.cinco = "f";
                                    tempPro6.seis = "v";
                                    tablasuma1.Items.Add(tempPro6);
                                    Proposisiciones tempPro7 = new Proposisiciones();
                                    tempPro7.uno = "f";
                                    tempPro7.dos = "v";
                                    tempPro7.tres = "f";
                                    tempPro7.cuatro = "v";
                                    tempPro7.cinco = "v";
                                    tempPro7.seis = "v";
                                    tablasuma1.Items.Add(tempPro7);
                                    Proposisiciones tempPro8 = new Proposisiciones();
                                    tempPro8.uno = "v";
                                    tempPro8.dos = "f";
                                    tempPro8.tres = "f";
                                    tempPro8.cuatro = "f";
                                    tempPro8.cinco = "f";
                                    tempPro8.seis = "v";
                                    tablasuma1.Items.Add(tempPro8);
                                    Proposisiciones tempPro9 = new Proposisiciones();
                                    tempPro9.uno = "f";
                                    tempPro9.dos = "v";
                                    tempPro9.tres = "v";
                                    tempPro9.cuatro = "v";
                                    tempPro9.cinco = "f";
                                    tempPro9.seis = "v";
                                    tablasuma1.Items.Add(tempPro9);
                                    resoluciondeteorema.Text = resoluciondeteorema.Text + "el teorema es falso";
                                }
                            }

                            //c
                            if (prop2.SelectedIndex == 4 && prop3.SelectedIndex == 0 || prop2.SelectedIndex == 5 && prop3.SelectedIndex == 1 || prop2.SelectedIndex == 6 && prop3.SelectedIndex == 2 || prop2.SelectedIndex == 7 && prop3.SelectedIndex == 3)
                            {
                                Proposisiciones tempPro2 = new Proposisiciones();
                                tempPro2.uno = "v";
                                tempPro2.dos = "v";
                                tempPro2.tres = "v";
                                tempPro2.cuatro = "f";
                                tempPro2.cinco = "v";
                                tempPro2.seis = "v";
                                tablasuma1.Items.Add(tempPro2);
                                Proposisiciones tempPro3 = new Proposisiciones();
                                tempPro3.uno = "f";
                                tempPro3.dos = "f";
                                tempPro3.tres = "f";
                                tempPro3.cuatro = "v";
                                tempPro3.cinco = "v";
                                tempPro3.seis = "f";
                                tablasuma1.Items.Add(tempPro3);
                                Proposisiciones tempPro4 = new Proposisiciones();
                                tempPro4.uno = "v";
                                tempPro4.dos = "v";
                                tempPro4.tres = "f";
                                tempPro4.cuatro = "f";
                                tempPro4.cinco = "f";
                                tempPro4.seis = "v";

                                tablasuma1.Items.Add(tempPro4);
                                Proposisiciones tempPro5 = new Proposisiciones();
                                tempPro5.uno = "f";
                                tempPro5.dos = "f";
                                tempPro5.tres = "v";
                                tempPro5.cuatro = "v";
                                tempPro5.cinco = "v";
                                tempPro5.seis = "f";

                                tablasuma1.Items.Add(tempPro5);
                                Proposisiciones tempPro6 = new Proposisiciones();
                                tempPro6.uno = "v";
                                tempPro6.dos = "f";
                                tempPro6.tres = "v";
                                tempPro6.cuatro = "v";
                                tempPro6.cinco = "v";
                                tempPro6.seis = "v";
                                tablasuma1.Items.Add(tempPro6);
                                Proposisiciones tempPro7 = new Proposisiciones();
                                tempPro7.uno = "f";
                                tempPro7.dos = "v";
                                tempPro7.tres = "f";
                                tempPro7.cuatro = "f";
                                tempPro7.cinco = "f";
                                tempPro7.seis = "v";
                                tablasuma1.Items.Add(tempPro7);
                                Proposisiciones tempPro8 = new Proposisiciones();
                                tempPro8.uno = "v";
                                tempPro8.dos = "f";
                                tempPro8.tres = "f";
                                tempPro8.cuatro = "v";
                                tempPro8.cinco = "v";
                                tempPro8.seis = "v";
                                tablasuma1.Items.Add(tempPro8);
                                Proposisiciones tempPro9 = new Proposisiciones();
                                tempPro9.uno = "f";
                                tempPro9.dos = "v";
                                tempPro9.tres = "v";
                                tempPro9.cuatro = "f";
                                tempPro9.cinco = "f";
                                tempPro9.seis = "v";
                                tablasuma1.Items.Add(tempPro9);
                                resoluciondeteorema.Text = resoluciondeteorema.Text + "el teorema es falso";
                            }

                            //d
                            if (prop2.SelectedIndex == 4 && prop4.SelectedIndex == 0 || prop2.SelectedIndex == 5 && prop4.SelectedIndex == 1 || prop2.SelectedIndex == 6 && prop4.SelectedIndex == 2 || prop2.SelectedIndex == 7 && prop4.SelectedIndex == 3)
                            {


                                Proposisiciones tempPro2 = new Proposisiciones();
                                tempPro2.uno = "v";
                                tempPro2.dos = "v";
                                tempPro2.tres = "v";
                                tempPro2.cuatro = "f";
                                tempPro2.cinco = "v";
                                tempPro2.seis = "v";
                                tablasuma1.Items.Add(tempPro2);
                                Proposisiciones tempPro3 = new Proposisiciones();
                                tempPro3.uno = "f";
                                tempPro3.dos = "f";
                                tempPro3.tres = "f";
                                tempPro3.cuatro = "v";
                                tempPro3.cinco = "v";
                                tempPro3.seis = "f";
                                tablasuma1.Items.Add(tempPro3);
                                Proposisiciones tempPro4 = new Proposisiciones();
                                tempPro4.uno = "v";
                                tempPro4.dos = "v";
                                tempPro4.tres = "f";
                                tempPro4.cuatro = "f";
                                tempPro4.cinco = "f";
                                tempPro4.seis = "v";
                                tempPro4.siete = "v";
                                tablasuma1.Items.Add(tempPro4);
                                Proposisiciones tempPro5 = new Proposisiciones();
                                tempPro5.uno = "f";
                                tempPro5.dos = "f";
                                tempPro5.tres = "v";
                                tempPro5.cuatro = "v";
                                tempPro5.cinco = "v";
                                tempPro5.seis = "v";

                                tablasuma1.Items.Add(tempPro5);
                                Proposisiciones tempPro6 = new Proposisiciones();
                                tempPro6.uno = "v";
                                tempPro6.dos = "f";
                                tempPro6.tres = "v";
                                tempPro6.cuatro = "v";
                                tempPro6.cinco = "v";
                                tempPro6.seis = "v";
                                tablasuma1.Items.Add(tempPro6);
                                Proposisiciones tempPro7 = new Proposisiciones();
                                tempPro7.uno = "f";
                                tempPro7.dos = "v";
                                tempPro7.tres = "f";
                                tempPro7.cuatro = "f";
                                tempPro7.cinco = "f";
                                tempPro7.seis = "v";
                                tablasuma1.Items.Add(tempPro7);
                                Proposisiciones tempPro8 = new Proposisiciones();
                                tempPro8.uno = "v";
                                tempPro8.dos = "f";
                                tempPro8.tres = "f";
                                tempPro8.cuatro = "v";
                                tempPro8.cinco = "v";
                                tempPro8.seis = "f";
                                tablasuma1.Items.Add(tempPro8);
                                Proposisiciones tempPro9 = new Proposisiciones();
                                tempPro9.uno = "f";
                                tempPro9.dos = "v";
                                tempPro9.tres = "v";
                                tempPro9.cuatro = "f";
                                tempPro9.cinco = "f";
                                tempPro9.seis = "v";
                                tablasuma1.Items.Add(tempPro9);
                                resoluciondeteorema.Text = resoluciondeteorema.Text + "el teorema es falso";

                            }




                        }

                        if (resultado2.Text == "p+-p" || resultado2.Text == "p+-q" || resultado2.Text == "p+-r" || resultado2.Text == "p+-s" || resultado2.Text == "q+-p" || resultado2.Text == "q+-q" || resultado2.Text == "q+-r" || resultado2.Text == "q+-s" ||
                           resultado2.Text == "r+-p" || resultado2.Text == "r+-q" || resultado2.Text == "r+-r" || resultado2.Text == "r+-s" || resultado2.Text == "s+-p" || resultado2.Text == "s+-q" || resultado2.Text == "s+-r" || resultado2.Text == "s+-s" ||
                           resultado2.Text == "-p+p" || resultado2.Text == "-p+q" || resultado2.Text == "-p+r" || resultado2.Text == "-p+s" || resultado2.Text == "-q+p" || resultado2.Text == "-q+q" || resultado2.Text == "-q+r" || resultado2.Text == "-q+s" ||
                           resultado2.Text == "-r+p" || resultado2.Text == "-r+q" || resultado2.Text == "-r+r" || resultado2.Text == "-r+s" || resultado2.Text == "-s+p" || resultado2.Text == "-s+q" || resultado2.Text == "-s+r" || resultado2.Text == "-s+s")

                        {
                            tablasuma1.Visibility = Visibility.Visible;
                            tablasuma1.Items.Clear();
                            tablasuma2.Visibility = Visibility.Hidden;
                            Proposisiciones tempPro = new Proposisiciones();

                            if (prop1.SelectedIndex == 0)
                            {
                                tempPro.uno = "p";
                            }
                            if (prop1.SelectedIndex == 1)
                            {
                                tempPro.uno = "q";
                            }
                            if (prop1.SelectedIndex == 2)
                            {
                                tempPro.uno = "r";
                            }
                            if (prop1.SelectedIndex == 3)
                            {
                                tempPro.uno = "s";
                            }
                            if (prop1.SelectedIndex == 4)
                            {
                                tempPro.uno = "p";
                            }
                            if (prop1.SelectedIndex == 5)
                            {
                                tempPro.uno = "q";
                            }
                            if (prop1.SelectedIndex == 6)
                            {
                                tempPro.uno = "r";
                            }
                            if (prop1.SelectedIndex == 7)
                            {
                                tempPro.uno = "s";
                            }


                            if (prop2.SelectedIndex == 0)
                            {
                                tempPro.dos = "p";
                            }
                            if (prop2.SelectedIndex == 1)
                            {
                                tempPro.dos = "q";
                            }
                            if (prop2.SelectedIndex == 2)
                            {
                                tempPro.dos = "r";
                            }
                            if (prop2.SelectedIndex == 3)
                            {
                                tempPro.dos = "s";
                            }

                            if (prop2.SelectedIndex == 4)
                            {
                                tempPro.dos = "p";
                            }
                            if (prop2.SelectedIndex == 5)
                            {
                                tempPro.dos = "q";
                            }
                            if (prop2.SelectedIndex == 6)
                            {
                                tempPro.dos = "r";
                            }
                            if (prop2.SelectedIndex == 7)
                            {
                                tempPro.dos = "s";
                            }



                            // tempPro.tres= prop3.Text;

                            if (prop1.SelectedIndex == 4 || prop2.SelectedIndex == 4 || prop3.SelectedIndex == 4 || prop4.SelectedIndex == 4)
                            {
                                tempPro.cuatro = "-p";
                            }
                            if (prop1.SelectedIndex == 5 || prop2.SelectedIndex == 5 || prop3.SelectedIndex == 5 || prop4.SelectedIndex == 5)
                            {
                                tempPro.cuatro = "-q";
                            }
                            if (prop1.SelectedIndex == 6 || prop2.SelectedIndex == 6 || prop3.SelectedIndex == 6 || prop4.SelectedIndex == 6)
                            {
                                tempPro.cuatro = "-r";
                            }
                            if (prop1.SelectedIndex == 7 || prop2.SelectedIndex == 7 || prop3.SelectedIndex == 7 || prop4.SelectedIndex == 7)
                            {
                                tempPro.cuatro = "-s";
                            }



                            if (prop3.SelectedIndex == 0 || prop4.SelectedIndex == 0)
                            {
                                tempPro.tres = "p";
                            }
                            if (prop3.SelectedIndex == 1 || prop4.SelectedIndex == 1)
                            {
                                tempPro.tres = "q";
                            }
                            if (prop3.SelectedIndex == 2 || prop4.SelectedIndex == 2)
                            {
                                tempPro.tres = "r";
                            }
                            if (prop3.SelectedIndex == 3 || prop4.SelectedIndex == 3)
                            {
                                tempPro.tres = "s";
                            }




                            //tempPro.cuatro = prop4.Text;
                            tempPro.cinco = resultado1.Text;
                            tempPro.seis = resultado2.Text;
                            tablasuma1.Items.Add(tempPro);
                            //paso 2 



                            //a
                            if (prop1.SelectedIndex == 4 && prop4.SelectedIndex == 4 || prop1.SelectedIndex == 5 && prop4.SelectedIndex == 5 || prop1.SelectedIndex == 6 && prop4.SelectedIndex == 6 || prop1.SelectedIndex == 7 && prop4.SelectedIndex == 7 ||
                                prop1.SelectedIndex == 4 && prop3.SelectedIndex == 4 || prop1.SelectedIndex == 5 && prop3.SelectedIndex == 5 || prop1.SelectedIndex == 6 && prop3.SelectedIndex == 6 || prop1.SelectedIndex == 7 && prop3.SelectedIndex == 7)
                            {


                                Proposisiciones tempPro2 = new Proposisiciones();
                                tempPro2.uno = "v";
                                tempPro2.dos = "v";
                                tempPro2.tres = "v";
                                tempPro2.cuatro = "f";
                                tempPro2.cinco = "v";
                                tempPro2.seis = "v";
                                tablasuma1.Items.Add(tempPro2);
                                Proposisiciones tempPro3 = new Proposisiciones();
                                tempPro3.uno = "f";
                                tempPro3.dos = "f";
                                tempPro3.tres = "f";
                                tempPro3.cuatro = "v";
                                tempPro3.cinco = "v";
                                tempPro3.seis = "f";
                                tablasuma1.Items.Add(tempPro3);
                                Proposisiciones tempPro4 = new Proposisiciones();
                                tempPro4.uno = "v";
                                tempPro4.dos = "v";
                                tempPro4.tres = "f";
                                tempPro4.cuatro = "f";
                                tempPro4.cinco = "f";
                                tempPro4.seis = "v";
                                tempPro4.siete = "v";
                                tablasuma1.Items.Add(tempPro4);
                                Proposisiciones tempPro5 = new Proposisiciones();
                                tempPro5.uno = "f";
                                tempPro5.dos = "f";
                                tempPro5.tres = "v";
                                tempPro5.cuatro = "v";
                                tempPro5.cinco = "v";
                                tempPro5.seis = "f";

                                tablasuma1.Items.Add(tempPro5);
                                Proposisiciones tempPro6 = new Proposisiciones();
                                tempPro6.uno = "v";
                                tempPro6.dos = "f";
                                tempPro6.tres = "v";
                                tempPro6.cuatro = "f";
                                tempPro6.cinco = "f";
                                tempPro6.seis = "v";
                                tablasuma1.Items.Add(tempPro6);
                                Proposisiciones tempPro7 = new Proposisiciones();
                                tempPro7.uno = "f";
                                tempPro7.dos = "v";
                                tempPro7.tres = "f";
                                tempPro7.cuatro = "v";
                                tempPro7.cinco = "v";
                                tempPro7.seis = "v";
                                tablasuma1.Items.Add(tempPro7);
                                Proposisiciones tempPro8 = new Proposisiciones();
                                tempPro8.uno = "v";
                                tempPro8.dos = "f";
                                tempPro8.tres = "f";
                                tempPro8.cuatro = "f";
                                tempPro8.cinco = "f";
                                tempPro8.seis = "v";
                                tablasuma1.Items.Add(tempPro8);
                                Proposisiciones tempPro9 = new Proposisiciones();
                                tempPro9.uno = "f";
                                tempPro9.dos = "v";
                                tempPro9.tres = "v";
                                tempPro9.cuatro = "v";
                                tempPro9.cinco = "f";
                                tempPro9.seis = "v";
                                tablasuma1.Items.Add(tempPro9);
                                resoluciondeteorema.Text = resoluciondeteorema.Text + "el teorema es falso";

                            }

                            //b
                            if (prop2.SelectedIndex == prop4.SelectedIndex || prop2.SelectedIndex == prop3.SelectedIndex)
                            {


                                Proposisiciones tempPro2 = new Proposisiciones();
                                tempPro2.uno = "v";
                                tempPro2.dos = "v";
                                tempPro2.tres = "v";
                                tempPro2.cuatro = "f";
                                tempPro2.cinco = "v";
                                tempPro2.seis = "v";
                                tablasuma1.Items.Add(tempPro2);
                                Proposisiciones tempPro3 = new Proposisiciones();
                                tempPro3.uno = "f";
                                tempPro3.dos = "f";
                                tempPro3.tres = "f";
                                tempPro3.cuatro = "v";
                                tempPro3.cinco = "v";
                                tempPro3.seis = "f";
                                tablasuma1.Items.Add(tempPro3);
                                Proposisiciones tempPro4 = new Proposisiciones();
                                tempPro4.uno = "v";
                                tempPro4.dos = "v";
                                tempPro4.tres = "f";
                                tempPro4.cuatro = "f";
                                tempPro4.cinco = "f";
                                tempPro4.seis = "v";
                                tempPro4.siete = "v";
                                tablasuma1.Items.Add(tempPro4);
                                Proposisiciones tempPro5 = new Proposisiciones();
                                tempPro5.uno = "f";
                                tempPro5.dos = "f";
                                tempPro5.tres = "v";
                                tempPro5.cuatro = "v";
                                tempPro5.cinco = "v";
                                tempPro5.seis = "f";

                                tablasuma1.Items.Add(tempPro5);
                                Proposisiciones tempPro6 = new Proposisiciones();
                                tempPro6.uno = "v";
                                tempPro6.dos = "f";
                                tempPro6.tres = "v";
                                tempPro6.cuatro = "v";
                                tempPro6.cinco = "v";
                                tempPro6.seis = "v";
                                tablasuma1.Items.Add(tempPro6);
                                Proposisiciones tempPro7 = new Proposisiciones();
                                tempPro7.uno = "f";
                                tempPro7.dos = "v";
                                tempPro7.tres = "f";
                                tempPro7.cuatro = "f";
                                tempPro7.cinco = "f";
                                tempPro7.seis = "f";
                                tablasuma1.Items.Add(tempPro7);
                                Proposisiciones tempPro8 = new Proposisiciones();
                                tempPro8.uno = "v";
                                tempPro8.dos = "f";
                                tempPro8.tres = "f";
                                tempPro8.cuatro = "v";
                                tempPro8.cinco = "v";
                                tempPro8.seis = "v";
                                tablasuma1.Items.Add(tempPro8);
                                Proposisiciones tempPro9 = new Proposisiciones();
                                tempPro9.uno = "f";
                                tempPro9.dos = "v";
                                tempPro9.tres = "v";
                                tempPro9.cuatro = "f";
                                tempPro9.cinco = "f";
                                tempPro9.seis = "v";
                                tablasuma1.Items.Add(tempPro9);
                                resoluciondeteorema.Text = resoluciondeteorema.Text + "el teorema es falso";

                            }


                            /*  if (prop1.SelectedIndex == 4 && prop3.SelectedIndex == 0 || prop1.SelectedIndex == 5 && prop3.SelectedIndex == 1 || prop1.SelectedIndex == 6 && prop3.SelectedIndex == 2 || prop1.SelectedIndex == 7 && prop3.SelectedIndex == 3 ||
                                   prop1.SelectedIndex == 4 && prop4.SelectedIndex == 0 || prop1.SelectedIndex == 5 && prop4.SelectedIndex == 1 || prop1.SelectedIndex == 6 && prop4.SelectedIndex == 2 || prop1.SelectedIndex == 7 && prop4.SelectedIndex == 3)
                              {
                                  Proposisiciones tempPro2 = new Proposisiciones();
                                  tempPro2.uno = "f";
                                  tempPro2.dos = "f";
                                  tempPro2.tres = "f";
                                  tempPro2.cuatro = "f";
                                  tempPro2.cinco = "f";
                                  tempPro2.seis = "f";
                                  tempPro2.siete = "f";
                                  tablasuma1.Items.Add(tempPro2);
                                  Proposisiciones tempPro3 = new Proposisiciones();
                                  tempPro3.uno = "f";
                                  tempPro3.dos = "f";
                                  tempPro3.tres = "f";
                                  tempPro3.cuatro = "v";
                                  tempPro3.cinco = "v";
                                  tempPro3.seis = "v";
                                  tempPro3.siete = "f";
                                  tablasuma1.Items.Add(tempPro3);
                                  Proposisiciones tempPro4 = new Proposisiciones();
                                  tempPro4.uno = "v";
                                  tempPro4.dos = "v";
                                  tempPro4.tres = "f";
                                  tempPro4.cuatro = "f";
                                  tempPro4.cinco = "f";
                                  tempPro4.seis = "f";
                                  tempPro4.siete = "v";
                                  tablasuma1.Items.Add(tempPro4);
                                  Proposisiciones tempPro5 = new Proposisiciones();
                                  tempPro5.uno = "f";
                                  tempPro5.dos = "f";
                                  tempPro5.tres = "v";
                                  tempPro5.cuatro = "v";
                                  tempPro5.cinco = "v";
                                  tempPro5.seis = "v";
                                  tempPro5.siete = "v";
                                  tablasuma1.Items.Add(tempPro5);
                                  Proposisiciones tempPro6 = new Proposisiciones();
                                  tempPro6.uno = "v";
                                  tempPro6.dos = "f";
                                  tempPro6.tres = "v";
                                  tempPro6.cuatro = "f";
                                  tempPro6.cinco = "v";
                                  tempPro6.seis = "v";
                                  tempPro6.siete = "v";
                                  tablasuma1.Items.Add(tempPro6);
                                  Proposisiciones tempPro7 = new Proposisiciones();
                                  tempPro7.uno = "f";
                                  tempPro7.dos = "v";
                                  tempPro7.tres = "f";
                                  tempPro7.cuatro = "v";
                                  tempPro7.cinco = "f";
                                  tempPro7.seis = "v";
                                  tempPro7.siete = "v";
                                  tablasuma1.Items.Add(tempPro7);
                                  Proposisiciones tempPro8 = new Proposisiciones();
                                  tempPro8.uno = "v";
                                  tempPro8.dos = "f";
                                  tempPro8.tres = "f";
                                  tempPro8.cuatro = "f";
                                  tempPro8.cinco = "v";
                                  tempPro8.seis = "v";
                                  tempPro8.siete = "v";
                                  tablasuma1.Items.Add(tempPro8);
                                  Proposisiciones tempPro9 = new Proposisiciones();
                                  tempPro9.uno = "f";
                                  tempPro9.dos = "v";
                                  tempPro9.tres = "v";
                                  tempPro9.cuatro = "v";
                                  tempPro9.cinco = "f";
                                  tempPro9.seis = "v";
                                  tempPro9.siete = "v";
                                  tablasuma1.Items.Add(tempPro9);
                                  resoluciondeteorema.Text = resoluciondeteorema.Text + "el teorema es falso";
                              }
                              else if (prop2.SelectedIndex == 4 && prop4.SelectedIndex == 0 || prop2.SelectedIndex == 5 && prop4.SelectedIndex == 1 || prop2.SelectedIndex == 6 && prop4.SelectedIndex == 2 || prop2.SelectedIndex == 7 && prop4.SelectedIndex == 3 ||
                                  prop2.SelectedIndex == 4 && prop3.SelectedIndex == 0 || prop2.SelectedIndex == 5 && prop3.SelectedIndex == 1 || prop2.SelectedIndex == 6 && prop3.SelectedIndex == 2 || prop2.SelectedIndex == 7 && prop3.SelectedIndex == 3)
                              {
                                  Proposisiciones tempPro2 = new Proposisiciones();
                                  tempPro2.uno = "v";
                                  tempPro2.dos = "v";
                                  tempPro2.tres = "v";
                                  tempPro2.cuatro = "f";
                                  tempPro2.cinco = "f";
                                  tempPro2.seis = "f";
                                  // tempPro2.siete = "hola";
                                  tablasuma1.Items.Add(tempPro2);
                                  Proposisiciones tempPro3 = new Proposisiciones();
                                  tempPro3.uno = "f";
                                  tempPro3.dos = "f";
                                  tempPro3.tres = "f";
                                  tempPro3.cuatro = "v";
                                  tempPro3.cinco = "v";
                                  tempPro3.seis = "v";
                                  // tempPro3.siete = "f";
                                  tablasuma1.Items.Add(tempPro3);
                                  Proposisiciones tempPro4 = new Proposisiciones();
                                  tempPro4.uno = "v";
                                  tempPro4.dos = "v";
                                  tempPro4.tres = "f";
                                  tempPro4.cuatro = "f";
                                  tempPro4.cinco = "f";
                                  tempPro4.seis = "f";
                                  // tempPro4.siete = "v";
                                  tablasuma1.Items.Add(tempPro4);
                                  Proposisiciones tempPro5 = new Proposisiciones();
                                  tempPro5.uno = "f";
                                  tempPro5.dos = "f";
                                  tempPro5.tres = "v";
                                  tempPro5.cuatro = "v";
                                  tempPro5.cinco = "v";
                                  tempPro5.seis = "v";
                                  // tempPro5.siete = "v";
                                  tablasuma1.Items.Add(tempPro5);
                                  Proposisiciones tempPro6 = new Proposisiciones();
                                  tempPro6.uno = "v";
                                  tempPro6.dos = "f";
                                  tempPro6.tres = "v";
                                  tempPro6.cuatro = "f";
                                  tempPro6.cinco = "v";
                                  tempPro6.seis = "v";
                                  // tempPro6.siete = "v";
                                  tablasuma1.Items.Add(tempPro6);
                                  Proposisiciones tempPro7 = new Proposisiciones();
                                  tempPro7.uno = "f";
                                  tempPro7.dos = "v";
                                  tempPro7.tres = "f";
                                  tempPro7.cuatro = "v";
                                  tempPro7.cinco = "f";
                                  tempPro7.seis = "v";
                                  //tempPro7.siete = "v";
                                  tablasuma1.Items.Add(tempPro7);
                                  Proposisiciones tempPro8 = new Proposisiciones();
                                  tempPro8.uno = "v";
                                  tempPro8.dos = "f";
                                  tempPro8.tres = "f";
                                  tempPro8.cuatro = "f";
                                  tempPro8.cinco = "v";
                                  tempPro8.seis = "v";
                                  //tempPro8.siete = "v";
                                  tablasuma1.Items.Add(tempPro8);
                                  Proposisiciones tempPro9 = new Proposisiciones();
                                  tempPro9.uno = "f";
                                  tempPro9.dos = "v";
                                  tempPro9.tres = "v";
                                  tempPro9.cuatro = "v";
                                  tempPro9.cinco = "f";
                                  tempPro9.seis = "v";
                                  //  tempPro9.siete = "v";
                                  tablasuma1.Items.Add(tempPro9);
                                  resoluciondeteorema.Text = resoluciondeteorema.Text + "el teorema es falso";
                              }*/
                        }


                    }











                    /* if (resultado1.Text == "-p+-p" || resultado1.Text == "-p+-q" || resultado1.Text == "-p+-r" || resultado1.Text == "-p+-s" || resultado1.Text == "-q+-p" || resultado1.Text == "-q+-q" || resultado1.Text == "-q+-r" || resultado1.Text == "-q+-s" ||
                               resultado1.Text == "-r+-p" || resultado1.Text == "-r+-q" || resultado1.Text == "-r+-r" || resultado1.Text == "-r+-s" || resultado1.Text == "-s+-p" || resultado1.Text == "-s+-q" || resultado1.Text == "-s+-r" || resultado1.Text == "-s+-s")
                     {
                         if (resultado2.Text == "p+-p" || resultado2.Text == "p+-q" || resultado2.Text == "p+-r" || resultado2.Text == "p+-s" || resultado2.Text == "q+-p" || resultado2.Text == "q+-q" || resultado2.Text == "q+-r" || resultado2.Text == "q+-s" ||
                            resultado2.Text == "r+-p" || resultado2.Text == "r+-q" || resultado2.Text == "r+-r" || resultado2.Text == "r+-s" || resultado2.Text == "s+-p" || resultado2.Text == "s+-q" || resultado2.Text == "s+-r" || resultado2.Text == "s+-s" ||
                            resultado2.Text == "-p+p" || resultado2.Text == "-p+q" || resultado2.Text == "-p+r" || resultado2.Text == "-p+s" || resultado2.Text == "-q+p" || resultado2.Text == "-q+q" || resultado2.Text == "-q+r" || resultado2.Text == "-q+s" ||
                            resultado2.Text == "-r+p" || resultado2.Text == "-r+q" || resultado2.Text == "-r+r" || resultado2.Text == "-r+s" || resultado2.Text == "-s+p" || resultado2.Text == "-s+q" || resultado2.Text == "-s+r" || resultado2.Text == "-s+s")

                         {
                             tablasuma1.Visibility = Visibility.Hidden;
                             tablasuma2.Items.Clear();
                             tablasuma2.Visibility = Visibility.Visible;
                             Proposisiciones tempPro = new Proposisiciones();

                             if (prop1.SelectedIndex == 0)
                             {
                                 tempPro.uno = "p";
                             }
                             if (prop1.SelectedIndex == 1)
                             {
                                 tempPro.uno = "q";
                             }
                             if (prop1.SelectedIndex == 2)
                             {
                                 tempPro.uno = "r";
                             }
                             if (prop1.SelectedIndex == 3)
                             {
                                 tempPro.uno = "s";
                             }
                             if (prop1.SelectedIndex == 4)
                             {
                                 tempPro.uno = "p";
                             }
                             if (prop1.SelectedIndex == 5)
                             {
                                 tempPro.uno = "q";
                             }
                             if (prop1.SelectedIndex == 6)
                             {
                                 tempPro.uno = "r";
                             }
                             if (prop1.SelectedIndex == 7)
                             {
                                 tempPro.uno = "s";
                             }


                             if (prop2.SelectedIndex == 0)
                             {
                                 tempPro.dos = "p";
                             }
                             if (prop2.SelectedIndex == 1)
                             {
                                 tempPro.dos = "q";
                             }
                             if (prop2.SelectedIndex == 2)
                             {
                                 tempPro.dos = "r";
                             }
                             if (prop2.SelectedIndex == 3)
                             {
                                 tempPro.dos = "s";
                             }

                             if (prop2.SelectedIndex == 4)
                             {
                                 tempPro.dos = "p";
                             }
                             if (prop2.SelectedIndex == 5)
                             {
                                 tempPro.dos = "q";
                             }
                             if (prop2.SelectedIndex == 6)
                             {
                                 tempPro.dos = "r";
                             }
                             if (prop2.SelectedIndex == 7)
                             {
                                 tempPro.dos = "s";
                             }



                             // tempPro.tres= prop3.Text;

                             if (prop1.SelectedIndex == 4 || prop2.SelectedIndex == 4 || prop3.SelectedIndex == 4 || prop4.SelectedIndex == 4)
                             {
                                // tempPro.cuatro = "-p";
                                 tempPro.cinco = "-p";
                             }
                             if (prop1.SelectedIndex == 5 || prop2.SelectedIndex == 5 || prop3.SelectedIndex == 5 || prop4.SelectedIndex == 5)
                             {
                                 //tempPro.cuatro = "-q";
                                 tempPro.cinco = "-q";
                             }
                             if (prop1.SelectedIndex == 6 || prop2.SelectedIndex == 6 || prop3.SelectedIndex == 6 || prop4.SelectedIndex == 6)
                             {
                                 //tempPro.cuatro = "-r";
                                 tempPro.cinco = "-r";
                             }
                             if (prop1.SelectedIndex == 7 || prop2.SelectedIndex == 7 || prop3.SelectedIndex == 7 || prop4.SelectedIndex == 7)
                             {
                                 //tempPro.cuatro = "-s";
                                 tempPro.cinco = "-s";
                             }

                             if ( prop3.SelectedIndex == 4 || prop4.SelectedIndex == 4)
                             {
                                 tempPro.cuatro = "-p";

                             }
                             if ( prop3.SelectedIndex == 5 || prop4.SelectedIndex == 5)
                             {
                                 tempPro.cuatro = "-q";

                             }
                             if ( prop3.SelectedIndex == 6 || prop4.SelectedIndex == 6)
                             {
                                 tempPro.cuatro = "-r";

                             }
                             if ( prop3.SelectedIndex == 7 || prop4.SelectedIndex == 7)
                             {
                                 tempPro.cuatro = "-s";

                             }

                             if (prop3.SelectedIndex == 0 || prop4.SelectedIndex == 0)
                             {
                                 tempPro.tres = "p";
                             }
                             if (prop3.SelectedIndex == 1 || prop4.SelectedIndex == 1)
                             {
                                 tempPro.tres = "q";
                             }
                             if (prop3.SelectedIndex == 2 || prop4.SelectedIndex == 2)
                             {
                                 tempPro.tres = "r";
                             }
                             if (prop3.SelectedIndex == 3 || prop4.SelectedIndex == 3)
                             {
                                 tempPro.tres = "s";
                             }

                             tempPro.seis = resultado1.Text;
                             tempPro.siete = resultado2.Text;
                             tablasuma2.Items.Add(tempPro);*/



                    /* if (prop1.SelectedIndex == 4 || prop1.SelectedIndex == 5 || prop1.SelectedIndex == 6 || prop1.SelectedIndex == 7   )
                     {
                         if (prop3.SelectedIndex == 0 || prop3.SelectedIndex == 1 || prop3.SelectedIndex == 2 || prop3.SelectedIndex == 3)
                         {
                             Proposisiciones tempPro2 = new Proposisiciones();
                             tempPro2.uno = "v";
                             tempPro2.dos = "v";
                             tempPro2.tres = "v";
                             tempPro2.cuatro = "f";
                             tempPro2.cinco = "f";
                             tempPro2.seis = "f";
                             tempPro2.siete = "v";
                             tablasuma2.Items.Add(tempPro2);
                             Proposisiciones tempPro3 = new Proposisiciones();
                             tempPro3.uno = "f";
                             tempPro3.dos = "f";
                             tempPro3.tres = "f";
                             tempPro3.cuatro = "v";
                             tempPro3.cinco = "v";
                             tempPro3.seis = "v";
                             tempPro3.siete = "f";
                             tablasuma2.Items.Add(tempPro3);
                             Proposisiciones tempPro4 = new Proposisiciones();
                             tempPro4.uno = "v";
                             tempPro4.dos = "v";
                             tempPro4.tres = "f";
                             tempPro4.cuatro = "f";
                             tempPro4.cinco = "f";
                             tempPro4.seis = "f";
                             tempPro4.siete = "v";
                             tablasuma2.Items.Add(tempPro4);
                             Proposisiciones tempPro5 = new Proposisiciones();
                             tempPro5.uno = "f";
                             tempPro5.dos = "f";
                             tempPro5.tres = "v";
                             tempPro5.cuatro = "v";
                             tempPro5.cinco = "v";
                             tempPro5.seis = "v";
                             tempPro5.siete = "v";
                             tablasuma2.Items.Add(tempPro5);
                             Proposisiciones tempPro6 = new Proposisiciones();
                             tempPro6.uno = "v";
                             tempPro6.dos = "f";
                             tempPro6.tres = "v";
                             tempPro6.cuatro = "f";
                             tempPro6.cinco = "v";
                             tempPro6.seis = "v";
                             tempPro6.siete = "v";
                             tablasuma2.Items.Add(tempPro6);
                             Proposisiciones tempPro7 = new Proposisiciones();
                             tempPro7.uno = "f";
                             tempPro7.dos = "v";
                             tempPro7.tres = "f";
                             tempPro7.cuatro = "v";
                             tempPro7.cinco = "f";
                             tempPro7.seis = "v";
                             tempPro7.siete = "v";
                             tablasuma2.Items.Add(tempPro7);
                             Proposisiciones tempPro8 = new Proposisiciones();
                             tempPro8.uno = "v";
                             tempPro8.dos = "f";
                             tempPro8.tres = "f";
                             tempPro8.cuatro = "f";
                             tempPro8.cinco = "v";
                             tempPro8.seis = "v";
                             tempPro8.siete = "v";
                             tablasuma2.Items.Add(tempPro8);
                             Proposisiciones tempPro9 = new Proposisiciones();
                             tempPro9.uno = "f";
                             tempPro9.dos = "v";
                             tempPro9.tres = "v";
                             tempPro9.cuatro = "v";
                             tempPro9.cinco = "f";
                             tempPro9.seis = "v";
                             tempPro9.siete = "v";
                             tablasuma2.Items.Add(tempPro9);
                             resoluciondeteorema.Text = resoluciondeteorema.Text + "el teorema es falso";
                         }
                         if (prop4.SelectedIndex == 0 || prop4.SelectedIndex == 1 || prop4.SelectedIndex == 2 || prop4.SelectedIndex == 3)
                         {
                             Proposisiciones tempPro2 = new Proposisiciones();
                             tempPro2.uno = "v";
                             tempPro2.dos = "v";
                             tempPro2.tres = "v";
                             tempPro2.cuatro = "f";
                             tempPro2.cinco = "f";
                             tempPro2.seis = "f";
                             tempPro2.siete = "hola";
                             tablasuma2.Items.Add(tempPro2);
                             Proposisiciones tempPro3 = new Proposisiciones();
                             tempPro3.uno = "f";
                             tempPro3.dos = "f";
                             tempPro3.tres = "f";
                             tempPro3.cuatro = "v";
                             tempPro3.cinco = "v";
                             tempPro3.seis = "v";
                             tempPro3.siete = "f";
                             tablasuma2.Items.Add(tempPro3);
                             Proposisiciones tempPro4 = new Proposisiciones();
                             tempPro4.uno = "v";
                             tempPro4.dos = "v";
                             tempPro4.tres = "f";
                             tempPro4.cuatro = "f";
                             tempPro4.cinco = "f";
                             tempPro4.seis = "f";
                             tempPro4.siete = "v";
                             tablasuma2.Items.Add(tempPro4);
                             Proposisiciones tempPro5 = new Proposisiciones();
                             tempPro5.uno = "f";
                             tempPro5.dos = "f";
                             tempPro5.tres = "v";
                             tempPro5.cuatro = "v";
                             tempPro5.cinco = "v";
                             tempPro5.seis = "v";
                             tempPro5.siete = "v";
                             tablasuma2.Items.Add(tempPro5);
                             Proposisiciones tempPro6 = new Proposisiciones();
                             tempPro6.uno = "v";
                             tempPro6.dos = "f";
                             tempPro6.tres = "v";
                             tempPro6.cuatro = "f";
                             tempPro6.cinco = "v";
                             tempPro6.seis = "v";
                             tempPro6.siete = "v";
                             tablasuma2.Items.Add(tempPro6);
                             Proposisiciones tempPro7 = new Proposisiciones();
                             tempPro7.uno = "f";
                             tempPro7.dos = "v";
                             tempPro7.tres = "f";
                             tempPro7.cuatro = "v";
                             tempPro7.cinco = "f";
                             tempPro7.seis = "v";
                             tempPro7.siete = "v";
                             tablasuma2.Items.Add(tempPro7);
                             Proposisiciones tempPro8 = new Proposisiciones();
                             tempPro8.uno = "v";
                             tempPro8.dos = "f";
                             tempPro8.tres = "f";
                             tempPro8.cuatro = "f";
                             tempPro8.cinco = "v";
                             tempPro8.seis = "v";
                             tempPro8.siete = "v";
                             tablasuma2.Items.Add(tempPro8);
                             Proposisiciones tempPro9 = new Proposisiciones();
                             tempPro9.uno = "f";
                             tempPro9.dos = "v";
                             tempPro9.tres = "v";
                             tempPro9.cuatro = "v";
                             tempPro9.cinco = "f";
                             tempPro9.seis = "v";
                             tempPro9.siete = "v";
                             tablasuma2.Items.Add(tempPro9);
                             resoluciondeteorema.Text = resoluciondeteorema.Text + "el teorema es falso";
                         }
                     }
                     if (prop2.SelectedIndex == prop3.SelectedIndex ||  prop2.SelectedIndex ==  prop4.SelectedIndex )
                     {
                         Proposisiciones tempPro2 = new Proposisiciones();
                         tempPro2.uno = "v";
                         tempPro2.dos = "v";
                         tempPro2.tres = "v";
                         tempPro2.cuatro = "f";
                         tempPro2.cinco = "f";
                         tempPro2.seis = "f";
                         tempPro2.siete = "v";
                         tablasuma2.Items.Add(tempPro2);
                         Proposisiciones tempPro3 = new Proposisiciones();
                         tempPro3.uno = "f";
                         tempPro3.dos = "f";
                         tempPro3.tres = "f";
                         tempPro3.cuatro = "v";
                         tempPro3.cinco = "v";
                         tempPro3.seis = "v";
                         tempPro3.siete = "f";
                         tablasuma2.Items.Add(tempPro3);
                         Proposisiciones tempPro4 = new Proposisiciones();
                         tempPro4.uno = "v";
                         tempPro4.dos = "v";
                         tempPro4.tres = "f";
                         tempPro4.cuatro = "f";
                         tempPro4.cinco = "f";
                         tempPro4.seis = "f";
                         tempPro4.siete = "v";
                         tablasuma2.Items.Add(tempPro4);
                         Proposisiciones tempPro5 = new Proposisiciones();
                         tempPro5.uno = "f";
                         tempPro5.dos = "f";
                         tempPro5.tres = "v";
                         tempPro5.cuatro = "v";
                         tempPro5.cinco = "v";
                         tempPro5.seis = "v";
                         tempPro5.siete = "v";
                         tablasuma2.Items.Add(tempPro5);
                         Proposisiciones tempPro6 = new Proposisiciones();
                         tempPro6.uno = "v";
                         tempPro6.dos = "f";
                         tempPro6.tres = "v";
                         tempPro6.cuatro = "f";
                         tempPro6.cinco = "v";
                         tempPro6.seis = "v";
                         tempPro6.siete = "v";
                         tablasuma2.Items.Add(tempPro6);
                         Proposisiciones tempPro7 = new Proposisiciones();
                         tempPro7.uno = "f";
                         tempPro7.dos = "v";
                         tempPro7.tres = "f";
                         tempPro7.cuatro = "v";
                         tempPro7.cinco = "f";
                         tempPro7.seis = "v";
                         tempPro7.siete = "v";
                         tablasuma2.Items.Add(tempPro7);
                         Proposisiciones tempPro8 = new Proposisiciones();
                         tempPro8.uno = "v";
                         tempPro8.dos = "f";
                         tempPro8.tres = "f";
                         tempPro8.cuatro = "f";
                         tempPro8.cinco = "v";
                         tempPro8.seis = "v";
                         tempPro8.siete = "f";
                         tablasuma2.Items.Add(tempPro8);
                         Proposisiciones tempPro9 = new Proposisiciones();
                         tempPro9.uno = "f";
                         tempPro9.dos = "v";
                         tempPro9.tres = "v";
                         tempPro9.cuatro = "v";
                         tempPro9.cinco = "f";
                         tempPro9.seis = "v";
                         tempPro9.siete = "v";
                         tablasuma2.Items.Add(tempPro9);
                         resoluciondeteorema.Text = resoluciondeteorema.Text + "el teorema es falso";
                     }*/
                }

            }



            prop1.SelectedIndex = -1;
            prop2.SelectedIndex = -1;
            prop3.SelectedIndex = -1;
            prop4.SelectedIndex = -1;
            signo.SelectedIndex = -1;
            signo2.SelectedIndex = -1;
            ver.Text = "";
            ver_Copy.Text = "";
            ver_Copy1.Text = "";
            ver_Copy2.Text = "";
            ver_Copy3.Text = "";
            ver_Copy4.Text = "";
            ver_Copy5.Text = "";
            resultado1.Text="";
            resultado2.Text = "";
            resultado3.Text = "";
            
           

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ver_Copy2.Text = ver_Copy2.Text + "<=>";
        }

       

        private void prop3_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (prop3.SelectedIndex)
            {
                case 0:
                    ver_Copy3.Text = ver_Copy3.Text + "p";
                    ver_Copy2.Text = ver_Copy2.Text + "p";
                    resultado2.Text = resultado2.Text + "p";

                    break;
                case 1:
                    ver_Copy3.Text = ver_Copy3.Text + "q";
                    ver_Copy2.Text = ver_Copy2.Text + "q";
                    resultado2.Text = resultado2.Text + "q";

                    break;
                case 2:
                    ver_Copy3.Text = ver_Copy3.Text + "r";
                    ver_Copy2.Text = ver_Copy2.Text + "r";
                    resultado2.Text = resultado2.Text + "r";

                    break;
                case 3:
                    ver_Copy3.Text = ver_Copy3.Text + "s";
                    ver_Copy2.Text = ver_Copy2.Text + "s";
                    resultado2.Text = resultado2.Text + "s";

                    break;

                case 4:
                    ver_Copy3.Text = ver_Copy3.Text + "-p";
                    ver_Copy2.Text = ver_Copy2.Text + "-p";
                    resultado2.Text = resultado2.Text + "-p";
                    break;
                case 5:
                    ver_Copy3.Text = ver_Copy3.Text + "-q";
                    ver_Copy.Text = ver.Text + "-q";
                    resultado2.Text = resultado2.Text + "-q";
                    break;
                case 6:
                    ver_Copy3.Text = ver_Copy3.Text + "-r";
                    ver_Copy.Text = ver.Text + "-r";
                    resultado2.Text = resultado2.Text + "-r";
                    break;
                case 7:
                    ver_Copy3.Text = ver_Copy3.Text + "-s";
                    ver_Copy.Text = ver.Text + "-s";
                    resultado2.Text = resultado2.Text + "-s";
                    break;
            }
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if (negativo2.IsChecked == true)
            {
                prop1.Items.Add("-p");
                prop1.Items.Add("-q");
                prop1.Items.Add("-r");
                prop1.Items.Add("-s");
                prop2.Items.Add("-p");
                prop2.Items.Add("-q");
                prop2.Items.Add("-r");
                prop2.Items.Add("-s");

            }
            else if (negativo2.IsChecked == false)
            {
                prop1.Items.Refresh();
                prop1.Items.Remove("-p");
                prop1.Items.Remove("-q");
                prop1.Items.Remove("-r");
                prop1.Items.Remove("-s");
                prop2.Items.Remove("-p");
                prop2.Items.Remove("-q");
                prop2.Items.Remove("-r");
                prop2.Items.Remove("-s");
            }
        }

        private void prop4_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (prop4.SelectedIndex)
            {
                case 0:
                    ver_Copy5.Text = ver_Copy5.Text + "p";
                    ver_Copy2.Text = ver_Copy2.Text + "p";
                    resultado2.Text = resultado2.Text + "p";

                    break;
                case 1:
                    ver_Copy5.Text = ver_Copy5.Text + "q";
                    ver_Copy2.Text = ver_Copy2.Text + "q";
                    resultado2.Text = resultado2.Text + "q";

                    break;
                case 2:
                    ver_Copy5.Text = ver_Copy5.Text + "r";
                    ver_Copy2.Text = ver_Copy2.Text + "r";
                    resultado2.Text = resultado2.Text + "r";

                    break;
                case 3:
                    ver_Copy5.Text = ver_Copy5.Text + "s";
                    ver_Copy2.Text = ver_Copy2.Text + "s";
                    resultado2.Text = resultado2.Text + "s";

                    break;

                case 4:
                    ver_Copy5.Text = ver_Copy5.Text + "-p";
                    ver_Copy2.Text = ver_Copy2.Text + "-p";
                    resultado2.Text = resultado2.Text + "-p";
                    break;
                case 5:
                    ver_Copy2.Text = ver_Copy2.Text + "-q";
                    ver_Copy5.Text = ver_Copy5.Text + "-q";
                    resultado2.Text = resultado2.Text + "-q";
                    break;
                case 6:
                    ver_Copy2.Text = ver_Copy2.Text + "-r";
                    ver_Copy5.Text = ver_Copy5.Text + "-r";
                    resultado2.Text = resultado2.Text + "-r";
                    break;
                case 7:
                    ver_Copy2.Text = ver_Copy2.Text + "-s";
                    ver_Copy5.Text = ver_Copy5.Text + "-s";
                    resultado2.Text = resultado2.Text + "-s";
                    break;
            }
        }

        private void signo2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (signo2.SelectedIndex)
            {
                case 0:

                    ver_Copy2.Text = ver_Copy2.Text + "+";
                    resultado2.Text = resultado2.Text + "+";

                    break;
                case 1:

                    ver_Copy2.Text = ver_Copy2.Text + "*";
                    resultado2.Text = resultado2.Text + "*";

                    break;
               
            }
        }

        private void Prop31_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (prop31.SelectedIndex)
            {
                case 0:
                    ver_Copy3.Text = ver_Copy3.Text + "p";
                    ver_Copy2.Text = ver_Copy2.Text + "p";
                    resultado3.Text = resultado3.Text + "p";

                    break;
                case 1:
                    ver_Copy3.Text = ver_Copy3.Text + "q";
                    ver_Copy2.Text = ver_Copy2.Text + "q";
                    resultado3.Text = resultado3.Text + "q";

                    break;
                case 2:
                    ver_Copy3.Text = ver_Copy3.Text + "r";
                    ver_Copy2.Text = ver_Copy2.Text + "r";
                    resultado3.Text = resultado3.Text + "r";

                    break;
                case 3:
                    ver_Copy3.Text = ver_Copy3.Text + "s";
                    ver_Copy2.Text = ver_Copy2.Text + "s";
                    resultado3.Text = resultado3.Text + "s";

                    break;

                case 4:
                    ver_Copy3.Text = ver_Copy3.Text + "-p";
                    ver_Copy2.Text = ver_Copy2.Text + "-p";
                    resultado3.Text = resultado3.Text + "-p";
                    break;
                case 5:
                    ver_Copy3.Text = ver_Copy3.Text + "-q";
                    ver_Copy.Text = ver.Text + "-q";
                    resultado3.Text = resultado3.Text + "-q";
                    break;
                case 6:
                    ver_Copy3.Text = ver_Copy3.Text + "-r";
                    ver_Copy.Text = ver.Text + "-r";
                    resultado3.Text = resultado3.Text + "-r";
                    break;
                case 7:
                    ver_Copy3.Text = ver_Copy3.Text + "-s";
                    ver_Copy.Text = ver.Text + "-s";
                    resultado3.Text = resultado3.Text + "-s";
                    break;
            }
        }

        private void Prop41_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (prop41.SelectedIndex)
            {
                case 0:
                    ver_Copy5.Text = ver_Copy5.Text + "p";
                    ver_Copy2.Text = ver_Copy2.Text + "p";
                    resultado2.Text = resultado2.Text + "p";

                    break;
                case 1:
                    ver_Copy5.Text = ver_Copy5.Text + "q";
                    ver_Copy2.Text = ver_Copy2.Text + "q";
                    resultado2.Text = resultado2.Text + "q";

                    break;
                case 2:
                    ver_Copy5.Text = ver_Copy5.Text + "r";
                    ver_Copy2.Text = ver_Copy2.Text + "r";
                    resultado2.Text = resultado2.Text + "r";

                    break;
                case 3:
                    ver_Copy5.Text = ver_Copy5.Text + "s";
                    ver_Copy2.Text = ver_Copy2.Text + "s";
                    resultado2.Text = resultado2.Text + "s";

                    break;

                case 4:
                    ver_Copy5.Text = ver_Copy5.Text + "-p";
                    ver_Copy2.Text = ver_Copy2.Text + "-p";
                    resultado2.Text = resultado2.Text + "-p";
                    break;
                case 5:
                    ver_Copy2.Text = ver_Copy2.Text + "-q";
                    ver_Copy5.Text = ver_Copy5.Text + "-q";
                    resultado2.Text = resultado2.Text + "-q";
                    break;
                case 6:
                    ver_Copy2.Text = ver_Copy2.Text + "-r";
                    ver_Copy5.Text = ver_Copy5.Text + "-r";
                    resultado2.Text = resultado2.Text + "-r";
                    break;
                case 7:
                    ver_Copy2.Text = ver_Copy2.Text + "-s";
                    ver_Copy5.Text = ver_Copy5.Text + "-s";
                    resultado2.Text = resultado2.Text + "-s";
                    break;
            }
        }

        private void Signo22_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (signo22.SelectedIndex)
            {
                case 0:

                    ver_Copy2.Text = ver_Copy2.Text + "+";
                    resultado2.Text = resultado2.Text + "+";

                    break;
                case 1:

                    ver_Copy2.Text = ver_Copy2.Text + "*";
                    resultado2.Text = resultado2.Text + "*";

                    break;

            }
        }

        private void Negativo_Checked(object sender, RoutedEventArgs e)
        {
            prop1.Items.Add("-p");
            prop1.Items.Add("-q");
            prop1.Items.Add("-r");
            prop1.Items.Add("-s");
            prop2.Items.Add("-p");
            prop2.Items.Add("-q");
            prop2.Items.Add("-r");
            prop2.Items.Add("-s");
            prop3.Items.Add("-p");
            prop3.Items.Add("-q");
            prop3.Items.Add("-r");
            prop3.Items.Add("-s");
            prop4.Items.Add("-p");
            prop4.Items.Add("-q");
            prop4.Items.Add("-r");
            prop4.Items.Add("-s");
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            prop1.Items.Refresh();
            prop1.Items.Remove("-p");
            prop1.Items.Remove("-q");
            prop1.Items.Remove("-r");
            prop1.Items.Remove("-s");
            prop2.Items.Remove("-p");
            prop2.Items.Remove("-q");
            prop2.Items.Remove("-r");
            prop2.Items.Remove("-s");
            prop3.Items.Remove("-p");
            prop3.Items.Remove("-q");
            prop3.Items.Remove("-r");
            prop3.Items.Remove("-s");
            prop4.Items.Remove("-p");
            prop4.Items.Remove("-q");
            prop4.Items.Remove("-r");
            prop4.Items.Remove("-s");
        }
    }
}
