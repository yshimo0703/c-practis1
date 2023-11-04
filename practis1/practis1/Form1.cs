using System.Data;

namespace practis1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // データテーブル宣言
            DataTable dt = new DataTable();

            // データテーブルの列を作成
            dt.Columns.Add("管理番号");
            dt.Columns.Add("カテゴリ");
            dt.Columns.Add("品名");

            // データテーブルの行を作成
            DataRow dr;
            dr = dt.NewRow();
            dr["管理番号"] = "N001";
            dr["カテゴリ"] = "製品";
            dr["品名"] = "A001";
            dt.Rows.Add(dr);

            // データテーブルの行を作成
            dr = dt.NewRow();
            dr["管理番号"] = "N002";
            dr["カテゴリ"] = "部品";
            dr["品名"] = "B001";
            dt.Rows.Add(dr);
            dataGridView1.DataSource = dt;


        }
    }
}