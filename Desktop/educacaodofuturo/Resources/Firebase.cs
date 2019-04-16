using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Cloud.Firestore;
using Firebase.Auth;

namespace educacaodofuturo.Resources
{
    public class Firebase
    {
        FirestoreDb db;
        public Firebase()
        {
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", System.AppDomain.CurrentDomain.BaseDirectory + @"educacaodofuturoweb-4ecfd6bb5c12.json");
            db = FirestoreDb.Create("educacaodofuturoweb");
        }

        public async void Login(Action<DocumentSnapshot> action,Action<string> erro, string email, string senha)
        {
            try
            {
                var authProvider = new FirebaseAuthProvider(new FirebaseConfig("AIzaSyBPrkD1vH-whMr8f2jsaHxL716PTx53jhQ"));
                var auth = await authProvider.SignInWithEmailAndPasswordAsync(email, senha);
                var id = auth.User.LocalId;
                var snapshot = await db.Collection("Funcionarios").Document(id).GetSnapshotAsync();
                action(snapshot);
            }
            catch(Exception ex)
            {
                erro(ex.ToString());
            }
        }

        public async void RetornarFrequencia(string collectionString, string campo, string valorCampo, Action<QuerySnapshot> action)
        {
            var collection = await db.Collection(collectionString).WhereEqualTo(campo, valorCampo).GetSnapshotAsync();
            action(collection);

        }

        public async void RetornarFrequenciaCargo(string collectionString, string campo, string valorCampo, string cargo, Action<QuerySnapshot> action)
        {
            var collection = await db.Collection(collectionString).WhereEqualTo(campo, valorCampo).WhereEqualTo("cargo",cargo).GetSnapshotAsync();
            action(collection);

        }

        public async void AlterarFreq(string cpf, string data, Dictionary<string,object> values, Action<bool> action)
        {
            try
            {
                var collection = await db.Collection("FrequenciaFuncs").WhereEqualTo("cpf", cpf).WhereEqualTo("data", data).GetSnapshotAsync();
                if (collection.Documents.Count > 0)
                {
                    string id = collection.Documents[0].Id;
                    var edit = await db.Collection("FrequenciaFuncs").Document(id).SetAsync(values);
                }
                else
                {
                    var register = await db.Collection("FrequenciaFuncs").AddAsync(values);
                }
                action(true);
            }
            catch
            {
                action(false);
            }
        }

        public async void GetFreq(string cpf, string data, string cargo, Action<Funcionario> action)
        {
            try
            {
                Funcionario funcionario = new Funcionario();
                var collection = await db.Collection("FrequenciaFuncs").WhereEqualTo("cpf", cpf).WhereEqualTo("data", data).GetSnapshotAsync();
                if (collection.Documents.Count > 0)
                {
                    var document = collection.Documents[0];
                    funcionario.Cpf = cpf;
                    funcionario.Cargo = cargo;
                    funcionario.HorarioEntrada = document.GetValue<string>("horarioEntrada");
                    funcionario.HorarioSaida = document.GetValue<string>("horarioSaida");
                    funcionario.VoltaIntervalo = document.GetValue<string>("saidaIntervalo");
                    funcionario.SaidaIntervalo = document.GetValue<string>("voltaIntervalo");
                }
                else
                {
                    Dictionary<string, object> values = new Dictionary<string, object>();
                    values.Add("cpf", cpf);
                    values.Add("data", data);
                    values.Add("cargo", cargo);
                    values.Add("horarioEntrada", "");
                    values.Add("horarioSaida", "");
                    values.Add("saidaIntervalo", "");
                    values.Add("voltaIntervalo", "");
                    var register = await db.Collection("FrequenciaFuncs").AddAsync(values);
                    funcionario.Cpf = cpf;
                    funcionario.Cargo = cargo;
                    funcionario.HorarioEntrada = "";
                    funcionario.HorarioSaida = "";
                    funcionario.SaidaIntervalo = "";
                    funcionario.VoltaIntervalo = "";
                }
                action(funcionario);
            }
            catch
            {
                action(new Funcionario());
            }
        }

        public async void CadastrarFuncionario(Dictionary<string, object> dados, Action<bool> action)
        {
            try
            {
                var authProvider = new FirebaseAuthProvider(new FirebaseConfig("AIzaSyBPrkD1vH-whMr8f2jsaHxL716PTx53jhQ"));
                var auth = await authProvider.CreateUserWithEmailAndPasswordAsync(dados["email"].ToString(), dados["senha"].ToString());
                dados.Remove("senha");
                var collection = db.Collection("Funcionarios").Document(auth.User.LocalId);
                await collection.CreateAsync(dados);
                action(true);
            }
            catch
            {
                action(false);
            }
        }

        public async void BuscarQuant(Action<Dictionary<string,int>> action)
        {
            Dictionary<string, int> quantidades = new Dictionary<string, int>();
            var collection = await db.Collection("Cursos").GetSnapshotAsync();
            quantidades.Add("Cursos",collection.Count());
            collection = await db.Collection("Funcionarios").WhereEqualTo("cargo", "Pedagogo").GetSnapshotAsync();
            quantidades.Add("Pedagogos", collection.Count());
            collection = await db.Collection("Funcionarios").WhereEqualTo("cargo", "Coordenador").GetSnapshotAsync();
            quantidades.Add("Coordenadores", collection.Count());
            collection = await db.Collection("Funcionarios").WhereEqualTo("cargo", "Secretario").GetSnapshotAsync();
            quantidades.Add("Secretarios", collection.Count());
            collection = await db.Collection("Funcionarios").WhereEqualTo("cargo", "Bibliotecario").GetSnapshotAsync();
            quantidades.Add("Bibliotecarios", collection.Count());
            collection = await db.Collection("Funcionarios").WhereEqualTo("cargo", "Auxiliar").GetSnapshotAsync();
            quantidades.Add("Auxiliares", collection.Count());
            collection = await db.Collection("Funcionarios").WhereEqualTo("cargo", "Professor").GetSnapshotAsync();
            quantidades.Add("Professores", collection.Count());
            collection = await db.Collection("Alunos").GetSnapshotAsync();
            quantidades.Add("Alunos", collection.Count());
            action(quantidades);
        }

        public async void BuscarTodos(Action<QuerySnapshot> action, string collectionName)
        {
            var collection = await db.Collection(collectionName).GetSnapshotAsync();
            action(collection);
        }

        public async void BuscarPorCargo(Action<QuerySnapshot> action, string collectionName, string cargo)
        {
            var collection = await db.Collection(collectionName).WhereEqualTo("cargo",cargo).GetSnapshotAsync();
            action(collection);
        }

        public async void Cadastrar(Dictionary<string, object> values, Action<bool> action, string collectionString)
        {
            try
            {
                var collection = db.Collection(collectionString);
                await collection.AddAsync(values);
                action(true);
            }
            catch
            {
                action(false);
            }
        }

        public async void CadastrarSub(Dictionary<string, object> values, Action<bool> action, string collectionString, string documentString, string subCollection)
        {
            try
            {
                var collection = db.Collection(collectionString).Document(documentString).Collection(subCollection);
                await collection.AddAsync(values);
                action(true);
            }
            catch
            {
                action(false);
            }
        }
    }
}
