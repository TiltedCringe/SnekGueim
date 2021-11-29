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
using System.Windows.Threading;

namespace Snake2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Snek jocSnek;
        DispatcherTimer timer = new DispatcherTimer();

        public MainWindow()
        {
            jocSnek = new Snek();
           
            timer.Tick += Timer_Tick;
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.Start();
            InitializeComponent();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            int y = (int)(cnCanvas.ActualHeight / Snek.Y_SIZE), x = (int)cnCanvas.ActualWidth / Snek.X_SIZE;
            Ellipse ellSerp = new Ellipse()
            {
                Fill = Brushes.IndianRed,
                Width = x,
                Height = y
            };
            cnCanvas.Children.Add(ellSerp);
            Canvas.SetTop(ellSerp, jocSnek.CapSerp.Y * y);
            Canvas.SetLeft(ellSerp, jocSnek.CapSerp.X * x);
        }

        private void cnCanvas_KeyDown(object sender, KeyEventArgs e)
        {
            jocSnek.Moure();
        }
    }
}
