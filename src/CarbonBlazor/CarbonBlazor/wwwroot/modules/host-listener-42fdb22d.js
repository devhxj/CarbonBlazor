/**
 * @license
 *
 * Copyright IBM Corp. 2019, 2020
 *
 * This source code is licensed under the Apache-2.0 license found in the
 * LICENSE file in the root directory of this source tree.
 */
/**
 * @license
 * 
 * This bundle contains the following third-party dependencies:
 * 
 * flatpickr:
 * 
 flatpickr v4.6.1, @license MIT
 * 
 * lit-html:
 * 
 * @license
 * Copyright 2017 Google LLC
 * SPDX-License-Identifier: BSD-3-Clause
 * 
 * lit-element:
 * 
 * @license
 * Copyright 2017 Google LLC
 * SPDX-License-Identifier: BSD-3-Clause
 * 
 * @lit/reactive-element:
 * 
 * @license
 * Copyright 2017 Google LLC
 * SPDX-License-Identifier: BSD-3-Clause
 * 
 * @carbon/layout:
 * 
 * Copyright IBM Corp. 2018, 2023
 *
 * This source code is licensed under the Apache-2.0 license found in the
 * LICENSE file in the root directory of this source tree.
 * 
 * Also refer to the following links for the license of other third-party dependencies:
 * 
 * https://www.npmjs.com/package/lit
 * https://www.npmjs.com/package/@carbon/icons
 * https://www.npmjs.com/package/lodash-es
 */

import{_ as t,a as e}from"./objectSpread2-ea408269.js";import{o}from"./on-6c264d49.js";
/**
 * @license
 *
 * Copyright IBM Corp. 2019, 2022
 *
 * This source code is licensed under the Apache-2.0 license found in the
 * LICENSE file in the root directory of this source tree.
 */const s=(t,e,o,s)=>{const n=o._hostListeners;if(!n)throw new Error("The method `@HostListener()` is defined on has to be of a class that has `HostListerMixin`.");n[s]||(n[s]={}),n[s][t]={options:e}},n=(e,o)=>(n,r)=>void 0!==r?s(e,o,n.constructor,r):((e,o,n)=>{const{kind:r,key:a,placement:i}=n;if(!("method"===r&&"prototype"===i||"field"===r&&"own"===i))throw new Error("`@HostListener()` must be defined on instance methods, but you may have defined it on static, field, etc.");return t(t({},n),{},{finisher(t){s(e,o,t,a)}})})(e,o,n),r=/^((document|window|parentRoot|shadowRoot):)?([\w-]+)$/,a=t=>{class s extends t{constructor(...t){super(...t),e(this,"_handles",new Set)}connectedCallback(){super.connectedCallback();const t=this.constructor._hostListeners;Object.keys(t).forEach((e=>{Object.keys(t[e]).forEach((s=>{var n;const a=r.exec(s);if(!a)throw new Error(`Could not parse the event name: ${e}`);const[,,i,c]=a,d={document:this.ownerDocument,window:this.ownerDocument.defaultView,parentRoot:this.getRootNode(),shadowRoot:this.shadowRoot}[i]||this,{options:h}=t[e][s];this._handles.add(o(d,null!==(n=this.constructor[c])&&void 0!==n?n:c,this[e],h))}))}))}disconnectedCallback(){this._handles.forEach((t=>{t.release(),this._handles.delete(t)})),super.disconnectedCallback()}}return e(s,"_hostListeners",{}),s};export{a as H,n as a};
