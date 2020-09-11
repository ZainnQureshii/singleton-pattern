using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Theme
    {
        public string ThemeCode { get; set; }
        public System.Drawing.Image FormBackgroundImage { get; set; }
        public System.Drawing.Color FormBackColor { get; set; }
        public System.Drawing.Color ButtonForeColor { get; set; }
        public System.Drawing.Color ButtonBackColor { get; set; }
        public System.Drawing.Font ButtonFont { get; set; }
        public string ButtonText { get; set; }
        
    }
}
