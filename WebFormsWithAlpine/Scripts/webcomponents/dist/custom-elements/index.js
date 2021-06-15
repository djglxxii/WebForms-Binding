import { h, attachShadow, proxyCustomElement } from '@stencil/core/internal/client';
export { setAssetPath, setPlatformOptions } from '@stencil/core/internal/client';

const maskedInputCss = ".container.sc-aeg-masked-input{display:-ms-flexbox;display:flex;-ms-flex-align:center;align-items:center}span.material-icons.sc-aeg-masked-input{margin-left:5px;cursor:pointer;-webkit-user-select:none;-moz-user-select:none;-ms-user-select:none;user-select:none}";

const MaskedInput = class extends HTMLElement {
  constructor() {
    super();
    this.__registerHost();
    this.isVisible = false;
  }
  componentDidLoad() {
  }
  render() {
    let icon;
    if (this.isVisible) {
      icon = 'visibility';
    }
    else {
      icon = 'visibility_off';
    }
    return (h("div", { class: 'container' }, h("input", { type: this.isVisible ? 'text' : 'password', name: this.name, value: this.value }), h("span", { class: 'material-icons', onClick: () => this.isVisible = !this.isVisible }, icon)));
  }
  static get style() { return maskedInputCss; }
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

function format(first, middle, last) {
  return (first || '') + (middle ? ` ${middle}` : '') + (last ? ` ${last}` : '');
}

const myComponentCss = ":host{display:block}";

const MyComponent$1 = class extends HTMLElement {
  constructor() {
    super();
    this.__registerHost();
    attachShadow(this);
  }
  getText() {
    return format(this.first, this.middle, this.last);
  }
  render() {
    return h("div", null, "Hello, World! I'm ", this.getText());
  }
  static get style() { return myComponentCss; }
};

const AegMaskedInput = /*@__PURE__*/proxyCustomElement(MaskedInput, [2,"aeg-masked-input",{"name":[1],"value":[1],"isVisible":[1540,"is-visible"]}]);
const AegisEditableList = /*@__PURE__*/proxyCustomElement(EditableList, [2,"aegis-editable-list",{"propertyName":[1,"property-name"],"value":[1],"parsedData":[32]}]);
const MyComponent = /*@__PURE__*/proxyCustomElement(MyComponent$1, [1,"my-component",{"first":[1],"middle":[1],"last":[1]}]);
const defineCustomElements = (opts) => {
  if (typeof customElements !== 'undefined') {
    [
      AegMaskedInput,
  AegisEditableList,
  MyComponent
    ].forEach(cmp => {
      if (!customElements.get(cmp.is)) {
        customElements.define(cmp.is, cmp, opts);
      }
    });
  }
};

export { AegMaskedInput, AegisEditableList, MyComponent, defineCustomElements };
