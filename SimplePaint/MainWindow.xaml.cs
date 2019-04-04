using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;

namespace SimplePaint
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DrawAction _drawAction;
        private Point _lineStartPoint;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Clear(object sender, RoutedEventArgs e)
        {
            MyCanvas.Children.Clear();
            _drawAction = DrawAction.None;
        }

        private void StartDrawingLines(object sender, RoutedEventArgs e)
        {
            _drawAction = DrawAction.StartDrawLine;
        }

        private void StartDrawingSquares(object sender, RoutedEventArgs e)
        {
            _drawAction = DrawAction.DrawSquare;
        }

        private void StartDrawingCircles(object sender, RoutedEventArgs e)
        {
            _drawAction = DrawAction.DrawCircle;
        }

        private void HandleMouseClick(object sender, MouseButtonEventArgs e)
        {
            var currentMousePosition = e.GetPosition(MyCanvas);
            switch (_drawAction)
            {
                case (DrawAction.None):
                    break;
                case (DrawAction.StartDrawLine):
                    HandleStartDrawLine(currentMousePosition);
                    break;
                case (DrawAction.EndDrawLine):
                    HandleEndDrawLine(currentMousePosition);
                    break;
                case (DrawAction.DrawCircle):
                    HandleStartDrawCircle(currentMousePosition);
                    break;
                case (DrawAction.DrawSquare):
                    HandleStartDrawSquare(currentMousePosition);
                    break;

                default:
                    break;
            }
        }

        private void HandleStartDrawLine(Point currentMousePosition)
        {
            _lineStartPoint = currentMousePosition;
            _drawAction = DrawAction.EndDrawLine;
        }

        private void HandleEndDrawLine(Point currentMousePosition)
        {
            var line = new Line
            {
                X1 = _lineStartPoint.X,
                Y1 = _lineStartPoint.Y,
                X2 = currentMousePosition.X,
                Y2 = currentMousePosition.Y,
                Stroke = Brushes.Green
            };
            MyCanvas.Children.Add(line);
            _drawAction = DrawAction.StartDrawLine;
        }

        private void HandleStartDrawCircle(Point currentMousePosition)
        {
            var circle = new Ellipse
            {
                Stroke = Brushes.Blue,
                Height = 50,
                Width = 50,
                Margin = new Thickness(currentMousePosition.X - 25, currentMousePosition.Y - 25, 0, 0)
            };
            MyCanvas.Children.Add(circle);
        }

        private void HandleStartDrawSquare(Point currentMousePosition)
        {
            var square = new Rectangle
            {
                Stroke = Brushes.Red,
                Height = 50,
                Width = 50,
                Margin = new Thickness(currentMousePosition.X - 25, currentMousePosition.Y - 25, 0, 0)
            };
            MyCanvas.Children.Add(square);
        }
    }
}
