'use strict';

Object.defineProperty(exports, '__esModule', { value: true });

const index = require('./index-763fbae9.js');

const validatedInputCss = "#container{position:relative}#message{background-color:red;border:1px solid brown;border-radius:3px;padding:3px;color:white;pointer-events:none;position:absolute;top:23px;left:0;-webkit-transition:all 300ms;transition:all 300ms;opacity:0}:host([position='top']) #message{top:-28px}:host([changed='false']) #message{opacity:100}";

const ValidatedInput = class {
  constructor(hostRef) {
    index.registerInstance(this, hostRef);
    this.message = null;
  }
  componentWillLoad() {
    if (this.message) {
      this.el.setAttribute('changed', 'false');
    }
  }
  render() {
    return (index.h("div", { id: 'container', onChange: () => this.el.setAttribute('changed', 'true') }, index.h("slot", null), index.h("div", { id: 'message' }, this.message)));
  }
  get el() { return index.getElement(this); }
};
ValidatedInput.style = validatedInputCss;

exports.aegis_validated_input = ValidatedInput;
