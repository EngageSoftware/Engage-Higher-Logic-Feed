module HigherLogicFeed.ViewHigherLogicFeed.Elm.Tests.HtmlTestRunner exposing (main)

import Test.Runner.Html exposing (run)
import HigherLogicFeed.ViewHigherLogicFeed.Elm.Tests.Tests as Tests


main : Program Never
main =
    run Tests.all
