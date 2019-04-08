$(document).ready(function () {
    firebase.auth().onAuthStateChanged(function (user) {

        if (user) {

        }
        else {
            window.location.href = '../../index'
        }

    });

    var numCursos = 0;
    firebase.firestore().collection('Cursos').get().then(function (snapshot) {
        snapshot.forEach(function (doc) {
            numCursos++
        })
        $('#info-numero-cursos').append(numCursos)

    })


    HomeTask('Diretor')
    HomeTask('Pedagogo')
    HomeTask('Coordenador')
    HomeTask('Secretário')
    HomeTask('Professor')
    HomeTask('Bibliotecário')
    HomeTask('Auxiliar')
    function HomeTask(cargo) {
        var num = 0;
        firebase.firestore().collection('Funcionarios').where('cargo', '==', cargo).get().then(function (snapshot) {
            snapshot.forEach(function (doc) {
                num++
            })
            $('#info-numero-' + cargo.toLowerCase() + '').append(num)

        })
    }
})

$(window).on('load', function () {

    $('#loading').css('display', 'none')

})

$('.card-bottom').click(function () {
    id = $(this).attr("id")
    Page(id)
})

function Page(id) {
    if (id == 'card-clientes') {
        window.location.href = 'cursos'
    }
    else if (id == 'card-pedagogo' || id == 'card-coordenador' || id == 'card-secretaria' || id == 'card-bibliotecario' || id == 'card-auxiliar') {
        window.location.href = 'funcionarios'
    }
}