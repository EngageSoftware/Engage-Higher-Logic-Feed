module HigherLogicFeed.ViewHigherLogicFeed.Elm.Tests.UpdateTests exposing (tests)

import Test exposing (..)
import Expect exposing (Expectation)
import Fuzz exposing (Fuzzer)
import HigherLogicFeed.ViewHigherLogicFeed.Elm.Messages exposing (Msg(..))
import HigherLogicFeed.ViewHigherLogicFeed.Elm.Model exposing (Model, initialModel)
import HigherLogicFeed.ViewHigherLogicFeed.Elm.Update exposing (update)


tests : List Test
tests =
    [ test "Increment adds one to x" <| \() -> incrementAddsOne
    , test "Increment does not change y" <| \() -> incrementDoesNotChangeMessage
    , fuzz (Fuzz.tuple ( Fuzz.int, Fuzz.string )) "Decrement message subtracts one from model's X" <| decrementSubtractsOne
    ]


incrementAddsOne : Expectation
incrementAddsOne =
    let
        ( incrementedModel, _ ) =
            update Increment { x = 0, y = "" }
    in
        incrementedModel.x
            |> Expect.equal 1


incrementDoesNotChangeMessage : Expectation
incrementDoesNotChangeMessage =
    let
        ( incrementedModel, _ ) =
            update Increment { x = 0, y = "Message" }
    in
        incrementedModel.y
            |> Expect.equal "Message"


decrementSubtractsOne : ( Int, String ) -> Expectation
decrementSubtractsOne ( x, y ) =
    let
        ( decrementedModel, _ ) =
            update Decrement (Model x y)
    in
        decrementedModel.x
            |> Expect.equal (x - 1)
