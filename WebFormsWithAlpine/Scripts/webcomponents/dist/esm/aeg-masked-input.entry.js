import { r as registerInstance, h } from './index-96c20a2b.js';

const maskedInputCss = ".container.sc-aeg-masked-input{display:-ms-flexbox;display:flex;-ms-flex-align:center;align-items:center}span.material-icons.sc-aeg-masked-input{margin-left:5px;cursor:pointer;-webkit-user-select:none;-moz-user-select:none;-ms-user-select:none;user-select:none}";

const MaskedInput = class {
  constructor(hostRef) {
    registerInstance(this, hostRef);
    this.isMasked = true;
  }
  render() {
    const icon = this.isMasked
      ? 'visibility_off'
      : 'visibility';
    return (h("div", { class: 'container' }, h("input", { type: this.isMasked ? 'password' : 'text', name: this.name, value: this.value }), h("span", { class: 'material-icons', onClick: () => this.isMasked = !this.isMasked }, icon)));
  }
};
MaskedInput.style = maskedInputCss;

export { MaskedInput as aeg_masked_input };
