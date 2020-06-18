import React, { useState } from "react"
import { registration } from "../../api/security/security"

import { Modal, Button, Form } from "react-bootstrap"

const RegistrationModalWindow = (props) => {

    const [user, setUser] = useState({
        Email: "",
        FirstName: "",
        LastName: "",
        Login: "",
        Password: ""
    })

    const onFormSubmit = (e) => {
        registration(user).then(response=>{
            console.log(response)
        })
        e.preventDefault();
    }

    const onLnameChange = (e) => {
        setUser({ ...user, LastName: e.target.value });
    }

    const onFnameChange = (e) => {
        setUser({ ...user, FirstName: e.target.value });
    }

    const onLoginChange = (e) => {
        setUser({ ...user, Login: e.target.value });
    }

    const onPasswordCHange = (e) => {
        setUser({ ...user, Password: e.target.value });
    }

    const onEmailChange = (e) =>{
        setUser({ ...user, Email: e.target.value });
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
                        <Form.Label>Email address</Form.Label>
                        <Form.Control type="text" placeholder="Email address" value={user.Email} onChange={onEmailChange} required />
                    </Form.Group>
                    <Form.Group controlId="formBasicFname">
                        <Form.Label>First name</Form.Label>
                        <Form.Control type="text" placeholder="first name" value={user.FirstName} onChange={onFnameChange} required />
                    </Form.Group>
                    <Form.Group controlId="formBasicLname">
                        <Form.Label>Last name</Form.Label>
                        <Form.Control type="text" placeholder="last name" value={user.LastName} onChange={onLnameChange} required />
                    </Form.Group>
                    <Form.Group controlId="formBasicLogin">
                        <Form.Label>Login</Form.Label>
                        <Form.Control type="text" placeholder="login" value={user.Login} onChange={onLoginChange} required />
                    </Form.Group>
                    <Form.Group controlId="formBasicPassword">
                        <Form.Label>Password</Form.Label>
                        <Form.Control type="password" placeholder="Password" value={user.Password} onChange={onPasswordCHange} required />
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