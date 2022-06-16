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

namespace GauRedAutoFishingAvatarHD
{
    /// <summary>
    /// Interaction logic for CloseConfirm.xaml
    /// </summary>
    public partial class CloseConfirm : Window
    {
        public CloseConfirm()
        {
            InitializeComponent();
        }

        private void btn_yes_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btn_no_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
