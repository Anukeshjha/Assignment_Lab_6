using System.Data.SqlClient;
using System.Xml.Linq;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadData();
        }
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-K9FU71U8;Initial Catalog=Stu;;Integrated Security=True;");
        SqlCommand cmd;
        SqlDataReader read;
        SqlDataAdapter drr;
        string id;
        bool Mode = true;
        string sql;

        public void LoadData()
        {
            try
            {
                sql = "select * from student";
                cmd = new SqlCommand(sql, con);
                con.Open();
                read = cmd.ExecuteReader();
                dataGridView1.Rows.Clear();

                while (read.Read())
                {
                    dataGridView1.Rows.Add(read[0], read[1], read[2], read[3]);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
        public void getID(String id)
        {
            sql = "select * from student where id = '" + id + "'  ";
            cmd = new SqlCommand(sql, con);
            con.Open();
            read = cmd.ExecuteReader();

            while (read.Read())
            {
                textBox2.Text = read[1].ToString();
                textBox1.Text = read[2].ToString();
                textBox3.Text = read[3].ToString();
            }
            con.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == dataGridView1.Columns["Edit"].Index && e.RowIndex >= 0)
            {
                Mode = false;
                id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                getID(id);
                EDIT.Text = "Edit";

            }
            else if (e.ColumnIndex == dataGridView1.Columns["Delete"].Index && e.RowIndex >= 0)
            {
                Mode = false;
                id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                sql = "delete from student where id  = @id ";
                con.Open();
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@id ", id);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Deleteeeee");
                con.Close();
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string name = textBox2.Text;
            string course = textBox1.Text;
            string fee = textBox3.Text;

            if (Mode == true)
            {
                sql = "insert into student(stname,course,fee) values(@stname,@course,@fee)";
                con.Open();
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@stname", name);
                cmd.Parameters.AddWithValue("@course", course);
                cmd.Parameters.AddWithValue("@fee", fee);
                MessageBox.Show("Record Addddedddd");
                cmd.ExecuteNonQuery();

                textBox2.Clear();
                textBox1.Clear();
                textBox3.Clear();
                textBox2.Focus();

            }
            else
            {
                id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                sql = "update student set stname = @stname, course= @course,fee = @fee where id = @id";
                con.Open();
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@stname", name);
                cmd.Parameters.AddWithValue("@course", course);
                cmd.Parameters.AddWithValue("@fee", fee);
                cmd.Parameters.AddWithValue("@id", id);
                MessageBox.Show("Record Updateddddd");
                cmd.ExecuteNonQuery();


                textBox2.Clear();
                textBox1.Clear();
                textBox3.Clear();
                textBox2.Focus();
                button3.Text = "Save";
                Mode = true;

            }
            con.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox1.Clear();
            textBox3.Clear();
            textBox2.Focus();
            button3.Text = "Save";
            Mode = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoadData();

        }
    }
}