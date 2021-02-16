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
using System.Threading;

namespace AutostradeSimulator
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            attesaDx = 0;
            attesaSx = 0;
        }

        int attesaDx, attesaSx;
        Random r = new Random();
        bool bloccoDx, bloccoSx;
        object contatoreDx = new object();
        object contatoreSx = new object();

        public void ArrivanoLeMacchine()
        {
            int turno;

            bloccoDx = false;
            bloccoSx = false;

            while(!bloccoDx && !bloccoSx)
            {
                turno = r.Next(1, 3);
                if(turno == 1 && !bloccoDx)
                {
                    lock (contatoreDx)
                    {
                        attesaDx++;
                    }
                }
                else if(turno == 2 && !bloccoSx)
                {
                    lock (contatoreSx)
                    {
                        attesaSx++;
                    }
                }
            }
        }

        public void MovimentoDx()
        {

        }
    }
}
