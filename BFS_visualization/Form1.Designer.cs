namespace BFS_visualization
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlGraph1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbMatrixOrder = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDrawSpaningTree = new System.Windows.Forms.Button();
            this.cbStartNode = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnImportMatrix = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlGraph1
            // 
            this.pnlGraph1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pnlGraph1.Location = new System.Drawing.Point(12, 12);
            this.pnlGraph1.Name = "pnlGraph1";
            this.pnlGraph1.Size = new System.Drawing.Size(859, 641);
            this.pnlGraph1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Google Sans", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(932, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "BFS VISUALIZATION";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Google Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(902, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ma trận thứ: ";
            // 
            // cbMatrixOrder
            // 
            this.cbMatrixOrder.Font = new System.Drawing.Font("Google Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMatrixOrder.FormattingEnabled = true;
            this.cbMatrixOrder.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.cbMatrixOrder.Location = new System.Drawing.Point(1043, 90);
            this.cbMatrixOrder.Name = "cbMatrixOrder";
            this.cbMatrixOrder.Size = new System.Drawing.Size(79, 34);
            this.cbMatrixOrder.TabIndex = 3;
            this.cbMatrixOrder.SelectedValueChanged += new System.EventHandler(this.cbMatrixOrder_SelectedValueChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.Controls.Add(this.btnDrawSpaningTree);
            this.panel2.Controls.Add(this.cbStartNode);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(877, 145);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(385, 138);
            this.panel2.TabIndex = 1;
            // 
            // btnDrawSpaningTree
            // 
            this.btnDrawSpaningTree.Font = new System.Drawing.Font("Google Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDrawSpaningTree.Location = new System.Drawing.Point(30, 71);
            this.btnDrawSpaningTree.Name = "btnDrawSpaningTree";
            this.btnDrawSpaningTree.Size = new System.Drawing.Size(337, 41);
            this.btnDrawSpaningTree.TabIndex = 8;
            this.btnDrawSpaningTree.Text = "VẼ CÂY KHUNG";
            this.btnDrawSpaningTree.UseVisualStyleBackColor = true;
            this.btnDrawSpaningTree.Click += new System.EventHandler(this.btnDrawSpaningTree_Click);
            // 
            // cbStartNode
            // 
            this.cbStartNode.Font = new System.Drawing.Font("Google Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStartNode.FormattingEnabled = true;
            this.cbStartNode.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.cbStartNode.Location = new System.Drawing.Point(184, 20);
            this.cbStartNode.Name = "cbStartNode";
            this.cbStartNode.Size = new System.Drawing.Size(181, 34);
            this.cbStartNode.TabIndex = 7;
            this.cbStartNode.SelectedValueChanged += new System.EventHandler(this.cbStartNode_SelectedValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Google Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "Node bắt đầu: ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Location = new System.Drawing.Point(877, 289);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(385, 364);
            this.panel1.TabIndex = 4;
            // 
            // btnImportMatrix
            // 
            this.btnImportMatrix.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnImportMatrix.Font = new System.Drawing.Font("Google Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportMatrix.Location = new System.Drawing.Point(1144, 73);
            this.btnImportMatrix.Name = "btnImportMatrix";
            this.btnImportMatrix.Size = new System.Drawing.Size(106, 66);
            this.btnImportMatrix.TabIndex = 9;
            this.btnImportMatrix.Text = "Nhập";
            this.btnImportMatrix.UseVisualStyleBackColor = false;
            this.btnImportMatrix.Click += new System.EventHandler(this.btnImportMatrix_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 665);
            this.Controls.Add(this.btnImportMatrix);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.cbMatrixOrder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlGraph1);
            this.Name = "Form1";
            this.Text = "BFS Visualization";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlGraph1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbMatrixOrder;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbStartNode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDrawSpaningTree;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnImportMatrix;
    }
}

