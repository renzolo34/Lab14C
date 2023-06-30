using Lab14C.Droid;
using System.IO;
using Xamarin.Forms;
using Lab14C.Interface;

[assembly: Dependency(typeof(ConfigDataBase))]
namespace Lab14C.Droid
{
    public class ConfigDataBase : IConfigDataBase
    {
        public string GetFullPath(string databaseFileName)
        {
            return Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), databaseFileName);
        }
    }
}