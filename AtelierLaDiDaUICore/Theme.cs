using System.Drawing;
using System.Windows.Forms;

namespace AtelierLaDiDaUICore
{
    internal struct ThemeColor
    {
        internal Color ForeColor;
        internal Color BackgroundColor;
        internal Color TextBoxBackground;
        internal Color ResultColor;
        internal Color ResultBackGroundColor;
    }

    internal enum EnumTheme
    {
        Default,
        Dark
    }

    internal class Theme
    {
        public static void ChangeTheme(Form form, EnumTheme theme)
        {
            var container = form.Controls;
            ThemeColor color;
            switch (theme)
            {
                case EnumTheme.Dark:
                    color.ForeColor = Color.White;
                    color.BackgroundColor = Color.Black;
                    color.TextBoxBackground = Color.DarkGray;
                    color.ResultColor = Color.White;
                    color.ResultBackGroundColor = Color.Black;
                    form.BackColor = Color.Black;
                    break;

                default:
                    color.ForeColor = Color.Black;
                    color.BackgroundColor = SystemColors.Control;
                    color.TextBoxBackground = SystemColors.Window;
                    color.ResultColor = Color.Black;
                    color.ResultBackGroundColor = SystemColors.Control;
                    form.BackColor = SystemColors.Control;
                    break;
            }
            foreach (Control component in container)
            {
                if (component.Name == "tbxResult")
                {
                    component.BackColor = color.ResultBackGroundColor;
                    component.ForeColor = color.ResultColor;
                }
                else if (component is Button)
                {
                    component.BackColor = color.BackgroundColor;
                    component.ForeColor = color.ForeColor;
                }
                else if (component is TextBox)
                {
                    component.BackColor = color.TextBoxBackground;
                    component.ForeColor = color.ForeColor;
                }
                else if (component is ComboBox)
                {
                    component.BackColor = color.TextBoxBackground;
                    component.ForeColor = color.ForeColor;
                }
                else if (component is CheckBox)
                {
                    component.BackColor = color.BackgroundColor;
                    component.ForeColor = color.ForeColor;
                }
                else if (component is Label)
                {
                    component.BackColor = color.BackgroundColor;
                    component.ForeColor = color.ForeColor;
                }
            }
        }
    }
}