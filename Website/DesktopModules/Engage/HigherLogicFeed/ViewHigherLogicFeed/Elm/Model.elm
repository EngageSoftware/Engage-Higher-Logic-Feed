module HigherLogicFeed.ViewHigherLogicFeed.Elm.Model exposing (..)


type alias Model =
    { x : Int
    , y : String
    }


initialModel : Model
initialModel =
    { x = 0
    , y = "Message"
    }
