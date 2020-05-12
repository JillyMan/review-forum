import React, { useState } from "react"

import { Form } from "react-bootstrap";
import { getAll } from "../../api/user/user-service"
import ListOfUsers from "./list-of-users";

const formStyle = {
    width: "16%",
}

const EditUser = () => {

    const [user, setUser] = useState(getAll());

    const statusUpdate = (newValue, index) => {
        const array = user.slice();
        array[index].isActice = newValue
        setUser(array.slice())
    }

    return (
        <Form style={formStyle}>
            <ListOfUsers
                entities={user}
                statusUpdate={statusUpdate}
            />
        </Form>
    );
}

export default EditUser