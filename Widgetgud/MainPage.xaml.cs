using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using WindowsUdk.UI.Shell.Dashboard;
// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Widgetgud
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            Guid g = new Guid("7103f56a-e4d7-4887-91ac-b46a71d96f15"); // dummy guid. probably find the one in registry
            Point p = new Point(0, 0);

            var d = new WindowsUdk.UI.Shell.Dashboard.DashboardContract();

            DashboardExtension f = DashboardExtension.GetDefault(); // errors on runtime with ystem.Reflection.TargetInvocationException: Exception has been thrown by the target of an invocation. ---> System.TypeLoadException: Error 0x261F.  > System.Runtime.InteropServices.COMException: Class not registered 

            DashboardExtension e = new DashboardExtension(); // error does not contain  constructor with 0 argument

          //  e.StartSwipe(g, p);
        }
    }
}
