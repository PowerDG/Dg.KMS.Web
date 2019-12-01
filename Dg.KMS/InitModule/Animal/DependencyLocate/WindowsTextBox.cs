using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Animal.DependencyLocate
{
    public class WindowsTextBox: ITextBox
    {
        public String Description { get; private set; }

        public WindowsTextBox()
        {
            this.Description = "Windows风格按钮";
        }

        public String ShowInfo()
        {
            return this.Description;
        }
    }
}
