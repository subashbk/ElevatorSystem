using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElevatorControl_sem3
{
    class LiftClass : Elevator
    {
        
        public void liftUp(Panel lift)
        {
            lift.Top -= 1;//decrement the location of elevator in y axis
        }
        public void liftDown( Panel lift)
        {
            lift.Top += 1;//increment the location of elevator in y axis
        }
    }
}
    
