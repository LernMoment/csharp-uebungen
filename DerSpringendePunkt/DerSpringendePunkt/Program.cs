using Lernmoment.CsharpCanvas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csharp_uebungskit
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            CsharpCanvas canvas = new CsharpCanvas();
            DrawingArea area = new DrawingArea(canvas);
            canvas.Setup();
        }
    }
}
