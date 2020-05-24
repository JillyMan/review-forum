import React, { useState } from "react"
import StarRaiting from "../../../common/star-raiting"
import { Button } from "react-bootstrap"
import MoadalStatisticWidow from "../modal-statistic-window"
import MapComponent from "../../../common/map-component"
import { getRateByMonthsByPlace } from '../../../../api/places/place-service'

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

const InfoRow = (props) => {

    const [modalShow, setModalShow] = useState(false);

    const { place } = props

    const onRateChange = (value) =>{
        
    }

    return (
        <div className="infoRow">
            <div className="firstRowCenter">
                <div style={nameStyle}>{place.name}</div>
                <div style={raitingInfoStyle}>
                    <div style={starsStyle}>
                        <StarRaiting rate={place.rate} onRateChange={onRateChange}/>
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
                            data={getRateByMonthsByPlace(place.id)}
                        />
                    </div>
                </div>
            </div>
            <div className="firstRowMap">
                <MapComponent coordinates={place.Address} />
            </div>
        </div>
    )

}
export default InfoRow