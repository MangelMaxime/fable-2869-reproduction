import { defineConfig } from 'vite'
import react from '@vitejs/plugin-react'
import fs from 'fs'

// https://vitejs.dev/config/
export default defineConfig({
    plugins: [react()],
    css: {
        postcss: {
            plugins : [
                // autoprefixer
                require('autoprefixer')
            ]
        }
    },
    server: {
        watch: {
            ignored: [
                "**/*.fs"
            ]
        }
    }
})
