## Reproduce Fable the bug

The bug that we want to reproduce is that when updating `CssModules.fs` Fable regenerate `Components/Consent.fs`. It shouldn't do that anymore more with Fable 3.7.15.

### Steps

1. `npm install`
2. `npm run dev`
3. Open `Client/src/CssModules.fs`
4. Force save the `CssModules.fs` file. You can add a `space` or replace a character by the same for example.
5. See that vite is saying `[vite] hmr update ...`

You can verify that the timestamp of `Client/src/Components/Consent.fs` by running `ll` in `Client/src/Components/`
