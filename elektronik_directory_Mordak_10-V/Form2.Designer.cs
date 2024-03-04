namespace elektronik_directory_Mordak_10_V
{
    partial class main_menu
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Умовні позначення");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Вступ");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Загальні відомості");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Рішення задачі");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Код");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Складність алгоритму");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Задача \"Доміно\"", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5,
            treeNode6});
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Динамічне програмування", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode7});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main_menu));
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.Location = new System.Drawing.Point(4, 14);
            this.treeView1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Узел1";
            treeNode1.SelectedImageIndex = 1;
            treeNode1.Text = "Умовні позначення";
            treeNode2.Name = "Узел2";
            treeNode2.SelectedImageIndex = 1;
            treeNode2.Text = "Вступ";
            treeNode3.Name = "Узел3";
            treeNode3.SelectedImageIndex = 1;
            treeNode3.Text = "Загальні відомості";
            treeNode4.Name = "Узел6";
            treeNode4.SelectedImageIndex = 1;
            treeNode4.Text = "Рішення задачі";
            treeNode5.Name = "Узел7";
            treeNode5.SelectedImageIndex = 1;
            treeNode5.Text = "Код";
            treeNode6.Name = "Узел10";
            treeNode6.SelectedImageIndex = 1;
            treeNode6.Text = "Складність алгоритму";
            treeNode7.Name = "Узел4";
            treeNode7.SelectedImageIndex = 1;
            treeNode7.Text = "Задача \"Доміно\"";
            treeNode8.Name = "Узел0";
            treeNode8.SelectedImageIndex = 1;
            treeNode8.Text = "Динамічне програмування";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode8});
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(285, 579);
            this.treeView1.TabIndex = 3;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "folder_new_icon_181120.ico");
            this.imageList1.Images.SetKeyName(1, "document_open_icon_181096.ico");
            this.imageList1.Images.SetKeyName(2, "go_home_icon_181144.ico");
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.webBrowser1.Location = new System.Drawing.Point(312, 14);
            this.webBrowser1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(36, 34);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(653, 579);
            this.webBrowser1.TabIndex = 4;
            // 
            // main_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 607);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.treeView1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "main_menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Документація";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.main_menu_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.ImageList imageList1;
    }
}