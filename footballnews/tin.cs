using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace footballnews
{
    public class tin
    {
        public string id, img, title, content;
        public tin()
        {

        }
        public tin(string id, string img, string title, string content)
        {
            this.id = id;
            this.img = img;
            this.title = title;
            this.content = content;
        }

        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Img
        {
            get { return img; }
            set { img = value; }
        }
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public string Content
        {
            get { return content; }
            set { content = value; }
        }


    }
}