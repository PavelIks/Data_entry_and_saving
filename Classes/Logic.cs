using System.IO;
using System.Windows.Forms;
using SaveTXTFileDate.Interfaces;

namespace SaveTXTFileDate.Classes
{
    class Logic: IFile
    {
        public void SaveDataToTxt(Data new_Info)
        {
            SaveFileDialog save = new SaveFileDialog();
            string text = new_Info.first_Name.ToString();
            string text1 = new_Info.middle_Name.ToString();
            string text2= new_Info.last_Name.ToString();
            string text3 = new_Info.age.ToString();
            string[] str = new string [4];
            str[0] = text;
            str[1] = text1;
            str[2] = text2;
            str[3] = text3;
            if (save.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllLines(save.FileName, str);
            }
        }
    }
}