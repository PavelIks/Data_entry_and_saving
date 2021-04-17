using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SaveTXTFileDate.Classes;

namespace SaveTXTFileDate.Interfaces
{
    interface IFile
    {
       void SaveDataToTxt(Data new_Info);
    }
}
