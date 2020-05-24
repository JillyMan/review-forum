import React, { useState } from "react"
import { Form, Col, Dropdown, DropdownButton } from "react-bootstrap"
import AddressBuilder from "./address-builder"
import { getAll } from "../../api/place-types/place-type-service"


const CommonInfo = (props) => {
    const { changeAddress, changeContactInfo } = props

    const [placeCategory] = useState(getAll())

    const [contactValues, setContactValues] = useState({
        name: "",
        phone: "",
        imgUrl: "",
        category: {
            id: "",
            name: "type"
        }
    })

    const onNameChange = (e) => {
        const newName = {
            ...contactValues,
            name: e.target.value
        }
        setContactValues(newName)
        changeContactInfo(newName)
    }

    const onImgUrlChange = (e) => {
        const newImgUrl = {
            ...contactValues,
            imgUrl: e.target.value
        }
        setContactValues(newImgUrl)
        changeContactInfo(newImgUrl)
    }

    const onPhoneChange = (e) => {
        const newPhone = {
            ...contactValues,
            phone: e.target.value
        }
        setContactValues(newPhone)
        changeContactInfo(newPhone)
    }

    const onCategoryChange = (id, name) => {
        const newCategory = {
            ...contactValues,
            category: {
                id: id,
                name: name
            }
        }
        setContactValues(newCategory)
        changeContactInfo(newCategory)
    }

    const placeCategoryList = placeCategory.map((place) => (
        <Dropdown.Item
            key={place.id}
            onClick={() => onCategoryChange(place.id, place.name)}
        >{place.name}</Dropdown.Item>
    ))

    return (
        <Form>
            <Form.Row>
                <Form.Group as={Col} controlId="formGridName">
                    <Form.Label>Name</Form.Label>
                    <Form.Control type="text" placeholder="place name" value={contactValues.name} onChange={onNameChange} required />
                </Form.Group>

                <Form.Group as={Col} controlId="formGridPhone">
                    <Form.Label>Phone</Form.Label>
                    <Form.Control type="text" placeholder="phone number" value={contactValues.phone} onChange={onPhoneChange} required />
                </Form.Group>

                <Form.Group as={Col} controlId="formGridImage">
                    <Form.Label>Image</Form.Label>
                    <Form.Control type="text" placeholder="image URL" value={contactValues.imgUrl} onChange={onImgUrlChange} required />
                </Form.Group>

                <Form.Group as={Col} controlId="formGridType">
                    <Form.Label>Type</Form.Label>
                    <DropdownButton id="dropdown-basic-button" title={contactValues.category.name}>
                        {placeCategoryList}
                    </DropdownButton>
                </Form.Group>
            </Form.Row>

            <Form.Row>
                <AddressBuilder onAddressChange={changeAddress} />
            </Form.Row>
        </Form>
    )
}

export default CommonInfo