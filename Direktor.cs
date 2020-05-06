using System;
using System.Collections.Generic;
using System.Text;

namespace LV3
{

     class Direktor{
      
        public ConsoleNotification INFOnotification(string author)
        {
            NotificationBuilder builder = new NotificationBuilder();
            builder.SetAuthor(author);
            builder.SetTitle("doop");
            builder.SetLevel(Category.INFO);
            builder.SetColor(ConsoleColor.White);
            builder.SetText("lv3");
            return builder.Build();
        }
        public ConsoleNotification ERRORnotification(string author)
        {
            NotificationBuilder builder = new NotificationBuilder();
            builder.SetAuthor(author);
            builder.SetTitle("doop");
            builder.SetLevel(Category.ERROR);
            builder.SetColor(ConsoleColor.Red);
            builder.SetText("lv3");
            return builder.Build();
        }
        public ConsoleNotification ALERTnotification(string author)
        {
            NotificationBuilder builder = new NotificationBuilder();
            builder.SetAuthor(author);
            builder.SetTitle("doop");
            builder.SetLevel(Category.ALERT);
            builder.SetColor(ConsoleColor.DarkRed);
            builder.SetText("lv3");
            return builder.Build();
        }




    }
}
