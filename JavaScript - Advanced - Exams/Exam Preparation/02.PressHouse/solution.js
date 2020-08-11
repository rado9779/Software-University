function solveClasses() {

    class Article {

        constructor(title, content) {
            this.title = title;
            this.content = content;
        }

        toString() {
            let result = '';
            result += `Title: ${this.title}\n`;
            result += `Content: ${this.content}\n`;

            return result.trimEnd();
        }
    }

    class ShortReports extends Article {

        constructor(title, content, originalResearch) {

            if (content.length > 150) {
                throw new Error('Short reports content should be less then 150 symbols.');
            }
            super(title, content);

            if (!originalResearch.title || !originalResearch.author) {
                throw new Error('The original research should have author and title.');
            }

            this.originalResearchTitle = originalResearch.title;
            this.originalResearchAuthor = originalResearch.author;
            this.comments = [];
        }

        addComment(comment) {
            this.comments.push(comment);
            return "The comment is added.";
        }

        toString() {
            let result = '';
            result += `${super.toString()}\n`;
            result += `Original Research: ${this.originalResearchTitle} by ${this.originalResearchAuthor}\n`;

            if (this.comments.length > 0) {
                result += `Comments:\n`;
                result += `${this.comments.join('\n')}`;
            }

            return result.trimEnd();
        }
    }

    class BookReview extends Article {

        constructor(title, content, book) {
            super(title, content);
            this.bookName = book.name;
            this.bookAuthor = book.author;
            this.clients = [];
        }

        addClient(clientName, orderDescription) {

            if (this.clients.find(x => x.clientName === clientName)) {
                throw new Error("This client has already ordered this review.");
            }
            this.clients.push({ clientName, orderDescription });
            return `${clientName} has ordered a review for ${this.bookName}`;
        }

        toString() {
            let result = '';
            result += `${super.toString()}\n`;
            result += `Book: ${this.bookName}\n`;
            if (this.clients.length > 0) {
                result += `Orders:\n`;
                this.clients.forEach(({ clientName, orderDescription }) => {
                    result += `${clientName} - ${orderDescription}\n`;
                });
            }

            return result.trimEnd();
        }
    }

    return {
        Article,
        ShortReports,
        BookReview
    };
}