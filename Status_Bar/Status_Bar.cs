using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Media;

namespace Status_Bar_Namespace
{
    public partial class Status_Bar : UserControl
    {
        int CharacterWidth = 1;
        public enum NotificationType
        {
            Success,
            Information,
            Error,
        }
        bool Animate = false;
        public string CopyrightText
        {
            get
            {
                return LCopyRightText.Text;
            }
            set
            {
                LCopyRightText.Text = value;
            }
        }
        private bool AnimationEnabledVar;
        public bool AnimationEnabled
        {
            get
            {
                
                return AnimationEnabledVar;
            }
            set
            {
                PanelPromotion.Visible = value;
                AnimationTimer.Enabled = value;
                AnimationEnabledVar = value;
            }
        }
        public string PromotionText
        {
            get
            {
                return LPromotionText.Text;
            }
            set
            {
                LPromotionText.Text = value;
            }
        }
        public Status_Bar()
        {
            InitializeComponent();

        }
        public void Show_Notification(string NT, NotificationType Notification_Type)
        {
            Color NEC = Color.FromArgb(171, 0, 31);
            Color NIC = Color.FromArgb(244, 136, 0);
            Color NSC = Color.FromArgb(53, 0, 174);
            Color NC = new Color();
            //SoundPlayer player = new SoundPlayer();
            if (Notification_Type == NotificationType.Error)
            {
                NC = NEC;
            }
            else if (Notification_Type == NotificationType.Information)
            {
                //player.SoundLocation = "Info_Error.wav";
                NC = NIC;
            }
            else if (Notification_Type == NotificationType.Success)
            {
                NC = NSC;
            }
            //player.Play();
            if (L_Notification_Text.InvokeRequired)
            {
                Invoke(new EventHandler(delegate (object sender2, EventArgs e2)
                {
                    L_Notification_Text.Text = NT;
                    L_Notification_Text.BackColor = NC;

                }), new object[2] { this, null });
            }
            else
            {
                L_Notification_Text.Text = NT;
                L_Notification_Text.BackColor = NC;
            }
            Animate = true;
            System.Timers.Timer AMT = new System.Timers.Timer();
            System.Timers.Timer NDT = new System.Timers.Timer();

            AMT.Elapsed += AMT_Tick;
            NDT.Elapsed += NDT_Tick;
            NDT.Interval = 5000;
            AMT.Interval = 10;
            AMT.Enabled = true;
            AMT.Start();
            NDT.Enabled = true;
            NDT.Start();
        }

        private void AMT_Tick(object sender, EventArgs e)
        {
            try
            {
                Invoke(new EventHandler(delegate (object sender2, EventArgs e2)
                {
                    if (Animate == true)
                    {

                        if (TLP_Status_Bar.RowStyles[1].Height <= 30)
                        {
                            if (TLP_Status_Bar.RowStyles[1].Height < 30)
                            {
                                TLP_Status_Bar.RowStyles[1].Height += 1;
                            }
                            else
                            {
                                L_Ready.BackColor = L_Notification_Text.BackColor;
                            }
                            if (TLP_Status_Bar.RowStyles[0].Height > 0)
                            {
                                TLP_Status_Bar.RowStyles[0].Height -= 1;
                            }
                        }
                        else
                        {

                        }
                    }
                    else
                    {
                        if (TLP_Status_Bar.RowStyles[0].Height < 30)
                        {
                            if (TLP_Status_Bar.RowStyles[1].Height > 0)
                                TLP_Status_Bar.RowStyles[1].Height -= 1;
                            if (TLP_Status_Bar.RowStyles[0].Height < 30)
                                TLP_Status_Bar.RowStyles[0].Height += 1;
                        }
                        else
                        {
                            ((System.Timers.Timer)sender).Stop();
                        }
                    }

                }), new object[2] { this, null });
            }
            catch
            {

            }

        }

        private void NDT_Tick(object sender, EventArgs e)
        {
            ((System.Timers.Timer)sender).Stop();
            Animate = false;
            try
            {
                Invoke(new EventHandler(delegate (object sender2, EventArgs e2)
                {
                    L_Ready.BackColor = Color.FromArgb(0, 122, 204);

                }), new object[2] { this, null });
            }
            catch
            {

            }
        }

        private void Status_Bar_Load(object sender, EventArgs e)
        {
            TLP_Status_Bar.RowStyles[0].Height = 30;
            TLP_Status_Bar.RowStyles[1].Height = 0;
        }

        private void AnimationTimer_Tick(object sender, EventArgs e)
        {

            if((LPromotionText.Left+LPromotionText.Width)/CharacterWidth>0)
            {
                LPromotionText.Left -= CharacterWidth;
            }
            else
            {
                LPromotionText.Left = PanelPromotion.Width;
            }
            
        }

        private void Status_Bar_Load_1(object sender, EventArgs e)
        {
            AnimationTimer.Enabled = true;
        }
    }
}
