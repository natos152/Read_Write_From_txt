using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Read_Write_From_txt
{
    public partial class Update_win : Form
    {
        string path = @"../../file1.txt";
        MainForm main_window = new MainForm();

        public Update_win()
        {
            InitializeComponent();
        }

        private void updateTeam_TextChanged(object sender, EventArgs e)
        {

        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            string editTeam = updateTeam.Text;
            string name = input_name.Text;
            decimal wins = input_win.Value;
            decimal lose = input_lose.Value;
            decimal draw = input_draw.Value;
            decimal points = wins * 3 + draw;
            bool flag = false;
            bool checkName = false;
            string oldLine;
            string newStr = "";
            StreamReader sr = File.OpenText(path);
            while ((oldLine = sr.ReadLine()) != null)
            {
                if (updateTeam.Text == "")
                {
                    MessageBox.Show("Please cheack your team name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (oldLine.Contains(updateTeam.Text))
                {
                    checkName = true;
                }
                if (!oldLine.Contains(updateTeam.Text))
                {
                    newStr += oldLine + Environment.NewLine;
                }
                else
                {
                    if (name == "" && wins == 0 && draw == 0 && lose == 0)
                    {
                        newStr += oldLine + Environment.NewLine;
                    }
                    else if (name == "" && wins != 0 && draw != 0 && lose != 0)
                    {
                        newStr += editTeam + ", loses: " + lose + ", draws: " + draw + ", wins: " + wins + ", points: " + points + Environment.NewLine;
                        flag = true;
                    }
                    else if (name != "" && wins == 0 && draw == 0 && lose == 0)
                    {
                        newStr += name + oldLine.Substring(updateTeam.Text.Length) + Environment.NewLine;
                        flag = true;
                    }
                    else
                    {
                        newStr += name + ", loses: " + lose + ", draws: " + draw + ", wins: " + wins + ", points: " + points + Environment.NewLine;
                        flag = true;
                    }
                }
            }
            sr.Close();
            File.WriteAllText(path, newStr);
            if (checkName == false) MessageBox.Show("Team is not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (flag == false)
            {
                MessageBox.Show("The team is not updated", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("The team is updated", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void main_btn_Click(object sender, EventArgs e)
        {
            main_window.Show();
        }

        private void open_file_txt_Click(object sender, EventArgs e)
        {
            string file = @"C:\Users\Cyber\source\repos\Read_Write_From_txt\Read_Write_From_txt\file1.txt";
            Process.Start(file);
        }
    }
}
