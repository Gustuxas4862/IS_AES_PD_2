// Program was created by Augustas Leliūnas. Student group id PI20B.

using PD2;
using System;
using System.Windows.Forms;

public static class Program
{
    [STAThread]
    public static void Main()
    {
        Application.SetHighDpiMode(HighDpiMode.SystemAware);
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new MainPanel());
    }
}
