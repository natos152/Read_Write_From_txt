
namespace Read_Write_From_txt
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.input_name = new System.Windows.Forms.TextBox();
            this.add_team = new System.Windows.Forms.Button();
            this.print_txt = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.read_txt = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.show_from2 = new System.Windows.Forms.Button();
            this.input_win = new System.Windows.Forms.NumericUpDown();
            this.input_lose = new System.Windows.Forms.NumericUpDown();
            this.input_draw = new System.Windows.Forms.NumericUpDown();
            this.open_file = new System.Windows.Forms.Button();
            this.del_team = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.inputDel = new System.Windows.Forms.TextBox();
            this.upd_btn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.input_win)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.input_lose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.input_draw)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(22, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Team Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(22, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Wins :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(22, 124);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Loses :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Location = new System.Drawing.Point(22, 167);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Draw :";
            // 
            // input_name
            // 
            this.input_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.input_name.Location = new System.Drawing.Point(160, 53);
            this.input_name.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.input_name.Name = "input_name";
            this.input_name.Size = new System.Drawing.Size(174, 28);
            this.input_name.TabIndex = 4;
            // 
            // add_team
            // 
            this.add_team.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.add_team.Location = new System.Drawing.Point(201, 210);
            this.add_team.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.add_team.Name = "add_team";
            this.add_team.Size = new System.Drawing.Size(147, 28);
            this.add_team.TabIndex = 8;
            this.add_team.Text = "Add to txt file";
            this.add_team.UseVisualStyleBackColor = true;
            this.add_team.Click += new System.EventHandler(this.add_team_Click);
            // 
            // print_txt
            // 
            this.print_txt.AutoSize = true;
            this.print_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.print_txt.Location = new System.Drawing.Point(473, 61);
            this.print_txt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.print_txt.Name = "print_txt";
            this.print_txt.Size = new System.Drawing.Size(0, 20);
            this.print_txt.TabIndex = 9;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.dateTimePicker1.Location = new System.Drawing.Point(710, 9);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(263, 28);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // read_txt
            // 
            this.read_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.read_txt.Location = new System.Drawing.Point(22, 210);
            this.read_txt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.read_txt.Name = "read_txt";
            this.read_txt.Size = new System.Drawing.Size(164, 28);
            this.read_txt.TabIndex = 11;
            this.read_txt.Text = "Read from txt file";
            this.read_txt.UseVisualStyleBackColor = true;
            this.read_txt.Click += new System.EventHandler(this.read_txt_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.Location = new System.Drawing.Point(22, 7);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(375, 31);
            this.label5.TabIndex = 12;
            this.label5.Text = "Read and Write by Text File";
            // 
            // show_from2
            // 
            this.show_from2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.show_from2.Location = new System.Drawing.Point(490, 6);
            this.show_from2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.show_from2.Name = "show_from2";
            this.show_from2.Size = new System.Drawing.Size(215, 32);
            this.show_from2.TabIndex = 13;
            this.show_from2.Text = "Show file text content";
            this.show_from2.UseVisualStyleBackColor = false;
            this.show_from2.Click += new System.EventHandler(this.show_from2_Click);
            // 
            // input_win
            // 
            this.input_win.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.input_win.Location = new System.Drawing.Point(160, 93);
            this.input_win.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.input_win.Name = "input_win";
            this.input_win.Size = new System.Drawing.Size(122, 26);
            this.input_win.TabIndex = 14;
            // 
            // input_lose
            // 
            this.input_lose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.input_lose.Location = new System.Drawing.Point(162, 129);
            this.input_lose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.input_lose.Name = "input_lose";
            this.input_lose.Size = new System.Drawing.Size(119, 26);
            this.input_lose.TabIndex = 15;
            // 
            // input_draw
            // 
            this.input_draw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.input_draw.Location = new System.Drawing.Point(162, 167);
            this.input_draw.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.input_draw.Name = "input_draw";
            this.input_draw.Size = new System.Drawing.Size(119, 26);
            this.input_draw.TabIndex = 16;
            // 
            // open_file
            // 
            this.open_file.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.open_file.Location = new System.Drawing.Point(22, 258);
            this.open_file.Name = "open_file";
            this.open_file.Size = new System.Drawing.Size(164, 28);
            this.open_file.TabIndex = 17;
            this.open_file.Text = "Open File text";
            this.open_file.UseVisualStyleBackColor = true;
            this.open_file.Click += new System.EventHandler(this.open_file_Click_1);
            // 
            // del_team
            // 
            this.del_team.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.del_team.Location = new System.Drawing.Point(428, 301);
            this.del_team.Name = "del_team";
            this.del_team.Size = new System.Drawing.Size(118, 27);
            this.del_team.TabIndex = 18;
            this.del_team.Text = "delete";
            this.del_team.UseVisualStyleBackColor = true;
            this.del_team.Click += new System.EventHandler(this.del_team_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(22, 303);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(272, 24);
            this.label6.TabIndex = 19;
            this.label6.Text = "Write the name of the team: ";
            // 
            // inputDel
            // 
            this.inputDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.inputDel.Location = new System.Drawing.Point(299, 301);
            this.inputDel.Name = "inputDel";
            this.inputDel.Size = new System.Drawing.Size(116, 28);
            this.inputDel.TabIndex = 20;
            this.inputDel.TextChanged += new System.EventHandler(this.inputDel_TextChanged);
            // 
            // upd_btn
            // 
            this.upd_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.upd_btn.Location = new System.Drawing.Point(314, 344);
            this.upd_btn.Name = "upd_btn";
            this.upd_btn.Size = new System.Drawing.Size(169, 30);
            this.upd_btn.TabIndex = 21;
            this.upd_btn.Text = "Update Window";
            this.upd_btn.UseVisualStyleBackColor = true;
            this.upd_btn.Click += new System.EventHandler(this.upd_btn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(22, 350);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(285, 24);
            this.label7.TabIndex = 22;
            this.label7.Text = "To update team click here -->";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 470);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.upd_btn);
            this.Controls.Add(this.inputDel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.del_team);
            this.Controls.Add(this.open_file);
            this.Controls.Add(this.input_draw);
            this.Controls.Add(this.input_lose);
            this.Controls.Add(this.input_win);
            this.Controls.Add(this.show_from2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.read_txt);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.print_txt);
            this.Controls.Add(this.add_team);
            this.Controls.Add(this.input_name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Read And Write Program";
            ((System.ComponentModel.ISupportInitialize)(this.input_win)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.input_lose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.input_draw)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox input_name;
        private System.Windows.Forms.Button add_team;
        private System.Windows.Forms.Label print_txt;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button read_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button show_from2;
        private System.Windows.Forms.NumericUpDown input_win;
        private System.Windows.Forms.NumericUpDown input_lose;
        private System.Windows.Forms.NumericUpDown input_draw;
        private System.Windows.Forms.Button open_file;
        private System.Windows.Forms.Button del_team;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox inputDel;
        private System.Windows.Forms.Button upd_btn;
        private System.Windows.Forms.Label label7;
    }
}

