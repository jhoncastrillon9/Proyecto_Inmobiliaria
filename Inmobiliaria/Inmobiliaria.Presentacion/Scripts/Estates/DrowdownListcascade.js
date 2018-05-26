    $(document).ready(function (e) {
        //cuando seleciona un municipio
        $("#Inmuebles_IdMunicipio").change(function () {
            //colocal en blanco las zonas
            $("#Inmuebles_IdZonaMunicipio").empty();
            //ajax
            $.ajax({                
                url: "GetFilterCity",
                data: { id: $('#Inmuebles_IdMunicipio').val() },
                datatype: 'json',  
                type: 'Get',                              
                success: function (entidad) {
                    $.each(entidad, function (i, dato) {
                        $('#Inmuebles_IdZonaMunicipio').append('<option value = "' + dato.Id + '">' + dato.Nombre + '</option>');
                    });
                }


            })
        });
    });
