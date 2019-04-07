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
            const cargo = user.cargo.toLowerCase()

            if (cargo == 'diretor') {
                if (!window.location.href.includes('home/menu-diretor.html')) {
                    window.location.href = '../home/menu-diretor.html'
                }
            }
            else if (cargo == 'coordenador') {
                if (!window.location.href.includes('home/menu-coordenador.html')) {
                    window.location.href = '../home/menu-coordenador.html'
                    alert('oi')
                }
            }

        })
    })
}