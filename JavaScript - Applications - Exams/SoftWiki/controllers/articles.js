import commonPartials from './partials.js';
import { setHeader } from './auth.js';
import { create, get, update, close } from '../models/articles.js';
import categories from './categories.js';

export function getCreate(ctx) {
    setHeader(ctx);
    ctx.loadPartials(commonPartials).partial('./view/article/create.hbs');
}

export function postCreate(ctx) {
    const { title, category, content } = ctx.params;
    const organizer = sessionStorage.getItem('user');

    if (categories.includes(category)) {
        create({ title, category, content, organizer })
            .then(() => {
                ctx.redirect('#/home');
            })
            .catch(e => console.log(e));
    }
}

export function getDetails(ctx) {
    const id = ctx.params.id;
    setHeader(ctx);
    get(id)
        .then(response => {
            ctx.article = { ...response.data(), id: response.id };
            ctx.isOrganizer = ctx.article.organizer === sessionStorage.getItem('user');
            ctx.loadPartials(commonPartials).partial('./view/article/details.hbs');
        })
        .catch(e => console.log(e));
}

export function getEdit(ctx) {
    const id = ctx.params.id;
    setHeader(ctx);
    get(id)
        .then(response => {
            ctx.article = { ...response.data(), id: response.id };
            ctx.loadPartials(commonPartials).partial('./view/article/edit.hbs');
        })
        .catch(e => console.log(e));
}

export function postEdit(ctx) {
    const { title, category, content } = ctx.params;
    const id = ctx.params.id;

    get(id)
        .then(response => {
            ctx.article = { ...response.data(), id: response.id };
            const isOrganizer = ctx.article.organizer === sessionStorage.getItem('user');
            if (isOrganizer) {

                update(id, { title, category, content })
                    .then(() => {
                        ctx.redirect(`#/home`);
                    })
                    .catch(e => console.log(e));
            }
        })
        .catch(e => console.log(e.message))
}


export function getDelete(ctx) {
    setHeader(ctx);
    const id = ctx.params.id;

    get(id)
        .then(response => {
            ctx.article = { ...response.data(), id: response.id };
            const isOrganizer = ctx.article.organizer === sessionStorage.getItem('user');
            if (isOrganizer) {
                close(id)
                    .then(() => {
                        ctx.redirect('#/home');
                    })
                    .catch(e => console.log(e.message));
            }
        })
        .catch(e => console.log(e.message))
}