import { r as registerInstance, h } from './index-fb5d324f.js';

const editableListCss = "";

const EditableList = class {
  constructor(hostRef) {
    registerInstance(this, hostRef);
  }
  componentWillLoad() {
    console.log(this.value);
    //this.parsedData = JSON.parse(this.value);
  }
  render() {
    return (h("div", null, h("input", { id: this.propertyName, name: this.propertyName, type: 'hidden', value: this.value })));
  }
};
EditableList.style = editableListCss;

export { EditableList as aegis_editable_list };
