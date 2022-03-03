using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wLightBoxGUI.wLightBoxLib.Models
{
    public class DurationsMs
    {
        public int colorFade { get; set; }
        public int effectFade { get; set; }
        public int effectStep { get; set; }
    }
    public class Rgbw
    {
        public int colorMode { get; set; }
        public int effectID { get; set; }
        public string desiredColor { get; set; }
        public string currentColor { get; set; }
        public string lastOnColor { get; set; }
        public DurationsMs durationsMs { get; set; }
        public IDictionary<int, string> effectNames { get; set; }
        public IDictionary<int, string>  favColors { get; set; }
    }

    public class RootRgbw
    {
        public Rgbw rgbw { get; set; }
    }

}
