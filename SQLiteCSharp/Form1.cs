using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;
using System.Text.RegularExpressions;
using System.Security.Cryptography;
using System.Text;
using Microsoft.Win32;

namespace SQLiteCSharp
{
    public partial class Form1 : Form
    {
        private SQLiteConnection Conn;
        private int sum;
        public static String dbName = "test.sqlite";
        private SQLiteCommand Cmd    = new SQLiteCommand();
        public static String Login         = "default";
        private string Pass          = "default";
        private string PassEnter     = "default";
        private DataTable Table      = new DataTable();
        private DataTable Table2     = new DataTable();
        private DataTable Table3     = new DataTable();
        private String[] stavka      = new string[1024];
        private String[] procGOD     = new string[1024];
        private String[] procLIM     = new string[1024];
        private String[] date        = new string[1024];
        private String[] elements    = new string[1024];
        private String[] dateSplit   = new string[1024];
        private String[] dtNowSplit  = new string[1024];
        private    int[] zpSub       = new    int[1024];
        private    int[] zpUser      = new    int[1024];
        private string[] separators  = { ",", ".", "/", "\\", ":", " " };
        private int years, mont, days, procGODint, procLIMint, stavkaint;

        //    ^^    ^^    ^^    ^^    ПЕРЕМЕННЫЕ    ^^    ^^    ^^    ^^    ^^    ^^    ^^   ^^    
        public Form1()
        {
            InitializeComponent();
        }

        public void LogStat1()
        {
            //dbName = "test.sqlite";
            String Query4user = "SELECT [ФИО_Сотрудника], [Дата_поступления_на_работу], [Группа], [Ставка], [ФИО_Начальника], [Процент_за_год_работы], [Не_более_процентов] FROM Staff where [Логин]='";
            String Query4sub  = "SELECT [ФИО_Сотрудника], [Дата_поступления_на_работу], [Группа], [Ставка], [ФИО_Начальника], [Процент_за_год_работы], [Не_более_процентов] FROM Staff where [Логин_Начальника]='";
            String Query4root = "SELECT [ФИО_Сотрудника], [Дата_поступления_на_работу], [Группа], [Ставка], [ФИО_Начальника], [Процент_за_год_работы], [Не_более_процентов] FROM Staff";

            //------------------------------------------------------------------------------------//***//
            Conn = new SQLiteConnection();                                                       //***//  подключение
            Conn = new SQLiteConnection("Data Source=" + dbName + ";New=False; Version=3;");    //***//  к
            Conn.Open();                                                                       //***//  базе
            Cmd.Connection = Conn;                                                            //***//  данных
            //-------------------------------------------------------------------------------//***//

           

            //*********************   информация о пользователе   *******************************************************************************

            Table.Clear();
            if (Login != "root")          //      получение информации не для root
            {
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(Query4user + Login + "'", Conn);
                adapter.Fill(Table);
                btAddUser.Visible = false;
                btAddUser.Enabled = false;
                btSumZp.Visible = false;
                btSumZp.Enabled = false;

            }


            else                      //      получение информации для root
            {
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(Query4root, Conn);
                adapter.Fill(Table);

                pictureBox1.Visible = false;
                label1.Visible = false;
                dataView4sub.Visible = false;
                btAddUser.Visible = true;
                btAddUser.Enabled = true;
                btSumZp.Visible = true;
                btSumZp.Enabled = true;

                dataView4user.Size = new System.Drawing.Size(763, 314);
               
            }


            /*      выдача информации        */
            if (Table.Rows.Count > 0)
            {
                dataView4user.Rows.Clear();
                for (int i = 0; i < Table.Rows.Count; i++)
                {
                    dataView4user.Rows.Add(Table.Rows[i].ItemArray);     //  прорисовка таблицы
                        dataView4sub.Rows.Add(Table.Rows[i].ItemArray);  //  прорисовка второй таблицы

                        date[i] = Table.Rows[i][1].ToString();           //  вытаскиваем
                        stavka[i] = Table.Rows[i][3].ToString();         //  данные
                        procGOD[i] = Table.Rows[i][5].ToString();        //  для
                        procLIM[i] = Table.Rows[i][6].ToString();        //  подсчета зп

                        dateSplit = date[i].Split(separators, StringSplitOptions.RemoveEmptyEntries);  // разложение даты на составляющие

                    try
                    {
                        years = Int32.Parse(dtNowSplit[2]) - Int32.Parse(dateSplit[2]);   //  считаем разницу годов
                        mont = Int32.Parse(dtNowSplit[1]) - Int32.Parse(dateSplit[1]);    //  считаем разницу месяцев
                        days = Int32.Parse(dtNowSplit[0]) - Int32.Parse(dateSplit[0]);    //  считаем разницу дней
                    }
                    catch (IndexOutOfRangeException ex)
                    {
                        if (ex.Message== "Индекс находился вне границ массива.")
                        { MessageBox.Show("Проверьте правильность введенной даты"); }
                    }

                        procGODint = Convert.ToInt32(procGOD[i]);          //  древняя магия
                        procLIMint = Convert.ToInt32(procLIM[i]);          //  не трогать
                        stavkaint = Convert.ToInt32(stavka[i]);            //
                        if (mont <= 1 && days <= 1)
                        { years--; }
                        

                        if (procGODint * years <= procLIMint)
                        {
                             zpUser[i] = stavkaint + stavkaint / 100 * procGODint * years;   // считаем зп
                             dataView4user[5, i].Value = zpUser[i];                          // рисуем зп в таблицу
                        }
                        else
                        {
                             zpUser[i] = stavkaint + stavkaint / 100 * procLIMint;           // считаем зп
                             dataView4user[5, i].Value = zpUser[i];                          // рисуем зп в таблицу
                        }
                }
            }
            else
            { MessageBox.Show("База данных пуста"); }

            //*********************   информация о подчиненных   *******************************************************************************
            Table.Clear();
            SQLiteDataAdapter adapter2 = new SQLiteDataAdapter(Query4sub + Login + "'", Conn);
            adapter2.Fill(Table);
            dataView4sub.Rows.Clear();
            for (int i = 0; i < Table.Rows.Count; i++)
            {
                dataView4sub.Rows.Add(Table.Rows[i].ItemArray);   // рисуем таблицу

                date[i] = Table.Rows[i][1].ToString();            //  вытаскиваем
                stavka[i] = Table.Rows[i][3].ToString();          //  данные
                procGOD[i] = Table.Rows[i][5].ToString();         //  для
                procLIM[i] = Table.Rows[i][6].ToString();         //  подсчета зп

                dateSplit = date[i].Split(separators, StringSplitOptions.RemoveEmptyEntries);  // разложение даты на составляющие

                years = Int32.Parse(dtNowSplit[2]) - Int32.Parse(dateSplit[2]);   //  считаем разницу годов
                mont = Int32.Parse(dtNowSplit[1]) - Int32.Parse(dateSplit[1]);    //  считаем разницу месяцев
                days = Int32.Parse(dtNowSplit[0]) - Int32.Parse(dateSplit[0]);    //  считаем разницу дней

                procGODint = Convert.ToInt32(procGOD[i]);          //  древняя магия
                procLIMint = Convert.ToInt32(procLIM[i]);          //  не трогать
                stavkaint = Convert.ToInt32(stavka[i]);            //
                if (mont <= 1 && days <= 1)
                { years--; }

                if (procGODint * years <= procLIMint)
                {
                    zpSub[i] = stavkaint + stavkaint / 100 * procGODint * years;   // считаем зп
                    dataView4sub[5, i].Value = zpSub[i];                           // рисуем зп в таблицу
                }
                else
                {
                    zpSub[i] = stavkaint + stavkaint / 100 * procLIMint;           // считаем зп
                    dataView4sub[5, i].Value = zpSub[i];                           // рисуем зп в таблицу
                }
            }
            Conn.Close();   
        }

        private void TbUpdate_Click(object sender, EventArgs e)
        {
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            LogStat1();
        }

        private void ToolStripButton2_Click(object sender, EventArgs e)
        {
            Form4 upd = new Form4();
            upd.ShowDialog();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //---------++++++++++---------++++++++----------++++++++++-----------++++++++++---------++++++++++

            for (int i = 0; i < zpUser.Length; i++)
            {
                sum+=zpUser[i];
                
            }
            MessageBox.Show("Суммарная зарплата всех сотрудников фирмы: "+sum+"р.");

        }

        static string Md5(string data)
        {
            var provider = new MD5CryptoServiceProvider();
            var hash = provider.ComputeHash(Encoding.UTF8.GetBytes(data));
            return BitConverter.ToString(hash).Replace("-", "").ToLower();
        }

        public void Auth()
        {
            DataTable Table = new DataTable();
            String QueryPass = "SELECT [Пароль] FROM Pass where [Логин]='";

            /*     подключение к базе данных     */
            if (File.Exists(dbName))                                        //  проверка существует ли файл базы данных
            {
                Conn = new SQLiteConnection("Data Source=" + dbName + ";New=False; Version=3;");
                Conn.Open();
                Cmd.Connection = Conn;

                try   //    получение информации о пароле пользователя
                {
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter(QueryPass + Login + "'", Conn);
                    adapter.Fill(Table);
                    if (Table.Rows.Count != 0)
                        Pass = Table.Rows[0][0].ToString();
                }
                catch (SQLiteException ex)
                {
                    MessageBox.Show("Неверная связка логин-пароль.");
                    My_load();
                }


                string hash1 = Md5(PassEnter);
                string hash2 = Md5(hash1);


                if (Pass == hash2) //   если введен верный пароль 
                {

                    LogStat1();  //   запустить функцию LogStat1
                }
                else
                {
                    MessageBox.Show("Неверная связка логин-пароль.");
                    My_load();
                }
            }
            else
            {
                Form5 baseFile = new Form5();           //        инициализация пятой формы       
                baseFile.ShowDialog();
            }
            Conn.Close();
        }


        public void My_load()
        {
            dtNowSplit = DateTime.Now.ToString().Split(separators, StringSplitOptions.RemoveEmptyEntries);
            Form2 log = new Form2();           //        инициализация второй формы       
            log.ShowDialog();                 //                 вызов второй формы

            Login = log.DataLog();          //           ловим отправленный второй формой логин
            PassEnter = log.DataPass();    //            ловим отправленный второй формой пароль

            Auth();                      //              функция аутентификации
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*.......ПРИ ЗАГРУЗКЕ ФОРМЫ........*/

            RegistryKey currentUserKey = Registry.CurrentUser;
            RegistryKey Key = currentUserKey.CreateSubKey("SQLCSharp");
            try
            {
                dbName = Key.GetValue("dbName").ToString();                // считываем путь до файла базы с реестра
            }
            catch(NullReferenceException ex)
            { if (ex.Message == "Ссылка на объект не указывает на экземпляр объекта.")       //  если в реестре его нет
                {
                    Key.SetValue("dbName", dbName);                                           // записываем его в реестр
                }
            }
           

            
            if (!File.Exists(dbName))                                        //  проверкасуществует ли файл базы данных
            {
                Form5 baseFile = new Form5();           //        инициализация пятой формы       
                baseFile.ShowDialog();
            }
            Key.Close();
            My_load();

        }

        private void BtAddUser_Click(object sender, EventArgs e)
        {
            Form3 add = new Form3();                  
            add.ShowDialog();

        }
    }
}
