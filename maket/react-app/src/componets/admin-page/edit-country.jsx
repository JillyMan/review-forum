import React, { useState } from "react"
import { Form } from "react-bootstrap";
import { getAll } from "../../api/countries/country-service"
import EditableInputList from "../common/editable-input-list";

const formStyle = {
    width: "16%",
}


const CountryComponent = () => {
    const [country, setCountry] = useState(getAll());
    const [selectedToDelete, setSelectedToDelete] = useState([])

    const update = (index, newValue) => {
        let array = country.slice()
        array[index].name = newValue;
        setCountry(array.slice())
    }

    const add = () => {
        setCountry([...country, { name: "", sities: {} }])
    }

    const addToDeleteList = (value, status) => {
        let array = selectedToDelete.slice();
        array = array.filter((selectedValue) => selectedValue.name !== value);
        array.push({ id: value, status: status })
        setSelectedToDelete(array.slice())
    }

    const onDelete = () => {
        let array = country.slice();
        selectedToDelete.forEach((value) => {
            if (value.status) {
                array = array.filter((country) => country.id !== value.id)
            }
        })
        setSelectedToDelete([])
        setCountry(array.slice())
    }

    return (
        <Form style={formStyle}>
            <EditableInputList
                entities={country}
                add={add}
                update={update}
                addToDeleteList={addToDeleteList}
                onDelete={onDelete}
            />
        </Form>)
}

export default CountryComponent