import React from "react"
import { Tab, Tabs } from "react-bootstrap";
import EditCity from "../edit-city";
import EditCountry from "../edit-country";

const containerStyle = {
    marginTop: "10px",
    marginLeft:"5%"
}

const AdminPageContainer = () => {

    return (

        <Tabs defaultActiveKey="profile" id="uncontrolled-tab-example" >
            <Tab eventKey="home" title="City">
                <div style={containerStyle}>
                    <EditCity />
                </div>
            </Tab>
            <Tab eventKey="profile" title="Country">
                <div style={containerStyle}>
                    <EditCountry />
                </div>
            </Tab>
        </Tabs>
    );
}
export default AdminPageContainer