using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace AD
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DoubleAnimation AnimatiomSizeName = new DoubleAnimation();
            AnimatiomSizeName.From = 40;
            AnimatiomSizeName.From = 45;
            AnimatiomSizeName.Duration = TimeSpan.FromSeconds(2);
            AnimatiomSizeName.AutoReverse = true;
            AnimatiomSizeName.RepeatBehavior = RepeatBehavior.Forever;
            TBLOCKName.BeginAnimation(FontSizeProperty, AnimatiomSizeName);

            DoubleAnimation AnimatiomLengthName = new DoubleAnimation();
            AnimatiomLengthName.From = 215;
            AnimatiomLengthName.From = 250;
            AnimatiomLengthName.Duration = TimeSpan.FromSeconds(4);
            AnimatiomLengthName.AutoReverse = true;
            AnimatiomLengthName.RepeatBehavior = RepeatBehavior.Forever;
            TBLOCKDownLettering.BeginAnimation(WidthProperty, AnimatiomLengthName);




            DoubleAnimation AnimatiomWidthButton = new DoubleAnimation();
            AnimatiomWidthButton.From = 150;
            AnimatiomWidthButton.From = 170;
            AnimatiomWidthButton.Duration = TimeSpan.FromSeconds(3);
            AnimatiomWidthButton.AutoReverse = true;
            AnimatiomWidthButton.RepeatBehavior = RepeatBehavior.Forever;


            DoubleAnimation AnimatiomLengthButton = new DoubleAnimation();
            AnimatiomLengthButton.From = 35;
            AnimatiomLengthButton.From = 45;
            AnimatiomLengthButton.Duration = TimeSpan.FromSeconds(3);
            AnimatiomLengthButton.AutoReverse = true;
            AnimatiomLengthButton.RepeatBehavior = RepeatBehavior.Forever;


            ThicknessAnimation AnimatiomButtonThi = new ThicknessAnimation();
            AnimatiomButtonThi.From = new Thickness(0, 0, 0, 0);
            AnimatiomButtonThi.From = new Thickness(5, 5, 5, 5); ;
            AnimatiomButtonThi.Duration = TimeSpan.FromSeconds(6);
            AnimatiomButtonThi.AutoReverse = true;
            AnimatiomButtonThi.RepeatBehavior = RepeatBehavior.Forever;
            BLink.BeginAnimation(BorderThicknessProperty, AnimatiomButtonThi);

            ColorAnimation AnimatiomButtonThicknessColor = new ColorAnimation();
            AnimatiomButtonThicknessColor.From = Color.FromRgb(218, 165, 32);
            BLink.Background = new SolidColorBrush(Color.FromRgb(218, 165, 32));
            AnimatiomButtonThicknessColor.To = Color.FromRgb(255, 255, 255);
            AnimatiomButtonThicknessColor.Duration = TimeSpan.FromSeconds(6);
            AnimatiomButtonThicknessColor.AutoReverse = true;
            AnimatiomButtonThicknessColor.RepeatBehavior = RepeatBehavior.Forever;
            BLink.Background.BeginAnimation(SolidColorBrush.ColorProperty, AnimatiomButtonThicknessColor);
        }
        private void BLink_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

