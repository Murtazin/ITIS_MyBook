//Открывает окно входа
$('.nav__btn-login').on('mousedown', function () { $('#login-layout').show(250); });
//Закрывает окно входа
$('#login-btn_close').on('mousedown', function () { $('#login-layout').hide(250); });
//Закрывает окно регистрации
$('#registration-btn_close').on('mousedown', function () {
	$('#register-layout').hide(250);
	$('#login-layout').hide(100);
});
//Переход на регистрацию
function transitionToRegister() {
	$('#authorization-layout').hide();
	$('#register-layout').show();
}
$('#transition-register').on('mousedown', transitionToRegister);
//Переход на авторизацию
function transitionToLogin() {
	$('#register-layout').hide();
	$('#authorization-layout').show();
}
$('#transition-login').on('mousedown', transitionToLogin);