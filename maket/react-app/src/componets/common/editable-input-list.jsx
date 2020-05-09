import React from "react"

import { ButtonGroup, Button } from "react-bootstrap";
import EditableInput from "./editable-input";

const containerStyle = {
    width: "270px",
    marginTop: "10px"
}


const EditableInputList = (props) => {

    const { entities, add, update, addToDeleteList, onDelete } = props

    return (
        <>
            <ButtonGroup>
                <Button variant="secondary" onClick={add}>Add</Button>
                <Button variant="secondary" onClick={onDelete}>Delete</Button>
            </ButtonGroup>
            <br />
            <div style={containerStyle}>
                {entities.map((value, rowIndex) => (
                    <EditableInput
                        key={rowIndex}
                        add={add}
                        update={update}
                        addToDeleteList={addToDeleteList}
                        rowIndex={rowIndex}
                        value={value.name}
                        valueId={value.id}
                    />
                ))}
            </div>
        </>
    )
}

export default EditableInputList