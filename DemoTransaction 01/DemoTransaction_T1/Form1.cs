using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DemoTransaction_T1
{
   
    public partial class Form1 : Form
    {
        
        SqlConnection cnn;
   
        SqlCommand cm;

        DataTable tbNguyenLieu;
       string strConnection=@"Server=PC\SQLSEVER; DataBase=QLNhaHang ; Integrated Security=SSPI";
       //string strConnection = @"Data Source=PC\SQLSEVER;Initial Catalog=QLNhaHanga;User Id=ngoc;Password=ngoc;";

        public void DocDulieu()
       {
           tbNguyenLieu = new DataTable();
           cnn = new SqlConnection(strConnection);
           cm = new SqlCommand();
           string lenh = "select MaNL,TenNL,SoLuongTon from NguyenLieu";
           cm.Connection = cnn;
           cnn.Open();

           cm.CommandType = CommandType.Text;
           cm.CommandText = lenh;
           tbNguyenLieu.Load(cm.ExecuteReader());
           cnn.Close();
           dgvNguyenLieu.DataSource = tbNguyenLieu;
       }
        public void DocDuLieu_Proc()
        {
            tbNguyenLieu = new DataTable();
            cnn = new SqlConnection(strConnection);
            cm = new SqlCommand();
            //string lenh = "select MaNL,TenNL,SoLuongTon from NguyenLieu";
            //string lenh = "begin tran select MaNL,TenNL,SoLuongTon from nguyenlieu waitfor delay '0:0:5' select MaNL,TenNL,SoLuongTon from nguyenlieu commit ";

            cm.Connection = cnn;
            cnn.Open();

            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "ReadNguyenLieu_UnrepeatableRead";
            tbNguyenLieu.Load(cm.ExecuteReader());
            dgvNguyenLieu.DataSource = tbNguyenLieu;
            cnn.Close();  
        }
       
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DocDulieu();
            cbbNguyenLieu.DataSource = tbNguyenLieu;
            cbbNguyenLieu.DisplayMember = "TenNl";
            cbbNguyenLieu.ValueMember = "MaNL";
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string soluong = txtSoLuong.Text;
            string manl = cbbNguyenLieu.SelectedValue.ToString();
           // string lenh = "update NguyenLieu set soluongton=" + soluong + " where manl=" + manl;
            SqlParameter parSoLuong = new SqlParameter("@soluong", SqlDbType.Int);
            parSoLuong.Value = soluong;
            SqlParameter parMaNL = new SqlParameter("@ma", SqlDbType.Int);
            parMaNL.Value = manl;
            
            cm.Connection = cnn;
            cnn.Open();
            cm.CommandType = CommandType.StoredProcedure;
            cm.Parameters.AddRange(new SqlParameter[] { parSoLuong, parMaNL });
            cm.CommandText = "UpdateNguyenLieu_UnreapeatableRead";
            cm.ExecuteNonQuery();
            cnn.Close();

            DocDulieu();
            
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DocDulieu();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            DocDuLieu_Proc();
           
        }

      

       

        
    }
}
