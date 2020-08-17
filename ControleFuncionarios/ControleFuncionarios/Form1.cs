using BLL;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleFuncionarios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Business Negocio = new Business();
            Pessoa novaPessoa = new Pessoa();
            novaPessoa.Nome = "Ana";
            novaPessoa.Idade = 38;
            Negocio.Salvar(novaPessoa);
        }
    }
}
