$(document).ready(
  function () {
    $("#formCadastro").submit(function (e) {
      e.preventDefault();
      Cadastrar();
    })
  }
)

function Cadastrar() {
  let parâmetros = {
    Nome: $("#nome").val(),
    Email: $("#email").val(),
    Mensagem: $("#mensagem").val(),
  }
  $.post("/Home/CadastrarInteresse", parâmetros).done(
    function (data) {
      if (data.status = "Ok") {
        $("#formCadastro").after('<p>Obrigado <strong>'+ data.message + '</strong>por nos enviar uma mensagem. Em breve lhe retornamos através do email informado 😁</p>');
        $("#formCadastro").hide();
      } else {
        alert(data.message)
      }
    }
  ).fail(function (){

  })
}
