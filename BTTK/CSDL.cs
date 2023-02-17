using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTTK
{
    class CSDL
    {
        private DataTable dt;
        private static CSDL _Instance;
        public static CSDL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new CSDL();
                }
                return _Instance;
            }
            private set { }
        }
        private CSDL()
        {
            dt = new DataTable();
            //add colum and row
            /////////////////////////
        }
        public void Add_CSDL(SinhVien s)
        {
            SinhVien sv = new SinhVien();
        }
        public void Del_CSDL(string MSSV)
        {

        }
        public void Update_CSDL(SinhVien s)
        {

        }
        public List<SinhVien> GetAllSV()
        {
            List<SinhVien> li = new List<SinhVien>();   
            foreach (DataRow i in dt.Rows)
            {
                li.Add(new SV
                {
                    //MSSV = i["MSSV"].ToString()
                    //
                });
            }
            return li;
        }
    }
}
