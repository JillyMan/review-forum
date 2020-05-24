import React from "react"
import EditableInputUser from "./editable-input-user";
import { Row, Col } from "react-bootstrap";


const containerStyle = {
    width: "400px",
    marginTop: "10px"
}

const ListOfUsers = (props) => {

    const { entities, statusUpdate } = props

    return (
        <>
            <div style={containerStyle}>
                <Row style={{ border: "1px solid black" }}>
                    <Col xs lg="2" style={{ border: "1px solid black", textAlign: "center" }}>Id</Col>
                    <Col xs lg="4" style={{ border: "1px solid black", textAlign: "center" }}>Name</Col>
                    <Col xs lg="4" style={{ border: "1px solid black", textAlign: "center" }}>login</Col>
                    <Col xs lg="2" style={{ border: "1px solid black", textAlign: "center" }}>status</Col>
                </Row>
                {entities.map((value, index) => (
                    <EditableInputUser
                        key={index}
                        user={value}
                        statusUpdate={statusUpdate}
                        userIndex={index}
                    />
                ))}
            </div>
        </>
    )
}

export default ListOfUsers