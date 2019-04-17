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
    public partial class output : Form
    {
         private DataTable eventData;
        private DataTable processData;
         public output(DataTable processData, DataTable eventData)
        {
            InitializeComponent();

            this.eventData = eventData;
            this.processData = processData;
            dataGridView1.DataSource = processData;
        }
        public output()
        {
            InitializeComponent();
        }

        private void output_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

            
                Brush main = new SolidBrush(Color.White);
                Pen border = new Pen(Color.Black);

                //Main Bar
                e.Graphics.DrawRectangle(border, new Rectangle(16, 44, 751, 61));
                e.Graphics.FillRectangle(main, new Rectangle(17, 45, 750, 60));

                //Random color;
                Random randomGen = new Random();
                int processCount = processData.Rows.Count;
                Brush[] processColor = new Brush[processCount];
                for (int i = 0; i < processCount; i++)
                {
                    int red = randomGen.Next(50, byte.MaxValue + 1);
                    int blue = randomGen.Next(50, byte.MaxValue + 1);
                    int green = randomGen.Next(50, byte.MaxValue + 1);
                    processColor[i] = new SolidBrush(Color.FromArgb(red, green, blue));
                }

                int maxTime = Convert.ToInt32(eventData.Rows[eventData.Rows.Count - 1]["End Time"].ToString());
                foreach (DataRow row in eventData.Rows)
                {
                    int startTime = Convert.ToInt32(row["Start Time"].ToString());
                    int endTime = Convert.ToInt32(row["End Time"].ToString());
                    String processName = row["Process Number"].ToString();
                    int processNumber = Convert.ToInt32(processName.Substring(7)) - 1;

                    int xStart = (startTime * 750) / maxTime + 17;
                    int xEnd = (endTime * 750) / maxTime + 17;
                    e.Graphics.FillRectangle(processColor[processNumber], new Rectangle(xStart, 45, xEnd - xStart, 60));
                    e.Graphics.DrawLine(border, new Point(xStart, 44), new Point(xStart, 105));
                    e.Graphics.DrawLine(border, new Point(xEnd, 44), new Point(xEnd, 105));

                    Font font = new Font("Arial", 9);
                    Brush text = new SolidBrush(Color.Black);

                    float xStartF = xStart;
                    float xEndF = xEnd;
                    e.Graphics.DrawString(startTime.ToString(), font, text, xStart, 22f);
                    e.Graphics.DrawString(endTime.ToString(), font, text, xEnd, 22f);
                    e.Graphics.DrawString(processName, font, text, (xStart + xEnd) / 2 - 10, 70f);
                }
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
