using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Animal.DependencyLocate
{
    public interface IFactory
    {
        IWindow MakeWindow();

        IButton MakeButton();

        ITextBox MakeTextBox();

    }

    public interface IWindow
    {
       public  string ShowInfo();
    }

    public interface ITextBox
    {
        public string ShowInfo();
    }
}
