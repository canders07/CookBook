using System;
using System.Collections.Generic;
using System.Text;

namespace CookBook.Models
{

    public enum MenuItemType
    {
        Browse,
        About
    }
    public class Folder
    {
        public MenuItemType Id { get; set; }
        public string Name { get; set; }
        public string path { get; set; }
        public string Title { get; set; }
    }
}
