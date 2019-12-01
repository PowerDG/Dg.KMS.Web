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
        string ShowInfo();
    }

    public interface ITextBox
    {
        string ShowInfo();
    }
}
