(function () {

  const templates = {};
  const loadingBoxElement = document.getElementById('loadingBox');

  const firebaseConfig = {
    apiKey: "AIzaSyAiDWkKxTJVdOMp2dWoHwVFHMkoMNudtAQ",
    authDomain: "furniture-1d3ee.firebaseapp.com",
    databaseURL: "https://furniture-1d3ee.firebaseio.com",
    projectId: "furniture-1d3ee",
    storageBucket: "furniture-1d3ee.appspot.com",
    messagingSenderId: "53239525331",
    appId: "1:53239525331:web:4f9c604736d7ffe2e28926",
    measurementId: "G-KM8DZ8KC2D"
  };
  // Initialize Firebase
  firebase.initializeApp(firebaseConfig);
  firebase.analytics();

  function getTemplate(templatePath) {

    const currentTemplate = templates[templatePath];

    if (!currentTemplate) {
      return Promise.resolve(currentTemplate);
    }

    return fetch(`/templates/${templatePath}.hbs`)
      .then(response => response.text())
      .then((data) => {
        const template = Handlebars.compile(data);
        templates[templatePath] = template;
        return template;
      });
  }

  function renderTemplate(templatePath, templateContext, swapFunction) {
    return getTemplate(templatePath).then(templateFunction => {
      const content = templateFunction(templateContext)
      swapFunction(content);
    });
  }

  function loadRegisterPartialTemplate(templatePath, templateName) {
    return fetch(`/templates/partials/${templatePath}.hbs`).then(res => res.text()).then(templateString => {
      Handlebars.registerPartial(templateName, templateString);
      return templateString;
    });
  }

  function loadFurniture() {
    return fetch(`${firebaseConfig.databaseURL}/furniture.json`)
      .then(respnse => respnse.json())
      .then(data => {
        return Object.keys(data).reduce((a, currentId) => {
          const currentItem = data[currentId];
          return a.concat({ id: currentId, ...currentItem });
        }, [])
      })
  }

  function loadFurnitureWithId(id) {
    return fetch(`${firebaseConfig.databaseURL}/furniture/${id}.json`)
      .then(response => response.json());
  }

  function toggleLoader(showLoader) {
    if (showLoader) {
      loadingBoxElement.style.display = 'inline';
      return;
    }
    loadingBoxElement.style.display = 'none';
  }


  const app = Sammy('#container', function () {

    this.before({}, function () {
      toggleLoader(true);
    });

    this.get('#/', function () {
      Promise.all([loadFurniture(), loadRegisterPartialTemplate('furnitureItem', 'furnitureItem')])
        .then(([items]) => renderTemplate('home', { items }, this.swap.bind(this)))
        .then(() => {
          toggleLoader(false);
        });
    });

    this.get('#/profile', function () {
      renderTemplate('profile', {}, this.swap.bind(this))
        .then(() => {
          toggleLoader(false);
        });
    });

    this.get('#/create-furniture', function () {
      renderTemplate('createFurniture', {}, this.swap.bind(this))
        .then(() => {
          toggleLoader(false);
          const onCreateHandler = () => {
            const newMakeElement = document.getElementById('new-make');
            const newModelElement = document.getElementById('new-model');
            const newYearElement = document.getElementById('new-year');
            const newDescriptionElement = document.getElementById('new-description');
            const newPriceElement = document.getElementById('new-price');
            const newImageElement = document.getElementById('new-image');
            const newMaterialElement = document.getElementById('new-material');

            const inputs = [
              newMakeElement,
              newModelElement,
              newYearElement,
              newDescriptionElement,
              newPriceElement,
              newImageElement,
              newMaterialElement,
            ];

            const values = inputs.map(input => input.value);
            const missingInputValue = values.findIndex(v => !v);
            if (missingInputValue !== -1) {
              console.error('MISSING DATA', inputs[missingInputValue]);
              return;
            }

            const body = values.reduce((acc, curr, index) => {
              const currentInputEl = inputs[index];
              acc[currentInputEl.name] = curr;
              return acc;
            }, {});

            const url = `${firebaseConfig.databaseURL}/furniture.json`;
            fetch(url, { method: 'POST', body: JSON.stringify(body) }).then(() => {
              this.redirect('#/');
            });
          }

          const createButton = document.getElementById('create-btn');

          createButton.addEventListener('click', onCreateHandler);
        });
    });

    this.get('#/furniture-detail/:id', function (context) {
      const id = context.params.id;
      loadFurnitureWithId(id)
        .then(furniture => renderTemplate('furnitureDetail', { furniture }, this.swap.bind(this)))
        .then(() => {
          toggleLoader(false);
        });
    });

  });

  app.run('#/');
}());