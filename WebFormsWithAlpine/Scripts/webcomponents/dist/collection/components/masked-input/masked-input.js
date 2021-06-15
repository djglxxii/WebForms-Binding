import { Component, h, Prop } from '@stencil/core';
export class MaskedInput {
  constructor() {
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
    return (h("div", { class: 'container' },
      h("input", { type: this.isVisible ? 'text' : 'password', name: this.name, value: this.value }),
      h("span", { class: 'material-icons', onClick: () => this.isVisible = !this.isVisible }, icon)));
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
    "isVisible": {
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
      "attribute": "is-visible",
      "reflect": true,
      "defaultValue": "false"
    }
  }; }
}
