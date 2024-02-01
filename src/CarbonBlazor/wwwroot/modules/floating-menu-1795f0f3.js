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

let e,t;import{_ as i}from"./objectSpread2-ea408269.js";import{_ as n,p as s,s as o}from"./settings-daf72103.js";import{H as r,a}from"./host-listener-42fdb22d.js";import{F as l}from"./focus-e79b2a40.js";
/**
 * @license
 *
 * Copyright IBM Corp. 2020, 2022, 2023
 *
 * This source code is licensed under the Apache-2.0 license found in the
 * LICENSE file in the root directory of this source tree.
 */!function(e){e.LTR="ltr",e.RTL="rtl"}(e||(e={})),function(e){e.TOP="top",e.BOTTOM="bottom"}(t||(t={}));const h=(e,t)=>(e.observe(t),{release:()=>(e.unobserve(t),null)}),c=(e,t)=>{const i=e.closest(t);if(i)return i;const{host:n}=e.getRootNode();return n?c(n,t):null};let d=n(null,(function(n,r){return{F:class extends r{constructor(...e){super(...e),n(this)}},d:[{kind:"field",key:"_hObserveResizeParent",value:()=>null},{kind:"field",key:"_hObserveResizeContainer",value:()=>null},{kind:"field",key:"_resizeObserver",value(){return new ResizeObserver((()=>{const{container:t,open:i,parent:n,position:s}=this;if(t&&i&&n){const{direction:t,start:i,top:n}=s;this.style[t!==e.RTL?"left":"right"]=`${i}px`,this.style.top=`${n}px`}}))}},{kind:"field",decorators:[a("focusout")],key:"_handleBlur",value(){return({relatedTarget:e})=>{if(!this.contains(e)){const{parent:t}=this;t&&t!==e&&(t.open=!1,HTMLElement.prototype.focus.call(this.parent))}}}},{kind:"field",decorators:[a("click")],key:"_click",value(){return()=>{const{parent:e}=this;e&&(e.open=!1)}}},{kind:"field",decorators:[a("keydown")],key:"_handleKeyDown",value(){return e=>{if("Tab"===e.key&&e.shiftKey){const{parent:e}=this;e&&(e.open=!1)}}}},{kind:"field",key:"parent",value:()=>null},{kind:"get",key:"container",value:function(){return c(this,this.constructor.selectorContainer)||this.ownerDocument.body}},{kind:"get",key:"position",value:function(){const{triggerPosition:i}=this.parent;if(!i)throw new TypeError("Missing information of trigger button position.");const{container:n}=this,{left:s=0,top:o=0,right:r=0,bottom:a=0}=i,{width:l,height:h}=this.getBoundingClientRect(),{left:c=0,right:d=0,top:u=0}=n.getBoundingClientRect(),p=n.ownerDocument.defaultView.getComputedStyle(n),f=p.getPropertyValue("direction"),v=f===e.RTL,b=v?n.ownerDocument.defaultView.innerWidth-d:c,k=v?d-r:s-c,O=v?d-s:r-c,y=o-u;if((n!==this.ownerDocument.body||0!==b||0!==u)&&"static"===p.getPropertyValue("position"))throw new Error("Floating menu container must not have `position:static`.");const{flipped:g,direction:R}=this;if(Object.values(t).indexOf(R)<0)throw new Error(`Wrong menu position direction: ${R}`);const m=g?O-l:k,{start:_,top:z}={[t.TOP]:()=>({start:m,top:y-h}),[t.BOTTOM]:()=>({start:m,top:a})}[R]();return{direction:f,start:_,top:z}}},{kind:"method",key:"disconnectedCallback",value:function(){this._hObserveResizeContainer&&(this._hObserveResizeContainer=this._hObserveResizeContainer.release()),this._hObserveResizeParent&&(this._hObserveResizeParent=this._hObserveResizeParent.release())}},{kind:"method",key:"updated",value:function(t){const{container:i,open:n,parent:s}=this;if((t.has("flipped")||t.has("direction")||t.has("open"))&&n){s||(this.parent=this.parentElement,i.appendChild(this));const{direction:t,start:n,top:o}=this.position;this.style[t!==e.RTL?"left":"right"]=`${n}px`,this.style.top=`${o}px`}if(t.has("open")&&(this._hObserveResizeContainer&&(this._hObserveResizeContainer=this._hObserveResizeContainer.release()),this._hObserveResizeParent&&(this._hObserveResizeParent=this._hObserveResizeParent.release()),n)){var o;const{parentElement:e}=null!==(o=this.parent)&&void 0!==o?o:{};this._hObserveResizeContainer=h(this._resizeObserver,i),e&&(this._hObserveResizeParent=h(this._resizeObserver,e))}}},{kind:"field",static:!0,key:"FLOATING_MENU",value:()=>!0},{kind:"get",static:!0,key:"selectorContainer",value:function(){return`[data-floating-menu-container],${s}-modal`}},{kind:"field",static:!0,key:"shadowRootOptions",value:()=>i(i({},o.shadowRootOptions),{},{delegatesFocus:!0})}]}}),r(l(o)));export{d as C,t as F};
