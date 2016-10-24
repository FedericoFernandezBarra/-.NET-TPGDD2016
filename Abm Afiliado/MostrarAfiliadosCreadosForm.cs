using ClinicaFrba.Clases.POJOS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaFrba.Abm_Afiliado
{
    public partial class MostrarAfiliadosCreadosForm : Form
    {
        List<Afiliado> afiliados = new List<Afiliado>();

        public MostrarAfiliadosCreadosForm(Afiliado afiliadoPrincipal)
        {
            afiliados.Add(afiliadoPrincipal);

            if (afiliadoPrincipal.conyuge!=null)
            {
                afiliados.Add(afiliadoPrincipal.conyuge);
            }

            afiliadoPrincipal.hijos.ForEach(h => afiliados.Add(h));

            InitializeComponent();
        }

        private void Volver_Button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MostrarAfiliadosCreadosForm_Load(object sender, EventArgs e)
        {
            initForm();
        }

        private void initForm()
        {
            DataGridViewTextBoxColumn cNroAfiliado = new DataGridViewTextBoxColumn();
            cNroAfiliado.HeaderText = "Nro de Afiliado";
            cNroAfiliado.ReadOnly = true;
            dataGridView1.Columns.Add(cNroAfiliado);
            DataGridViewTextBoxColumn cNick = new DataGridViewTextBoxColumn();
            cNick.HeaderText = "Nick";
            cNick.ReadOnly = true;
            dataGridView1.Columns.Add(cNick);
            DataGridViewTextBoxColumn cPass = new DataGridViewTextBoxColumn();
            cPass.HeaderText = "Password";
            cPass.ReadOnly = true;
            dataGridView1.Columns.Add(cPass);

            afiliados.ForEach(a => dataGridView1.Rows.Add(a.id, a.usuario.nick, a.usuario.pass));
        }
    }
}
