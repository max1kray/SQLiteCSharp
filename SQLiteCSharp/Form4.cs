using System;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Security.Cryptography;
using System.Text;
using System.Data;


namespace SQLiteCSharp
{
    public partial class Form4 : Form
    {
        private string PassHash = "default";
        private string hash1    = "default";
        private string hash2    = "default";
        //private String dbName   = "test.sqlite";
        private SQLiteConnection Conn = new SQLiteConnection();
        private SQLiteCommand     Cmd = new SQLiteCommand();
        private SQLiteCommand    Cmd2 = new SQLiteCommand();
        private SQLiteCommand    Cmd3 = new SQLiteCommand();
        private DataTable       Table = new DataTable();

        public Form4()
        {
            InitializeComponent();
        }

        private void RbLogin_CheckedChanged(object sender, EventArgs e)
        {//*************************************************************
            tbOldPass.Text  = "";//*************************************
            tbNewPass.Text  = "";//*************************************
            tbNewPass2.Text = "";//*************************************
            lOldPass.Visible   = false;//*******************************
            lOldPass.Enabled   = false;//*******************************
            lNewPass.Visible   = false;//*******************************
            lNewPass.Enabled   = false;//*******************************
            lNewPass2.Visible  = false;//*******************************
            lNewPass2.Enabled  = false;//*******************************
            tbOldPass.Visible  = false;//*******************************
            tbOldPass.Enabled  = false;//*******************************
            tbNewPass.Visible  = false;//*******************************
            tbNewPass.Enabled  = false;//*******************************
            tbNewPass2.Visible = false;//*******************************
            tbNewPass2.Enabled = false;//*******************************
            btPass.Visible     = false;//*******************************
            btPass.Enabled     = false;//*******************************
//**********************************************************************
            lOldLog.Visible    = true;//********************************
            lOldLog.Enabled    = true;//********************************
            lNewLog.Visible    = true;//********************************
            lNewLog.Enabled    = true;//********************************
            tbOldLog.Visible   = true;//********************************
            tbOldLog.Enabled   = true;//
            tbNewLog.Visible   = true;//     m    m mmmmm   mmmm  m    m   mm   m             mmmmmm mmmmmm mmmmmm mmmmmm   mmm mmmmmmm  mmmm
            tbNewLog.Enabled   = true;//     "m  m"   #    #"   " #    #   ##   #             #      #      #      #      m"   "   #    #"   "    
            btLogin.Visible    = true;//      #  #    #    "#mmm  #    #  #  #  #             #mmmmm #mmmmm #mmmmm #mmmmm #        #    "#mmm  
            btLogin.Enabled    = true;//     "mm"    #        "# #    #  #mm#  #             #      #      #      #      #        #        "#    
                                      //     ##   mm#mm  "mmm#" "mmmm" #    # #mmmmm        #mmmmm #      #      #mmmmm  "mmm"   #    "mmm#"   
        }//*****************************
//**********************************************************************
        private void RbPass_CheckedChanged(object sender, EventArgs e)//
        {//*************************************************************
            tbOldLog.Text = "";//***************************************
            tbNewLog.Text = "";//***************************************
            lOldLog.Visible    = false;//*******************************
            lOldLog.Enabled    = false;//*******************************
            lNewLog.Visible    = false;//*******************************
            lNewLog.Enabled    = false;//*******************************
            tbOldLog.Visible   = false;//*******************************
            tbOldLog.Enabled   = false;//*******************************
            tbNewLog.Visible   = false;//*******************************
            tbNewLog.Enabled   = false;//*******************************
            btLogin.Visible    = false;//*******************************
            btLogin.Enabled    = false;//*******************************
            //**********************************************************
            lOldPass.Visible   = true;//********************************
            lOldPass.Enabled   = true;//********************************
            lNewPass.Visible   = true;//********************************
            lNewPass.Enabled   = true;//********************************
            lNewPass2.Visible  = true;//********************************
            lNewPass2.Enabled  = true;//********************************
            tbOldPass.Visible  = true;//********************************
            tbOldPass.Enabled  = true;//********************************
            tbNewPass.Visible  = true;//********************************
            tbNewPass.Enabled  = true;//********************************
            tbNewPass2.Visible = true;//********************************
            tbNewPass2.Enabled = true;//********************************
            btPass.Visible     = true;//********************************
            btPass.Enabled     = true;//********************************
        }//*************************************************************
//**********************************************************************
        private void Form4_Load(object sender, EventArgs e)//***********
        {//*************************************************************
            rbLogin.Checked    = true;//********************************
            lOldPass.Visible   = false;//*******************************
            lOldPass.Enabled   = false;//*******************************
            lNewPass.Visible   = false;//*******************************
            lNewPass.Enabled   = false;//*******************************
            lNewPass2.Visible  = false;//*******************************
            lNewPass2.Enabled  = false;//*******************************
            tbOldPass.Visible  = false;//*******************************
            tbOldPass.Enabled  = false;//*******************************
            tbNewPass.Visible  = false;//******************************* 
            tbNewPass.Enabled  = false;//*******************************
            tbNewPass2.Visible = false;//*******************************
            tbNewPass2.Enabled = false;//*******************************
            btPass.Visible     = false;//*******************************
            btPass.Enabled     = false;//*******************************
//**********************************************************************
            lOldLog.Visible    = true;//********************************
            lOldLog.Enabled    = true;//********************************
            lNewLog.Visible    = true;//********************************
            lNewLog.Enabled    = true;//********************************
            tbOldLog.Visible   = true;//********************************
            tbOldLog.Enabled   = true;//********************************
            tbNewLog.Visible   = true;//********************************
            tbNewLog.Enabled   = true;//********************************
            btLogin.Visible    = true;//********************************
            btLogin.Enabled    = true;//********************************
        }//*************************************************************

        private void BtLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (Form1.Login == tbOldLog.Text)
                {
                    Conn = new SQLiteConnection("Data Source=" + Form1.dbName + ";New=False; Version=3;");
                    Conn.Open();
                    Cmd.Connection = Conn;
                    Cmd2.Connection = Conn;
                    Cmd3.Connection = Conn;
                    Cmd.CommandText = "UPDATE Staff SET [Логин] = '" + tbNewLog.Text + "' WHERE[Логин] = '" + tbOldLog.Text + "'";   //  запрос
                    Cmd2.CommandText = "UPDATE Staff SET [Логин_Начальника] = '" + tbNewLog.Text + "' WHERE[Логин_Начальника] = '" + tbOldLog.Text + "'";   //  запрос
                    Cmd3.CommandText = "UPDATE Pass SET [Логин] = '" + tbNewLog.Text + "' WHERE[Логин] = '" + tbOldLog.Text + "'";   //  запрос
                    Cmd.ExecuteReader();   // выполняем запрос
                    Cmd2.ExecuteReader();   // выполняем запрос
                    Cmd3.ExecuteReader();   // выполняем запрос
                    Conn.Close();
                    Form1.Login = tbNewLog.Text;
                    tbNewLog.Text = "";
                    tbOldLog.Text = "";
                    MessageBox.Show("Логин изменен");
                }
                else
                {
                    MessageBox.Show("Старый логин введен неверно");
                }
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Неизвестная ошибка");
            }
            catch (InvalidOperationException ex)
            {
               if(ex.Message== "Cannot set Connection while a DataReader is active")
                {
                    MessageBox.Show("Попробуйте через минуту");
                }
            }



        }

        static string Md5(string data)
        {
            var provider = new MD5CryptoServiceProvider();
            var hash = provider.ComputeHash(Encoding.UTF8.GetBytes(data));
            return BitConverter.ToString(hash).Replace("-", "").ToLower();
        }

        private void BtPass_Click(object sender, EventArgs e)
        {

            try
            {
                    
                if (tbNewPass.Text == tbNewPass2.Text)             
                  {
                    Conn = new SQLiteConnection("Data Source=" + Form1.dbName + ";New=False; Version=3;");
                    Conn.Open();
                    String QueryPass = "SELECT [Пароль] FROM Pass where [Логин]='";
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter(QueryPass + Form1.Login + "'", Conn);
                    adapter.Fill(Table);
                    Conn.Close();
                    PassHash = Table.Rows[0][0].ToString();          // вытаскиваем хеш пароля из базы

                    hash1 = Md5(tbOldPass.Text);
                    hash2 = Md5(hash1);

                    if (PassHash == hash2)
                    {
                        //*********************************************
                        hash1 = Md5(tbNewPass.Text);
                        hash2 = Md5(hash1);

                        Conn = new SQLiteConnection("Data Source=" + Form1.dbName + ";New=False; Version=3;");
                        Conn.Open();
                        Cmd.Connection = Conn;
                        Cmd.CommandText = "UPDATE Pass SET [Пароль] = '" + hash2 + "' WHERE[Логин] = '" + Form1.Login + "'";   //  запрос
                        
                        
                        Cmd.ExecuteReader();   // выполняем запрос
                        Conn.Close();
                        tbNewPass.Text = "";
                        tbOldPass.Text = "";
                        tbNewPass2.Text = "";
                        Table.Clear();
                        MessageBox.Show("Пароль изменен");

                    }

                    else
                    { MessageBox.Show("Старый пароль введен неверно"); }

                  }
                else
                     {
                    MessageBox.Show("Пароли не совпадают");
                     }

            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Неизвестная ошибка");
            }
            catch (InvalidOperationException ex)
            {
                if (ex.Message == "Cannot set Connection while a DataReader is active")
                {
                    MessageBox.Show("Попробуйте через минуту");
                }
            }
        }
    }
}
