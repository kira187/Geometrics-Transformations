using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Geometrics_Transfirmations_2D
{
    public partial class Form1 : Form
    {

        List<Point> pts = new List<Point>();
        Point CenterOrigin;

        public Form1()
        {
            InitializeComponent();

            btn_refleX.Enabled = false;
            btn_refleY.Enabled = false;
            btn_Rotation.Enabled = false;
            btn_Scalar.Enabled = false;
            btn_Traslate.Enabled = false;

        }

        Pen Pencil(Color color)
        {
            Pen Pencil = new Pen(color, 2);
            return Pencil;
        }

        private void WorkSPace_MouseClick(object sender, MouseEventArgs e)
        {
            Point point = new Point(e.X, e.Y);

            if (btn_DrawnFigure.Enabled != false)
            {
                pts.Add(point);
                WorkSPace.CreateGraphics().DrawEllipse(Pencil(Color.Black), point.X, point.Y, 2, 2);
            }
        }

        private void TrackBar_Rotation_Scroll(object sender, EventArgs e)
        {
            lbl_Rotacion.Text = "Rotacion: " + trackBar_Rotation.Value.ToString() + "°";
        }

        private void Btn_DrawnFigure_Click(object sender, EventArgs e)
        {
            if (pts.Count > 1)
            {
                DrawnFigure(pts, Pencil(Color.Black));
                DrawnCenter(pts);
            }
            else
            {
                MessageBox.Show("Debe ingresar minimo 2 puntos");
            }
        }

        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            WorkSPace.Refresh();
            txB_TraslationX.Clear();
            txB_TraslationY.Clear();
            NumUpDown_scale.Value = 0;
            pts.Clear();

            btn_refleX.Enabled = false;
            btn_refleY.Enabled = false;
            btn_Rotation.Enabled = false;
            btn_Scalar.Enabled = false;
            btn_Traslate.Enabled = false;
            btn_DrawnFigure.Enabled = true;
        }

        private void Btn_refleX_Click(object sender, EventArgs e)
        {
            List<Point> ptsRefelected;

            ptsRefelected = ReflectionX(pts);
            pts = ptsRefelected;

            DrawnFigure(pts, Pencil(Color.Black));
        }

        private void Btn_refleY_Click(object sender, EventArgs e)
        {
            List<Point> ptsRefelected;

            ptsRefelected = ReflectionY(pts);
            pts = ptsRefelected;

            DrawnFigure(pts, Pencil(Color.Green));
        }

        private void Btn_Traslate_Click(object sender, EventArgs e)
        {
            int translateX = 0;
            int translateY = 0;

            if (txB_TraslationX.Text != "" && txB_TraslationY.Text != "")
            {
                translateX = Convert.ToInt32(txB_TraslationX.Text);
                translateY = Convert.ToInt32(txB_TraslationY.Text);

                WorkSPace.Refresh();
                animatedTranslation(pts, translateX, translateY);

            }
            else if (txB_TraslationX.Text != "")
            {
                translateX = Convert.ToInt32(txB_TraslationX.Text);

                WorkSPace.Refresh();
                animatedTranslation(pts, translateX, translateY);

            }
            else if (txB_TraslationY.Text != "")
            {
                translateY = Convert.ToInt32(txB_TraslationY.Text);

                WorkSPace.Refresh();
                animatedTranslation(pts, translateX, translateY);
            }

            List<Point> TraslacionAct;
            TraslacionAct = Traslation(pts, translateX, translateY);
            pts = TraslacionAct;
        }

        private void Btn_Rotation_Click(object sender, EventArgs e)
        {
            int grades = trackBar_Rotation.Value;

            List<Point> PtsOrigin,
                        PtsRotated, 
                        PtsOrinalPosition = new List<Point>();
            
            PtsOrigin = PtsDisplacementOrigin(pts);
            RotationAnimated(PtsOrigin, grades);
            PtsRotated = Rotation(PtsOrigin, grades);
            PtsOrinalPosition = PtsDisplacementOriginalPosition(PtsRotated);
            pts = PtsOrinalPosition;

            DrawnCenter(pts);
        }

        private void Btn_Scalar_Click(object sender, EventArgs e)
        {
            Double scale = Convert.ToSingle(NumUpDown_scale.Text);
            
            List<Point> PtsOrigin,
                        PtsScaled,
                        PtsOrinalPosition = new List<Point>();

            PtsOrigin = PtsDisplacementOrigin(pts);
            ScaleAnimated(PtsOrigin, scale);
            PtsScaled = ScaleFigure(PtsOrigin, scale);

            PtsOrinalPosition = PtsDisplacementOriginalPosition(PtsScaled);
            pts = PtsOrinalPosition;
            DrawnCenter(pts);
        }

        private void btnLoadFile_Click_1(object sender, EventArgs e)
        {
            WorkSPace.Refresh();
            if (File.Exists("FigurePoints.txt"))
            {
                pts.Clear();
                using (StreamReader inputuFile = new StreamReader("FigurePoints.txt"))
                {
                    string linea = "";
                    int x, y;
                    while (!inputuFile.EndOfStream)
                    {
                        Point coordenada = new Point();
                        string[] strCoordenada;

                        linea = inputuFile.ReadLine();
                        strCoordenada = linea.Split(',');


                        x = int.Parse(strCoordenada[0]);
                        y = int.Parse(strCoordenada[1]);
                        coordenada.X = x;
                        coordenada.Y = y;


                        pts.Add(coordenada);

                        DrawnFigure(pts, Pencil(Color.Black));
                    }
                    inputuFile.Close();
                }
            }
            else
            {
                MessageBox.Show("No existe el archivo coordenadas.txt");
            }
            //dibujarCuadricula();

        }

        public void DrawnFigure(List<Point> pts, Pen pencil)
        {
            WorkSPace.Refresh();

            for (int i = 0; i < pts.Count; i++)
            {
                if (i == (pts.Count - 1))
                {
                    WorkSPace.CreateGraphics().DrawLine(Pencil(Color.Black), pts[i], pts[0]);
                }
                else
                {
                    WorkSPace.CreateGraphics().DrawLine(Pencil(Color.Black), pts[i], pts[i + 1]);
                }
            }
            //DrawnCenter(pts);
            btn_DrawnFigure.Enabled = false;
            btn_refleX.Enabled = true;
            btn_refleY.Enabled = true;
            btn_Rotation.Enabled = true;
            btn_Scalar.Enabled = true;
            btn_Traslate.Enabled = true;

        }

        public void DrawnCenter(List<Point> pts)
        {
            Point Center = FindCenter(pts);

            WorkSPace.CreateGraphics().DrawEllipse(Pencil(Color.Red), Center.X, Center.Y, 2, 2);
        }

        void animatedTranslation(List<Point> pts, int tx, int ty)
        {

            Point center = FindCenter(pts);


            if (tx > 0)
            {
                for (int i = 1; i <= tx; i++)

                {
                    WorkSPace.Refresh();
                    DrawnFigure(Traslation(pts, (i), 0), Pencil(Color.Black));

                    System.Threading.Thread.Sleep(30);
                }
            }
            else
            {
                for (int i = 0; i > tx; i--)

                {
                    WorkSPace.Refresh();
                    DrawnFigure(Traslation(pts, (i), 0), Pencil(Color.Black));

                    System.Threading.Thread.Sleep(30);
                }
            }
            if (ty > 0)
            {
                for (int i = 1; i <= ty; i++)
                {
                    WorkSPace.Refresh();
                    DrawnFigure(Traslation(pts, tx, (i)), Pencil(Color.Black));
                    System.Threading.Thread.Sleep(30);
                }
            }
            else
            {
                for (int i = 0; i >= ty; i--)
                {
                    WorkSPace.Refresh();
                    DrawnFigure(Traslation(pts, tx, (i)), Pencil(Color.Black));
                    System.Threading.Thread.Sleep(30);
                }
            }

        }

        void RotationAnimated(List<Point> pts, int grades)
        {
            for (int i = 1; i <= grades; i++)
            {
                WorkSPace.Refresh();
                DrawnFigure(Rotation(pts, (i)), Pencil(Color.Black));
                System.Threading.Thread.Sleep(100);
            }
        }

        void ScaleAnimated(List<Point> pts, Double scale)
        {
            for (int i = 1; i <= scale; i++)
            {
                WorkSPace.Refresh();
                DrawnFigure(ScaleFigure(pts, (i)), Pencil(Color.Black));
                System.Threading.Thread.Sleep(500);

            }
        }

        public Point FindCenter(List<Point> pts)
        {
            Point Max = pts[0];
            Point Min = pts[0];

            int xc, yc = 0;

            for (int i = 0; i < pts.Count; i++)
            {
                if (Max.X < pts[i].X)
                {
                    Max.X = pts[i].X;
                }
                if (Max.Y < pts[i].Y)
                {
                    Max.Y = pts[i].Y;
                }
                if (Min.X > pts[i].X)
                {
                    Min.X = pts[i].X;
                }
                if (Min.Y > pts[i].Y)
                {
                    Min.Y = pts[i].Y;
                }
            }

            xc = (Max.X + Min.X) / 2;
            yc = (Max.Y + Min.Y) / 2;

            Point Center = new Point(xc, yc);
            return Center;
        }

        public List<Point> ReflectionX(List<Point> pts)
        {
            List<Point> ptsReflected = new List<Point>();
            Point Center = FindCenter(pts);
            Point aux;

            for (int i = 0; i < pts.Count; i++)
            {
                aux = new Point();
                aux.X = pts[i].X;
                aux.Y = ((Center.Y - pts[i].Y) * 2) + pts[i].Y;
                ptsReflected.Add(aux);
            }

            return ptsReflected;

        }

        public List<Point> ReflectionY(List<Point> pts)
        {
            List<Point> ptsReflected = new List<Point>();
            Point Center = FindCenter(pts);
            Point aux;

            for (int i = 0; i < pts.Count; i++)
            {
                aux = new Point();
                aux.Y = pts[i].Y;
                aux.X = ((Center.X - pts[i].X) * 2) + pts[i].X;
                ptsReflected.Add(aux);
            }

            return ptsReflected;

        }

        public List<Point> Traslation(List<Point> pts, int tx, int ty)
        {
            CenterOrigin = FindCenter(pts);
            List<Point> ptsTraslated = new List<Point>();
            Point aux;

            for (int i = 0; i < pts.Count; i++)
            {
                aux = new Point();

                aux.X = (pts[i].X + tx);
                aux.Y = (pts[i].Y + ty);

                ptsTraslated.Add(aux);

            }

            return ptsTraslated;

        }

        public List<Point> PtsDisplacementOrigin(List<Point> pts)
        {
            Point center = FindCenter(pts);
            List<Point> DisplacedPoints = new List<Point>(); ;

            int cx = 0;
            int cy = 0;

            for (int i = 0; i <= center.X; i++)
            {
                DisplacedPoints = Traslation(pts, -i, cy);

                WorkSPace.Refresh();
                DrawnFigure(Traslation(pts, -i, cy), Pencil(Color.Black));
                

                System.Threading.Thread.Sleep(10);
                cx = -i;
            }
            for (int i = 0; i <= center.Y; i++)
            {
                DisplacedPoints = Traslation(pts, cx, -i);

                WorkSPace.Refresh();
                DrawnFigure(Traslation(pts, cx, -i), Pencil(Color.Black));
                System.Threading.Thread.Sleep(10);
            }
            return DisplacedPoints;
        }

        public List<Point> PtsDisplacementOriginalPosition(List<Point> pts)
        {

            List<Point> ptsDisplacedOrigin = new List<Point>(); ;
            Point center = CenterOrigin;

            int cx = 0;
            int cy = 0;

            for (int i = 0; i <= center.X; i++)
            {
                ptsDisplacedOrigin = Traslation(pts, i, cy);

                WorkSPace.Refresh();

                DrawnFigure(Traslation(pts, i, cy), Pencil(Color.Black));
                System.Threading.Thread.Sleep(10);
                cx++;

            }
            for (int i = 0; i <= center.Y; i++)
            {
                ptsDisplacedOrigin = Traslation(pts, cx, i);

                WorkSPace.Refresh();
                DrawnFigure(Traslation(pts, cx, i), Pencil(Color.Black));
                System.Threading.Thread.Sleep(10);
            }
            return ptsDisplacedOrigin;
        }

        public List<Point> Rotation(List<Point> pts, int grados)
        {
            List<Point> ptsRotated = new List<Point>();
            Point PRotar = new Point();

            Double teta = (Math.PI * grados) / 180;
            Double Cos = Math.Cos(teta);
            Double Sin = Math.Sin(teta);

            for (int i = 0; i < pts.Count; i++)
            {

                PRotar.X = (int)((Cos * pts[i].X) - (Sin * pts[i].Y));
                PRotar.Y = (int)((Sin * pts[i].X) + (Cos * pts[i].Y));

                ptsRotated.Add(PRotar);

            }

            return ptsRotated;
        }

        public List<Point> ScaleFigure(List<Point> puntos, double scale)
        {
            List<Point> Scaledpts = new List<Point>();
            Point ScaledPt = new Point(); ;


            for (int i = 0; i < puntos.Count; i++)
            {

                ScaledPt.X = (int)(puntos[i].X * scale);
                ScaledPt.Y = (int)(puntos[i].Y * scale);

                Scaledpts.Add(ScaledPt);
            }

            DrawnCenter(puntos);
            return Scaledpts;
        }

        

        
    }

}
