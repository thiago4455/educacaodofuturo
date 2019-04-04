firebase.auth().onAuthStateChanged(function (user) {
    if (user) {
        console.log(user)
        const email = user.email
        if (VerificaCargo(email)) {
            pic = document.getElementById('pic-profile')
            pic.src = user.photoURL
            $('#pic-nome').html(user.displayName)
        }
    }
    else {
        window.location.href = '../index'
    }
});


async function VerificaCargo(email) {
    await firebase.firestore().collection('Funcionarios').where('email', '==', email).get().then(function (querySnapshot) {
        querySnapshot.forEach((doc) => {
            const user = doc.data()
            const cargo = user.cargo
            if (cargo == 'diretor') {
                console.log(oi)
                window.location.href = 'home/menu-diretor.html'
            }
        })
    })
}