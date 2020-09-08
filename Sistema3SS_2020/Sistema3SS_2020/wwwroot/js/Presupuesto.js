function jsFuncion() {
    var selectCon = document.getElementById("SelectConcepcion").value;
    var selectEst = document.getElementById("Selectestanques");
    if (selectCon == 1) {
        selectEst.disabled = false;
    } else {
        selectEst.disabled = true;
    }

}

function jsFuncionNumeroEstanques() {
    var SelectEst = document.getElementById("Selectestanques");
    var length = SelectEst.options.length;
    for (var j = length - 1; j >= 0; j--) {
        SelectEst.options[j] = null;
    }
    var numeroEst = document.getElementById("SelectGranja").value;
    console.log("El numero de estanques que hay en esta granja son: " + numeroEst)
    if (numeroEst == 0) {
        return;
    }
    for ( var i = 1; i <= numeroEst; i++) {
        var option = document.createElement("option");
        option.text = i;
        SelectEst.add(option);
    }
}
