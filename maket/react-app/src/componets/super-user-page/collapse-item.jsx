import React, { useState } from "react"
import { Button, Collapse } from "react-bootstrap";
import DishForm from "./dish-form";

const CollapseItem = (props) => {

    const [open, setOpen] = useState(false);

    const { handlerName, contentForm } = props

    const [dishes, setDishes] = useState([contentForm])

    const addDish = () => {
        let array = dishes.slice()
        array.push(contentForm)
        setDishes(array.slice())
    }

    return (
        <>
            <Button
                onClick={() => setOpen(!open)}
                aria-controls="example-collapse-text"
                aria-expanded={open}
            >
                {handlerName}
            </Button>
            <Collapse in={open} style={{ width: "100%", height: "400px", overflow: "auto" }}>

                <div id="example-collapse-text">
                    <Button
                        onClick={addDish}
                    >
                        {handlerName}
                    </Button>
                    {dishes.map((value) => (
                        value
                    ))}
                </div>
            </Collapse>
        </>
    )
}

export default CollapseItem