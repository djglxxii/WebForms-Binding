import { r as registerInstance, h } from './index-fb5d324f.js';

const maskedInputCss = ".container.sc-aeg-masked-input{display:-ms-flexbox;display:flex;-ms-flex-align:center;align-items:center}span.material-icons.sc-aeg-masked-input{margin-left:5px;cursor:pointer;-webkit-user-select:none;-moz-user-select:none;-ms-user-select:none;user-select:none}";

const MaskedInput = class {
  constructor(hostRef) {
    registerInstance(this, hostRef);
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
};
MaskedInput.style = maskedInputCss;

export { MaskedInput as aeg_masked_input };
