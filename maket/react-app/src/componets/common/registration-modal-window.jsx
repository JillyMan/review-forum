import React, { useState } from "react"

import { Modal, Button, Form } from "react-bootstrap"

const RegistrationModalWindow = (props) => {


    const [login, setLogin] = useState()
    const [firstName, setFirstName] = useState()
    const [lastName, setLastName] = useState()
    const [password, setPassword] = useState()

    const onFormSubmit = () => {

    }

    const onLnameChange = (e) => {
        setLastName(e.target.value)
    }

    const onFnameChange = (e) => {
        setFirstName(e.target.value)
    }

    const onLoginChange = (e) => {
        setLogin(e.target.value)
    }

    const onPasswordCHange = (e) => {
        setPassword(e.target.value)
    }

    return (
        <Modal
            {...props}
            size="lg"
            aria-labelledby="contained-modal-title-vcenter"
            centered
        >
            <Modal.Header closeButton>
                <Modal.Title id="contained-modal-title-vcenter">
                    Registration
                </Modal.Title>
            </Modal.Header>
            <Modal.Body>
                <Form>
                    <Form.Group controlId="formBasicFname">
                        <Form.Label>First name</Form.Label>
                        <Form.Control type="text" placeholder="first name" value={firstName} onChange={onFnameChange} required />
                    </Form.Group>
                    <Form.Group controlId="formBasicLname">
                        <Form.Label>Last name</Form.Label>
                        <Form.Control type="text" placeholder="last name" value={lastName} onChange={onLnameChange} required />
                    </Form.Group>
                    <Form.Group controlId="formBasicLogin">
                        <Form.Label>Login</Form.Label>
                        <Form.Control type="text" placeholder="login" value={login} onChange={onLoginChange} required />
                    </Form.Group>

                    <Form.Group controlId="formBasicPassword">
                        <Form.Label>Password</Form.Label>
                        <Form.Control type="password" placeholder="Password" value={password} onChange={onPasswordCHange} required />
                    </Form.Group>
                    <Button variant="primary" type="submit" onClick={onFormSubmit}>
                        Submit
                    </Button>
                </Form>
            </Modal.Body>

        </Modal>
    )
}

export default RegistrationModalWindow