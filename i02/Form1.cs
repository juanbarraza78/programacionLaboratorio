using entidades;

namespace i02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_direccion.Text) || string.IsNullOrWhiteSpace(tb_nombre.Text))
            {
                MessageBox.Show("Error");
            }
            else
            {
                string nombreAux;
                string direccionAux;
                int edadAux;
                string generoAux;
                string paisAux;
                string[] cursosAux = new string[3];

                nombreAux = tb_nombre.Text;
                direccionAux = tb_direccion.Text;
                edadAux = (int)nud_edad.Value;
                paisAux = lb_pais.SelectedItem.ToString();

                if (rb_masculino.Checked == true)
                {
                    generoAux = "Masculino";
                }
                else if (rb_femenino.Checked == true)
                {
                    generoAux = "Femenino";
                }
                else
                {
                    generoAux = "No binario";
                }

                if (cb_c.Checked == true)
                {
                    cursosAux[0] = "C#";
                }
                if (cb_cMas.Checked == true)
                {
                    cursosAux[1] = "C++";
                }
                if (cb_javaScript.Checked == true)
                {
                    cursosAux[2] = "Java Script";
                }

                Ingresante nuevoIngresante = new Ingresante(cursosAux, direccionAux, edadAux, generoAux, nombreAux, paisAux);

                MessageBox.Show(nuevoIngresante.Mostrar());

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lb_pais.SelectedIndex = 0;
        }
    }
}