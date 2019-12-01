using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Animal.DependencyLocate
{
    public class WindowsFactory : IFactory
    {
        public IWindow MakeWindow()
        {
            return new WindowsWindow();
        }

        public IButton MakeButton()
        {
            return new WindowsButton();
        }

        public ITextBox MakeTextBox()
        {
            return new WindowsTextBox();
        }
    }
}
