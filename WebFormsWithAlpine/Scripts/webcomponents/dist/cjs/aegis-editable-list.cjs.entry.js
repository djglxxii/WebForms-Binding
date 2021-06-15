'use strict';

Object.defineProperty(exports, '__esModule', { value: true });

const index = require('./index-a45702ad.js');

const editableListCss = "";

const EditableList = class {
  constructor(hostRef) {
    index.registerInstance(this, hostRef);
  }
  componentWillLoad() {
    console.log(this.value);
    //this.parsedData = JSON.parse(this.value);
  }
  render() {
    return (index.h("div", null, index.h("input", { id: this.propertyName, name: this.propertyName, type: 'hidden', value: this.value })));
  }
};
EditableList.style = editableListCss;

exports.aegis_editable_list = EditableList;
