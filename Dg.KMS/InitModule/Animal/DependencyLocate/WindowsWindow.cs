using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Animal.DependencyLocate
{
    public class WindowsWindow: IWindow
    {
        public String Description { get; private set; }

        public WindowsWindow()
        {
            this.Description = "Windows风格Window";
        }

        public String ShowInfo()
        {
            return this.Description;
        }
    }
}
