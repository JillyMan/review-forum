import React, { useState } from "react"

import { Button, InputGroup, FormControl } from "react-bootstrap";

const EditableInput = (props) => {

    const { valueId, update, addToDeleteList, value, rowIndex } = props

    const [visibility, setVisibility] = useState("hidden");
    const [defaultValue] = useState(value)
    const [checked, setChecked] = useState(false)

    const onClick = () => {
        setChecked(!checked)
        addToDeleteList(valueId, !checked)
    }

    const btnStyle = {
        backgroundColor: "white",
        visibility: visibility
    }

    const onInputChangeHandler = (e) => {
        const currentValue = e.target.value;

        if (currentValue === defaultValue) {
            update(rowIndex, defaultValue)
            setVisibility("hidden")
        }
        else {
            update(rowIndex, e.target.value)
            setVisibility("visible")
        }

    }

    const applyBtnClick = () => {
        setVisibility("hidden")
    }

    const diskardBtnClick = () => {
        update(rowIndex, defaultValue)
        setVisibility("hidden")
    }

    return (
        <InputGroup className="mb-1">
            <InputGroup.Prepend>
                <InputGroup.Checkbox value={checked} onChange={onClick} />
            </InputGroup.Prepend>
            <FormControl onChange={onInputChangeHandler} value={value} />
            <InputGroup.Append >
                <Button variant="light" style={btnStyle} onClick={applyBtnClick}>&#9745;</Button>
                <Button variant="light" style={btnStyle} onClick={diskardBtnClick}>&#9746;</Button>
            </InputGroup.Append>
        </InputGroup>
    )
}

export default EditableInput