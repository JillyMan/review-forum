import React, { useState } from "react"
import { Form, DropdownButton, Dropdown, Col } from "react-bootstrap"

import { getAll } from "../../api/countries/country-service"

const AddressBuilder = (props) => {


    const [countries] = useState(getAll())

    const getCitiesByCountry = (country) => {
        let array = [{ id: 0 }]
        countries.forEach(element => {
            if (element.name === country) {
                array = element.cities
            }
        });
        return array;
    }

    const [address, setAddress] = useState({
        street: "",
        longtude: "",
        latitude: "",
        city: {
            id: "",
            name: "City",
        },
        country: {
            name: "Country"
        }
    });

    const { onAddressChange } = props

    const onStreetChange = (e) => {
        const newAddress = {
            ...address,
            street: e.target.value
        }
        setAddress(newAddress)
        onAddressChange(newAddress)
    }


    const onLongtudeChange = (e) => {
        const newLongtude = {
            ...address,
            longtude: e.target.value,
        }

        setAddress(newLongtude)
        onAddressChange(newLongtude)
    }


    const onLatitudeChange = (e) => {
        const newLatitude = {
            ...address,
            latitude: e.target.value,
        }

        setAddress(newLatitude)
        onAddressChange(newLatitude)
    }

    const onCityChange = (id, name) => {
        const newCity = {
            ...address,
            city: {
                id: id,
                name: name
            }
        }
        setAddress(newCity)
        onAddressChange(newCity)
    }

    const onCountryChange = (name) => {
        const newCountry = {
            ...address,
            country: {
                name: name
            },
        }
        setAddress(newCountry)
        onAddressChange(newCountry)
    }

    const countriesList = countries.map((country) => (
        <Dropdown.Item onClick={() => onCountryChange(country.name)} key={country.name}>{country.name}</Dropdown.Item>
    ))

    const citiesList = getCitiesByCountry(address.country.name).map((value) => (
        <Dropdown.Item
            key={value.id}
            onClick={() => onCityChange(value.id, value.name)}
        >
            {value.name}
        </Dropdown.Item>
    ))

    return (
        <>
            <Form.Group as={Col} controlId="formGridCountry">
                <Form.Label>Country</Form.Label>
                <DropdownButton id="dropdown-basic-button1" title={address.country.name}>
                    {countriesList}
                </DropdownButton>
            </Form.Group>

            <Form.Group as={Col} controlId="formGridCity">
                <Form.Label>City</Form.Label>
                <DropdownButton id="dropdown-basic-button2" title={address.city.name}>
                    {citiesList}
                </DropdownButton>
            </Form.Group>

            <Form.Group as={Col} controlId="formGridStreet">
                <Form.Label>Street</Form.Label>
                <Form.Control type="text" placeholder="street" value={address.street} onChange={onStreetChange} required />
            </Form.Group>

            <Form.Group as={Col} controlId="formGridLongtude">
                <Form.Label>Longtude</Form.Label>
                <Form.Control type="text" placeholder="longtude" value={address.longtude} onChange={onLongtudeChange} required />
            </Form.Group>

            <Form.Group as={Col} controlId="formGridLatitude">
                <Form.Label>Latitude</Form.Label>
                <Form.Control type="text" placeholder="Latitude" value={address.latitude} onChange={onLatitudeChange} required />
            </Form.Group>
        </>
    )
}

export default AddressBuilder