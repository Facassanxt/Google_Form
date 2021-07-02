
namespace Final
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuIconList = new System.Windows.Forms.ImageList(this.components);
            this.tabPageMenuCiphers = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.WB = new System.Windows.Forms.WebBrowser();
            this.URL = new MaterialSkin.Controls.MaterialTextBox();
            this.tabPageMenuSettings = new System.Windows.Forms.TabPage();
            this.Switch_Change_Theme = new MaterialSkin.Controls.MaterialSwitch();
            this.Switch_Language = new MaterialSkin.Controls.MaterialSwitch();
            this.Label1 = new MaterialSkin.Controls.MaterialLabel();
            this.Switch_Display_Icons_when_hidden = new MaterialSkin.Controls.MaterialSwitch();
            this.Switch_Background_with_Accent = new MaterialSkin.Controls.MaterialSwitch();
            this.Bu_Change_Colors = new MaterialSkin.Controls.MaterialButton();
            this.Switch_Highlight_with_Accent = new MaterialSkin.Controls.MaterialSwitch();
            this.Switch_Use_menu_colors = new MaterialSkin.Controls.MaterialSwitch();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.materialCheckbox1 = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialCheckbox2 = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialCheckbox3 = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialCheckbox4 = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialCheckbox5 = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialCheckbox6 = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialCheckbox7 = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialCheckbox8 = new MaterialSkin.Controls.MaterialCheckbox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.tabPageMenuCiphers.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPageMenuSettings.SuspendLayout();
            this.materialTabControl1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuIconList
            // 
            this.menuIconList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("menuIconList.ImageStream")));
            this.menuIconList.TransparentColor = System.Drawing.Color.Transparent;
            this.menuIconList.Images.SetKeyName(0, "round_assessment_white_24dp.png");
            this.menuIconList.Images.SetKeyName(1, "round_backup_white_24dp.png");
            this.menuIconList.Images.SetKeyName(2, "round_bluetooth_white_24dp.png");
            this.menuIconList.Images.SetKeyName(3, "round_bookmark_white_24dp.png");
            this.menuIconList.Images.SetKeyName(4, "round_build_white_24dp.png");
            this.menuIconList.Images.SetKeyName(5, "round_gps_fixed_white_24dp.png");
            this.menuIconList.Images.SetKeyName(6, "round_http_white_24dp.png");
            this.menuIconList.Images.SetKeyName(7, "round_report_problem_white_24dp.png");
            this.menuIconList.Images.SetKeyName(8, "round_swap_vert_white_24dp.png");
            // 
            // tabPageMenuCiphers
            // 
            this.tabPageMenuCiphers.BackColor = System.Drawing.Color.White;
            this.tabPageMenuCiphers.Controls.Add(this.panel1);
            this.tabPageMenuCiphers.Controls.Add(this.URL);
            this.tabPageMenuCiphers.ImageKey = "round_swap_vert_white_24dp.png";
            this.tabPageMenuCiphers.Location = new System.Drawing.Point(4, 31);
            this.tabPageMenuCiphers.Name = "tabPageMenuCiphers";
            this.tabPageMenuCiphers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMenuCiphers.Size = new System.Drawing.Size(1260, 612);
            this.tabPageMenuCiphers.TabIndex = 6;
            this.tabPageMenuCiphers.Text = "Ciphers";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.WB);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1254, 556);
            this.panel1.TabIndex = 104;
            // 
            // WB
            // 
            this.WB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WB.Location = new System.Drawing.Point(0, 0);
            this.WB.MinimumSize = new System.Drawing.Size(20, 20);
            this.WB.Name = "WB";
            this.WB.Size = new System.Drawing.Size(1254, 556);
            this.WB.TabIndex = 0;
            this.WB.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // URL
            // 
            this.URL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.URL.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.URL.Depth = 0;
            this.URL.Dock = System.Windows.Forms.DockStyle.Top;
            this.URL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.URL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.URL.Hint = "Type here your URL";
            this.URL.Location = new System.Drawing.Point(3, 3);
            this.URL.MaxLength = 50000;
            this.URL.MouseState = MaterialSkin.MouseState.OUT;
            this.URL.Multiline = false;
            this.URL.Name = "URL";
            this.URL.Size = new System.Drawing.Size(1254, 50);
            this.URL.TabIndex = 103;
            this.URL.Text = "https://docs.google.com/forms/d/e/1FAIpQLSentHkCp0AKal-I3Pbw9BSzCqI-kl6HFh1hfGEeG" +
    "OdVQnxhAg/viewform";
            this.URL.KeyDown += new System.Windows.Forms.KeyEventHandler(this.URL_KeyDown);
            // 
            // tabPageMenuSettings
            // 
            this.tabPageMenuSettings.BackColor = System.Drawing.Color.White;
            this.tabPageMenuSettings.Controls.Add(this.Switch_Change_Theme);
            this.tabPageMenuSettings.Controls.Add(this.Switch_Language);
            this.tabPageMenuSettings.Controls.Add(this.Label1);
            this.tabPageMenuSettings.Controls.Add(this.Switch_Display_Icons_when_hidden);
            this.tabPageMenuSettings.Controls.Add(this.Switch_Background_with_Accent);
            this.tabPageMenuSettings.Controls.Add(this.Bu_Change_Colors);
            this.tabPageMenuSettings.Controls.Add(this.Switch_Highlight_with_Accent);
            this.tabPageMenuSettings.Controls.Add(this.Switch_Use_menu_colors);
            this.tabPageMenuSettings.ImageKey = "round_build_white_24dp.png";
            this.tabPageMenuSettings.Location = new System.Drawing.Point(4, 31);
            this.tabPageMenuSettings.Name = "tabPageMenuSettings";
            this.tabPageMenuSettings.Size = new System.Drawing.Size(1260, 612);
            this.tabPageMenuSettings.TabIndex = 0;
            this.tabPageMenuSettings.Text = "Settings";
            // 
            // Switch_Change_Theme
            // 
            this.Switch_Change_Theme.AutoSize = true;
            this.Switch_Change_Theme.Checked = true;
            this.Switch_Change_Theme.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Switch_Change_Theme.Depth = 0;
            this.Switch_Change_Theme.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Switch_Change_Theme.Location = new System.Drawing.Point(14, 129);
            this.Switch_Change_Theme.Margin = new System.Windows.Forms.Padding(0);
            this.Switch_Change_Theme.MouseLocation = new System.Drawing.Point(-1, -1);
            this.Switch_Change_Theme.MouseState = MaterialSkin.MouseState.HOVER;
            this.Switch_Change_Theme.Name = "Switch_Change_Theme";
            this.Switch_Change_Theme.Ripple = true;
            this.Switch_Change_Theme.Size = new System.Drawing.Size(286, 37);
            this.Switch_Change_Theme.TabIndex = 41;
            this.Switch_Change_Theme.Text = "Change Theme - LIGHT ⮀ DARK\r\n";
            this.Switch_Change_Theme.UseVisualStyleBackColor = true;
            this.Switch_Change_Theme.CheckedChanged += new System.EventHandler(this.Switch_Change_Theme_CheckedChanged);
            // 
            // Switch_Language
            // 
            this.Switch_Language.AutoSize = true;
            this.Switch_Language.Checked = true;
            this.Switch_Language.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Switch_Language.Depth = 0;
            this.Switch_Language.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Switch_Language.Location = new System.Drawing.Point(14, 166);
            this.Switch_Language.Margin = new System.Windows.Forms.Padding(0);
            this.Switch_Language.MouseLocation = new System.Drawing.Point(-1, -1);
            this.Switch_Language.MouseState = MaterialSkin.MouseState.HOVER;
            this.Switch_Language.Name = "Switch_Language";
            this.Switch_Language.Ripple = true;
            this.Switch_Language.Size = new System.Drawing.Size(211, 37);
            this.Switch_Language.TabIndex = 40;
            this.Switch_Language.Text = "Language - RU ⮀ ENG";
            this.Switch_Language.UseVisualStyleBackColor = true;
            this.Switch_Language.CheckedChanged += new System.EventHandler(this.Switch_Language_CheckedChanged);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Depth = 0;
            this.Label1.Font = new System.Drawing.Font("Roboto", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.Label1.FontType = MaterialSkin.MaterialSkinManager.fontType.H3;
            this.Label1.Location = new System.Drawing.Point(14, 12);
            this.Label1.MouseState = MaterialSkin.MouseState.HOVER;
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(426, 58);
            this.Label1.TabIndex = 38;
            this.Label1.Text = "Application settings";
            // 
            // Switch_Display_Icons_when_hidden
            // 
            this.Switch_Display_Icons_when_hidden.AutoSize = true;
            this.Switch_Display_Icons_when_hidden.Checked = true;
            this.Switch_Display_Icons_when_hidden.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Switch_Display_Icons_when_hidden.Depth = 0;
            this.Switch_Display_Icons_when_hidden.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Switch_Display_Icons_when_hidden.Location = new System.Drawing.Point(14, 314);
            this.Switch_Display_Icons_when_hidden.Margin = new System.Windows.Forms.Padding(0);
            this.Switch_Display_Icons_when_hidden.MouseLocation = new System.Drawing.Point(-1, -1);
            this.Switch_Display_Icons_when_hidden.MouseState = MaterialSkin.MouseState.HOVER;
            this.Switch_Display_Icons_when_hidden.Name = "Switch_Display_Icons_when_hidden";
            this.Switch_Display_Icons_when_hidden.Ripple = true;
            this.Switch_Display_Icons_when_hidden.Size = new System.Drawing.Size(309, 37);
            this.Switch_Display_Icons_when_hidden.TabIndex = 37;
            this.Switch_Display_Icons_when_hidden.Text = "Drawer - Display Icons when hidden";
            this.Switch_Display_Icons_when_hidden.UseVisualStyleBackColor = true;
            this.Switch_Display_Icons_when_hidden.CheckedChanged += new System.EventHandler(this.Switch_Display_Icons_when_hidden_CheckedChanged);
            // 
            // Switch_Background_with_Accent
            // 
            this.Switch_Background_with_Accent.AutoSize = true;
            this.Switch_Background_with_Accent.Checked = true;
            this.Switch_Background_with_Accent.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Switch_Background_with_Accent.Depth = 0;
            this.Switch_Background_with_Accent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Switch_Background_with_Accent.Location = new System.Drawing.Point(14, 277);
            this.Switch_Background_with_Accent.Margin = new System.Windows.Forms.Padding(0);
            this.Switch_Background_with_Accent.MouseLocation = new System.Drawing.Point(-1, -1);
            this.Switch_Background_with_Accent.MouseState = MaterialSkin.MouseState.HOVER;
            this.Switch_Background_with_Accent.Name = "Switch_Background_with_Accent";
            this.Switch_Background_with_Accent.Ripple = true;
            this.Switch_Background_with_Accent.Size = new System.Drawing.Size(291, 37);
            this.Switch_Background_with_Accent.TabIndex = 31;
            this.Switch_Background_with_Accent.Text = "Drawer - Background with Accent";
            this.Switch_Background_with_Accent.UseVisualStyleBackColor = true;
            this.Switch_Background_with_Accent.CheckedChanged += new System.EventHandler(this.Switch_Background_with_Accent_CheckedChanged);
            // 
            // Bu_Change_Colors
            // 
            this.Bu_Change_Colors.AutoSize = false;
            this.Bu_Change_Colors.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Bu_Change_Colors.Depth = 0;
            this.Bu_Change_Colors.DrawShadows = true;
            this.Bu_Change_Colors.HighEmphasis = true;
            this.Bu_Change_Colors.Icon = null;
            this.Bu_Change_Colors.Location = new System.Drawing.Point(14, 87);
            this.Bu_Change_Colors.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Bu_Change_Colors.MouseState = MaterialSkin.MouseState.HOVER;
            this.Bu_Change_Colors.Name = "Bu_Change_Colors";
            this.Bu_Change_Colors.Size = new System.Drawing.Size(140, 36);
            this.Bu_Change_Colors.TabIndex = 22;
            this.Bu_Change_Colors.Text = "Change Colors";
            this.Bu_Change_Colors.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Bu_Change_Colors.UseAccentColor = false;
            this.Bu_Change_Colors.UseVisualStyleBackColor = true;
            this.Bu_Change_Colors.Click += new System.EventHandler(this.Bu_Change_Colors_Click);
            // 
            // Switch_Highlight_with_Accent
            // 
            this.Switch_Highlight_with_Accent.AutoSize = true;
            this.Switch_Highlight_with_Accent.Checked = true;
            this.Switch_Highlight_with_Accent.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Switch_Highlight_with_Accent.Depth = 0;
            this.Switch_Highlight_with_Accent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Switch_Highlight_with_Accent.Location = new System.Drawing.Point(14, 240);
            this.Switch_Highlight_with_Accent.Margin = new System.Windows.Forms.Padding(0);
            this.Switch_Highlight_with_Accent.MouseLocation = new System.Drawing.Point(-1, -1);
            this.Switch_Highlight_with_Accent.MouseState = MaterialSkin.MouseState.HOVER;
            this.Switch_Highlight_with_Accent.Name = "Switch_Highlight_with_Accent";
            this.Switch_Highlight_with_Accent.Ripple = true;
            this.Switch_Highlight_with_Accent.Size = new System.Drawing.Size(270, 37);
            this.Switch_Highlight_with_Accent.TabIndex = 30;
            this.Switch_Highlight_with_Accent.Text = "Drawer - Highlight with Accent";
            this.Switch_Highlight_with_Accent.UseVisualStyleBackColor = true;
            this.Switch_Highlight_with_Accent.CheckedChanged += new System.EventHandler(this.Switch_Highlight_with_Accent_CheckedChanged);
            // 
            // Switch_Use_menu_colors
            // 
            this.Switch_Use_menu_colors.AutoSize = true;
            this.Switch_Use_menu_colors.Depth = 0;
            this.Switch_Use_menu_colors.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Switch_Use_menu_colors.Location = new System.Drawing.Point(14, 203);
            this.Switch_Use_menu_colors.Margin = new System.Windows.Forms.Padding(0);
            this.Switch_Use_menu_colors.MouseLocation = new System.Drawing.Point(-1, -1);
            this.Switch_Use_menu_colors.MouseState = MaterialSkin.MouseState.HOVER;
            this.Switch_Use_menu_colors.Name = "Switch_Use_menu_colors";
            this.Switch_Use_menu_colors.Ripple = true;
            this.Switch_Use_menu_colors.Size = new System.Drawing.Size(237, 37);
            this.Switch_Use_menu_colors.TabIndex = 29;
            this.Switch_Use_menu_colors.Text = "Drawer - Use menu colors";
            this.Switch_Use_menu_colors.UseVisualStyleBackColor = true;
            this.Switch_Use_menu_colors.CheckedChanged += new System.EventHandler(this.Switch_Use_menu_colors_CheckedChanged);
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPageMenuCiphers);
            this.materialTabControl1.Controls.Add(this.tabPageMenuSettings);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.ImageList = this.menuIconList;
            this.materialTabControl1.Location = new System.Drawing.Point(3, 3);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1268, 647);
            this.materialTabControl1.TabIndex = 18;
            // 
            // materialCheckbox1
            // 
            this.materialCheckbox1.Depth = 0;
            this.materialCheckbox1.Location = new System.Drawing.Point(0, 0);
            this.materialCheckbox1.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox1.Name = "materialCheckbox1";
            this.materialCheckbox1.Ripple = true;
            this.materialCheckbox1.Size = new System.Drawing.Size(104, 37);
            this.materialCheckbox1.TabIndex = 0;
            // 
            // materialCheckbox2
            // 
            this.materialCheckbox2.Depth = 0;
            this.materialCheckbox2.Location = new System.Drawing.Point(0, 0);
            this.materialCheckbox2.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox2.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox2.Name = "materialCheckbox2";
            this.materialCheckbox2.Ripple = true;
            this.materialCheckbox2.Size = new System.Drawing.Size(104, 37);
            this.materialCheckbox2.TabIndex = 0;
            // 
            // materialCheckbox3
            // 
            this.materialCheckbox3.Depth = 0;
            this.materialCheckbox3.Location = new System.Drawing.Point(0, 0);
            this.materialCheckbox3.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox3.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox3.Name = "materialCheckbox3";
            this.materialCheckbox3.Ripple = true;
            this.materialCheckbox3.Size = new System.Drawing.Size(104, 37);
            this.materialCheckbox3.TabIndex = 0;
            // 
            // materialCheckbox4
            // 
            this.materialCheckbox4.Depth = 0;
            this.materialCheckbox4.Location = new System.Drawing.Point(0, 0);
            this.materialCheckbox4.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox4.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox4.Name = "materialCheckbox4";
            this.materialCheckbox4.Ripple = true;
            this.materialCheckbox4.Size = new System.Drawing.Size(104, 37);
            this.materialCheckbox4.TabIndex = 0;
            // 
            // materialCheckbox5
            // 
            this.materialCheckbox5.Depth = 0;
            this.materialCheckbox5.Location = new System.Drawing.Point(0, 0);
            this.materialCheckbox5.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox5.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox5.Name = "materialCheckbox5";
            this.materialCheckbox5.Ripple = true;
            this.materialCheckbox5.Size = new System.Drawing.Size(104, 37);
            this.materialCheckbox5.TabIndex = 0;
            // 
            // materialCheckbox6
            // 
            this.materialCheckbox6.Depth = 0;
            this.materialCheckbox6.Location = new System.Drawing.Point(0, 0);
            this.materialCheckbox6.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox6.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox6.Name = "materialCheckbox6";
            this.materialCheckbox6.Ripple = true;
            this.materialCheckbox6.Size = new System.Drawing.Size(104, 37);
            this.materialCheckbox6.TabIndex = 0;
            // 
            // materialCheckbox7
            // 
            this.materialCheckbox7.Depth = 0;
            this.materialCheckbox7.Location = new System.Drawing.Point(0, 0);
            this.materialCheckbox7.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox7.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox7.Name = "materialCheckbox7";
            this.materialCheckbox7.Ripple = true;
            this.materialCheckbox7.Size = new System.Drawing.Size(104, 37);
            this.materialCheckbox7.TabIndex = 0;
            // 
            // materialCheckbox8
            // 
            this.materialCheckbox8.Depth = 0;
            this.materialCheckbox8.Location = new System.Drawing.Point(0, 0);
            this.materialCheckbox8.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox8.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox8.Name = "materialCheckbox8";
            this.materialCheckbox8.Ripple = true;
            this.materialCheckbox8.Size = new System.Drawing.Size(104, 37);
            this.materialCheckbox8.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.materialTabControl1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 64);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1274, 653);
            this.tableLayoutPanel1.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(458, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(555, 35);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 21;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(649, 35);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 22;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(747, 35);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 23;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(128, 72);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(3, 64, 3, 3);
            this.Text = "Накрутка Google Form by Facassanxt";
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.tabPageMenuCiphers.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tabPageMenuSettings.ResumeLayout(false);
            this.tabPageMenuSettings.PerformLayout();
            this.materialTabControl1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList menuIconList;
        private System.Windows.Forms.TabPage tabPageMenuCiphers;
        private System.Windows.Forms.TabPage tabPageMenuSettings;
        private MaterialSkin.Controls.MaterialSwitch Switch_Display_Icons_when_hidden;
        private MaterialSkin.Controls.MaterialSwitch Switch_Background_with_Accent;
        private MaterialSkin.Controls.MaterialButton Bu_Change_Colors;
        private MaterialSkin.Controls.MaterialSwitch Switch_Highlight_with_Accent;
        private MaterialSkin.Controls.MaterialSwitch Switch_Use_menu_colors;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private MaterialSkin.Controls.MaterialSwitch Switch_Language;
        private MaterialSkin.Controls.MaterialLabel Label1;
        private MaterialSkin.Controls.MaterialSwitch Switch_Change_Theme;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox1;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox2;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox3;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox4;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox5;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox6;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox7;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MaterialSkin.Controls.MaterialTextBox URL;
        private System.Windows.Forms.WebBrowser WB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

