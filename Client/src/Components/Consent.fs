module Consent

open Feliz
open Fable.Core.JsInterop

// Workaround to have React-refresh working
// I need to open an issue on react-refresh to see if they can improve the detection
emitJsStatement () "import React from \"react\""

let private classes : CssModules.Components.Consent = import "default" "./Consent.module.css"

[<ReactComponent>]
let Consent () : ReactElement =
    Html.div [
        prop.className classes.pageContent

        prop.children [
            Html.div "Consent component"
        ]
    ]
