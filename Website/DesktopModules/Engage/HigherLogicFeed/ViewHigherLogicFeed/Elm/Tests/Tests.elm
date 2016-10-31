module HigherLogicFeed.ViewHigherLogicFeed.Elm.Tests.Tests exposing (all)

import Test exposing (..)
import HigherLogicFeed.ViewHigherLogicFeed.Elm.Tests.ModelTests as ModelTests
import HigherLogicFeed.ViewHigherLogicFeed.Elm.Tests.UpdateTests as UpdateTests


all : Test
all =
    describe "ViewHigherLogicFeed Tests"
        [ describe "Model Tests" ModelTests.tests
        , describe "Update Tests" UpdateTests.tests
        ]
