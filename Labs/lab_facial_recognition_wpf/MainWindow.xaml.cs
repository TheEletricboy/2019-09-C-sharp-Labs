using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using System.IO;
using Application = System.Windows.Forms.Application;
using MessageBox = System.Windows.Forms.MessageBox;
using System.Drawing;

namespace lab_facial_recognition_wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {



        //declaring variables to use them in the project
        SolidColorBrush greenBrush = new SolidColorBrush(Colors.Green);

        MCvFont font = new MCvFont(Emgu.CV.CvEnum.FONT.CV_FONT_HERSHEY_TRIPLEX, 0.6d, 0.6d);
        HaarCascade faceDetected;
        Image<Bgr, byte> Frame;
        Capture camera;
        Image<Gray, byte> result;
        Image<Gray, byte> TrainedFace = null;
        Image<Gray, byte> grayFace = null;
        List<Image<Gray, byte>> trainingImages = new List<Image<Gray, byte>>();
        List<string> labels = new List<string>();
        List<string> Users = new List<string>();
        int Count, NumLables, t;
        string name, names = null;

        

        private void start_Click_1(object sender, RoutedEventArgs e)
        {
            camera = new Capture();
            camera.QueryFrame();
            Application.Idle += new EventHandler(FrameProcedure);
        }

        public MainWindow()
        {
            InitializeComponent();


            
            //haarcascade is for face detection
            faceDetected = new HaarCascade("haarcascade_frontalface_default.xml");
            try
            {
                string Labelsinf = File.ReadAllText(Application.StartupPath + "/Faces/Faces.txt");
                string[] Labels = Labelsinf.Split(',');
                //the first label before ',' will be the number of faces saved.
                NumLables = Convert.ToInt16(Labels[0]);
                Count = NumLables;
                string FacesLoad;
                for (int i = 1; i < NumLables + 1; i++)
                {
                    FacesLoad = "face" + i + ".bmp";
                    trainingImages.Add(new Image<Gray, byte>(Application.StartupPath + $"/Faces/{FacesLoad}"));
                    labels.Add(Labels[i]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No match in the Database");
                //throw;
            }
        }

        private void cam_winform_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void FrameProcedure(object sender, EventArgs e)
        {
            Users.Add("");
            Frame = camera.QueryFrame().Resize(320, 240, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
            grayFace = Frame.Convert<Gray, Byte>();
            MCvAvgComp[][] facesDetectedNow = grayFace.DetectHaarCascade(faceDetected, 1.2, 10, Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING, new System.Drawing.Size(20, 20));
            foreach (MCvAvgComp f in facesDetectedNow[0])
            {
                result = Frame.Copy(f.rect).Convert<Gray, Byte>().Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
                Frame.Draw(f.rect, new Bgr(0, 255, 0), 3);
                if (trainingImages.ToArray().Length != 0)
                {
                    MCvTermCriteria termCriterias = new MCvTermCriteria(Count, 0.001);
                    EigenObjectRecognizer recognizer = new EigenObjectRecognizer(trainingImages.ToArray(), labels.ToArray(), 1500, ref termCriterias);
                    name = recognizer.Recognize(result);
                    Frame.Draw(name, ref font, new System.Drawing.Point(2, 2), new Bgr(0, 0, 255));

                }
                //Users[t - 1] = name;
                Users.Add("");
            }

            cameraBox.Image = Frame;
            names = "";
            Users.Clear();


        }
    }
}
