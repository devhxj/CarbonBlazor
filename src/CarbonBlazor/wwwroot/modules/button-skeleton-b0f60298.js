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
 * lit-element:
 * 
 * @license
 * Copyright 2017 Google LLC
 * SPDX-License-Identifier: BSD-3-Clause
 * 
 * lit-html:
 * 
 * @license
 * Copyright 2022 Google LLC
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
 * https://www.npmjs.com/package/@carbon/icons
 * https://www.npmjs.com/package/lit
 * https://www.npmjs.com/package/lodash-es
 */

import{_ as t,x as e,p as n}from"./settings-daf72103.js";import{o}from"./class-map-0ae732f6.js";import{l as a}from"./if-defined-5b102a7a.js";import{C as s,b as i}from"./button-fcaef03a.js";import{c as l}from"./carbon-element-4ca9803f.js";let r,d,f=t=>t;t([l(`${n}-button-skeleton`)],(function(t,s){return{F:class extends s{constructor(...e){super(...e),t(this)}},d:[{kind:"method",key:"_handleClickLinkSkeleton",value:function(t){this.disabled&&(t.preventDefault(),t.stopPropagation())}},{kind:"method",key:"render",value:function(){const{autofocus:t,disabled:s,download:i,href:l,hreflang:u,ping:c,rel:$,size:p,target:b,type:k}=this,m=o({[`${n}--btn`]:!0,[`${n}--skeleton`]:!0,[`${n}--btn--${p}`]:p});return l?e(r||(r=f`
          <a
            id="button"
            role="button"
            class="${0}"
            download="${0}"
            href="${0}"
            hreflang="${0}"
            ping="${0}"
            rel="${0}"
            target="${0}"
            type="${0}"
            @click="${0}"></a>
        `),m,a(i),a(l),a(u),a(c),a($),a(b),a(k),this._handleClickLinkSkeleton):e(d||(d=f`
          <button
            id="button"
            class="${0}"
            ?autofocus="${0}"
            ?disabled="${0}"
            type="${0}"></button>
        `),m,t,s,a(k))}},{kind:"field",static:!0,key:"styles",value:()=>i}]}}),s);
