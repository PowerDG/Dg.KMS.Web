using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Animal.DependencyLocate
{
    public class BaseButton
    {
    }
    public class WindowsButton : IButton
    {
        public String Description { get; private set; }

        public WindowsButton()
        {
            this.Description = "Windows风格按钮";
        }

        public String ShowInfo()
        {
            return this.Description;
        }
    }
    public class MacButton : IButton
    {
        public String Description { get; private set; }

        public MacButton()
        {
            this.Description = " Mac风格按钮";
        }

        public String ShowInfo()
        {
            return this.Description;
        }
    }
}
