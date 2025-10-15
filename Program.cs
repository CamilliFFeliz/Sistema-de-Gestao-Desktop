using System;
using System.Windows.Forms;
using SysInventory.UI;
using SysInventory.DAL;

namespace SysInventory
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Database.InitializeDatabase();
            Application.Run(new FormPrincipal());
        }
    }
}
