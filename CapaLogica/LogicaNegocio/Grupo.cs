using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaMatricula.CapaLogica.LogicaNegocio
{
    public class Grupo
    {
        #region ATRIBUTOS
        protected int grupo_id;
        protected string grupo_descripcion;
        protected string grupo_estado;
        #endregion

        #region CONSTRUTORES
        public Grupo()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Pgrupo_descripcion"></param>
        /// <param name="Pgrupo_estado"></param>
        public Grupo(string Pgrupo_descripcion, string Pgrupo_estado)
        {
            this.grupo_id = 0;
            this.grupo_descripcion = Pgrupo_descripcion;
            this.grupo_estado = Pgrupo_estado;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Pgrupo_id"></param>
        /// <param name="Pgrupo_descripcion"></param>
        /// <param name="Pgrupo_estado"></param>
        public Grupo(int Pgrupo_id, string Pgrupo_descripcion, string Pgrupo_estado)
        {
            this.grupo_id = Pgrupo_id;
            this.grupo_descripcion = Pgrupo_descripcion;
            this.grupo_estado = Pgrupo_estado;
        }
        #endregion

        #region GETS_SETS
        public int Grupo_id { get => grupo_id; set => grupo_id = value; }
        public string Grupo_descripcion { get => grupo_descripcion; set => grupo_descripcion = value; }
        public string Grupo_estado { get => grupo_estado; set => grupo_estado = value; }
        #endregion

    }
}
