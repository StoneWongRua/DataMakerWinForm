using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataMakerWinform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            resultText.Text = "";
        }
        public void getRandnum()
        {
            Random rd = new Random();
            ArrayList arrayList = new ArrayList();
            int maxnum = int.Parse(rTb.Text);
            for (int i = 0; i < maxnum; ++i)
            {
                arrayList.Add(rd.Next(0, 200));
            }
            for (int j = 0; j < maxnum; ++j)
            {
                resultText.Text += arrayList[j].ToString() + " ";
            }           
            
        }

        private void btn_Click(object sender, EventArgs e)
        {
            if (rTb.Text == "")
            {
                MessageBox.Show("请输入总数！", "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }
            if (int.Parse(rTb.Text) <= 0)
            {
                MessageBox.Show("请输入有效的正数！", "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }
            if ((startButton.Text).Equals("开始") == true)
            {
                startButton.Text = "重新";
                getRandnum();

            }
            else {
                resultText.Text = " ";
            }

        }

        private void Result_Click(object sender, EventArgs e)
        {

        }

        private void Result_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}