using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace CapaPresentacion
{
    public class RJButton : Button
    {
        private int tamañoBorde = 0;
        private int radioBorde = 40;
        private Color colorBorde = Color.PaleVioletRed;

        [Category("PersonalizarBoton")]
        public int TamañoBorde
        {
            get { return tamañoBorde; }
            set { tamañoBorde = value; this.Invalidate(); }
        }
        [Category("PersonalizarBoton")]
        public int RadioBorde
        {
            get { return radioBorde; }
            set { radioBorde = value; this.Invalidate(); }
        }
        [Category("PersonalizarBoton")]
        public Color ColorBorde
        {
            get { return colorBorde; }
            set { colorBorde = value; this.Invalidate(); }
        }
        [Category("PersonalizarBoton")]
        public Color ColorBoton
        {
            get { return this.BackColor; }
            set { this.BackColor = value; }
        }
        [Category("PersonalizarBoton")]
        public Color ColorTexto
        {
            get { return this.ForeColor; }
            set { this.ForeColor = value;  }
        }
        public RJButton()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Size = new Size(150, 40);
            this.BackColor = Color.MediumSlateBlue;
            this.ForeColor = Color.White;
            this.Resize += new EventHandler(RedimencionarBoton);
        }
        private void RedimencionarBoton(object sender, EventArgs e)
        {
            if (RadioBorde > this.Height)
            {
                RadioBorde = this.Height;
            }
        }
        private GraphicsPath obtenerlarutadelafigura(RectangleF rectandulo, float radio)
        {
            GraphicsPath ObtenerRuta = new GraphicsPath();
            ObtenerRuta.StartFigure();
            ObtenerRuta.AddArc(rectandulo.X, rectandulo.Y, radio, radio, 180, 90);
            ObtenerRuta.AddArc(rectandulo.Width-radio, rectandulo.Y, radio, radio, 270, 90);
            ObtenerRuta.AddArc(rectandulo.Width - radio, rectandulo.Height-radio, radio, radio, 0, 90);
            ObtenerRuta.AddArc(rectandulo.X, rectandulo.Height-radio, radio, radio, 90, 90);

            ObtenerRuta.CloseFigure();
            return ObtenerRuta;
        } 
        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            RectangleF SuperficiExterior = new RectangleF(0, 0, this.Width, this.Height);
            RectangleF BordeBoton = new RectangleF(1, 1, this.Width-0.8F, this.Height-1);

            if (RadioBorde > 2)
            {
                using (GraphicsPath RutaSuperficieBoton = obtenerlarutadelafigura(SuperficiExterior, RadioBorde))
                using (GraphicsPath RutaBorde = obtenerlarutadelafigura(BordeBoton, RadioBorde - 1F))
                using (Pen BoligrafoSuperficie = new Pen(this.Parent.BackColor, 2))
                using (Pen BoligrafoBordeBoton = new Pen(ColorBorde, TamañoBorde))
                {
                    BoligrafoBordeBoton.Alignment = PenAlignment.Inset;
                    this.Region = new Region(RutaSuperficieBoton);
                    pevent.Graphics.DrawPath(BoligrafoSuperficie, RutaSuperficieBoton);

                    if(TamañoBorde >= 1)
                    {
                        pevent.Graphics.DrawPath(BoligrafoBordeBoton, RutaBorde );
                    }
                }
            }
            else
            {
                this.Region = new Region(SuperficiExterior);
                if (TamañoBorde >= 1)
                {
                    using (Pen BoligarfoBordeBoton = new Pen(ColorBorde, TamañoBorde))
                    {
                        BoligarfoBordeBoton.Alignment = PenAlignment.Inset;
                        pevent.Graphics.DrawRectangle(BoligarfoBordeBoton, 0, 0, this.Width-1, this.Height-1);
                    }
                }
            }
        }
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            this.Parent.BackColorChanged += new EventHandler(Container_BackColorChanged);
        }
        private void Container_BackColorChanged(object sender, EventArgs e)
        {
            if(this.DesignMode)
            {
                this.Invalidate();
            }
        }
    }
}
