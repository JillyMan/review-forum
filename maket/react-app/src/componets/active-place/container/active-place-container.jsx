import React from "react"
import ActivePlacePresetation from "../presentation/active-place-presentation"

const ActivePlaceContainer = (props) => {

    const { selector } = props

    return <ActivePlacePresetation place={selector} />;
}

export default ActivePlaceContainer