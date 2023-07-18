using AForge.Video.DirectShow;
using AForge.Video;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using Emgu.CV;
using Emgu.CV.Structure;

namespace ProcesamientoDeImagenes
{
    public partial class Form1 : Form
    {

        private bool hayDispositivos = false;
        private FilterInfoCollection misDispositivos;
        private VideoCaptureDevice miWebCam;

        OpenFileDialog baseImage;

        OpenFileDialog baseVideo;

        static readonly CascadeClassifier cascadeClassifier = new CascadeClassifier("haarcascade_frontalface_alt_tree.xml");

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
                comboBox_imagen.Items.Clear();
                comboBox_imagen.Items.Add("Tono - Rojo");
                comboBox_imagen.Items.Add("Tono - Verde");
                comboBox_imagen.Items.Add("Tono - Azul");
                comboBox_imagen.Items.Add("Negativo");
                comboBox_imagen.Items.Add("Aberracion Cromatica");
                comboBox_imagen.Items.Add("Pixeleado");
                comboBox_imagen.Items.Add("Color Slicing");
                comboBox_imagen.Items.Add("Viñeta");
                comboBox_imagen.Items.Add("Contraste");
                comboBox_imagen.Items.Add("Agudizacion");
                comboBox_imagen.Items.Add("Correccion de Gama");
                comboBox_imagen.Items.Add("Suavizado Gaussiano");

                comboBox_imagen.SelectedIndex = 0;

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
            //MessageBox.Show("Valor del trackbar = ."+trackBar1_imagen.Value, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string fileName = "Imagen_" + Path.GetRandomFileName();
            string filePath = Path.Combine(desktopPath, fileName + ".jpg");

            Bitmap image = (Bitmap)pictureBox_Imagen.Image;
            image.Save(filePath, ImageFormat.Jpeg);

            MessageBox.Show("La imagen se ha guardado en el escritorio.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void aplicarFiltro()
        {

            string filtroSeleccionado = comboBox_imagen.SelectedItem.ToString();

            Bitmap imagenOriginal = (Bitmap)pictureBox_Imagen.Image;
            Bitmap imagenFiltrada;
            int valorTono;
            byte[] newByte = { 1, 1, 1 };

            switch (filtroSeleccionado)
            {

                case "Tono - Rojo":
                    valorTono = trackBar1_imagen.Value;
                    imagenFiltrada = Filtros.aplicarTonoRojo(imagenOriginal, valorTono);
                    pictureBox_Imagen.Image = imagenFiltrada;
                    break;
                case "Tono - Verde":
                    valorTono = trackBar1_imagen.Value;
                    imagenFiltrada = Filtros.aplicarTonoVerde(imagenOriginal, valorTono);
                    pictureBox_Imagen.Image = imagenFiltrada;
                    break;
                case "Tono - Azul":
                    valorTono = trackBar1_imagen.Value;
                    imagenFiltrada = Filtros.aplicarTonoAzul(imagenOriginal, valorTono);
                    pictureBox_Imagen.Image = imagenFiltrada;
                    break;
                case "Negativo":
                    imagenFiltrada = Filtros.aplicarNegativo(imagenOriginal);
                    pictureBox_Imagen.Image = imagenFiltrada;
                    break;
                case "Aberracion Cromatica":
                    imagenFiltrada = Filtros.aplicarAberracion(imagenOriginal, 10);
                    pictureBox_Imagen.Image = imagenFiltrada;
                    break;
                case "Pixeleado":
                    imagenFiltrada = Filtros.aplicarPixeleado(imagenOriginal);
                    pictureBox_Imagen.Image = imagenFiltrada;
                    break;
                case "Color Slicing":
                    imagenFiltrada = Filtros.ColorSlice(imagenOriginal, newByte, 50);
                    pictureBox_Imagen.Image = imagenFiltrada;
                    break;
                case "Viñeta":
                    imagenFiltrada = Filtros.aplicarViñeta(imagenOriginal);
                    pictureBox_Imagen.Image = imagenFiltrada;
                    break;
                case "Contraste":
                    imagenFiltrada = Filtros.aplicarContraste(imagenOriginal, 1.5);
                    pictureBox_Imagen.Image = imagenFiltrada;
                    break;
                case "Agudizacion":
                    imagenFiltrada = Filtros.aplicarAgudizacion(imagenOriginal);
                    pictureBox_Imagen.Image = imagenFiltrada;
                    break;
                case "Correccion de Gama":
                    imagenFiltrada = Filtros.aplicarGamma(imagenOriginal, 1.5);
                    pictureBox_Imagen.Image = imagenFiltrada;
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

            baseVideo = new OpenFileDialog() { Multiselect = false, Filter = "Files (.mp4)|*.mp4" };

            if (baseVideo.ShowDialog() == DialogResult.OK)
            {

            }
            else
            {
                cambiarPantalla(0);
            }

        }
        #endregion

        #region WebCam
        //Boton de abrir camara
        private void button3_Click(object sender, EventArgs e)
        {
            cambiarPantalla(3);
        }
        //Metodo para actualizar PictureBox para camara 
        private void actualizarCamara(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap imagen = (Bitmap)eventArgs.Frame.Clone();

            Image<Bgr, byte> greayimage = imagen.ToImage<Bgr, byte>();

            Rectangle[] rectangles = cascadeClassifier.DetectMultiScale(greayimage, 1.2, 1);
            if (rectangles.Length > 0)
            {
                foreach (Rectangle rectangle in rectangles)
                {
                    using (Graphics graphics = Graphics.FromImage(imagen))
                    {
                        using (Pen pen = new Pen(Color.Red, 1))
                        {
                            graphics.DrawRectangle(pen, rectangle);
                        }
                    }
                }
            }
            pictureBox_Camara.Image = imagen;
        }
        private void comboBox_Cam_SelectedIndexChanges(object sender, EventArgs e)
        {

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
                    cerrarWebCam();
                    groupBox1_Inicio.Visible = false;
                    groupBox_Camara.Visible = false;
                    groupBox_Imagen.Visible = false;
                    groupBox_Video.Visible = true;
                    break;
                //Camara
                case 3:
                    cerrarWebCam();
                    cargarDispositivios();
                    groupBox1_Inicio.Visible = false;
                    groupBox_Imagen.Visible = false;
                    groupBox_Video.Visible = false;
                    groupBox_Camara.Visible = true;
                    break;
                default:
                    cerrarWebCam();
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
        public static double[] generarKernel(int tamanoKernel, double sigmaX, double sigmaY)
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
        public static Bitmap aplicarTonoRojo(Bitmap imagen, int tonoRojo)
        {
            Bitmap imagenFiltrada = new Bitmap(imagen);


            for (int x = 0; x < imagen.Width; x++)
            {
                for (int y = 0; y < imagen.Height; y++)
                {
                    Color pixel = imagen.GetPixel(x, y);

                    int r = pixel.R;
                    int g = pixel.G;
                    int b = pixel.B;

                    r += tonoRojo;

                    r = Math.Max(0, Math.Min(255, r));

                    Color nuevoPixel = Color.FromArgb(r, g, b);

                    imagenFiltrada.SetPixel(x, y, nuevoPixel);
                }
            }

            return imagenFiltrada;
        }
        public static Bitmap aplicarTonoVerde(Bitmap imagen, int tonoVerde)
        {
            Bitmap imagenFiltrada = new Bitmap(imagen);


            for (int x = 0; x < imagen.Width; x++)
            {
                for (int y = 0; y < imagen.Height; y++)
                {
                    Color pixel = imagen.GetPixel(x, y);

                    int r = pixel.R;
                    int g = pixel.G;
                    int b = pixel.B;

                    g += tonoVerde;

                    g = Math.Max(0, Math.Min(255, r));

                    Color nuevoPixel = Color.FromArgb(r, g, b);

                    imagenFiltrada.SetPixel(x, y, nuevoPixel);
                }
            }

            return imagenFiltrada;
        }
        public static Bitmap aplicarTonoAzul(Bitmap imagen, int tonoAzul)
        {
            Bitmap imagenFiltrada = new Bitmap(imagen);


            for (int x = 0; x < imagen.Width; x++)
            {
                for (int y = 0; y < imagen.Height; y++)
                {
                    Color pixel = imagen.GetPixel(x, y);

                    int r = pixel.R;
                    int g = pixel.G;
                    int b = pixel.B;

                    b += tonoAzul;

                    b = Math.Max(0, Math.Min(255, r));

                    Color nuevoPixel = Color.FromArgb(r, g, b);

                    imagenFiltrada.SetPixel(x, y, nuevoPixel);
                }
            }

            return imagenFiltrada;
        }
        public static Bitmap aplicarNegativo(Bitmap imagen)
        {
            Bitmap imagenFiltrada = new Bitmap(imagen);

            for (int x = 0; x < imagen.Width; x++)
            {
                for (int y = 0; y < imagen.Height; y++)
                {
                    Color pixel = imagen.GetPixel(x, y);

                    int r = pixel.R;
                    int g = pixel.G;
                    int b = pixel.B;

                    int nuevoR = 255 - r;
                    int nuevoG = 255 - g;
                    int nuevoB = 255 - b;

                    Color nuevoPixel = Color.FromArgb(nuevoR, nuevoG, nuevoB);
                    imagenFiltrada.SetPixel(x, y, nuevoPixel);
                }
            }

            return imagenFiltrada;

        }
        public static Bitmap aplicarAberracion(Bitmap imagen, int desp)
        {
            Bitmap imagenFiltrada = new Bitmap(imagen);

            for (int x = 0; x < imagen.Width; x++)
            {
                for (int y = 0; y < imagen.Height; y++)
                {
                    Color pixel = imagen.GetPixel(x, y);
                    int r = pixel.R;
                    int g = pixel.G;
                    int b = pixel.B;
                    int rDesplazado = (x + desp) < imagen.Width ? imagen.GetPixel(x + desp, y).R : 0;
                    int bDesplazado = (x - desp) >= 0 ? imagen.GetPixel(x - desp, y).B : 0;
                    Color nuevoPixel = Color.FromArgb(rDesplazado, g, bDesplazado);
                    imagenFiltrada.SetPixel(x, y, nuevoPixel);
                }
            }

            return imagenFiltrada;
        }
        public static Bitmap aplicarPixeleado(Bitmap imagen)
        {
            int tamanoBloque = 10;
            int width = imagen.Width;
            int height = imagen.Height;
            Bitmap imagenFiltrada = new Bitmap(width, height);

            for (int x = 0; x < width; x += tamanoBloque)
            {
                for (int y = 0; y < height; y += tamanoBloque)
                {
                    Color promedioColor = ObtenerPromedioColorBloque(imagen, x, y, tamanoBloque);

                    RellenarBloquePixeles(imagenFiltrada, x, y, tamanoBloque, promedioColor);
                }
            }

            return imagenFiltrada;
        }
        public static Color ObtenerPromedioColorBloque(Bitmap imagen, int xInicial, int yInicial, int tamanoBloque)
        {
            int rTotal = 0;
            int gTotal = 0;
            int bTotal = 0;
            int totalPixeles = 0;

            for (int x = xInicial; x < xInicial + tamanoBloque && x < imagen.Width; x++)
            {
                for (int y = yInicial; y < yInicial + tamanoBloque && y < imagen.Height; y++)
                {
                    Color pixel = imagen.GetPixel(x, y);
                    rTotal += pixel.R;
                    gTotal += pixel.G;
                    bTotal += pixel.B;
                    totalPixeles++;
                }
            }
            int rPromedio = rTotal / totalPixeles;
            int gPromedio = gTotal / totalPixeles;
            int bPromedio = bTotal / totalPixeles;

            return Color.FromArgb(rPromedio, gPromedio, bPromedio);
        }
        public static void RellenarBloquePixeles(Bitmap imagen, int xInicial, int yInicial, int tamanoBloque, Color color)
        {
            for (int x = xInicial; x < xInicial + tamanoBloque && x < imagen.Width; x++)
            {
                for (int y = yInicial; y < yInicial + tamanoBloque && y < imagen.Height; y++)
                {
                    imagen.SetPixel(x, y, color);
                }
            }
        }
        public static Bitmap aplicarViñeta(Bitmap image)
        {
            float intensity = 0.5f;
            Bitmap filteredImage = new Bitmap(image.Width, image.Height);

            float centerX = image.Width / 2f;
            float centerY = image.Height / 2f;
            float maxDistance = (float)Math.Sqrt(centerX * centerX + centerY * centerY);

            for (int y = 0; y < image.Height; y++)
            {
                for (int x = 0; x < image.Width; x++)
                {
                    float distance = (float)Math.Sqrt((x - centerX) * (x - centerX) + (y - centerY) * (y - centerY));
                    float factor = 1f - (distance / maxDistance * intensity);

                    Color pixel = image.GetPixel(x, y);
                    int red = (int)(pixel.R * factor);
                    int green = (int)(pixel.G * factor);
                    int blue = (int)(pixel.B * factor);

                    filteredImage.SetPixel(x, y, Color.FromArgb(red, green, blue));
                }
            }

            return filteredImage;
        }
        public static Bitmap aplicarContraste(Bitmap image, double factor)
        {
            Bitmap adjustedImage = new Bitmap(image.Width, image.Height);

            for (int y = 0; y < image.Height; y++)
            {
                for (int x = 0; x < image.Width; x++)
                {
                    Color pixel = image.GetPixel(x, y);

                    int red = (int)(pixel.R * factor);
                    int green = (int)(pixel.G * factor);
                    int blue = (int)(pixel.B * factor);

                    red = Math.Max(0, Math.Min(255, red));
                    green = Math.Max(0, Math.Min(255, green));
                    blue = Math.Max(0, Math.Min(255, blue));

                    Color adjustedPixel = Color.FromArgb(red, green, blue);
                    adjustedImage.SetPixel(x, y, adjustedPixel);
                }
            }

            return adjustedImage;
        }
        public static Bitmap aplicarGamma(Bitmap image, double gamma)
        {
            Bitmap correctedImage = new Bitmap(image.Width, image.Height);

            double maxIntensity = 255.0;

            double gammaCorrection = 1.0 / gamma;

            for (int y = 0; y < image.Height; y++)
            {
                for (int x = 0; x < image.Width; x++)
                {
                    Color pixel = image.GetPixel(x, y);
                    int red = (int)(Math.Pow(pixel.R / maxIntensity, gammaCorrection) * maxIntensity);
                    int green = (int)(Math.Pow(pixel.G / maxIntensity, gammaCorrection) * maxIntensity);
                    int blue = (int)(Math.Pow(pixel.B / maxIntensity, gammaCorrection) * maxIntensity);
                    red = Math.Max(0, Math.Min(255, red));
                    green = Math.Max(0, Math.Min(255, green));
                    blue = Math.Max(0, Math.Min(255, blue));
                    Color correctedPixel = Color.FromArgb(red, green, blue);
                    correctedImage.SetPixel(x, y, correctedPixel);
                }
            }

            return correctedImage;
        }
        public static Bitmap ColorSlice(Bitmap image, byte[] prototype_color, float color_cube_width)
        {
            int w = image.Width;
            int h = image.Height;

            BitmapData image_data = image.LockBits(
                new Rectangle(0, 0, w, h),
                ImageLockMode.ReadOnly,
                PixelFormat.Format24bppRgb);
            int bytes = image_data.Stride * image_data.Height;

            byte[] buffer = new byte[bytes];
            byte[] result = new byte[bytes];

            Marshal.Copy(image_data.Scan0, buffer, 0, bytes);
            image.UnlockBits(image_data);

            //subtracting 3 from total amount of bytes will let you process images with odd number dimensions
            for (int i = 0; i < bytes - 3; i += 3)
            {
                for (int c = 0; c < 3; c++)
                {
                    if (Math.Abs(buffer[i + c] - prototype_color[c]) > (color_cube_width / 2))
                    {
                        result[i + c] = 128;
                    }
                    else
                    {
                        result[i + c] = buffer[i + c];
                    }
                }
            }

            Bitmap res_image = new Bitmap(w, h);
            BitmapData result_data = res_image.LockBits(
                new Rectangle(0, 0, w, h),
                ImageLockMode.WriteOnly,
                PixelFormat.Format24bppRgb);
            Marshal.Copy(result, 0, result_data.Scan0, bytes);
            res_image.UnlockBits(result_data);

            return res_image;
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


