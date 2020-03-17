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
    /// Lógica de interacción para Dos.xaml
    /// </summary>
    public partial class Dos : Window
    {
        string proposiciona;
        string proposicionb;
        string proposicionc;

        string operacion;
        public Dos()
        {
            InitializeComponent();
            proposiciona = "p";
            proposicionb = "q";

        }

        private void P_Click(object sender, RoutedEventArgs e)
        {
            resultado.Text = resultado.Text + "p";
            proposiciona = "p";

        }

        private void Q_Click(object sender, RoutedEventArgs e)
        {
            resultado.Text = resultado.Text +  "q";
            proposicionb = "q";
        }

        private void Suma_Click(object sender, RoutedEventArgs e)
        {
            resultado.Text = resultado.Text + "+";
            operacion = "+";
          
            
        }

        private void R_Click(object sender, RoutedEventArgs e)
        {
            resultado.Text = resultado.Text +  "r";
            proposicionc = "r";
        }
        public class Proposisiciones
        {
            public string uno { get; set; }
            public string dos { get; set; }
            public string tres { get; set; }
            public string cuatro { get; set; }

            public string proposiciona;
            public string proposicionb;
            



        }

        private void Igual_Click(object sender, RoutedEventArgs e)
        {
            

            switch(operacion)
            {
                case "+":
            


                    if (resultado.Text == proposiciona + proposicionb)
                    {
                        tablasuma1.Items.Clear();

                        Proposisiciones tempPro = new Proposisiciones();
                        tempPro.uno = proposiciona;
                        tempPro.dos = proposicionb;
                        tempPro.tres = resultado.Text;
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
                    break;
            }
        }

    }
}
