using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cpu_scheduling
{
    public partial class Form1 : Form
    {
        public string  mode;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1insert_Click(object sender, EventArgs e)
        {
            int processNumber;

            dataGridView2.Rows.Clear();
            processNumber = Convert.ToInt32(textBox2.Text);

            for (int i = 0; i < processNumber; i++)
            {
                String[] data = { "Process " + (i + 1).ToString(), "", "" };

                dataGridView2.Rows.Add(data);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
     

        private void radioButtonSTF_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonSTF.Checked)
                mode = "STF";
            

        }
        private void radioButtonSRTF_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonSRTF.Checked)
                mode = "SRTF";
            

        }
        private void radioButtonP_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonP.Checked)
                mode = "P";
            
        }

        private void radioButtonFCFS_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonFCFS.Checked)
                mode = "FCFS";
            
        }

        private void radioButtonPP_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonPP.Checked)
                mode = "PP";
        }


        private void buttonStart_Click(object sender, EventArgs e)
        {
            int length = dataGridView2.Rows.Count;
            Process[] processArray = new Process[length];
            for (int i = 0; i < length; i++)
            {
                String name = dataGridView2.Rows[i].Cells[0].Value.ToString();
                int arrivalTime = Convert.ToInt32(dataGridView2.Rows[i].Cells[2].Value.ToString());
                int cpuBurst = Convert.ToInt32(dataGridView2.Rows[i].Cells[3].Value.ToString());
                int priorty = Convert.ToInt32(dataGridView2.Rows[i].Cells[1].Value.ToString());
                processArray[i] = new Process(name, arrivalTime, cpuBurst, priorty);
            }


            SchedulingAlgorithm scheduler = new SchedulingAlgorithm(processArray,mode,length);
            MessageBox.Show(mode);
            scheduler.Run();
            DataTable processData = scheduler.GetProcessData();
            DataTable eventData = scheduler.GetEventData();

            this.Hide();

            output prf = new output(processData, eventData);
            prf.ShowDialog();

            this.Show();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
    }
}
