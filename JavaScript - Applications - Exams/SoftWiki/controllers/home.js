import commonPartials from './partials.js';
import { setHeader } from './auth.js';
import { getAll } from '../models/articles.js';

export function getHome(ctx) {
    setHeader(ctx);

    getAll()
        .then(response => {
            const articles = response.docs.map(x => x = { ...x.data(), id: x.id });
            ctx.articles = articles.sort((a, b) => b.title.localeCompare(a.title));

            ctx.jsArticles = articles.filter(x => x.category == 'JavaScript');
            ctx.csharpArticles = articles.filter(x => x.category == 'C#');
            ctx.javaArticles = articles.filter(x => x.category == 'Java');
            ctx.pytonArticles = articles.filter(x => x.category == 'Pyton');

            ctx.loadPartials(commonPartials).partial('./view/home.hbs');
        })
}