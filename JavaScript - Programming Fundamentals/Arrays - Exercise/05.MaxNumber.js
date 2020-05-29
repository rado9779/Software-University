function topIntegers(array) {

  let result = [];

  for (let i = 0; i < array.length; i++) {

    let currentElement = array[i];
    let isTop = true;

    for (let j = i + 1; j < array.length; j++) {

      if (array[j] >= currentElement) {
        isTop = false;
      }
    }

    if (isTop) {
      result.push(currentElement);
    }
  }

  console.log(result.join(' '));
}