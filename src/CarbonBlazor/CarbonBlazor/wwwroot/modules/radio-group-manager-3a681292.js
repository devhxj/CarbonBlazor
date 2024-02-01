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

let e;import{a as t}from"./objectSpread2-ea408269.js";
/**
 * @license
 *
 * Copyright IBM Corp. 2019, 2023
 *
 * This source code is licensed under the Apache-2.0 license found in the
 * LICENSE file in the root directory of this source tree.
 */!function(e){e[e.BACKWARD=-1]="BACKWARD",e[e.FORWARD=1]="FORWARD"}(e||(e={}));class s{constructor(e){t(this,"_groups",{}),this.constructor._instances.set(e,this)}shouldBeFocusable(e){if(e.checked)return!0;const{name:t}=e,s=this._groups[t];if(s&&Array.from(s).some((e=>e.checked)))return!1;return!s||1===s.size||this.getSortedGroup(e)[0]===e}getSortedGroup(e){const t=this._groups[e.name];return t&&Array.from(t).sort(((e,t)=>{const s=e.compareDocumentPosition(t);return s&Node.DOCUMENT_POSITION_FOLLOWING||s&Node.DOCUMENT_POSITION_CONTAINED_BY?-1:s&Node.DOCUMENT_POSITION_PRECEDING||s&Node.DOCUMENT_POSITION_CONTAINS?1:0}))}add(e){const{name:t}=e;if(t){const s=this._groups;s[t]||(s[t]=new Set),s[t].add(e)}return this}delete(e,t=e.name){const s=this._groups[t];return!!s&&s.delete(e)}select(e,t){const s=this._groups[e.name];s&&(e.checked=!t||!0,e.tabIndex=0,e.focus(),s.forEach((s=>{e!==s&&(s.checked=t||!1,s.tabIndex=-1)})))}navigate(e,t){const s=this.getSortedGroup(e);let r=s.indexOf(e)+t;return r<0?r=s.length-1:r>=s.length&&(r=0),s[r]}static get(e){return this._instances.get(e)||new s(e)}}t(s,"_instances",new WeakMap);export{e as N,s as R};
