using System;
using System.Collections.Generic;
using System.Text;

namespace MathMultiplicationTables.Models
{
   /// <summary>
   /// Navigation Pages
   /// </summary>
    public enum MenuItemType
    {
        About,
        Home
    }
    
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
