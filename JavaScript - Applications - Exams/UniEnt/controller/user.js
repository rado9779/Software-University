import commonPartials from './partials.js';
import { registerUser, login, logout } from '../models/user.js';
import { saveUserInfo, setHeader } from './auth.js';

//GET
export function getLogin(ctx) {
    setHeader(ctx);
    ctx.loadPartials(commonPartials).partial('./view/user/login.hbs')
}

export function getProfile(ctx) {
    setHeader(ctx);
    ctx.loadPartials(commonPartials).partial('./view/user/profile.hbs')
}

export function getRegister(ctx) {
    setHeader(ctx);
    ctx.loadPartials(commonPartials).partial('./view/user/register.hbs')
}

export function getLogout(ctx) {
    setHeader(ctx);
    sessionStorage.clear();

    logout()
        .then(() => {
            notification('successBox', 'Logout successful.');
            setTimeout(() => {
                ctx.redirect('#/login');
            }, 2000);

        })
        .catch(e => notification('errorBox', e.message));
}

//POST
export function postRegister(ctx) {

    const { username, password, rePassword } = ctx.params;

    if (password !== rePassword) {
        throw new Error('Passwords don`t match!');
    }

    registerUser(username, password)
        .then(response => {
            saveUserInfo(response.user.email);
            notification('successBox', 'User registration successful.');
            
            setTimeout(() => {
                ctx.redirect('#/home');
            }, 2000);
        })
        .catch(e => notification('errorBox',e.message));
}

export function postLogin(ctx) {
    const { username, password } = ctx.params;
    login(username, password)
        .then(response => {
            saveUserInfo(response.user.email);

            notification('successBox', 'Login successful.');
            setTimeout(() => {
                ctx.redirect('#/home');
            }, 2000);
        })
        .catch(e => notification('errorBox',e.message));;
}

function notification(status, message) {
    const notification = document.getElementById(status);
    notification.textContent = message;
    notification.style.display = 'block';
}

