function solve() {

   const chatBox = document.querySelector('#chat_messages');
   const sendButton = document.querySelector('#send');
   const text = document.querySelector('#chat_input');

   sendButton.addEventListener('click', sendMessage);

   function sendMessage() {

      const textMessage = text.value;
      const message = document.createElement('div');

      message.classList.add('message', 'my-message');
      message.textContent = textMessage;

      chatBox.appendChild(message);
      text.value = '';
   }
}