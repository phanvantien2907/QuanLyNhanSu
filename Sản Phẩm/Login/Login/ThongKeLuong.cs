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
    public partial class ThongKeLuong : Form
    {
        // khai báo thông tin kết nối
        SqlConnection conn = null;
        public ThongKeLuong()
        {
            InitializeComponent();
        }

        private DataTable HienThi()
        {
            string sqlSelect = "select * from tb_QuanLyLuong";
            SqlCommand cmd = new SqlCommand(sqlSelect, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            return dt;

        }
        private void reportViewer1_Load(object sender, EventArgs e)
        {
            try
            {
                // khai báo thông tin kết nối tới csdl
                string connstring = @"Data Source=PHANVANTIEN\PHANVANTIEN;Initial Catalog=QuanLyNhanSu;Integrated Security=True;";
                conn = new SqlConnection(connstring);
                conn.Open();

                formreport.LocalReport.ReportEmbeddedResource = "Login.Report2.rdlc";
                ReportDataSource reportDataSource = new ReportDataSource();
                reportDataSource.Name = "DataSet1";
                DataTable dt = HienThi();
                reportDataSource.Value = dt;
                formreport.LocalReport.DataSources.Add(reportDataSource);
                this.formreport.RefreshReport();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.formreport.RefreshReport();
        }
    }
    }

