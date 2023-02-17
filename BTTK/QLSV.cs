using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTTK
{
    class QLSV
    {
        private static QLSV _Instance;
        public static QLSV Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new QLSV();
                }
                return _Instance;

            }
            private set { }
        }
        public List<string> GetLSH()
        {
            List<string> li = new List<string>();
            foreach(SinhVien i in CSDL.Instance.GetAllSV())
            {
                li.Add(i.LopSH);
            }
            return li;
        }
        public List<SinhVien> GetSV(string LSH, string txt)
        {
            List<SinhVien> li = new List<SinhVien>();
            if(LSH == "All") {
                li = CSDL.Instance.GetAllSV();            
            }
            else
            {
                foreach (SinhVien i in CSDL.Instance.GetAllSV())
                {
                    if(i.LopSH == LSH)
                    {
                        li.Add(i);
                    }
                }
            }
            return li;
        }
        public void DelSV(List<string> li)
        {
            foreach (string i in li)
            {
                CSDL.Instance.Del_CSDL(i);
            }

        }
        public SinhVien getbymssv(string mssv)
        {
            SinhVien s = new SinhVien();
            return s;
        }
    }
}
