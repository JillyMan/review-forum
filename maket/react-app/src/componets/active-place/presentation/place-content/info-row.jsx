import React, { useState } from "react"
import StarRaiting from "../../../common/star-raiting"
import { Button } from "react-bootstrap"
import MoadalStatisticWidow from "../modal-statistic-window"

const InfoRow = (props) => {

    const [modalShow, setModalShow] = useState(false);

    const { info } = props

    const nameStyle = {
        fontFamily: "Poppins,Helvetica Neue,Helvetica,Arial,sans-serif",
        fontSize: "25pt",
        fontWeight: "900",
        wordWrap: "break-word!important",
        wordBreak: "break-word!important",
        overflowWrap: "break-word!important",
        color: "#2b273c",
        fontWize: "48px",
        lineHeight: "54px",
    }

    const raitingInfoStyle = {
        fontSize: "25pt",
        display: "grid",
        gridTemplateColumns: "3fr 1fr 3fr"
    }

    const starsStyle = {
        marginLeft: "-6px",
        alignItems: "center"
    }

    const reviewsColumn = {
        fontSize: "11pt",
        alignItems: "center"
    }

    const reviewsValueStyle =
    {
        marginTop: "19px",
        marginLeft: "-40px"
    }

    const statisticButtonStyle = {
        height: "50%",
        width: "50%",
        marginLeft: "-30px"
    }

    return (
        <div className="infoRow">
            <div className="firstRowCenter">
                <div style={nameStyle}>{info[0].name}</div>
                <div style={raitingInfoStyle}>
                    <div style={starsStyle}>
                        <StarRaiting rate={info[0].rate} />
                    </div>
                    <div style={reviewsColumn}>
                        <div style={reviewsValueStyle}>
                            28 reviews
            </div>
                    </div>
                    <div style={statisticButtonStyle}>
                        <Button variant="dark" onClick={() => setModalShow(true)}>Details</Button>
                        <MoadalStatisticWidow
                            show={modalShow}
                            onHide={() => setModalShow(false)}
                        />
                    </div>
                </div>
            </div>
            <div className="firstRowMap">
                map
        </div>
        </div>
    )

}
export default InfoRow