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
            //i_Form.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            //i_Form.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            //i_Form.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            //i_Form.ClientSize = new System.Drawing.Size(1135, 638);

        }

    }
}
