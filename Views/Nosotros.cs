using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProyectoTOO.Views
{
    public partial class Nosotros : Form
    {
        public Nosotros()
        {
            InitializeComponent();
        }

        private void Nosotros_Load(object sender, EventArgs e)
        {
            richTextBox1.Rtf = @"{\rtf1\ansi\deff0
                {\fonttbl{\f0\fswiss\fcharset0 Arial;}}
                \pard\qc\b Universidad de El Salvador\par
                \pard\qc Facultad de Ingeniería y Arquitectura\par
                \pard\qc Escuela de Ingeniería de Sistemas Informáticos\par
                \pard\qc\b0\par
                \pard\ql\ul Integrantes del Proyecto\ulnone\par
                \pard\ql\tqr\tx9000 Pedro Ernesto Alfaro Laínez\tab AL19002\par
                \pard\ql\tqr\tx9000 José Salvador Perdomo Méndez\tab PM18106\par
                \pard\ql\tqr\tx9000 Emerson Adalberto Martínez Escalante\tab ME12007\par
                \pard\ql\tqr\tx9000 José Adonias Galeano Cortez\tab GC21017\par
                \pard\ql\tqr\tx9000 Melvin Bladimir Suárez\tab SS09023\par
                \pard\ql\tqr\tx9000 Daniel Esaú Ramírez Flores\tab RR20102\par
                \pard\qc\par
                \pard\qc\b © 2025 Universidad de El Salvador. Todos los derechos reservados.\b0\par
                }";
        }
    }
}
