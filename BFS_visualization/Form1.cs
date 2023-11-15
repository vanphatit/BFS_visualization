using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace BFS_visualization
{
    public partial class Form1 : Form
    {
        List<Button> buttons = new List<Button>();
        List<int[,]> matrixs = new List<int[,]>();
        public List<List<Point>> listpoints = new List<List<Point>>();
        public List<Point> points;
        bool isChanged = false;
        int root;
        int[,] A = new int[10, 10];
        
        public Form1()
        {
            InitializeComponent();
            initializePoints();
            cbMatrixOrder.Enabled = false;
            cbStartNode.Enabled = false;
            btnDrawSpaningTree.Enabled = false;
            btnDrawSlowly.Enabled = false;
            if (!isChanged)
                points = listpoints[0];
        }

        #region BFS 
        public int[] chuaXet = { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
        void InitQ(ref Queue<int> Q)
        {
            Q.FL = null;
            Q.LL = null;
        }

        public int pushQ(ref Queue<int> Q, int x)
        {
            Node<int> p = new Node<int>(x);
            if (p == null) return 0;
            if (Q.FL == null)
            {
                p.value = x;
                p.pointer = Q.FL;
                Q.FL = p;
                Q.LL = p;
            }
            else
            {
                p.value = x;
                p.pointer = null;
                Q.LL.pointer = p;
                Q.LL = p;
            }
            return 1;
        }

        public void RemoveNode(Queue<int> Q)
        {
            if (Q.FL != null)
            {
                Node<int> removedNode = Q.FL;
                Q.FL = removedNode.pointer;

                if (Q.FL == null)
                {
                    Q.LL = null;
                }
            }
        }

        public int popQ(ref Queue<int> Q, out int x)
        {
            Node<int> p;
            p = Q.FL;
            if (p != null)
            {
                x = p.value;
                Q.FL = p.pointer;
                if (Q.FL == null) Q.LL = null;

                return 1;
            }
            x = 0;
            return 0;
        }

        public void TreeBFS(int r, bool isSlow)
        {
            Graphics gra = this.pnlGraph1.CreateGraphics();
            Pen pen = new Pen(Color.Red, 3);
            for (int i = 0; i < 10; i++)
                for (int j = 0; j < 10; j++)
                {
                    if (A[i, j] == 1)
                    {
                        gra.DrawLine(pen, new Point(points[i].X + 30 / 2, points[i].Y + 30 / 2),
                                            new Point(points[j].X + 30 / 2, points[j].Y + 30 / 2));
                    }
                }
            Queue<int> Q = new Queue<int>();
            int v;
            InitQ(ref Q);
            pushQ(ref Q, r);
            chuaXet[r] = 0;
            while (Q.FL != null)
            {
                popQ(ref Q, out v);
                for (int i = 0; i < 10; i++)
                    if (A[i, v] == 1)
                        if (chuaXet[i] == 1)
                        {
                            pushQ(ref Q, i);
                            chuaXet[i] = 0;
                            Pen pen10 = new Pen(Color.Yellow, 3);
                                gra.DrawLine(pen10, new Point(points[v].X + 30 / 2, points[v].Y + 30 / 2),
                                                new Point(points[i].X + 30 / 2, points[i].Y + 30 / 2));
                            if (isSlow)
                            {
                                Thread.Sleep(500);
                            }
                        }
            }
        }
        #endregion

        void DrawTree()
        {
            pnlGraph1.Controls.Clear();
            pnlGraph1.Refresh();
            Graphics gra = this.pnlGraph1.CreateGraphics();
            Pen pen = new Pen(Color.Red, 3);
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
                    if (A[i, j] == 1)
                    {
                        gra.DrawLine(pen, new Point(points[i].X + 30 / 2, points[i].Y + 30 / 2),
                                            new Point(points[j].X + 30 / 2, points[j].Y + 30 / 2));
                    }
                }
        }

        private void cbStartNode_SelectedValueChanged(object sender, EventArgs e)
        {
            root = Int32.Parse(cbStartNode.SelectedItem.ToString());
        }

        private void btnDrawSpaningTree_Click(object sender, EventArgs e)
        {
            if(cbStartNode.SelectedItem  != null && cbMatrixOrder.SelectedItem != null)
            {
                for (int i = 0; i < 10; i++)
                {
                    chuaXet[i] = 1;
                }
                TreeBFS(root, false);
            }
            else
            {
                MessageBox.Show("Please choose start node!!!!");
            }
        }

        private void cbMatrixOrder_SelectedValueChanged(object sender, EventArgs e)
        {
            isChanged = true;
            int order = Int32.Parse(cbMatrixOrder.SelectedItem.ToString());
            points = listpoints[order];
            A = matrixs[order];
            DrawTree();
        }

        private void btnImportMatrix_Click(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines("Matran.txt");

            int[,] currentMatrix = new int[10, 10];
            int i = 0, j = 0;

            foreach (string line in lines)
            {
                foreach (char item in line)
                {
                    if (item == '0' || item == '1')
                    {
                        currentMatrix[i, j] = int.Parse(item.ToString());
                        j++;

                        if (j == 10)
                        {
                            i++;
                            j = 0;
                        }

                    }

                    // Xử lí khi gặp kí tự lạ
                    else if (!char.IsWhiteSpace(item))
                    {
                        throw new FormatException($"Invalid character '{item}' in the file.");
                    }
                }

                if (i == 10)
                {
                    matrixs.Add(currentMatrix);
                    currentMatrix = new int[10, 10];
                    i = 0;
                }
            }

            MessageBox.Show("Import matrix completed!!");
            cbMatrixOrder.Enabled = true;
            cbStartNode.Enabled = true;
            btnDrawSpaningTree.Enabled = true;
            btnDrawSlowly.Enabled = true;
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
            List<Point> point2 = new List<Point>
            {
                new Point(111, 33),
                new Point(351, 33),
                new Point(445, 139),
                new Point(313, 139),
                new Point(160, 150),
                new Point(29, 153),
                new Point(258, 277),
                new Point(497, 277),
                new Point(313, 413),
                new Point(101, 469)
            };
            listpoints.Add(point2);
            List<Point> point3 = new List<Point>
            {
                new Point(16, 277),
                new Point(125, 133),
                new Point(125, 429),
                new Point(188, 277),
                new Point(244, 394),
                new Point(244, 172),
                new Point(310, 277),
                new Point(472, 277),
                new Point(370, 411),
                new Point(370, 156)
            };
            listpoints.Add(point3);
            List<Point> point4 = new List<Point>
            {
                new Point(111, 33),
                new Point(410, 33),
                new Point(157, 156),
                new Point(292, 156),
                new Point(292, 277),
                new Point(157, 277),
                new Point(525, 171),
                new Point(487, 319),
                new Point(344, 423),
                new Point(68, 423)
            };
            listpoints.Add(point4);
            List<Point> point5 = new List<Point>
            {
                new Point(208, 205),
                new Point(356, 205),
                new Point(356, 319),
                new Point(208, 319),
                new Point(81, 264),
                new Point(479, 264),
                new Point(286, 102),
                new Point(286, 425),
                new Point(449, 399),
                new Point(286, 264)
            };
            listpoints.Add(point5);
            List<Point> point6 = new List<Point>
            {
                new Point(62, 153),
                new Point(207, 23),
                new Point(356, 153),
                new Point(207, 156),
                new Point(62, 315),
                new Point(207, 315),
                new Point(356, 315),
                new Point(133, 237),
                new Point(283, 237),
                new Point(207, 441)
            };
            listpoints.Add(point6);
            List<Point> point7 = new List<Point>
            {
                new Point(51, 69),
                new Point(51, 182),
                new Point(51, 292),
                new Point(51, 402),
                new Point(172, 182),
                new Point(172, 292),
                new Point(299, 113),
                new Point(299, 239),
                new Point(299, 355),
                new Point(466, 239)
            };
            listpoints.Add(point7);
            List<Point> point8 = new List<Point>
            {
                new Point(51, 69),
                new Point(172, 69),
                new Point(51, 182),
                new Point(51, 292),
                new Point(154, 405),
                new Point(326, 350),
                new Point(172, 239),
                new Point(299, 239),
                new Point(299, 121),
                new Point(459, 228)
            };
            listpoints.Add(point8);
            List<Point> point9 = new List<Point>
            {
                new Point(102, 42),
                new Point(299, 111),
                new Point(166, 205),
                new Point(411, 205),
                new Point(50, 309),
                new Point(530, 309),
                new Point(190, 319),
                new Point(392, 319),
                new Point(205, 453),
                new Point(381, 453)
            };
            listpoints.Add(point9);
        }

        private void btnDrawSlowly_Click(object sender, EventArgs e)
        {
            if (cbStartNode.SelectedItem != null && cbMatrixOrder.SelectedItem != null)
            {
                for (int i = 0; i < 10; i++)
                {
                    chuaXet[i] = 1;
                }
                TreeBFS(root, true);
                MessageBox.Show("Done!");
            }
            else
            {
                MessageBox.Show("Please choose start node!!!!");
            }
        }
    }
}