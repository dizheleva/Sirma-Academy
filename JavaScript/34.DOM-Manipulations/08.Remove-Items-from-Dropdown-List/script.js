function removecolor() {
    const list = document.getElementById('colorSelect');
    const optionIndex = list.selectedIndex;

    list.remove(optionIndex);
}