namespace sShuffler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listView_files = new System.Windows.Forms.ListView();
            this.chTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chExtension = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sShuffler = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.shuffleBtn = new System.Windows.Forms.Button();
            this.totalShuffle = new System.Windows.Forms.Label();
            this.clearBtn = new System.Windows.Forms.Button();
            this.consoleLog = new System.Windows.Forms.RichTextBox();
            this.helpBtn = new System.Windows.Forms.Button();
            this.helpPanel = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.startingPointNum = new System.Windows.Forms.NumericUpDown();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.manStartingPointHelpLabel = new System.Windows.Forms.Label();
            this.manualStartingPointPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.infoBtn = new System.Windows.Forms.Button();
            this.infoPanel = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.loadingGif = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.progressPanel = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.helpPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.startingPointNum)).BeginInit();
            this.manualStartingPointPanel.SuspendLayout();
            this.infoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loadingGif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.progressPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // listView_files
            // 
            this.listView_files.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.listView_files.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.listView_files.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView_files.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chTitle,
            this.chSize,
            this.chExtension});
            this.listView_files.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listView_files.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.listView_files.FullRowSelect = true;
            this.listView_files.GridLines = true;
            this.listView_files.HideSelection = false;
            this.listView_files.Location = new System.Drawing.Point(630, 12);
            this.listView_files.Name = "listView_files";
            this.listView_files.Size = new System.Drawing.Size(493, 406);
            this.listView_files.TabIndex = 0;
            this.listView_files.UseCompatibleStateImageBehavior = false;
            this.listView_files.View = System.Windows.Forms.View.Details;
            this.listView_files.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // chTitle
            // 
            this.chTitle.Text = "Title";
            this.chTitle.Width = 255;
            // 
            // chSize
            // 
            this.chSize.Text = "Size";
            this.chSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chSize.Width = 100;
            // 
            // chExtension
            // 
            this.chExtension.Text = "Extension";
            this.chExtension.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chExtension.Width = 80;
            // 
            // sShuffler
            // 
            this.sShuffler.AutoSize = true;
            this.sShuffler.Font = new System.Drawing.Font("Candara Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sShuffler.Location = new System.Drawing.Point(7, 116);
            this.sShuffler.Name = "sShuffler";
            this.sShuffler.Size = new System.Drawing.Size(51, 29);
            this.sShuffler.TabIndex = 1;
            this.sShuffler.Text = "Log";
            this.sShuffler.UseMnemonic = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(627, 428);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(593, 34);
            this.label2.TabIndex = 4;
            this.label2.Text = "If needed, you can delete one or multiple elements by selecting them and then pre" +
    "ssing DEL \r\nkey. Effect is immediate.";
            // 
            // shuffleBtn
            // 
            this.shuffleBtn.BackColor = System.Drawing.Color.PaleGreen;
            this.shuffleBtn.FlatAppearance.BorderSize = 0;
            this.shuffleBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.shuffleBtn.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.shuffleBtn.Location = new System.Drawing.Point(133, 446);
            this.shuffleBtn.Name = "shuffleBtn";
            this.shuffleBtn.Size = new System.Drawing.Size(184, 48);
            this.shuffleBtn.TabIndex = 5;
            this.shuffleBtn.Text = "sShuffle";
            this.shuffleBtn.UseVisualStyleBackColor = false;
            // 
            // totalShuffle
            // 
            this.totalShuffle.AutoSize = true;
            this.totalShuffle.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.totalShuffle.Location = new System.Drawing.Point(135, 497);
            this.totalShuffle.Name = "totalShuffle";
            this.totalShuffle.Size = new System.Drawing.Size(182, 17);
            this.totalShuffle.TabIndex = 6;
            this.totalShuffle.Text = "Total songs to sShuffle: 0\r\n";
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.Color.LightSalmon;
            this.clearBtn.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.clearBtn.FlatAppearance.BorderSize = 0;
            this.clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearBtn.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.clearBtn.Location = new System.Drawing.Point(-2, -2);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(101, 56);
            this.clearBtn.TabIndex = 7;
            this.clearBtn.Text = "RESET";
            this.clearBtn.UseVisualStyleBackColor = false;
            // 
            // consoleLog
            // 
            this.consoleLog.DetectUrls = false;
            this.consoleLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.consoleLog.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.consoleLog.Location = new System.Drawing.Point(12, 148);
            this.consoleLog.Name = "consoleLog";
            this.consoleLog.ReadOnly = true;
            this.consoleLog.Size = new System.Drawing.Size(352, 196);
            this.consoleLog.TabIndex = 9;
            this.consoleLog.Text = "";
            // 
            // helpBtn
            // 
            this.helpBtn.BackColor = System.Drawing.Color.LightGreen;
            this.helpBtn.FlatAppearance.BorderSize = 0;
            this.helpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.helpBtn.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.helpBtn.Location = new System.Drawing.Point(105, -3);
            this.helpBtn.Name = "helpBtn";
            this.helpBtn.Size = new System.Drawing.Size(101, 56);
            this.helpBtn.TabIndex = 10;
            this.helpBtn.Text = "Help";
            this.helpBtn.UseVisualStyleBackColor = false;
            // 
            // helpPanel
            // 
            this.helpPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.helpPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.helpPanel.Controls.Add(this.label11);
            this.helpPanel.Controls.Add(this.label9);
            this.helpPanel.Controls.Add(this.label8);
            this.helpPanel.Controls.Add(this.label7);
            this.helpPanel.Controls.Add(this.label6);
            this.helpPanel.Controls.Add(this.label4);
            this.helpPanel.Controls.Add(this.label5);
            this.helpPanel.Controls.Add(this.label3);
            this.helpPanel.Location = new System.Drawing.Point(630, 12);
            this.helpPanel.Name = "helpPanel";
            this.helpPanel.Size = new System.Drawing.Size(550, 529);
            this.helpPanel.TabIndex = 11;
            this.helpPanel.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(104, 501);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(342, 21);
            this.label11.TabIndex = 19;
            this.label11.Text = "Click again on Help button to close this window.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(137, 309);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(377, 168);
            this.label9.TabIndex = 18;
            this.label9.Text = resources.GetString("label9.Text");
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Font = new System.Drawing.Font("Calibri", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(48, 329);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 61);
            this.label8.TabIndex = 17;
            this.label8.Text = "3";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(137, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(388, 84);
            this.label7.TabIndex = 16;
            this.label7.Text = resources.GetString("label7.Text");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("Calibri", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(48, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 61);
            this.label6.TabIndex = 15;
            this.label6.Text = "2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Calibri", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(48, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 61);
            this.label4.TabIndex = 14;
            this.label4.Text = "1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(137, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(390, 84);
            this.label5.TabIndex = 13;
            this.label5.Text = "To start using sShuffler, add desired mp3/wav songs\r\nby simply dragging them to g" +
    "reen bordered box. You\r\ncan drop many songs at once. Added songs will appear\r\nin" +
    " the list. \r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(17, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(519, 42);
            this.label3.TabIndex = 12;
            this.label3.Text = "sShuffler rearranges given songs in order that is properly read by devices \r\ncapa" +
    "ble of playing songs stored on USB flash drives (e.g. in cars). ";
            // 
            // startingPointNum
            // 
            this.startingPointNum.Location = new System.Drawing.Point(338, 480);
            this.startingPointNum.Name = "startingPointNum";
            this.startingPointNum.Size = new System.Drawing.Size(120, 22);
            this.startingPointNum.TabIndex = 12;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(338, 453);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(207, 21);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "unlock manual starting point";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Gadugi", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(351, 508);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 32);
            this.label10.TabIndex = 14;
            this.label10.Text = "only positive \r\ninteger values";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // manStartingPointHelpLabel
            // 
            this.manStartingPointHelpLabel.AutoSize = true;
            this.manStartingPointHelpLabel.Font = new System.Drawing.Font("Gadugi", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manStartingPointHelpLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.manStartingPointHelpLabel.Location = new System.Drawing.Point(525, 453);
            this.manStartingPointHelpLabel.Name = "manStartingPointHelpLabel";
            this.manStartingPointHelpLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.manStartingPointHelpLabel.Size = new System.Drawing.Size(44, 17);
            this.manStartingPointHelpLabel.TabIndex = 15;
            this.manStartingPointHelpLabel.Text = "[Help]";
            this.manStartingPointHelpLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // manualStartingPointPanel
            // 
            this.manualStartingPointPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.manualStartingPointPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.manualStartingPointPanel.Controls.Add(this.label1);
            this.manualStartingPointPanel.Location = new System.Drawing.Point(571, 369);
            this.manualStartingPointPanel.Name = "manualStartingPointPanel";
            this.manualStartingPointPanel.Size = new System.Drawing.Size(326, 100);
            this.manualStartingPointPanel.TabIndex = 16;
            this.manualStartingPointPanel.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(7, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 84);
            this.label1.TabIndex = 19;
            this.label1.Text = "Use this option if you want to set manually\r\nstarting number when for e.g. you ha" +
    "ve\r\nnew songs and you are planning to place\r\nthem at the beginning of the playli" +
    "st.\r\n";
            // 
            // infoBtn
            // 
            this.infoBtn.BackColor = System.Drawing.Color.PaleTurquoise;
            this.infoBtn.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.infoBtn.FlatAppearance.BorderSize = 0;
            this.infoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.infoBtn.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.infoBtn.Location = new System.Drawing.Point(212, -2);
            this.infoBtn.Name = "infoBtn";
            this.infoBtn.Size = new System.Drawing.Size(101, 56);
            this.infoBtn.TabIndex = 17;
            this.infoBtn.Text = "Info";
            this.infoBtn.UseVisualStyleBackColor = false;
            // 
            // infoPanel
            // 
            this.infoPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.infoPanel.Controls.Add(this.pictureBox4);
            this.infoPanel.Controls.Add(this.label12);
            this.infoPanel.Location = new System.Drawing.Point(338, 13);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Size = new System.Drawing.Size(286, 129);
            this.infoPanel.TabIndex = 18;
            this.infoPanel.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(211, 119);
            this.label12.TabIndex = 20;
            this.label12.Text = "sShuffler is open source project\r\nmade using WinForms. Logo is \r\nlicensed under C" +
    "C BY 4.0 and \r\nbelongs to Twitter. For more\r\ndetails see: \r\nhttps://github.com/t" +
    "rolit/sShuffler\r\n\r\n";
            // 
            // loadingGif
            // 
            this.loadingGif.Image = global::sShuffler.Properties.Resources.spin;
            this.loadingGif.Location = new System.Drawing.Point(234, 144);
            this.loadingGif.Name = "loadingGif";
            this.loadingGif.Size = new System.Drawing.Size(272, 126);
            this.loadingGif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.loadingGif.TabIndex = 19;
            this.loadingGif.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::sShuffler.Properties.Resources.snake_bgless;
            this.pictureBox4.Location = new System.Drawing.Point(201, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(85, 57);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 19;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::sShuffler.Properties.Resources.snake_bgless;
            this.pictureBox2.Location = new System.Drawing.Point(-75, 419);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(292, 211);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::sShuffler.Properties.Resources.drop;
            this.pictureBox1.Location = new System.Drawing.Point(381, 148);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(243, 196);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // progressPanel
            // 
            this.progressPanel.BackColor = System.Drawing.Color.Beige;
            this.progressPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.progressPanel.Controls.Add(this.progressBar1);
            this.progressPanel.Controls.Add(this.pictureBox3);
            this.progressPanel.Controls.Add(this.label15);
            this.progressPanel.Controls.Add(this.label13);
            this.progressPanel.Controls.Add(this.loadingGif);
            this.progressPanel.Location = new System.Drawing.Point(244, 48);
            this.progressPanel.Name = "progressPanel";
            this.progressPanel.Size = new System.Drawing.Size(720, 442);
            this.progressPanel.TabIndex = 20;
            this.progressPanel.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Courier New", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.Location = new System.Drawing.Point(261, 67);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(234, 42);
            this.label13.TabIndex = 20;
            this.label13.Text = "Shuffling";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label15.Location = new System.Drawing.Point(275, 298);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(208, 27);
            this.label15.TabIndex = 22;
            this.label15.Text = "Please, wait..";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::sShuffler.Properties.Resources.snake_bgless;
            this.pictureBox3.Location = new System.Drawing.Point(539, 259);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(227, 206);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 23;
            this.pictureBox3.TabStop = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(234, 352);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(272, 23);
            this.progressBar1.TabIndex = 24;
            this.progressBar1.Value = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1182, 553);
            this.Controls.Add(this.progressPanel);
            this.Controls.Add(this.infoPanel);
            this.Controls.Add(this.infoBtn);
            this.Controls.Add(this.manualStartingPointPanel);
            this.Controls.Add(this.helpPanel);
            this.Controls.Add(this.manStartingPointHelpLabel);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.startingPointNum);
            this.Controls.Add(this.helpBtn);
            this.Controls.Add(this.consoleLog);
            this.Controls.Add(this.totalShuffle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.shuffleBtn);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.sShuffler);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listView_files);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "sShuffler - automated random arrangement";
            this.helpPanel.ResumeLayout(false);
            this.helpPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.startingPointNum)).EndInit();
            this.manualStartingPointPanel.ResumeLayout(false);
            this.manualStartingPointPanel.PerformLayout();
            this.infoPanel.ResumeLayout(false);
            this.infoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loadingGif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.progressPanel.ResumeLayout(false);
            this.progressPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView_files;
        private System.Windows.Forms.ColumnHeader chTitle;
        private System.Windows.Forms.ColumnHeader chSize;
        private System.Windows.Forms.ColumnHeader chExtension;
        private System.Windows.Forms.Label sShuffler;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button shuffleBtn;
        private System.Windows.Forms.Label totalShuffle;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.RichTextBox consoleLog;
        private System.Windows.Forms.Button helpBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown startingPointNum;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label manStartingPointHelpLabel;
        private System.Windows.Forms.Panel helpPanel;
        private System.Windows.Forms.Panel manualStartingPointPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button infoBtn;
        private System.Windows.Forms.Panel infoPanel;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox loadingGif;
        private System.Windows.Forms.Panel progressPanel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

