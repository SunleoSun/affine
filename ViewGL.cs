using System;
using System.Drawing;
using System.Windows.Forms;
namespace OpenGL
{
    public partial class ViewGL : UserControl
    {
        public ViewGL()
        {
            InitializeComponent();
            FindOneLengthX();
            FindOneLengthY();
            paint_style = PaintStyle.Fill;

        }
        public ViewGL(PaintStyle p)
        {
            paint_style = p;
        }
        public enum PaintStyle{Fill = 1, Lines = 2, Points = 3};
        public PaintStyle paint_style;

        
        double scale_factor = 1;
        public double ScaleFactor
        {
            get { return scale_factor; }
            set { scale_factor = value; }
        }

        int rotate_angle = 0;
        public int RotateAngle
        {
            get { return rotate_angle; }
            set { rotate_angle = value; }
        }

        double transfer_value = 0;
        public double TransferValue
        {
            get { return transfer_value; }
            set { transfer_value = value; }
        }

        double rotate_x = 0;
        public double RotateX
        {
            get { return rotate_x; }
            set { rotate_x = value; }
        }
        double rotate_y = 0;
        public double RotateY
        {
            get { return rotate_y; }
            set { rotate_y = value; }
        }
        double oneLengthX = 0;
        public double OneLengthX
        {
            get { return oneLengthX; }
        }
        double oneLengthY = 0;
        public double OneLengthY
        {
            get { return oneLengthY; }
        }

        double xmin = -4;
        public double xMin
        {
            get { return xmin; }
        }
        double xmax = 7;
        public double xMax
        {
            get { return xmax; }
        }

        double ymax = 12;
        public double yMax
        {
            get { return ymax; }
        }
        double ymin = -4;
        public double yMin
        {
            get { return ymin; }
        }
        /// <summary>
        /// Функция для рисования координат, координатной сетки, чисел для подписи значений коорднинат
        /// </summary>
        private void DrawCoordinates()
        {
            GL.glLineWidth(3.0f);
            GL.glBegin(GL.GL_LINES);
            GL.glColor3f(1.0f, 1.0f, 0.0f);

            if (xMax <= 0)
            {
                GL.glVertex2d(xMax, yMax);
                GL.glVertex2d(xMax, yMin);
            }
            else
            {
                GL.glVertex2d(0, yMax);
                GL.glVertex2d(0, yMin);
            }
            if (xMax <= 0)
            {
                GL.glVertex2d(xMax, yMax);
                GL.glVertex2d(xMax - oneLengthX / 10, yMax - (oneLengthY / 5));
                GL.glVertex2d(xMax, yMax);
                GL.glVertex2d(xMax + oneLengthX / 10, yMax - (oneLengthY / 5));
            }
            else
            {
                GL.glVertex2d(0, yMax);
                GL.glVertex2d(-oneLengthX / 10, yMax - (oneLengthY / 5));
                GL.glVertex2d(0, yMax);
                GL.glVertex2d(oneLengthX / 10, yMax - (oneLengthY / 5));
            }
            if (yMin > 0)
            {
                GL.glVertex2d(xMin, yMin);
                GL.glVertex2d(xMax, yMin);
            }
            else
                if (yMax < 0)
                {
                    GL.glVertex2d(xMin, yMax);
                    GL.glVertex2d(xMax, yMax);
                }
                else
                    if (xMin < 0)
                    {
                        GL.glVertex2d(xMin, 0);
                        GL.glVertex2d(xMax, 0);
                    }
                    else
                    {
                        GL.glVertex2d(0, 0);
                        GL.glVertex2d(xMax, 0);
                    }
            GL.glEnd();

            OutText("0", -oneLengthX / 3, -oneLengthY / 5);
            if (yMax < 0)
            {
                OutText("X", xMax, yMax - oneLengthY / 3);
                GL.glLineWidth(3.0f);
                GL.glBegin(GL.GL_LINES);
                GL.glColor3f(1.0f, 1.0f, 0.0f);
                GL.glVertex2d(xMax, yMax);
                GL.glVertex2d(xMax - (oneLengthX / 5), yMax - oneLengthY / 10);
                GL.glVertex2d(xMax, yMax);
                GL.glVertex2d(xMax - (oneLengthX / 5), yMax - -oneLengthY / 10);
                GL.glEnd();

            }
            else
                if (yMin > 0)
                {
                    OutText("X", xMax, yMin - oneLengthY / 3);
                    GL.glLineWidth(3.0f);
                    GL.glBegin(GL.GL_LINES);
                    GL.glColor3f(1.0f, 1.0f, 0.0f);
                    GL.glVertex2d(xMax, yMin);
                    GL.glVertex2d(xMax - (oneLengthX / 5), yMin + oneLengthY / 10);
                    GL.glVertex2d(xMax, yMin);
                    GL.glVertex2d(xMax - (oneLengthX / 5), yMin + -oneLengthY / 10);
                    GL.glEnd();

                }
                else
                {
                    OutText("X", xMax, -oneLengthY / 3);
                    GL.glLineWidth(3.0f);
                    GL.glBegin(GL.GL_LINES);
                    GL.glColor3f(1.0f, 1.0f, 0.0f);
                    GL.glVertex2d(xMax, 0);
                    GL.glVertex2d(xMax - (oneLengthX / 5), oneLengthY / 10);
                    GL.glVertex2d(xMax, 0);
                    GL.glVertex2d(xMax - (oneLengthX / 5), -oneLengthY / 10);
                    GL.glEnd();
                }
            if (xMax <= 0)
            {
                OutText("Y", xMax - oneLengthX / 3, yMax);
            }
            else
            {
                OutText("Y", -oneLengthX / 3, yMax);
            }
            GL.glBegin(GL.GL_LINES);
            for (int y = 1; y < 10; y++)
            {
                if (xMax <= 0)
                {
                    GL.glVertex2d(xMax - oneLengthX / 10, yMax - (y * oneLengthY));
                    GL.glVertex2d(xMax + oneLengthX / 10, yMax - (y * oneLengthY));
                }
                else
                {
                    GL.glVertex2d(-oneLengthX / 10, yMax - (y * oneLengthY));
                    GL.glVertex2d(oneLengthX / 10, yMax - (y * oneLengthY));
                }

                GL.glEnd();

                GL.glLineWidth(1.0f);
                GL.glEnable(GL.GL_LINE_STIPPLE);
                GL.glLineStipple(1, 0xff0);
                GL.glBegin(GL.GL_LINES);
                GL.glColor3f(1.0f, 1.0f, 1.0f);
                if (xMin < 0)
                {
                    GL.glVertex2d(xmin, yMax - (y * oneLengthY));
                }
                else
                    GL.glVertex2d(0, yMax - (y * oneLengthY));
                GL.glVertex2d(xmax, yMax - (y * oneLengthY));
                GL.glEnd();
                GL.glDisable(GL.GL_LINE_STIPPLE);
                if (xMax <= 0)
                {
                    if (yMax > 10)
                    {
                        OutText((((yMax - (y * oneLengthY))).ToString("F1")), xMax + oneLengthX / 3.5, yMax - (y * oneLengthY));
                    }
                    else
                        OutText((((yMax - (y * oneLengthY))).ToString("F2")), xMax + oneLengthX / 3.5, yMax - (y * oneLengthY));
                }
                else
                    if (yMax > 10)
                    {
                        OutText((((yMax - (y * oneLengthY))).ToString("F1")), -oneLengthX / 1.5, yMax - (y * oneLengthY));
                    }
                    else
                        OutText((((yMax - (y * oneLengthY))).ToString("F2")), -oneLengthX / 1.5, yMax - (y * oneLengthY));
                GL.glLineWidth(3.0f);
                GL.glBegin(GL.GL_LINES);
                GL.glColor3f(1.0f, 1.0f, 0.0f);
            }
            for (int x = 1; x < 20; x++)
            {
                GL.glLineWidth(3.0f);
                if (yMax < 0)
                {
                    GL.glVertex2d(xMax - (x * oneLengthX), yMax - oneLengthY / 10);
                    GL.glVertex2d(xMax - (x * oneLengthX), yMax + oneLengthY / 10);
                }
                else
                    if (yMin > 0)
                    {
                        GL.glVertex2d(xMax - (x * oneLengthX), yMin - oneLengthY / 10);
                        GL.glVertex2d(xMax - (x * oneLengthX), yMin + oneLengthY / 10);
                    }
                    else
                    {
                        GL.glVertex2d(xMax - (x * oneLengthX), -oneLengthY / 10);
                        GL.glVertex2d(xMax - (x * oneLengthX), oneLengthY / 10);
                    }
                GL.glEnd();

                GL.glLineWidth(1.0f);
                GL.glEnable(GL.GL_LINE_STIPPLE);
                GL.glLineStipple(1, 0xff0);
                GL.glBegin(GL.GL_LINES);
                GL.glColor3f(1.0f, 1.0f, 1.0f);
                GL.glVertex2d(xMax - (x * oneLengthX), ymax);
                GL.glVertex2d(xMax - (x * oneLengthX), ymin);
                GL.glEnd();

                GL.glDisable(GL.GL_LINE_STIPPLE);
                if (yMax < 0)
                {
                    if (xMax > 10)
                        OutText((((xMax - (x * oneLengthX))).ToString("F1")), xMax - (x * oneLengthX), yMax - oneLengthY / 2.5);
                    else
                        OutText((((xMax - (x * oneLengthX))).ToString("F2")), xMax - (x * oneLengthX), yMax - oneLengthY / 2.5);

                }
                else
                    if (yMin > 0)
                    {
                        if (xMax > 10)
                            OutText((((xMax - (x * oneLengthX))).ToString("F1")), xMax - (x * oneLengthX), yMin - oneLengthY / 2.5);
                        else
                            OutText((((xMax - (x * oneLengthX))).ToString("F2")), xMax - (x * oneLengthX), yMin - oneLengthY / 2.5);
                    }
                    else
                    {
                        if (xMax > 10)
                            OutText((((xMax - (x * oneLengthX))).ToString("F1")), xMax - (x * oneLengthX), -oneLengthY / 2.5);
                        else
                            OutText((((xMax - (x * oneLengthX))).ToString("F2")), xMax - (x * oneLengthX), -oneLengthY / 2.5);
                    }
                GL.glLineWidth(3.0f);
                GL.glBegin(GL.GL_LINES);
                GL.glColor3f(1.0f, 1.0f, 0.0f);
            }
            GL.glEnd();
        }

        private void FindMaxMinXYForOnePoint(double[] point1)
        {
            double[] res = new double[point1.Length];
            res = MultiplyMatrixsByVariant(point1);
            if (res[0]>xMax)
            {
                xmax = res[0];
            }
            if (res[0]<xMin)
            {
                xmin = res[0];
            }
            if (res[1]* ScaleFactor> yMax)
            {
                ymax = res[1] * ScaleFactor;
            }
            if (res[1] * ScaleFactor < yMin)
            {
                ymin = res[1] * ScaleFactor;
            }
        }
        public void ReflashMaxMinXY()
        {
            xmax = 7;
            xmin = -4;
            ymax = 12;
            ymin = -4;
        }
        private void FindMaxMinXY()
        {
            //Для веохней часи фигуры
            double[] point = new double[] { 0, 0, 1 ,0,0,0,0,0,0};
            FindMaxMinXYForOnePoint(point);
            point = new double[] { -2, 0, 1, 0, 0, 0, 0, 0, 0 };
            FindMaxMinXYForOnePoint(point);
            point = new double[] { -3, -1, 1, 0, 0, 0, 0, 0, 0 };
            FindMaxMinXYForOnePoint(point);
            point = new double[] { -1, -2, 1, 0, 0, 0, 0, 0, 0 };
            FindMaxMinXYForOnePoint(point);
            point = new double[] { 4, -2, 1, 0, 0, 0, 0, 0, 0 };
            FindMaxMinXYForOnePoint(point);
            point = new double[] { 6, -1, 1, 0, 0, 0, 0, 0, 0 };
            FindMaxMinXYForOnePoint(point);
            //Для нижней части фигуры
            point = new double[] { -3, 1, 1, 0, 0, 0, 0, 0, 0 };
            FindMaxMinXYForOnePoint(point);
            point = new double[] { -1, 2, 1, 0, 0, 0, 0, 0, 0 };
            FindMaxMinXYForOnePoint(point);
            point = new double[] { 4, 2, 1, 0, 0, 0, 0, 0, 0 };
            FindMaxMinXYForOnePoint(point);
            point = new double[] { 6, 1, 1, 0, 0, 0, 0, 0, 0 };
            FindMaxMinXYForOnePoint(point);

        }

        private double[] MultiplyMatrixsByVariant(double[] coordinates)
        {
            double[] res = new double[coordinates.Length];
            double[] scalematrix = new double[]
            {1,0,0,   
               0,ScaleFactor,0,
               0,0,1};
            double[] move_for_rotate = new double[]
                {1,0,0,   
                   0,1,0,
                   -RotateX,-RotateY/ScaleFactor,1};
            double[] rotate_matrix = new double[]
                {Math.Cos(Math.PI/180 * RotateAngle),-Math.Sin(Math.PI/180 * RotateAngle),0,   
                   Math.Sin(Math.PI/180 * RotateAngle),Math.Cos(Math.PI/180 * RotateAngle),0,
                   0,0,1};
            double[] move_for_rotate2 = new double[]
                {1,0,0,   
                   0,1,0,
                   RotateX,RotateY/ScaleFactor,1};
            double[] transfer_matrix = new double[]
            {1,0,0,   
               0,1,0,
               0,TransferValue/ScaleFactor,1};

            res = MultiplyMatrixs(coordinates, scalematrix);
            res = MultiplyMatrixs(res, move_for_rotate);
            res = MultiplyMatrixs(res, rotate_matrix);
            res = MultiplyMatrixs(res, move_for_rotate2);
            res = MultiplyMatrixs(res, transfer_matrix);

            return res;
        }
        private double[] MultiplyMatrixs(double[] matrix1, double[] matrix2)
        {
            if (matrix1.Length != 9 || matrix2.Length != 9)
            {
                return null;
            }

            int count = 0;
            double[] ResultMatrix = new double[matrix1.Length];
            for (int z = 0; z < matrix1.Length; z += 3)
            {
                for (int x = 0; x < 3; x++)
                {
                    count = 0;
                    for (int y = 0; y < matrix2.Length; y += 3)
                    {
                        ResultMatrix[x + z] += matrix1[z + count] * matrix2[x + y];
                        count++;
                    }
                }
            }
            return ResultMatrix;
        }
        private void DrawFigure()
        {
            //Рисуем фигуру (нижняя часть)
            GL.glBegin(GL.GL_TRIANGLE_FAN);
            GL.glColor3f(0.0f, 1.0f, 0.0f);

            GL.glVertex2d(0.0, 0.0);
            GL.glVertex2d(-2.0, 0);
            GL.glVertex2d(-3.0, -1);
            GL.glVertex2d(-1.0, -2.0);
            GL.glVertex2d(4, -2.0);
            GL.glVertex2d(6, -1);

            GL.glEnd();
            GL.glLineWidth(1.0f);

            //Рисуем фигуру (верхняя часть)
            GL.glBegin(GL.GL_TRIANGLE_FAN);
            GL.glColor3f(0.0f, 1.0f, 0.0f);
            GL.glVertex2d(0.0, 0);
            GL.glVertex2d(-2, 0);
            GL.glVertex2d(-3.0, 1);
            GL.glVertex2d(-1, 2);
            GL.glVertex2d(4, 2);
            GL.glVertex2d(6, 1);
            GL.glEnd();

        }

        //Найти минимальную величину видимую в масштабе X
        private void FindOneLengthX()
        {
            if (xmin >= 0)
            {
                oneLengthX = xmax / 20;
            }
            else
            {
                oneLengthX = (xmax - xmin) / 20;
            }
        }
        /// <summary>
        /// Найти минимальную величину видимую в масштабе Y
        /// </summary>
        private void FindOneLengthY()
        {
            oneLengthY = (ymax - ymin) / 10;
        }
        //Функция вращения
        private void Rotate(bool Positive)
        {
            if (Positive)
            {
                double[] matrix = new double[]
                {1,0,0,0,   
                   0,1,0,0,
                   0,0,1,0,
                   RotateX,RotateY/ScaleFactor,0,1};
                GL.glMultMatrixd(matrix);

                matrix = new double[]
                {Math.Cos(Math.PI/180 * RotateAngle),-Math.Sin(Math.PI/180 * RotateAngle),0,0,   
                   Math.Sin(Math.PI/180 * RotateAngle),Math.Cos(Math.PI/180 * RotateAngle),0,0,
                   0,0,1,0,
                   0,0,0,1};
                GL.glMultMatrixd(matrix);

                matrix = new double[]
                {1,0,0,0,   
                   0,1,0,0,
                   0,0,1,0,
                   -RotateX,-RotateY/ScaleFactor,0,1};
                GL.glMultMatrixd(matrix);
            }
            else
            {
                double[] matrix = new double[]
                {1,0,0,0,   
                   0,1,0,0,
                   0,0,1,0,
                   0,4,0,1};
                GL.glMultMatrixd(matrix);
                matrix = new double[]
                {Math.Cos(Math.PI/180 * RotateAngle),Math.Sin(Math.PI/180 * RotateAngle),0,0,   
                   -Math.Sin(Math.PI/180 * RotateAngle),Math.Cos(Math.PI/180 * RotateAngle),0,0,
                   0,0,1,0,
                   0,0,0,1};
                GL.glMultMatrixd(matrix);
                matrix = new double[]
                {1,0,0,0,   
                   0,1,0,0,
                   0,0,1,0,
                   0,-4,0,1};
                GL.glMultMatrixd(matrix);
            }
        }

        /// <summary> 
        /// Обработчик события WM_PAINT. Здесь выполняются все основные команды рисования OpenGL.
        /// </summary>
        private  void ViewGL_Paint(object sender, PaintEventArgs e)
        {
            FindOneLengthX();
            FindOneLengthY();
            FindMaxMinXY();
            GL.glLoadIdentity();
            //Преобразуем систему координат
            GLU.gluOrtho2D(xMin - oneLengthX, xMax + oneLengthX, yMin - oneLengthY, yMax + oneLengthY);

            //Переключатель для различных вариантов отображения
            switch (paint_style)
            {
                case PaintStyle.Fill:
                    GL.glPolygonMode(GL.GL_FRONT_AND_BACK, GL.GL_FILL);
                    break;
                case PaintStyle.Lines:
                    GL.glPolygonMode(GL.GL_FRONT_AND_BACK, GL.GL_LINE);
                    break;
                case PaintStyle.Points:
                    GL.glEnable(GL.GL_POINT_SMOOTH);
                    GL.glPointSize(10f);
                    GL.glPolygonMode(GL.GL_FRONT_AND_BACK, GL.GL_POINT);
                    break;
            }
            GL.glLineWidth(1.0f);
            GL.glPushMatrix();

            Scale();

            //Перенос по вертикали
            double[] matrix = new double[]
            {1,0,0,0,   
               0,1,0,0,
               0,0,1,0,
               0,TransferValue/ScaleFactor,0,1};
            GL.glMultMatrixd(matrix);

            //Поворот по часовой стрелке
            Rotate(true);

            DrawFigure();

            GL.glDisable(GL.GL_POINT_SMOOTH);
            GL.glPopMatrix();
           
            GL.glLineWidth(3.0f);

            DrawCoordinates();

            GL.glFinish();
            WGL.wglSwapBuffers(DC);
        }

        private void Scale()
        {
            //Изменение масштаба по оси Y
            double[] matrix = new double[]
            {1,0,0,0,   
               0,ScaleFactor,0,0,
               0,0,1,0,
               0,0,0,1};
            GL.glMultMatrixd(matrix);
        }

        private void ViewGL_Resize(object sender, EventArgs e)
        {
            GL.glViewport(0, 0, this.ClientSize.Width, this.ClientSize.Height);
        }

        // / <summary> 
        // / Переопределение перерисовки фона для предотвращения мерцания изображения при изменении размера окна.
        // / </summary>
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            GL.glClear(GL.GL_COLOR_BUFFER_BIT);
        }
    

    }
}
