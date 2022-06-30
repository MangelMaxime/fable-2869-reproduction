module Main

open Feliz
open Browser.Dom

let app : obj =
    ReactDOM.render(
        App.App ()
        ,
        document.getElementById("root")
    )
