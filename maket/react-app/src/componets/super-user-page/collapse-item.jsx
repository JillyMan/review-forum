import React, { useState } from "react"
import { Button, Collapse } from "react-bootstrap";
import "./style/collapse.css"

const btnStyle = {
    marginLeft: "10px",
    marginTop: "10px"
}

const containerstyle = {
    width: "100%",
    height: "400px",
    overflow: "auto"
}

const CollapseItem = (props) => {

    const [open, setOpen] = useState(false);

    const { handlerName, contentForm, change } = props

    const [dishes, setDishes] = useState([contentForm])

    const addDish = () => {
        setDishes([...dishes, contentForm])
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

            <Collapse in={open} style={containerstyle}>
                <div>
                    <Button
                        onClick={addDish}
                        style={btnStyle}
                    >
                        +
            </Button>
                    <div id="example-collapse-text" >
                        <div style={containerstyle}>
                            {dishes.map((value, index) => (
                                <div className="containerstyle"
                                    key={index}>
                                    {value}
                                </div>
                            ))}
                        </div>
                    </div>
                </div>
            </Collapse>
        </>
    )
}

export default CollapseItem