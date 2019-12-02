using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace A20_EX01_Idan_203315098_Dolev_205811797.GUI
{
    public static class Stylesheet
    {

        //FONTS
        public static string font_MainFontName = "Century Gothic";
        public static Font font_NavbarButtonDefault = new System.Drawing.Font(font_MainFontName, 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        public static Font font_NavbarButtonSelected = new System.Drawing.Font(font_MainFontName, 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        public static Font font_Header1 = new System.Drawing.Font(font_MainFontName, 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        public static Font font_Header2 = new System.Drawing.Font(font_MainFontName, 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        public static Font font_Header2Underline = new System.Drawing.Font(font_MainFontName, font_Header2.Size, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        public static Font font_Header3 = new System.Drawing.Font(font_MainFontName, 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        public static Font font_Header3Underline = new System.Drawing.Font(font_MainFontName, font_Header3.Size, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Regular | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        public static Font font_Body = new System.Drawing.Font(font_MainFontName, 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        public static Font font_BodyItalics = new System.Drawing.Font(font_MainFontName, font_Body.Size, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        public static Font font_Footer = new System.Drawing.Font(font_MainFontName, 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //COLORS
        public static Color color_Main = Color.FromArgb(32, 52, 88);
        public static Color color_Secondary = Color.FromArgb(66, 103, 178);
        public static Color color_Tertiary = Color.FromArgb(14, 32, 69);
        public static Color color_BGColorA = Color.FromArgb(223, 226, 232);
        public static Color color_BGColorB = Color.FromArgb(216, 220, 229);
        public static Color color_BGColor_OLD = Color.FromArgb(224, 224, 224); //TODO
        public static Color color_NavbarButtonColor = Color.FromArgb(65, 65, 65);
        public static Color color_TabRollover = Color.FromArgb(89, 124, 194);
        public static Color color_NavbarRollover = Color.FromArgb(193, 203, 220);
        public static Color color_PanelColorA = Color.White;
        public static Color color_PanelColorB = Color.FromArgb(245, 245, 245);

        //Best Times Heatmap Colors
        public static Color color_BestTimesLow = Color.FromArgb(232, 200, 20);
        public static Color color_BestTimesMedium = Color.FromArgb(217, 117, 17);
        public static Color color_BestTimesHigh = Color.FromArgb(217, 17, 17);
    }
}
