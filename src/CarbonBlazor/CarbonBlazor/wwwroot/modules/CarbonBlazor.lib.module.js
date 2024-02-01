const css = (name, ver) => {
    if (!document.head.querySelector(`#cds-${name}`)) {
        const id = `cds-${name}`
        var g = document.createElement('link')
        g.setAttribute('id', id)
        g.setAttribute('rel', 'stylesheet')
        g.setAttribute('href', `_content/CarbonBlazor/css/${name}.css${ver}`)
        document.head.appendChild(g)
        console.info(name)
    }
}

const imp = (name, ver, dir) =>
    import(`./modules/${name}${dir}.min.js${ver}`)
        .then(() => console.info(`${name}${dir}`))
        .catch(e => console.error(e));

export function beforeWebStart() {
    //const ver = document.body.getAttribute('ver')
    //const name = document.body.getAttribute('name')
    //let d = '';
    //if (name && localStorage.getItem(`${name}-dir`) === 'rtl') {
    //    document.body.setAttribute('dir', 'rtl')
    //    d = '.rtl'
    //}
    //const v = ver ? `?${ver}` : ''
    //css('grid', v)
    //css('themes', v)
    //Promise.all([
    //    imp('accordion', v, d),
    //    imp('breadcrumb', v, d),
    //    imp('button', v, d),
    //    imp('checkbox', v, d),
    //    imp('code-snippet', v, d),
    //    imp('combo-box', v, d),
    //    imp('content-switcher', v, d),
    //    //imp('copy', v, d),
    //    imp('copy-button', v, d),
    //    imp('data-table', v, d),
    //    imp('date-picker', v, d),
    //    imp('dropdown', v, d),
    //    imp('file-uploader', v, d),
    //    imp('floating-menu', v, d),
    //    imp('form', v, d),
    //    imp('inline-loading', v, d),
    //    imp('layer', v, d),
    //    imp('link', v, d),
    //    imp('list', v, d),
    //    imp('loading', v, d),
    //    imp('modal', v, d),
    //    imp('multi-select', v, d),
    //    imp('notification', v, d),
    //    imp('number-input', v, d),
    //    imp('overflow-menu', v, d),
    //    imp('pagination', v, d),
    //    imp('progress-indicator', v, d),
    //    imp('radio-button', v, d),
    //    imp('search', v, d),
    //    imp('select', v, d),
    //    imp('skeleton-placeholder', v, d),
    //    imp('skeleton-text', v, d),
    //    imp('skip-to-content', v, d),
    //    imp('slider', v, d),
    //    imp('structured-list', v, d),
    //    imp('tabs', v, d),
    //    imp('tag', v, d),
    //    imp('text-input', v, d),
    //    imp('textarea', v, d),
    //    imp('tile', v, d),
    //    imp('toggle', v, d),
    //    imp('toggle-tip', v, d),
    //    imp('tooltip', v, d),
    //    imp('ui-shell', v, d),
    //]).then((values) => {
    //    console.info('Carbon module loading completed.')
    //    const indicator = document.getElementById('indicator')
    //    if (indicator) indicator.style.display = 'none';
    //});
}