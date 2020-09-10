
function AgregarGranja() {
    console.log("Se desencadeno seleccionar granja");
    var SelectGranja = document.getElementById("SelectGranja");
    var NombreGranja = SelectGranja.options[SelectGranja.selectedIndex].text;
    var ValidarNombre = document.getElementById(NombreGranja);
    if (ValidarNombre == null) {
        var divConteinerGranjas = document.getElementById("DivSelectGranja");
        if (NombreGranja != null) {
            var ButtonNombreGran = document.createElement("button");
            ButtonNombreGran.id = NombreGranja;
            ButtonNombreGran.type = "button";
            
            var funtionNmae = "BorrarGranja(" +"'"+ NombreGranja +"'"+ ");";
            ButtonNombreGran.setAttribute("onclick",funtionNmae);
            ButtonNombreGran.textContent = (NombreGranja);
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
function RecopilarDatos()
{
    var customer = { contact_name: "Scott", company_name: "HP" };
    $.ajax({
        type: "POST",
        data: JSON.stringify(customer),
        url: "api/Customer",
        contentType: "application/json"
    });
}