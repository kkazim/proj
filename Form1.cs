using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace proj
{
    public partial class main : Form
    {
        Kubik cube = new Kubik();
        Tetraedr tetrahedron = new Tetraedr();

        class Kubik 
        {
            public double[,] MatrixCube;

            public void MatrixMultiple(double[,] Obr) // умножение матриц 
            {
                double[,] res = new double[8, 4];

                res[0, 0] = MatrixCube[0, 0] * Obr[0, 0] + MatrixCube[0, 1] * Obr[1, 0] + MatrixCube[0, 2] * Obr[2, 0] + MatrixCube[0, 3] * Obr[3, 0];
                res[0, 1] = MatrixCube[0, 0] * Obr[0, 1] + MatrixCube[0, 1] * Obr[1, 1] + MatrixCube[0, 2] * Obr[2, 1] + MatrixCube[0, 3] * Obr[3, 1];
                res[0, 2] = MatrixCube[0, 0] * Obr[0, 2] + MatrixCube[0, 1] * Obr[1, 2] + MatrixCube[0, 2] * Obr[2, 2] + MatrixCube[0, 3] * Obr[3, 2];
                res[0, 3] = MatrixCube[0, 0] * Obr[0, 3] + MatrixCube[0, 1] * Obr[1, 3] + MatrixCube[0, 2] * Obr[2, 3] + MatrixCube[0, 3] * Obr[3, 3];

                res[1, 0] = MatrixCube[1, 0] * Obr[0, 0] + MatrixCube[1, 1] * Obr[1, 0] + MatrixCube[1, 2] * Obr[2, 0] + MatrixCube[1, 3] * Obr[3, 0];
                res[1, 1] = MatrixCube[1, 0] * Obr[0, 1] + MatrixCube[1, 1] * Obr[1, 1] + MatrixCube[1, 2] * Obr[2, 1] + MatrixCube[1, 3] * Obr[3, 1];
                res[1, 2] = MatrixCube[1, 0] * Obr[0, 2] + MatrixCube[1, 1] * Obr[1, 2] + MatrixCube[1, 2] * Obr[2, 2] + MatrixCube[1, 3] * Obr[3, 2];
                res[1, 3] = MatrixCube[1, 0] * Obr[0, 3] + MatrixCube[1, 1] * Obr[1, 3] + MatrixCube[1, 2] * Obr[2, 3] + MatrixCube[1, 3] * Obr[3, 3];

                res[2, 0] = MatrixCube[2, 0] * Obr[0, 0] + MatrixCube[2, 1] * Obr[1, 0] + MatrixCube[2, 2] * Obr[2, 0] + MatrixCube[2, 3] * Obr[3, 0];
                res[2, 1] = MatrixCube[2, 0] * Obr[0, 1] + MatrixCube[2, 1] * Obr[1, 1] + MatrixCube[2, 2] * Obr[2, 1] + MatrixCube[2, 3] * Obr[3, 1];
                res[2, 2] = MatrixCube[2, 0] * Obr[0, 2] + MatrixCube[2, 1] * Obr[1, 2] + MatrixCube[2, 2] * Obr[2, 2] + MatrixCube[2, 3] * Obr[3, 2];
                res[2, 3] = MatrixCube[2, 0] * Obr[0, 3] + MatrixCube[2, 1] * Obr[1, 3] + MatrixCube[2, 2] * Obr[2, 3] + MatrixCube[2, 3] * Obr[3, 3];

                res[3, 0] = MatrixCube[3, 0] * Obr[0, 0] + MatrixCube[3, 1] * Obr[1, 0] + MatrixCube[3, 2] * Obr[2, 0] + MatrixCube[3, 3] * Obr[3, 0];
                res[3, 1] = MatrixCube[3, 0] * Obr[0, 1] + MatrixCube[3, 1] * Obr[1, 1] + MatrixCube[3, 2] * Obr[2, 1] + MatrixCube[3, 3] * Obr[3, 1];
                res[3, 2] = MatrixCube[3, 0] * Obr[0, 2] + MatrixCube[3, 1] * Obr[1, 2] + MatrixCube[3, 2] * Obr[2, 2] + MatrixCube[3, 3] * Obr[3, 2];
                res[3, 3] = MatrixCube[3, 0] * Obr[0, 3] + MatrixCube[3, 1] * Obr[1, 3] + MatrixCube[3, 2] * Obr[2, 3] + MatrixCube[3, 3] * Obr[3, 3];

                res[4, 0] = MatrixCube[4, 0] * Obr[0, 0] + MatrixCube[4, 1] * Obr[1, 0] + MatrixCube[4, 2] * Obr[2, 0] + MatrixCube[4, 3] * Obr[3, 0];
                res[4, 1] = MatrixCube[4, 0] * Obr[0, 1] + MatrixCube[4, 1] * Obr[1, 1] + MatrixCube[4, 2] * Obr[2, 1] + MatrixCube[4, 3] * Obr[3, 1];
                res[4, 2] = MatrixCube[4, 0] * Obr[0, 2] + MatrixCube[4, 1] * Obr[1, 2] + MatrixCube[4, 2] * Obr[2, 2] + MatrixCube[4, 3] * Obr[3, 2];
                res[4, 3] = MatrixCube[4, 0] * Obr[0, 3] + MatrixCube[4, 1] * Obr[1, 3] + MatrixCube[4, 2] * Obr[2, 3] + MatrixCube[4, 3] * Obr[3, 3];

                res[5, 0] = MatrixCube[5, 0] * Obr[0, 0] + MatrixCube[5, 1] * Obr[1, 0] + MatrixCube[5, 2] * Obr[2, 0] + MatrixCube[5, 3] * Obr[3, 0];
                res[5, 1] = MatrixCube[5, 0] * Obr[0, 1] + MatrixCube[5, 1] * Obr[1, 1] + MatrixCube[5, 2] * Obr[2, 1] + MatrixCube[5, 3] * Obr[3, 1];
                res[5, 2] = MatrixCube[5, 0] * Obr[0, 2] + MatrixCube[5, 1] * Obr[1, 2] + MatrixCube[5, 2] * Obr[2, 2] + MatrixCube[5, 3] * Obr[3, 2];
                res[5, 3] = MatrixCube[5, 0] * Obr[0, 3] + MatrixCube[5, 1] * Obr[1, 3] + MatrixCube[5, 2] * Obr[2, 3] + MatrixCube[5, 3] * Obr[3, 3];

                res[6, 0] = MatrixCube[6, 0] * Obr[0, 0] + MatrixCube[6, 1] * Obr[1, 0] + MatrixCube[6, 2] * Obr[2, 0] + MatrixCube[6, 3] * Obr[3, 0];
                res[6, 1] = MatrixCube[6, 0] * Obr[0, 1] + MatrixCube[6, 1] * Obr[1, 1] + MatrixCube[6, 2] * Obr[2, 1] + MatrixCube[6, 3] * Obr[3, 1];
                res[6, 2] = MatrixCube[6, 0] * Obr[0, 2] + MatrixCube[6, 1] * Obr[1, 2] + MatrixCube[6, 2] * Obr[2, 2] + MatrixCube[6, 3] * Obr[3, 2];
                res[6, 3] = MatrixCube[6, 0] * Obr[0, 3] + MatrixCube[6, 1] * Obr[1, 3] + MatrixCube[6, 2] * Obr[2, 3] + MatrixCube[6, 3] * Obr[3, 3];

                res[7, 0] = MatrixCube[7, 0] * Obr[0, 0] + MatrixCube[7, 1] * Obr[1, 0] + MatrixCube[7, 2] * Obr[2, 0] + MatrixCube[7, 3] * Obr[3, 0];
                res[7, 1] = MatrixCube[7, 0] * Obr[0, 1] + MatrixCube[7, 1] * Obr[1, 1] + MatrixCube[7, 2] * Obr[2, 1] + MatrixCube[7, 3] * Obr[3, 1];
                res[7, 2] = MatrixCube[7, 0] * Obr[0, 2] + MatrixCube[7, 1] * Obr[1, 2] + MatrixCube[7, 2] * Obr[2, 2] + MatrixCube[7, 3] * Obr[3, 2];
                res[7, 3] = MatrixCube[7, 0] * Obr[0, 3] + MatrixCube[7, 1] * Obr[1, 3] + MatrixCube[7, 2] * Obr[2, 3] + MatrixCube[7, 3] * Obr[3, 3];

                MatrixCube[0, 0] = res[0, 0]; MatrixCube[0, 1] = res[0, 1]; MatrixCube[0, 2] = res[0, 2]; MatrixCube[0, 3] = res[0, 3];
                MatrixCube[1, 0] = res[1, 0]; MatrixCube[1, 1] = res[1, 1]; MatrixCube[1, 2] = res[1, 2]; MatrixCube[1, 3] = res[1, 3];
                MatrixCube[2, 0] = res[2, 0]; MatrixCube[2, 1] = res[2, 1]; MatrixCube[2, 2] = res[2, 2]; MatrixCube[2, 3] = res[2, 3];
                MatrixCube[3, 0] = res[3, 0]; MatrixCube[3, 1] = res[3, 1]; MatrixCube[3, 2] = res[3, 2]; MatrixCube[3, 3] = res[3, 3];
                MatrixCube[4, 0] = res[4, 0]; MatrixCube[4, 1] = res[4, 1]; MatrixCube[4, 2] = res[4, 2]; MatrixCube[4, 3] = res[4, 3];
                MatrixCube[5, 0] = res[5, 0]; MatrixCube[5, 1] = res[5, 1]; MatrixCube[5, 2] = res[5, 2]; MatrixCube[5, 3] = res[5, 3];
                MatrixCube[6, 0] = res[6, 0]; MatrixCube[6, 1] = res[6, 1]; MatrixCube[6, 2] = res[6, 2]; MatrixCube[6, 3] = res[6, 3];
                MatrixCube[7, 0] = res[7, 0]; MatrixCube[7, 1] = res[7, 1]; MatrixCube[7, 2] = res[7, 2]; MatrixCube[7, 3] = res[7, 3];
            }

            public void CentreCube(int l) // вернуть куб в исходное положение 
            {
                int size = l * 10;

                MatrixCube = new double[8, 4];

                MatrixCube[0, 0] = -1 * size / 2; MatrixCube[0, 1] = 1 * size / 2; MatrixCube[0, 2] = -1 * size / 2; MatrixCube[0, 3] = 1;  // A
                MatrixCube[1, 0] = -1 * size / 2; MatrixCube[1, 1] = -1 * size / 2; MatrixCube[1, 2] = -1 * size / 2; MatrixCube[1, 3] = 1; // A1
                MatrixCube[2, 0] = 1 * size / 2; MatrixCube[2, 1] = 1 * size / 2; MatrixCube[2, 2] = -1 * size / 2; MatrixCube[2, 3] = 1;   // D
                MatrixCube[3, 0] = 1 * size / 2; MatrixCube[3, 1] = -1 * size / 2; MatrixCube[3, 2] = -1 * size / 2; MatrixCube[3, 3] = 1;  // D1
                MatrixCube[4, 0] = -1 * size / 2; MatrixCube[4, 1] = 1 * size / 2; MatrixCube[4, 2] = 1 * size / 2; MatrixCube[4, 3] = 1;   // B
                MatrixCube[5, 0] = -1 * size / 2; MatrixCube[5, 1] = -1 * size / 2; MatrixCube[5, 2] = 1 * size / 2; MatrixCube[5, 3] = 1;  // B1
                MatrixCube[6, 0] = 1 * size / 2; MatrixCube[6, 1] = 1 * size / 2; MatrixCube[6, 2] = 1 * size / 2; MatrixCube[6, 3] = 1;    // C
                MatrixCube[7, 0] = 1 * size / 2; MatrixCube[7, 1] = -1 * size / 2; MatrixCube[7, 2] = 1 * size / 2; MatrixCube[7, 3] = 1;   // C1
            }

            public void DrawCube(PictureBox pictureBox) // рисовать куб 
            {
                Bitmap bmp = new Bitmap(pictureBox.Width, pictureBox.Height);
                Graphics g = Graphics.FromImage(bmp);

                Pen p = new Pen(Color.Black, 2);

                Point A = new Point((int)(MatrixCube[0, 0] + pictureBox.Width / 2), (int)(MatrixCube[0, 1] + pictureBox.Height / 2));
                Point B = new Point((int)(MatrixCube[4, 0] + pictureBox.Width / 2), (int)(MatrixCube[4, 1] + pictureBox.Height / 2));
                Point C = new Point((int)(MatrixCube[6, 0] + pictureBox.Width / 2), (int)(MatrixCube[6, 1] + pictureBox.Height / 2));
                Point D = new Point((int)(MatrixCube[2, 0] + pictureBox.Width / 2), (int)(MatrixCube[2, 1] + pictureBox.Height / 2));
                Point A1 = new Point((int)(MatrixCube[1, 0] + pictureBox.Width / 2), (int)(MatrixCube[1, 1] + pictureBox.Height / 2));
                Point B1 = new Point((int)(MatrixCube[5, 0] + pictureBox.Width / 2), (int)(MatrixCube[5, 1] + pictureBox.Height / 2));
                Point C1 = new Point((int)(MatrixCube[7, 0] + pictureBox.Width / 2), (int)(MatrixCube[7, 1] + pictureBox.Height / 2));
                Point D1 = new Point((int)(MatrixCube[3, 0] + pictureBox.Width / 2), (int)(MatrixCube[3, 1] + pictureBox.Height / 2));

                g.DrawLine(p, A, B);
                g.DrawLine(p, B, C);
                g.DrawLine(p, C, D);
                g.DrawLine(p, D, A);
                g.DrawLine(p, A, A1);
                g.DrawLine(p, B, B1);
                g.DrawLine(p, C, C1);
                g.DrawLine(p, D, D1);
                g.DrawLine(p, A1, B1);
                g.DrawLine(p, B1, C1);
                g.DrawLine(p, C1, D1);
                g.DrawLine(p, D1, A1);

                pictureBox.Image = bmp;
            }

            public void RotateCube(int X_an, int Y_an, int Z_an) // повернуть куб 
            {
                if (X_an != 0)
                {
                    double X_an_rad = X_an * Math.PI / 180;

                    double[,] rotate_X = new double[4, 4];

                    rotate_X[0, 0] = 1; rotate_X[0, 1] = 0; rotate_X[0, 2] = 0; rotate_X[0, 3] = 0;
                    rotate_X[1, 0] = 0; rotate_X[1, 1] = Math.Cos(X_an_rad); rotate_X[1, 2] = Math.Sin(X_an_rad); rotate_X[1, 3] = 0;
                    rotate_X[2, 0] = 0; rotate_X[2, 1] = -Math.Sin(X_an_rad); rotate_X[2, 2] = Math.Cos(X_an_rad); rotate_X[2, 3] = 0;
                    rotate_X[3, 0] = 0; rotate_X[3, 1] = 0; rotate_X[3, 2] = 0; rotate_X[3, 3] = 1;

                    MatrixMultiple(rotate_X);
                }

                if (Y_an != 0)
                {
                    double Y_an_rad = Y_an * Math.PI / 180;

                    double[,] rotate_Y = new double[4, 4];

                    rotate_Y[0, 0] = Math.Cos(Y_an_rad); rotate_Y[0, 1] = 0; rotate_Y[0, 2] = -Math.Sin(Y_an_rad); rotate_Y[0, 3] = 0;
                    rotate_Y[1, 0] = 0; rotate_Y[1, 1] = 1; rotate_Y[1, 2] = 0; rotate_Y[1, 3] = 0;
                    rotate_Y[2, 0] = Math.Sin(Y_an_rad); rotate_Y[2, 1] = 0; rotate_Y[2, 2] = Math.Cos(Y_an_rad); rotate_Y[2, 3] = 0;
                    rotate_Y[3, 0] = 0; rotate_Y[3, 1] = 0; rotate_Y[3, 2] = 0; rotate_Y[3, 3] = 1;

                    MatrixMultiple(rotate_Y);
                }

                if (Z_an != 0)
                {
                    double Z_an_rad = Z_an * Math.PI / 180;

                    double[,] rotate_Z = new double[4, 4];

                    rotate_Z[0, 0] = Math.Cos(Z_an_rad); rotate_Z[0, 1] = Math.Sin(Z_an_rad); rotate_Z[0, 2] = 0; rotate_Z[0, 3] = 0;
                    rotate_Z[1, 0] = -Math.Sin(Z_an_rad); rotate_Z[1, 1] = Math.Cos(Z_an_rad); rotate_Z[1, 2] = 0; rotate_Z[1, 3] = 0;
                    rotate_Z[2, 0] = 0; rotate_Z[2, 1] = 0; rotate_Z[2, 2] = 1; rotate_Z[2, 3] = 0;
                    rotate_Z[3, 0] = 0; rotate_Z[3, 1] = 0; rotate_Z[3, 2] = 0; rotate_Z[3, 3] = 1;

                    MatrixMultiple(rotate_Z);
                }
            }

            public void TransformCube(int X_len, int Y_len) // двигать куб 
            {
                MatrixCube[0, 0] += X_len;
                MatrixCube[1, 0] += X_len;
                MatrixCube[2, 0] += X_len;
                MatrixCube[3, 0] += X_len;
                MatrixCube[4, 0] += X_len;
                MatrixCube[5, 0] += X_len;
                MatrixCube[6, 0] += X_len;
                MatrixCube[7, 0] += X_len;

                MatrixCube[0, 1] += Y_len;
                MatrixCube[1, 1] += Y_len;
                MatrixCube[2, 1] += Y_len;
                MatrixCube[3, 1] += Y_len;
                MatrixCube[4, 1] += Y_len;
                MatrixCube[5, 1] += Y_len;
                MatrixCube[6, 1] += Y_len;
                MatrixCube[7, 1] += Y_len;
            }
        }

        class Tetraedr 
        {
            public double[,] MatrixTetrahedron;

            public void MatrixMultiple(double[,] Obr) // умножение матриц 
            {
                double[,] res = new double[4, 4];

                res[0, 0] = MatrixTetrahedron[0, 0] * Obr[0, 0] + MatrixTetrahedron[0, 1] * Obr[1, 0] + MatrixTetrahedron[0, 2] * Obr[2, 0] + MatrixTetrahedron[0, 3] * Obr[3, 0];
                res[0, 1] = MatrixTetrahedron[0, 0] * Obr[0, 1] + MatrixTetrahedron[0, 1] * Obr[1, 1] + MatrixTetrahedron[0, 2] * Obr[2, 1] + MatrixTetrahedron[0, 3] * Obr[3, 1];
                res[0, 2] = MatrixTetrahedron[0, 0] * Obr[0, 2] + MatrixTetrahedron[0, 1] * Obr[1, 2] + MatrixTetrahedron[0, 2] * Obr[2, 2] + MatrixTetrahedron[0, 3] * Obr[3, 2];
                res[0, 3] = MatrixTetrahedron[0, 0] * Obr[0, 3] + MatrixTetrahedron[0, 1] * Obr[1, 3] + MatrixTetrahedron[0, 2] * Obr[2, 3] + MatrixTetrahedron[0, 3] * Obr[3, 3];

                res[1, 0] = MatrixTetrahedron[1, 0] * Obr[0, 0] + MatrixTetrahedron[1, 1] * Obr[1, 0] + MatrixTetrahedron[1, 2] * Obr[2, 0] + MatrixTetrahedron[1, 3] * Obr[3, 0];
                res[1, 1] = MatrixTetrahedron[1, 0] * Obr[0, 1] + MatrixTetrahedron[1, 1] * Obr[1, 1] + MatrixTetrahedron[1, 2] * Obr[2, 1] + MatrixTetrahedron[1, 3] * Obr[3, 1];
                res[1, 2] = MatrixTetrahedron[1, 0] * Obr[0, 2] + MatrixTetrahedron[1, 1] * Obr[1, 2] + MatrixTetrahedron[1, 2] * Obr[2, 2] + MatrixTetrahedron[1, 3] * Obr[3, 2];
                res[1, 3] = MatrixTetrahedron[1, 0] * Obr[0, 3] + MatrixTetrahedron[1, 1] * Obr[1, 3] + MatrixTetrahedron[1, 2] * Obr[2, 3] + MatrixTetrahedron[1, 3] * Obr[3, 3];

                res[2, 0] = MatrixTetrahedron[2, 0] * Obr[0, 0] + MatrixTetrahedron[2, 1] * Obr[1, 0] + MatrixTetrahedron[2, 2] * Obr[2, 0] + MatrixTetrahedron[2, 3] * Obr[3, 0];
                res[2, 1] = MatrixTetrahedron[2, 0] * Obr[0, 1] + MatrixTetrahedron[2, 1] * Obr[1, 1] + MatrixTetrahedron[2, 2] * Obr[2, 1] + MatrixTetrahedron[2, 3] * Obr[3, 1];
                res[2, 2] = MatrixTetrahedron[2, 0] * Obr[0, 2] + MatrixTetrahedron[2, 1] * Obr[1, 2] + MatrixTetrahedron[2, 2] * Obr[2, 2] + MatrixTetrahedron[2, 3] * Obr[3, 2];
                res[2, 3] = MatrixTetrahedron[2, 0] * Obr[0, 3] + MatrixTetrahedron[2, 1] * Obr[1, 3] + MatrixTetrahedron[2, 2] * Obr[2, 3] + MatrixTetrahedron[2, 3] * Obr[3, 3];

                res[3, 0] = MatrixTetrahedron[3, 0] * Obr[0, 0] + MatrixTetrahedron[3, 1] * Obr[1, 0] + MatrixTetrahedron[3, 2] * Obr[2, 0] + MatrixTetrahedron[3, 3] * Obr[3, 0];
                res[3, 1] = MatrixTetrahedron[3, 0] * Obr[0, 1] + MatrixTetrahedron[3, 1] * Obr[1, 1] + MatrixTetrahedron[3, 2] * Obr[2, 1] + MatrixTetrahedron[3, 3] * Obr[3, 1];
                res[3, 2] = MatrixTetrahedron[3, 0] * Obr[0, 2] + MatrixTetrahedron[3, 1] * Obr[1, 2] + MatrixTetrahedron[3, 2] * Obr[2, 2] + MatrixTetrahedron[3, 3] * Obr[3, 2];
                res[3, 3] = MatrixTetrahedron[3, 0] * Obr[0, 3] + MatrixTetrahedron[3, 1] * Obr[1, 3] + MatrixTetrahedron[3, 2] * Obr[2, 3] + MatrixTetrahedron[3, 3] * Obr[3, 3];

                MatrixTetrahedron[0, 0] = res[0, 0]; MatrixTetrahedron[0, 1] = res[0, 1]; MatrixTetrahedron[0, 2] = res[0, 2]; MatrixTetrahedron[0, 3] = res[0, 3];
                MatrixTetrahedron[1, 0] = res[1, 0]; MatrixTetrahedron[1, 1] = res[1, 1]; MatrixTetrahedron[1, 2] = res[1, 2]; MatrixTetrahedron[1, 3] = res[1, 3];
                MatrixTetrahedron[2, 0] = res[2, 0]; MatrixTetrahedron[2, 1] = res[2, 1]; MatrixTetrahedron[2, 2] = res[2, 2]; MatrixTetrahedron[2, 3] = res[2, 3];
                MatrixTetrahedron[3, 0] = res[3, 0]; MatrixTetrahedron[3, 1] = res[3, 1]; MatrixTetrahedron[3, 2] = res[3, 2]; MatrixTetrahedron[3, 3] = res[3, 3];
            }

            public void CentreTetrahedron(int l) // вернуть тетраэдр в исходное положение 
            {
                int size = l * 10;

                MatrixTetrahedron = new double[4, 4];

                MatrixTetrahedron[0, 0] = -1 * size / 2; MatrixTetrahedron[0, 1] = -1 * size / 2; MatrixTetrahedron[0, 2] = 1 * size / 2; MatrixTetrahedron[0, 3] = 1;  // S
                MatrixTetrahedron[1, 0] = -1 * size / 2; MatrixTetrahedron[1, 1] = 1 * size / 2; MatrixTetrahedron[1, 2] = -1 * size / 2; MatrixTetrahedron[1, 3] = 1;  // A
                MatrixTetrahedron[2, 0] = 1 * size / 2; MatrixTetrahedron[2, 1] = 1 * size / 2; MatrixTetrahedron[2, 2] = 1 * size / 2; MatrixTetrahedron[2, 3] = 1;    // B
                MatrixTetrahedron[3, 0] = 1 * size / 2; MatrixTetrahedron[3, 1] = -1 * size / 2; MatrixTetrahedron[3, 2] = -1 * size / 2; MatrixTetrahedron[3, 3] = 1;  // C
            }

            public void DrawTetrahedron(PictureBox pictureBox) // рисовать тетраэдр 
            {
                Bitmap bmp = new Bitmap(pictureBox.Width, pictureBox.Height);
                Graphics g = Graphics.FromImage(bmp);

                Pen p = new Pen(Color.Black, 2);
                Brush brush1 = new SolidBrush(Color.Green);
                Brush brush2 = new SolidBrush(Color.Red);
                Brush brush3 = new SolidBrush(Color.Blue);
                Brush brush4 = new SolidBrush(Color.Orange);

                Point S = new Point((int)(MatrixTetrahedron[0, 0] + pictureBox.Width / 2), (int)(MatrixTetrahedron[0, 1] + pictureBox.Height / 2));
                Point A = new Point((int)(MatrixTetrahedron[1, 0] + pictureBox.Width / 2), (int)(MatrixTetrahedron[1, 1] + pictureBox.Height / 2));
                Point B = new Point((int)(MatrixTetrahedron[2, 0] + pictureBox.Width / 2), (int)(MatrixTetrahedron[2, 1] + pictureBox.Height / 2));
                Point C = new Point((int)(MatrixTetrahedron[3, 0] + pictureBox.Width / 2), (int)(MatrixTetrahedron[3, 1] + pictureBox.Height / 2));

                g.DrawLine(p, A, B);
                g.DrawLine(p, B, C);
                g.DrawLine(p, C, A);
                g.DrawLine(p, S, A);
                g.DrawLine(p, S, B);
                g.DrawLine(p, S, C);
                
                pictureBox.Image = bmp;
            }

            public void RotateTetrahedron(int X_an, int Y_an, int Z_an) // повернуть тетраэдр 
            {
                if (X_an != 0)
                {
                    double X_an_rad = X_an * Math.PI / 180;

                    double[,] rotate_X = { { 1, 0, 0, 0 },
                         { 0, Math.Cos(X_an_rad), Math.Sin(X_an_rad), 0 },
                         { 0, - Math.Sin(X_an_rad), Math.Cos(X_an_rad), 0 },
                         { 0, 0, 0, 1 } };

                    MatrixMultiple(rotate_X);
                }

                if (Y_an != 0)
                {
                    double Y_an_rad = Y_an * Math.PI / 180;

                    double[,] rotate_Y = { { Math.Cos(Y_an_rad), 0, - Math.Sin(Y_an_rad), 0 },
                         { 0, 1, 0, 0 },
                         { Math.Sin(Y_an_rad), 0, Math.Cos(Y_an_rad), 0 },
                         { 0, 0, 0, 1 } };

                    MatrixMultiple(rotate_Y);
                }

                if (Z_an != 0)
                {
                    double Z_an_rad = Z_an * Math.PI / 180;

                    double[,] rotate_Z = { { Math.Cos(Z_an_rad), Math.Sin(Z_an_rad), 0 , 0 },
                         { - Math.Sin(Z_an_rad), Math.Cos(Z_an_rad), 0, 0 },
                         { 0, 0, 1, 0 },
                         { 0, 0, 0, 1 } };

                    MatrixMultiple(rotate_Z);
                }
            }

            public void TransformTetrahedron(int X_len, int Y_len) // двигать тетраэдр 
            {
                MatrixTetrahedron[0, 1] += X_len;
                MatrixTetrahedron[1, 1] += X_len;
                MatrixTetrahedron[2, 1] += X_len;
                MatrixTetrahedron[3, 1] += X_len;

                MatrixTetrahedron[0, 1] += Y_len;
                MatrixTetrahedron[1, 1] += Y_len;
                MatrixTetrahedron[2, 1] += Y_len;
                MatrixTetrahedron[3, 1] += Y_len;
            }
        }

        public main() 
        {
            InitializeComponent();
        }

        private void ClearDraw() // очистить поля чертежа 
        {
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height); // присвоить pictureBox пустой Bitmap
            pictureBox1.Image= bmp;
        }

        private void mathem() // расчет основных характеристик 
        {
            int l = Convert.ToInt32(textBox1.Text);
            double value = 0;
            double square = 0;

            if (Cube_radio.Checked == true)
            {
                value = (l * l * l);
                square = (6 * l * l);
            }

            if (Tetrahedron_radio.Checked == true)
            {
                value = (l * l * l * 1.4 / 12);
                square = (l * l * 1.7);
            }

            textBox2.Text = value.ToString();
            textBox3.Text = square.ToString();
        }

        private void Exit_Click(object sender, EventArgs e) // закрыть форму 
        {
            Close();
        }

        private void OnRight_Click(object sender, EventArgs e) // двигать вправо 
        {
            ClearDraw();

            if (Cube_radio.Checked == true)
            {
                cube.TransformCube(5, 0);
                cube.DrawCube(pictureBox1);
            }

            if (Tetrahedron_radio.Checked == true)
            {
                tetrahedron.TransformTetrahedron(5, 0);
                tetrahedron.DrawTetrahedron(pictureBox1);
            }
        }

        private void OnLeft_Click(object sender, EventArgs e) // двигать влево 
        {
            ClearDraw();

            if (Cube_radio.Checked == true)
            {
                cube.TransformCube(-5, 0);
                cube.DrawCube(pictureBox1);
            }

            if (Tetrahedron_radio.Checked == true)
            {
                tetrahedron.TransformTetrahedron(-5, 0);
                tetrahedron.DrawTetrahedron(pictureBox1);
            }
        }

        private void Up_Click(object sender, EventArgs e) // двигать вверх 
        {
            ClearDraw();

            if (Cube_radio.Checked == true)
            {
                cube.TransformCube(0, -5);
                cube.DrawCube(pictureBox1);
            }

            if (Tetrahedron_radio.Checked == true)
            {
                tetrahedron.TransformTetrahedron(0, -5);
                tetrahedron.DrawTetrahedron(pictureBox1);
            }
        }

        private void Down_Click(object sender, EventArgs e) // двигать вниз 
        {
            ClearDraw();

            if (Cube_radio.Checked == true)
            {
                cube.TransformCube(0, 5);
                cube.DrawCube(pictureBox1);
            }

            if (Tetrahedron_radio.Checked == true)
            {
                tetrahedron.TransformTetrahedron(0, 5);
                tetrahedron.DrawTetrahedron(pictureBox1);
            }
        }

        private void dvizh_Click(object sender, EventArgs e) // двигать по вектору 
        {
            int X_vec = Convert.ToInt32(X_vector.Text);
            int Y_vec = - Convert.ToInt32(Y_vector.Text);

            ClearDraw();

            if (Cube_radio.Checked == true)
            {
                cube.TransformCube(X_vec, Y_vec);
                cube.DrawCube(pictureBox1);
            }

            if (Tetrahedron_radio.Checked == true)
            {
                tetrahedron.TransformTetrahedron(X_vec, Y_vec);
                tetrahedron.DrawTetrahedron(pictureBox1);
            }
        }

        private void Rotation_Click(object sender, EventArgs e) // повернуть на угол 
        {
            int X_an;
            int Y_an;
            int Z_an;

            if (X_angle.Text == "")
            {
                X_an = 0;
            }
            else
            {
                X_an = Convert.ToInt32(X_angle.Text);
            }

            if (Y_angle.Text == "")
            {
                Y_an = 0;
            }
            else
            {
                Y_an = Convert.ToInt32(Y_angle.Text);
            }

            if (Z_angle.Text == "")
            {
                Z_an = 0;
            }
            else
            {
                Z_an = Convert.ToInt32(Z_angle.Text);
            }

            ClearDraw();

            if (Cube_radio.Checked == true)
            {
                cube.RotateCube(X_an, Y_an, Z_an);
                cube.DrawCube(pictureBox1);
            }

            if (Tetrahedron_radio.Checked == true) 
            {
                tetrahedron.RotateTetrahedron(X_an, Y_an, Z_an);
                tetrahedron.DrawTetrahedron(pictureBox1);
            }
        }

        private void Empty_radio_CheckedChanged(object sender, EventArgs e) 
        {
            ClearDraw();
            mathem();
        }

        private void Cube_radio_CheckedChanged(object sender, EventArgs e) 
        {
            ClearDraw();
            int l = Convert.ToInt32(textBox1.Text);
            cube.CentreCube(l);
            cube.DrawCube(pictureBox1);
            mathem();
        }

        private void Tetrahedron_radio_CheckedChanged(object sender, EventArgs e) 
        {
            ClearDraw();
            int l = Convert.ToInt32(textBox1.Text);
            tetrahedron.CentreTetrahedron(l);
            tetrahedron.DrawTetrahedron(pictureBox1);
            mathem();
        }

        private void Tetrahedron_radio_Click(object sender, EventArgs e) 
        {
            ClearDraw();
            int l = Convert.ToInt32(textBox1.Text);
            tetrahedron.CentreTetrahedron(l);
            tetrahedron.DrawTetrahedron(pictureBox1);
        }

        private void Cube_radio_Click(object sender, EventArgs e) 
        {
            ClearDraw();
            int l = Convert.ToInt32(textBox1.Text);
            cube.CentreCube(l);
            cube.DrawCube(pictureBox1);
        }

        private void Empty_radio_Click(object sender, EventArgs e) 
        {
            ClearDraw();
        }

        private void izom_Click(object sender, EventArgs e) 
        {
            ClearDraw();

            if (Cube_radio.Checked == true)
            {
                int l = Convert.ToInt32(textBox1.Text);
                cube.CentreCube(l);
                cube.RotateCube(0, 45, 0);
                cube.RotateCube(30, 0, 0);
                cube.DrawCube(pictureBox1);
            }

            if (Tetrahedron_radio.Checked == true)
            {
                int l = Convert.ToInt32(textBox1.Text);
                tetrahedron.CentreTetrahedron(l);
                tetrahedron.RotateTetrahedron(0, 0, 45);
                tetrahedron.RotateTetrahedron(120, 0, 0);
                tetrahedron.DrawTetrahedron(pictureBox1);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e) 
        {
            mathem();
            int l = Convert.ToInt32(textBox1.Text);

            if (Cube_radio.Checked == true)
            {
                cube.CentreCube(l);
                cube.DrawCube(pictureBox1);
            }

            if (Tetrahedron_radio.Checked == true)
            {
                tetrahedron.CentreTetrahedron(l);
                tetrahedron.DrawTetrahedron(pictureBox1);
            }
        }
    }
}