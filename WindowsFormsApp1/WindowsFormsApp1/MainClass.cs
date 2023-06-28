using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace WindowsFormsApp1
{
    internal class MainClass
    {
      public static void ShowWindow(Form openwin,Form clswin ,Form MDIwin)
      {
            clswin.Show();
            openwin.MdiParent = MDIwin;
            openwin.WindowState = FormWindowState.Maximized;
            openwin.Show();
       }
       public static void ShowWindow(Form openwin, Form MDIwin)
       {
             openwin.MdiParent = MDIwin;
            openwin.WindowState = FormWindowState.Maximized;
            openwin.Show();
       }
    }
}
