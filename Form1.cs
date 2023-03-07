using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// using the fontawesome library
using FontAwesome.Sharp;
using Color = System.Drawing.Color;

namespace CookieUICsharp
{
    public partial class Form1 : Form
    {
        // fields
        private IconButton currentBtn;
        HomeUserControl homeUser = new HomeUserControl();
        EatInUserControl eatInUser = new EatInUserControl();
       
        public Form1()
        {
            InitializeComponent();
            addUserControl(homeUser);

        }

        // add usercontrol to main form
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelDashboard.Controls.Clear();
            panelDashboard.Controls.Add(userControl);
            userControl.BringToFront();
        }

        //Structs
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);


        }

        // methods
        // activating button 
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();

                // button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
            }
        }

        // changing button back to default settings
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void ibtnHome_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            addUserControl(homeUser);
        }

        private void ibtneatIn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            addUserControl(eatInUser);
        }

        private void ibtnCollection_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
        }

        private void ibtnDelivery_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
        }

        private void ibtnTakesAway_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
        }

        private void ibtnDriver_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
        }

        private void ibtnCustomers_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
        }

        private void ibtnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
