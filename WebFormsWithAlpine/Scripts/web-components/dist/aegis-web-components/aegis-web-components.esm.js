import{d as t,N as s,w as e,p as n,H as r,b as i}from"./p-f3e5b584.js";const o=t=>{const s=t.cloneNode;t.cloneNode=function(t){if("TEMPLATE"===this.nodeName)return s.call(this,t);const e=s.call(this,!1),n=this.childNodes;if(t)for(let t=0;t<n.length;t++)2!==n[t].nodeType&&e.appendChild(n[t].cloneNode(!0));return e}};(()=>{o(r.prototype);const i=Array.from(t.querySelectorAll("script")).find((t=>new RegExp(`/${s}(\\.esm)?\\.js($|\\?|#)`).test(t.src)||t.getAttribute("data-stencil-namespace")===s)),a=i["data-opts"]||{};return a.resourcesUrl=new URL(".",new URL(i.getAttribute("data-resources-url")||i.src,e.location.href)).href,((n,r)=>{const i=`__sc_import_${s.replace(/\s|-/g,"_")}`;try{e[i]=new Function("w",`return import(w);//${Math.random()}`)}catch(s){const o=new Map;e[i]=s=>{const a=new URL(s,n).href;let c=o.get(a);if(!c){const s=t.createElement("script");s.type="module",s.crossOrigin=r.crossOrigin,s.src=URL.createObjectURL(new Blob([`import * as m from '${a}'; window.${i}.m = m;`],{type:"application/javascript"})),c=new Promise((t=>{s.onload=()=>{t(e[i].m),s.remove()}})),o.set(a,c),t.head.appendChild(s)}return c}}})(a.resourcesUrl,i),e.customElements?n(a):__sc_import_aegis_web_components("./p-9064d5bf.js").then((()=>a))})().then((t=>i([["p-cf642e56",[[1,"aegis-validated-input",{message:[1]}]]],["p-3dfc5c37",[[1,"my-component",{first:[1],middle:[1],last:[1]}]]]],t)));