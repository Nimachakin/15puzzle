namespace _15_puzzle
{
    partial class FifteenPuzzle
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.numPanel = new System.Windows.Forms.Panel();
            this.empty_picbox = new System.Windows.Forms.PictureBox();
            this.fifteen_picbox = new System.Windows.Forms.PictureBox();
            this.fourteen_picbox = new System.Windows.Forms.PictureBox();
            this.thirteen_picbox = new System.Windows.Forms.PictureBox();
            this.twelve_picbox = new System.Windows.Forms.PictureBox();
            this.eleven_picbox = new System.Windows.Forms.PictureBox();
            this.ten_picbox = new System.Windows.Forms.PictureBox();
            this.nine_picbox = new System.Windows.Forms.PictureBox();
            this.eight_picbox = new System.Windows.Forms.PictureBox();
            this.seven_picbox = new System.Windows.Forms.PictureBox();
            this.six_picbox = new System.Windows.Forms.PictureBox();
            this.five_picbox = new System.Windows.Forms.PictureBox();
            this.four_picbox = new System.Windows.Forms.PictureBox();
            this.three_picbox = new System.Windows.Forms.PictureBox();
            this.two_picbox = new System.Windows.Forms.PictureBox();
            this.one_picbox = new System.Windows.Forms.PictureBox();
            this.newGame_btn = new System.Windows.Forms.Button();
            this.timeCounter = new System.Windows.Forms.Timer(this.components);
            this.clock_lbl = new System.Windows.Forms.Label();
            this.time_lbl = new System.Windows.Forms.Label();
            this.numPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empty_picbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fifteen_picbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fourteen_picbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thirteen_picbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.twelve_picbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eleven_picbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ten_picbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nine_picbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eight_picbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seven_picbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.six_picbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.five_picbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.four_picbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.three_picbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.two_picbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.one_picbox)).BeginInit();
            this.SuspendLayout();
            // 
            // numPanel
            // 
            this.numPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numPanel.Controls.Add(this.empty_picbox);
            this.numPanel.Controls.Add(this.fifteen_picbox);
            this.numPanel.Controls.Add(this.fourteen_picbox);
            this.numPanel.Controls.Add(this.thirteen_picbox);
            this.numPanel.Controls.Add(this.twelve_picbox);
            this.numPanel.Controls.Add(this.eleven_picbox);
            this.numPanel.Controls.Add(this.ten_picbox);
            this.numPanel.Controls.Add(this.nine_picbox);
            this.numPanel.Controls.Add(this.eight_picbox);
            this.numPanel.Controls.Add(this.seven_picbox);
            this.numPanel.Controls.Add(this.six_picbox);
            this.numPanel.Controls.Add(this.five_picbox);
            this.numPanel.Controls.Add(this.four_picbox);
            this.numPanel.Controls.Add(this.three_picbox);
            this.numPanel.Controls.Add(this.two_picbox);
            this.numPanel.Controls.Add(this.one_picbox);
            this.numPanel.Location = new System.Drawing.Point(12, 12);
            this.numPanel.Name = "numPanel";
            this.numPanel.Size = new System.Drawing.Size(226, 226);
            this.numPanel.TabIndex = 0;
            // 
            // empty_picbox
            // 
            this.empty_picbox.Location = new System.Drawing.Point(171, 171);
            this.empty_picbox.Name = "empty_picbox";
            this.empty_picbox.Size = new System.Drawing.Size(50, 50);
            this.empty_picbox.TabIndex = 3;
            this.empty_picbox.TabStop = false;
            // 
            // fifteen_picbox
            // 
            this.fifteen_picbox.Image = global::_15_puzzle.Properties.Resources.fifteen;
            this.fifteen_picbox.Location = new System.Drawing.Point(115, 171);
            this.fifteen_picbox.Name = "fifteen_picbox";
            this.fifteen_picbox.Size = new System.Drawing.Size(50, 50);
            this.fifteen_picbox.TabIndex = 29;
            this.fifteen_picbox.TabStop = false;
            this.fifteen_picbox.Click += new System.EventHandler(this.fifteen_picbox_Click);
            // 
            // fourteen_picbox
            // 
            this.fourteen_picbox.Image = global::_15_puzzle.Properties.Resources.fourteen;
            this.fourteen_picbox.Location = new System.Drawing.Point(59, 171);
            this.fourteen_picbox.Name = "fourteen_picbox";
            this.fourteen_picbox.Size = new System.Drawing.Size(50, 50);
            this.fourteen_picbox.TabIndex = 28;
            this.fourteen_picbox.TabStop = false;
            this.fourteen_picbox.Click += new System.EventHandler(this.fourteen_picbox_Click);
            // 
            // thirteen_picbox
            // 
            this.thirteen_picbox.Image = global::_15_puzzle.Properties.Resources.thirteen;
            this.thirteen_picbox.Location = new System.Drawing.Point(3, 171);
            this.thirteen_picbox.Name = "thirteen_picbox";
            this.thirteen_picbox.Size = new System.Drawing.Size(50, 50);
            this.thirteen_picbox.TabIndex = 27;
            this.thirteen_picbox.TabStop = false;
            this.thirteen_picbox.Click += new System.EventHandler(this.thirteen_picbox_Click);
            // 
            // twelve_picbox
            // 
            this.twelve_picbox.Image = global::_15_puzzle.Properties.Resources.twelve;
            this.twelve_picbox.Location = new System.Drawing.Point(171, 115);
            this.twelve_picbox.Name = "twelve_picbox";
            this.twelve_picbox.Size = new System.Drawing.Size(50, 50);
            this.twelve_picbox.TabIndex = 26;
            this.twelve_picbox.TabStop = false;
            this.twelve_picbox.Click += new System.EventHandler(this.twelve_picbox_Click);
            // 
            // eleven_picbox
            // 
            this.eleven_picbox.Image = global::_15_puzzle.Properties.Resources.eleven;
            this.eleven_picbox.Location = new System.Drawing.Point(115, 115);
            this.eleven_picbox.Name = "eleven_picbox";
            this.eleven_picbox.Size = new System.Drawing.Size(50, 50);
            this.eleven_picbox.TabIndex = 25;
            this.eleven_picbox.TabStop = false;
            this.eleven_picbox.Click += new System.EventHandler(this.eleven_picbox_Click);
            // 
            // ten_picbox
            // 
            this.ten_picbox.Image = global::_15_puzzle.Properties.Resources.ten;
            this.ten_picbox.Location = new System.Drawing.Point(59, 115);
            this.ten_picbox.Name = "ten_picbox";
            this.ten_picbox.Size = new System.Drawing.Size(50, 50);
            this.ten_picbox.TabIndex = 24;
            this.ten_picbox.TabStop = false;
            this.ten_picbox.Click += new System.EventHandler(this.ten_picbox_Click);
            // 
            // nine_picbox
            // 
            this.nine_picbox.Image = global::_15_puzzle.Properties.Resources.nine;
            this.nine_picbox.Location = new System.Drawing.Point(3, 115);
            this.nine_picbox.Name = "nine_picbox";
            this.nine_picbox.Size = new System.Drawing.Size(50, 50);
            this.nine_picbox.TabIndex = 23;
            this.nine_picbox.TabStop = false;
            this.nine_picbox.Click += new System.EventHandler(this.nine_picbox_Click);
            // 
            // eight_picbox
            // 
            this.eight_picbox.Image = global::_15_puzzle.Properties.Resources.eight;
            this.eight_picbox.Location = new System.Drawing.Point(171, 59);
            this.eight_picbox.Name = "eight_picbox";
            this.eight_picbox.Size = new System.Drawing.Size(50, 50);
            this.eight_picbox.TabIndex = 22;
            this.eight_picbox.TabStop = false;
            this.eight_picbox.Click += new System.EventHandler(this.eight_picbox_Click);
            // 
            // seven_picbox
            // 
            this.seven_picbox.Image = global::_15_puzzle.Properties.Resources.seven;
            this.seven_picbox.Location = new System.Drawing.Point(115, 59);
            this.seven_picbox.Name = "seven_picbox";
            this.seven_picbox.Size = new System.Drawing.Size(50, 50);
            this.seven_picbox.TabIndex = 21;
            this.seven_picbox.TabStop = false;
            this.seven_picbox.Click += new System.EventHandler(this.seven_picbox_Click);
            // 
            // six_picbox
            // 
            this.six_picbox.Image = global::_15_puzzle.Properties.Resources.six;
            this.six_picbox.Location = new System.Drawing.Point(59, 59);
            this.six_picbox.Name = "six_picbox";
            this.six_picbox.Size = new System.Drawing.Size(50, 50);
            this.six_picbox.TabIndex = 20;
            this.six_picbox.TabStop = false;
            this.six_picbox.Click += new System.EventHandler(this.six_picbox_Click);
            // 
            // five_picbox
            // 
            this.five_picbox.Image = global::_15_puzzle.Properties.Resources.five;
            this.five_picbox.Location = new System.Drawing.Point(3, 59);
            this.five_picbox.Name = "five_picbox";
            this.five_picbox.Size = new System.Drawing.Size(50, 50);
            this.five_picbox.TabIndex = 19;
            this.five_picbox.TabStop = false;
            this.five_picbox.Click += new System.EventHandler(this.five_picbox_Click);
            // 
            // four_picbox
            // 
            this.four_picbox.Image = global::_15_puzzle.Properties.Resources.four;
            this.four_picbox.Location = new System.Drawing.Point(171, 3);
            this.four_picbox.Name = "four_picbox";
            this.four_picbox.Size = new System.Drawing.Size(50, 50);
            this.four_picbox.TabIndex = 18;
            this.four_picbox.TabStop = false;
            this.four_picbox.Click += new System.EventHandler(this.four_picbox_Click);
            // 
            // three_picbox
            // 
            this.three_picbox.Image = global::_15_puzzle.Properties.Resources.three;
            this.three_picbox.Location = new System.Drawing.Point(115, 3);
            this.three_picbox.Name = "three_picbox";
            this.three_picbox.Size = new System.Drawing.Size(50, 50);
            this.three_picbox.TabIndex = 17;
            this.three_picbox.TabStop = false;
            this.three_picbox.Click += new System.EventHandler(this.three_picbox_Click);
            // 
            // two_picbox
            // 
            this.two_picbox.Image = global::_15_puzzle.Properties.Resources.two;
            this.two_picbox.Location = new System.Drawing.Point(59, 3);
            this.two_picbox.Name = "two_picbox";
            this.two_picbox.Size = new System.Drawing.Size(50, 50);
            this.two_picbox.TabIndex = 16;
            this.two_picbox.TabStop = false;
            this.two_picbox.Click += new System.EventHandler(this.two_picbox_Click);
            // 
            // one_picbox
            // 
            this.one_picbox.Image = global::_15_puzzle.Properties.Resources.one;
            this.one_picbox.Location = new System.Drawing.Point(3, 3);
            this.one_picbox.Name = "one_picbox";
            this.one_picbox.Size = new System.Drawing.Size(50, 50);
            this.one_picbox.TabIndex = 15;
            this.one_picbox.TabStop = false;
            this.one_picbox.Click += new System.EventHandler(this.one_picbox_Click);
            // 
            // newGame_btn
            // 
            this.newGame_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.newGame_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newGame_btn.Location = new System.Drawing.Point(244, 16);
            this.newGame_btn.Name = "newGame_btn";
            this.newGame_btn.Size = new System.Drawing.Size(127, 50);
            this.newGame_btn.TabIndex = 1;
            this.newGame_btn.Text = "Start";
            this.newGame_btn.UseVisualStyleBackColor = false;
            this.newGame_btn.Click += new System.EventHandler(this.newGame_btn_Click);
            // 
            // timeCounter
            // 
            this.timeCounter.Tick += new System.EventHandler(this.timeCounter_Tick);
            // 
            // clock_lbl
            // 
            this.clock_lbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clock_lbl.Location = new System.Drawing.Point(244, 128);
            this.clock_lbl.Name = "clock_lbl";
            this.clock_lbl.Size = new System.Drawing.Size(127, 23);
            this.clock_lbl.TabIndex = 2;
            this.clock_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // time_lbl
            // 
            this.time_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.time_lbl.Location = new System.Drawing.Point(245, 93);
            this.time_lbl.Name = "time_lbl";
            this.time_lbl.Size = new System.Drawing.Size(126, 29);
            this.time_lbl.TabIndex = 3;
            this.time_lbl.Text = "Time";
            this.time_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FifteenPuzzle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 247);
            this.Controls.Add(this.time_lbl);
            this.Controls.Add(this.clock_lbl);
            this.Controls.Add(this.newGame_btn);
            this.Controls.Add(this.numPanel);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(395, 285);
            this.MinimumSize = new System.Drawing.Size(395, 285);
            this.Name = "FifteenPuzzle";
            this.Text = "15 Puzzle v0.89 :)";
            this.numPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.empty_picbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fifteen_picbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fourteen_picbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thirteen_picbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.twelve_picbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eleven_picbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ten_picbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nine_picbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eight_picbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seven_picbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.six_picbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.five_picbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.four_picbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.three_picbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.two_picbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.one_picbox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel numPanel;
        private System.Windows.Forms.Button newGame_btn;
        private System.Windows.Forms.PictureBox fifteen_picbox;
        private System.Windows.Forms.PictureBox fourteen_picbox;
        private System.Windows.Forms.PictureBox thirteen_picbox;
        private System.Windows.Forms.PictureBox twelve_picbox;
        private System.Windows.Forms.PictureBox eleven_picbox;
        private System.Windows.Forms.PictureBox ten_picbox;
        private System.Windows.Forms.PictureBox nine_picbox;
        private System.Windows.Forms.PictureBox eight_picbox;
        private System.Windows.Forms.PictureBox seven_picbox;
        private System.Windows.Forms.PictureBox six_picbox;
        private System.Windows.Forms.PictureBox five_picbox;
        private System.Windows.Forms.PictureBox four_picbox;
        private System.Windows.Forms.PictureBox three_picbox;
        private System.Windows.Forms.PictureBox two_picbox;
        private System.Windows.Forms.PictureBox one_picbox;
        private System.Windows.Forms.PictureBox empty_picbox;
        private System.Windows.Forms.Timer timeCounter;
        private System.Windows.Forms.Label clock_lbl;
        private System.Windows.Forms.Label time_lbl;
    }
}

