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




            Thread arrivo = new Thread(new ThreadStart(ArrivanoLeMacchine));
            arrivo.Start();
            Thread gestionePonteDx = new Thread(new ThreadStart(GestionePonteDx));
            Thread gestionePonteSx = new Thread(new ThreadStart(GestionePonteSx));
            gestionePonteDx.Start();
            gestionePonteSx.Start();

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

            imgStopDx.Visibility = Visibility.Hidden;
            imgStopSx.Visibility = Visibility.Hidden;
        }

        int attesaDx, attesaSx;
        Random r = new Random();
        object contatoreDx = new object();
        object contatoreSx = new object();
        object ponte = new object();

        Thread carD1;
        Thread carD2;
        Thread carD3;
        Thread carD4;
        Thread carD5;
        Thread carD6;
        Thread carD7;
        Thread carD8;
        Thread carD9;
        Thread carD10;

        Thread carS1;
        Thread carS2;
        Thread carS3;
        Thread carS4;
        Thread carS5;
        Thread carS6;
        Thread carS7;
        Thread carS8;
        Thread carS9;
        Thread carS10;


        public void ArrivanoLeMacchine()
        {
            Thread.Sleep(TimeSpan.FromSeconds(3));

            while (true)
            {
                int turno;
                turno = r.Next(1, 3);
                if (turno == 1 && attesaDx < 10)
                {
                    lock (contatoreDx)
                    {
                        attesaDx++;
                    }
                }
                else if (turno == 2 && attesaSx < 10)
                {
                    lock (contatoreSx)
                    {
                        attesaSx++;
                    }
                }

                AggiornLbl();



                Thread.Sleep(TimeSpan.FromSeconds(r.Next(1,10)));
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

        public void MSx1()
        {
            MovimentoSx(imgSx1);
        }

        public void MSx2()
        {
            MovimentoSx(imgSx2);
        }
        public void MSx3()
        {
            MovimentoSx(imgSx3);
        }
        public void MSx4()
        {
            MovimentoSx(imgSx4);
        }
        public void MSx5()
        {
            MovimentoSx(imgSx5);
        }
        public void MSx6()
        {
            MovimentoSx(imgSx6);
        }
        public void MSx7()
        {
            MovimentoSx(imgSx7);
        }
        public void MSx8()
        {
            MovimentoSx(imgSx8);
        }
        public void MSx9()
        {
            MovimentoSx(imgSx9);
        }
        public void MSx10()
        {
            MovimentoSx(imgSx10);
        }

        public void MovimentoDx(Image macchinaDx)
        {
            this.Dispatcher.BeginInvoke(new Action(() =>
            {
                macchinaDx.Visibility = Visibility.Visible;
            }));
            int nuovoMargine = 745;
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
                macchinaDx.Margin = new Thickness(627, 136, 0, 0);
            }));
        }

        public void MovimentoSx(Image macchinaSx)
        {
            this.Dispatcher.BeginInvoke(new Action(() =>
            {
                macchinaSx.Visibility = Visibility.Visible;
            }));
            int nuovoMargine = 10;

            Thread.Sleep(TimeSpan.FromMilliseconds(3));

            this.Dispatcher.BeginInvoke(new Action(() =>
            {

                macchinaSx.Margin = new Thickness(10, 240, 0, 0);

            }));

            while (nuovoMargine < 113)
            {
                Thread.Sleep(TimeSpan.FromMilliseconds(3));
                nuovoMargine += 1;
                this.Dispatcher.BeginInvoke(new Action(() =>
                {

                    macchinaSx.Margin = new Thickness(nuovoMargine, 240, 0, 0);

                }));
            }

            nuovoMargine = 171;

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

                macchinaSx.Margin = new Thickness(526, 238, 0, 0);

            }));

            nuovoMargine = 526;

            while (nuovoMargine < 645)
            {
                Thread.Sleep(TimeSpan.FromMilliseconds(3));
                nuovoMargine += 1;
                this.Dispatcher.BeginInvoke(new Action(() =>
                {

                    macchinaSx.Margin = new Thickness(nuovoMargine, 238, 0, 0);

                }));
            }

            this.Dispatcher.BeginInvoke(new Action(() =>
            {
                macchinaSx.Visibility = Visibility.Hidden;
                macchinaSx.Margin = new Thickness(86, 240, 0, 0);
            }));
        }

        public void AggiornLbl()
        {
            this.Dispatcher.BeginInvoke(new Action(() =>
            {

                lblDx.Content = "In attesa: " + attesaDx;
                lblSx.Content = "In attesa: " + attesaSx;

            }));
        }

        public void GestionePonteDx()
        {
            while (true)
            {
                if (attesaDx > 0)
                {
                    lock (ponte)
                    {
                        lock (contatoreDx)
                        {
                            this.Dispatcher.BeginInvoke(new Action(() =>
                            {
                                imgStopSx.Visibility = Visibility.Visible;
                            }));


                            carD1 = new Thread(new ThreadStart(MDx1));
                            carD2 = new Thread(new ThreadStart(MDx2));
                            carD3 = new Thread(new ThreadStart(MDx3));
                            carD4 = new Thread(new ThreadStart(MDx4));
                            carD5 = new Thread(new ThreadStart(MDx5));
                            carD6 = new Thread(new ThreadStart(MDx6));
                            carD7 = new Thread(new ThreadStart(MDx7));
                            carD8 = new Thread(new ThreadStart(MDx8));
                            carD9 = new Thread(new ThreadStart(MDx9));
                            carD10 = new Thread(new ThreadStart(MDx10));
                            switch (attesaDx)
                            {
                                case 1:
                                    carD1.Start();
                                    carD1.Join();
                                    break;
                                case 2:
                                    carD1.Start();
                                    Thread.Sleep(TimeSpan.FromMilliseconds(r.Next(1000, 2000)));
                                    carD2.Start();
                                    carD1.Join();
                                    carD2.Join();
                                    break;
                                case 3:
                                    carD1.Start();
                                    Thread.Sleep(TimeSpan.FromMilliseconds(r.Next(1000, 2000)));
                                    carD2.Start();
                                    Thread.Sleep(TimeSpan.FromMilliseconds(r.Next(1000, 2000)));
                                    carD3.Start();
                                    carD1.Join();
                                    carD2.Join();
                                    carD3.Join();
                                    break;
                                case 4:
                                    carD1.Start();
                                    Thread.Sleep(TimeSpan.FromMilliseconds(r.Next(1000, 2000)));
                                    carD2.Start();
                                    Thread.Sleep(TimeSpan.FromMilliseconds(r.Next(1000, 2000)));
                                    carD3.Start();
                                    Thread.Sleep(TimeSpan.FromMilliseconds(r.Next(1000, 2000)));
                                    carD4.Start();
                                    carD1.Join();
                                    carD2.Join();
                                    carD3.Join();
                                    carD4.Join();
                                    break;
                                case 5:
                                    carD1.Start();
                                    Thread.Sleep(TimeSpan.FromMilliseconds(r.Next(1000, 2000)));
                                    carD2.Start();
                                    Thread.Sleep(TimeSpan.FromMilliseconds(r.Next(1000, 2000)));
                                    carD3.Start();
                                    Thread.Sleep(TimeSpan.FromMilliseconds(r.Next(1000, 2000)));
                                    carD4.Start();
                                    Thread.Sleep(TimeSpan.FromMilliseconds(r.Next(1000, 2000)));
                                    carD5.Start();
                                    carD1.Join();
                                    carD2.Join();
                                    carD3.Join();
                                    carD4.Join();
                                    carD5.Join();
                                    break;
                                case 6:
                                    carD1.Start();
                                    Thread.Sleep(TimeSpan.FromMilliseconds(r.Next(1000, 2000)));
                                    carD2.Start();
                                    Thread.Sleep(TimeSpan.FromMilliseconds(r.Next(1000, 2000)));
                                    carD3.Start();
                                    Thread.Sleep(TimeSpan.FromMilliseconds(r.Next(1000, 2000)));
                                    carD4.Start();
                                    Thread.Sleep(TimeSpan.FromMilliseconds(r.Next(1000, 2000)));
                                    carD5.Start();
                                    Thread.Sleep(TimeSpan.FromMilliseconds(r.Next(1000, 2000)));
                                    carD6.Start();
                                    carD1.Join();
                                    carD2.Join();
                                    carD3.Join();
                                    carD4.Join();
                                    carD5.Join();
                                    carD6.Join();
                                    break;
                                case 7:
                                    carD1.Start();
                                    Thread.Sleep(TimeSpan.FromMilliseconds(r.Next(1000, 2000)));
                                    carD2.Start();
                                    Thread.Sleep(TimeSpan.FromMilliseconds(r.Next(1000, 2000)));
                                    carD3.Start();
                                    Thread.Sleep(TimeSpan.FromMilliseconds(r.Next(1000, 2000)));
                                    carD4.Start();
                                    Thread.Sleep(TimeSpan.FromMilliseconds(r.Next(1000, 2000)));
                                    carD5.Start();
                                    Thread.Sleep(TimeSpan.FromMilliseconds(r.Next(1000, 2000)));
                                    carD6.Start();
                                    Thread.Sleep(TimeSpan.FromMilliseconds(r.Next(1000, 2000)));
                                    carD7.Start();
                                    carD1.Join();
                                    carD2.Join();
                                    carD3.Join();
                                    carD4.Join();
                                    carD5.Join();
                                    carD6.Join();
                                    carD7.Join();
                                    break;
                                case 8:
                                    carD1.Start();
                                    Thread.Sleep(TimeSpan.FromMilliseconds(r.Next(1000, 2000)));
                                    carD2.Start();
                                    Thread.Sleep(TimeSpan.FromMilliseconds(r.Next(1000, 2000)));
                                    carD3.Start();
                                    Thread.Sleep(TimeSpan.FromMilliseconds(r.Next(1000, 2000)));
                                    carD4.Start();
                                    Thread.Sleep(TimeSpan.FromMilliseconds(r.Next(1000, 2000)));
                                    carD5.Start();
                                    Thread.Sleep(TimeSpan.FromMilliseconds(r.Next(1000, 2000)));
                                    carD6.Start();
                                    Thread.Sleep(TimeSpan.FromMilliseconds(r.Next(1000, 2000)));
                                    carD7.Start();
                                    Thread.Sleep(TimeSpan.FromMilliseconds(r.Next(1000, 2000)));
                                    carD8.Start();
                                    carD1.Join();
                                    carD2.Join();
                                    carD3.Join();
                                    carD4.Join();
                                    carD5.Join();
                                    carD6.Join();
                                    carD7.Join();
                                    carD8.Join();
                                    break;
                                case 9:
                                    carD1.Start();
                                    Thread.Sleep(TimeSpan.FromMilliseconds(r.Next(1000, 2000)));
                                    carD2.Start();
                                    Thread.Sleep(TimeSpan.FromMilliseconds(r.Next(1000, 2000)));
                                    carD3.Start();
                                    Thread.Sleep(TimeSpan.FromMilliseconds(r.Next(1000, 2000)));
                                    carD4.Start();
                                    Thread.Sleep(TimeSpan.FromMilliseconds(r.Next(1000, 2000)));
                                    carD5.Start();
                                    Thread.Sleep(TimeSpan.FromMilliseconds(r.Next(1000, 2000)));
                                    carD6.Start();
                                    Thread.Sleep(TimeSpan.FromMilliseconds(r.Next(1000, 2000)));
                                    carD7.Start();
                                    Thread.Sleep(TimeSpan.FromMilliseconds(r.Next(1000, 2000)));
                                    carD8.Start();
                                    Thread.Sleep(TimeSpan.FromMilliseconds(r.Next(1000, 2000)));
                                    carD9.Start();
                                    carD1.Join();
                                    carD2.Join();
                                    carD3.Join();
                                    carD4.Join();
                                    carD5.Join();
                                    carD6.Join();
                                    carD7.Join();
                                    carD8.Join();
                                    carD9.Join();
                                    break;
                                case 10:
                                    carD1.Start();
                                    Thread.Sleep(TimeSpan.FromMilliseconds(r.Next(1000, 2000)));
                                    carD2.Start();
                                    Thread.Sleep(TimeSpan.FromMilliseconds(r.Next(1000, 2000)));
                                    carD3.Start();
                                    Thread.Sleep(TimeSpan.FromMilliseconds(r.Next(1000, 2000)));
                                    carD4.Start();
                                    Thread.Sleep(TimeSpan.FromMilliseconds(r.Next(1000, 2000)));
                                    carD5.Start();
                                    Thread.Sleep(TimeSpan.FromMilliseconds(r.Next(1000, 2000)));
                                    carD6.Start();
                                    Thread.Sleep(TimeSpan.FromMilliseconds(r.Next(1000, 2000)));
                                    carD7.Start();
                                    Thread.Sleep(TimeSpan.FromMilliseconds(r.Next(1000, 2000)));
                                    carD8.Start();
                                    Thread.Sleep(TimeSpan.FromMilliseconds(r.Next(1000, 2000)));
                                    carD9.Start();
                                    Thread.Sleep(TimeSpan.FromMilliseconds(r.Next(1000, 2000)));
                                    carD10.Start();
                                    carD1.Join();
                                    carD2.Join();
                                    carD3.Join();
                                    carD4.Join();
                                    carD5.Join();
                                    carD6.Join();
                                    carD7.Join();
                                    carD8.Join();
                                    carD9.Join();
                                    carD10.Join();
                                    break;

                            }
                            attesaDx = 0;
                            AggiornLbl();
                            this.Dispatcher.BeginInvoke(new Action(() =>
                            {
                                imgStopSx.Visibility = Visibility.Hidden;
                            }));
                        }
                    }
                }
            }
        }

        public void GestionePonteSx()
        {
            while (true)
            {
                if (attesaSx > 0)
                {
                    lock (ponte)
                    {
                        lock (contatoreSx)
                        {
                            this.Dispatcher.BeginInvoke(new Action(() =>
                            {
                                imgStopDx.Visibility = Visibility.Visible;
                            }));

                            carS1 = new Thread(new ThreadStart(MSx1));
                            carS2 = new Thread(new ThreadStart(MSx2));
                            carS3 = new Thread(new ThreadStart(MSx3));
                            carS4 = new Thread(new ThreadStart(MSx4));
                            carS5 = new Thread(new ThreadStart(MSx5));
                            carS6 = new Thread(new ThreadStart(MSx6));
                            carS7 = new Thread(new ThreadStart(MSx7));
                            carS8 = new Thread(new ThreadStart(MSx8));
                            carS9 = new Thread(new ThreadStart(MSx9));
                            carS10 = new Thread(new ThreadStart(MSx10));
                            switch (attesaSx)
                            {
                                case 1:
                                    carS1.Start();
                                    carS1.Join();
                                    break;
                                case 2:
                                    carS1.Start();
                                    Thread.Sleep(TimeSpan.FromMilliseconds(r.Next(1000, 2000)));
                                    carS2.Start();
                                    carS1.Join();
                                    carS2.Join();
                                    break;
                                case 3:
                                    carS1.Start();
                                    Thread.Sleep(TimeSpan.FromMilliseconds(r.Next(1000, 2000)));
                                    carS2.Start();
                                    Thread.Sleep(TimeSpan.FromMilliseconds(r.Next(1000, 2000)));
                                    carS3.Start();
                                    carS1.Join();
                                    carS2.Join();
                                    carS3.Join();
                                    break;
                                case 4:
                                    carS1.Start();
                                    Thread.Sleep(TimeSpan.FromMilliseconds(r.Next(1000, 2000)));
                                    carS2.Start();
                                    Thread.Sleep(TimeSpan.FromMilliseconds(r.Next(1000, 2000)));
                                    carS3.Start();
                                    Thread.Sleep(TimeSpan.FromMilliseconds(r.Next(1000, 2000)));
                                    carS4.Start();
                                    carS1.Join();
                                    carS2.Join();
                                    carS3.Join();
                                    carS4.Join();
                                    break;
                                case 5:
                                    carS1.Start();
                                    Thread.Sleep(TimeSpan.FromMilliseconds(r.Next(1000, 2000)));
                                    carS2.Start();
                                    Thread.Sleep(TimeSpan.FromMilliseconds(r.Next(1000, 2000)));
                                    carS3.Start();
                                    Thread.Sleep(TimeSpan.FromMilliseconds(r.Next(1000, 2000)));
                                    carS4.Start();
                                    Thread.Sleep(TimeSpan.FromMilliseconds(r.Next(1000, 2000)));
                                    carS5.Start();
                                    carS1.Join();
                                    carS2.Join();
                                    carS3.Join();
                                    carS4.Join();
                                    carS5.Join();
                                    break;
                                case 6:
                                    carS1.Start();
                                    Thread.Sleep(TimeSpan.FromMilliseconds(r.Next(1000, 2000)));
                                    carS2.Start();
                                    Thread.Sleep(TimeSpan.FromMilliseconds(r.Next(1000, 2000)));
                                    carS3.Start();
                                    Thread.Sleep(TimeSpan.FromMilliseconds(r.Next(1000, 2000)));
                                    carS4.Start();
                                    Thread.Sleep(TimeSpan.FromMilliseconds(r.Next(1000, 2000)));
                                    carS5.Start();
                                    Thread.Sleep(TimeSpan.FromMilliseconds(r.Next(1000, 2000)));
                                    carS6.Start();
                                    carS1.Join();
                                    carS2.Join();
                                    carS3.Join();
                                    carS4.Join();
                                    carS5.Join();
                                    carS6.Join();
                                    break;
                                case 7:
                                    carS1.Start();
                                    Thread.Sleep(TimeSpan.FromMilliseconds(r.Next(1000, 2000)));
                                    carS2.Start();
                                    Thread.Sleep(TimeSpan.FromMilliseconds(r.Next(1000, 2000)));
                                    carS3.Start();
                                    Thread.Sleep(TimeSpan.FromMilliseconds(r.Next(1000, 2000)));
                                    carS4.Start();
                                    Thread.Sleep(TimeSpan.FromMilliseconds(r.Next(1000, 2000)));
                                    carS5.Start();
                                    Thread.Sleep(TimeSpan.FromMilliseconds(r.Next(1000, 2000)));
                                    carS6.Start();
                                    Thread.Sleep(TimeSpan.FromMilliseconds(r.Next(1000, 2000)));
                                    carS7.Start();
                                    carS1.Join();
                                    carS2.Join();
                                    carS3.Join();
                                    carS4.Join();
                                    carS5.Join();
                                    carS6.Join();
                                    carS7.Join();
                                    break;
                                case 8:
                                    carS1.Start();
                                    Thread.Sleep(TimeSpan.FromMilliseconds(r.Next(1000, 2000)));
                                    carS2.Start();
                                    Thread.Sleep(TimeSpan.FromMilliseconds(r.Next(1000, 2000)));
                                    carS3.Start();
                                    Thread.Sleep(TimeSpan.FromMilliseconds(r.Next(1000, 2000)));
                                    carS4.Start();
                                    Thread.Sleep(TimeSpan.FromMilliseconds(r.Next(1000, 2000)));
                                    carS5.Start();
                                    Thread.Sleep(TimeSpan.FromMilliseconds(r.Next(1000, 2000)));
                                    carS6.Start();
                                    Thread.Sleep(TimeSpan.FromMilliseconds(r.Next(1000, 2000)));
                                    carS7.Start();
                                    Thread.Sleep(TimeSpan.FromMilliseconds(r.Next(1000, 2000)));
                                    carS8.Start();
                                    carS1.Join();
                                    carS2.Join();
                                    carS3.Join();
                                    carS4.Join();
                                    carS5.Join();
                                    carS6.Join();
                                    carS7.Join();
                                    carS8.Join();
                                    break;
                                case 9:
                                    carS1.Start();
                                    Thread.Sleep(TimeSpan.FromMilliseconds(r.Next(1000, 2000)));
                                    carS2.Start();
                                    Thread.Sleep(TimeSpan.FromMilliseconds(r.Next(1000, 2000)));
                                    carS3.Start();
                                    Thread.Sleep(TimeSpan.FromMilliseconds(r.Next(1000, 2000)));
                                    carS4.Start();
                                    Thread.Sleep(TimeSpan.FromMilliseconds(r.Next(1000, 2000)));
                                    carS5.Start();
                                    Thread.Sleep(TimeSpan.FromMilliseconds(r.Next(1000, 2000)));
                                    carS6.Start();
                                    Thread.Sleep(TimeSpan.FromMilliseconds(r.Next(1000, 2000)));
                                    carS7.Start();
                                    Thread.Sleep(TimeSpan.FromMilliseconds(r.Next(1000, 2000)));
                                    carS8.Start();
                                    Thread.Sleep(TimeSpan.FromMilliseconds(r.Next(1000, 2000)));
                                    carS9.Start();
                                    carS1.Join();
                                    carS2.Join();
                                    carS3.Join();
                                    carS4.Join();
                                    carS5.Join();
                                    carS6.Join();
                                    carS7.Join();
                                    carS8.Join();
                                    carS9.Join();
                                    break;
                                case 10:
                                    carS1.Start();
                                    Thread.Sleep(TimeSpan.FromMilliseconds(r.Next(1000, 2000)));
                                    carS2.Start();
                                    Thread.Sleep(TimeSpan.FromMilliseconds(r.Next(1000, 2000)));
                                    carS3.Start();
                                    Thread.Sleep(TimeSpan.FromMilliseconds(r.Next(1000, 2000)));
                                    carS4.Start();
                                    Thread.Sleep(TimeSpan.FromMilliseconds(r.Next(1000, 2000)));
                                    carS5.Start();
                                    Thread.Sleep(TimeSpan.FromMilliseconds(r.Next(1000, 2000)));
                                    carS6.Start();
                                    Thread.Sleep(TimeSpan.FromMilliseconds(r.Next(1000, 2000)));
                                    carS7.Start();
                                    Thread.Sleep(TimeSpan.FromMilliseconds(r.Next(1000, 2000)));
                                    carS8.Start();
                                    Thread.Sleep(TimeSpan.FromMilliseconds(r.Next(1000, 2000)));
                                    carS9.Start();
                                    Thread.Sleep(TimeSpan.FromMilliseconds(r.Next(1000, 2000)));
                                    carS10.Start();
                                    carS1.Join();
                                    carS2.Join();
                                    carS3.Join();
                                    carS4.Join();
                                    carS5.Join();
                                    carS6.Join();
                                    carS7.Join();
                                    carS8.Join();
                                    carS9.Join();
                                    carS10.Join();
                                    break;

                            }
                            attesaSx = 0;
                            AggiornLbl();
                            this.Dispatcher.BeginInvoke(new Action(() =>
                            {
                                imgStopDx.Visibility = Visibility.Hidden;
                            }));
                        }
                    }
                }
            }
        }
    }
}
