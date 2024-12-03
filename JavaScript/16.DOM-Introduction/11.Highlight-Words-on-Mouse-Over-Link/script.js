const boldWordsArray = Array.from(document.getElementsByTagName('strong'));

function highlightWords() {
    boldWordsArray.forEach(word => word.style.backgroundColor = 'yellow');
}

function removeHighlight() {
    boldWordsArray.forEach(word => word.style.backgroundColor = 'transparent');
}