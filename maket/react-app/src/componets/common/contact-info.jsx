import React from "react"


const contactInfoStyle = {
    fontSize : "12px"
}

const ContactInfo = (props) => {

    const { data } = props

    return (
    <>
        <div style={ contactInfoStyle }>
            {data.Address.Country.name.toUpperCase()}
            <br />
            {data.Address.City.name.toUpperCase()}
            <br />
            {data.Address.Street.name.toUpperCase()}
        </div>
        <div>
            {props.data.phoneNumber}
        </div>
    </>
    )
}

export default ContactInfo