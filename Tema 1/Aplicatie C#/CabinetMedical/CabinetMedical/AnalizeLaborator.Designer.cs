namespace CabinetMedical
{
    partial class AnalizeLaborator
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Analize 1");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Analize 2");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Nume 1", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Analize 2");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Analize 3");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Analize 1");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Analize 4");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Nume2", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Nume3");
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.treeView1.Location = new System.Drawing.Point(15, 12);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node3";
            treeNode1.Text = "Analize 1";
            treeNode2.Name = "Node5";
            treeNode2.Text = "Analize 2";
            treeNode3.Name = "Node0";
            treeNode3.Text = "Nume 1";
            treeNode4.Name = "Node8";
            treeNode4.Text = "Analize 2";
            treeNode5.Name = "Node11";
            treeNode5.Text = "Analize 3";
            treeNode6.Name = "Node7";
            treeNode6.Text = "Analize 1";
            treeNode7.Name = "Node12";
            treeNode7.Text = "Analize 4";
            treeNode8.Name = "Node6";
            treeNode8.Text = "Nume2";
            treeNode9.Name = "Node13";
            treeNode9.Text = "Nume3";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode8,
            treeNode9});
            this.treeView1.Size = new System.Drawing.Size(618, 611);
            this.treeView1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::CabinetMedical.Properties.Resources.analize_giurgiu1;
            this.pictureBox1.Location = new System.Drawing.Point(698, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(628, 611);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // AnalizeLaborator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1338, 635);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.treeView1);
            this.Name = "AnalizeLaborator";
            this.Text = "AnalizeLaborator";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}