import React, { useState } from "react"
import { Row, Button } from "react-bootstrap"
import CommonInfo from "./common-info"
import CollapseItem from "./collapse-item"
import DishForm from "./dish-form"
import HeaderImageInfo from "./header-image-info"

const rowStyle = {
    paddingBottom: "10px"
}

const editBtnName = "Edit place"

const ChangePlaceComponent = () => {

    const [place, setPlace] = useState({
        name: "",
        phoneNumber: "",
        image: {
            imageUrl: ""
        },
        categoryId: "",
        address: "",
        dishes: [],
        headerImages: []
    });

    const changeAddress = (newValue) => {
        setPlace({
            ...place,
            address: {
                cityId: newValue.city.id,
                street: newValue.street,
                latitude: newValue.latitude,
                Longitude: newValue.longtude
            }
        })
    }

    const changeContactInfo = (newValue) => {
        setPlace({
            ...place,
            name: newValue.name,
            phoneNumber: newValue.phone,
            image: {
                imageUrl: newValue.imgUrl
            },
            categoryId: newValue.category.id
        })
    }

    const onDishesChange = (newValue) => {
        let updatedDishes = [...place.dishes, newValue]
        setPlace({ ...place, dishes: [...updatedDishes] })
    }

    const onHeaderImgChange = (newValue) => {
        let array = place.headerImages.slice()
        array.push(newValue);
        setPlace({ ...place, headerImages: array.slice() })
    }

    const removeDishes = (item) => {

    }

    const removeHeaderImg = (item) => {

    }

    return (
        <>
            <Row style={rowStyle}>
                <CommonInfo
                    changeAddress={changeAddress}
                    changeContactInfo={changeContactInfo}
                />
            </Row>
            <Row style={rowStyle}>
                <CollapseItem
                    handlerName={"Header Image"}
                    contentForm={<HeaderImageInfo onChange={onHeaderImgChange} />}
                />
            </Row>
            <Row style={rowStyle}>
                <CollapseItem
                    handlerName={"Dish"}
                    contentForm={<DishForm onChange={onDishesChange} />}
                />
            </Row>
            <Row>
                <Button variant="primary" onClick={() => { console.log(place) }}>{editBtnName}</Button>
            </Row>
        </>
    )
}

export default ChangePlaceComponent