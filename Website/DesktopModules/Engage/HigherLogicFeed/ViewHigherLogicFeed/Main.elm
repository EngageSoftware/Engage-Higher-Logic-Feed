module HigherLogicFeed.ViewHigherLogicFeed.Main exposing (..)

import HigherLogicFeed.ViewHigherLogicFeed.Elm.Model exposing (initialModel, Model)
import HigherLogicFeed.ViewHigherLogicFeed.Elm.View exposing (view)
import HigherLogicFeed.ViewHigherLogicFeed.Elm.Update exposing (update)
import Html.App as Html


main : Program Never
main =
    Html.program
        { init = ( initialModel, Cmd.none )
        , view = view
        , update = update
        , subscriptions = \_ -> Sub.none
        }
