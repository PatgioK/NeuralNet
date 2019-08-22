using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeuralNetwork
{
    public partial class Form1 : Form
    {
        private Core.NeuralNet network;
        private int numberToDraw;
        private int totalDrawn = 0;
        private int correctDrawn = 0;

        public void StartNewMNISTNetwork()
        {
            Service.MNISTLoader loader;
            Service.MNISTLoader testLoader;
            LoadMNISTDataset(out loader, out testLoader);
            List<int> size = new List<int> { 784, 30, 10 };
            network = new Core.NeuralNet(size);
            network.SGD(loader.Data, 2, 10, 3.0, testLoader.Data);
        }
        

        private void LoadMNISTDataset(out Service.MNISTLoader loader, out Service.MNISTLoader testLoader)
        {
            loader = new Service.MNISTLoader("C:/Users/patgi/source/repos/NeuralNet4932/train-images.idx3-ubyte", "C:/Users/patgi/source/repos/NeuralNet4932/train-labels.idx1-ubyte");
            loader.Load();
            testLoader = new Service.MNISTLoader("C:/Users/patgi/source/repos/NeuralNet4932/t10k-images.idx3-ubyte", "C:/Users/patgi/source/repos/NeuralNet4932/t10k-labels.idx1-ubyte");
            testLoader.Load();
        }

        

        public Form1()
        {
            InitializeComponent();
            numberToDraw = Core.NeuralRandom.Instance.GetRandom();
            numToDrawLabel.Text = numberToDraw.ToString();
            
            StartNewMNISTNetwork();
            
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (network != null)
            {
                double[,] expected = Service.MNISTLoader.IntToVector(numberToDraw);
                int guess = 0;
                bool evaluated = network.EvaluateDrawn(Tuple.Create(drawPanel.GetImageData(), expected), out guess);

                //Graphics g = panel1.CreateGraphics();
                //g.Clear(SystemColors.ControlLightLight);
                //g.DrawImage(new Bitmap(drawPanel.scaledImage, 28, 28), Point.Empty);

                totalDrawn++;
                if (evaluated)
                {
                    correctDrawn++;
                }

                prevGuessLabel.Text = "Previous Guess: " + guess;

                correctLabel.Text = "";

                numberToDraw = Core.NeuralRandom.Instance.GetRandom();
                //drawPanelLabel.Text = "Next number: " +  numberToDraw.ToString();
            }
            Focus();
            drawPanel.ClearPanel();
        }

       

        private void clearButton_Click(object sender, EventArgs e)
        {
            drawPanel.ClearPanel();
        }
    }
}
