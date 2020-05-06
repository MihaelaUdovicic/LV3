using System;
using System.Collections.Generic;
using System.Text;

namespace LV3
{
    class NotificationBuilder : IBuilder
    {
        private string author, title, text;
        private DateTime time;
        private ConsoleColor color;
        private Category level;

        public ConsoleNotification Build()
        {
            return new ConsoleNotification(author, title, text, time, level, color);
        }
        public IBuilder SetAuthor(String author)
        {
            this.author = author;
            return this;
        }
        public IBuilder SetTitle(String title)
        {
            this.title = title;
            return this;
        }
        public IBuilder SetTime(DateTime time)
        {
            this.time = time;
            return this;
        }
        public IBuilder SetLevel(Category level)
        {
            this.level = level;
            return this;
        }
        public IBuilder SetColor(ConsoleColor color)
        {
            this.color = color;
            return this;
        }
        public IBuilder SetText(String text)
        {
            this.text = text;
            return this;
        }


    }
}
