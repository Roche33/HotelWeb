// Mostrar/ocultar menú hamburguesa
document.getElementById("toggle-btn").addEventListener("click", function () {
    const menu = document.getElementById("mobile-menu");
    menu.classList.toggle("hidden");
});