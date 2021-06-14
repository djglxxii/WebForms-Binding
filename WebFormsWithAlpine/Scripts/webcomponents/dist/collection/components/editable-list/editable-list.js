import { Component, Element, h, Prop, } from '@stencil/core';
export class EditableList {
  constructor() {
    this.inputEl = null;
    this.name = '';
    this.value = '';
  }
  componentDidLoad() {
    if (this.inputEl === null) {
      const parentEl = this.el.parentElement;
      this.inputEl = parentEl.ownerDocument.createElement('input');
      this.inputEl.type = 'hidden';
      this.inputEl.name = this.name;
      this.inputEl.value = this.value;
      parentEl.append(this.inputEl);
    }
  }
  render() {
    return (h("div", { class: 'container' }, "Editable List"));
  }
  static get is() { return "aegis-editable-list"; }
  static get encapsulation() { return "shadow"; }
  static get originalStyleUrls() { return {
    "$": ["editable-list.css"]
  }; }
  static get styleUrls() { return {
    "$": ["editable-list.css"]
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
      "reflect": false,
      "defaultValue": "''"
    },
    "value": {
      "type": "string",
      "mutable": true,
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
      "reflect": true,
      "defaultValue": "''"
    }
  }; }
  static get elementRef() { return "el"; }
}
