using System.Collections.Generic;

namespace Masterchef.Mobile.App.Models
{
    public class ListViewGrouping<T> : List<T>
    {
        public ListViewGrouping(string title, string shortName)
        {
            Title = title;
            ShortName = shortName;
        }

        public string Title { get; set; }

        public string ShortName { get; set; }

    }
}
