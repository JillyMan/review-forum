import React, { useState } from "react"
import { Row, Button } from "react-bootstrap"
import CommonInfo from "./common-info"
import CollapseItem from "./collapse-item"
import DishForm from "./dish-form"
import HeaderImageInfo from "./header-image-info"

const rowStyle = {
    paddingBottom: "10px"
}

const AddPlaceComponent = () => {

    const [inputPlace, setValues] = useState({
        contactInfo: "",
        address: "",
        dishes: [],
        headerImages: []
    });

    const changeAddress = (newValue) => {
        setValues({ ...inputPlace, address: newValue })
    }

    const changeContactInfo = (newValue) => {
        setValues({ ...inputPlace, contactInfo: newValue })
    }

    const onDishesChange = (newValue) => {
        let array = inputPlace.dishes.slice()
        array.push(newValue);
        setValues({ ...inputPlace, dishes: array })
    }

    const onHeaderImgChange = (newValue) => {
        let array = inputPlace.headerImages.slice()
        array.push(newValue);
        setValues({ ...inputPlace, headerImages: array })
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
                    handlerName={"Add Header Image"}
                    contentForm={<HeaderImageInfo onChange={onHeaderImgChange} />}
                    change={onHeaderImgChange}
                />
            </Row>
            <Row style={rowStyle}>
                <CollapseItem
                    handlerName={"Add Dishes"}
                    contentForm={<DishForm onChange={onDishesChange} />}
                    change={onDishesChange}
                />
            </Row>
            <Row>
                <Button variant="primary">Add</Button>
            </Row>
        </>
    )
}

export default AddPlaceComponent