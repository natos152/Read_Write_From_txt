
namespace Read_Write_From_txt
{
    partial class Update_win
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
            this.updateBtn = new System.Windows.Forms.Button();
            this.input_draw = new System.Windows.Forms.NumericUpDown();
            this.input_lose = new System.Windows.Forms.NumericUpDown();
            this.input_win = new System.Windows.Forms.NumericUpDown();
            this.input_name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.updateTeam = new System.Windows.Forms.TextBox();
            this.main_btn = new System.Windows.Forms.Button();
            this.open_file_txt = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.input_draw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.input_lose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.input_win)).BeginInit();
            this.SuspendLayout();
            // 
            // updateBtn
            // 
            this.updateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.updateBtn.Location = new System.Drawing.Point(214, 325);
            this.updateBtn.Margin = new System.Windows.Forms.Padding(4);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(137, 39);
            this.updateBtn.TabIndex = 0;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // input_draw
            // 
            this.input_draw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.input_draw.Location = new System.Drawing.Point(251, 272);
            this.input_draw.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.input_draw.Name = "input_draw";
            this.input_draw.Size = new System.Drawing.Size(157, 30);
            this.input_draw.TabIndex = 24;
            // 
            // input_lose
            // 
            this.input_lose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.input_lose.Location = new System.Drawing.Point(251, 225);
            this.input_lose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.input_lose.Name = "input_lose";
            this.input_lose.Size = new System.Drawing.Size(157, 30);
            this.input_lose.TabIndex = 23;
            // 
            // input_win
            // 
            this.input_win.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.input_win.Location = new System.Drawing.Point(248, 181);
            this.input_win.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.input_win.Name = "input_win";
            this.input_win.Size = new System.Drawing.Size(160, 30);
            this.input_win.TabIndex = 22;
            // 
            // input_name
            // 
            this.input_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.input_name.Location = new System.Drawing.Point(248, 133);
            this.input_name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.input_name.Name = "input_name";
            this.input_name.Size = new System.Drawing.Size(217, 34);
            this.input_name.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Location = new System.Drawing.Point(69, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 29);
            this.label4.TabIndex = 20;
            this.label4.Text = "Draw :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(69, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 29);
            this.label3.TabIndex = 19;
            this.label3.Text = "Loses :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(69, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 29);
            this.label2.TabIndex = 18;
            this.label2.Text = "Wins :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(69, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 29);
            this.label1.TabIndex = 17;
            this.label1.Text = "Team Name :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.Location = new System.Drawing.Point(15, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(259, 29);
            this.label5.TabIndex = 25;
            this.label5.Text = "Update Team Details";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label6.Location = new System.Drawing.Point(55, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(353, 29);
            this.label6.TabIndex = 26;
            this.label6.Text = "Write the team name  to edit :";
            // 
            // updateTeam
            // 
            this.updateTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.updateTeam.Location = new System.Drawing.Point(417, 57);
            this.updateTeam.Margin = new System.Windows.Forms.Padding(4);
            this.updateTeam.Multiline = true;
            this.updateTeam.Name = "updateTeam";
            this.updateTeam.Size = new System.Drawing.Size(196, 34);
            this.updateTeam.TabIndex = 27;
            this.updateTeam.TextChanged += new System.EventHandler(this.updateTeam_TextChanged);
            // 
            // main_btn
            // 
            this.main_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.main_btn.Location = new System.Drawing.Point(861, 13);
            this.main_btn.Margin = new System.Windows.Forms.Padding(4);
            this.main_btn.Name = "main_btn";
            this.main_btn.Size = new System.Drawing.Size(193, 42);
            this.main_btn.TabIndex = 28;
            this.main_btn.Text = "Main Window";
            this.main_btn.UseVisualStyleBackColor = true;
            this.main_btn.Click += new System.EventHandler(this.main_btn_Click);
            // 
            // open_file_txt
            // 
            this.open_file_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.open_file_txt.Location = new System.Drawing.Point(375, 325);
            this.open_file_txt.Name = "open_file_txt";
            this.open_file_txt.Size = new System.Drawing.Size(162, 39);
            this.open_file_txt.TabIndex = 29;
            this.open_file_txt.Text = "Open File";
            this.open_file_txt.UseVisualStyleBackColor = true;
            this.open_file_txt.Click += new System.EventHandler(this.open_file_txt_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label7.Location = new System.Drawing.Point(56, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(900, 24);
            this.label7.TabIndex = 30;
            this.label7.Text = "For Update Team name please fill only team name , To Wins/Loses/Draws please fill" +
    " all of them.";
            // 
            // Update_win
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.open_file_txt);
            this.Controls.Add(this.main_btn);
            this.Controls.Add(this.updateTeam);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.input_draw);
            this.Controls.Add(this.input_lose);
            this.Controls.Add(this.input_win);
            this.Controls.Add(this.input_name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.updateBtn);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Update_win";
            this.Text = "Update_win";
            ((System.ComponentModel.ISupportInitialize)(this.input_draw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.input_lose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.input_win)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.NumericUpDown input_draw;
        private System.Windows.Forms.NumericUpDown input_lose;
        private System.Windows.Forms.NumericUpDown input_win;
        private System.Windows.Forms.TextBox input_name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox updateTeam;
        private System.Windows.Forms.Button main_btn;
        private System.Windows.Forms.Button open_file_txt;
        private System.Windows.Forms.Label label7;
    }
}