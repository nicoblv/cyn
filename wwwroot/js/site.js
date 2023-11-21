function myFunction() {
    if ($('#inputUsuario').val() == "" || $('#inputPassword').val() == "") {
        tpl = '<div class="alert alert-danger" role="alert">Ingrese datos</div>';
        $('#msjError').html(tpl)
    }
    else {
        $.ajax({
            url: '@Url.Action("Validar","Home")',
            data: { usuario: $("#inputUsuario").val(), password: $("#inputPassword").val() },
            type: "GET",
            dataType: "json",
            contentType: "application/json; charset=utf-8",
            success: function (data) {
                if (data.data == true) {
                    tpl = '<div class="alert alert-danger" role="alert">Error al iniciar Sesión, verifique sus datos y vuelva a intentarlo</div>';
                    $('#formulRespuesta').html(tpl)
                }
                else {
                    tpl = '<div class="alert alert-danger" role="alert">Error al iniciar Sesión, verifique sus datos y vuelva a intentarlo</div>';
                    $('#formulRespuesta').html(tpl)
                }
            },
            error: function (data) {
                tpl = '<div class="alert alert-danger" role="alert">Error al iniciar Sesión, verifique sus datos y vuelva a intentarlo</div>';
                $('#formulRespuesta').html(tpl)
            }
        });
    }
};