using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Singleton
{
    sealed class ThemeManager
    {
        static ThemeManager objManager;
        private ThemeManager()
        {
        }
         public static ThemeManager Instance
        {
            get
            {
                if (objManager == null)
                {
                    objManager = new ThemeManager();
                }

                return objManager;
            }
        }

        Theme ZainT = new Theme();

        public void initTheme()
        {
            ZainT.ThemeCode = "NewTheme";
            ZainT.FormBackgroundImage = System.Drawing.Image.FromFile(@"E:\Documents\ZaIN\WEB\Udemy\DevSlopes\Skateboarding Website - Bootstrap 4\assets\board.jpg");
            ZainT.FormBackColor = System.Drawing.SystemColors.MenuHighlight;
            ZainT.ButtonForeColor = System.Drawing.SystemColors.ControlDarkDark;
            ZainT.ButtonBackColor = System.Drawing.SystemColors.ActiveCaption;
            ZainT.ButtonFont = new System.Drawing.Font("Copperplate Gothic Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ZainT.ButtonText = "New THEME Applied";
       //     ZainT.Hide = label1.hide();
        }

        public void ApplyThemeOnButton(Button btn)
        {
            btn.ForeColor = ZainT.ButtonForeColor;
            btn.BackColor = ZainT.ButtonBackColor;
            btn.BackgroundImage = ZainT.FormBackgroundImage;
            btn.Font = ZainT.ButtonFont;
            btn.Text = ZainT.ButtonText;
        }

        public void ApplyThemeOnForm(Form1 frm)
        {
            frm.BackgroundImage = ZainT.FormBackgroundImage;
            frm.BackColor = ZainT.FormBackColor;
            frm.AccessibleName = ZainT.ThemeCode;
        }

    }
}
