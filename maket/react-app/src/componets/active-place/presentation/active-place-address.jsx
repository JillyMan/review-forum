import React from "react"
import { ListGroup } from "react-bootstrap"

const ActivePlaceAddress = (props) => {

    const { contacts } = props

    return (
        <>
            <ListGroup>
                <ListGroup.Item>{contacts.Address.City.Country.name.toUpperCase()}</ListGroup.Item>
                <ListGroup.Item>{contacts.Address.City.name.toUpperCase()}</ListGroup.Item>
                <ListGroup.Item>{contacts.Address.Street.name.toUpperCase()}</ListGroup.Item>
                <ListGroup.Item>{contacts.phoneNumber}</ListGroup.Item>
            </ListGroup>
        </>
    )

}

export default ActivePlaceAddress