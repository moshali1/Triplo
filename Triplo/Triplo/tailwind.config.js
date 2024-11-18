/** @type {import('tailwindcss').Config} */
module.exports = {
    content: [
        './**/*.{razor,html}',
        '../Triplo.Client/**/*.{razor,html}'
    ],
  theme: {
    extend: {},
  },
    plugins: [
        require('@tailwindcss/forms'),
    ],
}
