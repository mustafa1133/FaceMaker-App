using Face_Interface;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FaceAppForm
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();


            cbxLE.DataSource = new object[] {"Red", "Green", "Blue", "Yellow","Brown","White","Black","Wheat","Orange","Indigo","Violet"};
            cbxRE.DataSource = new object[] { "Red", "Green", "Blue", "Yellow", "Brown", "White", "Black", "Wheat", "Orange", "Indigo", "Violet" };
            cbxF.DataSource= new object[] { "Red", "Green", "Blue", "Yellow", "Brown", "White", "Black", "Wheat", "Orange", "Indigo", "Violet" };
            cbxLEYE.DataSource= new object[] { "Red", "Green", "Blue", "Yellow", "Brown", "White", "Black", "Wheat", "Orange", "Indigo", "Violet" };
            cbxREYE.DataSource= new object[] { "Red", "Green", "Blue", "Yellow", "Brown", "White", "Black", "Wheat", "Orange", "Indigo", "Violet" };
            cbxLP.DataSource= new object[] { "Red", "Green", "Blue", "Yellow", "Brown", "White", "Black", "Wheat", "Orange", "Indigo", "Violet" };
            cbxRP.DataSource= new object[] { "Red", "Green", "Blue", "Yellow", "Brown", "White", "Black", "Wheat", "Orange", "Indigo", "Violet" };
            cbxL.DataSource= new object[] { "Red", "Green", "Blue", "Yellow", "Brown", "White", "Black", "Wheat", "Orange", "Indigo", "Violet" };
            cbxM.DataSource= new object[] { "Red", "Green", "Blue", "Yellow", "Brown", "White", "Black", "Wheat", "Orange", "Indigo", "Violet" };


        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            List<IDrawable> face = new List<IDrawable>();
            face.Add(new DrawableEllipse(Color.FromName(cbxLE.Text), cbLE.Checked, new Rectangle((int)nudLEX.Value,(int) nudLEY.Value, (int) nudLEW.Value, (int) nudLEH.Value)));      //left ear
            face.Add(new DrawableEllipse(Color.FromName(cbxRE.Text), cbRE.Checked, new Rectangle((int)nudREX.Value, (int)nudREY.Value, (int)nudREW.Value, (int)nudREH.Value)));     //right ear
            face.Add(new DrawableRectangle(Color.FromName(cbxF.Text), cbF.Checked, new Rectangle((int)nudFX.Value, (int)nudFY.Value, (int)nudFW.Value, (int)nudFH.Value))); //face
            face.Add(new DrawableRectangle(Color.FromName(cbxLEYE.Text), cbREYE.Checked, new Rectangle((int)nudREYEX.Value, (int)nudREYEY.Value,(int) nudREYEW.Value,(int) nudREYEH.Value)));    //right eye
            face.Add(new DrawableRectangle(Color.FromName(cbxREYE.Text), cbLEYE.Checked, new Rectangle((int)nudLEYEX.Value, (int)nudLEYEY.Value, (int)nudLEYEW.Value,(int)nudLEYEH.Value)));    //left eye
            face.Add(new DrawableRectangle(Color.FromName(cbxLP.Text), cbRP.Checked, new Rectangle((int)nudRPX.Value, (int)nudRPY.Value, (int)nudRPW.Value, (int)nudRPH.Value)));    //right pupil
            face.Add(new DrawableRectangle(Color.FromName(cbxRP.Text), cbLP.Checked, new Rectangle((int)nudLPX.Value ,(int)nudLPY.Value, (int)nudLPW.Value, (int)nudLPH.Value)));    //left pupil
            face.Add(new DrawableBezier(Color.Black, new Point(195, 240), new Point(135, 280), new Point(275, 280), new Point(215, 240)));
            face.Add(new DrawableEllipse(Color.FromName(cbxL.Text), cbL.Checked, new Rectangle((int)nudLX.Value, (int)nudLY.Value, (int)nudLW.Value, (int)nudLH.Value)));      //lips
            face.Add(new DrawableEllipse(Color.FromName(cbxM.Text), cbM.Checked, new Rectangle((int)nudMX.Value, (int)nudMY.Value, (int)nudMW.Value,(int)nudMH.Value)));      //mouth
                                                                                                 

            int width = 400, length = 450;
            Bitmap bmp = new Bitmap(width, length);
            Graphics g = Graphics.FromImage(bmp);
            foreach (var item in face)
            {
                item.Draw(g);
                if (item is IWritable)
                {
                    ((IWritable)item).Write(System.Console.Out);
                }
            }

            g.Dispose();
            bmp.Save("face.png", ImageFormat.Png);
            bmp.Dispose();
            MessageBox.Show("Face Created!");

        }
    }


}
