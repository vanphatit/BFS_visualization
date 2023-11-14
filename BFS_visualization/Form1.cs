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
        public List<Point> points = new List<Point>();
       
        public Form1()
        {
            InitializeComponent();
            initializePoints();
        }

        void DrawTree(string order)
        {
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

            DrawTree("");
        }

        void initializePoints()
        {
            points.Add(new Point(226, 36));
            points.Add(new Point(412, 83));
            points.Add(new Point(536, 201));
            points.Add(new Point(72, 63));
            points.Add(new Point(211, 176));
            points.Add(new Point(336, 238));
            points.Add(new Point(462, 362));
            points.Add(new Point(271, 428));
            points.Add(new Point(115, 346));
            points.Add(new Point(95, 217));
        }
    }
}
