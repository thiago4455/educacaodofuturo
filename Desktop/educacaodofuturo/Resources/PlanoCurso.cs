using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace educacaodofuturo.Resources
{
    class PlanoCurso
    {
        public string Id { get; set; }
        public string NomeMateria { get; set; }
        public string NomeCurso { get; set; }
        public string Descricao { get; set; }
        public string CargaHor { get; set; }

        Action<bool> actionCadastrar;

        public void Cadastrar(Action<bool> action)
        {
            actionCadastrar = action;
            Dictionary<string, object> values = new Dictionary<string, object>();
            values.Add("nomeMateria", NomeMateria);
            values.Add("nomeCurso", NomeCurso);
            values.Add("descricao", Descricao);
            values.Add("cargaHor", CargaHor);
            new Firebase().CadastrarSub(values, CadastrarResult, "Cursos",Id,"Materias");
        }

        public void CadastrarResult(bool cadastrado)
        {
            actionCadastrar(cadastrado);
        }
    }
}
