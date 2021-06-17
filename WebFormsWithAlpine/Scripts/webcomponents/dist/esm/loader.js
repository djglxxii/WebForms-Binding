import { C as CSS, p as plt, w as win, a as promiseResolve, b as bootstrapLazy } from './index-96c20a2b.js';

/*
 Stencil Client Patch Esm v2.6.0 | MIT Licensed | https://stenciljs.com
 */
const patchEsm = () => {
    // NOTE!! This fn cannot use async/await!
    // @ts-ignore
    if (!(CSS && CSS.supports && CSS.supports('color', 'var(--c)'))) {
        // @ts-ignore
        return import(/* webpackChunkName: "polyfills-css-shim" */ './css-shim-8d75038b.js').then(() => {
            if ((plt.$cssShim$ = win.__cssshim)) {
                return plt.$cssShim$.i();
            }
            else {
                // for better minification
                return 0;
            }
        });
    }
    return promiseResolve();
};

const defineCustomElements = (win, options) => {
  if (typeof window === 'undefined') return Promise.resolve();
  return patchEsm().then(() => {
  return bootstrapLazy([["aeg-masked-input",[[2,"aeg-masked-input",{"name":[1],"value":[1],"isMasked":[1540,"is-masked"]}]]],["aeg-validation-message",[[1,"aeg-validation-message",{"message":[1],"showMessage":[32]}]]],["aegis-editable-list",[[2,"aegis-editable-list",{"propertyName":[1,"property-name"],"value":[1],"parsedData":[32]}]]]], options);
  });
};

export { defineCustomElements };
