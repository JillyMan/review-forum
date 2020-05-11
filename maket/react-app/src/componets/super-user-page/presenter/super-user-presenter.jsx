import React from "react"
import { Tabs, Tab, Container, Row, Col } from "react-bootstrap"
import AddPlaceComponent from "../add-place-componet"
import PlacesByUser from "../places-by-user"



const SuperUserPresenter = () => {

    return (
        <Tabs defaultActiveKey="profile" id="uncontrolled-tab-example">
            <Tab eventKey="home" title="My places">
                <PlacesByUser />
            </Tab>
            <Tab eventKey="profile" title="Add New">
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
        </Tabs>
    )
}

export default SuperUserPresenter