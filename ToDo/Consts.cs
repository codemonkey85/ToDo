using System.Drawing;

namespace ToDo
{
    public static class Consts
    {
        internal static readonly Color DefaultColor = Color.Black;
        internal static readonly string NewProject = @"New Project";
        internal static readonly string NewTask = @"New Task";
        internal static readonly string NewTag = @"New Tag";
        internal static readonly string NewLocation = @"New Location";
        internal static readonly string NewSmartList = @"New Smart List";

        public enum LocationConditions
        {
            Arriving,
            Leaving
        }
    }
}