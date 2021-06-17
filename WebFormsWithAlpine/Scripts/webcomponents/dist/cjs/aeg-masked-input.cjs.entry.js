'use strict';

Object.defineProperty(exports, '__esModule', { value: true });

const index = require('./index-9a89354e.js');

const maskedInputCss = ".container.sc-aeg-masked-input{display:-ms-flexbox;display:flex;-ms-flex-align:center;align-items:center}span.material-icons.sc-aeg-masked-input{margin-left:5px;cursor:pointer;-webkit-user-select:none;-moz-user-select:none;-ms-user-select:none;user-select:none}";

const MaskedInput = class {
  constructor(hostRef) {
    index.registerInstance(this, hostRef);
    this.isMasked = true;
  }
  render() {
    const icon = this.isMasked
      ? 'visibility_off'
      : 'visibility';
    return (index.h("div", { class: 'container' }, index.h("input", { type: this.isMasked ? 'password' : 'text', name: this.name, value: this.value }), index.h("span", { class: 'material-icons', onClick: () => this.isMasked = !this.isMasked }, icon)));
  }
};
MaskedInput.style = maskedInputCss;

exports.aeg_masked_input = MaskedInput;
