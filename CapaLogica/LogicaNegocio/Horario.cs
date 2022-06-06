using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaMatricula.CapaLogica.LogicaNegocio
{
    public class Horario
    {
        #region ATRIBUTOS
        protected int horario_id;
        protected string horario_descripcion;
        protected string horario_dia;
        protected string horario_horaInicial;
        protected string horario_horaFinal;
        protected string horario_estado;
        #endregion

        #region CONSTRUCRORES
        public Horario()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Phorario_descripcion"></param>
        /// <param name="Phorario_dia"></param>
        /// <param name="Phorario_horaInicial"></param>
        /// <param name="Phorario_horaFinal"></param>
        /// <param name="Phorario_estado"></param>
        public Horario(string Phorario_descripcion, string Phorario_dia, string Phorario_horaInicial, string Phorario_horaFinal, string Phorario_estado)
        {
            Horario_id = 0;
            Horario_descripcion = Phorario_descripcion;
            Horario_dia = Phorario_dia;
            Horario_horaInicial = Phorario_horaInicial;
            Horario_horaFinal = Phorario_horaFinal;
            Horario_estado = Phorario_estado;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Phorario_id"></param>
        /// <param name="Phorario_descripcion"></param>
        /// <param name="Phorario_dia"></param>
        /// <param name="Phorario_horaInicial"></param>
        /// <param name="Phorario_horaFinal"></param>
        /// <param name="Phorario_estado"></param>
        public Horario(int Phorario_id,string Phorario_descripcion, string Phorario_dia, string Phorario_horaInicial, string Phorario_horaFinal, string Phorario_estado)
        {
            Horario_id = Phorario_id;
            Horario_descripcion =Phorario_descripcion;
            Horario_dia = Phorario_dia;
            Horario_horaInicial = Phorario_horaInicial;
            Horario_horaFinal = Phorario_horaFinal;
            Horario_estado = Phorario_estado;
        }
        #endregion

        #region GETS_SETS
        public int Horario_id { get => horario_id; set => horario_id = value; }
        public string Horario_descripcion { get => horario_descripcion; set => horario_descripcion = value; }
        public string Horario_dia { get => horario_dia; set => horario_dia = value; }
        public string Horario_horaInicial { get => horario_horaInicial; set => horario_horaInicial = value; }
        public string Horario_horaFinal { get => horario_horaFinal; set => horario_horaFinal = value; }
        public string Horario_estado { get => horario_estado; set => horario_estado = value; }
        #endregion
    }
}
