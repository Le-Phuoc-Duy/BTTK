using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BTTK
{
    class SinhVien
    {
        public string MSSV { set; get; }
        public string Name { set; get; }
        public string LopSH { set; get; }
        public bool Gender { set; get; }

        public DateTime NS { set; get; }
        public double DTB { set; get; }
        public bool Anh { set; get; }
        public bool Hocba { set; get; }
        public bool CCCD { set; get; } 

    }
}
