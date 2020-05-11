import React, { useState } from "react"
import { Modal, Button, Form } from "react-bootstrap"

const SignInModalWindow = (props) => {

    const [login, setLogin] = useState()
    const [password, setPassword] = useState()

    const onFormSubmit = () => {

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
                    Sign In
                </Modal.Title>
            </Modal.Header>
            <Modal.Body>
                <Form>
                    <Form.Group controlId="formBasicEmail">
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

export default SignInModalWindow