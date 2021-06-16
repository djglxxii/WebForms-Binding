import { Component, h, Prop } from '@stencil/core';

@Component({
  tag: 'aeg-masked-input',
  styleUrl: 'masked-input.css',
  scoped: true,
})
export class MaskedInput {

  @Prop()
  name: string;

  @Prop()
  value: string;

  @Prop({ mutable: true, reflect: true })
  isVisible = false;

  componentDidLoad() {

  }

  render() {
    let icon: string;
    if (this.isVisible) {
      icon = 'visibility';
    } else {
      icon = 'visibility_off';
    }

    return (
      <div class='container'>

        <input
          type={this.isVisible ? 'text' : 'password'}
          name={this.name}
          value={this.value} />

        <span class='material-icons'
              onClick={() => this.isVisible = !this.isVisible}
        >{icon}</span>

      </div>
    );
  }
}
