using System.Drawing;

namespace A20_EX02_Idan_203315098_Dolev_205811797.View
{
    public static class Stylesheet
    {
        #region Fonts
        // FONTS
        public static string Font_MainFontName = "Century Gothic";
        public static Font Font_NavbarButtonDefault = new Font(
            Font_MainFontName,
            10F,
            FontStyle.Bold,
            GraphicsUnit.Point,
            (byte)0);

        public static Font Font_NavbarButtonSelected = new Font(
            Font_MainFontName,
            10F,
            (FontStyle)(FontStyle.Bold | FontStyle.Underline),
            GraphicsUnit.Point,
            (byte)0);

        public static Font Font_Header1 = new Font(
            Font_MainFontName,
            18F,
            FontStyle.Bold,
            GraphicsUnit.Point,
            (byte)0);

        public static Font Font_Header2 = new Font(
            Font_MainFontName,
            13F,
            FontStyle.Bold,
            GraphicsUnit.Point,
            (byte)0);

        public static Font Font_Header2Underline = new Font(
            Font_MainFontName,
            Font_Header2.Size,
            (FontStyle)(FontStyle.Bold | FontStyle.Underline),
            GraphicsUnit.Point,
            (byte)0);

        public static Font Font_Header3 = new Font(
            Font_MainFontName,
            11F,
            FontStyle.Regular,
            GraphicsUnit.Point,
            (byte)0);

        public static Font Font_Header3Underline = new Font(
            Font_MainFontName,
            Font_Header3.Size,
            (FontStyle)(FontStyle.Regular | FontStyle.Underline),
            GraphicsUnit.Point,
            (byte)0);

        public static Font Font_Body = new Font(
            Font_MainFontName,
            9F,
            FontStyle.Regular,
            GraphicsUnit.Point,
            (byte)0);

        public static Font Font_BodyItalics = new Font(
            Font_MainFontName,
            Font_Body.Size,
            FontStyle.Italic,
            GraphicsUnit.Point,
            (byte)0);

        public static Font Font_Footer = new Font(
            Font_MainFontName,
            8.25F,
            FontStyle.Regular,
            GraphicsUnit.Point,
            (byte)0);

        public static Font Font_BestTimesGrid = new Font(
            Font_MainFontName,
            7.875F,
            FontStyle.Bold,
            GraphicsUnit.Point,
            (byte)0);
        #endregion

        #region Colors
        // COLORS
        public static Color Color_Main = Color.FromArgb(32, 52, 88);
        public static Color Color_Secondary = Color.FromArgb(66, 103, 178);
        public static Color Color_Tertiary = Color.FromArgb(14, 32, 69);
        public static Color Color_BGColorA = Color.FromArgb(223, 226, 232);
        public static Color Color_BGColorB = Color.FromArgb(216, 220, 229);
        public static Color Color_NavbarButtonColor = Color.FromArgb(65, 65, 65);
        public static Color Color_ButtonRollover = Color.FromArgb(158, 171, 195);
        public static Color Color_NavbarSelected = Color.FromArgb(193, 203, 220);
        public static Color Color_PanelColorA = Color.White;
        public static Color Color_PanelColorB = Color.FromArgb(241, 241, 241);
        //// Best Times Heatmap Colors
        public static Color Color_BestTimesLow = Color.FromArgb(232, 200, 20);
        public static Color Color_BestTimesMedium = Color.FromArgb(217, 117, 17);
        public static Color Color_BestTimesHigh = Color.FromArgb(217, 17, 17);
        #endregion
    }
}
