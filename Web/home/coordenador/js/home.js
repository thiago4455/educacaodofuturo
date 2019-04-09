$(document).ready(function () {
    firebase.auth().onAuthStateChanged(function (user) {

        if (user) {

        }
        else {
            window.location.href = '../../index'
        }

    });

    var numProf = 0;
    firebase.firestore().collection('Professores').get().then(function (snapshot) {
        snapshot.forEach(function (doc) {
            numProf++
        })
        $('#info-numero-professor').append(numProf)

    })

})

$(window).on('load', function () {

    $('#loading').css('display', 'none')

})

$('.card-bottom').click(function () {
    id = $(this).attr("id")
    Page(id)
})

function Page(id) {
    if (id == 'card-professor') {
        window.location.href = 'professores.html'
    }
    else if (id == 'card-pedagogo' || id == 'card-coordenador' || id == 'card-secretaria' || id == 'card-bibliotecario' || id == 'card-auxiliar') {
        window.location.href = 'funcionarios'
    }
}