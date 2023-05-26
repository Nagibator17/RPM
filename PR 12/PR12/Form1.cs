using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR12
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
                 
               
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            var arr = new int[dataGridView1.RowCount, dataGridView1.ColumnCount];

            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j <dataGridView1.ColumnCount; j++)
                {
                    arr[i, j] = rnd.Next(0, 101);
                    dataGridView1.Rows[i].Cells[j].Value = arr[i, j];
                }
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            dataGridView1.RowCount = (int)numericUpDown1.Value;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

            dataGridView1.ColumnCount = (int)numericUpDown2.Value;
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            dataGridView2.RowCount = (int)numericUpDown4.Value;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            var arr = new int[dataGridView2.RowCount, dataGridView2.ColumnCount];

            for (int i = 0; i < dataGridView2.RowCount; i++)
            {
                for (int j = 0; j < dataGridView2.ColumnCount; j++)
                {
                    arr[i, j] = rnd.Next(0, 101);
                    dataGridView2.Rows[i].Cells[j].Value = arr[i, j];
                }
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            dataGridView2.RowCount = dataGridView1.RowCount;
            dataGridView2.ColumnCount = dataGridView1.ColumnCount;
            for (int i=0; i < dataGridView1.RowCount; i++)
            {
                for (int j=0; j < dataGridView1.ColumnCount; j++)
                {
                    dataGridView2[j, i].Value = dataGridView1[j, i].Value;
                }
            }
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            dataGridView2.ColumnCount = (int)numericUpDown3.Value;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            dataGridView1.RowCount = dataGridView2.RowCount;
            dataGridView1.ColumnCount = dataGridView2.ColumnCount;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    dataGridView1[j, i].Value = dataGridView2[j, i].Value;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount != dataGridView2.RowCount)
            {
                if(dataGridView1.ColumnCount != dataGridView2.ColumnCount)
                {
                    MessageBox.Show("", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);                    
                }
            }
            else
            {
                dataGridView3.RowCount = dataGridView1.RowCount;
                dataGridView3.ColumnCount = dataGridView1.ColumnCount;
                dataGridView1.RowCount = dataGridView3.RowCount;
                dataGridView1.ColumnCount = dataGridView3.ColumnCount;
                double sum = 0;

                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    {
                        double tempo = 0;
                        double obosrish = 0;
                        tempo = sum + Convert.ToDouble(dataGridView1[i, j].Value);
                        obosrish = tempo + Convert.ToDouble(dataGridView2[i, j].Value);
                        dataGridView3.Rows[j].Cells[i].Value = obosrish;
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount != dataGridView2.RowCount)
            {
                if (dataGridView1.ColumnCount != dataGridView2.ColumnCount)
                {
                    MessageBox.Show("", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);     
                }
            }
            else
            {
                dataGridView3.RowCount = dataGridView1.RowCount;
                dataGridView3.ColumnCount = dataGridView1.ColumnCount;
                dataGridView1.RowCount = dataGridView3.RowCount;
                dataGridView1.ColumnCount = dataGridView3.ColumnCount;
                double sum = 0;

                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    {
                        double tempo = 0;
                        double obosrish = 0;
                        tempo = Convert.ToDouble(dataGridView1[i, j].Value);
                        obosrish = tempo - Convert.ToDouble(dataGridView2[i, j].Value);
                        dataGridView3.Rows[j].Cells[i].Value = obosrish;
                    }
                }
            }          
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount != dataGridView2.RowCount)
            {
                if (dataGridView1.ColumnCount != dataGridView2.ColumnCount)
                {
                    MessageBox.Show("", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);            
                }
            }
            else
            {
                dataGridView3.RowCount = dataGridView1.RowCount;
                dataGridView3.ColumnCount = dataGridView1.ColumnCount;
                dataGridView1.RowCount = dataGridView3.RowCount;
                dataGridView1.ColumnCount = dataGridView3.ColumnCount;
              

                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    {
                        double tempo = 0;
                        double obosrish = 0;
                        tempo = Convert.ToDouble(dataGridView1[i, j].Value);
                        obosrish = tempo * Convert.ToDouble(dataGridView2[i, j].Value);
                        dataGridView3.Rows[j].Cells[i].Value = obosrish;
                    }
                }
            }
        }
    }
}
