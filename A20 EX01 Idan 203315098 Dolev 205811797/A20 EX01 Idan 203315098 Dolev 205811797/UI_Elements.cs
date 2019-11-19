using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
namespace A20_EX01_Idan_203315098_Dolev_205811797
{
    class UI_Elements
    {
        public static Color m_mainColor = Color.FromArgb(32, 52, 88);
        public static Color m_secondaryColor = Color.FromArgb(66, 103, 178);

        //this.ClientSize = new System.Drawing.Size(1135, 638);


        public static void initializerAddons(Form i_Form)
        {
            i_Form.MaximizeBox = false;
            i_Form.MinimizeBox = false;
            i_Form.FormBorderStyle = FormBorderStyle.FixedDialog;
            i_Form.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            //i_Form.ClientSize = new System.Drawing.Size(2108, 1242);

        }

    //    public List<Button> navbarButtonSetter(Form i_Form, List<Object> Pages)
    //    {
    //        int startLocationX = 170, startLocationY = 30, buttonSpacing = 50,
    //        buttonWidth = 100, buttonHeight = 25;

    //        List<Button> navbarButtons = new List<Button>();

    //        for (int i = 0; i < Pages.Count; i++)
    //        {
    //            Button button = new Button();
    //            button.Location = new System.Drawing.Point(startLocationX, startLocationY);
    //            button.Name = "button1";
    //            button.Size = new System.Drawing.Size(75, 23);
    //            button.TabIndex = 1;
    //            button.Text = "button1";
    //            button.UseVisualStyleBackColor = true;
    //            navbarButtons.add(button);
    //        }

    //        return navbarButtons;
    //    }
    }
}
