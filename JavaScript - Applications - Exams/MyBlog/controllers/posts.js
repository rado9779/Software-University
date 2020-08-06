import { create, get, update, close } from '../models/posts.js';
import { setHeader } from './auth.js';
import commonPartials from './partials.js';

export function postCreate(ctx) {
    const { title, category, content } = ctx.params;
    const creator = sessionStorage.getItem('user');

    create({ title, category, content, creator })
        .then(() => {
            ctx.redirect('#/home');
        })
        .catch(e => console.log(e.message));
}

export function getDetails(ctx) {
    setHeader(ctx);
    const id = ctx.params.id;

    get(id)
        .then(response => {
            ctx.post = { ...response.data(), id: response.id };
            ctx.isCreator = ctx.post.creator === sessionStorage.getItem('user');
            ctx.loadPartials(commonPartials).partial('./view/posts/details.hbs');
        })
        .catch(e => console.log(e.message))
}

export function getEdit(ctx) {
    setHeader(ctx);
    const id = ctx.params.id;

    get(id)
        .then(response => {
            ctx.post = { ...response.data(), id: response.id };
            const isCreator = ctx.post.creator === sessionStorage.getItem('user');
            if (isCreator) {
                ctx.loadPartials(commonPartials).partial('./view/posts/edit.hbs');
            }
        })
        .catch(e => console.log(e.message))
}

export function postEdit(ctx) {
    const { title, category, content } = ctx.params;
    const id = ctx.params.id;

    update(id, { title, category, content })
        .then(() => {
            ctx.redirect('#/home');
        })
        .catch(e => console.log(e.message));
}

export function getDelete(ctx) {
    setHeader(ctx);
    const id = ctx.params.id;

    get(id)
        .then(response => {
            ctx.post = { ...response.data(), id: response.id };
            const isCreator = ctx.post.creator === sessionStorage.getItem('user');
            if (isCreator) {
                close(id)
                    .then(() => {
                        ctx.redirect('#/home');
                    })
                    .catch(e => console.log(e.message));
            }
        })
        .catch(e => console.log(e.message))
}