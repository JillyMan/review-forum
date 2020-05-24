import React, { useState } from "react"

import { Modal, Button, Form } from "react-bootstrap"

const RegistrationModalWindow = (props) => {

    const [user, setUser] = useState({
        login: "",
        firstName: "",
        lastName: "",
        password: ""
    })

    const onFormSubmit = (e) => {
        e.preventDefault();
        console.log(user)
    }

    const onLnameChange = (e) => {
        setUser({ ...user, lastName: e.target.value });
    }

    const onFnameChange = (e) => {
        setUser({ ...user, firstName: e.target.value });
    }

    const onLoginChange = (e) => {
        setUser({ ...user, login: e.target.value });
    }

    const onPasswordCHange = (e) => {
        setUser({ ...user, password: e.target.value });
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
                        <Form.Control type="text" placeholder="first name" value={user.firstName} onChange={onFnameChange} required />
                    </Form.Group>
                    <Form.Group controlId="formBasicLname">
                        <Form.Label>Last name</Form.Label>
                        <Form.Control type="text" placeholder="last name" value={user.lastName} onChange={onLnameChange} required />
                    </Form.Group>
                    <Form.Group controlId="formBasicLogin">
                        <Form.Label>Login</Form.Label>
                        <Form.Control type="text" placeholder="login" value={user.login} onChange={onLoginChange} required />
                    </Form.Group>

                    <Form.Group controlId="formBasicPassword">
                        <Form.Label>Password</Form.Label>
                        <Form.Control type="password" placeholder="Password" value={user.password} onChange={onPasswordCHange} required />
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