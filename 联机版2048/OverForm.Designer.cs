namespace _2048Game
{
    partial class OverForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.lbl_socre = new System.Windows.Forms.Label();
            this.pb_gameover = new System.Windows.Forms.PictureBox();
            this.pb_restart = new System.Windows.Forms.PictureBox();
            this.lbl_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_gameover)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_restart)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_socre
            // 
            this.lbl_socre.AutoSize = true;
            this.lbl_socre.BackColor = System.Drawing.Color.Transparent;
            this.lbl_socre.Font = new System.Drawing.Font("宋体", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_socre.Location = new System.Drawing.Point(223, 221);
            this.lbl_socre.Name = "lbl_socre";
            this.lbl_socre.Size = new System.Drawing.Size(44, 48);
            this.lbl_socre.TabIndex = 0;
            this.lbl_socre.Text = "0";
            this.lbl_socre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pb_gameover
            // 
            this.pb_gameover.BackColor = System.Drawing.Color.Transparent;
            this.pb_gameover.Image = global::_2048Game.Resource.over;
            this.pb_gameover.Location = new System.Drawing.Point(74, 12);
            this.pb_gameover.Name = "pb_gameover";
            this.pb_gameover.Size = new System.Drawing.Size(248, 138);
            this.pb_gameover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_gameover.TabIndex = 1;
            this.pb_gameover.TabStop = false;
            // 
            // pb_restart
            // 
            this.pb_restart.BackColor = System.Drawing.Color.Transparent;
            this.pb_restart.Image = global::_2048Game.Resource.start1;
            this.pb_restart.Location = new System.Drawing.Point(140, 304);
            this.pb_restart.Name = "pb_restart";
            this.pb_restart.Size = new System.Drawing.Size(113, 79);
            this.pb_restart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_restart.TabIndex = 1;
            this.pb_restart.TabStop = false;
            this.pb_restart.Click += new System.EventHandler(this.OverForm_Click);
            this.pb_restart.MouseLeave += new System.EventHandler(this.OverForm_MouseLeave);
            this.pb_restart.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OverForm_MouseMove);
            // 
            // lbl_name
            // 
            this.lbl_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(173)))), ((int)(((byte)(160)))));
            this.lbl_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbl_name.Font = new System.Drawing.Font("宋体", 24F);
            this.lbl_name.Location = new System.Drawing.Point(176, 181);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(137, 37);
            this.lbl_name.TabIndex = 10;
            this.lbl_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 24F);
            this.label2.Location = new System.Drawing.Point(80, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 33);
            this.label2.TabIndex = 9;
            this.label2.Text = "成绩：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 24F);
            this.label1.Location = new System.Drawing.Point(80, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 33);
            this.label1.TabIndex = 8;
            this.label1.Text = "姓名：";
            // 
            // OverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(173)))), ((int)(((byte)(160)))));
            this.ClientSize = new System.Drawing.Size(388, 412);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pb_gameover);
            this.Controls.Add(this.pb_restart);
            this.Controls.Add(this.lbl_socre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "OverForm";
            this.Opacity = 0.9D;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pb_gameover)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_restart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_socre;
        private System.Windows.Forms.PictureBox pb_restart;
        private System.Windows.Forms.PictureBox pb_gameover;
        private System.Windows.Forms.TextBox lbl_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}