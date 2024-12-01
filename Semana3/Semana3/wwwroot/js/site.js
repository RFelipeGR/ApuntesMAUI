// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function CrearAlerta() {
    alert("Crea Alerta");
}

function Sumar() {
    var Numero1 = document.getElementById("Numero1").value;
    var Numero2 = document.getElementById("Numero2").value;

    var suma = parseInt( Numero1 ) + parseInt( Numero2 );

    document.getElementById("Resultado").value = suma;

}

