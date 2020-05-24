import React, { useState } from "react"

import { Button, InputGroup, FormControl, Row, Col, Container } from "react-bootstrap";

const block = "block"
const unBlock = "unblock"

const btnStyle = {
    backgroundColor: "white",
    visibility: "visible"
}

const EditableInputUser = (props) => {

    const { user, statusUpdate, userIndex } = props

    const inputStyle = {
        backgroundColor: user.isActice ? "white" : "#FEBDD7",
        width: "400px",
        textAlign: "center"
    }

    const blockStatusChange = () => {
        statusUpdate(!user.isActice, userIndex)
    }

    return (
        <>
            <Row style={inputStyle}>
                <Col xs lg="2" style={{ textAlign: "center" }}>{user.id}</Col>
                <Col xs lg="4" style={{ textAlign: "center" }}>{user.name}</Col>
                <Col xs lg="4" style={{ textAlign: "center" }}>{user.login}</Col>
                <Col xs lg="2" style={{ textAlign: "center", alignItems: "center" }}><Button variant="light" style={btnStyle} onClick={blockStatusChange}>{user.isActice ? block : unBlock}</Button></Col>
            </Row>
        </>
    )
}

export default EditableInputUser