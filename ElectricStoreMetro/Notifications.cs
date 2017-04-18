using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tulpep.NotificationWindow;

namespace ElectricStoreMetro
{
    public class Notifications
    {
        public static void Notfication(string title, string content, Color titleColor)
        {
            PopupNotifier p = new PopupNotifier();
            p.Image = Properties.Resources.NotifySuccess;
            p.TitleColor = titleColor;
            
            p.TitleText = title;
            p.ContentText = content;
            p.Popup();  
        }
    }
}
