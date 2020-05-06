import React from 'react'
import getPlaceByCategory from '../../../api/places/place-service'
import ListOfPlacesPresenter from '../presentations/list-of-places-presenter'

const containerStyle = {
    height: "100%",
    width: "100%",
    display: "grid",
    gridTemplateColumns: "1fr auto 1fr"
}

const ListOfPlacesByCategoryContainer = (props) => {

    const { categoryId } = props

    const places = getPlaceByCategory(categoryId)

    return (
        <div style={containerStyle}>
            <div></div>
            <ListOfPlacesPresenter orientation="inline" placeConfigs={places} />
        </div>
    )
}

export default ListOfPlacesByCategoryContainer;