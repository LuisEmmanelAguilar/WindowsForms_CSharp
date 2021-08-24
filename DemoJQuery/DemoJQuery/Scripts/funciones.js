//Primero declarar
//Manejador de Eventos
$(document).ready(iniciarEventos)

//Funcion inicial
function iniciarEventos() {
    $("#btnInfo").click(contenidoDiv);
    function contenidoDiv() {
        $.post("contenido",{},
            function (r){
                $("#contenido").html(r)
            }
       )
  }
}