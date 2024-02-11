namespace WindowsAppWeatherForecast.WindowsForm
{
    partial class MainForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.actionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.authorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.town3Name = new System.Windows.Forms.Label();
            this.town3Value = new System.Windows.Forms.Label();
            this.town14Name = new System.Windows.Forms.Label();
            this.town14Value = new System.Windows.Forms.Label();
            this.town12Name = new System.Windows.Forms.Label();
            this.town12Value = new System.Windows.Forms.Label();
            this.town8Name = new System.Windows.Forms.Label();
            this.town8Value = new System.Windows.Forms.Label();
            this.town2Name = new System.Windows.Forms.Label();
            this.town2Value = new System.Windows.Forms.Label();
            this.town11Name = new System.Windows.Forms.Label();
            this.town11Value = new System.Windows.Forms.Label();
            this.town1Name = new System.Windows.Forms.Label();
            this.town1Value = new System.Windows.Forms.Label();
            this.town7Name = new System.Windows.Forms.Label();
            this.town7Value = new System.Windows.Forms.Label();
            this.town10Name = new System.Windows.Forms.Label();
            this.town10Value = new System.Windows.Forms.Label();
            this.town0Name = new System.Windows.Forms.Label();
            this.town0Value = new System.Windows.Forms.Label();
            this.town5Name = new System.Windows.Forms.Label();
            this.town5Value = new System.Windows.Forms.Label();
            this.town9Name = new System.Windows.Forms.Label();
            this.town9Value = new System.Windows.Forms.Label();
            this.town15Name = new System.Windows.Forms.Label();
            this.town15Value = new System.Windows.Forms.Label();
            this.town4Name = new System.Windows.Forms.Label();
            this.town4Value = new System.Windows.Forms.Label();
            this.town6Name = new System.Windows.Forms.Label();
            this.town6Value = new System.Windows.Forms.Label();
            this.town13Name = new System.Windows.Forms.Label();
            this.town13Value = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(873, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // actionToolStripMenuItem
            // 
            this.actionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.authorToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.actionToolStripMenuItem.Name = "actionToolStripMenuItem";
            this.actionToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.actionToolStripMenuItem.Text = "Action";
            // 
            // authorToolStripMenuItem
            // 
            this.authorToolStripMenuItem.Name = "authorToolStripMenuItem";
            this.authorToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.authorToolStripMenuItem.Text = "Author";
            this.authorToolStripMenuItem.Click += new System.EventHandler(this.authorToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(873, 632);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(865, 604);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Gainsboro;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.textBox1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.528428F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.47157F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(859, 598);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBox1.Location = new System.Drawing.Point(10, 61);
            this.textBox1.Margin = new System.Windows.Forms.Padding(10, 10, 10, 20);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(839, 517);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.button1.Location = new System.Drawing.Point(10, 10);
            this.button1.Margin = new System.Windows.Forms.Padding(10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(260, 31);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel3);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(865, 604);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.Gainsboro;
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 863F));
            this.tableLayoutPanel3.Controls.Add(this.textBox2, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.comboBox1, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.64706F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(859, 598);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBox2.Location = new System.Drawing.Point(10, 81);
            this.textBox2.Margin = new System.Windows.Forms.Padding(10, 10, 10, 20);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(843, 497);
            this.textBox2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(857, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // comboBox1
            // 
            this.comboBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(10, 35);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(10);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(400, 23);
            this.comboBox1.Sorted = true;
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.panel2);
            this.tabPage3.Controls.Add(this.tableLayoutPanel1);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(865, 604);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(605, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(257, 598);
            this.panel2.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.button2.Location = new System.Drawing.Point(8, 75);
            this.button2.Margin = new System.Windows.Forms.Padding(15);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(229, 49);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.Location = new System.Drawing.Point(13, 11);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 15, 15, 15);
            this.label2.Size = new System.Drawing.Size(60, 49);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label3.Location = new System.Drawing.Point(13, 302);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 15, 15, 15);
            this.label3.Size = new System.Drawing.Size(60, 49);
            this.label3.TabIndex = 5;
            this.label3.Text = "label3";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.button3.Location = new System.Drawing.Point(8, 154);
            this.button3.Margin = new System.Windows.Forms.Padding(15);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(229, 50);
            this.button3.TabIndex = 3;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.button4.Location = new System.Drawing.Point(8, 234);
            this.button4.Margin = new System.Windows.Forms.Padding(15);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(229, 49);
            this.button4.TabIndex = 4;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.69167F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(859, 598);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.town3Name);
            this.panel1.Controls.Add(this.town3Value);
            this.panel1.Controls.Add(this.town14Name);
            this.panel1.Controls.Add(this.town14Value);
            this.panel1.Controls.Add(this.town12Name);
            this.panel1.Controls.Add(this.town12Value);
            this.panel1.Controls.Add(this.town8Name);
            this.panel1.Controls.Add(this.town8Value);
            this.panel1.Controls.Add(this.town2Name);
            this.panel1.Controls.Add(this.town2Value);
            this.panel1.Controls.Add(this.town11Name);
            this.panel1.Controls.Add(this.town11Value);
            this.panel1.Controls.Add(this.town1Name);
            this.panel1.Controls.Add(this.town1Value);
            this.panel1.Controls.Add(this.town7Name);
            this.panel1.Controls.Add(this.town7Value);
            this.panel1.Controls.Add(this.town10Name);
            this.panel1.Controls.Add(this.town10Value);
            this.panel1.Controls.Add(this.town0Name);
            this.panel1.Controls.Add(this.town0Value);
            this.panel1.Controls.Add(this.town5Name);
            this.panel1.Controls.Add(this.town5Value);
            this.panel1.Controls.Add(this.town9Name);
            this.panel1.Controls.Add(this.town9Value);
            this.panel1.Controls.Add(this.town15Name);
            this.panel1.Controls.Add(this.town15Value);
            this.panel1.Controls.Add(this.town4Name);
            this.panel1.Controls.Add(this.town4Value);
            this.panel1.Controls.Add(this.town6Name);
            this.panel1.Controls.Add(this.town6Value);
            this.panel1.Controls.Add(this.town13Name);
            this.panel1.Controls.Add(this.town13Value);
            this.panel1.Controls.Add(this.tableLayoutPanel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(601, 592);
            this.panel1.TabIndex = 0;
            // 
            // town3Name
            // 
            this.town3Name.AutoSize = true;
            this.town3Name.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.town3Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.town3Name.ForeColor = System.Drawing.Color.Blue;
            this.town3Name.Location = new System.Drawing.Point(206, 424);
            this.town3Name.Name = "town3Name";
            this.town3Name.Padding = new System.Windows.Forms.Padding(5);
            this.town3Name.Size = new System.Drawing.Size(41, 30);
            this.town3Name.TabIndex = 32;
            this.town3Name.Text = "(...)";
            // 
            // town3Value
            // 
            this.town3Value.AutoSize = true;
            this.town3Value.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.town3Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.town3Value.ForeColor = System.Drawing.Color.Red;
            this.town3Value.Location = new System.Drawing.Point(206, 395);
            this.town3Value.Name = "town3Value";
            this.town3Value.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.town3Value.Size = new System.Drawing.Size(36, 26);
            this.town3Value.TabIndex = 31;
            this.town3Value.Text = "???";
            // 
            // town14Name
            // 
            this.town14Name.AutoSize = true;
            this.town14Name.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.town14Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.town14Name.ForeColor = System.Drawing.Color.Blue;
            this.town14Name.Location = new System.Drawing.Point(139, 340);
            this.town14Name.Name = "town14Name";
            this.town14Name.Padding = new System.Windows.Forms.Padding(5);
            this.town14Name.Size = new System.Drawing.Size(41, 30);
            this.town14Name.TabIndex = 30;
            this.town14Name.Text = "(...)";
            // 
            // town14Value
            // 
            this.town14Value.AutoSize = true;
            this.town14Value.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.town14Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.town14Value.ForeColor = System.Drawing.Color.Red;
            this.town14Value.Location = new System.Drawing.Point(139, 311);
            this.town14Value.Name = "town14Value";
            this.town14Value.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.town14Value.Size = new System.Drawing.Size(36, 26);
            this.town14Value.TabIndex = 29;
            this.town14Value.Text = "???";
            // 
            // town12Name
            // 
            this.town12Name.AutoSize = true;
            this.town12Name.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.town12Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.town12Name.ForeColor = System.Drawing.Color.Blue;
            this.town12Name.Location = new System.Drawing.Point(225, 183);
            this.town12Name.Name = "town12Name";
            this.town12Name.Padding = new System.Windows.Forms.Padding(5);
            this.town12Name.Size = new System.Drawing.Size(41, 30);
            this.town12Name.TabIndex = 28;
            this.town12Name.Text = "(...)";
            // 
            // town12Value
            // 
            this.town12Value.AutoSize = true;
            this.town12Value.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.town12Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.town12Value.ForeColor = System.Drawing.Color.Red;
            this.town12Value.Location = new System.Drawing.Point(225, 154);
            this.town12Value.Name = "town12Value";
            this.town12Value.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.town12Value.Size = new System.Drawing.Size(36, 26);
            this.town12Value.TabIndex = 27;
            this.town12Value.Text = "???";
            // 
            // town8Name
            // 
            this.town8Name.AutoSize = true;
            this.town8Name.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.town8Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.town8Name.ForeColor = System.Drawing.Color.Blue;
            this.town8Name.Location = new System.Drawing.Point(176, 263);
            this.town8Name.Name = "town8Name";
            this.town8Name.Padding = new System.Windows.Forms.Padding(5);
            this.town8Name.Size = new System.Drawing.Size(41, 30);
            this.town8Name.TabIndex = 26;
            this.town8Name.Text = "(...)";
            // 
            // town8Value
            // 
            this.town8Value.AutoSize = true;
            this.town8Value.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.town8Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.town8Value.ForeColor = System.Drawing.Color.Red;
            this.town8Value.Location = new System.Drawing.Point(176, 234);
            this.town8Value.Name = "town8Value";
            this.town8Value.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.town8Value.Size = new System.Drawing.Size(36, 26);
            this.town8Value.TabIndex = 25;
            this.town8Value.Text = "???";
            // 
            // town2Name
            // 
            this.town2Name.AutoSize = true;
            this.town2Name.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.town2Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.town2Name.ForeColor = System.Drawing.Color.Blue;
            this.town2Name.Location = new System.Drawing.Point(57, 249);
            this.town2Name.Name = "town2Name";
            this.town2Name.Padding = new System.Windows.Forms.Padding(5);
            this.town2Name.Size = new System.Drawing.Size(41, 30);
            this.town2Name.TabIndex = 24;
            this.town2Name.Text = "(...)";
            // 
            // town2Value
            // 
            this.town2Value.AutoSize = true;
            this.town2Value.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.town2Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.town2Value.ForeColor = System.Drawing.Color.Red;
            this.town2Value.Location = new System.Drawing.Point(57, 220);
            this.town2Value.Name = "town2Value";
            this.town2Value.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.town2Value.Size = new System.Drawing.Size(36, 26);
            this.town2Value.TabIndex = 23;
            this.town2Value.Text = "???";
            // 
            // town11Name
            // 
            this.town11Name.AutoSize = true;
            this.town11Name.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.town11Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.town11Name.ForeColor = System.Drawing.Color.Blue;
            this.town11Name.Location = new System.Drawing.Point(44, 123);
            this.town11Name.Name = "town11Name";
            this.town11Name.Padding = new System.Windows.Forms.Padding(5);
            this.town11Name.Size = new System.Drawing.Size(41, 30);
            this.town11Name.TabIndex = 22;
            this.town11Name.Text = "(...)";
            // 
            // town11Value
            // 
            this.town11Value.AutoSize = true;
            this.town11Value.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.town11Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.town11Value.ForeColor = System.Drawing.Color.Red;
            this.town11Value.Location = new System.Drawing.Point(44, 94);
            this.town11Value.Name = "town11Value";
            this.town11Value.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.town11Value.Size = new System.Drawing.Size(36, 26);
            this.town11Value.TabIndex = 21;
            this.town11Value.Text = "???";
            // 
            // town1Name
            // 
            this.town1Name.AutoSize = true;
            this.town1Name.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.town1Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.town1Name.ForeColor = System.Drawing.Color.Blue;
            this.town1Name.Location = new System.Drawing.Point(225, 86);
            this.town1Name.Name = "town1Name";
            this.town1Name.Padding = new System.Windows.Forms.Padding(5);
            this.town1Name.Size = new System.Drawing.Size(41, 30);
            this.town1Name.TabIndex = 20;
            this.town1Name.Text = "(...)";
            // 
            // town1Value
            // 
            this.town1Value.AutoSize = true;
            this.town1Value.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.town1Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.town1Value.ForeColor = System.Drawing.Color.Red;
            this.town1Value.Location = new System.Drawing.Point(225, 57);
            this.town1Value.Name = "town1Value";
            this.town1Value.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.town1Value.Size = new System.Drawing.Size(36, 26);
            this.town1Value.TabIndex = 19;
            this.town1Value.Text = "???";
            // 
            // town7Name
            // 
            this.town7Name.AutoSize = true;
            this.town7Name.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.town7Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.town7Name.ForeColor = System.Drawing.Color.Blue;
            this.town7Name.Location = new System.Drawing.Point(346, 104);
            this.town7Name.Name = "town7Name";
            this.town7Name.Padding = new System.Windows.Forms.Padding(5);
            this.town7Name.Size = new System.Drawing.Size(41, 30);
            this.town7Name.TabIndex = 18;
            this.town7Name.Text = "(...)";
            // 
            // town7Value
            // 
            this.town7Value.AutoSize = true;
            this.town7Value.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.town7Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.town7Value.ForeColor = System.Drawing.Color.Red;
            this.town7Value.Location = new System.Drawing.Point(346, 75);
            this.town7Value.Name = "town7Value";
            this.town7Value.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.town7Value.Size = new System.Drawing.Size(36, 26);
            this.town7Value.TabIndex = 17;
            this.town7Value.Text = "???";
            // 
            // town10Name
            // 
            this.town10Name.AutoSize = true;
            this.town10Name.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.town10Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.town10Name.ForeColor = System.Drawing.Color.Blue;
            this.town10Name.Location = new System.Drawing.Point(475, 117);
            this.town10Name.Name = "town10Name";
            this.town10Name.Padding = new System.Windows.Forms.Padding(5);
            this.town10Name.Size = new System.Drawing.Size(41, 30);
            this.town10Name.TabIndex = 16;
            this.town10Name.Text = "(...)";
            // 
            // town10Value
            // 
            this.town10Value.AutoSize = true;
            this.town10Value.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.town10Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.town10Value.ForeColor = System.Drawing.Color.Red;
            this.town10Value.Location = new System.Drawing.Point(475, 88);
            this.town10Value.Name = "town10Value";
            this.town10Value.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.town10Value.Size = new System.Drawing.Size(36, 26);
            this.town10Value.TabIndex = 15;
            this.town10Value.Text = "???";
            // 
            // town0Name
            // 
            this.town0Name.AutoSize = true;
            this.town0Name.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.town0Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.town0Name.ForeColor = System.Drawing.Color.Blue;
            this.town0Name.Location = new System.Drawing.Point(492, 217);
            this.town0Name.Name = "town0Name";
            this.town0Name.Padding = new System.Windows.Forms.Padding(5);
            this.town0Name.Size = new System.Drawing.Size(41, 30);
            this.town0Name.TabIndex = 14;
            this.town0Name.Text = "(...)";
            // 
            // town0Value
            // 
            this.town0Value.AutoSize = true;
            this.town0Value.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.town0Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.town0Value.ForeColor = System.Drawing.Color.Red;
            this.town0Value.Location = new System.Drawing.Point(492, 188);
            this.town0Value.Name = "town0Value";
            this.town0Value.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.town0Value.Size = new System.Drawing.Size(36, 26);
            this.town0Value.TabIndex = 13;
            this.town0Value.Text = "???";
            // 
            // town5Name
            // 
            this.town5Name.AutoSize = true;
            this.town5Name.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.town5Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.town5Name.ForeColor = System.Drawing.Color.Blue;
            this.town5Name.Location = new System.Drawing.Point(475, 363);
            this.town5Name.Name = "town5Name";
            this.town5Name.Padding = new System.Windows.Forms.Padding(5);
            this.town5Name.Size = new System.Drawing.Size(41, 30);
            this.town5Name.TabIndex = 12;
            this.town5Name.Text = "(...)";
            // 
            // town5Value
            // 
            this.town5Value.AutoSize = true;
            this.town5Value.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.town5Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.town5Value.ForeColor = System.Drawing.Color.Red;
            this.town5Value.Location = new System.Drawing.Point(475, 334);
            this.town5Value.Name = "town5Value";
            this.town5Value.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.town5Value.Size = new System.Drawing.Size(36, 26);
            this.town5Value.TabIndex = 11;
            this.town5Value.Text = "???";
            // 
            // town9Name
            // 
            this.town9Name.AutoSize = true;
            this.town9Name.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.town9Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.town9Name.ForeColor = System.Drawing.Color.Blue;
            this.town9Name.Location = new System.Drawing.Point(452, 442);
            this.town9Name.Name = "town9Name";
            this.town9Name.Padding = new System.Windows.Forms.Padding(5);
            this.town9Name.Size = new System.Drawing.Size(41, 30);
            this.town9Name.TabIndex = 10;
            this.town9Name.Text = "(...)";
            // 
            // town9Value
            // 
            this.town9Value.AutoSize = true;
            this.town9Value.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.town9Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.town9Value.ForeColor = System.Drawing.Color.Red;
            this.town9Value.Location = new System.Drawing.Point(452, 412);
            this.town9Value.Name = "town9Value";
            this.town9Value.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.town9Value.Size = new System.Drawing.Size(36, 26);
            this.town9Value.TabIndex = 9;
            this.town9Value.Text = "???";
            // 
            // town15Name
            // 
            this.town15Name.AutoSize = true;
            this.town15Name.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.town15Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.town15Name.ForeColor = System.Drawing.Color.Blue;
            this.town15Name.Location = new System.Drawing.Point(346, 508);
            this.town15Name.Name = "town15Name";
            this.town15Name.Padding = new System.Windows.Forms.Padding(5);
            this.town15Name.Size = new System.Drawing.Size(41, 30);
            this.town15Name.TabIndex = 8;
            this.town15Name.Text = "(...)";
            // 
            // town15Value
            // 
            this.town15Value.AutoSize = true;
            this.town15Value.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.town15Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.town15Value.ForeColor = System.Drawing.Color.Red;
            this.town15Value.Location = new System.Drawing.Point(346, 479);
            this.town15Value.Name = "town15Value";
            this.town15Value.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.town15Value.Size = new System.Drawing.Size(36, 26);
            this.town15Value.TabIndex = 7;
            this.town15Value.Text = "???";
            // 
            // town4Name
            // 
            this.town4Name.AutoSize = true;
            this.town4Name.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.town4Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.town4Name.ForeColor = System.Drawing.Color.Blue;
            this.town4Name.Location = new System.Drawing.Point(319, 424);
            this.town4Name.Name = "town4Name";
            this.town4Name.Padding = new System.Windows.Forms.Padding(5);
            this.town4Name.Size = new System.Drawing.Size(41, 30);
            this.town4Name.TabIndex = 6;
            this.town4Name.Text = "(...)";
            // 
            // town4Value
            // 
            this.town4Value.AutoSize = true;
            this.town4Value.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.town4Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.town4Value.ForeColor = System.Drawing.Color.Red;
            this.town4Value.Location = new System.Drawing.Point(319, 395);
            this.town4Value.Name = "town4Value";
            this.town4Value.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.town4Value.Size = new System.Drawing.Size(36, 26);
            this.town4Value.TabIndex = 5;
            this.town4Value.Text = "???";
            // 
            // town6Name
            // 
            this.town6Name.AutoSize = true;
            this.town6Name.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.town6Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.town6Name.ForeColor = System.Drawing.Color.Blue;
            this.town6Name.Location = new System.Drawing.Point(277, 305);
            this.town6Name.Name = "town6Name";
            this.town6Name.Padding = new System.Windows.Forms.Padding(5);
            this.town6Name.Size = new System.Drawing.Size(41, 30);
            this.town6Name.TabIndex = 4;
            this.town6Name.Text = "(...)";
            // 
            // town6Value
            // 
            this.town6Value.AutoSize = true;
            this.town6Value.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.town6Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.town6Value.ForeColor = System.Drawing.Color.Red;
            this.town6Value.Location = new System.Drawing.Point(277, 276);
            this.town6Value.Name = "town6Value";
            this.town6Value.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.town6Value.Size = new System.Drawing.Size(36, 26);
            this.town6Value.TabIndex = 3;
            this.town6Value.Text = "???";
            // 
            // town13Name
            // 
            this.town13Name.AutoSize = true;
            this.town13Name.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.town13Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.town13Name.ForeColor = System.Drawing.Color.Blue;
            this.town13Name.Location = new System.Drawing.Point(367, 250);
            this.town13Name.Margin = new System.Windows.Forms.Padding(0);
            this.town13Name.Name = "town13Name";
            this.town13Name.Padding = new System.Windows.Forms.Padding(5);
            this.town13Name.Size = new System.Drawing.Size(41, 30);
            this.town13Name.TabIndex = 2;
            this.town13Name.Text = "(...)";
            // 
            // town13Value
            // 
            this.town13Value.AutoSize = true;
            this.town13Value.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.town13Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.town13Value.ForeColor = System.Drawing.Color.Red;
            this.town13Value.Location = new System.Drawing.Point(367, 221);
            this.town13Value.Name = "town13Value";
            this.town13Value.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.town13Value.Size = new System.Drawing.Size(36, 26);
            this.town13Value.TabIndex = 1;
            this.town13Value.Text = "???";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Location = new System.Drawing.Point(755, 106);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(95, 100);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 634);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(873, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 656);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(889, 695);
            this.Name = "MainForm";
            this.Text = "WeatherForecast";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem actionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem authorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label town13Value;
        private System.Windows.Forms.Label town1Name;
        private System.Windows.Forms.Label town1Value;
        private System.Windows.Forms.Label town7Name;
        private System.Windows.Forms.Label town7Value;
        private System.Windows.Forms.Label town10Name;
        private System.Windows.Forms.Label town10Value;
        private System.Windows.Forms.Label town0Name;
        private System.Windows.Forms.Label town0Value;
        private System.Windows.Forms.Label town5Name;
        private System.Windows.Forms.Label town5Value;
        private System.Windows.Forms.Label town9Name;
        private System.Windows.Forms.Label town9Value;
        private System.Windows.Forms.Label town15Name;
        private System.Windows.Forms.Label town15Value;
        private System.Windows.Forms.Label town4Name;
        private System.Windows.Forms.Label town4Value;
        private System.Windows.Forms.Label town6Name;
        private System.Windows.Forms.Label town6Value;
        private System.Windows.Forms.Label town13Name;
        private System.Windows.Forms.Label town3Name;
        private System.Windows.Forms.Label town3Value;
        private System.Windows.Forms.Label town14Name;
        private System.Windows.Forms.Label town14Value;
        private System.Windows.Forms.Label town12Name;
        private System.Windows.Forms.Label town12Value;
        private System.Windows.Forms.Label town8Name;
        private System.Windows.Forms.Label town8Value;
        private System.Windows.Forms.Label town2Name;
        private System.Windows.Forms.Label town2Value;
        private System.Windows.Forms.Label town11Name;
        private System.Windows.Forms.Label town11Value;
    }
}

