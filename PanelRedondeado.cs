using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Fase_1_C_
{
    public class PanelRedondeado : Panel
    {
        // Esta variable controla qué tan curvas serán las esquinas
        private int radioBordes = 30;

        public int RadioBordes
        {
            get { return radioBordes; }
            set
            {
                radioBordes = value;
                this.Invalidate(); // Fuerza al panel a redibujarse si cambias el valor
            }
        }

        // Aquí modificamos el comportamiento visual nativo del Panel
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Creamos la "ruta" que cortará los bordes
            GraphicsPath rutaGrafo = new GraphicsPath();

            // Esquina superior izquierda
            rutaGrafo.AddArc(0, 0, radioBordes, radioBordes, 180, 90);
            // Esquina superior derecha
            rutaGrafo.AddArc(Width - radioBordes, 0, radioBordes, radioBordes, 270, 90);
            // Esquina inferior derecha
            rutaGrafo.AddArc(Width - radioBordes, Height - radioBordes, radioBordes, radioBordes, 0, 90);
            // Esquina inferior izquierda
            rutaGrafo.AddArc(0, Height - radioBordes, radioBordes, radioBordes, 90, 90);

            rutaGrafo.CloseFigure();

            // Le decimos al panel que su nueva forma (Región) es la ruta que acabamos de dibujar
            this.Region = new Region(rutaGrafo);
        }
    }
}
