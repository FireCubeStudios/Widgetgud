using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsUdk.UI.Shell.Dashboard;

namespace Widgetgud
{
    public class DashboardEx : DashboardExtension
    {
        public void ToggleVisibility(Guid sessionID, DashboardInvokeType invokeType, Rect monitor);
        public void Show(Guid sessionID, DashboardInvokeType invokeType, Rect monitor);
        public void Dismiss(Guid sessionID, DashboardInvokeType invokeType);
        public void StartSwipe(Guid sessionID, Point position);
        public void ContinueSwipe(Point position);
        public void CommitSwipe(Point position);
        public void CancelSwipe();
        public void SetStartUpEvent(Guid sessionID, StartUpEvent startUpEvent);
        public bool IsSupported();
        public void ReportDashboardButtonReset();
        public void Show(Guid sessionId, DashboardInvokeType invokeType, Rect monitor, ulong edgeGestureOffset, GestureAnimationData animationData);
        public static DashboardExtension GetDefault();

        public bool IsPrelaunchEnabled { get; }
        public TimeSpan PrelaunchDelay { get; }
        public DashboardPrelaunchOptions PrelaunchOptions { get; set; }
        public bool ShouldResetDashboardButton { get; }
    }
}
