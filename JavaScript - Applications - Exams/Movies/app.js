import { getHome } from './controllers/home.js';
import { getRegister, getLogin, postRegister, postLogin, getLogout } from './controllers/user.js';
import { getCreate, postCreate, getDetails, getEdit, postEdit, getDelete, getLike } from './controllers/movie.js';

const app = Sammy("body", function () {
    this.use("Handlebars", "hbs");

    //Home
    this.get('#/home', getHome);

    //Register
    this.get('#/register', getRegister);
    this.post('#/register', postRegister);

    //Login
    this.get('#/login', getLogin);
    this.post('#/login', postLogin);

    //Logout
    this.get('#/logout', getLogout);

    //Create Movie
    this.get('#/create', getCreate)
    this.post('#/create', postCreate);

    //Details Movie
    this.get('#/details/:id', getDetails);

    //Edit Movie
    this.get('#/edit/:id', getEdit);
    this.post('#/edit/:id', postEdit);

    //Delete Movie
    this.get('#/delete/:id', getDelete);

    //Like Movie
    this.get('#/like/:id', getLike);
});
app.run('#/home');