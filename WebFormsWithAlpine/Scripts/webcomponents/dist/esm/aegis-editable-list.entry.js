import { r as registerInstance, h, g as getElement } from './index-f00b599d.js';

const editableListCss = "";

const EditableList = class {
  constructor(hostRef) {
    registerInstance(this, hostRef);
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
  get el() { return getElement(this); }
};
EditableList.style = editableListCss;

export { EditableList as aegis_editable_list };
