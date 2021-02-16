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

            NascondiLeMacchine();

            //Thread arrivo = new Thread(new ThreadStart(ArrivanoLeMacchine));
            //arrivo.Start();
        }

        public void NascondiLeMacchine()
        {
            imgDx1.Visibility = Visibility.Hidden;
            imgDx2.Visibility = Visibility.Hidden;
            imgDx3.Visibility = Visibility.Hidden;
            imgDx4.Visibility = Visibility.Hidden;
            imgDx5.Visibility = Visibility.Hidden;
            imgDx6.Visibility = Visibility.Hidden;
            imgDx7.Visibility = Visibility.Hidden;
            imgDx8.Visibility = Visibility.Hidden;
            imgDx9.Visibility = Visibility.Hidden;
            imgDx10.Visibility = Visibility.Hidden;

            imgSx1.Visibility = Visibility.Hidden;
            imgSx2.Visibility = Visibility.Hidden;
            imgSx3.Visibility = Visibility.Hidden;
            imgSx4.Visibility = Visibility.Hidden;
            imgSx5.Visibility = Visibility.Hidden;
            imgSx6.Visibility = Visibility.Hidden;
            imgSx7.Visibility = Visibility.Hidden;
            imgSx8.Visibility = Visibility.Hidden;
            imgSx9.Visibility = Visibility.Hidden;
            imgSx10.Visibility = Visibility.Hidden;
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
                Thread.Sleep(TimeSpan.FromSeconds(r.Next(5, 21)));
                turno = r.Next(1, 3);
                if(turno == 1 && !bloccoDx && attesaDx < 10)
                {
                    lock (contatoreDx)
                    {
                        attesaDx++;
                    }
                }
                else if(turno == 2 && !bloccoSx && attesaSx < 10)
                {
                    lock (contatoreSx)
                    {
                        attesaSx++;
                    }
                }
            }
        }

        public void MDx1()
        {
            MovimentoDx(imgDx1);
        }

        public void MDx2()
        {
            MovimentoDx(imgDx2);
        }
        public void MDx3()
        {
            MovimentoDx(imgDx3);
        }
        public void MDx4()
        {
            MovimentoDx(imgDx4);
        }
        public void MDx5()
        {
            MovimentoDx(imgDx5);
        }
        public void MDx6()
        {
            MovimentoDx(imgDx6);
        }
        public void MDx7()
        {
            MovimentoDx(imgDx7);
        }
        public void MDx8()
        {
            MovimentoDx(imgDx8);
        }
        public void MDx9()
        {
            MovimentoDx(imgDx9);
        }
        public void MDx10()
        {
            MovimentoDx(imgDx10);
        }

        public void MovimentoDx(Image macchinaDx)
        {
            this.Dispatcher.BeginInvoke(new Action(() =>
            {
                macchinaDx.Visibility = Visibility.Visible;
            }));
            int nuovoMargine = 627;
            while(nuovoMargine > 86)
            {
                Thread.Sleep(TimeSpan.FromMilliseconds(3));
                nuovoMargine -= 1;
                this.Dispatcher.BeginInvoke(new Action(() =>
                {
                    macchinaDx.Margin = new Thickness(nuovoMargine, 136, 0, 0);
                }));
            }
            this.Dispatcher.BeginInvoke(new Action(() =>
            {
                macchinaDx.Visibility = Visibility.Hidden;
            }));
        }

        public void MovimentoSx(Image macchinaSx)
        {
            int nuovoMargine = 171;

            Thread.Sleep(TimeSpan.FromMilliseconds(3));

            this.Dispatcher.BeginInvoke(new Action(() =>
            {

                macchinaSx.Margin = new Thickness(171, 136, 0, 0);

            }));


            while (nuovoMargine < 475)
            {
                Thread.Sleep(TimeSpan.FromMilliseconds(3));
                nuovoMargine += 1;
                this.Dispatcher.BeginInvoke(new Action(() =>
                {

                    macchinaSx.Margin = new Thickness(nuovoMargine, 136, 0, 0);

                }));
            }

            Thread.Sleep(TimeSpan.FromMilliseconds(3));
            this.Dispatcher.BeginInvoke(new Action(() =>
            {

                macchinaSx.Margin = new Thickness(627, 238, 0, 0);

            }));
        }

        public void GestionePonte()
        {

        }
    }
}
