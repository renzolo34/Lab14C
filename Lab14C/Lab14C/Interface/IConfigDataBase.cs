using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Lab14C.Interface
{
    public interface IConfigDataBase
    {
        string GetFullPath(string databaseFileName);
    }
}