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
        $('#modal-cpf').val('')
        $('#modal-telefone').val('')
        $('#modal-email').val('')
        $('#modal-cep').val('')
        $('#modal-rua').val('')
        $('#modal-bairro').val('')
        $('#modal-cidade').val('')
        $('#modal-estado').val('Selecione...')
        $('#modal-numero').val('')
    }


    $('#modal-adicionar').click(function () {
        const nome = $('#modal-nome').val()
        const cpf = $('#modal-cpf').val()
        const telefone = $('#modal-telefone').val()
        const email = $('#modal-email').val()
        const cep = $('#modal-cep').val()
        const rua = $('#modal-rua').val()
        const bairro = $('#modal-bairro').val()
        const cidade = $('#modal-cidade').val()
        const estado = $('#modal-estado').val()
        const numero = $('#modal-numero').val()

        if (!nome || !cpf || !telefone || !email || !cep || !rua || !bairro || !cidade || !estado || estado == 'Selecione...' || !numero) {
            alert('Preencha todos os campos')
        }
        else {
            firebase.firestore().collection('Clientes').add({
                nome: nome,
                cpf: cpf,
                telefone: telefone,
                email: email,
                cep: cep,
                rua: rua,
                bairro: bairro,
                cidade: cidade,
                estado: estado,
                numero: numero
            }).then(function () {
                alert('Cliente cadastrado com sucesso')
                $('#modal-addCliente').modal('hide')                        
                LimparForm()
                $('#table-info').html('')
                OrderByName()
            })
        }
    })

    function OrderByName() {
        firebase.firestore().collection("Clientes").orderBy("nome", "asc").get().then(function (querySnapshot) {
            querySnapshot.forEach(function (doc) {
                const data = doc.data();
                $('#table-info').append("<tr> <th>" + data.nome + "</th> <th>" + data.cpf + "</th> <th>" + data.telefone + "</th> <th>" + data.email + "</th> <th>" + data.cep + "</th> <th>" + data.rua + "</th> <th>" + data.bairro + "</th> <th>" + data.cidade + "</th> <th>" + data.estado + "</th> <th>" + data.numero + "</th> </tr>")
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

$('#modal-cep').mask('00000-000');
$('#modal-cpf').mask('000.000.000-00', { reverse: true });
$('#modal-telefone').mask('(00) 00000-0000')


$("#modal-cep").keyup(function () {

    if ($('#modal-cep').val().length == 9) {

        //Nova variável "cep" somente com dígitos.
        var cep = $(this).val().replace(/\D/g, '');

        //Verifica se campo cep possui valor informado.
        if (cep != "") {

            //Expressão regular para validar o CEP.
            var validacep = /^[0-9]{8}$/;

            //Valida o formato do CEP.
            if (validacep.test(cep)) {

                //Preenche os campos com "..." enquanto consulta webservice.
                $("#modal-rua").val("Aguarde...");
                $("#modal-bairro").val("Aguarde...");
                $("#modal-cidade").val("Aguarde...");
                $("#modal-estado").val("Aguarde...");

                //Consulta o webservice viacep.com.br/
                $.getJSON("https://viacep.com.br/ws/" + cep + "/json/?callback=?", function (dados) {

                    if (!("erro" in dados)) {
                        //Atualiza os campos com os valores da consulta.
                        $("#modal-rua").val(dados.logradouro);
                        $("#modal-bairro").val(dados.bairro);
                        $("#modal-cidade").val(dados.localidade);
                        $("#modal-estado").val(dados.uf);
                    } //end if.
                    else {
                        //CEP pesquisado não foi encontrado.
                        alert("CEP não encontrado.");
                    }
                });
            } //end if.
            else {
                alert("Formato de CEP inválido.");
            }
        } //end if.
        else {
            //cep sem valor, limpa formulário.
        }
    }
});
