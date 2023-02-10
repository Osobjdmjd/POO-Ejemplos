namespace Herencia_Ejemplo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Persona persona = new Persona();
            Estudiante estud = new Estudiante("202208069","Ingeniería en Sistemas","3ra Calle","Cua Alvarado","Julio Pablo");
            persona.Nombres = "Juan";
            persona.Apellidos = "Mendez";
            MessageBox.Show(persona.Nombres + " " + persona.Apellidos);
            Persona persona1 = new Persona("Pedro","Martínez","3ra calle");
            MessageBox.Show(persona1.Nombres + " " + persona1.Apellidos);
            MessageBox.Show(estud.Nombres + " " + estud.Apellidos + " " + estud.Direccion + " " + estud.Carrera);
        }
    }

    
}