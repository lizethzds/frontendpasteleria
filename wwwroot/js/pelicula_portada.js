const imagen = document.querySelector(".foto");
const archivo = document.getElementById("ArchivoId");

function CargaImagen() {

    if (archivo.selectedIndex > 0) {
        const path = imagen.dataset.url + "/api/archivos/" + archivo.options[archivo.selectedIndex].value;
        imagen.src = path;
    }
}

archivo.addEventListener("change", CargaImagen);