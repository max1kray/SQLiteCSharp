using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Security.Cryptography;
using System.Text;

namespace SQLiteCSharp
{
    public partial class Form3 : Form
    {
        

        public Form3()
        {
            InitializeComponent();
        }

        static string Md5(string data)
        {
            var provider = new MD5CryptoServiceProvider();
            var hash = provider.ComputeHash(Encoding.UTF8.GetBytes(data));
            return BitConverter.ToString(hash).Replace("-", "").ToLower();
        }

       

        private void Button1_Click_1(object sender, EventArgs e)
        {
                     String[] dateSplit = new string[1024];
                     String[] dtNowSplit = new string[1024];

            try
            {
                    SQLiteConnection Conn;
                   // String dbName = "test.sqlite";
                    SQLiteCommand Cmd = new SQLiteCommand();
                    SQLiteCommand Cmd2 = new SQLiteCommand();
                    DataTable Table = new DataTable();
                    String NachLog = "default";
                    Table.Clear();
                    String QueryAdd = "select[Логин] from Staff where [ФИО_Сотрудника] = '" + tbNACH.Text + "'";   // первый запрос 

                Conn = new SQLiteConnection("Data Source=" + Form1.dbName + ";New=False; Version=3;");
                Conn.Open();
                Cmd.Connection = Conn;
                Cmd2.Connection = Conn;

                string hash1 = Md5(tbPASS.Text);
                string hash2 = Md5(hash1);

                if (tbNACH.Text != "")
                {
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter(QueryAdd, Conn);      // вытаскиваем  
                    adapter.Fill(Table);                                                    // логин начальника

                    if (Table.Rows.Count > 0)
                    {
                        NachLog = Table.Rows[0][0].ToString();
                    }
                    else
                    {
                        tbNACH.Text = "";
                        NachLog = "";
                    }
                }
                else
                {
                    tbNACH.Text = "";
                    NachLog = "";
                }

                    DateTime dt = (DateTime)Convert.ChangeType(tbDATE.Text, typeof(DateTime));
                    
                //  второй запрос 
                Cmd.CommandText = "INSERT INTO Staff ([ФИО_Сотрудника], [Логин], [Дата_поступления_на_работу], [Группа], [Ставка], [Процент_за_год_работы], [Не_более_процентов], [ФИО_Начальника], [Логин_Начальника])  values('" + tbFIO.Text + "','" + tbLOGIN.Text + "','" + tbDATE.Text + "','" + tbGROUP.Text + "','" + tbSTAVKA.Text + "','" + tbPROC.Text + "','" + tbLIM.Text + "','" + tbNACH.Text + "','" + NachLog + "')";
                //  третий запрос
                Cmd2.CommandText = "INSERT INTO Pass (Логин, Пароль) values('" + tbLOGIN.Text + "','" + hash2 + "')";

                Cmd.ExecuteReader();       //выполняем второй запрос       
                Cmd2.ExecuteReader();       // выполняем третий запрос

                Conn.Close();

                tbFIO.Text = "";          //  визуальные эффекты
                tbDATE.Text = "";
                tbGROUP.Text = "";
                tbLIM.Text = "";
                tbLOGIN.Text = "";
                tbNACH.Text = "";
                tbPASS.Text = "";
                tbPROC.Text = "";
                tbSTAVKA.Text = "";

                MessageBox.Show("Сотрудник добавлен");

            }

            catch (SQLiteException ex)
            {
                if (ex.ErrorCode == 19)
                MessageBox.Show("Данный сотрудник уже есть в базе данных");

            }
            catch (FormatException form)
            {
                if (form.Message == "Строка не распознана как действительное значение DateTime.")
                    MessageBox.Show("Проверьте правильность введенной даты");
                tbDATE.Text = "";
            }
        }

        private void IfAdd_CheckedChanged(object sender, EventArgs e)
        {
                //   визуальные эффекты при переключении радиобатонов
            pictureBox1.Visible = false;
            pictureBox1.Enabled = false;
            button2.Visible     = false;
            button2.Enabled     = false;
            label3.Visible      = false;
            label3.Enabled      = false;
            label10.Visible     = true;
            label10.Enabled     = true;
            label9.Visible      = true;
            label9.Enabled      = true;
            label8.Visible      = true;
            label8.Enabled      = true;
            label7.Visible      = true;
            label7.Enabled      = true;
            label6.Visible      = true;
            label6.Enabled      = true;
            label5.Visible      = true;
            label5.Enabled      = true;
            label4.Visible      = true;
            label4.Enabled      = true;
            label2.Visible      = true;
            label2.Enabled      = true;
            label1.Visible      = true;
            label1.Enabled      = true;
            tbFIO.Visible       = true;
            tbFIO.Enabled       = true;
            tbDATE.Visible      = true;
            tbDATE.Enabled      = true;
            tbGROUP.Visible     = true;
            tbGROUP.Enabled     = true;
            tbLIM.Visible       = true;
            tbLIM.Enabled       = true;
            tbLOGIN.Visible     = true;
            tbLOGIN.Enabled     = true;
            tbNACH.Visible      = true;
            tbNACH.Enabled      = true;
            tbPASS.Visible      = true;
            tbPASS.Enabled      = true;
            tbPROC.Visible      = true;
            tbPROC.Enabled      = true;
            tbSTAVKA.Visible    = true;
            tbSTAVKA.Enabled    = true;
            button1.Visible     = true;
            button1.Enabled     = true;
            tbFIO.Text    = "";
            tbDATE.Text   = "";
            tbGROUP.Text  = "";
            tbLIM.Text    = "";
            tbLOGIN.Text  = "";
            tbNACH.Text   = "";
            tbPASS.Text   = "";
            tbPROC.Text   = "";
            tbSTAVKA.Text = "";
           
        }

        private void IfDel_CheckedChanged(object sender, EventArgs e)
        {
            //   визуальные эффекты при переключении радиобатонов

            pictureBox1.Visible = true;
            pictureBox1.Enabled = true;
            label3.Visible      = true;
            label3.Enabled      = true;
            label10.Visible     = false;
            label10.Enabled     = false;
            label8.Visible      = false;
            label8.Enabled      = false;
            label7.Visible      = false;
            label7.Enabled      = false;
            label6.Visible      = false;
            label6.Enabled      = false;
            label5.Visible      = false;
            label5.Enabled      = false;
            label4.Visible      = false;
            label4.Enabled      = false;
            label2.Visible      = false;
            label2.Enabled      = false;
            label1.Visible      = false;
            label1.Enabled      = false;
            tbFIO.Visible       = false;
            tbFIO.Enabled       = false;
            tbDATE.Visible      = false;
            tbDATE.Enabled      = false;
            tbGROUP.Visible     = false;
            tbGROUP.Enabled     = false;
            tbLIM.Visible       = false;
            tbLIM.Enabled       = false;
            tbNACH.Visible      = false;
            tbNACH.Enabled      = false;
            tbPASS.Visible      = false;
            tbPASS.Enabled      = false;
            tbPROC.Visible      = false;
            tbPROC.Enabled      = false;
            tbSTAVKA.Visible    = false;
            tbSTAVKA.Enabled    = false;
            button1.Visible     = false;
            button1.Enabled     = false;
            button2.Visible     = true;
            button2.Enabled     = true;
            tbFIO.Text    = "";
            tbDATE.Text   = "";
            tbGROUP.Text  = "";
            tbLIM.Text    = "";
            tbLOGIN.Text  = "";
            tbNACH.Text   = "";
            tbPASS.Text   = "";
            tbPROC.Text   = "";
            tbSTAVKA.Text = "";
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            ifAdd.Checked = true;
            
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                 SQLiteConnection Conn;
                // String dbName = "test.sqlite";
                 SQLiteCommand Cmd = new SQLiteCommand();
                 SQLiteCommand Cmd2 = new SQLiteCommand();
                 DataTable Table = new DataTable();

                Table.Clear();

                Conn = new SQLiteConnection("Data Source=" + Form1.dbName + ";New=False; Version=3;");
                Conn.Open();

                Cmd.Connection = Conn;
                Cmd2.Connection = Conn;

                Cmd.CommandText = "DELETE FROM Staff WHERE[Логин] = '" + tbLOGIN.Text + "'";  // первый запрос
                Cmd2.CommandText = " DELETE FROM Pass WHERE[Логин] = '" + tbLOGIN.Text + "'";  // второй запрос
               
                Cmd.ExecuteReader();   // выполняем первый запрос
                Cmd2.ExecuteReader();  // выполняем второй запрос

                Conn.Close();

                MessageBox.Show("Сотрудник удален");
            }

            catch (SQLiteException ex)
            { MessageBox.Show("error " + ex); }
        }
    }
}
