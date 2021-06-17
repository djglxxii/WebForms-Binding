import { h, attachShadow, proxyCustomElement } from '@stencil/core/internal/client';
export { setAssetPath, setPlatformOptions } from '@stencil/core/internal/client';

const maskedInputCss = ".container.sc-aeg-masked-input{display:-ms-flexbox;display:flex;-ms-flex-align:center;align-items:center}span.material-icons.sc-aeg-masked-input{margin-left:5px;cursor:pointer;-webkit-user-select:none;-moz-user-select:none;-ms-user-select:none;user-select:none}";

const MaskedInput = class extends HTMLElement {
  constructor() {
    super();
    this.__registerHost();
    this.isMasked = true;
  }
  render() {
    const icon = this.isMasked
      ? 'visibility_off'
      : 'visibility';
    return (h("div", { class: 'container' }, h("input", { type: this.isMasked ? 'password' : 'text', name: this.name, value: this.value }), h("span", { class: 'material-icons', onClick: () => this.isMasked = !this.isMasked }, icon)));
  }
  static get style() { return maskedInputCss; }
};

const validationMessageCss = ".container{position:relative}.message{color:white;background-color:red;border:1px solid brown;padding:2px 4px;border-radius:3px;font-size:12px;pointer-events:none;position:absolute;top:23px;left:0;opacity:0;-webkit-transition:all .5s;transition:all .5s}:host([position='top']) .message{top:-22px}.message.show{opacity:100}";

const ValidationMessage = class extends HTMLElement {
  constructor() {
    super();
    this.__registerHost();
    attachShadow(this);
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
  static get style() { return validationMessageCss; }
};

const editableListCss = "";

const EditableList = class extends HTMLElement {
  constructor() {
    super();
    this.__registerHost();
  }
  componentWillLoad() {
    console.log(this.value);
    //this.parsedData = JSON.parse(this.value);
  }
  render() {
    return (h("div", null, h("input", { id: this.propertyName, name: this.propertyName, type: 'hidden', value: this.value })));
  }
  static get style() { return editableListCss; }
};

const AegMaskedInput = /*@__PURE__*/proxyCustomElement(MaskedInput, [2,"aeg-masked-input",{"name":[1],"value":[1],"isMasked":[1540,"is-masked"]}]);
const AegValidationMessage = /*@__PURE__*/proxyCustomElement(ValidationMessage, [1,"aeg-validation-message",{"message":[1],"showMessage":[32]}]);
const AegisEditableList = /*@__PURE__*/proxyCustomElement(EditableList, [2,"aegis-editable-list",{"propertyName":[1,"property-name"],"value":[1],"parsedData":[32]}]);
const defineCustomElements = (opts) => {
  if (typeof customElements !== 'undefined') {
    [
      AegMaskedInput,
  AegValidationMessage,
  AegisEditableList
    ].forEach(cmp => {
      if (!customElements.get(cmp.is)) {
        customElements.define(cmp.is, cmp, opts);
      }
    });
  }
};

export { AegMaskedInput, AegValidationMessage, AegisEditableList, defineCustomElements };
