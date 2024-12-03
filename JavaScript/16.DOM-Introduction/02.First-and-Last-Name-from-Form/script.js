function getFormvalue() {
    const firstNameElement = document.querySelector('input[name=fname]');
    const lastNameElement = document.querySelector('input[name=lname]');

    alert(`Hello, ${firstNameElement.value} ${lastNameElement.value}`);
}