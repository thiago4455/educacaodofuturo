$(document).ready(function () {


    $('#busca-btn').click(function () {
        if ($('#busca-input').val() == "") {
            $('#busca-input').toggleClass('busca-active')
        }
    })

    $('#sair').click(function () {
        Deslogar();
    })

    $('.item').click(function () {
        id = $(this).attr("id")
        NavLateral(id)
        Page(id)
    })

    $('.cel-menu').click(() => {
        $('.nav-lateral').css('display','flex')
        $('#btn-voltar').css('display','flex')
    })

    $('#btn-voltar').click(() => {
        $('.nav-lateral').css('display','none')
        $('#btn-voltar').css('display','none')
    })

})

$(window).on('load', function () {

    $('#loading').css('display', 'none')

})

function Deslogar() {
    firebase.auth().signOut().then(function () {
    });
    window.location.href = '../index'
}

function NavLateral(id) {
    $('.item').removeClass('item-active')
    $('#' + id).addClass('item-active')
}

function Page(id) {

    if (id == 'nav-home') {
        const caminho = 'diretor/home.html'
        PageLoad(caminho)
    }
    else if (id == 'nav-cursos') {
        const caminho = 'diretor/cursos.html'
        PageLoad(caminho)
    }
    else if (id == 'nav-func') {
        const caminho = 'diretor/funcionarios.html'
        PageLoad(caminho)
    }
    else if (id == 'nav-relatorio') {
        const caminho = 'diretor/relatorios.html'
        PageLoad(caminho)
    }
}

function PageLoad(caminho) {
    const iframe = document.getElementById('iframe')
    iframe.src = caminho
}
