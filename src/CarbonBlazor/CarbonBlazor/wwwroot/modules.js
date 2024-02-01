window.CDS = {}
window.CDS.import = (name, ver, dir) => import(`./modules/${name}${dir}.min.js${ver}`)
    .then(() => console.info(`${name}${dir}`))
    .catch(e => console.error(e))
window.CDS.preload = (visible) => {
    if (visible) {
        let temp = document.getElementById("cds-preload-template");
        if (temp) temp.before(temp.content.cloneNode(true));
    }
    else {
        let p = document.getElementById('cds-preload')
        if (p) p.remove();
    }
}
window.CDS.initialize = async () => {
    CDS.preload(true);
    const ver = document.documentElement.getAttribute('ver')
    const name = document.documentElement.getAttribute('name')
    let d = '';
    if (name && localStorage.getItem(`${name}-dir`) === 'rtl') {
        document.documentElement.setAttribute('dir', 'rtl')
        d = '.rtl'
    }
    const v = ver ? `?${ver}` : ''
    await Promise.all([
        CDS.import('accordion', v, d),
        CDS.import('breadcrumb', v, d),
        CDS.import('button', v, d),
        CDS.import('checkbox', v, d),
        CDS.import('code-snippet', v, d),
        CDS.import('combo-box', v, d),
        CDS.import('content-switcher', v, d),
        //CDS.import('copy', v, d),
        CDS.import('copy-button', v, d),
        CDS.import('data-table', v, d),
        CDS.import('date-picker', v, d),
        CDS.import('dropdown', v, d),
        CDS.import('file-uploader', v, d),
        CDS.import('floating-menu', v, d),
        CDS.import('form', v, d),
        CDS.import('inline-loading', v, d),
        CDS.import('layer', v, d),
        CDS.import('link', v, d),
        CDS.import('list', v, d),
        CDS.import('loading', v, d),
        CDS.import('modal', v, d),
        CDS.import('multi-select', v, d),
        CDS.import('notification', v, d),
        CDS.import('number-input', v, d),
        CDS.import('overflow-menu', v, d),
        CDS.import('pagination', v, d),
        CDS.import('progress-indicator', v, d),
        CDS.import('radio-button', v, d),
        CDS.import('search', v, d),
        CDS.import('select', v, d),
        CDS.import('skeleton-placeholder', v, d),
        CDS.import('skeleton-text', v, d),
        CDS.import('skip-to-content', v, d),
        CDS.import('slider', v, d),
        CDS.import('structured-list', v, d),
        CDS.import('tabs', v, d),
        CDS.import('tag', v, d),
        CDS.import('text-input', v, d),
        CDS.import('textarea', v, d),
        CDS.import('tile', v, d),
        CDS.import('toggle', v, d),
        CDS.import('toggle-tip', v, d),
        CDS.import('tooltip', v, d),
        CDS.import('ui-shell', v, d),
    ]).then((values) => {
        console.info('Carbon module loading completed.')
        CDS.preload(false);
    })
}

CDS.initialize();


