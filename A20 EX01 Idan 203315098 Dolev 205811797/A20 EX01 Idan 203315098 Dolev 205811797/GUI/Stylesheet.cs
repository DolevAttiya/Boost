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
        public static Font font_NavbarButtonDefault = new Font(
            font_MainFontName,
            10F,
            FontStyle.Bold,
            GraphicsUnit.Point,
            ((byte)(0)));
        public static Font font_NavbarButtonSelected = new Font(
            font_MainFontName,
            10F,
            ((FontStyle)((FontStyle.Bold | FontStyle.Underline))),
            GraphicsUnit.Point,
            ((byte)(0)));
        public static Font font_Header1 = new Font(
            font_MainFontName,
            18F,
            FontStyle.Bold,
            GraphicsUnit.Point,
            ((byte)(0)));
        public static Font font_Header2 = new Font(
            font_MainFontName,
            13F,
            FontStyle.Bold,
            GraphicsUnit.Point,
            ((byte)(0)));
        public static Font font_Header2Underline = new Font(
            font_MainFontName,
            font_Header2.Size,
            ((FontStyle)((FontStyle.Bold | FontStyle.Underline))),
            GraphicsUnit.Point,
            ((byte)(0)));
        public static Font font_Header3 = new Font(
            font_MainFontName,
            11F,
            FontStyle.Regular,
            GraphicsUnit.Point,
            ((byte)(0)));
        public static Font font_Header3Underline = new Font(
            font_MainFontName,
            font_Header3.Size,
            ((FontStyle)((FontStyle.Regular | FontStyle.Underline))),
            GraphicsUnit.Point,
            ((byte)(0)));
        public static Font font_Body = new Font(
            font_MainFontName,
            9F,
            FontStyle.Regular,
            GraphicsUnit.Point,
            ((byte)(0)));
        public static Font font_BodyItalics = new Font(
            font_MainFontName,
            font_Body.Size,
            FontStyle.Italic,
            GraphicsUnit.Point,
            ((byte)(0)));
        public static Font font_Footer = new Font(
            font_MainFontName,
            8.25F,
            FontStyle.Regular,
            GraphicsUnit.Point,
            ((byte)(0)));
        //COLORS
        public static Color color_Main = Color.FromArgb(32, 52, 88);
        public static Color color_Secondary = Color.FromArgb(66, 103, 178);
        public static Color color_Tertiary = Color.FromArgb(14, 32, 69);
        public static Color color_BGColorA = Color.FromArgb(223, 226, 232);
        public static Color color_BGColorB = Color.FromArgb(216, 220, 229);
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
