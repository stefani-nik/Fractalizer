using System.Windows.Forms;

namespace Fractalizer.Common
{
    public static class FormConstants
    {
        public static readonly int BaseFormWidth = Screen.PrimaryScreen.WorkingArea.Width;
        public static readonly int BaseFromHeight = Screen.PrimaryScreen.WorkingArea.Height;

        public static readonly int SettingsPanelWidth = Screen.PrimaryScreen.WorkingArea.Width;
        public static readonly int SettingsPanelHeight = Screen.PrimaryScreen.WorkingArea.Height / 5;

        public static readonly int SettingsPanelLocationX = 0;
        public static readonly int SettingsPanelLocationY = Screen.PrimaryScreen.WorkingArea.Height / 10;

        public static readonly int PicturePanelWidth = Screen.PrimaryScreen.WorkingArea.Width;
        public static readonly int PicturePanelHeight = (Screen.PrimaryScreen.WorkingArea.Height/3)*2;

        public static readonly int PicturePanelLocationX = 0;
        public static readonly int PicturePanelLocationY = SettingsPanelLocationY + SettingsPanelHeight;


    }
}
