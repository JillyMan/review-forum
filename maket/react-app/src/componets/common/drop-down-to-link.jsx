import React, { useState } from "react"
import { Dropdown, DropdownButton } from "react-bootstrap"
import { Link } from "react-router-dom";

const dropDownStyle = {
    marginLeft: "130px"
}

const defaultCategoryName = "select category"

const DropDownToLink = (props) => {

    const [dropDownName, setDropDownName] = useState(defaultCategoryName)

    const DropDownItems = props.listOfLinks.map((item, i) => (
            <Dropdown.Item
                key={i}
                as={Link}
                to={item.to}
                onClick={() => setDropDownName(item.name)}
            >
                {item.name}
            </Dropdown.Item>
    )
    )

    return (
        <DropdownButton
            id="dropdown-basic-button"
            title={dropDownName}
            style={ dropDownStyle }>
            {DropDownItems}
        </DropdownButton>
    )
}

export default DropDownToLink