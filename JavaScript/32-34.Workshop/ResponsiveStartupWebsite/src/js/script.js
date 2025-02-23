const burgerMenu = document.getElementById('burger-menu');
const nav = document.getElementsByTagName('nav');

burgerMenu.addEventListener('click', () => {
    // Toggle the navigation menu
    nav.classList.toggle('nav-active');

    // Animate the burger menu icon
    burgerMenu.classList.toggle('toggle');
});