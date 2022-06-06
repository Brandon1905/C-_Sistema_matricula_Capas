using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaMatricula.CapaLogica.LogicaNegocio
{
    public class Aula
    {
        #region ATRIBUTOS
        protected int aula_id;
        protected string aula_descripcion;
        protected string aula_capacidad;
        protected string aula_estado;
        #endregion

        #region CONSTRUTORES
        public Aula()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Paula_descricion"></param>
        /// <param name="Paula_capacidad"></param>
        /// <param name="Paula_estado"></param>
        public Aula(string Paula_descricion, string Paula_capacidad, string Paula_estado)
        {
            Aula_id = 0;
            Aula_descripcion = Paula_descricion;
            Aula_capacidad = Paula_capacidad;
            Aula_estado = Paula_estado;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Paula_id"></param>
        /// <param name="Paula_descricion"></param>
        /// <param name="Paula_capacidad"></param>
        /// <param name="Paula_estado"></param>
        public Aula(int Paula_id, string Paula_descricion, string Paula_capacidad, string Paula_estado)
        {
            Aula_id = Paula_id;
            Aula_descripcion = Paula_descricion;
            Aula_capacidad = Paula_capacidad;
            Aula_estado = Paula_estado;
        }
        #endregion

        #region GETS_SETS
        public int Aula_id { get => aula_id; set => aula_id = value; }
        public string Aula_descripcion { get => aula_descripcion; set => aula_descripcion = value; }
        public string Aula_capacidad { get => aula_capacidad; set => aula_capacidad = value; }
        public string Aula_estado { get => aula_estado; set => aula_estado = value; }
        #endregion

    }
}
