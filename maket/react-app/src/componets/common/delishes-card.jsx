import React from "react"

const delishesCardStyle = {
    height: "100%",
    width: "240px",
    backgroundColor: "white",
    display: "grid",
    gridTemplateRows: "70% 30%",
    border: "1px solid black",
    borderRadius: "10px",
    float:"left",
    marginRight : "10px"
}

const DelishesCard = (props) => {

    const {info} = props

    return (
        <div style={delishesCardStyle}>
            <div style={{
                padding: "10px"
            }}>
                <img
                    src={info.imageUrl}
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
                    {info.name + " : " + info.cost + " $"}
                </div>
            </div>
        </div>
    )
}

export default DelishesCard