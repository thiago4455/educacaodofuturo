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

        public async void CadastrarFuncionario(Dictionary<string, object> dados, Action<bool> action)
        {
            try
            {
                var authProvider = new FirebaseAuthProvider(new FirebaseConfig("AIzaSyBPrkD1vH-whMr8f2jsaHxL716PTx53jhQ"));
                var auth = await authProvider.CreateUserWithEmailAndPasswordAsync(dados["email"].ToString(), dados["senha"].ToString());
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
            action(quantidades);

        }

        public async void BuscarTodos(Action<QuerySnapshot> action, string collectionName)
        {
            var collection = await db.Collection(collectionName).GetSnapshotAsync();
            action(collection);
        }

        public async void Cadastrar(Dictionary<string,object> values, Action<bool> action, string collectionString)
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
    }
}
