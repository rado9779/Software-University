import commonPartials from './partials.js';
import { setHeader, saveUserInfo } from './auth.js';
import { registerUser, login, logout } from '../models/user.js';


//Register
export function getRegister(ctx) {
    setHeader(ctx);
    ctx.loadPartials(commonPartials).partial('./view/user/register.hbs')
}

export function postRegister(ctx) {
    const { email, password, repeatPassword } = ctx.params;

    if (password !== repeatPassword) {
        throw new Error('Passwords don`t match!');
    }

    registerUser(email, password)
        .then(response => {
            saveUserInfo(response.user.email);

            ctx.redirect('#/home');
        })
        .catch(e => console.log(e.message));
}

//Login
export function getLogin(ctx) {
    setHeader(ctx);
    ctx.loadPartials(commonPartials).partial('./view/user/login.hbs')
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

//Logout
export function getLogout(ctx) {
    setHeader(ctx);
    sessionStorage.clear();

    logout()
        .then(() => {
            ctx.redirect('#/login');
        })
        .catch(e => console.log(e.message));
}