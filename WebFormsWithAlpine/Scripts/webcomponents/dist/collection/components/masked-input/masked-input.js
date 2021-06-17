import { Component, h, Prop } from '@stencil/core';
export class MaskedInput {
  constructor() {
    this.isMasked = true;
  }
  render() {
    const icon = this.isMasked
      ? 'visibility_off'
      : 'visibility';
    return (h("div", { class: 'container' },
      h("input", { type: this.isMasked ? 'password' : 'text', name: this.name, value: this.value }),
      h("span", { class: 'material-icons', onClick: () => this.isMasked = !this.isMasked }, icon)));
  }
  static get is() { return "aeg-masked-input"; }
  static get encapsulation() { return "scoped"; }
  static get originalStyleUrls() { return {
    "$": ["masked-input.css"]
  }; }
  static get styleUrls() { return {
    "$": ["masked-input.css"]
  }; }
  static get properties() { return {
    "name": {
      "type": "string",
      "mutable": false,
      "complexType": {
        "original": "string",
        "resolved": "string",
        "references": {}
      },
      "required": false,
      "optional": false,
      "docs": {
        "tags": [],
        "text": ""
      },
      "attribute": "name",
      "reflect": false
    },
    "value": {
      "type": "string",
      "mutable": false,
      "complexType": {
        "original": "string",
        "resolved": "string",
        "references": {}
      },
      "required": false,
      "optional": false,
      "docs": {
        "tags": [],
        "text": ""
      },
      "attribute": "value",
      "reflect": false
    },
    "isMasked": {
      "type": "boolean",
      "mutable": true,
      "complexType": {
        "original": "boolean",
        "resolved": "boolean",
        "references": {}
      },
      "required": false,
      "optional": false,
      "docs": {
        "tags": [],
        "text": ""
      },
      "attribute": "is-masked",
      "reflect": true,
      "defaultValue": "true"
    }
  }; }
}
