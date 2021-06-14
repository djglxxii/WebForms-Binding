import {
  Component,
  h,
} from '@stencil/core';

@Component({
  tag: 'aegis-editable-list',
  styleUrl: 'editable-list.css',
  shadow: true,
})
export class EditableList {

  render() {
    return (
      <div>
        Editable List
      </div>
    );
  }
}
