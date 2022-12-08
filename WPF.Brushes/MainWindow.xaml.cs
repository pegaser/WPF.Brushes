using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;

namespace WPF.Brushes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            Rectangle myRectangle= new Rectangle();
            myRectangle.Fill = new SolidColorBrush(Colors.Purple);
            myRectangle.Stroke = new SolidColorBrush(Colors.Black);
            myRectangle.Width = 200;
            myRectangle.Height = 200;
            stpMain.Children.Add(myRectangle);
            myRectangle = new Rectangle();
            int red = 0;
            int green = 255;
            int blue = 0;
            myRectangle.Fill = new SolidColorBrush(Color.FromRgb((byte)red, (byte)green, (byte)blue));
            myRectangle.Stroke = new SolidColorBrush(Colors.Black);
            myRectangle.Width = 100;
            myRectangle.Height = 100;
            stpMain.Children.Add(myRectangle);
        }
    }
}
