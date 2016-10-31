port module HigherLogicFeed.ViewHigherLogicFeed.Elm.Tests.NodeTestRunner exposing (main)

import Json.Encode exposing (Value)
import Test.Runner.Node exposing (run)
import HigherLogicFeed.ViewHigherLogicFeed.Elm.Tests.Tests as Tests


main : Program Value
main =
    run emit Tests.all


port emit : ( String, Value ) -> Cmd msg
