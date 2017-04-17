namespace Gonki
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pause_button = new System.Windows.Forms.Button();
            this.start_button = new System.Windows.Forms.Button();
            this.stop_button = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.thirdbutton = new Gonki.Button_Compare();
            this.secondbutton = new Gonki.Button_Compare();
            this.firstbutton = new Gonki.Button_Compare();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pause_button
            // 
            this.pause_button.Enabled = false;
            this.pause_button.Location = new System.Drawing.Point(139, 43);
            this.pause_button.Name = "pause_button";
            this.pause_button.Size = new System.Drawing.Size(75, 23);
            this.pause_button.TabIndex = 3;
            this.pause_button.Text = "PAUSE";
            this.pause_button.UseVisualStyleBackColor = true;
            this.pause_button.Click += new System.EventHandler(this.pause_button_Click);
            // 
            // start_button
            // 
            this.start_button.Location = new System.Drawing.Point(58, 43);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(75, 23);
            this.start_button.TabIndex = 4;
            this.start_button.Text = "START";
            this.start_button.UseVisualStyleBackColor = true;
            this.start_button.Click += new System.EventHandler(this.start_button_Click);
            // 
            // stop_button
            // 
            this.stop_button.Enabled = false;
            this.stop_button.Location = new System.Drawing.Point(220, 43);
            this.stop_button.Name = "stop_button";
            this.stop_button.Size = new System.Drawing.Size(75, 23);
            this.stop_button.TabIndex = 5;
            this.stop_button.Text = "STOP";
            this.stop_button.UseVisualStyleBackColor = true;
            this.stop_button.Click += new System.EventHandler(this.stop_button_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pause_button);
            this.groupBox1.Controls.Add(this.stop_button);
            this.groupBox1.Controls.Add(this.start_button);
            this.groupBox1.Location = new System.Drawing.Point(12, 336);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(377, 100);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Gonki.Properties.Resources.finish;
            this.pictureBox1.Location = new System.Drawing.Point(344, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 241);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // thirdbutton
            // 
            this.thirdbutton.Image = ((System.Drawing.Image)(resources.GetObject("thirdbutton.Image")));
            this.thirdbutton.Location = new System.Drawing.Point(12, 35);
            this.thirdbutton.Name = "thirdbutton";
            this.thirdbutton.Size = new System.Drawing.Size(97, 62);
            this.thirdbutton.TabIndex = 2;
            this.thirdbutton.UseVisualStyleBackColor = true;
            // 
            // secondbutton
            // 
            this.secondbutton.Image = ((System.Drawing.Image)(resources.GetObject("secondbutton.Image")));
            this.secondbutton.Location = new System.Drawing.Point(12, 103);
            this.secondbutton.Name = "secondbutton";
            this.secondbutton.Size = new System.Drawing.Size(97, 62);
            this.secondbutton.TabIndex = 1;
            this.secondbutton.UseVisualStyleBackColor = true;
            // 
            // firstbutton
            // 
            this.firstbutton.Image = ((System.Drawing.Image)(resources.GetObject("firstbutton.Image")));
            this.firstbutton.Location = new System.Drawing.Point(12, 171);
            this.firstbutton.Name = "firstbutton";
            this.firstbutton.Size = new System.Drawing.Size(97, 62);
            this.firstbutton.TabIndex = 0;
            this.firstbutton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(426, 448);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.thirdbutton);
            this.Controls.Add(this.secondbutton);
            this.Controls.Add(this.firstbutton);
            this.Name = "Form1";
            this.Text = "NeedForGonochki";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button_Compare firstbutton;
        private Button_Compare secondbutton;
        private Button_Compare thirdbutton;


        private System.Windows.Forms.Button pause_button;
        private System.Windows.Forms.Button start_button;
        private System.Windows.Forms.Button stop_button;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

