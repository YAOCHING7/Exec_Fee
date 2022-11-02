using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Exec_Fee
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			bool gender = radioButton1.Checked;
			int age = Convert.ToInt32(textBox1.Text);
			int fee = calcFee(gender, age);
			if (age <= 3)
			{
			label6.Text = "年齡小於3不用錢";
			}
			else if (gender == true && age >= 70)
			{ label6.Text = "男性超過70歲2塊錢"; }
			else if (gender == false && age >= 60)
			{ label6.Text = "女姓超過60歲3塊錢"; }
			else
			{ label6.Text = "全票15元"; }
			label4.Text = fee.ToString();
		}

		static int calcFee(bool gender, int age)
		{
			int fee = 0;
			if (age <= 3)
			{
				fee = 0;
			}
			else if (gender == true && age >= 70)
			{ fee = 2; }
			else if (gender == false && age >= 60)
			{ fee = 3; }
			else
			{ fee = 15;}
			return fee;
			

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
