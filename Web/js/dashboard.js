function TransferirMenu(snapshot) {
    VerificaCargo(snapshot.user.email)
}

async function VerificaCargo(email) {
    await firebase.firestore().collection('Funcionarios').where('email', '==', email).get().then(function (querySnapshot) {
        querySnapshot.forEach((doc) => {
            const user = doc.data()
            const cargo = user.cargo.toLowerCase()
            if (cargo == 'diretor') {
                window.location.href = 'home/menu-diretor'
            }
            else if (cargo == 'coordenador') {
                window.location.href = 'home/menu-coordenador'
            }
        })
    })
}
