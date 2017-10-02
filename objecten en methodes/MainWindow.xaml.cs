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

namespace objecten_en_methodes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public object PaperCanvas { get; private set; }

        private void ButtonDraw_Click(object sender, RoutedEventArgs e)
        {
            double Top = 0;
            double Left = 0;

            Top = MijnRechthoek.Margin.Top;
            Left = MijnRechthoek.Margin.Left;

            Left++;

            MijnRechthoek.Stroke = Brushes.Cyan;
            MijnRechthoek.Margin = new Thickness(Top, Left, 0, 0);
        }

        private void mijnCanvas_MouseEnter(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Hallo wereld!", "Hallo", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Knop2_Click(object sender, RoutedEventArgs e)
        {
            Line lijn = new Line();
            lijn.X1 = 100;
            lijn.Y1 = 100;
            lijn.X2 = 200;
            lijn.Y2 = 100;
            lijn.Stroke = new SolidColorBrush(Colors.Red);
            MijnCanvas.Children.Add(lijn);

            Line lijn2 = new Line();
            lijn2.X1 = 100;
            lijn2.Y1 = 10;
            lijn2.X2 = 200;
            lijn2.Y2 = 100;
            lijn2.Stroke = new SolidColorBrush(Colors.Red);
            MijnCanvas.Children.Add(lijn2);

            Line lijn3 = new Line();
            lijn3.X1 = 100;
            lijn3.Y1 = 10;
            lijn3.X2 = 100;
            lijn3.Y2 = 100;
            lijn3.Stroke = new SolidColorBrush(Colors.Red);
            MijnCanvas.Children.Add(lijn3);

            Line lijn4 = new Line();
            lijn4.X1 = 10;
            lijn4.Y1 = 145;
            lijn4.X2 = 10;
            lijn4.Y2 = 10;
            lijn4.Stroke = new SolidColorBrush(Colors.Blue);
            MijnCanvas.Children.Add(lijn4);

            Line lijn5 = new Line();
            lijn5.X1 = 50;
            lijn5.Y1 = 145;
            lijn5.X2 = 50;
            lijn5.Y2 = 10;
            lijn5.Stroke = new SolidColorBrush(Colors.Blue);
            MijnCanvas.Children.Add(lijn5);

            Line lijn6 = new Line();
            lijn6.X1 = 90;
            lijn6.Y1 = 145;
            lijn6.X2 = 90;
            lijn6.Y2 = 10;
            lijn6.Stroke = new SolidColorBrush(Colors.Blue);
            MijnCanvas.Children.Add(lijn6);

            Line lijn7 = new Line();
            lijn7.X1 = 10;
            lijn7.Y1 = 10;
            lijn7.X2 = 130;
            lijn7.Y2 = 10;
            lijn7.Stroke = new SolidColorBrush(Colors.Blue);
            MijnCanvas.Children.Add(lijn7);

            Line lijn8 = new Line();
            lijn8.X1 = 10;
            lijn8.Y1 = 55;
            lijn8.X2 = 130;
            lijn8.Y2 = 55;
            lijn8.Stroke = new SolidColorBrush(Colors.Blue);
            MijnCanvas.Children.Add(lijn8);

            Line lijn9 = new Line();
            lijn9.X1 = 10;
            lijn9.Y1 = 100;
            lijn9.X2 = 130;
            lijn9.Y2 = 100;
            lijn9.Stroke = new SolidColorBrush(Colors.Blue);
            MijnCanvas.Children.Add(lijn9);

            Line lijn10 = new Line();
            lijn10.X1 = 130;
            lijn10.Y1 = 145;
            lijn10.X2 = 130;
            lijn10.Y2 = 10;
            lijn10.Stroke = new SolidColorBrush(Colors.Blue);
            MijnCanvas.Children.Add(lijn10);

            Line lijn11 = new Line();
            lijn11.X1 = 10;
            lijn11.Y1 = 145;
            lijn11.X2 = 130;
            lijn11.Y2 = 145;
            lijn11.Stroke = new SolidColorBrush(Colors.Blue);
            MijnCanvas.Children.Add(lijn11);
        }
    }
}
