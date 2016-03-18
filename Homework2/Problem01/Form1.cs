using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Problem01
{
    public partial class Form1 : Form
    {
        private string[] player = new string[10];
        private int[] computer = new int[10];
        private int x, y;
        private Random randoms = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "猜四值";
            label3.Text = "";
            label4.Text = "";

            for (int i = 0; i < 10; i++)
            {
                computer[i] = i;
            }
            computers();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.MaxLength = 4;  //設定長度只能最多只能輸入4碼
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String num = "";
            int a = 0, b = 0;
            for (int t = 0; t < 4; t++)
            {
                player[t] = textBox1.Text.Substring(t, 1);  //抓取輸入的四碼
                num += player[t];
            }

            if (player[0] == player[1] || player[0] == player[2]  //判斷輸入的值是否重複
             || player[0] == player[3] || player[1] == player[2]
             || player[1] == player[3] || player[2] == player[3])
            {
                label4.Text = "判斷有相同數值\n請重新輸入";
            }
            else
            {
                for (int m = 0; m < 4; m++)
                {
                    for (int n = 0; n < 4; n++)
                    {
                        if (player[m] == computer[n].ToString()) //判斷輸入的4值和亂數產生的答案是否相同
                        {
                            if (m == n) { a++; }
                            else if (m != n) { b++; }
                        }
                    }
                }
                textBox2.Text += num + "(" + a.ToString() + "A" + b.ToString() + "B)" + "\r\n";
                label2.Text = "你猜了" + (textBox2.Lines.Length - 1) + "次";
                textBox1.Focus(); textBox1.SelectAll();
            }

            if (a == 4) { label3.Text = "恭喜你猜對了"; }
            else if (textBox2.Lines.Length != 0)
            { label3.Text = a.ToString() + "個位置正確\n" + b.ToString() + "個位置錯誤"; }
            else { label3.Text = ""; }
        }

        private void button2_Click(object sender, EventArgs e)  //等於空白 產生新的4值
        {
            label2.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            computers();
        }

        private void button3_Click(object sender, EventArgs e) //顯示亂數產生的答案
        {
            label4.Text = "";
            for (int i = 1; i <= 4; i++)
            {
                label4.Text += computer[i];
            }
        }

        private void computers() //產生亂數4值，不重複
        {
            for (int i = 0; i < 10; i++)
            {
                y = randoms.Next(0, 10 - i);
                x = computer[y];
                computer[y] = computer[9 - i];
                computer[9 - i] = x;
            }
        }
    }
}