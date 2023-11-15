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
        //int[,] A = new int[10, 10] {
        //                { 0, 1, 0, 1, 0, 0, 0, 0, 0, 0 },
        //                { 1, 0, 1, 0, 1, 1, 0, 0, 0, 0 },
        //                { 0, 1, 0, 0, 0, 0, 1, 0, 0, 0 },
        //                { 1, 0, 0, 0, 1, 0, 0, 0, 0, 0 },
        //                { 0, 1, 0, 1, 0, 0, 0, 0, 0, 1 },
        //                { 0, 1, 0, 0, 0, 0, 1, 0, 0, 1 },
        //                { 0, 0, 1, 0, 0, 1, 0, 1, 0, 0 },
        //                { 0, 0, 0, 0, 0, 0, 1, 0, 1, 0 },
        //                { 0, 0, 0, 0, 0, 0, 0, 1, 0, 1 },
        //                { 0, 0, 0, 0, 1, 1, 0, 0, 1, 0 }
        //                };

        public Form1()
        {
            InitializeComponent();
            initializePoints();
            if(!isChanged)
                points = listpoints[0];
        }

        // BFS 
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

        public void TreeBFS(int r)
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
                        }
            }
        }
        // BFS

        void DrawTree()
        {
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

        private void cbStartNode_SelectedValueChanged(object sender, EventArgs e)
        {
            root = Int32.Parse(cbStartNode.SelectedItem.ToString());
        }

        private void btnDrawSpaningTree_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                chuaXet[i] = 1;
            }
            TreeBFS(root);
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
            string[] a = File.ReadAllLines("Matran.txt");
            int[,] b = new int[10, 10];
            int i = 0, j = 0;

            foreach (string s in a)
            {
                foreach (var item in s)
                {
                    if (item == '0' || item == '1')
                    {
                        b[i, j] = Int32.Parse(item.ToString());
                        j++;

                        if (j == 10)
                        {
                            i++;
                            j = 0;
                        }
                        
                    }
                    if (i == 10)
                    {
                        matrixs.Add(b);
                        i = 0;
                    }
                }
                
            }

            DrawTree();
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
