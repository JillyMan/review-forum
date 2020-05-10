import React from "react"
import { Form, Button, Col } from "react-bootstrap"

const SuperUserPresenter = () => {

    return (
        <Form>
            <Form.Group controlId="formGridEmail">
                <Form.Label>Name</Form.Label>
                <Form.Control type="text" placeholder="Enter place name" />
            </Form.Group>

            <Form.Group controlId="formGridPassword">
                <Form.Label>Image</Form.Label>
                <Form.Control type="text" placeholder="image" />
            </Form.Group>


            <Form.Group controlId="formGridPassword">
                <Form.Label>Phone number</Form.Label>
                <Form.Control type="text" placeholder="number" />
            </Form.Group>


            <Form.Group controlId="formGridAddress1">
                <Form.Label>Address</Form.Label>
                <Form.Control placeholder="1234 Main St" />
            </Form.Group>

            <Form.Group controlId="formGridAddress2">
                <Form.Label>Address 2</Form.Label>
                <Form.Control placeholder="Apartment, studio, or floor" />
            </Form.Group>

            <Form.Row>
                <Form.Group as={Col} controlId="formGridCity">
                    <Form.Label>City</Form.Label>
                    <Form.Control />
                </Form.Group>

                <Form.Group as={Col} controlId="formGridState">
                    <Form.Label>State</Form.Label>
                    <Form.Control as="select" value="Choose...">
                        <option>Choose...</option>
                        <option>...</option>
                    </Form.Control>
                </Form.Group>

            </Form.Row>

            <Form.Group id="formGridCheckbox">
                <Form.Check type="checkbox" label="Check me out" />
            </Form.Group>

            <Button variant="primary" type="submit">
                Submit
  </Button>
        </Form>
    )
}

export default SuperUserPresenter