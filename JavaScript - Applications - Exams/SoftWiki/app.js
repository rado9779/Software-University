import { getHome } from './controllers/home.js';
import { getRegister, getLogin, postRegister, postLogin, getLogout } from './controllers/user.js';
import { getCreate, postCreate, getDetails, getEdit, postEdit, getDelete } from './controllers/articles.js';

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

    //Create Article
    this.get('#/create', getCreate);
    this.post('#/create', postCreate);

    //Details
    this.get('#/details/:id', getDetails);

    //Edit
    this.get('#/edit/:id', getEdit);
    this.post('#/edit/:id', postEdit);

    //Delete
    this.get('#/delete/:id', getDelete)

});
app.run('#/home');