System.register(["./p-5e194958.system.js"],(function(e,r){"use strict";var t,n,s,a,i,o;return{setters:[function(e){t=e.d;n=e.N;s=e.w;a=e.p;i=e.H;o=e.b}],execute:function(){var e=function(e){return"__sc_import_"+e.replace(/\s|-/g,"_")};var c=function(){{l(i.prototype)}var e=Array.from(t.querySelectorAll("script")).find((function(e){return new RegExp("/"+n+"(\\.esm)?\\.js($|\\?|#)").test(e.src)||e.getAttribute("data-stencil-namespace")===n}));var o=r.meta.url;var c=e["data-opts"]||{};if(o!==""){c.resourcesUrl=new URL(".",o).href}else{c.resourcesUrl=new URL(".",new URL(e.getAttribute("data-resources-url")||e.src,s.location.href)).href;{u(c.resourcesUrl,e)}if(!s.customElements){return r.import("./p-11ba787a.system.js").then((function(){return c}))}}return a(c)};var u=function(r,a){var i=e(n);try{s[i]=new Function("w","return import(w);//"+Math.random())}catch(e){var o=new Map;s[i]=function(e){var n=new URL(e,r).href;var c=o.get(n);if(!c){var u=t.createElement("script");u.type="module";u.crossOrigin=a.crossOrigin;u.src=URL.createObjectURL(new Blob(["import * as m from '"+n+"'; window."+i+".m = m;"],{type:"application/javascript"}));c=new Promise((function(e){u.onload=function(){e(s[i].m);u.remove()}}));o.set(n,c);t.head.appendChild(u)}return c}}};var l=function(e){var r=e.cloneNode;e.cloneNode=function(e){if(this.nodeName==="TEMPLATE"){return r.call(this,e)}var t=r.call(this,false);var n=this.childNodes;if(e){for(var s=0;s<n.length;s++){if(n[s].nodeType!==2){t.appendChild(n[s].cloneNode(true))}}}return t}};c().then((function(e){return o([["p-bfa85c71.system",[[1,"aegis-validated-input",{message:[1]}]]],["p-5314cb46.system",[[1,"my-component",{first:[1],middle:[1],last:[1]}]]]],e)}))}}}));