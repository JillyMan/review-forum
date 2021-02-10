import React, { useState } from "react"
import { Button } from "react-bootstrap"
import SignInModalWindow from "./sign-in-modal-window"
import RegistrationModalWindow from "./registration-modal-window"
import {Link} from "react-router-dom"

const signInBtnName = "Sign In"
const registrationBtnName = "Registration"
const logoutBtnName = "Logout"

const signIn = {
    marginLeft: "auto",
    marginRight: "10px"
}

const roleBtnName = JSON.parse(localStorage.getItem("user")) ? JSON.parse(localStorage.getItem("user")).role === "admin" ? "admin" : "super-user" : ""

const NavbarUserButotns = (props) => {

    const [modalShowSignIn, setMSodalShowSignIn] = useState(false);
    const [modalShowRegistration, setModalShowRegistration] = useState(false);

    const onExitBtnClick = (e) => {
        localStorage.removeItem("user");
        document.location.reload();
    }

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
    <Link style={signIn} to={JSON.parse(localStorage.getItem("user")) ? JSON.parse(localStorage.getItem("user")).role === "admin" ? "/admin" : "/super_user" : ""}>
        <Button variant="light"
        >
            {roleBtnName}
        </Button>
    </Link>
        <Button variant="light"
            onClick={onExitBtnClick}
        >
            {logoutBtnName}
        </Button></>

    return props.autorize ? AutorizeButton : notAutorizeButtons
}

export default NavbarUserButotns