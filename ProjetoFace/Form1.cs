using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Face;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace ProjetoFace
{
   public partial class Form1 : Form
    {
        private VideoCapture capture;
        private Thread captureThread;

        private CascadeClassifier faceDetector = new CascadeClassifier("haarcascade_frontalface_default.xml");
        private int contadorImagem = 1;

        public Form1()
        {
            

            InitializeComponent();

        }

        private void SalvarImagemRosto(Image<Gray, byte> imagemRosto, int idColaborador, int contador)
        {
            string pasta = @"C:\RostosTreinamento\";

            if (!Directory.Exists(pasta))
                Directory.CreateDirectory(pasta);

            string nomeArquivo = $"{idColaborador}_{contador}.jpg";
            string caminhoCompleto = Path.Combine(pasta, nomeArquivo);

            imagemRosto.Save(caminhoCompleto);
        }

        private void Camera(int idColaborador)
        {
            // Reseta o contador de imagens
            contadorImagem = 1;

            // Captura imagens da webcam e detecta rostos
            while (true)
            {
                var img = CaptureWebcamImage();
                if (img != null)
                {
                    var gray = img.Convert<Gray, byte>();
                    var faces = faceDetector.DetectMultiScale(gray, 1.1, 10, Size.Empty);

                    foreach (var face in faces)
                    {
                        img.Draw(face, new Bgr(Color.Red), 2);
                        var imagemRosto = gray.Copy(face).Resize(100, 100, Inter.Cubic);
                        SalvarImagemRosto(imagemRosto, idColaborador, contadorImagem);
                        contadorImagem++;
                        Thread.Sleep(500);
                    }

                    pictureBox1.Image = img.ToBitmap();
                }

                Application.DoEvents();
                if (contadorImagem > 20) // Captura 20 imagens e para reconhecimento
                    break;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxId.Text) || !int.TryParse(textBoxId.Text, out int id))
            {
                MessageBox.Show("Informe um ID válido do colaborador.");
                textBoxId.Focus();
                return;
            }

            // Inicia a captura com o ID informado
            button1.Enabled = false;
            captureThread = new Thread(() => Camera(id));
            captureThread.IsBackground = true;
            captureThread.Start();

        }

        private Image<Bgr, byte> CaptureWebcamImage()
        {
            // Inicializa o VideoCapture se ainda não estiver inicializado
            if (capture == null)
            {
                capture = new VideoCapture();
            }

            // Captura um frame da webcam
            using (Mat frame = capture.QueryFrame())
            {
                if (frame == null)
                    return null;

                // Converte o frame para Image<Bgr, byte>
                return frame.ToImage<Bgr, byte>();
            }
        }

        private void btnTreinarModelo_Click(object sender, EventArgs e)
        {
            string pasta = @"C:\RostosTreinamento\";
            List<Image<Gray, byte>> imagens = new List<Image<Gray, byte>>();
            List<int> ids = new List<int>();
            btnTreinarModelo.Enabled = false;

            foreach (string arquivo in Directory.GetFiles(pasta, "*.jpg"))
            {
                // Extrai o ID do nome do arquivo (ex: 12_1.jpg → 12)
                string nome = Path.GetFileNameWithoutExtension(arquivo);
                string idTexto = nome.Split('_')[0];

                if (int.TryParse(idTexto, out int id))
                {
                    Image<Gray, byte> imagem = new Image<Gray, byte>(arquivo).Resize(100, 100, Emgu.CV.CvEnum.Inter.Cubic);
                    imagens.Add(imagem);
                    ids.Add(id);
                }
            }

            if (imagens.Count > 0)
            {
                var recognizer = new LBPHFaceRecognizer();

                // Convert List<Image<Gray, byte>> to Mat[]
                Mat[] imagensMat = imagens.Select(img => img.Mat).ToArray();
                int[] idsArray = ids.ToArray();

                recognizer.Train(imagensMat, idsArray);

                // Salva o modelo treinado
                recognizer.Write(@"C:\RostosTreinamento\modeloLBPH.yml");

                MessageBox.Show("Modelo treinado com sucesso!");
                btnTreinarModelo.Enabled = true;
            }
            else
            {
                MessageBox.Show("Nenhuma imagem encontrada para treinamento.");
            }

        }

        private void btnReconhecer_Click(object sender, EventArgs e)
        {
            var recognizer = new LBPHFaceRecognizer();
            recognizer.Read(@"C:\RostosTreinamento\modeloLBPH.yml");

            var startTime = DateTime.Now;
            var recognized = false;

            btnReconhecer.Enabled = false;

            while ((DateTime.Now - startTime).TotalSeconds < 5 && !recognized)
            {
                var img = CaptureWebcamImage();
                if (img == null)
                {
                    labelStatus.Text = "Imagem da webcam não disponível.";
                    Application.DoEvents();
                    continue;
                }

                var gray = img.Convert<Gray, byte>();
                var faces = faceDetector.DetectMultiScale(gray, 1.1, 10, Size.Empty);

                foreach (var face in faces)
                {
                    var faceImage = gray.Copy(face).Resize(100, 100, Emgu.CV.CvEnum.Inter.Cubic);
                    var result = recognizer.Predict(faceImage);

                    if (result.Label != -1 && result.Distance < 80) // Ajuste o threshold conforme necessário
                    {
                        textBoxId.Text = result.Label.ToString();
                        labelStatus.Text = $"Reconhecido: ID {result.Label} (Confiança: {result.Distance:F2})";
                        recognized = true;
                    }
                    else
                    {
                        labelStatus.Text = "Rosto não reconhecido.";
                    }

                    img.Draw(face, new Bgr(Color.Green), 2);
                }

                pictureBox1.Image = img.ToBitmap();
                Application.DoEvents();
            }

            if (!recognized)
            {
                labelStatus.Text = "Nenhum rosto reconhecido em 5 segundos.";
            }

            btnReconhecer.Enabled = true;
        }
    }


}
