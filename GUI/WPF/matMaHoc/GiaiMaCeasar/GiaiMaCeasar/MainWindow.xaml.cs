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
using System.Diagnostics;


namespace MatMaHoc
{

    public partial class MainWindow : Window
    {
        char[] a = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

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
                    Application.Current.Shutdown();
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

       

        #region MaHoa
        private void MaHoa_Click(object sender, RoutedEventArgs e)
        {
            // kiểm tra giá trị đầu vào
            if (KtInput() == 1 && KtKhoaK() == 1)
            {
                //khai báo biến khóa K bằng dữ liệu nhập vào
                int khoaK = int.Parse(tbxK.Text);
                //clear ô kết quả
                tbxOnput.Text = "";

                //duyệt từng ký tự từ Input
                for (int i = 0; i < tbxInput.Text.Length; i++)
                {
                    //dùng hàm substring để tách từng chữ từ input và lưu vào biến ktInput
                    string kytuInput = tbxInput.Text.Substring(i, 1);

                    //duyệt từng ký tự trong bảng chữ cái để so sánh
                    for (int j = 0; j < a.Length; j++)
                    {
                        if (kytuInput == " ")
                        {
                            tbxOnput.Text += " ";
                            break;
                        }
                        //kiểm tra nếu ktInput có bằng ký tự trong bảng chữ cái không
                        if (((kytuInput).Equals(a[j].ToString()) || kytuInput.Equals(char.ToLower(a[j]).ToString()))) //kiểm tra cả chữ hoa và thường
                        {
                            //kiểm tra bảng chữ cái sau khi lùi về có chạm giới hạn đầu không, nếu có thì sẽ tiếp tục duyệt từ cuối
                            while (khoaK > a.Length) // giảm bớt số vòng trùng lặp
                            { khoaK -= a.Length; }
                            if (j - khoaK < 0)
                            {
                                
                                tbxOnput.Text += a[a.Length + (j - khoaK)].ToString();
                            }
                            else
                                tbxOnput.Text += a[j - khoaK].ToString();
                            break;
                        }
                    }
                }
            }
        }

        

        #endregion

        #region GiaiMa
        private void GiaiMa_Click(object sender, RoutedEventArgs e)
        {
            // kiểm tra giá trị đầu vào
            if (KtInput() == 1 && KtKhoaK() == 1)
            {
                //khai báo biến khóa K bằng dữ liệu nhập vào
                int khoaK = int.Parse(tbxK.Text);
                //clear ô kết quả
                tbxOnput.Text = "";

                //duyệt từng ký tự từ Input
                for (int i = 0; i < tbxInput.Text.Length; i++)
                {
                    //dùng hàm substring để tách từng chữ từ input và lưu vào biến ktInput
                    string kytuInput = tbxInput.Text.Substring(i, 1);

                    //duyệt từng ký tự trong bảng chữ cái để so sánh
                    for (int j = 0; j < a.Length; j++)
                    {
                        if (kytuInput == " ")
                        {
                            tbxOnput.Text += " ";
                            break;
                        }
                        //kiểm tra nếu ktInput có bằng ký tự trong bảng chữ cái không
                        if (((kytuInput).Equals(a[j].ToString()) || kytuInput.Equals(char.ToLower(a[j]).ToString()))) //kiểm tra cả chữ hoa và thường
                        {
                            //kiểm tra bảng chữ cái sau khi lùi về có chạm giới hạn đầu không, nếu có thì sẽ tiếp tục duyệt từ cuối
                            while (khoaK > a.Length) // giảm bớt số vòng trùng lặp
                            { khoaK -= a.Length;}
                            if (j + khoaK >=a.Length)
                            {

                                tbxOnput.Text += a[0 + (j + khoaK - a.Length)].ToString();
                            }
                            else
                                tbxOnput.Text += a[j + khoaK].ToString();
                            break;
                        }
                    }
                }
            }
        }

        #endregion

        #region kiemTraGiaTri

        public int KtInput()
        {
            if (tbxInput.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập Input", "Lỗi input");
                return 0;
            }
            for (int i = 0; i < tbxInput.Text.Length; i++)
            {
                if (tbxInput.Text.Substring(i, 1).Any(c => c!=32 && (c > 122 || c < 65)) || char.IsDigit(char.Parse(tbxInput.Text.Substring(i, 1)))) //kt có ký tự số không
                {
                    MessageBox.Show("Nhập Input sai, vui lòng nhập chữ không dấu!", "Lỗi input");
                    return 0;
                }
            }
            return 1;
        }
        public int KtKhoaK()
        {
            if (tbxK.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập khóa K!", "Lỗi khóa K");
                return 0;
            }
            for (int i = 0; i < tbxK.Text.Length; i++)
            {
                if (!char.IsDigit(char.Parse(tbxK.Text.Substring(i, 1)))) //kt có ký tự chữ không
                {
                    MessageBox.Show("Nhập khóa K sai, vui lòng nhập số!", "Lỗi khóa K");
                    return 0;
                }
            }
            return 1;
        }

        #endregion
        



        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    try
        //    {
        //        Process.Start("nụ cười tỏa nắng.exe");
        //    }
        //    catch (Exception)
        //    {
        //        MessageBox.Show("không tìm thấy file", "Error");
        //    }
        //}

    }
}
