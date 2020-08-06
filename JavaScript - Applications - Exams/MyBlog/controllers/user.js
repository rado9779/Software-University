import commonPartials from './partials.js';
import { registerUser, login, logout } from '../models/user.js';
import { saveUserInfo, setHeader } from './auth.js'

export function getLogin(ctx) {
    setHeader(ctx);
    ctx.loadPartials(commonPartials).partial('./view/user/login.hbs');
}

export function postLogin(ctx) {
    const { email, password } = ctx.params;

    login(email, password)
        .then(response => {
            saveUserInfo(response.user.email);
            ctx.redirect('#/home');
        })
        .catch(e => console.log(e.message));
}

export function getRegister(ctx) {
    setHeader(ctx);
    ctx.loadPartials(commonPartials).partial('./view/user/register.hbs');
}

export function postRegister(ctx) {
    const { email, password, repeatPassword } = ctx.params;

    if (password !== repeatPassword) {
        throw new Error('Passwords don`t match!');
    }

    registerUser(email, password, repeatPassword)
        .then(response => {
            saveUserInfo(response.user.email);
            ctx.redirect('#/login');
        })
        .catch(e => console.log(e.message))
}

export function getLogout(ctx) {
    setHeader(ctx);
    sessionStorage.clear();

    logout()
        .then(() => {
            ctx.redirect('#/home');
        })
        .catch(e => console.log(e.message));
}