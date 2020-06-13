function encodeAndDecodeMessages() {

    const messageToEncode = document.getElementsByTagName('textarea')[0];
    const messageToDecode = document.getElementsByTagName('textarea')[1];
    const encodeButton = document.getElementsByTagName('button')[0];
    const decodeButton = document.getElementsByTagName('button')[1];

    encodeButton.addEventListener('click', encode);
    decodeButton.addEventListener('click', decode);

    function encode(e) {
        let message = messageToEncode.value;
        let encoded = '';

        for (let i = 0; i < message.length; i++) {
            let char = message.charCodeAt(i);
            encoded += String.fromCharCode(char += 1);
        }

        messageToDecode.value = encoded;
        messageToEncode.value = '';
    }

    function decode(e) {
        let message = messageToDecode.value;
        let decoded = '';

        for (let i = 0; i < message.length; i++) {
            let char = message.charCodeAt(i);
            decoded += String.fromCharCode(char -= 1);
        }

        messageToDecode.value = decoded;
    }
}