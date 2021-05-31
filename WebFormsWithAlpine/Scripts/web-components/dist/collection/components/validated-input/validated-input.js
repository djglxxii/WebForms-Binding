import { Component, Element, h, Prop } from '@stencil/core';
export class ValidatedInput {
  constructor() {
    this.message = null;
  }
  componentWillLoad() {
    if (this.message) {
      this.el.setAttribute('changed', 'false');
    }
  }
  render() {
    return (h("div", { id: 'container', onChange: () => this.el.setAttribute('changed', 'true') },
      h("slot", null),
      h("div", { id: 'message' }, this.message)));
  }
  static get is() { return "aegis-validated-input"; }
  static get encapsulation() { return "shadow"; }
  static get originalStyleUrls() { return {
    "$": ["./validated-input.css"]
  }; }
  static get styleUrls() { return {
    "$": ["validated-input.css"]
  }; }
  static get properties() { return {
    "message": {
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
      "attribute": "message",
      "reflect": false,
      "defaultValue": "null"
    }
  }; }
  static get elementRef() { return "el"; }
}
