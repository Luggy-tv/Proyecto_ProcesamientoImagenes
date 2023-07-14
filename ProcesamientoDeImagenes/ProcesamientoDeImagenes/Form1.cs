using AForge.Video.DirectShow;
using AForge.Video;
using Emgu.CV;
using System.Drawing.Imaging;
using System.ComponentModel.Design;

namespace ProcesamientoDeImagenes
{

    public partial class Form1 : Form
    {

        private bool hayDispositivos = false;
        private FilterInfoCollection misDispositivos;
        private VideoCaptureDevice miWebCam;
        OpenFileDialog baseImage;

        static readonly CascadeClassifier cascadeClassifier = new CascadeClassifier("haarcascade_frontalface_default.xml");

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            cerrarWebCam();
        }

        #region Imagen

        //Boton de Seleccionar imagen
        private void button1_Click(object sender, EventArgs e)
        {
            cambiarPantalla(1);

            baseImage = new OpenFileDialog() { Multiselect = false, Filter = "JPEG,PNG|*.JPG;*.PNG" };

            if (baseImage.ShowDialog() == DialogResult.OK)
            {
                comboBox_imagen.Items.Add("Tono - Rojo");
                comboBox_imagen.Items.Add("Tono - Verde");
                comboBox_imagen.Items.Add("Tono - Azul");
                comboBox_imagen.Items.Add("Negativo");
                comboBox_imagen.Items.Add("Color Slicing");
                comboBox_imagen.Items.Add("Pixeleado");
                comboBox_imagen.Items.Add("Deteccion de bordes Canny");
                comboBox_imagen.Items.Add("Viñeta");
                comboBox_imagen.Items.Add("Contraste");
                comboBox_imagen.Items.Add("Agudizacion");
                comboBox_imagen.Items.Add("Correccion de Gama");
                comboBox_imagen.Items.Add("Suavizado Gaussiano");

                pictureBox_Imagen.Image = new Bitmap(baseImage.FileName);
                actualizarHistogramas(pictureBox_Imagen, pictureBox_Imagen_Rojo, pictureBox_Imagen_Azul, pictureBox_Imagen_Verde);

            }
            else
            {
                cambiarPantalla(0);
            }

        }
        //Boton De Aplicar Filtro_AImagen
        private void button4_Click(object sender, EventArgs e)
        {
            aplicarFiltro();
            actualizarHistogramas(pictureBox_Imagen, pictureBox_Imagen_Rojo, pictureBox_Imagen_Azul, pictureBox_Imagen_Verde);
            MessageBox.Show("Se ha aplicado el filtro.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //Boton de quitar filtro de Imagen
        private void button6_Click(object sender, EventArgs e)
        {
            pictureBox_Imagen.Image = new Bitmap(baseImage.FileName);
            actualizarHistogramas(pictureBox_Imagen, pictureBox_Imagen_Rojo, pictureBox_Imagen_Azul, pictureBox_Imagen_Verde);
            MessageBox.Show("La imagen se ha restaurado a la imagen original.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //Boton de Guardar Imagen
        private void button5_Click(object sender, EventArgs e)
        {

        }
        private void aplicarFiltro()
        {

            string filtroSeleccionado = comboBox_imagen.SelectedItem.ToString();

            Bitmap imagenOriginal = (Bitmap)pictureBox_Imagen.Image;
            Bitmap imagenFiltrada;

            switch (filtroSeleccionado)
            {
                case "Tono - Rojo":
                    //AplicarFiltroTonoRojo();
                    break;
                case "Tono - Verde":
                    //AplicarFiltroTonoVerde();
                    break;
                case "Tono - Azul":
                    //AplicarFiltroTonoAzul();
                    break;
                case "Negativo":
                    //AplicarFiltroNegativo();
                    break;
                case "Color Slicing":
                    //AplicarFiltroColorSlicing();
                    break;
                case "Pixeleado":
                    //AplicarFiltroPixeleado();
                    break;
                case "Deteccion de bordes Canny":
                    //AplicarFiltroDeteccionBordesCanny();
                    break;
                case "Viñeta":
                    //AplicarFiltroVineta();
                    break;
                case "Contraste":
                    //AplicarFiltroContraste();
                    break;
                case "Agudizacion":
                    imagenFiltrada = Filtros.aplicarAgudizacion(imagenOriginal);
                    pictureBox_Imagen.Image = imagenFiltrada;
                    break;
                case "Correccion de Gama":
                    //AplicarFiltroCorreccionGama();
                    break;
                case "Suavizado Gaussiano":
                    imagenFiltrada = Filtros.aplicarDesenfoque(imagenOriginal);
                    pictureBox_Imagen.Image = imagenFiltrada;
                    break;
                default:
                    MessageBox.Show("Favor de seleccionar un filtro valido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }


        }
        //Cambio de combobox de imagen
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            string filtroSeleccionado = comboBox_imagen.SelectedItem.ToString();


            if (filtroSeleccionado == "Tono - Rojo" || filtroSeleccionado == "Tono - Verde" || filtroSeleccionado == "Tono - Azul")
            {
                trackBar1_imagen.Visible = true;
            }
            else
            {

                trackBar1_imagen.Visible = false;
            }
        }

        #endregion

        #region Video
        //Boton de Seleccionar video
        private void button2_Click(object sender, EventArgs e)
        {
            cambiarPantalla(2);

        }
        #endregion

        #region WebCam
        //Boton de abrir camara
        private void button3_Click(object sender, EventArgs e)
        {
            //cerrarWebCam();
            cambiarPantalla(3);
        }
        //Metodo para actualizar PictureBox para camara 
        private void actualizarCamara(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap imagen = (Bitmap)eventArgs.Frame.Clone();
            //Image<Rgb, Byte> grayImage = new Image<Rgb, Byte>(imagen);
            pictureBox_Camara.Image = imagen;
        }

        //Cargar Dispositivos detectados en el sistema
        private void cargarDispositivios()
        {
            misDispositivos = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            if (misDispositivos.Count > 0)
            {

                comboBox_Camara.Items.Clear();

                hayDispositivos = true;

                for (int i = 0; i < misDispositivos.Count; i++)
                {
                    comboBox_Camara.Items.Add(misDispositivos[i].Name.ToString());
                }

                comboBox_Camara.Text = misDispositivos[0].Name.ToString();

                //Cambiar esto a otro boton ya que es de la camara
                #region Cosas de Camara que hay que quitar de aqui
                cerrarWebCam();
                int j = comboBox_Camara.SelectedIndex;
                string nombreVideo = misDispositivos[j].MonikerString;

                //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

                miWebCam = new VideoCaptureDevice(nombreVideo);
                miWebCam.NewFrame += new NewFrameEventHandler(actualizarCamara);
                miWebCam.Start();

                #endregion
            }
            else
            {
                hayDispositivos = false;
            }
        }
        //Metodo para cerrar Webcam
        public void cerrarWebCam()
        {
            if (miWebCam != null && miWebCam.IsRunning)
            {
                miWebCam.SignalToStop();
                miWebCam = null;
            }
        }

        #endregion

        private void cambiarPantalla(int op)
        {
            switch (op)
            {
                //Imagen
                case 1:
                    groupBox1_Inicio.Visible = false;
                    groupBox_Camara.Visible = false;
                    groupBox_Video.Visible = false;
                    groupBox_Imagen.Visible = true;
                    cerrarWebCam();
                    break;

                //Video
                case 2:
                    groupBox1_Inicio.Visible = false;
                    groupBox_Camara.Visible = false;
                    groupBox_Imagen.Visible = false;
                    groupBox_Video.Visible = true;
                    cerrarWebCam();
                    break;

                //Camara
                case 3:
                    groupBox1_Inicio.Visible = false;
                    groupBox_Imagen.Visible = false;
                    groupBox_Video.Visible = false;
                    groupBox_Camara.Visible = true;
                    cerrarWebCam();
                    cargarDispositivios();
                    break;

                default:
                    groupBox_Imagen.Visible = false;
                    groupBox_Video.Visible = false;
                    groupBox_Camara.Visible = false;
                    groupBox1_Inicio.Visible = true;
                    break;
            }
        }
        private void button4_Inicio_Click(object sender, EventArgs e)
        {
            cambiarPantalla(0);
        }
        public void actualizarHistogramas(PictureBox pictureBoxImagen, PictureBox pBRojo, PictureBox pBAzul, PictureBox pBVerde)
        {
            Histogram histogram = new Histogram();

            int[] histogramaRojo = histogram.CalculateHistogram(Histogram.ColorChannel.Red, (Bitmap)pictureBoxImagen.Image);
            histogram.DrawHistogram(histogramaRojo, Color.Red, pBRojo);

            int[] histogramaVerde = histogram.CalculateHistogram(Histogram.ColorChannel.Green, (Bitmap)pictureBoxImagen.Image);
            histogram.DrawHistogram(histogramaVerde, Color.Green, pBVerde);

            int[] histogramaAzul = histogram.CalculateHistogram(Histogram.ColorChannel.Blue, (Bitmap)pictureBoxImagen.Image);
            histogram.DrawHistogram(histogramaAzul, Color.Blue, pBAzul);
        }

    }

    public class Filtros
    {
        public static Bitmap aplicarDesenfoque(Bitmap imagen)
        {
            int tamanoKernel = 5;
            double sigmaX = 1.5;
            double sigmaY = 1.5;

            int width = imagen.Width;
            int height = imagen.Height;
            Bitmap imagenFiltrada = new Bitmap(width, height);

            double[] kernel = generarKernel(tamanoKernel, sigmaX, sigmaY);

            BitmapData imagenData = imagen.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
            BitmapData imagenFiltradaData = imagenFiltrada.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.WriteOnly, PixelFormat.Format24bppRgb);

            int bytesPerPixel = Image.GetPixelFormatSize(PixelFormat.Format24bppRgb) / 8;
            int stride = imagenData.Stride;

            unsafe
            {
                byte* imagenPtr = (byte*)imagenData.Scan0;
                byte* imagenFiltradaPtr = (byte*)imagenFiltradaData.Scan0;

                for (int y = 0; y < height; y++)
                {
                    byte* imagenRowPtr = imagenPtr + (y * stride);
                    byte* imagenFiltradaRowPtr = imagenFiltradaPtr + (y * stride);

                    for (int x = 0; x < width; x++)
                    {
                        byte* imagenPixelPtr = imagenRowPtr + (x * bytesPerPixel);
                        byte* imagenFiltradaPixelPtr = imagenFiltradaRowPtr + (x * bytesPerPixel);

                        double r = 0, g = 0, b = 0, totalWeight = 0;

                        for (int ky = -tamanoKernel / 2; ky <= tamanoKernel / 2; ky++)
                        {
                            int offsetY = y + ky;

                            if (offsetY >= 0 && offsetY < height)
                            {
                                byte* imagenKernelRowPtr = imagenPtr + (offsetY * stride);

                                for (int kx = -tamanoKernel / 2; kx <= tamanoKernel / 2; kx++)
                                {
                                    int offsetX = x + kx;

                                    if (offsetX >= 0 && offsetX < width)
                                    {
                                        byte* imagenKernelPixelPtr = imagenKernelRowPtr + (offsetX * bytesPerPixel);
                                        double weight = kernel[kx + tamanoKernel / 2 + (ky + tamanoKernel / 2) * tamanoKernel];

                                        r += imagenKernelPixelPtr[2] * weight;
                                        g += imagenKernelPixelPtr[1] * weight;
                                        b += imagenKernelPixelPtr[0] * weight;
                                        totalWeight += weight;
                                    }
                                }
                            }
                        }

                        r /= totalWeight;
                        g /= totalWeight;
                        b /= totalWeight;

                        imagenFiltradaPixelPtr[2] = (byte)r;
                        imagenFiltradaPixelPtr[1] = (byte)g;
                        imagenFiltradaPixelPtr[0] = (byte)b;
                    }
                }
            }

            imagen.UnlockBits(imagenData);
            imagenFiltrada.UnlockBits(imagenFiltradaData);

            return imagenFiltrada;
        }
        private static double[] generarKernel(int tamanoKernel, double sigmaX, double sigmaY)
        {
            double[] kernel = new double[tamanoKernel * tamanoKernel];
            double twoSigmaXSquared = 2 * sigmaX * sigmaX;
            double twoSigmaYSquared = 2 * sigmaY * sigmaY;
            double normalizationFactor = 0;

            int halfKernelSize = tamanoKernel / 2;

            for (int y = -halfKernelSize; y <= halfKernelSize; y++)
            {
                for (int x = -halfKernelSize; x <= halfKernelSize; x++)
                {
                    double exponent = -(x * x) / twoSigmaXSquared - (y * y) / twoSigmaYSquared;
                    double weight = Math.Exp(exponent);
                    kernel[(x + halfKernelSize) + (y + halfKernelSize) * tamanoKernel] = weight;
                    normalizationFactor += weight;
                }
            }

            for (int i = 0; i < kernel.Length; i++)
            {
                kernel[i] /= normalizationFactor;
            }

            return kernel;
        }
        public static Bitmap aplicarAgudizacion(Bitmap imagen)
        {
            int[,] mascara = new int[,]
            {
        { -1, -1, -1 },
        { -1,  9, -1 },
        { -1, -1, -1 }
            };

            int ancho = imagen.Width;
            int alto = imagen.Height;
            Bitmap imagenFiltrada = new Bitmap(ancho, alto);

            BitmapData imagenData = imagen.LockBits(new Rectangle(0, 0, ancho, alto), ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
            BitmapData imagenFiltradaData = imagenFiltrada.LockBits(new Rectangle(0, 0, ancho, alto), ImageLockMode.WriteOnly, PixelFormat.Format24bppRgb);

            int bytesPerPixel = Image.GetPixelFormatSize(PixelFormat.Format24bppRgb) / 8;
            int stride = imagenData.Stride;

            unsafe
            {
                byte* imagenPtr = (byte*)imagenData.Scan0;
                byte* imagenFiltradaPtr = (byte*)imagenFiltradaData.Scan0;

                for (int y = 0; y < alto; y++)
                {
                    byte* imagenRowPtr = imagenPtr + (y * stride);
                    byte* imagenFiltradaRowPtr = imagenFiltradaPtr + (y * stride);

                    for (int x = 0; x < ancho; x++)
                    {
                        byte* imagenPixelPtr = imagenRowPtr + (x * bytesPerPixel);
                        byte* imagenFiltradaPixelPtr = imagenFiltradaRowPtr + (x * bytesPerPixel);

                        double r = 0, g = 0, b = 0;

                        for (int ky = -1; ky <= 1; ky++)
                        {
                            int offsetY = y + ky;

                            if (offsetY >= 0 && offsetY < alto)
                            {
                                byte* imagenKernelRowPtr = imagenPtr + (offsetY * stride);

                                for (int kx = -1; kx <= 1; kx++)
                                {
                                    int offsetX = x + kx;

                                    if (offsetX >= 0 && offsetX < ancho)
                                    {
                                        byte* imagenKernelPixelPtr = imagenKernelRowPtr + (offsetX * bytesPerPixel);
                                        int valorMascara = mascara[kx + 1, ky + 1];

                                        r += imagenKernelPixelPtr[2] * valorMascara;
                                        g += imagenKernelPixelPtr[1] * valorMascara;
                                        b += imagenKernelPixelPtr[0] * valorMascara;
                                    }
                                }
                            }
                        }

                        r = Math.Max(0, Math.Min(255, r));
                        g = Math.Max(0, Math.Min(255, g));
                        b = Math.Max(0, Math.Min(255, b));

                        imagenFiltradaPixelPtr[2] = (byte)r;
                        imagenFiltradaPixelPtr[1] = (byte)g;
                        imagenFiltradaPixelPtr[0] = (byte)b;
                    }
                }
            }

            imagen.UnlockBits(imagenData);
            imagenFiltrada.UnlockBits(imagenFiltradaData);

            return imagenFiltrada;
        }
        public static void aplicarTonoRojo()
        {

        }
        public static void aplicarTonoVerde()
        {

        }
        public static void aplicarTonoAzul()
        {

        }
        public static void aplicarNegativo()
        {

        }
        public static void aplicarColorSlicing()
        {

        }
        public static void aplicarPixeleado()
        {

        }
        public static void aplicarDeteccion()
        {

        }
        public static void aplicarViñeta()
        {

        }
        public static void aplicarContraste()
        {

        }
        public static void aplicarGamma()
        {

        }

    }

    public class Histogram
    {
        public enum ColorChannel
        {
            Red,
            Green,
            Blue
        }

        public int[] CalculateHistogram(ColorChannel channel, Bitmap image)
        {
            int[] histogram = new int[256];

            for (int x = 0; x < image.Width; x++)
            {
                for (int y = 0; y < image.Height; y++)
                {
                    Color pixelColor = image.GetPixel(x, y);
                    int channelValue = 0;

                    switch (channel)
                    {
                        case ColorChannel.Red:
                            channelValue = pixelColor.R;
                            break;
                        case ColorChannel.Green:
                            channelValue = pixelColor.G;
                            break;
                        case ColorChannel.Blue:
                            channelValue = pixelColor.B;
                            break;
                    }

                    histogram[channelValue]++;
                }
            }

            return histogram;
        }

        public void DrawHistogram(int[] histogram, Color color, PictureBox pictureBox)
        {
            Bitmap histogramBitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
            using (Graphics g = Graphics.FromImage(histogramBitmap))
            {
                g.Clear(Color.White);

                int maxValue = GetMaxValue(histogram);
                int barWidth = pictureBox.Width / histogram.Length;
                Brush brush = new SolidBrush(color);

                for (int i = 0; i < histogram.Length; i++)
                {
                    int barHeight = (int)((double)histogram[i] / maxValue * pictureBox.Height);
                    int x = i * barWidth;
                    int y = pictureBox.Height - barHeight;

                    Rectangle barRect = new Rectangle(x, y, barWidth, barHeight);
                    g.FillRectangle(brush, barRect);
                }
            }

            pictureBox.Image = histogramBitmap;
        }

        public int GetMaxValue(int[] values)
        {
            int max = 0;
            for (int i = 0; i < values.Length; i++)
            {
                int value = values[i];
                if (value > max)
                {
                    max = value;
                }
            }
            return max;
        }
    }


}