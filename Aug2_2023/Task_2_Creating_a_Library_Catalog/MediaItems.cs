using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCatalog
{
    internal class MediaItem
    {
        private string title;
        private string mediaType;
        private int duration;

        public MediaItem(string _title, string _mediaType, int _duration)
        {
            title = _title;
            mediaType = _mediaType;
            duration = _duration;
        }
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public string MediaType
        {
            get { return mediaType; }
            set { mediaType = value; }
        }
        public int Duration
        {
            get { return duration; }
            set { duration = value; }
        }


    }
}



