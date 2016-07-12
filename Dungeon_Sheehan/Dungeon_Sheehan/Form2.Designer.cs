namespace Dungeon_Sheehan
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.B1 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.B2 = new System.Windows.Forms.Button();
            this.B5 = new System.Windows.Forms.Button();
            this.B4 = new System.Windows.Forms.Button();
            this.B3 = new System.Windows.Forms.Button();
            this.B8 = new System.Windows.Forms.Button();
            this.B9 = new System.Windows.Forms.Button();
            this.B10 = new System.Windows.Forms.Button();
            this.B7 = new System.Windows.Forms.Button();
            this.B6 = new System.Windows.Forms.Button();
            this.B18 = new System.Windows.Forms.Button();
            this.B19 = new System.Windows.Forms.Button();
            this.B20 = new System.Windows.Forms.Button();
            this.B17 = new System.Windows.Forms.Button();
            this.B16 = new System.Windows.Forms.Button();
            this.B13 = new System.Windows.Forms.Button();
            this.B14 = new System.Windows.Forms.Button();
            this.B15 = new System.Windows.Forms.Button();
            this.B12 = new System.Windows.Forms.Button();
            this.B11 = new System.Windows.Forms.Button();
            this.Player1 = new System.Windows.Forms.Label();
            this.Player2 = new System.Windows.Forms.Label();
            this.Player3 = new System.Windows.Forms.Label();
            this.Player4 = new System.Windows.Forms.Label();
            this.TreasureList1 = new System.Windows.Forms.Label();
            this.TreasureList2 = new System.Windows.Forms.Label();
            this.TreasureList3 = new System.Windows.Forms.Label();
            this.TreasureList4 = new System.Windows.Forms.Label();
            this.TreasureTotal1 = new System.Windows.Forms.Label();
            this.TreasureTotal2 = new System.Windows.Forms.Label();
            this.TreasureTotal3 = new System.Windows.Forms.Label();
            this.TreasureTotal4 = new System.Windows.Forms.Label();
            this.GameLabel = new System.Windows.Forms.Label();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // B1
            // 
            this.B1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B1.ImageIndex = 0;
            this.B1.ImageList = this.imageList1;
            this.B1.Location = new System.Drawing.Point(37, 48);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(66, 73);
            this.B1.TabIndex = 0;
            this.B1.UseVisualStyleBackColor = true;
            this.B1.Click += new System.EventHandler(this.Button_Click);
            this.B1.MouseEnter += new System.EventHandler(this.button_enter);
            this.B1.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Castle.jpg");
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(-1, 3);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(189, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // B2
            // 
            this.B2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B2.ImageIndex = 0;
            this.B2.ImageList = this.imageList1;
            this.B2.Location = new System.Drawing.Point(109, 48);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(66, 73);
            this.B2.TabIndex = 5;
            this.B2.UseVisualStyleBackColor = true;
            this.B2.Click += new System.EventHandler(this.Button_Click);
            this.B2.MouseEnter += new System.EventHandler(this.button_enter);
            this.B2.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // B5
            // 
            this.B5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B5.ImageIndex = 0;
            this.B5.ImageList = this.imageList1;
            this.B5.Location = new System.Drawing.Point(324, 48);
            this.B5.Name = "B5";
            this.B5.Size = new System.Drawing.Size(66, 73);
            this.B5.TabIndex = 6;
            this.B5.UseVisualStyleBackColor = true;
            this.B5.Click += new System.EventHandler(this.Button_Click);
            this.B5.MouseEnter += new System.EventHandler(this.button_enter);
            this.B5.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // B4
            // 
            this.B4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B4.ImageIndex = 0;
            this.B4.ImageList = this.imageList1;
            this.B4.Location = new System.Drawing.Point(252, 48);
            this.B4.Name = "B4";
            this.B4.Size = new System.Drawing.Size(66, 73);
            this.B4.TabIndex = 7;
            this.B4.UseVisualStyleBackColor = true;
            this.B4.Click += new System.EventHandler(this.Button_Click);
            this.B4.MouseEnter += new System.EventHandler(this.button_enter);
            this.B4.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // B3
            // 
            this.B3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B3.ImageIndex = 0;
            this.B3.ImageList = this.imageList1;
            this.B3.Location = new System.Drawing.Point(180, 48);
            this.B3.Name = "B3";
            this.B3.Size = new System.Drawing.Size(66, 73);
            this.B3.TabIndex = 8;
            this.B3.UseVisualStyleBackColor = true;
            this.B3.Click += new System.EventHandler(this.Button_Click);
            this.B3.MouseEnter += new System.EventHandler(this.button_enter);
            this.B3.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // B8
            // 
            this.B8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B8.ImageIndex = 0;
            this.B8.ImageList = this.imageList1;
            this.B8.Location = new System.Drawing.Point(180, 127);
            this.B8.Name = "B8";
            this.B8.Size = new System.Drawing.Size(66, 73);
            this.B8.TabIndex = 13;
            this.B8.UseVisualStyleBackColor = true;
            this.B8.Click += new System.EventHandler(this.Button_Click);
            this.B8.MouseEnter += new System.EventHandler(this.button_enter);
            this.B8.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // B9
            // 
            this.B9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B9.ImageIndex = 0;
            this.B9.ImageList = this.imageList1;
            this.B9.Location = new System.Drawing.Point(252, 127);
            this.B9.Name = "B9";
            this.B9.Size = new System.Drawing.Size(66, 73);
            this.B9.TabIndex = 12;
            this.B9.UseVisualStyleBackColor = true;
            this.B9.Click += new System.EventHandler(this.Button_Click);
            this.B9.MouseEnter += new System.EventHandler(this.button_enter);
            this.B9.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // B10
            // 
            this.B10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B10.ImageIndex = 0;
            this.B10.ImageList = this.imageList1;
            this.B10.Location = new System.Drawing.Point(324, 127);
            this.B10.Name = "B10";
            this.B10.Size = new System.Drawing.Size(66, 73);
            this.B10.TabIndex = 11;
            this.B10.UseVisualStyleBackColor = true;
            this.B10.Click += new System.EventHandler(this.Button_Click);
            this.B10.MouseEnter += new System.EventHandler(this.button_enter);
            this.B10.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // B7
            // 
            this.B7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B7.ImageIndex = 0;
            this.B7.ImageList = this.imageList1;
            this.B7.Location = new System.Drawing.Point(109, 127);
            this.B7.Name = "B7";
            this.B7.Size = new System.Drawing.Size(66, 73);
            this.B7.TabIndex = 10;
            this.B7.UseVisualStyleBackColor = true;
            this.B7.Click += new System.EventHandler(this.Button_Click);
            this.B7.MouseEnter += new System.EventHandler(this.button_enter);
            this.B7.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // B6
            // 
            this.B6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B6.ImageIndex = 0;
            this.B6.ImageList = this.imageList1;
            this.B6.Location = new System.Drawing.Point(37, 127);
            this.B6.Name = "B6";
            this.B6.Size = new System.Drawing.Size(66, 73);
            this.B6.TabIndex = 9;
            this.B6.UseVisualStyleBackColor = true;
            this.B6.Click += new System.EventHandler(this.Button_Click);
            this.B6.MouseEnter += new System.EventHandler(this.button_enter);
            this.B6.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // B18
            // 
            this.B18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B18.ImageIndex = 0;
            this.B18.ImageList = this.imageList1;
            this.B18.Location = new System.Drawing.Point(181, 287);
            this.B18.Name = "B18";
            this.B18.Size = new System.Drawing.Size(66, 73);
            this.B18.TabIndex = 23;
            this.B18.UseVisualStyleBackColor = true;
            this.B18.Click += new System.EventHandler(this.Button_Click);
            this.B18.MouseEnter += new System.EventHandler(this.button_enter);
            this.B18.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // B19
            // 
            this.B19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B19.ImageIndex = 0;
            this.B19.ImageList = this.imageList1;
            this.B19.Location = new System.Drawing.Point(253, 287);
            this.B19.Name = "B19";
            this.B19.Size = new System.Drawing.Size(66, 73);
            this.B19.TabIndex = 22;
            this.B19.UseVisualStyleBackColor = true;
            this.B19.Click += new System.EventHandler(this.Button_Click);
            this.B19.MouseEnter += new System.EventHandler(this.button_enter);
            this.B19.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // B20
            // 
            this.B20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B20.ImageIndex = 0;
            this.B20.ImageList = this.imageList1;
            this.B20.Location = new System.Drawing.Point(325, 287);
            this.B20.Name = "B20";
            this.B20.Size = new System.Drawing.Size(66, 73);
            this.B20.TabIndex = 21;
            this.B20.UseVisualStyleBackColor = true;
            this.B20.Click += new System.EventHandler(this.Button_Click);
            this.B20.MouseEnter += new System.EventHandler(this.button_enter);
            this.B20.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // B17
            // 
            this.B17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B17.ImageIndex = 0;
            this.B17.ImageList = this.imageList1;
            this.B17.Location = new System.Drawing.Point(109, 287);
            this.B17.Name = "B17";
            this.B17.Size = new System.Drawing.Size(66, 73);
            this.B17.TabIndex = 20;
            this.B17.UseVisualStyleBackColor = true;
            this.B17.Click += new System.EventHandler(this.Button_Click);
            this.B17.MouseEnter += new System.EventHandler(this.button_enter);
            this.B17.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // B16
            // 
            this.B16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B16.ImageIndex = 0;
            this.B16.ImageList = this.imageList1;
            this.B16.Location = new System.Drawing.Point(37, 287);
            this.B16.Name = "B16";
            this.B16.Size = new System.Drawing.Size(66, 73);
            this.B16.TabIndex = 19;
            this.B16.UseVisualStyleBackColor = true;
            this.B16.Click += new System.EventHandler(this.Button_Click);
            this.B16.MouseEnter += new System.EventHandler(this.button_enter);
            this.B16.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // B13
            // 
            this.B13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B13.ImageIndex = 0;
            this.B13.ImageList = this.imageList1;
            this.B13.Location = new System.Drawing.Point(180, 208);
            this.B13.Name = "B13";
            this.B13.Size = new System.Drawing.Size(66, 73);
            this.B13.TabIndex = 18;
            this.B13.UseVisualStyleBackColor = true;
            this.B13.Click += new System.EventHandler(this.Button_Click);
            this.B13.MouseEnter += new System.EventHandler(this.button_enter);
            this.B13.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // B14
            // 
            this.B14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B14.ImageIndex = 0;
            this.B14.ImageList = this.imageList1;
            this.B14.Location = new System.Drawing.Point(252, 208);
            this.B14.Name = "B14";
            this.B14.Size = new System.Drawing.Size(66, 73);
            this.B14.TabIndex = 17;
            this.B14.UseVisualStyleBackColor = true;
            this.B14.Click += new System.EventHandler(this.Button_Click);
            this.B14.MouseEnter += new System.EventHandler(this.button_enter);
            this.B14.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // B15
            // 
            this.B15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B15.ImageIndex = 0;
            this.B15.ImageList = this.imageList1;
            this.B15.Location = new System.Drawing.Point(324, 208);
            this.B15.Name = "B15";
            this.B15.Size = new System.Drawing.Size(66, 73);
            this.B15.TabIndex = 16;
            this.B15.UseVisualStyleBackColor = true;
            this.B15.Click += new System.EventHandler(this.Button_Click);
            this.B15.MouseEnter += new System.EventHandler(this.button_enter);
            this.B15.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // B12
            // 
            this.B12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B12.ImageIndex = 0;
            this.B12.ImageList = this.imageList1;
            this.B12.Location = new System.Drawing.Point(109, 208);
            this.B12.Name = "B12";
            this.B12.Size = new System.Drawing.Size(66, 73);
            this.B12.TabIndex = 15;
            this.B12.UseVisualStyleBackColor = true;
            this.B12.Click += new System.EventHandler(this.Button_Click);
            this.B12.MouseEnter += new System.EventHandler(this.button_enter);
            this.B12.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // B11
            // 
            this.B11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B11.ImageIndex = 0;
            this.B11.ImageList = this.imageList1;
            this.B11.Location = new System.Drawing.Point(37, 208);
            this.B11.Name = "B11";
            this.B11.Size = new System.Drawing.Size(66, 73);
            this.B11.TabIndex = 14;
            this.B11.UseVisualStyleBackColor = true;
            this.B11.Click += new System.EventHandler(this.Button_Click);
            this.B11.MouseEnter += new System.EventHandler(this.button_enter);
            this.B11.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // Player1
            // 
            this.Player1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Player1.Font = new System.Drawing.Font("Monotype Corsiva", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player1.Location = new System.Drawing.Point(410, 50);
            this.Player1.Name = "Player1";
            this.Player1.Size = new System.Drawing.Size(50, 13);
            this.Player1.TabIndex = 24;
            // 
            // Player2
            // 
            this.Player2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Player2.Font = new System.Drawing.Font("Monotype Corsiva", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player2.Location = new System.Drawing.Point(410, 129);
            this.Player2.Name = "Player2";
            this.Player2.Size = new System.Drawing.Size(50, 13);
            this.Player2.TabIndex = 25;
            // 
            // Player3
            // 
            this.Player3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Player3.Font = new System.Drawing.Font("Monotype Corsiva", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player3.Location = new System.Drawing.Point(410, 210);
            this.Player3.Name = "Player3";
            this.Player3.Size = new System.Drawing.Size(50, 13);
            this.Player3.TabIndex = 26;
            // 
            // Player4
            // 
            this.Player4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Player4.Font = new System.Drawing.Font("Monotype Corsiva", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player4.Location = new System.Drawing.Point(410, 289);
            this.Player4.Name = "Player4";
            this.Player4.Size = new System.Drawing.Size(50, 13);
            this.Player4.TabIndex = 27;
            // 
            // TreasureList1
            // 
            this.TreasureList1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TreasureList1.Location = new System.Drawing.Point(476, 48);
            this.TreasureList1.Name = "TreasureList1";
            this.TreasureList1.Size = new System.Drawing.Size(320, 75);
            this.TreasureList1.TabIndex = 28;
            // 
            // TreasureList2
            // 
            this.TreasureList2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TreasureList2.Location = new System.Drawing.Point(476, 129);
            this.TreasureList2.Name = "TreasureList2";
            this.TreasureList2.Size = new System.Drawing.Size(320, 75);
            this.TreasureList2.TabIndex = 36;
            // 
            // TreasureList3
            // 
            this.TreasureList3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TreasureList3.Location = new System.Drawing.Point(476, 210);
            this.TreasureList3.Name = "TreasureList3";
            this.TreasureList3.Size = new System.Drawing.Size(320, 75);
            this.TreasureList3.TabIndex = 37;
            // 
            // TreasureList4
            // 
            this.TreasureList4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TreasureList4.Location = new System.Drawing.Point(476, 289);
            this.TreasureList4.Name = "TreasureList4";
            this.TreasureList4.Size = new System.Drawing.Size(320, 75);
            this.TreasureList4.TabIndex = 38;
            // 
            // TreasureTotal1
            // 
            this.TreasureTotal1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TreasureTotal1.Location = new System.Drawing.Point(814, 50);
            this.TreasureTotal1.Name = "TreasureTotal1";
            this.TreasureTotal1.Size = new System.Drawing.Size(50, 23);
            this.TreasureTotal1.TabIndex = 39;
            // 
            // TreasureTotal2
            // 
            this.TreasureTotal2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TreasureTotal2.Location = new System.Drawing.Point(814, 129);
            this.TreasureTotal2.Name = "TreasureTotal2";
            this.TreasureTotal2.Size = new System.Drawing.Size(50, 23);
            this.TreasureTotal2.TabIndex = 40;
            // 
            // TreasureTotal3
            // 
            this.TreasureTotal3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TreasureTotal3.Location = new System.Drawing.Point(814, 208);
            this.TreasureTotal3.Name = "TreasureTotal3";
            this.TreasureTotal3.Size = new System.Drawing.Size(50, 23);
            this.TreasureTotal3.TabIndex = 41;
            // 
            // TreasureTotal4
            // 
            this.TreasureTotal4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TreasureTotal4.Location = new System.Drawing.Point(814, 287);
            this.TreasureTotal4.Name = "TreasureTotal4";
            this.TreasureTotal4.Size = new System.Drawing.Size(50, 23);
            this.TreasureTotal4.TabIndex = 42;
            // 
            // GameLabel
            // 
            this.GameLabel.AutoSize = true;
            this.GameLabel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.GameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameLabel.Location = new System.Drawing.Point(389, 9);
            this.GameLabel.Name = "GameLabel";
            this.GameLabel.Size = new System.Drawing.Size(125, 25);
            this.GameLabel.TabIndex = 43;
            this.GameLabel.Text = "DUNGEON";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Dungeon_Sheehan.Properties.Resources.Fog;
            this.ClientSize = new System.Drawing.Size(919, 381);
            this.Controls.Add(this.GameLabel);
            this.Controls.Add(this.TreasureTotal4);
            this.Controls.Add(this.TreasureTotal3);
            this.Controls.Add(this.TreasureTotal2);
            this.Controls.Add(this.TreasureTotal1);
            this.Controls.Add(this.TreasureList4);
            this.Controls.Add(this.TreasureList3);
            this.Controls.Add(this.TreasureList2);
            this.Controls.Add(this.TreasureList1);
            this.Controls.Add(this.Player4);
            this.Controls.Add(this.Player3);
            this.Controls.Add(this.Player2);
            this.Controls.Add(this.Player1);
            this.Controls.Add(this.B18);
            this.Controls.Add(this.B19);
            this.Controls.Add(this.B20);
            this.Controls.Add(this.B17);
            this.Controls.Add(this.B16);
            this.Controls.Add(this.B13);
            this.Controls.Add(this.B14);
            this.Controls.Add(this.B15);
            this.Controls.Add(this.B12);
            this.Controls.Add(this.B11);
            this.Controls.Add(this.B8);
            this.Controls.Add(this.B9);
            this.Controls.Add(this.B10);
            this.Controls.Add(this.B7);
            this.Controls.Add(this.B6);
            this.Controls.Add(this.B3);
            this.Controls.Add(this.B4);
            this.Controls.Add(this.B5);
            this.Controls.Add(this.B2);
            this.Controls.Add(this.B1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.ShowIcon = false;
            this.Text = "Dungeon!";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button B1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button B2;
        private System.Windows.Forms.Button B5;
        private System.Windows.Forms.Button B4;
        private System.Windows.Forms.Button B3;
        private System.Windows.Forms.Button B8;
        private System.Windows.Forms.Button B9;
        private System.Windows.Forms.Button B10;
        private System.Windows.Forms.Button B7;
        private System.Windows.Forms.Button B6;
        private System.Windows.Forms.Button B18;
        private System.Windows.Forms.Button B19;
        private System.Windows.Forms.Button B20;
        private System.Windows.Forms.Button B17;
        private System.Windows.Forms.Button B16;
        private System.Windows.Forms.Button B13;
        private System.Windows.Forms.Button B14;
        private System.Windows.Forms.Button B15;
        private System.Windows.Forms.Button B12;
        private System.Windows.Forms.Button B11;
        private System.Windows.Forms.Label Player1;
        private System.Windows.Forms.Label Player2;
        private System.Windows.Forms.Label Player3;
        private System.Windows.Forms.Label Player4;
        private System.Windows.Forms.Label TreasureList1;
        private System.Windows.Forms.Label TreasureList2;
        private System.Windows.Forms.Label TreasureList3;
        private System.Windows.Forms.Label TreasureList4;
        private System.Windows.Forms.Label TreasureTotal1;
        private System.Windows.Forms.Label TreasureTotal2;
        private System.Windows.Forms.Label TreasureTotal3;
        private System.Windows.Forms.Label TreasureTotal4;
        private System.Windows.Forms.Label GameLabel;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    }
}