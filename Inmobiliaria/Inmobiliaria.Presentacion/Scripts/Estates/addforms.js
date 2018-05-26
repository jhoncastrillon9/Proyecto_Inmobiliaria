$(document).ready(function (e) {
    //cuando camabia el inputs
    
    $("#Inmuebles_PrecioPropietario, #Inmuebles_Honorarios, #Inmuebles_Porcentaje, #Inmuebles_IdIva").keydown(function () {
        addsuma();
    });

    $("#Inmuebles_PrecioPropietario, #Inmuebles_Honorarios, #Inmuebles_Porcentaje, #Inmuebles_IdIva").keyup(function () {
        addsuma();
    });

    $("#Inmuebles_PrecioPropietario, #Inmuebles_Honorarios, #Inmuebles_Porcentaje, #Inmuebles_IdIva").keypress(function () {
        addsuma();
    });

    function addsuma() {
        //Limpia el Precio Final
        $("#Inmuebles_PrecioFinal").empty();
        var percentage = $('#Inmuebles_Porcentaje').val() > 0 ? $('#Inmuebles_Porcentaje').val() : 0
        var price = $("#Inmuebles_PrecioPropietario").val() > 0 ? $('#Inmuebles_PrecioPropietario').val() : 0
        var fee = $("#Inmuebles_Honorarios").val() > 0 ? $('#Inmuebles_Honorarios').val() : 0
        var iva = $('#Inmuebles_IdIva').val() > 0 ? $('#Inmuebles_IdIva').val() : 0
        //Values
        commission = (percentage * price) / 100;
        var subtotal = parseFloat(price) + parseFloat(commission) + parseFloat(fee);

        switch (iva) {
            case "1":
                taxes = 0;
                break;
            case "2":
                taxes = (subtotal * 12) / 100;
                break;
            case "3":
                taxes = (subtotal * 16) / 100;
                break;
            case "4":
                taxes = (subtotal * 19) / 100;
                break;
            default:
                taxes = 0;
        }

        var total = parseFloat(subtotal) + parseFloat(taxes);
        //colcoamos el total de la suma
        $('#Inmuebles_PrecioFinal').val(total);
    }


});





