using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace plonger
{
    class Controller
    {
        MainWindow window;

        public Controller(MainWindow _window)
        {  
            window = _window;

            // Load XML file
        }

        public void run(String _key)
        {
            Debug.WriteLine(_key);

            // Search program for the string
        }
    }
}
