using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data;
using System.IO;

namespace SQLiteCSharp
{
    public partial class Form2 : Form
    {
        
        



        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
        }

        public string DataLog()
        {     
                return tbLogin.Text;             //   возврат логина
        }

        public string DataPass()
        {
            return tbPass.Text;                  //   возврат пароля
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            /*..........ПРИ НАЖИТИИ НА КНОПКУ.........*/
            DataLog();                            //   функция возврата введенного логина
            DataPass();                          //    функция возврата введенного пароля
            this.Close();                       //     закрыть форму
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (tbLogin.Text == "") Environment.Exit(0);
        }
    }
}
