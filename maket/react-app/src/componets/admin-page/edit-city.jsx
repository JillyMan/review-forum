import React, { useState } from "react"
import { Form } from "react-bootstrap";
import { getAll } from "../../api/countries/country-service"
import EditableInputList from "../common/editable-input-list";

const formStyle = {
    width: "16%",
}

const inputStyle = {
    marginBottom: "10px"
}

const CityComponent = () => {

    const [country, setCountry] = useState(getAll());
    const [selectedCountry, setSelectedCountry] = useState(country[0].name);
    const [selectedToDelete, setSelectedToDelete] = useState([])

    const getCurrentCountryId = () => {
        let index = 0;
        country.forEach((value, id) => {
            if (value.name === selectedCountry) {
                index = id;
            }
        })
        return index
    }

    const update = (index, newValue) => {
        let array = country.slice();
        array[getCurrentCountryId()].cities[index].name = newValue
        setCountry(array.slice())
    }

    const add = () => {
        let array = country.slice()
        array[getCurrentCountryId()].cities.push({
            name: ""
        })
        setCountry(array.slice())
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
                array[getCurrentCountryId()].cities = array[getCurrentCountryId()]
                    .cities.filter((city) => city.id !== value.id)
            }
        })
        setSelectedToDelete([])
        setCountry(array.slice())
    }


    return (
        <Form style={formStyle}>
            <Form.Label>Country</Form.Label>
            <Form.Control as="select" style={inputStyle} onChange={(e) => { setSelectedCountry(e.target.value) }}>
                {country.map((value, i) => (<option key={i}>{value.name}</option>))}
            </Form.Control>
            <EditableInputList
                entities={country[getCurrentCountryId()].cities}
                add={add}
                update={update}
                addToDeleteList={addToDeleteList}
                onDelete={onDelete}
            />
        </Form>
    )

}

export default CityComponent