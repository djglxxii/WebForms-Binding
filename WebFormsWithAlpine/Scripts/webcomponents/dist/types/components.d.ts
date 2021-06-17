/* eslint-disable */
/* tslint:disable */
/**
 * This is an autogenerated file created by the Stencil compiler.
 * It contains typing information for all components that exist in this project.
 */
import { HTMLStencilElement, JSXBase } from "./stencil-public-runtime";
export namespace Components {
    interface AegMaskedInput {
        "isMasked": boolean;
        "name": string;
        "value": string;
    }
    interface AegValidationMessage {
        "message": string;
    }
    interface AegisEditableList {
        "propertyName": string;
        "value": string;
    }
}
declare global {
    interface HTMLAegMaskedInputElement extends Components.AegMaskedInput, HTMLStencilElement {
    }
    var HTMLAegMaskedInputElement: {
        prototype: HTMLAegMaskedInputElement;
        new (): HTMLAegMaskedInputElement;
    };
    interface HTMLAegValidationMessageElement extends Components.AegValidationMessage, HTMLStencilElement {
    }
    var HTMLAegValidationMessageElement: {
        prototype: HTMLAegValidationMessageElement;
        new (): HTMLAegValidationMessageElement;
    };
    interface HTMLAegisEditableListElement extends Components.AegisEditableList, HTMLStencilElement {
    }
    var HTMLAegisEditableListElement: {
        prototype: HTMLAegisEditableListElement;
        new (): HTMLAegisEditableListElement;
    };
    interface HTMLElementTagNameMap {
        "aeg-masked-input": HTMLAegMaskedInputElement;
        "aeg-validation-message": HTMLAegValidationMessageElement;
        "aegis-editable-list": HTMLAegisEditableListElement;
    }
}
declare namespace LocalJSX {
    interface AegMaskedInput {
        "isMasked"?: boolean;
        "name"?: string;
        "value"?: string;
    }
    interface AegValidationMessage {
        "message"?: string;
    }
    interface AegisEditableList {
        "propertyName"?: string;
        "value"?: string;
    }
    interface IntrinsicElements {
        "aeg-masked-input": AegMaskedInput;
        "aeg-validation-message": AegValidationMessage;
        "aegis-editable-list": AegisEditableList;
    }
}
export { LocalJSX as JSX };
declare module "@stencil/core" {
    export namespace JSX {
        interface IntrinsicElements {
            "aeg-masked-input": LocalJSX.AegMaskedInput & JSXBase.HTMLAttributes<HTMLAegMaskedInputElement>;
            "aeg-validation-message": LocalJSX.AegValidationMessage & JSXBase.HTMLAttributes<HTMLAegValidationMessageElement>;
            "aegis-editable-list": LocalJSX.AegisEditableList & JSXBase.HTMLAttributes<HTMLAegisEditableListElement>;
        }
    }
}
