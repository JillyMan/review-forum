import React from 'react'
import ListOfPlacesPresenter from '../presentations/list-of-places-presenter'

const containerStyle = {
    marginTop : "20px",
    height: "100%",
    width: "100%",
    display: "grid",
    gridTemplateColumns: "1fr auto 1fr"
}

const ListOfPlacesContainer = (props) => {

    const { selector } = props

    const places = selector()

    return (
        <div style={containerStyle}>
            <div></div>
            <ListOfPlacesPresenter orientation="inlineоо" placeConfigs={places} />
        </div>
    )
}

export default ListOfPlacesContainer;