using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMOMS_Display_Mockup_Framework
{
    class SelectedComponent
    {
        public int OrderID { get; set; }
        public string ComponentId { get; set; }
        public string MoveUp { get; }
        public string MoveDown { get; }
        public string Remove { get; }

        public SelectedComponent(int orderId, string componentId)
        {
            OrderID = orderId;
            ComponentId = componentId;
            MoveUp = "UP";
            MoveDown = "DOWN";
            Remove = "X";
        }

    }
}
