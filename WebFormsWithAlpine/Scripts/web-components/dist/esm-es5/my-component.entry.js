import{r as registerInstance,h}from"./index-14ac85e4.js";function format(t,n,e){return(t||"")+(n?" "+n:"")+(e?" "+e:"")}var myComponentCss=":host{display:block}";var MyComponent=function(){function t(t){registerInstance(this,t)}t.prototype.getText=function(){return format(this.first,this.middle,this.last)};t.prototype.render=function(){return h("div",null,"Hello, World! I'm ",this.getText())};return t}();MyComponent.style=myComponentCss;export{MyComponent as my_component};