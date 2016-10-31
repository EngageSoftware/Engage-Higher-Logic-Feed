module HigherLogicFeed.ViewHigherLogicFeed.Elm.Update exposing (..)

import HigherLogicFeed.ViewHigherLogicFeed.Elm.Model exposing (Model)
import HigherLogicFeed.ViewHigherLogicFeed.Elm.Messages exposing (..)


update : Msg -> Model -> ( Model, Cmd Msg )
update msg model =
    case msg of
        Increment ->
            ( { model | x = model.x + 1 }, Cmd.none )

        Decrement ->
            ( { x = model.x - 1, y = model.y }, Cmd.none )
