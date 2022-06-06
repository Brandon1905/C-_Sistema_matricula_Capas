using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmProfesor());
            Application.Run(new ModuloAula());
            Application.Run(new ModuloCurso());
            Application.Run(new ModuloGrupo());
            Application.Run(new ModeloHorario());
            Application.Run(new ModuloUsuario());
            Application.Run(new ModuloEstudiante());
            Application.Run(new ModuloMatricula());
        }
    }
}
