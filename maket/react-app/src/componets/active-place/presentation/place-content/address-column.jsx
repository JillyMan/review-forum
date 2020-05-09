import React from "react"
import ActivePlaceAddress from "../active-place-address"

const AddressColumn = (props) => {

    return (
        <div className="addressColumn">
            <ActivePlaceAddress contacts={props.address} />
        </div>
    )

}

export default AddressColumn