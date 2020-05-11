import React from "react"
import { Tab, Tabs } from "react-bootstrap";
import EditCity from "../edit-city";
import EditCountry from "../edit-country";
import ListOfUsers from "../list-of-users";

const containerStyle = {
    marginTop: "10px",
    marginLeft: "5%"
}

const AdminPageContainer = () => {

    return (

        <Tabs defaultActiveKey="city" id="uncontrolled-tab-example" >
            <Tab eventKey="city" title="City" defaultActiveKey>
                <div style={containerStyle}>
                    <EditCity />
                </div>
            </Tab>
            <Tab eventKey="country" title="Country">
                <div style={containerStyle}>
                    <EditCountry />
                </div>
            </Tab>
            <Tab eventKey="user" title="User">
                <div style={containerStyle}>
                    <ListOfUsers />
                </div>
            </Tab>
        </Tabs>
    );
}
export default AdminPageContainer