/*
	EFECTOS ESPECIALES INPUT
		ANIMACION ARRIBA / ABAJO DE TEXTOS DE INFORMACION INPUT'S
*/
// SI INPUT EXISTE ENTONCES

const inputs = document.querySelectorAll(".input");
function AgregarInformacion() {
    let parent = this.parentNode.parentNode;
    parent.classList.add("focus");
}

function RemoverInformacion() {
    let parent = this.parentNode.parentNode;
    if (this.value == "") {
        parent.classList.remove("focus");
    }
}

/*LLAMANDO EVENTOS*/
inputs.forEach(input => {
    input.addEventListener("focus", AgregarInformacion);
    input.addEventListener("blur", RemoverInformacion);
});