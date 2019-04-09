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
        $('#modal-senha').val('')
        $('#modal-cep').val('')
        $('#modal-rua').val('')
        $('#modal-bairro').val('')
        $('#modal-cidade').val('')
        $('#modal-estado').val('Selecione...')
        $('#modal-numero').val('')
        $('#modal-cargo').val('Cargo...')
        $('#modal-sexo').val('Sexo...')
    }

    

    firebase.firestore().collection("Cursos").get().then(function (querySnapshot) {
        querySnapshot.forEach(function (doc) {
            const data = doc.data();
            area = data.area

            select = document.getElementById('modal-area')
            console.log(select.length)
            for(i = 0; i < select.length; i++) {
                if(area != select.options[i]) {
                    $('#modal-area').append('<option>'+ area +'</option')
                }
            }
        });
    });


    $('#modal-adicionar').click(function () {
        const nome = $('#modal-nome').val()
        const cpf = $('#modal-cpf').val()
        const telefone = $('#modal-telefone').val()
        const email = $('#modal-email').val()
        const senha = $('#modal-senha').val()
        const cep = $('#modal-cep').val()
        const rua = $('#modal-rua').val()
        const bairro = $('#modal-bairro').val()
        const cidade = $('#modal-cidade').val()
        const estado = $('#modal-estado').val()
        const numero = $('#modal-numero').val()
        const area = $('#modal-area').val()
        const sexo = $('#modal-sexo').val()

        if (!nome || !cpf || !telefone || !email || !senha || !cep || !rua || !bairro || !cidade || !estado || estado == 'Selecione...' || !numero || area == 'Área...' || !sexo || sexo == 'Sexo...') {
            alert('Preencha todos os campos')
        }
        else {

            firebase.auth().createUserWithEmailAndPassword(email, senha).then((snapshot) => {
                console.log(snapshot)
                if (sexo == 'Masculino') {
                    photo = '../assets/icons/userMale.png'
                }
                else if (sexo == 'Feminino') {
                    photo = '../assets/icons/userFemale.png'
                }
                else {
                    photo = '../assets/userProfile/user.png'
                }
                snapshot.user.updateProfile({
                    displayName: nome,
                    phoneNumber: telefone,
                    photoURL: photo
                })
                firebase.firestore().collection('Professores').doc(snapshot.user.uid).set({
                    nome: nome,
                    telefone: telefone,
                    cpf: cpf,
                    email: email,
                    cep: cep,
                    rua: rua,
                    bairro: bairro,
                    cidade: cidade,
                    estado: estado,
                    numero: numero,
                    area: area,
                    sexo: sexo
                }).then(function () {
                    alert('Professor cadastrado com sucesso. Logue-se novamente por motivos de segurança')
                    firebase.auth().signOut()
                })
            }).catch(function (error) {
            });


        }
    })

    function OrderByName() {
        firebase.firestore().collection("Professores").orderBy("area", "asc").get().then(function (querySnapshot) {
            querySnapshot.forEach(function (doc) {
                const data = doc.data();
                $('#table-info').append("<tr> <th>" + data.nome + "</th> <th>" + data.area + "</th> <th>" + data.email + "</th> <th>" + data.telefone + "</th> </tr>")
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
