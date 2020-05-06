import React, { useState } from "react"
import { Form, Button, FormControl } from "react-bootstrap"
import { getPlaceByName } from "../../api/places/place-service"
import ListOfPlacesContainer from "../places-by-category/containers/list-of-places-container"

const searchBtnName = "Search"

const searchFormStyle = {
    height: "746px",
    width: "100%",
    display: "grid",
    gridTemplateRows: "33% 33% 33%"
}

const variantsListStyle = {
    marginTop: "10px"
}

const searchSectorStyle = {
    marginTop: "3%",
    height: "100%",
    width: "100%",
    display: "grid",
    gridTemplateColumns: "1fr auto 1fr"
}

const formControlStyle = {
    width: "985px"
}

const SearchPlaceContainer = () => {

    const [placeName, setPlaceName] = useState("");

    const onInputValueChange = (e) => {
        setPlaceName(e.target.value)
    }

    return (
        <div style={searchFormStyle}>
            <div style={searchSectorStyle}>
                <div></div>
                <div>
                    <Form inline>
                        <FormControl
                            type="text"
                            placeholder="Search"
                            className="mr-sm-1"
                            style={formControlStyle}
                            value={placeName}
                            onChange={onInputValueChange} />
                        <Button variant="primary">{searchBtnName}</Button>
                    </Form>
                    <div style={variantsListStyle}>
                        <ListOfPlacesContainer selector={() => getPlaceByName(placeName)} />
                    </div>
                </div>
                <div></div>
            </div>
        </div>

    )
}

export default SearchPlaceContainer