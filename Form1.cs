using System.Windows.Forms;

namespace proyFinal
{
    public partial class Form1 : Form
    {
        private List<Panel> paneles;

        public Form1()
        {
            // Configuraci�n del formulario
            this.Text = "Paneles con Controles";
            this.Size = new Size(800, 600);

            // Crear y configurar la lista de paneles
            paneles = new List<Panel>();
            int numPaneles = 5;

            for (int i = 0; i < numPaneles; i++)
            {
                // Crear un nuevo panel
                Panel panel = new Panel
                {
                    Size = new Size(150, 150),
                    Location = new Point(50 + (i * 160), 50), // Espaciado horizontal
                    BackColor = Color.FromArgb(50 * i, 100, 150) // Colores distintos
                };

                // Crear y agregar una PictureBox dentro del panel
                PictureBox pictureBox = new PictureBox
                {
                    Size = new Size(100, 70),
                    Location = new Point(25, 10),
                    BackColor = Color.White,
                    BorderStyle = BorderStyle.FixedSingle,
                    Image = Properties.Resources.gato,// aqui va la imagen que viene de la base de datos // Usa una imagen del proyecto o pon null
                    SizeMode = PictureBoxSizeMode.Zoom
                };
                panel.Controls.Add(pictureBox);

                // Crear y agregar un bot�n dentro del panel
                Button button = new Button
                {
                    Text = $"Bot�n {i + 1}",
                    Size = new Size(100, 30),
                    Location = new Point(25, 90)
                };
                button.Click += (sender, e) => MessageBox.Show($"�Hiciste clic en el bot�n {i + 1}!");
                panel.Controls.Add(button);

                // Agregar el panel a la lista y al formulario
                paneles.Add(panel);
                this.Controls.Add(panel);
            }
        }
    }
}
