using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using KAutoHelper;

namespace GauRedAutoFishingAvatarHD
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

        #region WindowControl  
        private void TitleBar_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                if (e.ClickCount == 2)
                {
                    AdjustWindowSize();
                }
                else
                {
                    Application.Current.MainWindow.DragMove();
                }
        }

        #region EventButton
        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            CloseConfirm f2 = new CloseConfirm();
                f2.ShowDialog();
        }
        private void MaximizeButton_Click(object sender, RoutedEventArgs e)
        {
            AdjustWindowSize();

        }
        private void MinimizeButton_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }
        private void AdjustWindowSize()
        {
            if (this.WindowState == WindowState.Maximized)
            {

                this.WindowState = WindowState.Normal;
                MaximizeButton.Content = btn2.Content;
                MaximizeButton.ToolTip = "Maximize";

            }
            else
            {
                this.WindowState = WindowState.Maximized;
                MaximizeButton.Content = btn1.Content;
                MaximizeButton.ToolTip = "Restore";

            }

        }
        private void CloseButton_MouseEnter(object sender, MouseEventArgs e)
        {
            CloseButton.Background = Brushes.Black;
        }

        private void CloseButton_MouseLeave(object sender, MouseEventArgs e)
        {
            CloseButton.Background = Brushes.Red;
        }

        private void MaximizeButton_MouseEnter(object sender, MouseEventArgs e)
        {
            MaximizeButton.Background = Brushes.Orange;
        }

        private void MaximizeButton_MouseLeave(object sender, MouseEventArgs e)
        {
            MaximizeButton.Background = Brushes.Red;
        }

        private void MinimizeButton_MouseEnter(object sender, MouseEventArgs e)
        {
            MinimizeButton.Background = Brushes.Orange;
        }

        private void MinimizeButton_MouseLeave(object sender, MouseEventArgs e)
        {
            MinimizeButton.Background = Brushes.Red;
        }



        #endregion

        #endregion

        #region mod
        private void btn_Start_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("notepad");
        }




        #endregion

        //private void btn_OpenGame_Click(object sender, RoutedEventArgs e)
        //{
        //    Process.Start(@"C: \Users\vanqu\OneDrive\Máy tính\Avatar.lnk");
        //}
    }
}
