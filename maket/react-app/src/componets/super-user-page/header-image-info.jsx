import React, { useState } from "react"

const delishesCardStyle = {
    height: "250px",
    width: "200px",
    backgroundColor: "white",
    display: "grid",
    gridTemplateRows: "60% 50%",
    border: "1px solid black",
    borderRadius: "10px",
    float: "left",
    marginRight: "10px",
    marginTop: "10px"
}

const exitBtn = {
    marginLeft: "90%",
    border: 0
}

const HeaderImageInfo = (props) => {
    const { onChange } = props

    const [dishesValue, setDishesValue] = useState({
        imgPath: "",
    })

    const onImgPathChange = (e) => {
        const newImg = {
            ...dishesValue,
            imgPath: e.target.value
        }
        setDishesValue(newImg)
        onChange(newImg)
    }

    return (
        <div style={delishesCardStyle}>
            <div style={{
                padding: "10px"
            }}>
                <button style={exitBtn}>X</button>
                <img
                    src={dishesValue.imgPath}
                    alt="..."
                    style={{
                        height: "100%",
                        width: "100%",
                        borderRadius: "10px"
                    }}
                />
            </div>
            <div style={{
                textAlign: "center",
                alignSelf: "center",
                padding: "5px"
            }}>
                <div style={{
                    textAlign: "center",
                    alignSelf: "center",
                    borderRadius: "5px"
                }}>
                    <label>
                        url
                        <input type="text" value={dishesValue.imgPath} onChange={onImgPathChange} />
                    </label>
                </div>
            </div>
        </div>
    )
}

export default HeaderImageInfo