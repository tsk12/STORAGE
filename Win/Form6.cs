﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        DB_z db7 = new DB_z(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=c:\users\user\documents\visual studio 2013\Projects\WinLinq\Win\Asd.mdf;Integrated Security=True;Connect Timeout=30");
       
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show(" Строка не заполнена! Пожалуйста, введите номер заказа ");
                    return;
                }
            }
            catch { }
            var q = db7.Vivod(0);
            foreach (Заказ z in q)
            {
                var w = z.заказID.Equals(Convert.ToInt32(textBox1.Text));
                if (w==true)
                {
                    MessageBox.Show(z.Статус);
                }
                else
                {
                    MessageBox.Show("Заказа с данным номером не существует");
                }  
            }
                
            
            
        }
    }
}
