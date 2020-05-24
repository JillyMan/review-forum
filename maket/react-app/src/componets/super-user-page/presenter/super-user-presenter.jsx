import React, { useState } from "react"
import { Tabs, Tab, Container, Row, Col, Button } from "react-bootstrap"
import AddPlaceComponent from "../add-place-componet"
import PlacesByUser from "../places-by-user"
import ChangePlaceComponent from "../change-place-component"

const deleteBtnName = "delete place"

const SuperUserPresenter = () => {

    const [key, setKey] = useState("my")
    const [selectedPlace, setSelectedPlace] = useState("")

    return (
        <Tabs
            defaultActiveKey="my"
            id="uncontrolled-tab-example"
            activeKey={key}
            onSelect={(k) => setKey(k)}
        >
            <Tab eventKey="my" title="My places">
                <Container>
                    <Row>
                        <Col></Col>
                        <Col xs lg="12">
                            <PlacesByUser changeActiveTab={setKey} selectedPlace={setSelectedPlace}/>
                        </Col>
                        <Col></Col>
                    </Row>
                </Container>
            </Tab>
            <Tab eventKey="add" title="Add New">
                <Container>
                    <Row>
                        <Col></Col>
                        <Col xs lg="7">
                            <AddPlaceComponent />
                        </Col>
                        <Col></Col>
                    </Row>
                </Container>
            </Tab>
            <Tab eventKey="edit" title="Edit place">
                <Container>
                    <Row>
                        <Col>
                            <Button variant="primary">{deleteBtnName}</Button>
                        </Col>
                        <Col xs lg="7">
                            <ChangePlaceComponent place={selectedPlace.place} />
                        </Col>
                        <Col></Col>
                    </Row>
                </Container>
            </Tab>
        </Tabs>
    )
}

export default SuperUserPresenter