import { r as registerInstance, h } from './index-96c20a2b.js';

const validationMessageCss = ".container{position:relative}.message{color:white;background-color:red;border:1px solid brown;padding:2px 4px;border-radius:3px;font-size:12px;pointer-events:none;position:absolute;top:23px;left:0;opacity:0;-webkit-transition:all .5s;transition:all .5s}:host([position='top']) .message{top:-22px}.message.show{opacity:100}";

const ValidationMessage = class {
  constructor(hostRef) {
    registerInstance(this, hostRef);
    this.showMessage = false;
    this.message = '';
  }
  componentWillLoad() {
    this.showMessage = this.message.length > 0;
  }
  render() {
    let messageCss = 'message';
    if (this.showMessage) {
      messageCss += ' show';
    }
    return (
    // when the user changes the value then hide the message.
    h("div", { class: 'container', onChange: () => this.showMessage = false }, h("slot", null), h("div", { class: messageCss }, this.message)));
  }
};
ValidationMessage.style = validationMessageCss;

export { ValidationMessage as aeg_validation_message };
