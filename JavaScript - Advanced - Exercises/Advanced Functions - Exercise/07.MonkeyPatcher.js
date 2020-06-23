function solution(input) {

    const calculateScore = (x) => {
        const result = [];
        const votes = x.upvotes + x.downvotes;

        if (votes <= 50) {
            result.push(x.upvotes);
            result.push(x.downvotes);
        }
        else {
            let modifier = Math.ceil(Math.max(x.upvotes, x.downvotes) * 0.25);
            result.push(x.upvotes + modifier);
            result.push(x.downvotes + modifier);
        }
        result.push(result[0] - result[1]);

        let upvotesPercent = 100 * x.upvotes / votes;

        if (votes < 10) {
            result[3] = 'new';
        }
        else if (upvotesPercent > 66) {
            result[3] = 'hot';
        }
        else if (result[2] < 0) {
            result[3] = 'unpopular';
        }
        else if (x.upvotes > 100 || x.downvotes > 100) {
            result[3] = 'controversial';
        }
        else {
            result[3] = 'new';
        }

        return result;
    }

    if (input === 'upvote') {
        this.upvotes++;
    }
    else if (input === 'downvote') {
        this.downvotes++;
    }
    else if (input === 'score') {
        return calculateScore(this);
    }
}