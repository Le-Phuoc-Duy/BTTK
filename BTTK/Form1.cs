using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTTK
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*DataTable dtSV;

        public DataTable createTable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("STT");
            dt.Columns.Add("Mssv");
            dt.Columns.Add("Name");
            dt.Columns.Add("Lop");
            dt.Columns.Add("Ngay sinh");
            dt.Columns.Add("DTB");
            return dt;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            dtSV = createTable();  
        }*/
        public void SetCBBLSH()
        {
            cboLop.Items.Add("All");
            foreach(string i in QLSV.Instance.GetLSH().Distinct())
            {
                cboLop.Items.Add(i); //e
            }
            QLSV.Instance.GetLSH().Distinct();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = QLSV.Instance.GetSV(cboLop.SelectedItem.ToString(),txtSearch.Text);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                List<string> li = new List<string>();
                foreach(DataGridViewRow i in dataGridView1.SelectedRows)
                {
                    li.Add(i.Cells[2].Value.ToString());

                }
                QLSV.Instance.DelSV(li);
                Show(cboLop.SelectedItem.ToString(),txtSearch.Text);
            }
        }
    }
}
