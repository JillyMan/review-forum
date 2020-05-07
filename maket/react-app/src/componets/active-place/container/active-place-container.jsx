import React from "react"
import ActivePlacePresetation from "../presentation/active-place-presentation"

const ActivePlaceContainer = (props) => {
    const place = props.selector();
    return <ActivePlacePresetation place={place} />;
}

export default ActivePlaceContainer