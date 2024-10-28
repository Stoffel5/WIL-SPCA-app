const sidebarToggle = document.querySelector('.sidebar');

window.addEventListener('resize', () => {
    if (window.innerWidth <= 768) {
        sidebarToggle.classList.add('collapsed');
    } else {
        sidebarToggle.classList.remove('collapsed');
    }
});
