using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Data.OleDb;

namespace ElevatorControl_sem3
{
    public partial class Elevator : Form
    {
        DoorClass door;
        LiftClass lift;
        DatabaseClass DbClass;

        
        bool doorat0Closed = true;
        bool doorat1Closed = true;
        int elePos = 1;
        bool goDown = false;
        bool goUp = false;
        bool alertclick = false;
       
        
        public Elevator()
        {
            
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            door = new DoorClass();
            lift = new LiftClass();
            DbClass = new DatabaseClass();
            pnlWhole.Height = this.Height;
            pnlWhole.Width = this.Width;
            RecentLog("form load");
            // RecentLog("Form_loaded");
        }
        private void disableButton()
        {
            btnClose.Enabled = false;
            btnDown.Enabled = false;
            btnFirst.Enabled = false;
            btnGround.Enabled = false;
            btnOpen.Enabled = false;
            btnUp.Enabled = false;


        }
        private void enableButton()
        {
            btnClose.Enabled = true;
            btnDown.Enabled = true;
            btnFirst.Enabled = true;
            btnGround.Enabled = true;
            btnOpen.Enabled = true;
            btnUp.Enabled = true;

        }


        private void btndown_Click(object sender, EventArgs e)
        {
            disableButton();
            btnFirst_Click(sender, e);
            //if (elePos == 1 && doorat1Closed == true)
            // {   RecentLog(" lift is moving up");
            //     tmr_Open_door1.Start();

            // }
            // else if (elePos == 1 && doorat1Closed == false)
            // {
            //     btnFirst_Click(sender, e);

            // }


        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            

            disableButton();
            btnGround_Click(sender, e);
            //RecentLog("lift is moving down");

            //if (elePos == 0)
            //{

            //    tmr_Open_Door0.Start();
            //}
            //else
            //{
            //    btnGround_Click(sender, e);

            //}
        }

       

       
        private void LiftUPFunc()
        {
            if (pnlLift.Top >= 0)// moving the elevator towards upward direction and stop at first floor
            {
                lift.liftUp(pnlLift);
            }
            else
            {
                elePos = 1;
                tmrLiftup.Stop();
                picDisplay.Image = global::ElevatorControl_sem3.Properties.Resources.one_image;
                tmr_Open_door1.Start();
            }
        }
        private void tmrLiftup_Tick(object sender, EventArgs e)
        {
            LiftUPFunc();

        }
        private void LiftDownFunc()
        {
            if (pnlLift.Bottom <= pnlLiftmove.Height)// moving  elevator towards downward direction and  stop at ground floor
            {
                lift.liftDown(pnlLift);
              //  pnlLift.Top += 1;
                
                
               
            }
            else
            {
                elePos = 0;
                tmrLiftdown.Stop();
                picDisplay.Image = global::ElevatorControl_sem3.Properties.Resources.ground_button;
                tmr_Open_Door0.Start();
                
            }
        }
        private void tmrLiftdown_Tick(object sender, EventArgs e)
        {
            LiftDownFunc();


        }


        private void btnOpen_Click(object sender, EventArgs e)
        {
            disableButton();
            if(elePos == 1 && doorat1Closed == true)
            {
                tmr_Open_door1.Start();
            } 
            else  if(elePos == 0 && doorat0Closed == true)
            {
                tmr_Open_Door0.Start();
            }                                                                           
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            disableButton();
            if (elePos == 1 && doorat1Closed == false)
            {
                tmr_Close_Door1.Start();
              

            }
            else if (elePos == 0 && doorat0Closed == false)
            {
                tmr_Close_Door0.Start();
               
            }
        }

        private void pnlWhole_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tmr_Open_door1_Tick(object sender, EventArgs e)
        {
            if ((elePos == 1 || elePos == -1) && doorat1Closed == true && picleftdoorat1.Left >= -picleftdoorat1.Width)//open the door of theelevator at first floor
            {
                door.openDoor1(picleftdoorat1, picrightdoorat1);
                
               
            }
            else
            {
                if (!alertclick)
                {
                    RecentLog("door opening at first floor");
                }
                
                tmr_Open_door1.Stop();
                enableButton();
                doorat1Closed = false;
                stop();
               
            }
        }
        private void tmr_Open_Door0_Tick(object sender, EventArgs e)
        {
            if((elePos ==0 || elePos == -1) && doorat0Closed == true && picleftdoorat0.Left >= -picleftdoorat0.Width)//open the door of the elevtor at ground floor
            {
               
                door.openDoor0(picleftdoorat0, picrightdoorat0);
                
            }
            else
            {
                if (!alertclick)
                {
                    RecentLog("door opening at ground floor");
                }
                
                tmr_Open_Door0.Stop();
                enableButton();
                doorat0Closed = false;
                stop();
                
            }
        }


        private void tmr_Close_Door1_Tick(object sender, EventArgs e)
        {
            if (doorat1Closed == false &&  elePos == 1 && picleftdoorat1.Left <= 0)//  close the door of the elevavtor at first floor
            {
                door.closeDoor1(picleftdoorat1, picrightdoorat1);
            }
            else
            {
                tmr_Close_Door1.Stop();
                doorat1Closed = true;
                if (goDown == true)
                {
                    tmrLiftdown.Start();
                    RecentLog("Lift Moving Down");
                    picDisplay.Image = global::ElevatorControl_sem3.Properties.Resources.down_gif;
                    goDown = false;
                }
                else
                {
                    enableButton();
                }
                RecentLog("door closing at first floor");
            }
;        }

        private void tmr_Close_Door0_Tick_1(object sender, EventArgs e)
        {
            if (doorat0Closed == false && elePos == 0 && picleftdoorat0.Left <= 0)// close the door of the elevator at ground floor 
            {
                door.closeDoor0(picleftdoorat0, picrightdoorat0);
                
            }
            else
            {
                RecentLog("door closing at ground floor");
                tmr_Close_Door0.Stop();
                
                doorat0Closed = true;
                
                if (goUp == true)
                {

                    tmrLiftup.Start();
                    RecentLog("Lift Moving Up");

                    picDisplay.Image = global::ElevatorControl_sem3.Properties.Resources.up_gif;
                    goUp = false;
                }
                else
                {
                    enableButton();
                }
            }
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
           
            if (doorat0Closed == true && elePos==0)
                
            {
                tmrLiftup.Start();
                picDisplay.Image = global::ElevatorControl_sem3.Properties.Resources.up_gif;
                RecentLog("lift is moving up");

            }
            else if(doorat0Closed == false && elePos == 0)
            {
                
                tmr_Close_Door0.Start();
                goUp = true;


            }
            else
            {
                tmr_Open_door1.Start();
            }

            
        }

        private void btnGround_Click(object sender, EventArgs e)
        {
            disableButton();
            if (doorat1Closed == true && elePos == 1)
            {
                tmrLiftdown.Start();
                picDisplay.Image = global::ElevatorControl_sem3.Properties.Resources.down_gif;
                RecentLog(" lift is moving down");
            }
            else if (doorat1Closed == false && elePos == 1)
            {
              
                tmr_Close_Door1.Start();
        
                goDown = true;

            }
            else
            {
                tmr_Open_Door0.Start();
            }
            

        }

        

        private void btnAlert_Click(object sender, EventArgs e)
        {
             alertclick = true;
           
            elePos = -1;
            tmr_Open_Door0.Start();
            tmr_Open_door1.Start();
            RecentLog("door open at first and ground floor");
            picDisplay.Image = global::ElevatorControl_sem3.Properties.Resources.alert_bell_image;
        }

        private async void stop()
        {

            
            if (elePos == 1 && doorat1Closed == false)
            {
                await Task.Delay(5000);
                tmr_Close_Door1.Start();

            }else if (elePos == 0 && doorat0Closed == false)
            {
                await Task.Delay(5000);
                tmr_Close_Door0.Start();
            }
        }
        private void btnDisplay_Click(object sender, EventArgs e)
        {
            //DbClass.record(Database_lstBox);


        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            Database_lstBox.Items.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void RecentLog(String Log)
        {
            DbClass.UnsavedLog(Log_lstBox,Log);
            //btnDisplayDBLog.PerformClick();

        }
        private void groundFloor_txtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSaveLog_Click(object sender, EventArgs e)
        {
            DbClass.SaveLog(Log_lstBox);
        }

        private void btnDisplayDBLog_Click(object sender, EventArgs e)
        {
            DbClass.displaySavedLog(Database_lstBox);
        }

        private void BtnClear_Click_1(object sender, EventArgs e)
        {
            Log_lstBox.Items.Clear();
        }

        private void lblDate_Click(object sender, EventArgs e)
        {

        }
    }
}
 



