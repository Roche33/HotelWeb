// Mostrar/ocultar menú hamburguesa
document.getElementById("toggle-btn").addEventListener("click", function () {
    const menu = document.getElementById("mobile-menu");
    menu.classList.toggle("hidden");
});

function openModal() {
    document.getElementById('modal').classList.remove('hidden');
}

function closeModal() {
    document.getElementById('modal').classList.add('hidden');
}
function mostrarImagenes() {
    document.getElementById("modal").classList.remove("hidden");
}
function cambiarImagen(imagenSeleccionada) {
    const imagenPrincipal = document.getElementById("imagenPrincipal");
    imagenPrincipal.src = imagenSeleccionada.src;
    closeModal();
}