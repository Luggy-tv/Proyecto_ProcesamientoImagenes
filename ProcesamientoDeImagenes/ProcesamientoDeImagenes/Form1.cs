using AForge.Video.DirectShow;
using AForge.Video;

namespace ProcesamientoDeImagenes
{
    public partial class Form1 : Form
    {

        private bool hayDispositivos = false;
        private FilterInfoCollection misDispositivos;
        private VideoCaptureDevice miWebCam = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cargarDispositivios()
        {
            misDispositivos = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            
            if (misDispositivos.Count > 0)
            {
                
                comboBox1.Items.Clear();

                hayDispositivos = true;
                for (int i = 0; i < misDispositivos.Count; i++)
                {
                    comboBox1.Items.Add(misDispositivos[i].Name.ToString());
                }

                comboBox1.Text = misDispositivos[0].Name.ToString();

                //Cambiar esto a otro boton ya que es de la camara
                #region Cosas de Camara que hay que quitar de aqui
                cerrarWebCam();
                int j = comboBox1.SelectedIndex;
                string nombreVideo = misDispositivos[j].MonikerString;
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
        public void cerrarWebCam()
        {
            if (miWebCam != null && miWebCam.IsRunning)
            {
                miWebCam.SignalToStop();
                miWebCam = null;
            }
        }

        //Boton De Aplicar Filtro
        private void button4_Click(object sender, EventArgs e)
        {

        }


        //Boton de Seleccionar imagen
        private void button1_Click(object sender, EventArgs e)
        {
            cerrarWebCam();

        }

        //Boton de abrir camara
        private void button3_Click(object sender, EventArgs e)
        {
            cerrarWebCam();
            cargarDispositivios();
        }
        //Metodo para actualizar PictureBox para camara 
        private void actualizarCamara(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap imagen = (Bitmap)eventArgs.Frame.Clone();
            pictureBox1.Image = imagen;
        }

        //Boton de Seleccionar video
        private void button2_Click(object sender, EventArgs e)
        {
            cerrarWebCam();

        }

        //Boton de quitar filtro
        private void button6_Click(object sender, EventArgs e)
        {

        }
        //Boton de Guardar Imagen
        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            cerrarWebCam();
        }
    }
}