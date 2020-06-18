import React, { useState } from "react"
import { login } from "../../api/user/user-service"
import { Modal, Button, Form } from "react-bootstrap"

const SignInModalWindow = (props) => {

    const [user, setUser] = useState({
        login: "",
        password: ""
    })

    const onFormSubmit = (e) => {
        if(login(user)){
            document.location.reload();
        }
        e.preventDefault();
    }

    const onLoginChange = (e) => {
        setUser({ ...user, login: e.target.value })
    }

    const onPasswordCHange = (e) => {
        setUser({ ...user, password: e.target.value })
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

export default SignInModalWindow