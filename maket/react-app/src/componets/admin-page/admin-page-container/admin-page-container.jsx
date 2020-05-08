import React, { useState } from "react"
import { Form, Button, ButtonGroup } from "react-bootstrap";

const AdminPageContainer = () => {

    const country1 = {
        name: "Belarus",
        cities: [
            {
                name: "Hrodna",
            },
            {
                name: "Brest"
            },
            {
                name: "Minsk"
            }
        ]
    }

    const country2 = {
        name: "USA",
        cities: [
            {
                name: "New-York",
            },
            {
                name: "Oklahoma"
            },
            {
                name: "Kentucky"
            }
        ]
    }

    const country3 = {
        name: "Poland",
        cities: [
            {
                name: "Krakow",
            },
            {
                name: "Bylastok"
            },
            {
                name: "Warshaw"
            }
        ]
    }


    const [country, setCountry] = useState([country1, country2, country3]);
    const [selectedCountry, setSelectedCountry] = useState(country[0].name);
    const [text, setText] = useState("")

    return (
        <Form>
            <Form.Group controlId="exampleForm.ControlSelect1">
                <Form.Label>Country</Form.Label>
                <Form.Control as="select" onChange={(e) => { setSelectedCountry(e.target.value) }}>
                    {country.map((value, i) => (<option key={i}>{value.name}</option>))}
                </Form.Control>
            </Form.Group>
            <Form.Group controlId="exampleForm.ControlSelect2">
                <ButtonGroup aria-label="Basic example">
                    <Button variant="secondary">Add</Button>
                    <Button variant="secondary">Delete</Button>
                </ButtonGroup>
                    {country.map((value, i) => (
                        value.name === selectedCountry ? value.cities.map((city, i) => <option>{city.name}</option>) : ""
                    )
                    )
                    }
            </Form.Group>
        </Form>
    );
}
export default AdminPageContainer