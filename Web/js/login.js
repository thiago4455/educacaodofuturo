$(document).ready(function () {

    firebase.auth().onAuthStateChanged(function (user) {
        if (user) {
           VerificaCargo(user.email)
        }
    });

    $('#btn-entrar').click(function () {
        const email = $('#email').val()
        const senha = $('#senha').val()

        if (!email || !senha) {
            messageError('Preencha todos os campos')
        }
        else {

            firebase.auth().signInWithEmailAndPassword(email, senha).then(snapshot => {
                TransferirMenu(snapshot)
            }).catch(error => {
                console.log(error)
                if (error.code == 'auth/user-not-found') {
                    messageError('Email ou senha incorretos')
                } else if (error.code == 'auth/wrong-password') {
                    messageError('Senha inválida')
                }
            })
        }
    })

    function messageError(msg) {
        $('.alert').css('display', 'flex')
        $('#alert-message').html(msg)
    }

    $('.close').click(function () {
        $('.alert').css('display', 'none')
    })

})