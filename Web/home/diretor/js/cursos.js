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
        $('#modal-area').val('Selecione...')
        $('#modal-cargaHor').val('')
        $('#modal-mensalidade').val('')
    }


    $('#modal-adicionar').click(function () {
        const nome = $('#modal-nome').val()
        const area = $('#modal-area').val()
        const cargaHor = $('#modal-cargaHor').val()
        const mensalidade = $('#modal-mensalidade').val()
     

        if (!nome || !area || !cargaHor || !mensalidade || area == 'Selecione...') {
            alert('Preencha todos os campos')
        }
        else {
            firebase.firestore().collection('Cursos').add({
                nome: nome,
                area: area,
                cargaHor: cargaHor,
                mensalidade: mensalidade
            }).then(function () {
                alert('Curso cadastrado com sucesso')
                $('#modal-addCliente').modal('hide')                        
                LimparForm()
                $('#table-info').html('')
                OrderByName()
            })
        }
    })

    function OrderByName() {
        firebase.firestore().collection("Cursos").orderBy("nome", "asc").get().then(function (querySnapshot) {
            querySnapshot.forEach(function (doc) {
                console.log(doc)
                const data = doc.data();
                $('#table-info').append("<tr> <th>" + data.nome + "</th> <th>" + data.area + "</th> <th>" + data.cargaHor + ' horas' + "</th> <th>" + 'R$ ' + data.mensalidade + "</th> </tr>")
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