function showError(container, errorMessage) {
    container.className = 'error';
    var msgElem = document.createElement('span');
    msgElem.className = "error-message";
    msgElem.innerHTML = errorMessage;
    container.appendChild(msgElem);
}

function resetError(container) {
    container.className = '';
    if (container.lastChild.className == "error-message") {
        container.removeChild(container.lastChild);
    }
}

function validate(form) {
    var elems = form.elements;

    resetError(elems.nameOfUser.parentNode);
    if (!elems.nameOfUser.value) {
        showError(elems.nameOfUser.parentNode, ' Укажите ваше имя.');
    }
    resetError(elems.emailOfUser.parentNode);
    if (!elems.emailOfUser.value) {
        showError(elems.emailOfUser.parentNode, ' Укажите ваш email.');
    }
    resetError(elems.commentOfUser.parentNode);
    if (!elems.commentOfUser.value) {
        showError(elems.commentOfUser.parentNode, ' Укажите текст комментария.');
    }

    resetError(elems.password.parentNode);

    if (!elems.password.value) {
        showError(elems.password.parentNode, ' Укажите пароль.');
    } else if (elems.password.value != elems.password2.value) {
        showError(elems.password.parentNode, ' Пароли не совпадают.');
    }

}