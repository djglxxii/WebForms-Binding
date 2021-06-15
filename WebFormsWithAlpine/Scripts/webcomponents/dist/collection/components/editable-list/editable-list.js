import { Component, h, Prop, State, } from '@stencil/core';
export class EditableList {
  componentWillLoad() {
    console.log(this.value);
    //this.parsedData = JSON.parse(this.value);
  }
  render() {
    return (h("div", null,
      h("input", { id: this.propertyName, name: this.propertyName, type: 'hidden', value: this.value })));
  }
  static get is() { return "aegis-editable-list"; }
  static get encapsulation() { return "scoped"; }
  static get originalStyleUrls() { return {
    "$": ["editable-list.css"]
  }; }
  static get styleUrls() { return {
    "$": ["editable-list.css"]
  }; }
  static get properties() { return {
    "propertyName": {
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
      "attribute": "property-name",
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
    }
  }; }
  static get states() { return {
    "parsedData": {}
  }; }
}
