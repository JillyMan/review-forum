import React from "react"
import StarRaiting from "./star-raiting"

const delishesCardStyle = {
    height: "100%",
    width: "240px",
    backgroundColor: "white",
    display: "grid",
    gridTemplateRows: "70% 30%",
    border: "1px solid black",
    borderRadius: "10px",
    float: "left",
    marginRight: "10px"
}

const DelishesCard = (props) => {

    const { info } = props

    const onRateChange = (value) => {
        
    }

    return (
        <div style={delishesCardStyle}>
            <div style={{
                padding: "10px"
            }}>
                <img
                    src={info.image.imageUrl}
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
                <div style={{ fontSize:"30px"}}>
                    <StarRaiting rate={3} onRateChange={onRateChange}/>
                </div>
                <div style={{
                    textAlign: "center",
                    alignSelf: "center",
                    borderRadius: "5px"
                }}>
                    {info.name + " : " + info.price + " $"}
                </div>
            </div>
        </div>
    )
}

export default DelishesCard