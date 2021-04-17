using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SaveTXTFileDate.Classes;

namespace SaveTXTFileDate.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void GetSave(object sender, EventArgs e)
        {
            string first = FirstNameBox.Text.ToString();
            string middle = MiddleNameBox.Text.ToString();
            string last = LastNameBox.Text.ToString();
            int age = Convert.ToInt32(AgeBox.Text.ToString());

            Data ForSave = new Data(first,middle,last,age);

            Logic SaveInfo = new Logic();
            SaveInfo.SaveDataToTxt(ForSave);
        }
    }
}
