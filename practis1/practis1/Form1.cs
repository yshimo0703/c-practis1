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
            // �f�[�^�e�[�u���錾
            DataTable dt = new DataTable();

            // �f�[�^�e�[�u���̗���쐬
            dt.Columns.Add("�Ǘ��ԍ�");
            dt.Columns.Add("�J�e�S��");
            dt.Columns.Add("�i��");

            // �f�[�^�e�[�u���̍s���쐬
            DataRow dr;
            dr = dt.NewRow();
            dr["�Ǘ��ԍ�"] = "N001";
            dr["�J�e�S��"] = "���i";
            dr["�i��"] = "A001";
            dt.Rows.Add(dr);

            // �f�[�^�e�[�u���̍s���쐬
            dr = dt.NewRow();
            dr["�Ǘ��ԍ�"] = "N002";
            dr["�J�e�S��"] = "���i";
            dr["�i��"] = "B001";
            dt.Rows.Add(dr);
            dataGridView1.DataSource = dt;


        }
    }
}