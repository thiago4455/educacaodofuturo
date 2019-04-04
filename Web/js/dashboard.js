function TransferirMenu(snapshot) {
    VerificaCargo(snapshot.user.email)
}

async function VerificaCargo(email) {
    console.log(email)
    await firebase.firestore().collection('Funcionarios').where('email', '==', email).get().then(function (querySnapshot) {
        querySnapshot.forEach((doc) => {
            const user = doc.data()
            const cargo = user.cargo.toLowerCase()
            console.log(cargo)
            if (cargo == 'diretor') {
                window.location.href = 'home/menu-diretor'
            }
        })
    })
}
