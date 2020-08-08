import commonPartials from './partials.js';
import { setHeader } from './auth.js';
import { create, get, update, close } from '../models/movies.js';

export function getCreate(ctx) {
    setHeader(ctx);
    ctx.loadPartials(commonPartials).partial('./view/movie/create.hbs');
}


export function postCreate(ctx) {
    const { title, description, imageUrl } = ctx.params;
    const creator = sessionStorage.getItem('user');

    if (creator === null) {
        throw new Error('Please log in');
    }

    if (title === null || description === null || imageUrl === null ||
        title === '' || description === '' || imageUrl === '') {
        throw new Error('Fill all fields');
    }

    create({ title, description, imageUrl, creator: creator, likes: 0, likedBy: [] })
        .then(() => {
            ctx.redirect('#/home');
        })
        .catch(e => console.log(e));
}


export function getDetails(ctx) {
    const id = ctx.params.id;
    setHeader(ctx);
    get(id)
        .then(response => {
            ctx.movie = { ...response.data(), id: response.id };
            ctx.isCreator = ctx.movie.creator === sessionStorage.getItem('user');
            ctx.loadPartials(commonPartials).partial('./view/movie/details.hbs');
        })
        .catch(e => console.log(e));
}

export function getEdit(ctx) {
    const id = ctx.params.id;
    setHeader(ctx);
    get(id)
        .then(response => {
            ctx.movie = { ...response.data(), id: response.id };
            ctx.loadPartials(commonPartials).partial('./view/movie/edit.hbs');
        })
        .catch(e => console.log(e));
}


export function postEdit(ctx) {
    const { title, description, imageUrl } = ctx.params;
    const id = ctx.params.id;

    get(id)
        .then(response => {
            ctx.movie = { ...response.data(), id: response.id };
            const isCreator = ctx.movie.creator === sessionStorage.getItem('user');

            if (isCreator) {
                update(id, { title, description, imageUrl })
                    .then(() => {
                        ctx.redirect(`#/details/${id}`);
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
            ctx.movie = { ...response.data(), id: response.id };
            const isCreator = ctx.movie.creator === sessionStorage.getItem('user');
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

export function getLike(ctx) {
    setHeader(ctx);
    const id = ctx.params.id;

    get(id)
        .then(response => {
            let inputLikes = response.data().likes;
            const inputUsers = response.data().likedBy;
            const user = sessionStorage.getItem('user');

            if (response.data().likedBy.includes(user)) {
            }
            else {
                inputUsers.push(user);
                inputLikes += 1;
            }

            const likedBy = inputUsers;
            const likes = inputLikes;

            update(id, { likes, likedBy })
                .then(() => {
                    ctx.redirect(`#/details/${id}`);
                })
                .catch(e => console.log(e));
        })
        .catch(e => console.log(e));
}


