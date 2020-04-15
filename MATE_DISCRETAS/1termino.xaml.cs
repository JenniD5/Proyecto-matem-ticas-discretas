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
    /// Lógica de interacción para _1termino.xaml
    /// </summary>
    public partial class _1termino : UserControl
    {
        public _1termino()
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
                case 4:
                    ver.Text = ver.Text + "-p";
                    ver_Copy2.Text = ver_Copy2.Text + "-p";
                    ver_Copy1.Text = ver_Copy1.Text = "-p";
                    break;
                case 5:
                    ver_Copy2.Text = ver_Copy2.Text + "-q";
                    ver.Text = ver.Text + "-q";
                    break;
                case 6:
                    ver_Copy2.Text = ver_Copy2.Text + "-r";
                    ver.Text = ver.Text + "-r";
                    break;
                case 7:
                    ver_Copy2.Text = ver_Copy2.Text + "-s";
                    ver.Text = ver.Text + "-r";
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

                case 4:
                    ver_Copy.Text = ver.Text + "-p";
                    ver_Copy2.Text = ver_Copy2.Text + "-p";
                    break;
                case 5:
                    ver_Copy2.Text = ver_Copy2.Text + "-q";
                    ver_Copy.Text = ver.Text + "-q";
                    break;
                case 6:
                    ver_Copy2.Text = ver_Copy2.Text + "-r";
                    ver_Copy.Text = ver.Text + "-r";
                    break;
                case 7:
                    ver_Copy2.Text = ver_Copy2.Text + "-s";
                    ver_Copy.Text = ver.Text + "-r";
                    break;
            }
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

            else if(ver_Copy2.Text == "-q" | ver_Copy2.Text == "-p" | ver_Copy2.Text == "-r" |
               ver_Copy2.Text == "-s")
            {
                negativo1.Items.Clear();
                tablasuma1.Visibility = Visibility.Hidden;
                negativo1.Visibility = Visibility.Visible;

                Proposisiciones tempPro = new Proposisiciones();
                
                if (ver_Copy2.Text=="-p")
                {
                    tempPro.uno = "p";
                }
                else if (ver_Copy2.Text == "-q")
                {
                    tempPro.uno = "q";
                }
                else if (ver_Copy2.Text == "-r")
                {
                    tempPro.uno = "r";
                }
                else if (ver_Copy2.Text == "-s")
                {
                    tempPro.uno = "s";
                }
                tempPro.dos = ver_Copy2.Text;
                negativo1.Items.Add(tempPro);
                Proposisiciones tempPro2 = new Proposisiciones();
                tempPro2.uno = "v";
                tempPro2.dos = "f";
                
                negativo1.Items.Add(tempPro2);
                Proposisiciones tempPro3 = new Proposisiciones();
                tempPro3.uno = "f";
                tempPro3.dos = "v";
                negativo1.Items.Add(tempPro3);
            }

            else if (ver_Copy2.Text == "-q*p" | ver_Copy2.Text == "-q*r" | ver_Copy2.Text == "-q*s" |
              ver_Copy2.Text == "-p*q" | ver_Copy2.Text == "-p*r" | ver_Copy2.Text == "-p*s" |
              ver_Copy2.Text == "-r*q" | ver_Copy2.Text == "-r*q" | ver_Copy2.Text == "-r*s" |
              ver_Copy2.Text == "-s*q" | ver_Copy2.Text == "-s*q" | ver_Copy2.Text == "-s*r")
            {
                negativo2terminos.Items.Clear();
                tablasuma1.Visibility = Visibility.Hidden;
                negativo1.Visibility = Visibility.Hidden;
                negativo2terminos.Visibility = Visibility.Visible;


                Proposisiciones tempPro = new Proposisiciones();

                tempPro.dos = prop2.Text;
                

                if (ver.Text == "-p")
                {
                    tempPro.uno = "p";
                    tempPro.tres = "-p";
                }
                else if (ver.Text == "-q")
                {
                    tempPro.uno = "q";
                    tempPro.tres = "-q";
                }
                else if (ver.Text == "-r")
                {
                    tempPro.uno = "r";
                    tempPro.tres = "-r";
                }
                else if (ver.Text == "-s")
                {
                    tempPro.uno = "s";
                    tempPro.tres = "-s";
                }
                tempPro.cuatro = ver_Copy2.Text;
                
                negativo2terminos.Items.Add(tempPro);

                Proposisiciones tempPro2 = new Proposisiciones();
                tempPro2.uno = "v";
                tempPro2.dos = "v";
                tempPro2.tres = "f";
                tempPro2.cuatro = "f";
                negativo2terminos.Items.Add(tempPro2);
                Proposisiciones tempPro3 = new Proposisiciones();
                tempPro3.uno = "f";
                tempPro3.dos = "f";
                tempPro3.tres = "v";
                tempPro3.cuatro = "f";
                negativo2terminos.Items.Add(tempPro3);
                Proposisiciones tempPro4 = new Proposisiciones();
                tempPro4.uno = "v";
                tempPro4.dos = "f";
                tempPro4.tres = "f";
                tempPro4.cuatro = "f";
                negativo2terminos.Items.Add(tempPro4);
                Proposisiciones tempPro5 = new Proposisiciones();
                tempPro5.uno = "f";
                tempPro5.dos = "v";
                tempPro5.tres = "v";
                tempPro5.cuatro = "v";
                negativo2terminos.Items.Add(tempPro5);

            }
           else if (ver_Copy2.Text == "q*-p" | ver_Copy2.Text == "q*-r" | ver_Copy2.Text == "q*-s" |
             ver_Copy2.Text == "p*-q" | ver_Copy2.Text == "p*-r" | ver_Copy2.Text == "p*-s" |
             ver_Copy2.Text == "r*-q" | ver_Copy2.Text == "r*-q" | ver_Copy2.Text == "r*-s" |
             ver_Copy2.Text == "s*-q" | ver_Copy2.Text == "s*-q" | ver_Copy2.Text == "s*-r")
            {
                negativo2terminos.Items.Clear();
                tablasuma1.Visibility = Visibility.Hidden;
                negativo1.Visibility = Visibility.Hidden;
                negativo2terminos.Visibility = Visibility.Visible;


                Proposisiciones tempPro = new Proposisiciones();

                tempPro.uno = prop1.Text;


                if (prop2.SelectedIndex == 4)
                {
                    tempPro.dos = "p";
                    tempPro.tres = "-p";
                }
                if (prop2.SelectedIndex == 5)
                {
                    tempPro.dos = "q";
                    tempPro.tres = "-q";
                }
                if (prop2.SelectedIndex == 6)
                {
                    tempPro.dos = "r";
                    tempPro.tres = "-r";
                }
                if (prop2.SelectedIndex == 7)
                {
                    tempPro.dos = "s";
                    tempPro.tres = "-s";
                }
                
                tempPro.cuatro = ver_Copy2.Text;

                negativo2terminos.Items.Add(tempPro);

                Proposisiciones tempPro2 = new Proposisiciones();
                tempPro2.uno = "v";
                tempPro2.dos = "v";
                tempPro2.tres = "f";
                tempPro2.cuatro = "f";
                negativo2terminos.Items.Add(tempPro2);
                Proposisiciones tempPro3 = new Proposisiciones();
                tempPro3.uno = "f";
                tempPro3.dos = "f";
                tempPro3.tres = "v";
                tempPro3.cuatro = "f";
                negativo2terminos.Items.Add(tempPro3);
                Proposisiciones tempPro4 = new Proposisiciones();
                tempPro4.uno = "v";
                tempPro4.dos = "f";
                tempPro4.tres = "f";
                tempPro4.cuatro = "f";
                negativo2terminos.Items.Add(tempPro4);
                Proposisiciones tempPro5 = new Proposisiciones();
                tempPro5.uno = "f";
                tempPro5.dos = "v";
                tempPro5.tres = "v";
                tempPro5.cuatro = "v";
                negativo2terminos.Items.Add(tempPro5);

            }
            else if (ver_Copy2.Text == "-q*-p" | ver_Copy2.Text == "-q*-r" | ver_Copy2.Text == "-q*-s" |
             ver_Copy2.Text == "-p*-q" | ver_Copy2.Text == "-p*-r" | ver_Copy2.Text == "-p*-s" |
             ver_Copy2.Text == "-r*-q" | ver_Copy2.Text == "-r*-q" | ver_Copy2.Text == "-r*-s" |
             ver_Copy2.Text == "-s*-q" | ver_Copy2.Text == "-s*-q" | ver_Copy2.Text == "-s*-r")
            {
                negativo2terminos.Items.Clear();
                tablasuma1.Visibility = Visibility.Hidden;
                negativo1.Visibility = Visibility.Hidden;
                negativo2terminos.Visibility = Visibility.Visible;
                negativo2terminos2.Visibility = Visibility.Visible;
                negativo2terminos2.Items.Clear();


                Proposisiciones tempPro = new Proposisiciones();

                if (ver.Text == "-p")
                {
                    tempPro.uno = "p";
                    tempPro.tres = "-p";
                }
                else if (ver.Text == "-q")
                {
                    tempPro.uno = "q";
                    tempPro.tres = "-q";
                }
                else if (ver.Text == "-r")
                {
                    tempPro.uno = "r";
                    tempPro.tres = "-r";
                }
                else if (ver.Text == "-s")
                {
                    tempPro.uno = "s";
                    tempPro.tres = "-s";
                }
                                                                                                       
                 if (prop2.SelectedIndex == 4)
                {
                    tempPro.dos = "p";
                    tempPro.cuatro = "-p";
                }
                 if (prop2.SelectedIndex == 5)
                {
                    tempPro.dos = "q";
                    tempPro.cuatro = "-q";
                }
                 if (prop2.SelectedIndex == 6)
                {
                    tempPro.dos = "r";
                    tempPro.cuatro = "-r";
                }
                 if (prop2.SelectedIndex == 7)
                {
                    tempPro.dos = "s";
                    tempPro.cuatro = "-s";
                }

               
                tempPro.cinco = ver_Copy2.Text;

                negativo2terminos2.Items.Add(tempPro);

                Proposisiciones tempPro2 = new Proposisiciones();
                tempPro2.uno = "v";
                tempPro2.dos = "v";
                tempPro2.tres = "f";
                tempPro2.cuatro = "f";
                tempPro2.cinco = "f";
                negativo2terminos2.Items.Add(tempPro2);
                Proposisiciones tempPro3 = new Proposisiciones();
                tempPro3.uno = "f";
                tempPro3.dos = "f";
                tempPro3.tres = "v";
                tempPro3.cuatro = "v";
                tempPro3.cinco = "v";
                negativo2terminos2.Items.Add(tempPro3);
                Proposisiciones tempPro4 = new Proposisiciones();
                tempPro4.uno = "v";
                tempPro4.dos = "f";
                tempPro4.tres = "f";
                tempPro4.cuatro = "v";
                tempPro4.cinco = "f";
                negativo2terminos2.Items.Add(tempPro4);
                Proposisiciones tempPro5 = new Proposisiciones();
                tempPro5.uno = "f";
                tempPro5.dos = "v";
                tempPro5.tres = "v";
                tempPro5.cuatro = "f";
                tempPro5.cinco = "f";
                negativo2terminos2.Items.Add(tempPro5);

            }


                                                                                                           //sumas negativos 

            else if (ver_Copy2.Text == "-q+p" | ver_Copy2.Text == "-q+r" | ver_Copy2.Text == "-q+s" |
             ver_Copy2.Text == "-p+q" | ver_Copy2.Text == "-p+r" | ver_Copy2.Text == "-p+s" |
             ver_Copy2.Text == "-r+q" | ver_Copy2.Text == "-r+q" | ver_Copy2.Text == "-r+s" |
             ver_Copy2.Text == "-s+q" | ver_Copy2.Text == "-s+q" | ver_Copy2.Text == "-s+r")
            {
                negativo2terminos.Items.Clear();
                tablasuma1.Visibility = Visibility.Hidden;
                negativo1.Visibility = Visibility.Hidden;
                negativo2terminos.Visibility = Visibility.Visible;


                Proposisiciones tempPro = new Proposisiciones();

                tempPro.dos = prop2.Text;


                if (ver.Text == "-p")
                {
                    tempPro.uno = "p";
                    tempPro.tres = "-p";
                }
                else if (ver.Text == "-q")
                {
                    tempPro.uno = "q";
                    tempPro.tres = "-q";
                }
                else if (ver.Text == "-r")
                {
                    tempPro.uno = "r";
                    tempPro.tres = "-r";
                }
                else if (ver.Text == "-s")
                {
                    tempPro.uno = "s";
                    tempPro.tres = "-s";
                }
                tempPro.cuatro = ver_Copy2.Text;

                negativo2terminos.Items.Add(tempPro);

                Proposisiciones tempPro2 = new Proposisiciones();
                tempPro2.uno = "v";
                tempPro2.dos = "v";
                tempPro2.tres = "f";
                tempPro2.cuatro = "v";
                negativo2terminos.Items.Add(tempPro2);
                Proposisiciones tempPro3 = new Proposisiciones();
                tempPro3.uno = "f";
                tempPro3.dos = "f";
                tempPro3.tres = "v";
                tempPro3.cuatro = "v";
                negativo2terminos.Items.Add(tempPro3);
                Proposisiciones tempPro4 = new Proposisiciones();
                tempPro4.uno = "v";
                tempPro4.dos = "f";
                tempPro4.tres = "f";
                tempPro4.cuatro = "f";
                negativo2terminos.Items.Add(tempPro4);
                Proposisiciones tempPro5 = new Proposisiciones();
                tempPro5.uno = "f";
                tempPro5.dos = "v";
                tempPro5.tres = "v";
                tempPro5.cuatro = "v";
                negativo2terminos.Items.Add(tempPro5);

            }                                                                                              //syma negativo segunda proposicion
            else if (ver_Copy2.Text == "q+-p" | ver_Copy2.Text == "q+-r" | ver_Copy2.Text == "q+-s" |
              ver_Copy2.Text == "p+-q" | ver_Copy2.Text == "p+-r" | ver_Copy2.Text == "p+-s" |
              ver_Copy2.Text == "r+-q" | ver_Copy2.Text == "r+-q" | ver_Copy2.Text == "r+-s" |
              ver_Copy2.Text == "s+-q" | ver_Copy2.Text == "s+-q" | ver_Copy2.Text == "s+-r")
            {
                negativo2terminos.Items.Clear();
                tablasuma1.Visibility = Visibility.Hidden;
                negativo1.Visibility = Visibility.Hidden;
                negativo2terminos.Visibility = Visibility.Visible;


                Proposisiciones tempPro = new Proposisiciones();

                tempPro.uno = prop1.Text;


                if (prop2.SelectedIndex == 4)
                {
                    tempPro.dos = "p";
                    tempPro.tres = "-p";
                }
                if (prop2.SelectedIndex == 5)
                {
                    tempPro.dos = "q";
                    tempPro.tres = "-q";
                }
                if (prop2.SelectedIndex == 6)
                {
                    tempPro.dos = "r";
                    tempPro.tres = "-r";
                }
                if (prop2.SelectedIndex == 7)
                {
                    tempPro.dos = "s";
                    tempPro.tres = "-s";
                }

                tempPro.cuatro = ver_Copy2.Text;

                negativo2terminos.Items.Add(tempPro);

                Proposisiciones tempPro2 = new Proposisiciones();
                tempPro2.uno = "v";
                tempPro2.dos = "v";
                tempPro2.tres = "f";
                tempPro2.cuatro = "v";
                negativo2terminos.Items.Add(tempPro2);
                Proposisiciones tempPro3 = new Proposisiciones();
                tempPro3.uno = "f";
                tempPro3.dos = "f";
                tempPro3.tres = "v";
                tempPro3.cuatro = "v";
                negativo2terminos.Items.Add(tempPro3);
                Proposisiciones tempPro4 = new Proposisiciones();
                tempPro4.uno = "v";
                tempPro4.dos = "f";
                tempPro4.tres = "v";
                tempPro4.cuatro = "v";
                negativo2terminos.Items.Add(tempPro4);
                Proposisiciones tempPro5 = new Proposisiciones();
                tempPro5.uno = "f";
                tempPro5.dos = "v";
                tempPro5.tres = "f";
                tempPro5.cuatro = "f";
                negativo2terminos.Items.Add(tempPro5);

            }                                                                                                    //suma dos proposiciones negativas
            else if (ver_Copy2.Text == "-q+-p" | ver_Copy2.Text == "-q+-r" | ver_Copy2.Text == "-q+-s" |
             ver_Copy2.Text == "-p+-q" | ver_Copy2.Text == "-p+-r" | ver_Copy2.Text == "-p+-s" |
             ver_Copy2.Text == "-r+-q" | ver_Copy2.Text == "-r+-q" | ver_Copy2.Text == "-r+-s" |
             ver_Copy2.Text == "-s+-q" | ver_Copy2.Text == "-s+-q" | ver_Copy2.Text == "-s+-r")
            {
                negativo2terminos.Items.Clear();
                tablasuma1.Visibility = Visibility.Hidden;
                negativo1.Visibility = Visibility.Hidden;
                negativo2terminos.Visibility = Visibility.Visible;
                negativo2terminos2.Visibility = Visibility.Visible;
                negativo2terminos2.Items.Clear();


                Proposisiciones tempPro = new Proposisiciones();

                if (ver.Text == "-p")
                {
                    tempPro.uno = "p";
                    tempPro.tres = "-p";
                }
                else if (ver.Text == "-q")
                {
                    tempPro.uno = "q";
                    tempPro.tres = "-q";
                }
                else if (ver.Text == "-r")
                {
                    tempPro.uno = "r";
                    tempPro.tres = "-r";
                }
                else if (ver.Text == "-s")
                {
                    tempPro.uno = "s";
                    tempPro.tres = "-s";
                }

                if (prop2.SelectedIndex == 4)
                {
                    tempPro.dos = "p";
                    tempPro.cuatro = "-p";
                }
                if (prop2.SelectedIndex == 5)
                {
                    tempPro.dos = "q";
                    tempPro.cuatro = "-q";
                }
                if (prop2.SelectedIndex == 6)
                {
                    tempPro.dos = "r";
                    tempPro.cuatro = "-r";
                }
                if (prop2.SelectedIndex == 7)
                {
                    tempPro.dos = "s";
                    tempPro.cuatro = "-s";
                }


                tempPro.cinco = ver_Copy2.Text;

                negativo2terminos2.Items.Add(tempPro);

                Proposisiciones tempPro2 = new Proposisiciones();
                tempPro2.uno = "v";
                tempPro2.dos = "v";
                tempPro2.tres = "f";
                tempPro2.cuatro = "f";
                tempPro2.cinco = "f";
                negativo2terminos2.Items.Add(tempPro2);
                Proposisiciones tempPro3 = new Proposisiciones();
                tempPro3.uno = "f";
                tempPro3.dos = "f";
                tempPro3.tres = "v";
                tempPro3.cuatro = "v";
                tempPro3.cinco = "v";
                negativo2terminos2.Items.Add(tempPro3);
                Proposisiciones tempPro4 = new Proposisiciones();
                tempPro4.uno = "v";
                tempPro4.dos = "f";
                tempPro4.tres = "f";
                tempPro4.cuatro = "v";
                tempPro4.cinco = "v";
                negativo2terminos2.Items.Add(tempPro4);
                Proposisiciones tempPro5 = new Proposisiciones();
                tempPro5.uno = "f";
                tempPro5.dos = "v";
                tempPro5.tres = "v";
                tempPro5.cuatro = "f";
                tempPro5.cinco = "v";
                negativo2terminos2.Items.Add(tempPro5);

            }





            ver.Text = "";
            ver_Copy.Text = "";
            ver_Copy1.Text = "";
            ver_Copy2.Text = "";
            prop1.SelectedIndex = -1;
            prop2.SelectedIndex = -1;
            signo.SelectedIndex = -1;
        }

        

        private void Negativo2_Checked(object sender, RoutedEventArgs e)
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
                prop2.Items.Add("-p");
                prop2.Items.Add("-q");
                prop2.Items.Add("-r");
                prop2.Items.Add("-s");
            }

          
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
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

        private void Negativo1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

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
        }
    }
}
