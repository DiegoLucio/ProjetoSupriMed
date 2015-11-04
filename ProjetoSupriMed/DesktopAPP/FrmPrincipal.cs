using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoSupriMed.Code.DTO;


namespace ProjetoSupriMed.DesktopAPP
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();

            tSSLExibiData.Text = DateTime.Now.ToString();

        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            tSSLUsuarioLogado.Text = UsuarioLogadoDTO.UsuarioLogado;
        }
    }
}
