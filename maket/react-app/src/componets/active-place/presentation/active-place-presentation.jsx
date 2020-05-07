import React, { useState } from "react"
import "../style/active-page-style.css"
import SlideMenu from "../../common/slide-menu";
import StarRaiting from "../../common/star-raiting";
import { Button } from "react-bootstrap";
import MoadalStatisticWidow from "./modal-statistic-window"
import DishesSlideMenu from "./dishes-slide-menu";
import CommentContainer from "./comment/comment-container"

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

const ActivePlacePresentation = (props) => {

    let arr = []

    const { place } = props

    console.log(place)
    const [modalShow, setModalShow] = useState(false);

    for (let i = 0; i < 14; i++) {
        arr.push("https://s3-media0.fl.yelpcdn.com/bphoto/BWpaBuHh5hukxpofW9eEgQ/l.jpg")
    }
    return (
        <>
            <SlideMenu images={arr} />
            <div className="activePageStyle">
                <div className="infoRow">
                    <div className="firstRowCenter">
                        <div style={nameStyle}>{place.name}</div>
                        <div style={raitingInfoStyle}>
                            <div style={starsStyle}>
                                <StarRaiting rate={place.rate} />
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
                <div className="dishesRow">
                    <div className="dishesRowMenu">
                        <DishesSlideMenu info={place[0].dishes} />
                    </div>
                </div>
                <div className="commentsRow" style={{marginTop: 50}}>
                    <CommentContainer/>
                </div>
            </div>
        </>);
}
export default ActivePlacePresentation