

function jsFuncionNumeroEstanques() {

    console.log("Se desencadeno la funcion secuencia de cambios");
    var TipoConception = document.getElementById("SelectConcepcion");
    var SelcGran = document.getElementById("SelectGranja");
    var SelcEstquest = document.getElementById("Selectestanquest");
    if (SelcGran.value == 0) {
        console.log("No se selecciono elemento valido");
        TipoConception.disabled = true;
        return;
    }
    else {
        console.log("Se activo sleeccionador de graja");
        TipoConception.disabled = false;
    }
    if (SelectConcepcion.value == 0) {
        console.log("No se selecciono elemento valido");
        SelcEstquest.disabled = true;
        return;
    } else {
        console.log("Se activo sleeccionador de graja");
        SelcEstquest.disabled = false;
    }

    var divEliminar = document.getElementById("checkboxes");
    if (!divEliminar) {
        console.log("No existe el div");
    }
    else {
        var padre = divEliminar.parentNode;
        padre.removeChild(divEliminar);
        console.log("Se elimino el div");
    }
    var SelectEst = document.getElementById("Selectestanquest");
    var length = SelectEst.options.length;
    for (var j = length - 1; j >= 0; j--) {
        SelectEst.options[j] = null;
    }
    var numeroEst = document.getElementById("SelectGranja").value;
    var numeroElect = document.getElementById("SelectConcepcion").value;
    console.log("El numero de estanques que hay en esta granja son: " + numeroEst)
    if (numeroElect == 2) {
        var Est2 = document.getElementById("Est2");
        console.log("Desancadena seleccionar solo uno");
        Est2.visibility = false;
        for (var i = 1; i <= numeroEst; i++) {
            var option = document.createElement("option");
            option.text = i;
            SelectEst.add(option);
        }
        var Est1 = document.getElementById("Est1");
        Est1.style.visibility = "visible";
    } if (numeroElect == 1) {
        console.log("Desancadena seleccionar varios");
        var Est2 = document.getElementById("Est2");
        Est2.visibility = true;
        var CreateDivCheckboxes = document.createElement("div");
        CreateDivCheckboxes.id = "checkboxes";
        CreateDivCheckboxes.className = "container";
        Est2.appendChild(CreateDivCheckboxes);
        var checkboxes = document.getElementById("checkboxes");
        if (checkboxes) {
            console.log("se creo el div para los checkboxes");
        }
        for (var z = 1; z <= numeroEst; z++) {
            var check = document.createElement("input");
            var label = document.createElement("label");
            var br = document.createElement("br");
            check.type = "checkbox";
            label.textContent ="Estanque " + z+".";
            label.className = "lbGenerateJs";
            checkboxes.appendChild(label);
            checkboxes.appendChild(check);
            checkboxes.appendChild(br);
        }
        Est2.style.visibility = "visible";
    }
    else {
        console.log("No se selecciono opcion con desencadenadores");
        return;
    }

}
function SecuenciaDeCambios() {
    console.log("Se desencadeno la funcion secuencia de cambios");
    var TipoPres = document.getElementById("TipoPres");
    var SelcGran = document.getElementById("SelectGranja");
    if (TipoPres.value == 0) {
        console.log("No se selecciono elemento valido");
        SelcGran.disabled = true;
        return;
    }
    else {  
        console.log("Se activo sleeccionador de graja");
        SelcGran.disabled = false;
    }
}
