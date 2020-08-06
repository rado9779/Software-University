import commonPartials from './partials.js';
import { setHeader } from './auth.js';
import { getAll } from '../models/posts.js';

export function getHome(ctx) {
    setHeader(ctx);
    getAll()
        .then(response => {
            const data = response.docs.map(x => x = { ...x.data(), id: x.id });
            ctx.posts = data;
            ctx.loadPartials(commonPartials).partial('./view/home.hbs');
        })
        .catch(e => console.log(e.message));
}