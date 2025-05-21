namespace OOP_laba_1
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            pictureBox = new PictureBox();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            importPluginToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            buttonUndo = new ToolStripButton();
            buttonRedo = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            buttonColor = new ToolStripButton();
            buttonFill = new ToolStripButton();
            toolStripSeparator4 = new ToolStripSeparator();
            buttonLine = new ToolStripButton();
            buttonPolyline = new ToolStripButton();
            buttonPolygon = new ToolStripDropDownButton();
            triangleButton = new ToolStripMenuItem();
            pentagonButton = new ToolStripMenuItem();
            hexagonButton = new ToolStripMenuItem();
            buttonRectangle = new ToolStripButton();
            buttonEllipse = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            buttonWigth = new ToolStripDropDownButton();
            buttonWigth1 = new ToolStripMenuItem();
            buttonWigth2 = new ToolStripMenuItem();
            buttonWigth4 = new ToolStripMenuItem();
            buttonWigth6 = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            buttonPlugins = new ToolStripDropDownButton();
            colorDialog = new ColorDialog();
            saveFileDialog = new SaveFileDialog();
            openFileDialog = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox
            // 
            pictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox.BackColor = SystemColors.ButtonHighlight;
            pictureBox.BackgroundImageLayout = ImageLayout.None;
            pictureBox.Location = new Point(0, 71);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(1368, 588);
            pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            pictureBox.Paint += pictureBox_Paint;
            pictureBox.DoubleClick += pictureBox_DoubleClick;
            pictureBox.MouseDown += pictureBox_MouseDown;
            pictureBox.MouseLeave += pictureBox_MouseLeave;
            pictureBox.MouseMove += pictureBox_MouseMove;
            pictureBox.MouseUp += pictureBox_MouseUp;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1368, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, saveToolStripMenuItem, importPluginToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(182, 26);
            openToolStripMenuItem.Text = "Open";
            openToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(182, 26);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem1_Click;
            // 
            // importPluginToolStripMenuItem
            // 
            importPluginToolStripMenuItem.Name = "importPluginToolStripMenuItem";
            importPluginToolStripMenuItem.Size = new Size(182, 26);
            importPluginToolStripMenuItem.Text = "Import Plugin";
            importPluginToolStripMenuItem.Click += importPluginToolStripMenuItem_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            toolStrip1.AutoSize = false;
            toolStrip1.Dock = DockStyle.None;
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { buttonUndo, buttonRedo, toolStripSeparator2, buttonColor, buttonFill, toolStripSeparator4, buttonLine, buttonPolyline, buttonPolygon, buttonRectangle, buttonEllipse, toolStripSeparator1, buttonWigth, toolStripSeparator3, buttonPlugins });
            toolStrip1.Location = new Point(0, 28);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1368, 40);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // buttonUndo
            // 
            buttonUndo.DisplayStyle = ToolStripItemDisplayStyle.Image;
            buttonUndo.Image = (Image)resources.GetObject("buttonUndo.Image");
            buttonUndo.ImageTransparentColor = Color.Magenta;
            buttonUndo.Name = "buttonUndo";
            buttonUndo.Size = new Size(29, 37);
            buttonUndo.Text = "toolStripButtonUndo";
            buttonUndo.Click += buttonUndo_Click;
            // 
            // buttonRedo
            // 
            buttonRedo.DisplayStyle = ToolStripItemDisplayStyle.Image;
            buttonRedo.Image = (Image)resources.GetObject("buttonRedo.Image");
            buttonRedo.ImageTransparentColor = Color.Magenta;
            buttonRedo.Name = "buttonRedo";
            buttonRedo.Size = new Size(29, 37);
            buttonRedo.Text = "toolStripButtonRedo";
            buttonRedo.Click += buttonRedo_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 40);
            // 
            // buttonColor
            // 
            buttonColor.DisplayStyle = ToolStripItemDisplayStyle.Image;
            buttonColor.Image = (Image)resources.GetObject("buttonColor.Image");
            buttonColor.ImageTransparentColor = Color.Magenta;
            buttonColor.Name = "buttonColor";
            buttonColor.Size = new Size(29, 37);
            buttonColor.Text = "toolStripButton3";
            buttonColor.Click += buttonColor_Click;
            // 
            // buttonFill
            // 
            buttonFill.DisplayStyle = ToolStripItemDisplayStyle.Image;
            buttonFill.Image = (Image)resources.GetObject("buttonFill.Image");
            buttonFill.ImageTransparentColor = Color.Magenta;
            buttonFill.Name = "buttonFill";
            buttonFill.Size = new Size(29, 37);
            buttonFill.Text = "toolStripButton4";
            buttonFill.Click += buttonFill_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(6, 40);
            // 
            // buttonLine
            // 
            buttonLine.DisplayStyle = ToolStripItemDisplayStyle.Image;
            buttonLine.Image = (Image)resources.GetObject("buttonLine.Image");
            buttonLine.ImageTransparentColor = Color.Magenta;
            buttonLine.Name = "buttonLine";
            buttonLine.Size = new Size(29, 37);
            buttonLine.Text = "toolStripButton1";
            buttonLine.Click += buttonLine_Click;
            // 
            // buttonPolyline
            // 
            buttonPolyline.DisplayStyle = ToolStripItemDisplayStyle.Image;
            buttonPolyline.Image = (Image)resources.GetObject("buttonPolyline.Image");
            buttonPolyline.ImageTransparentColor = Color.Magenta;
            buttonPolyline.Name = "buttonPolyline";
            buttonPolyline.Size = new Size(29, 37);
            buttonPolyline.Text = "toolStripButton2";
            buttonPolyline.Click += buttonPolyline_Click;
            // 
            // buttonPolygon
            // 
            buttonPolygon.DisplayStyle = ToolStripItemDisplayStyle.Image;
            buttonPolygon.DropDownItems.AddRange(new ToolStripItem[] { triangleButton, pentagonButton, hexagonButton });
            buttonPolygon.Image = (Image)resources.GetObject("buttonPolygon.Image");
            buttonPolygon.ImageTransparentColor = Color.Magenta;
            buttonPolygon.Name = "buttonPolygon";
            buttonPolygon.Size = new Size(34, 37);
            buttonPolygon.Text = "toolStripDropDownButton1";
            // 
            // triangleButton
            // 
            triangleButton.Image = (Image)resources.GetObject("triangleButton.Image");
            triangleButton.Name = "triangleButton";
            triangleButton.Size = new Size(100, 26);
            triangleButton.Text = "3";
            triangleButton.Click += toolStripMenuItem2_Click;
            // 
            // pentagonButton
            // 
            pentagonButton.Image = (Image)resources.GetObject("pentagonButton.Image");
            pentagonButton.Name = "pentagonButton";
            pentagonButton.Size = new Size(100, 26);
            pentagonButton.Text = "5";
            pentagonButton.Click += pentagonButton_Click;
            // 
            // hexagonButton
            // 
            hexagonButton.Image = (Image)resources.GetObject("hexagonButton.Image");
            hexagonButton.Name = "hexagonButton";
            hexagonButton.Size = new Size(100, 26);
            hexagonButton.Text = "6";
            hexagonButton.Click += toolStripMenuItem4_Click;
            // 
            // buttonRectangle
            // 
            buttonRectangle.DisplayStyle = ToolStripItemDisplayStyle.Image;
            buttonRectangle.Image = (Image)resources.GetObject("buttonRectangle.Image");
            buttonRectangle.ImageTransparentColor = Color.Magenta;
            buttonRectangle.Name = "buttonRectangle";
            buttonRectangle.Size = new Size(29, 37);
            buttonRectangle.Text = "toolStripButton4";
            buttonRectangle.Click += buttonRectangle_Click;
            // 
            // buttonEllipse
            // 
            buttonEllipse.DisplayStyle = ToolStripItemDisplayStyle.Image;
            buttonEllipse.Image = (Image)resources.GetObject("buttonEllipse.Image");
            buttonEllipse.ImageTransparentColor = Color.Magenta;
            buttonEllipse.Name = "buttonEllipse";
            buttonEllipse.Size = new Size(29, 37);
            buttonEllipse.Text = "toolStripButton2";
            buttonEllipse.Click += buttonEllipse_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 40);
            // 
            // buttonWigth
            // 
            buttonWigth.DisplayStyle = ToolStripItemDisplayStyle.Image;
            buttonWigth.DropDownItems.AddRange(new ToolStripItem[] { buttonWigth1, buttonWigth2, buttonWigth4, buttonWigth6 });
            buttonWigth.Image = (Image)resources.GetObject("buttonWigth.Image");
            buttonWigth.ImageTransparentColor = Color.Magenta;
            buttonWigth.Name = "buttonWigth";
            buttonWigth.Size = new Size(34, 37);
            buttonWigth.Text = "toolStripDropDownButton2";
            // 
            // buttonWigth1
            // 
            buttonWigth1.Name = "buttonWigth1";
            buttonWigth1.Size = new Size(116, 26);
            buttonWigth1.Text = "1px";
            buttonWigth1.Click += pxToolStripMenuItem_Click;
            // 
            // buttonWigth2
            // 
            buttonWigth2.Name = "buttonWigth2";
            buttonWigth2.Size = new Size(116, 26);
            buttonWigth2.Text = "2px";
            buttonWigth2.Click += buttonWigth2_Click;
            // 
            // buttonWigth4
            // 
            buttonWigth4.Name = "buttonWigth4";
            buttonWigth4.Size = new Size(116, 26);
            buttonWigth4.Text = "4px";
            buttonWigth4.Click += pxToolStripMenuItem2_Click;
            // 
            // buttonWigth6
            // 
            buttonWigth6.Name = "buttonWigth6";
            buttonWigth6.Size = new Size(116, 26);
            buttonWigth6.Text = "6px";
            buttonWigth6.Click += buttonWigth6_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 40);
            // 
            // buttonPlugins
            // 
            buttonPlugins.DisplayStyle = ToolStripItemDisplayStyle.Image;
            buttonPlugins.Image = (Image)resources.GetObject("buttonPlugins.Image");
            buttonPlugins.ImageTransparentColor = Color.Magenta;
            buttonPlugins.Name = "buttonPlugins";
            buttonPlugins.Size = new Size(34, 37);
            buttonPlugins.Text = "toolStripDropDownButton1";
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog1";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1368, 671);
            Controls.Add(toolStrip1);
            Controls.Add(pictureBox);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "OOP laba 1";
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem importPluginToolStripMenuItem;
        private ToolStrip toolStrip1;
        private ToolStripButton buttonUndo;
        private ToolStripButton buttonRedo;
        private ToolStripButton buttonColor;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton buttonFill;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripDropDownButton buttonWigth;
        private ToolStripButton buttonLine;
        private ToolStripButton buttonPolyline;
        private ToolStripButton buttonRectangle;
        private ToolStripButton buttonEllipse;
        private ColorDialog colorDialog;
        private ToolStripMenuItem buttonWigth1;
        private ToolStripMenuItem buttonWigth2;
        private ToolStripMenuItem buttonWigth4;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem buttonWigth6;
        private SaveFileDialog saveFileDialog;
        private OpenFileDialog openFileDialog;
        private ToolStripDropDownButton buttonPlugins;
        private ToolStripDropDownButton buttonPolygon;
        private ToolStripMenuItem triangleButton;
        private ToolStripMenuItem pentagonButton;
        private ToolStripMenuItem hexagonButton;
    }
}
