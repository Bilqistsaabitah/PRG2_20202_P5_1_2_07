using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PRG2_20202_P5_1_2_07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //deklarasi variabel dsProdi dengan tipe DataSet
        private DataSet dsProdi;

        public DataSet CreateProdiDataSet()
        {
            DataSet myDataSet = new DataSet();

            try
            {
                //connection string digunakan untuk koneksi ke basisdata 
                //perhatikan data source berisi "." menunjukan komputer localhost
                //pada kenyataan Anda akan menggantikan dengan alamat IP Komputer server basisdatra
                string myConnectionString = @"Integrated Security=True;Data Source=LAPTOP-ALDVS5GI;Initial Catalog=P5_07";
                //string connectionString = "Data Source=LAPTOP-ALDVS5GI;Initial Catalog=P5_07;Integrated Security=True;Pooling=False";

                //membuat object dengan nama myConnection, inisialisasi dengan connection string
                SqlConnection myConnection = new SqlConnection(myConnectionString);

                //membuat object dengan nama myCommand, inisialisasi dari class SqlCommand
                SqlCommand myCommand = new SqlCommand();

                //menetapkan koneksi basisdata yang akan digunakan, yaitu pobject myConnection
                myCommand.Connection = myConnection;

                //mengatur perintah SQL yang digunakan untuk object Command
                myCommand.CommandText = "SELECT * FROM msprodi";
                myCommand.CommandType = CommandType.Text;

                //buatlah data adapter dan tentukan object command
                //tambahkan table mapping untuk prodi
                SqlDataAdapter mylDataAdapter = new SqlDataAdapter();
                mylDataAdapter.SelectCommand = myCommand;
                mylDataAdapter.TableMappings.Add("Table", "Prodi");

                //digunakan method Fill dari data adapter untuk mengisi dataset
                mylDataAdapter.Fill(myDataSet);

            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return myDataSet;
        }

        private void RefreshDataSet ()
        {
            //mengatur nilai DatSet dsProdi
            //nilai didapat dari pengembangan method CreateProdiDataSet
            dsProdi = CreateProdiDataSet();

            //bind dataset ke dalam datagrid dgProdi
            //dgProdi.DataSource = dsProdi.Tables["Prodi"];

            // TODO: This line of code loads data into the 'dsProdi1.msprodi' table. You can move, or remove it, as needed.
            this.msprodiTableAdapter.Fill(this.dsProdi1.msprodi);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshDataSet();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string connectionstring = @"Integrated Security=True;Data Source=LAPTOP-ALDVS5GI;Initial Catalog=P5_07";
            SqlConnection connection = new SqlConnection(connectionstring);
            SqlDataAdapter adapter = new SqlDataAdapter();

            // buka connection
            connection.Open();

            // membuat dataadapter dan commandbuilder
            //SqlDataAdapter myAdapter = new SqlDataAdapter("SELECT * FROM msprodi", myConnection);
            //SqlCommandBuilder myCmdBuilder = new SqlCommandBuilder(myAdapter);

            // menggunakan commandbuilder untuk build insertcommand, updatecommand, dan
            // deletecommand required by dataadapter
            //myAdapter.InsertCommand = myCmdBuilder.GetInsertCommand();
            //myAdapter.UpdateCommand = myCmdBuilder.GetUpdateCommand();
            //myAdapter.DeleteCommand = myCmdBuilder.GetDeleteCommand();

            //deklarasi object untuk parameter
            SqlParameter param = new SqlParameter();

            //delete command
            SqlCommand delete = new SqlCommand("sp_DeleteProdi", connection);
            delete.CommandType = CommandType.StoredProcedure;

            //set parameter untuk operasi delete
            //diambil dari DaraGrid dengan nama kolom id_prodi
            param = delete.Parameters.Add("@id_prodi", SqlDbType.Char, 10);
            param.Direction = ParameterDirection.Input;
            param.SourceColumn = "id_prodi";
            param.SourceVersion = DataRowVersion.Original;

            //set delete command
            adapter.DeleteCommand = delete;

            //insert command
            SqlCommand insert = new SqlCommand("sp_UpdateProdi", connection);
            insert.CommandType = CommandType.StoredProcedure;

            param = insert.Parameters.Add("@id_prodi", SqlDbType.Char, 10);
            param.Direction = ParameterDirection.Input;
            param.SourceColumn = "nama_prodi";
            param.SourceVersion = DataRowVersion.Current;

            param = insert.Parameters.Add("@nama_prodi", SqlDbType.VarChar, 100);
            param.Direction = ParameterDirection.Input;
            param.SourceColumn = "nama_prodi";
            param.SourceVersion = DataRowVersion.Current;

            param = insert.Parameters.Add("@singkatan", SqlDbType.VarChar, 10);
            param.Direction = ParameterDirection.Input;
            param.SourceColumn = "singkatan";
            param.SourceVersion = DataRowVersion.Current;

            param = insert.Parameters.Add("@ka_prodi", SqlDbType.VarChar, 50);
            param.Direction = ParameterDirection.Input;
            param.SourceColumn = "ka_prodi";
            param.SourceVersion = DataRowVersion.Current;

            param = insert.Parameters.Add("@sek_prodi", SqlDbType.VarChar, 50);
            param.Direction = ParameterDirection.Input;
            param.SourceColumn = "sek_prodi";
            param.SourceVersion = DataRowVersion.Current;

            //set insert command
            adapter.InsertCommand = insert;

            //update command
            SqlCommand update = new SqlCommand("sp_UpdateProdi", connection);
            update.CommandType = CommandType.StoredProcedure;

            param = update.Parameters.Add("@nama_prodi", SqlDbType.VarChar, 100);
            param.Direction = ParameterDirection.Input;
            param.SourceColumn = "nama_prodi";
            param.SourceVersion = DataRowVersion.Current;

            param = update.Parameters.Add("@singkatan", SqlDbType.VarChar, 10);
            param.Direction = ParameterDirection.Input;
            param.SourceColumn = "singkatan";
            param.SourceVersion = DataRowVersion.Current;

            param = update.Parameters.Add("@ka_prodi", SqlDbType.VarChar, 50);
            param.Direction = ParameterDirection.Input;
            param.SourceColumn = "ka_prodi";
            param.SourceVersion = DataRowVersion.Current;

            param = update.Parameters.Add("@sek_prodi", SqlDbType.VarChar, 50);
            param.Direction = ParameterDirection.Input;
            param.SourceColumn = "sek_prodi";
            param.SourceVersion = DataRowVersion.Current;

            param = update.Parameters.Add("@id_prodi", SqlDbType.VarChar, 50);
            param.Direction = ParameterDirection.Input;
            param.SourceColumn = "id_prodi";
            param.SourceVersion = DataRowVersion.Current;

            //set update command
            adapter.UpdateCommand = update;

            // Perhatikan juga mengenai Transaksi... ini sangat penting!!!
            // Pelajari..!!!
            //memulai sebuah transaksi baru
            SqlTransaction transaction = connection.BeginTransaction();
            adapter.InsertCommand.Transaction = transaction;
            adapter.UpdateCommand.Transaction = transaction;
            adapter.DeleteCommand.Transaction = transaction;

            //exception handler untuk melakukan update
            //jika gagal, akan mengulang kembali
            try
            {
                //memanggil method update dari dataadapter
                int rowsUpdate = adapter.Update(dsProdi1, "msprodi");

                //panggil method commit dari object transaction
                //digunakan untuk melakukan (yang disimpan) transaksi berjalan
                //membuat perubahan permanen
                transaction.Commit();

                //jika data berhasil diperbarui, muncul pesan dari refresh dataset
                MessageBox.Show(rowsUpdate.ToString() + " baris diperbarui", "informasi",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshDataSet();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Unable to update: " + ex.Message);

                //mengulang kembali transaksi berjalan berarti membatalkan perubahan
                transaction.Rollback();
            }

            // Coba hilangkan comment dari baris berikut, untuk mengetahui command yang dibuat
            // oleh sqlcommandbuilder
            //MessageBox.Show(myAdapter.InsertCommand.CommandText);
            // MessageBox.Show(myAdapter.UpdateCommand.CommandText);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsProdi1.msprodi' table. You can move, or remove it, as needed.
            this.msprodiTableAdapter.Fill(this.dsProdi1.msprodi);

        }
    }

}
