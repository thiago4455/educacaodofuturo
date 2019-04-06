using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Cloud.Firestore;

namespace educacaodofuturo.Resources
{
    public class Cursos
    {
        public string Id { get; set; }
        public string Nome { get; set; }
        public string Area { get; set; }
        public string CargaHoraria { get; set; }
        public string Mensalidade { get; set; }

        Action<List<Cursos>> actionRetCursos;
        Action<bool> actionCadastrar;

        public void RetTodos(Action<List<Cursos>> action)
        {
            this.actionRetCursos = action;
            new Resources.Firebase().BuscarTodos(RetTodosResult, "Cursos");
        }
        public void RetTodosResult(QuerySnapshot querySnapshot)
        {
            List<Cursos> cursos = new List<Cursos>();
            foreach (var document in querySnapshot)
            {
                Cursos curso = new Cursos();
                curso.Id = document.Id;
                curso.Nome = document.GetValue<string>("nome");
                curso.Area = document.GetValue<string>("area");
                curso.CargaHoraria = document.GetValue<string>("cargaHor") + " horas";
                curso.Mensalidade = "R$ "+document.GetValue<string>("mensalidade");
                cursos.Add(curso);
            }
            actionRetCursos(cursos);
        }

        public void Cadastrar(Action<bool> action)
        {
            actionCadastrar = action;
            Dictionary<string, object> values = new Dictionary<string, object>();
            values.Add("nome", Nome);
            values.Add("area", Area);
            values.Add("mensalidade", Mensalidade);
            values.Add("cargaHor", CargaHoraria);
            new Firebase().Cadastrar(values, CadastrarResult,"Cursos");
        }

        public void CadastrarResult(bool cadastrado)
        {
            actionCadastrar(cadastrado);
        }
    }
}
