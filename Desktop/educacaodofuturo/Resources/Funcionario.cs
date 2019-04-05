using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Cloud.Firestore;

namespace educacaodofuturo.Resources
{
    public class Funcionario
    {
        [FirestoreProperty("nome")]
        public string Nome { get; set; }
        [FirestoreProperty("cargo")]
        public string Cargo { get; set; }
        [FirestoreProperty("email")]
        public string Email { get; set; }
        [FirestoreProperty("senha")]
        public string Senha { get; set; }

        public string Id { get; set; }

        private Action<Funcionario> action;

        public async void Login(Action<Funcionario> action)
        {
            this.action = action;
            try
            {
                new Firebase().Login(ResultLogin, LoginErro, Email, Senha);
            }
            catch
            {
                Id = "";
                action(this);
            }
        }

        public void ResultLogin(DocumentSnapshot snapshot)
        {
            Funcionario func = new Funcionario();
            Id = snapshot.Id;
            Email = snapshot.GetValue<string>("email");
            Nome = snapshot.GetValue<string>("nome");
            Cargo = snapshot.GetValue<string>("cargo");
            action(this);
        }

        public void LoginErro(string erro)
        {
            Funcionario func = new Funcionario();
            Id = "";
            action(this);
        }

        public async void Cadastrar()
        {
            Dictionary<string, object> values = new Dictionary<string, object>();
            values.Add("nome", Nome);
            values.Add("email", Email);
            values.Add("senha", Senha);
            values.Add("cargo", Cargo);
            new Firebase().Cadastrar(values, CadastrarResult);
        }

        public void CadastrarResult(bool cadastrado)
        {

        }
    }
}
