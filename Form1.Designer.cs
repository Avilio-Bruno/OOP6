namespace OOP_LAB_4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.shapesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBoxCircle = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBoxRectangle = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBoxTriangle = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.button_setColor = new System.Windows.Forms.Button();
            this.pictureBox_color = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_color)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(12, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1558, 787);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.shapesToolStripMenuItem,
            this.colorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1584, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // shapesToolStripMenuItem
            // 
            this.shapesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBoxCircle,
            this.toolStripTextBoxRectangle,
            this.toolStripTextBoxTriangle});
            this.shapesToolStripMenuItem.Name = "shapesToolStripMenuItem";
            this.shapesToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.shapesToolStripMenuItem.Text = "Shapes";
            // 
            // toolStripTextBoxCircle
            // 
            this.toolStripTextBoxCircle.Name = "toolStripTextBoxCircle";
            this.toolStripTextBoxCircle.Size = new System.Drawing.Size(126, 22);
            this.toolStripTextBoxCircle.Text = "Circle";
            this.toolStripTextBoxCircle.Click += new System.EventHandler(this.toolStripTextBoxCircle_Click);
            // 
            // toolStripTextBoxRectangle
            // 
            this.toolStripTextBoxRectangle.Name = "toolStripTextBoxRectangle";
            this.toolStripTextBoxRectangle.Size = new System.Drawing.Size(126, 22);
            this.toolStripTextBoxRectangle.Text = "Rectangle";
            this.toolStripTextBoxRectangle.Click += new System.EventHandler(this.toolStripTextBoxRectangle_Click);
            // 
            // toolStripTextBoxTriangle
            // 
            this.toolStripTextBoxTriangle.Name = "toolStripTextBoxTriangle";
            this.toolStripTextBoxTriangle.Size = new System.Drawing.Size(126, 22);
            this.toolStripTextBoxTriangle.Text = "Triangle";
            this.toolStripTextBoxTriangle.Click += new System.EventHandler(this.toolStripTextBoxTriangle_Click);
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.colorToolStripMenuItem.Text = "Color";
            this.colorToolStripMenuItem.Click += new System.EventHandler(this.colorToolStripMenuItem_Click);
            // 
            // button_setColor
            // 
            this.button_setColor.Location = new System.Drawing.Point(12, 27);
            this.button_setColor.Name = "button_setColor";
            this.button_setColor.Size = new System.Drawing.Size(168, 23);
            this.button_setColor.TabIndex = 2;
            this.button_setColor.Text = "Set color to selected shapes";
            this.button_setColor.UseVisualStyleBackColor = true;
            this.button_setColor.Click += new System.EventHandler(this.button_setColor_Click);
            // 
            // pictureBox_color
            // 
            this.pictureBox_color.Location = new System.Drawing.Point(186, 27);
            this.pictureBox_color.Name = "pictureBox_color";
            this.pictureBox_color.Size = new System.Drawing.Size(22, 23);
            this.pictureBox_color.TabIndex = 3;
            this.pictureBox_color.TabStop = false;
            this.pictureBox_color.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_color_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.pictureBox_color);
            this.Controls.Add(this.button_setColor);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(1600, 900);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_color)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Panel panel1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem shapesToolStripMenuItem;
        private ToolStripMenuItem toolStripTextBoxCircle;
        private ToolStripMenuItem toolStripTextBoxRectangle;
        private ToolStripMenuItem toolStripTextBoxTriangle;
        private ToolStripMenuItem colorToolStripMenuItem;
        private ColorDialog colorDialog1;
        private Button button_setColor;
        private PictureBox pictureBox_color;
    }
}