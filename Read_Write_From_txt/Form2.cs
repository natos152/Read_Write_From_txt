using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Read_Write_From_txt
{
    public partial class Form2 : Form
    {
        string path = @"../../file1.txt";

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string output = File.ReadAllText(path);
            print_txt_file.Text = output;
        }
    }
}
