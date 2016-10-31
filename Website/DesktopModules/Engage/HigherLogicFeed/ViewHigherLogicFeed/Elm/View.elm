module HigherLogicFeed.ViewHigherLogicFeed.Elm.View exposing (..)

import Html exposing (Html, div, button, text)
import Html.Attributes exposing (type')
import Html.Events exposing (onClick)
import HigherLogicFeed.ViewHigherLogicFeed.Elm.Model exposing (Model)
import HigherLogicFeed.ViewHigherLogicFeed.Elm.Messages exposing (..)


view : Model -> Html Msg
view model =
    div []
        [ text (toString model.x)
        , button [ type' "button", onClick Increment ] [ text "+" ]
        , text model.y
        ]
