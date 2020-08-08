import commonPartials from './partials.js';
import { setHeader } from './auth.js';
import { getAll } from '../models/movies.js';

export function getHome(ctx) {
    setHeader(ctx);

    getAll()
        .then(response => {
            const movies = response.docs.map(x => x = { ...x.data(), id: x.id });
            ctx.movies = movies;
            ctx.loadPartials(commonPartials).partial('./view/home.hbs');
        })
}