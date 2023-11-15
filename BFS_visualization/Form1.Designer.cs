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
            this.label4 = new System.Windows.Forms.Label();
            this.btnDrawSlowly = new System.Windows.Forms.Button();
            this.btnDrawSpaningTree = new System.Windows.Forms.Button();
            this.cbStartNode = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnImportMatrix = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.label2.Location = new System.Drawing.Point(903, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Matrix:";
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
            this.cbMatrixOrder.Location = new System.Drawing.Point(990, 104);
            this.cbMatrixOrder.Name = "cbMatrixOrder";
            this.cbMatrixOrder.Size = new System.Drawing.Size(49, 34);
            this.cbMatrixOrder.TabIndex = 3;
            this.cbMatrixOrder.SelectedValueChanged += new System.EventHandler(this.cbMatrixOrder_SelectedValueChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.btnDrawSlowly);
            this.panel2.Controls.Add(this.btnDrawSpaningTree);
            this.panel2.Controls.Add(this.cbStartNode);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(878, 159);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(385, 150);
            this.panel2.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Google Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label4.Location = new System.Drawing.Point(117, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 26);
            this.label4.TabIndex = 10;
            this.label4.Text = "SPANING TREE";
            // 
            // btnDrawSlowly
            // 
            this.btnDrawSlowly.Font = new System.Drawing.Font("Google Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDrawSlowly.Location = new System.Drawing.Point(253, 54);
            this.btnDrawSlowly.Name = "btnDrawSlowly";
            this.btnDrawSlowly.Size = new System.Drawing.Size(102, 70);
            this.btnDrawSlowly.TabIndex = 9;
            this.btnDrawSlowly.Text = "Draw slowly";
            this.btnDrawSlowly.UseVisualStyleBackColor = true;
            this.btnDrawSlowly.Click += new System.EventHandler(this.btnDrawSlowly_Click);
            // 
            // btnDrawSpaningTree
            // 
            this.btnDrawSpaningTree.Font = new System.Drawing.Font("Google Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDrawSpaningTree.Location = new System.Drawing.Point(156, 54);
            this.btnDrawSpaningTree.Name = "btnDrawSpaningTree";
            this.btnDrawSpaningTree.Size = new System.Drawing.Size(91, 70);
            this.btnDrawSpaningTree.TabIndex = 8;
            this.btnDrawSpaningTree.Text = "Draw";
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
            this.cbStartNode.Location = new System.Drawing.Point(25, 87);
            this.cbStartNode.Name = "cbStartNode";
            this.cbStartNode.Size = new System.Drawing.Size(115, 34);
            this.cbStartNode.TabIndex = 7;
            this.cbStartNode.SelectedValueChanged += new System.EventHandler(this.cbStartNode_SelectedValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Google Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "Start node:";
            // 
            // btnImportMatrix
            // 
            this.btnImportMatrix.BackColor = System.Drawing.SystemColors.Info;
            this.btnImportMatrix.Font = new System.Drawing.Font("Google Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportMatrix.Location = new System.Drawing.Point(1062, 87);
            this.btnImportMatrix.Name = "btnImportMatrix";
            this.btnImportMatrix.Size = new System.Drawing.Size(189, 66);
            this.btnImportMatrix.TabIndex = 9;
            this.btnImportMatrix.Text = "Import matrix";
            this.btnImportMatrix.UseVisualStyleBackColor = false;
            this.btnImportMatrix.Click += new System.EventHandler(this.btnImportMatrix_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::BFS_visualization.Properties.Resources.BFS2;
            this.pictureBox1.Image = global::BFS_visualization.Properties.Resources.h1CBC93F0;
            this.pictureBox1.Location = new System.Drawing.Point(877, 315);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(386, 338);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 665);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnImportMatrix);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.cbMatrixOrder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlGraph1);
            this.Name = "Form1";
            this.Text = "BFS Visualization";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Button btnDrawSlowly;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

