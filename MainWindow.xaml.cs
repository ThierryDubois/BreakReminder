using System;
using System.Windows;
using Windows.Data.Xml.Dom;
using Windows.UI.Notifications;

namespace BreakReminder
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
        }

        private void ButtonShowToast_Click(object sender, RoutedEventArgs e)
        {
            string title = "The current time is";

            string toastXmlString =
            $@"<toast><visual>
            <binding template='ToastGeneric'>
            <text>{title}</text>
            </binding>
        </visual></toast>";

            var xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(toastXmlString);

            var toastNotification = new ToastNotification(xmlDoc);

            var toastNotifier = ToastNotificationManager.CreateToastNotifier();
            toastNotifier.Show(toastNotification);
        }
    }
}
