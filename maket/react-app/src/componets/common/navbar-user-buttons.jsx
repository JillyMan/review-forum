import React, { useState } from "react"
import { Button } from "react-bootstrap"
import SignInModalWindow from "./sign-in-modal-window"
import RegistrationModalWindow from "./registration-modal-window"

const signInBtnName = "Sign In"
const registrationBtnName = "Registration"
const logoutBtnName = "Logout"

const signIn = {
    marginLeft: "auto",
    marginRight: "10px"
}

const NavbarUserButotns = (props) => {

    const [modalShowSignIn, setMSodalShowSignIn] = useState(false);
    const [modalShowRegistration, setModalShowRegistration] = useState(false);

    const notAutorizeButtons = <>
        <Button variant="light"
            style={signIn}
            onClick={() => { setMSodalShowSignIn(true) }}
        >{signInBtnName}</Button>
        <SignInModalWindow
            show={modalShowSignIn}
            onHide={() => setMSodalShowSignIn(false)}
        />
        <Button variant="light"
            onClick={() => { setModalShowRegistration(true) }}
        >{registrationBtnName}</Button>
        <RegistrationModalWindow
            show={modalShowRegistration}
            onHide={() => setModalShowRegistration(false)}
        />
    </>
    const AutorizeButton = <>
        <Button variant="light"
            style={signIn}
        >{logoutBtnName}</Button></>

    return props.autorize ? AutorizeButton : notAutorizeButtons
}

export default NavbarUserButotns