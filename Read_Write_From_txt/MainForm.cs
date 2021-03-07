using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Read_Write_From_txt
{
    public partial class MainForm : Form
    {
        string path = @"../../file1.txt";
        public MainForm()
        {
            InitializeComponent();
        }
        private void add_team_Click(object sender, EventArgs e)
        {
            string name = input_name.Text;
            decimal wins = input_win.Value;
            decimal lose = input_lose.Value;
            decimal draw = input_draw.Value;
            decimal points = wins * 3 + draw;

            string all = name + ", loses: " + lose + ", draws: " + draw + ", wins: " + wins + ", points: " + points + "\n";
            if (name == "")
            {
                MessageBox.Show("Please add team name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                input_name.Focus();
                return;
            }
            File.AppendAllText(path, all);
            MessageBox.Show("Added to txt file !", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
            input_name.Clear();
            input_win.Value = 0;
            input_lose.Value = 0;
            input_draw.Value = 0;
        }

        private void read_txt_Click(object sender, EventArgs e)
        {
            string output = File.ReadAllText(path);
            print_txt.Text = output;
        }


        private void show_from2_Click(object sender, EventArgs e)
        {
            TeamsWindow form2 = new TeamsWindow();
            form2.Show();
        }

        private void open_file_Click_1(object sender, EventArgs e)
        {
            string file = @"C:\Users\Cyber\source\repos\Read_Write_From_txt\Read_Write_From_txt\file1.txt";
            Process.Start(file);
        }

        private void del_team_Click(object sender, EventArgs e)
        {
            bool flag = false;
            string oldLine;
            string newStr = "";
            StreamReader sr = File.OpenText(path);
            while ((oldLine = sr.ReadLine()) != null)
            {
                if (!oldLine.Contains(inputDel.Text))
                {
                    newStr += oldLine + Environment.NewLine;
                }
                else
                {
                    flag = true;
                }
            }
            sr.Close();
            File.WriteAllText(path, newStr);
            if (flag == false)
            {
                MessageBox.Show("The team is not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                inputDel.Clear();
                return;
            }
            MessageBox.Show("The team deleted", "succses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            inputDel.Clear();

        }

        private void upd_btn_Click(object sender, EventArgs e)
        {
            Update_win update_window = new Update_win();
            update_window.Show();

        }

        private void inputDel_TextChanged(object sender, EventArgs e)
        {
            // no
        }
    }
}
