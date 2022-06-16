using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caro
{
    public class Player
    {

        //thuoc tinh
        private string name;        //ctrl + r + e tạo get set

        public string Name { get => name; set => name = value; }

        private Image logo;

        public Image Logo { get => logo; set => logo = value; }


        //constructor
        public Player(string name, Image logo)
        {
            Name = name;
            
            Logo = logo;
  
        }

        //method

    }
}
