import {
  Component,
  Element,
  h,
  Prop,
} from '@stencil/core';

@Component({
  tag: 'aegis-editable-list',
  styleUrl: 'editable-list.css',
  shadow: true,
})
export class EditableList {
  private inputEl: HTMLInputElement = null;

  @Element()
  el;

  @Prop()
  name: string = '';

  @Prop({ mutable: true, reflect: true })
  value: string = '';

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
    return (
      <div class='container'>
        Editable List
      </div>
    );
  }
}
