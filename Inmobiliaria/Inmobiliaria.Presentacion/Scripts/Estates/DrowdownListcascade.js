    $(document).ready(function (e) {
        //cuando seleciona un municipio
        $("#Inmuebles_IdMunicipio").change(function () {
            //colocal en blanco las zonas
            $("#Inmuebles_IdZonaMunicipio").empty();
            //ajax
            $.ajax({                
                //url: "http://localhost:53509/Inmuebles/GetFilterCity",
                //pruebas produccion
                url: "http://jhoncastrillon9-001-site1.ctempurl.com/Inmuebles/GetFilterCity",
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
