using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMOMS_Display_Mockup_Framework
{
    class SelectedDisplay
    {
        public int OrderID { get; set; }
        public string DisplayId { get; set; }
        public string MoveUp { get; }
        public string MoveDown { get; }
        public string Remove { get; }

        public SelectedDisplay(int orderId, string displayId)
        {
            OrderID = orderId;
            DisplayId = displayId;
            MoveUp = "UP";
            MoveDown = "DOWN";
            Remove = "X";
        }

    }
}
