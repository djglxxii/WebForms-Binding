import{d as doc,N as NAMESPACE,w as win,p as promiseResolve,H,b as bootstrapLazy}from"./index-14ac85e4.js";var getDynamicImportFunction=function(e){return"__sc_import_"+e.replace(/\s|-/g,"_")};var patchBrowser=function(){{patchCloneNodeFix(H.prototype)}var e=Array.from(doc.querySelectorAll("script")).find((function(e){return new RegExp("/"+NAMESPACE+"(\\.esm)?\\.js($|\\?|#)").test(e.src)||e.getAttribute("data-stencil-namespace")===NAMESPACE}));var r="";var t=e["data-opts"]||{};if(r!==""){t.resourcesUrl=new URL(".",r).href}else{t.resourcesUrl=new URL(".",new URL(e.getAttribute("data-resources-url")||e.src,win.location.href)).href;{patchDynamicImport(t.resourcesUrl,e)}if(!win.customElements){return import("./dom-bd0bf1dc.js").then((function(){return t}))}}return promiseResolve(t)};var patchDynamicImport=function(e,r){var t=getDynamicImportFunction(NAMESPACE);try{win[t]=new Function("w","return import(w);//"+Math.random())}catch(o){var n=new Map;win[t]=function(o){var a=new URL(o,e).href;var i=n.get(a);if(!i){var c=doc.createElement("script");c.type="module";c.crossOrigin=r.crossOrigin;c.src=URL.createObjectURL(new Blob(["import * as m from '"+a+"'; window."+t+".m = m;"],{type:"application/javascript"}));i=new Promise((function(e){c.onload=function(){e(win[t].m);c.remove()}}));n.set(a,i);doc.head.appendChild(c)}return i}}};var patchCloneNodeFix=function(e){var r=e.cloneNode;e.cloneNode=function(e){if(this.nodeName==="TEMPLATE"){return r.call(this,e)}var t=r.call(this,false);var n=this.childNodes;if(e){for(var o=0;o<n.length;o++){if(n[o].nodeType!==2){t.appendChild(n[o].cloneNode(true))}}}return t}};patchBrowser().then((function(e){return bootstrapLazy([["aegis-validated-input",[[1,"aegis-validated-input",{message:[1]}]]],["my-component",[[1,"my-component",{first:[1],middle:[1],last:[1]}]]]],e)}));