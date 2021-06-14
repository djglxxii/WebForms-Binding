'use strict';

Object.defineProperty(exports, '__esModule', { value: true });

const index = require('./index-530eba9c.js');

const editableListCss = "";

const EditableList = class {
  constructor(hostRef) {
    index.registerInstance(this, hostRef);
    this.inputEl = null;
    this.name = '';
    this.value = '';
  }
  componentDidLoad() {
    const json = JSON.stringify(this.value);
    console.log(json);
    if (this.inputEl === null) {
      const parentEl = this.el.parentElement;
      this.inputEl = parentEl.ownerDocument.createElement('input');
      this.inputEl.type = 'text';
      this.inputEl.name = this.name;
      this.inputEl.value = json;
      parentEl.append(this.inputEl);
    }
  }
  render() {
    return (index.h("div", { class: 'container' }, "Editable List"));
  }
  get el() { return index.getElement(this); }
};
EditableList.style = editableListCss;

exports.aegis_editable_list = EditableList;
