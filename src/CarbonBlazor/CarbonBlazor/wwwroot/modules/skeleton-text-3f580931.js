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

let e;import{i as n,_ as o,s as t,p as i,x as r}from"./settings-daf72103.js";import{o as s}from"./class-map-0ae732f6.js";import{n as a}from"./query-assigned-elements-8e88277c.js";import{c}from"./carbon-element-4ca9803f.js";
/**
 * @license
 *
 * Copyright IBM Corp. 2020, 2023
 *
 * This source code is licensed under the Apache-2.0 license found in the
 * LICENSE file in the root directory of this source tree.
 */!function(e){e.REGULAR="",e.HEADING="heading"}(e||(e={}));var l=n(['@keyframes hide-feedback{0%{opacity:1;visibility:inherit}to{opacity:0;visibility:hidden}}@keyframes show-feedback{0%{opacity:0;visibility:hidden}to{opacity:1;visibility:inherit}}@keyframes skeleton{0%{opacity:.3;transform:scaleX(0);transform-origin:right}20%{opacity:1;transform:scaleX(1);transform-origin:right}28%{transform:scaleX(1);transform-origin:left}51%{transform:scaleX(0);transform-origin:left}58%{transform:scaleX(0);transform-origin:left}82%{transform:scaleX(1);transform-origin:left}83%{transform:scaleX(1);transform-origin:right}96%{transform:scaleX(0);transform-origin:right}to{opacity:.3;transform:scaleX(0);transform-origin:right}}.cds--icon--skeleton{background:var(--cds-skeleton-background,#e8e8e8);block-size:1rem;border:none;box-shadow:none;display:inline-block;inline-size:1rem;padding:0;pointer-events:none;position:relative}.cds--icon--skeleton:active,.cds--icon--skeleton:focus,.cds--icon--skeleton:hover{border:none;cursor:default;outline:none}.cds--icon--skeleton:before{animation:skeleton 3s ease-in-out infinite;background:var(--cds-skeleton-element,#c6c6c6);block-size:100%;content:"";inline-size:100%;position:absolute;will-change:transform-origin,transform,opacity}@media (prefers-reduced-motion:reduce){.cds--icon--skeleton:before{animation:none}}.cds--skeleton__placeholder{background:var(--cds-skeleton-background,#e8e8e8);block-size:6.25rem;border:none;box-shadow:none;inline-size:6.25rem;padding:0;pointer-events:none;position:relative}.cds--skeleton__placeholder:active,.cds--skeleton__placeholder:focus,.cds--skeleton__placeholder:hover{border:none;cursor:default;outline:none}.cds--skeleton__placeholder:before{animation:skeleton 3s ease-in-out infinite;background:var(--cds-skeleton-element,#c6c6c6);block-size:100%;content:"";inline-size:100%;position:absolute;will-change:transform-origin,transform,opacity}@media (prefers-reduced-motion:reduce){.cds--skeleton__placeholder:before{animation:none}}.cds--skeleton__text{background:var(--cds-skeleton-background,#e8e8e8);block-size:1rem;border:none;box-shadow:none;inline-size:100%;margin-block-end:.5rem;padding:0;pointer-events:none;position:relative}.cds--skeleton__text:active,.cds--skeleton__text:focus,.cds--skeleton__text:hover{border:none;cursor:default;outline:none}.cds--skeleton__text:before{animation:skeleton 3s ease-in-out infinite;background:var(--cds-skeleton-element,#c6c6c6);block-size:100%;content:"";inline-size:100%;position:absolute;will-change:transform-origin,transform,opacity}@media (prefers-reduced-motion:reduce){.cds--skeleton__text:before{animation:none}}.cds--skeleton__heading{block-size:1.5rem}:host(cds-skeleton-text){display:block;width:100%}:host(cds-skeleton-text) .cds--skeleton__text{margin-top:0}']);let d,f,k,m=e=>e;function p(e,n,o){return Math.floor([.973051493507435,.15334737213558558,.5671034553053769][o%3]*(n-e+1))+e}o([c(`${i}-skeleton-text`)],(function(n,o){return{F:class extends o{constructor(...e){super(...e),n(this)}},d:[{kind:"field",decorators:[a({reflect:!0})],key:"type",value:()=>e.REGULAR},{kind:"field",decorators:[a({reflect:!0})],key:"width",value:()=>"100%"},{kind:"field",decorators:[a({type:Boolean,reflect:!0})],key:"paragraph",value:()=>!1},{kind:"field",decorators:[a({type:Number,reflect:!0})],key:"lineCount",value:()=>3},{kind:"method",key:"render",value:function(){const{paragraph:n,lineCount:o,type:t,width:a}=this,c=s({[`${i}--skeleton__text`]:!0,[`${i}--skeleton__heading`]:t===e.HEADING});if(n){const e=parseInt(this.width,10),n=this.width.includes("px"),t=this.width.includes("%"),i=Array.apply(null,Array(o));return r(d||(d=m`${0}`),i.map(((o,i)=>{const s=t&&`${p(0,75,i)}px`||n&&`${p(0,e,i)}px`,l=t&&`width: calc(${a} - ${s})`||n&&`width: ${s}`||"";return r(f||(f=m`<p class="${0}" style="${0}"></p>`),c,l)})))}return r(k||(k=m`<p class="${0}" style="width:${0}"></p>`),c,a)}},{kind:"field",static:!0,key:"styles",value:()=>l}]}}),t);export{e as S};
