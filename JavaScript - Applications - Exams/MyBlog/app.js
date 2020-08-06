import { getHome } from './controllers/home.js';
import { getLogin, getRegister, postRegister, postLogin, getLogout } from './controllers/user.js';
import { postCreate, getDetails, getEdit, postEdit, getDelete } from './controllers/posts.js';

const app = Sammy("body", function () {
    this.use("Handlebars", "hbs");

    //Home
    this.get('#/home', getHome);

    //Login
    this.get('#/login', getLogin);
    this.post('#/login', postLogin);

    //Register
    this.get('#/register', getRegister);
    this.post('#/register', postRegister);

    //Logout
    this.get('#/logout', getLogout);

    //Create Post
    this.post('#/create', postCreate);

    //Post Details
    this.get('#/details/:id', getDetails);

    //Edit Post
    this.get('#/edit/:id', getEdit);
    this.post('#/edit/:id', postEdit);

    //Delete Post
    this.get('#/delete/:id', getDelete);
});
app.run('#/home');