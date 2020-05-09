import React from "react"
import "../style/active-page-style.css"
import SlideMenu from "../../common/slide-menu";
import InfoRow from "./place-content/info-row";
import DishesRow from "./place-content/dishesRow";
import CommentsRow from "./place-content/comments-row";
import AddressColumn from "./place-content/address-column";




const ActivePlacePresentation = (props) => {

    let arr = []

    const { place } = props

    for (let i = 0; i < 14; i++) {
        arr.push("https://s3-media0.fl.yelpcdn.com/bphoto/BWpaBuHh5hukxpofW9eEgQ/l.jpg")
    }
    return (
        <>
            <SlideMenu images={arr} />
            <div className="activePageStyle">
                <div>
                    <InfoRow info={place} />
                    <DishesRow dishes={place[0].dishes} />
                    <CommentsRow />
                </div>
                <div>
                    <AddressColumn address={place[0]} />
                </div>
            </div>

        </>);
}
export default ActivePlacePresentation