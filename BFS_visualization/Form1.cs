using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BFS_visualization
{
    public partial class Form1 : Form
    {
        List<Button> buttons = new List<Button>();
        public List<List<Point>> listpoints = new List<List<Point>>();
       
        public Form1()
        {
            InitializeComponent();
            initializePoints();
        }

        void DrawTree(string order)
        {
            int index = Int32.Parse(order);
            int[,] A = new int[10, 10] {
                                    { 0, 1, 0, 1, 0, 0, 0, 0, 0, 0 },
                                    { 1, 0, 1, 0, 1, 1, 0, 0, 0, 0 },
                                    { 0, 1, 0, 0, 0, 0, 1, 0, 0, 0 },
                                    { 1, 0, 0, 0, 1, 0, 0, 0, 0, 0 },
                                    { 0, 1, 0, 1, 0, 0, 0, 0, 0, 1 },
                                    { 0, 1, 0, 0, 0, 0, 1, 0, 0, 1 },
                                    { 0, 0, 1, 0, 0, 1, 0, 1, 0, 0 },
                                    { 0, 0, 0, 0, 0, 0, 1, 0, 1, 0 },
                                    { 0, 0, 0, 0, 0, 0, 0, 1, 0, 1 },
                                    { 0, 0, 0, 0, 1, 1, 0, 0, 1, 0 }
            };

            List<Point> points = listpoints[index];

            pnlGraph1.Controls.Clear();
            pnlGraph1.Refresh();
            Graphics gra = this.pnlGraph1.CreateGraphics();
            Pen pen = new Pen(Color.Red, 3);
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                Button btn = new Button();
                btn.Size = new Size(30, 30);
                btn.Location = points[i];
                btn.Text = i.ToString();
                buttons.Add(btn);
                pnlGraph1.Controls.Add(btn);
            }
            for (int i = 0; i < 10; i++)
                for (int j = 0; j < 10; j++)
                {
                    if (A[i,j] == 1)
                    {
                        gra.DrawLine(pen, new Point(points[i].X + 30 / 2, points[i].Y + 30 / 2), 
                                            new Point(points[j].X + 30 / 2, points[j].Y + 30 / 2));
                    }
                }
        }

        private void btnDrawSpaningTree_Click(object sender, EventArgs e)
        {
            string root = cbStartNode.SelectedValue.ToString();
        }

        private void cbMatrixOrder_SelectedValueChanged(object sender, EventArgs e)
        {
            DrawTree(cbMatrixOrder.SelectedIndex.ToString());
        }

        private void btnImportMatrix_Click(object sender, EventArgs e)
        {
            DrawTree("0");
        }

        void initializePoints()
        {
            List<Point> point0 = new List<Point>
            {
                new Point(226, 36),
                new Point(412, 83),
                new Point(536, 201),
                new Point(72, 63),
                new Point(211, 176),
                new Point(336, 238),
                new Point(462, 362),
                new Point(271, 428),
                new Point(115, 346),
                new Point(95, 217)
            };
            listpoints.Add(point0);
            List<Point> point1 = new List<Point>
            {
                new Point(36, 258),
                new Point(95, 362),
                new Point(111, 150),
                new Point(281, 454),
                new Point(281, 316),
                new Point(281, 182),
                new Point(281, 46),
                new Point(445, 316),
                new Point(445, 182),
                new Point(586, 260)
            };
            listpoints.Add(point1);
        }
    }
}
