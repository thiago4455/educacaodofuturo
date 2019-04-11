$(document).ready(function () {

    firebase.auth().onAuthStateChanged(function (user) {

        if (user) {

        }
        else {
            window.location.href = '../index'
        }

    });

    $('#modal-limpar').click(function (e) {
        e.preventDefault()
        LimparForm()
    })

    function LimparForm() {
        $('#modal-nome').val('')
        $('#modal-cargaHor').val('')
        $('#modal-descricao').val('')
        $('#modal-curso').val('Curso...')
    }

    firebase.firestore().collection("Cursos").get().then(function (querySnapshot) {
        querySnapshot.forEach(function (doc) {
            const data = doc.data();
            nomeCurso = data.nome

            $('#modal-curso').append('<option>' + nomeCurso + '</option')
        })
    })

    $('#modal-adicionar').click(function () {
        const nome = $('#modal-nome').val()
        const cargaHor = $('#modal-cargaHor').val()
        const descricao = $('#modal-descricao').val()
        const curso = $('#modal-curso').val()

        if (!nome || !cargaHor || !descricao || !curso || curso == 'Curso...') {
            alert('Preencha todos os campos')
        }
        else {
            firebase.firestore().collection('Cursos/' + uid + '/Materias').doc(snapshot.user.uid).set({
                nomeCurso: nome,
                cargaHor: cargaHor,
                descricao: descricao,
                nomeMateria: curso
            }).then(function () {
                alert('Matéria cadastrada com sucesso.')
                firebase.auth().signOut()
            })
        }
    })

    function OrderByName() {
        firebase.firestore().collection("Cursos").orderBy("area", "asc").get().then(function (querySnapshot) {
            querySnapshot.forEach(function (doc) {
                const data = doc.data();
                $('#table-info').append("<tr> <th>" + data.nomeCurso + "</th> <th>" + data.cargaHor + "</th> <th>" + data.descricao + "</th> <th>" + data.nomeMateria + "</th> </tr>")
            });
        });
        setTimeout(OrderLoad, 2000)
    }

    OrderByName()

    $('.order-item').click(function () {
        id = $(this).attr("id")
        LimparOrder(id)
    })

    function LimparOrder(id) {
        $('.order-item').removeClass('order-item-active')
        $('#' + id).addClass('order-item-active')
        $('#table-info').html('')
        $('#loading').css('display', 'flex')

        if (id == 'order-nome') {
            OrderByName()
        }
        else if (id == 'order-quant') {
            OrderByQuant()
        }
        else {
            OrderByPreco()
        }
    }
})

$(window).on('load', function () {

    setTimeout(OrderLoad, 2000)

})

function OrderLoad() {
    $('#loading').css('display', 'none')
}