using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElevatorControl_sem3
{  

    

    class DoorClass : Elevator
    {

        public void openDoor0(PictureBox left, PictureBox right)
        {
            right.Left += 1;
            left.Left -= 1;
        }
        public void openDoor1(PictureBox left, PictureBox right)
        {
            right.Left += 1; //increment of the right  picture box in x-axis
            left.Left -= 1; // decrement of the left picture box in x-axis

        }
        public void closeDoor0(PictureBox left, PictureBox right)
        {
            right.Left -= 1;
            left.Left += 1;

        }
        public void closeDoor1(PictureBox left, PictureBox right)
        {
            right.Left -= 1;
            left.Left += 1;
        }
    }
 }
