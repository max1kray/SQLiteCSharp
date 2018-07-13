using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Data.SQLite;
using System.IO;


namespace SQLiteCSharp
{
    public partial class Form5 : Form
    {
        private int stat=0;

        public Form5()
        {
            InitializeComponent();
        }

      

        private void Form5_Load(object sender, EventArgs e)
        {
             
         }

        public void reg(string dbName)
        {
            if (Form1.dbName != "")
            {
                RegistryKey currentUserKey = Registry.CurrentUser;
                RegistryKey Key = currentUserKey.CreateSubKey("SQLCSharp");
                Key.SetValue("dbName", Form1.dbName);                      // записываем в реестр путь до нового файла базы
                Key.Close();
            }
            
        }

            private void btBrowser_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();                        // просим юзера указать файл базы
            Form1.dbName = openFileDialog1.FileName;
            reg(Form1.dbName);

          
           
        }

        private void btCreate_Click(object sender, EventArgs e)
        {
            String dbName;
            SQLiteConnection Conn = new SQLiteConnection();
            SQLiteCommand Cmd = new SQLiteCommand();
            SQLiteCommand Cmd2 = new SQLiteCommand();
            SQLiteCommand Cmd3 = new SQLiteCommand();
            // Conn 


            dbName = "test.sqlite";

            
                SQLiteConnection.CreateFile(dbName);           

                try
                {
                    Conn = new SQLiteConnection("Data Source=" + dbName + ";Version=3;");
                    Conn.Open();
                    Cmd.Connection = Conn;
                    Cmd2.Connection = Conn;
                    Cmd3.Connection = Conn;
                    // создаем таблицы в базе
                    Cmd.CommandText = "CREATE TABLE Staff(ФИО_Сотрудника TEXT (50)   UNIQUE,Логин STRING(10) UNIQUE PRIMARY KEY, Дата_поступления_на_работу STRING(8), Группа TEXT(10), Ставка INT, Процент_за_год_работы      INT, Не_более_процентов INT, Логин_Начальника           STRING(10), ФИО_Начальника TEXT(50))";
                    Cmd2.CommandText = "CREATE TABLE Pass(Логин TEXT(10) UNIQUE PRIMARY KEY, Пароль STRING    NOT NULL)";
                    //  создаем root пользователя в базе
                    Cmd3.CommandText = "INSERT INTO Pass (Логин, Пароль) values('root','913f8cfc77c2c974cc3a838cde8c7e6b')";
                    Cmd.ExecuteNonQuery();
                    Cmd2.ExecuteNonQuery();
                    Cmd3.ExecuteNonQuery();
                    Conn.Close();
                Form1.dbName = dbName;
                reg(Form1.dbName);
                MessageBox.Show("База test.sqlite создана. Пользователь по умолчанию - root/toor. \n В целях безопасности смените логин и/или пароль при первом входе в базу.");
                

                }
                catch (SQLiteException ex)
                {

                }



            
                Conn.Close();
                this.Close();
            
        }

        private void Form5_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!File.Exists(Form1.dbName))                                        //  проверка существует ли файл базы данных
            {
                Environment.Exit(0);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
