namespace _2048Game
{
    partial class StartForm
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
            this.Start = new System.Windows.Forms.Button();
            this.alone = new System.Windows.Forms.RadioButton();
            this.link = new System.Windows.Forms.RadioButton();
            this.wait = new System.Windows.Forms.CheckBox();
            this.find = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(141, 253);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(75, 23);
            this.Start.TabIndex = 0;
            this.Start.Text = "开始游戏";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // alone
            // 
            this.alone.AutoSize = true;
            this.alone.Location = new System.Drawing.Point(91, 131);
            this.alone.Name = "alone";
            this.alone.Size = new System.Drawing.Size(71, 16);
            this.alone.TabIndex = 1;
            this.alone.Text = "单机模式";
            this.alone.UseVisualStyleBackColor = true;
            // 
            // link
            // 
            this.link.AutoSize = true;
            this.link.Location = new System.Drawing.Point(188, 131);
            this.link.Name = "link";
            this.link.Size = new System.Drawing.Size(71, 16);
            this.link.TabIndex = 2;
            this.link.Text = "联机模式";
            this.link.UseVisualStyleBackColor = true;
            this.link.CheckedChanged += new System.EventHandler(this.link_CheckedChanged);
            // 
            // wait
            // 
            this.wait.AutoSize = true;
            this.wait.Location = new System.Drawing.Point(122, 177);
            this.wait.Name = "wait";
            this.wait.Size = new System.Drawing.Size(96, 16);
            this.wait.TabIndex = 3;
            this.wait.Text = "等待玩家邀请";
            this.wait.UseVisualStyleBackColor = true;
            // 
            // find
            // 
            this.find.AutoSize = true;
            this.find.Location = new System.Drawing.Point(122, 212);
            this.find.Name = "find";
            this.find.Size = new System.Drawing.Size(96, 16);
            this.find.TabIndex = 4;
            this.find.Text = "邀请附近玩家";
            this.find.UseVisualStyleBackColor = true;
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 384);
            this.Controls.Add(this.find);
            this.Controls.Add(this.wait);
            this.Controls.Add(this.link);
            this.Controls.Add(this.alone);
            this.Controls.Add(this.Start);
            this.Name = "StartForm";
            this.Text = "StartForm";
            this.Load += new System.EventHandler(this.StartForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.RadioButton alone;
        private System.Windows.Forms.RadioButton link;
        private System.Windows.Forms.CheckBox wait;
        private System.Windows.Forms.CheckBox find;
    }
}