import { getHome } from './controller/home.js';
import { getLogin, getProfile, getLogout, getRegister, postRegister, postLogin } from './controller/user.js';
import { getCreate, postCreate, getDetails, getEdit, getClose, getJoin } from './controller/event.js';

const app = Sammy("body", function () {
    this.use("Handlebars", "hbs");

    //GET
    this.get('#/home', getHome);

    this.get('#/login', getLogin);

    this.get('#/profile', getProfile);

    this.get('#/logout', getLogout);

    this.get('#/create', getCreate);

    this.get('#/register', getRegister);

    this.get('#/details/:id', getDetails);

    this.get('#/edit/:id', getEdit);

    this.get('#/close/:id', getClose)

    this.get('#/join/:id', getJoin);

    //POST
    this.post('#/register', postRegister);

    this.post('#/login', postLogin);

    this.post('#/create', postCreate);

});
app.run('#/home');