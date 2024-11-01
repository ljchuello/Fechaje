namespace Fechaje
{
    public partial class Form1 : Form
    {
        private DateTime fechaActual = DateTime.Now;
        private DateTime fechaInicioMuestra = DateTime.Now;
        private DateTime fechaFinMuestra = DateTime.Now;
        private DateTime fechaInicioPrueba = DateTime.Now;
        private DateTime fechaFinPrueba = DateTime.Now;

        private int nroMesesMuestra = 2;
        private int nroMesesPruebas = 3;


        public Form1()
        {
            InitializeComponent();
            load();
        }

        void load()
        {
            txtFechaActual.Text = $"{fechaActual:dd/MM/yyyy}";
            txtNroMesesMuestra.Text = $"{nroMesesMuestra:n0}";
            txtNroMesesPrueba.Text = $"{nroMesesPruebas:n0}";

            monthCalendar1.SelectionEnd = fechaActual;
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            fechaActual = e.End;
            load();
        }
    }
}
