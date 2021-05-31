import { attachShadow, h, proxyCustomElement } from '@stencil/core/internal/client';
export { setAssetPath, setPlatformOptions } from '@stencil/core/internal/client';

const validatedInputCss = "#container{position:relative}#message{background-color:red;border:1px solid brown;border-radius:3px;padding:3px;color:white;pointer-events:none;position:absolute;top:23px;left:0;-webkit-transition:all 300ms;transition:all 300ms;opacity:0}:host([position='top']) #message{top:-28px}:host([changed='false']) #message{opacity:100}";

const ValidatedInput = class extends HTMLElement {
  constructor() {
    super();
    this.__registerHost();
    attachShadow(this);
    this.message = null;
  }
  componentWillLoad() {
    if (this.message) {
      this.el.setAttribute('changed', 'false');
    }
  }
  render() {
    return (h("div", { id: 'container', onChange: () => this.el.setAttribute('changed', 'true') }, h("slot", null), h("div", { id: 'message' }, this.message)));
  }
  get el() { return this; }
  static get style() { return validatedInputCss; }
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

const AegisValidatedInput = /*@__PURE__*/proxyCustomElement(ValidatedInput, [1,"aegis-validated-input",{"message":[1]}]);
const MyComponent = /*@__PURE__*/proxyCustomElement(MyComponent$1, [1,"my-component",{"first":[1],"middle":[1],"last":[1]}]);
const defineCustomElements = (opts) => {
  if (typeof customElements !== 'undefined') {
    [
      AegisValidatedInput,
  MyComponent
    ].forEach(cmp => {
      if (!customElements.get(cmp.is)) {
        customElements.define(cmp.is, cmp, opts);
      }
    });
  }
};

export { AegisValidatedInput, MyComponent, defineCustomElements };
