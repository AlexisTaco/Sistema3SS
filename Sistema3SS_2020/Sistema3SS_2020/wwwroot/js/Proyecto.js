
function AgregarGranja() {
    console.log("Se desencadeno seleccionar granja");
    var SelectGranja = document.getElementById("SelectGranja");
    var NombreGranja = SelectGranja.options[SelectGranja.selectedIndex].text;
    var IdGranja = SelectGranja.options[SelectGranja.selectedIndex].value;
    var ValidarNombre = document.getElementById(IdGranja);
    if (ValidarNombre == null) {
        var divConteinerGranjas = document.getElementById("DivSelectGranja");
        if (NombreGranja != null) {
            var ButtonNombreGran = document.createElement("input");
            ButtonNombreGran.id = IdGranja;
            ButtonNombreGran.className = "form-control";
            ButtonNombreGran.type = "text";
            ButtonNombreGran.readOnly = true;
            ButtonNombreGran.name = NombreGranja;
            
            var funtionNmae = "BorrarGranja(" + "'" + IdGranja +"'"+ ");";
            ButtonNombreGran.setAttribute("onclick", funtionNmae);
            ButtonNombreGran.value = (NombreGranja);
            divConteinerGranjas.appendChild(ButtonNombreGran);
        }
    } else {
        console.log("Ya se agrego esa granja al proyecto");
        return;
    }

}
function BorrarGranja(NombreGranja) {
    var boton = document.getElementById(NombreGranja);
    padre = boton.parentNode;
    padre.removeChild(boton);
};
