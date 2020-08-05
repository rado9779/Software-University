import commonPartials from './partials.js';
import { setHeader } from './auth.js';
import { create, get, update, close } from '../models/events.js';

export function getCreate(ctx) {
    setHeader(ctx);
    ctx.loadPartials(commonPartials).partial('./view/events/create.hbs');
}

export function postCreate(ctx) {
    const { name, dateTime, description, imageURL } = ctx.params;
    const organizer = sessionStorage.getItem('user');

    create({ name, dateTime, description, imageURL, organizer, interestedIn: 0 })
        .then({
        })
        .catch(e => console.log(e));
}

export function getDetails(ctx) {
    const id = ctx.params.id;
    setHeader(ctx);
    get(id)
        .then(response => {
            ctx.event = { ...response.data(), id: response.id };
            ctx.isOrganizer = ctx.event.organizer === sessionStorage.getItem('user');
            ctx.loadPartials(commonPartials).partial('./view/events/details.hbs');
        })
        .catch(e => console.log(e));
}

export function getEdit(ctx) {
    const id = ctx.params.id;
    setHeader(ctx);
    get(id)
        .then(response => {
            ctx.event = { ...response.data(), id: response.id };
            ctx.loadPartials(commonPartials).partial('./view/events/edit.hbs');
        })
        .catch(e => console.log(e));
}

export function postEdit(ctx) {
    const { name, dateTime, description, imageURL } = ctx.params;
    const id = ctx.params.id;
    update(id, { name, dateTime, description, imageURL })
        .then(response => {
            ctx.redirect(`#/details/${id}`);
        })
        .catch(e => console.log(e));
}

export function getClose(ctx) {
    const id = ctx.params.id;
    setHeader(ctx);
    close(id)
        .then(response => {
            ctx.redirect('#/home');
        })
        .catch(e => console.log(e));
}

export function getJoin(ctx) {
    const id = ctx.params.id;
    get(id)
        .then(response => {
            const temp = response.data().interestedIn;
            const interestedIn = temp + 1;
            update(id, { interestedIn })
                .then(() => {
                    ctx.redirect(`#/details/${id}`);
                })
                .catch(e => console.log(e));
        })
        .catch(e => console.log(e));
}