System.register(["./p-87698a6d.system.js"],(function(e){"use strict";var i,s;return{setters:[function(e){i=e.r;s=e.h}],execute:function(){var t=".container.sc-aeg-masked-input{display:-ms-flexbox;display:flex;-ms-flex-align:center;align-items:center}span.material-icons.sc-aeg-masked-input{margin-left:5px;cursor:pointer;-webkit-user-select:none;-moz-user-select:none;-ms-user-select:none;user-select:none}";var n=e("aeg_masked_input",function(){function e(e){i(this,e);this.isVisible=false}e.prototype.componentDidLoad=function(){};e.prototype.render=function(){var e=this;var i;if(this.isVisible){i="visibility"}else{i="visibility_off"}return s("div",{class:"container"},s("input",{type:this.isVisible?"text":"password",name:this.name,value:this.value}),s("span",{class:"material-icons",onClick:function(){return e.isVisible=!e.isVisible}},i))};return e}());n.style=t}}}));