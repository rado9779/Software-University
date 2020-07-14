function attachEvents() {

    const loadButton = document.getElementById('btnLoadPosts');
    const posts = document.getElementById('posts');
    const viewButton = document.getElementById('btnViewPost');
    const postTitle = document.getElementById('post-title');
    const postDetails = document.getElementById('post-body');
    const comments = document.getElementById('post-comments');

    const url = 'https://blog-apps-c12bf.firebaseio.com/';

    loadButton.addEventListener('click', loadPosts);
    viewButton.addEventListener('click', viewPost);

    function renderResponse(response) {
        if (response.status === 200) {
            return response.json();
        }
        throw response;
    }

    function loadPosts() {

        fetch(`${url}posts.json`)
            .then((response) => renderResponse(response))
            .then((data) => printPosts(data));

        function printPosts(data) {
            const postsData = Object.entries(data);

            postsData.forEach(([key, value]) => {
                const option = document.createElement('option');
                option.id = value.id;
                option.value = key;
                option.textContent = value.title;
                posts.appendChild(option);
            });
        }
    }

    function viewPost() {
        const postId = posts.value;

        fetch(`${url}posts/${postId}.json`)
            .then((response) => renderResponse(response))
            .then((data) => printPosts(data))

        function printPosts(data) {
            postTitle.textContent = data.title;
            postDetails.textContent = data.body;
            loadComments(data.id);
        }
    }

    function loadComments(postId) {

        fetch(`${url}comments.json`)
            .then((response) => renderResponse(response))
            .then((data) => printComment(data))

        function printComment(data) {
            comments.innerHTML = '';
            const commentsData = Object.entries(data);

            commentsData.forEach(([key, value]) => {

                if (postId === value.postId) {
                    const li = document.createElement('li');
                    li.textContent = value.text;
                    comments.appendChild(li);
                }
            });
        }
    }
}

attachEvents();