using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Cloud.Firestore;

namespace educacaodofuturo.Resources
{
    class Aluno
    {
        public string Id { get; set; }
        public string Bairro { get; set; }
        public string Cep { get; set; }
        public string Cidade{ get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public string Estado { get; set; }
        public string Nome { get; set; }
        public string Numero { get; set; }
        public string Rua { get; set; }
        public string Sexo { get; set; }
        public string Telefone { get; set; }
        public string Turma { get; set; }


        private Action<Aluno> action;
        private Action<bool> actionResult;
        Action<List<Aluno>> actionRetList;

        public void Cadastrar(Action<bool> result)
        {
            actionResult = result;
            Dictionary<string, object> values = new Dictionary<string, object>();
            values.Add("bairro", Bairro);
            values.Add("cep", Cep);
            values.Add("cidade", Cidade);
            values.Add("cpf", Cpf);
            values.Add("email", Email);
            values.Add("estado", Estado);
            values.Add("nome", Nome);
            values.Add("numero", Numero);
            values.Add("rua", Rua);
            values.Add("sexo", Sexo);
            values.Add("telefone", Telefone);
            values.Add("turma", Turma);
            new Firebase().Cadastrar(values, CadastrarResult,"Aluno");
        }

        public void CadastrarResult(bool cadastrado)
        {
            actionResult(cadastrado);
        }

        public void RetTodos(Action<List<Aluno>> action)
        {
            this.actionRetList = action;
            new Resources.Firebase().BuscarTodos(RetTodosResult, "Aluno");
        }
        public void RetTodosResult(QuerySnapshot querySnapshot)
        {
            List<Aluno> alunos = new List<Aluno>();
            foreach (var document in querySnapshot)
            {
                Aluno aluno = new Aluno();
                aluno.Id = document.Id;
                aluno.Nome = document.GetValue<string>("nome");
                aluno.Cpf = document.GetValue<string>("cpf");
                aluno.Email = document.GetValue<string>("email");
                aluno.Telefone = document.GetValue<string>("telefone");
                alunos.Add(aluno);
            }
            actionRetList(alunos);
        }
    }
}
