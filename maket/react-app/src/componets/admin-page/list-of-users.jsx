import React from "react"
import { ButtonGroup, Button } from "react-bootstrap";
import EditableInput from "../common/editable-input";

const ListOfUsers = () => {

    <ButtonGroup>
        <Button variant="secondary" >Add</Button>
        <Button variant="secondary" >Delete</Button>
    </ButtonGroup>

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
                        //  add={add}
                        //  update={update}
                        //  addToDeleteList={addToDeleteList}
                        rowIndex={rowIndex}
                        value={value.name}
                        valueId={value.id}
                    />
                ))}
            </div>
        </>
    );
}

export default ListOfUsers