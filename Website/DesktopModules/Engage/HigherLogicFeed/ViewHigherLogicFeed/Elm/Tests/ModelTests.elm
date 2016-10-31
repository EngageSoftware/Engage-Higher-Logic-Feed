module HigherLogicFeed.ViewHigherLogicFeed.Elm.Tests.ModelTests exposing (tests)

import Test exposing (..)
import Expect exposing (Expectation)
import HigherLogicFeed.ViewHigherLogicFeed.Elm.Model exposing (Model, initialModel)


tests : List Test
tests =
    [ test "x starts at zero" <|
        \() ->
            initialModel.x
                |> Expect.equal 0
    , test "y is 'Message'" <|
        \() ->
            initialModel.y
                |> Expect.equal "Message"
    ]
