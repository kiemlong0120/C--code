using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace caro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DrawField();
        }



        // thuôc tính
        private List<Player> playerlist = new List<Player>();

        public List<Player> Playerlist { get => playerlist; set => playerlist = value; }

        public int curentPlayer;
       
        public int CurentPlayer { get => curentPlayer; set => curentPlayer = value; }
  
        

        
        void DrawField()
        {
            ;

            Player p1 = new Player("P1", Image.FromFile(Application.StartupPath + "\\Resources\\p1.jpg"));

            Player p2 = new Player("P2", Image.FromFile(Application.StartupPath + "\\Resources\\p2.jpg"));
            curentPlayer = 0;
            Playerlist.Add(p1);
            Playerlist.Add(p2);

            picKyHieu.BackgroundImageLayout = ImageLayout.Stretch;
            picKyHieu.BackgroundImage = Playerlist[curentPlayer].Logo;
            tbPlayerName.Text = Playerlist[curentPlayer].Name;

            Button oldButton = new Button() { Width=0,Location = new Point(0,0)};

            for (int i = 0; i < ConsVariable.boardHeight; i++)
            {
                for (int j = 0; j < ConsVariable.boardWidth; j++)
                {
                    Button btn1 = new Button()
                    {
                        Width = ConsVariable.zoneWidth,
                        Height = ConsVariable.zoneHeight,
                        Location = new Point(oldButton.Location.X + oldButton.Width, oldButton.Location.Y),
                        BackgroundImageLayout = ImageLayout.Stretch
                    };

                    btn1.Click += btn1_Click;

                    pnlBanCo.Controls.Add(btn1);

                    oldButton = btn1;
                }

                oldButton.Location = new Point(0,oldButton.Location.Y+oldButton.Height);
                oldButton.Width = 0;
                oldButton.Height = 0;

            }


        }

        void btn1_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;



            if (btn.BackgroundImage == null)        // kiểm tra ô đó đã đánh chưa
            { 
                btn.BackgroundImage = Playerlist[curentPlayer].Logo;
                curentPlayer = curentPlayer == 1 ? 0 : 1;

                picKyHieu.BackgroundImage = Playerlist[curentPlayer].Logo;
                tbPlayerName.Text = Playerlist[curentPlayer].Name;
            }
            

         
        }
    }
}
