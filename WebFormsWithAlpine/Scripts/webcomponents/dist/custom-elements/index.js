import { attachShadow, h, proxyCustomElement } from '@stencil/core/internal/client';
export { setAssetPath, setPlatformOptions } from '@stencil/core/internal/client';

const editableListCss = "";

const EditableList = class extends HTMLElement {
  constructor() {
    super();
    this.__registerHost();
    attachShadow(this);
    this.inputEl = null;
    this.name = '';
    this.value = '';
  }
  componentDidLoad() {
    if (this.inputEl === null) {
      const parentEl = this.el.parentElement;
      this.inputEl = parentEl.ownerDocument.createElement('input');
      this.inputEl.type = 'hidden';
      this.inputEl.name = this.name;
      this.inputEl.value = this.value;
      parentEl.append(this.inputEl);
    }
  }
  render() {
    return (h("div", { class: 'container' }, "Editable List"));
  }
  get el() { return this; }
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

const AegisEditableList = /*@__PURE__*/proxyCustomElement(EditableList, [1,"aegis-editable-list",{"name":[1],"value":[1537]}]);
const MyComponent = /*@__PURE__*/proxyCustomElement(MyComponent$1, [1,"my-component",{"first":[1],"middle":[1],"last":[1]}]);
const defineCustomElements = (opts) => {
  if (typeof customElements !== 'undefined') {
    [
      AegisEditableList,
  MyComponent
    ].forEach(cmp => {
      if (!customElements.get(cmp.is)) {
        customElements.define(cmp.is, cmp, opts);
      }
    });
  }
};

export { AegisEditableList, MyComponent, defineCustomElements };
