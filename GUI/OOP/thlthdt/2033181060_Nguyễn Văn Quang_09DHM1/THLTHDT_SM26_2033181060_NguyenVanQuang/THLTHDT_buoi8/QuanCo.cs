using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THLTHDT_buoi8
{
    abstract class QuanCo
    {
        string ten, vitri;

        public string Vitri
        {
            get { return vitri; }
            set { vitri = value; }
        }

        public string Ten
        {
            get { return ten; }
            set { ten = value; }
        }

        public QuanCo()
        {
            this.Ten = "";
        }

        public abstract void cachDi();
        public abstract void cachThang();

    }
}
