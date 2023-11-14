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
        public Form1()
        {
            InitializeComponent();

        }

        void DrawTree(string order)
        {
            if(order == "2")
            {
                pnlGraph1.Visible = false;
            }
            else
            {
                pnlGraph1.Visible=true;
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

        }
    }
}
