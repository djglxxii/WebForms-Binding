import{r as e,h as s}from"./p-cf22cca0.js";const t=class{constructor(s){e(this,s),this.isVisible=!1}componentDidLoad(){}render(){let e;return e=this.isVisible?"visibility":"visibility_off",s("div",{class:"container"},s("input",{type:this.isVisible?"text":"password",name:this.name,value:this.value}),s("span",{class:"material-icons",onClick:()=>this.isVisible=!this.isVisible},e))}};t.style=".container.sc-aeg-masked-input{display:-ms-flexbox;display:flex;-ms-flex-align:center;align-items:center}span.material-icons.sc-aeg-masked-input{margin-left:5px;cursor:pointer;-webkit-user-select:none;-moz-user-select:none;-ms-user-select:none;user-select:none}";export{t as aeg_masked_input}