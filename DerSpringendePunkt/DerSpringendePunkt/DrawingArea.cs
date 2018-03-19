
using Lernmoment.CsharpCanvas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_uebungskit
{
    class DrawingArea
    {
        private CsharpCanvas canvas;
        public DrawingArea(CsharpCanvas aCanvas)
        {
            canvas = aCanvas;
            // Vorder- und Hintergrund definieren
            canvas.SetBackgroundColor(0x00, 0xA8, 0xC6);
            canvas.SetForegroundColor(System.Drawing.Color.Blue);

            // Draw Event abonieren
            canvas.Draw += Canvas_Draw;

            // initialisiert das canvas
            canvas.Init();
        }

        private void Canvas_Draw()
        {
            // Hier können Elemente gezeichnet werden
        }
    }
}
