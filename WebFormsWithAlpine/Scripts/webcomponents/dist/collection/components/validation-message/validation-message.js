import { Component, h, Prop, State } from '@stencil/core';
export class ValidationMessage {
  constructor() {
    this.showMessage = false;
    this.message = '';
  }
  componentWillLoad() {
    this.showMessage = this.message.length > 0;
  }
  render() {
    let messageCss = 'message';
    if (this.showMessage) {
      messageCss += ' show';
    }
    return (
    // when the user changes the value then hide the message.
    h("div", { class: 'container', onChange: () => this.showMessage = false },
      h("slot", null),
      h("div", { class: messageCss }, this.message)));
  }
  static get is() { return "aeg-validation-message"; }
  static get encapsulation() { return "shadow"; }
  static get originalStyleUrls() { return {
    "$": ["validation-message.css"]
  }; }
  static get styleUrls() { return {
    "$": ["validation-message.css"]
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
      "defaultValue": "''"
    }
  }; }
  static get states() { return {
    "showMessage": {}
  }; }
}
