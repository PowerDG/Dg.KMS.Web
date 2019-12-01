using Animal.DependencyLocate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Animal.DependencyLocate
{
    public class MacFactory : IFactory
    {
        public IWindow MakeWindow()
        {
            return new MacWindow();
        }

        public IButton MakeButton()
        {
            return new MacButton();
        }

        public ITextBox MakeTextBox()
        {
            return new MacTextBox();
        }
    }

    public class MacWindow : IWindow
    {
        public String Description { get; private set; }

        public MacWindow()
        {
            this.Description = "Mac-Window";
        }

        public String ShowInfo()
        {
            return this.Description;
        }
    }



    public class MacTextBox : ITextBox
    {
        public String Description { get; private set; }

        public MacTextBox()
        {
            this.Description = "Mac-TextBox";
        }

        public String ShowInfo()
        {
            return this.Description;
        }
    }
}
