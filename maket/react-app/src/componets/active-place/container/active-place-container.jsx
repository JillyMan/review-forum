import React from "react"
import ActivePlacePresetation from "../presentation/active-place-presentation"

const ActivePlaceContainer = (props) => {
    const place = props.selector()[0];
    return <ActivePlacePresetation place={place} />;
}

export default ActivePlaceContainer