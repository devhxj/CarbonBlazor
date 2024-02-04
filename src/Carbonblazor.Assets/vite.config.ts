import viteCompression from 'vite-plugin-compression'

export default () => {
    return {
        plugins: [viteCompression({
            algorithm: 'gzip',
            ext: 'gzip'
        }), viteCompression({
            algorithm: 'brotliCompress',
            ext: 'br'
        })],
        build: {
            lib: {
                entry: 'src/main.ts',
                name: 'carbon',
                fileName: (format) => `web-components.${format}.js`
            },
            sourcemap: false,
            rollupOptions: {
                output: {
                    assetFileNames: "web-components.[ext]",
                }
            }
        }
    };
}