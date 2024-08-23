using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class ThongKeNhanSu : Form
    {
        SqlConnection conn = null;
        public ThongKeNhanSu()
        {
            InitializeComponent();
        }
        private DataTable HienThi()
        {
            string sqlSelect = "select * from tb_NhanVien";
            SqlCommand cmd = new SqlCommand(sqlSelect, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            return dt;

        }

        private void ThongKe_Load(object sender, EventArgs e)
        {
            try
            {
                // khai báo thông tin kết nối tới csdl
                string connstring = @"Data Source=PHANVANTIEN\PHANVANTIEN;Initial Catalog=QuanLyNhanSu;Integrated Security=True;";
                conn = new SqlConnection(connstring);
                conn.Open();

                reportViewer1.LocalReport.ReportEmbeddedResource = "Login.Report1.rdlc";
                ReportDataSource reportDataSource = new ReportDataSource();
                reportDataSource.Name = "DataSet1";
                DataTable dt = HienThi();
                reportDataSource.Value = dt;
                reportViewer1.LocalReport.DataSources.Add(reportDataSource);
                this.reportViewer1.RefreshReport();
            }
            
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.reportViewer1.RefreshReport();
        }
    }
}
