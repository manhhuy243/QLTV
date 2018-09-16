using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    class DataBase
    {
            //Thuoc tinh 
            protected string m_connectionString;
            protected SqlConnection connection;
            protected SqlDataAdapter da = null;
            protected SqlCommand command;
            //Phuong thuc 
            public DataBase()
            {
                m_connectionString = @"Data Source=./;Initial Catalog=D:\C#\BAITAP\QLTV\QLTV\QUANLYTHUVIEN.MDF;Integrated Security=True";
            }
            //Ket noi 
            public void connect()
            {
                try
                {
                    connection = new SqlConnection(ConnectionString);
                    connection.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể kết nối được với Server\n" + ex.Message, "Lỗi chương trình");
                    //Application.Exit(); 
                }
            }
            //Tat ket noi 
            public void disconnect()
            {
                try
                {
                    connection.Close();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
            //Lay ra du lieu ra table 
            public DataTable TaoBang(String sqlString)
            {
                connect();
                DataTable ds = new DataTable();
                da = new SqlDataAdapter(sqlString, connection);
                da.Fill(ds);
                disconnect();
                return ds;
            }
            //Dung cho cac thao tac insert, delete, update 
            public void ExcuteNonQuery(string sqlString)
            {
                connect();
                command = new SqlCommand(sqlString, connection);
                command.ExecuteNonQuery();
                disconnect();
            }
            //Lay 1 gia tri du lieu ra 
            public object executeScalar(string sqlString)
            {
                connect();
                command = new SqlCommand(sqlString, connection);
                object o = command.ExecuteScalar();
                disconnect();
                return o;
            }

            public string ConnectionString
            {
                get
                {
                    return m_connectionString;
                }
                set
                {
                    m_connectionString = value;
                }
            }
        }
    }



