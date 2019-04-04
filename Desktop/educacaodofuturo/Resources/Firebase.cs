using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Cloud.Firestore;
using Firebase.Auth;

namespace educacaodofuturo.Resources
{
    class Firebase
    {
        FirestoreDb db;
        public Firebase()
        {
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", System.AppDomain.CurrentDomain.BaseDirectory + @"educacaodofuturoweb-firebase-adminsdk-920mx-24aa307d2d.json");
            db = FirestoreDb.Create("educacaodofuturoweb");
        }

        public async void Login(Action<DocumentSnapshot> action, string email, string senha)
        {
            var authProvider = new FirebaseAuthProvider(new FirebaseConfig("AIzaSyBPrkD1vH-whMr8f2jsaHxL716PTx53jhQ"));
            var auth = await authProvider.SignInWithEmailAndPasswordAsync(email, senha);
            var id = auth.User.LocalId;
            var snapshot = await db.Collection("Funcionarios").Document(id).GetSnapshotAsync();
            action(snapshot);
        }

        public async void Cadastrar(Dictionary<string, object> dados, Action<bool> action)
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
    }
}
