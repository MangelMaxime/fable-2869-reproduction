module App

open Feliz
open Fable.Core.JsInterop
// Workaround to have React-refresh working
// I need to open an issue on react-refresh to see if they can improve the detection
emitJsStatement () "import React from \"react\""

importSideEffects "./index.scss"

[<ReactComponent>]
let App () : ReactElement =
    Consent.Consent()
