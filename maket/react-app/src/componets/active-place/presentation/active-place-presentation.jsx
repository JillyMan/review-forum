import React from "react"
import "../style/active-page-style.css"
import SlideMenu from "../../common/slide-menu";
import InfoRow from "./place-content/info-row";
import DishesRow from "./place-content/dishesRow";
import CommentsRow from "./place-content/comments-row";
import AddressColumn from "./place-content/address-column";

const ActivePlacePresentation = (props) => {

    const { place } = props

    return (
        <>
            <SlideMenu images={place.headerImages} />
            <div className="activePageStyle">
                <div>
                    <InfoRow place={place} />
                    <DishesRow dishes={place.dishes} />
                    <CommentsRow />
                </div>
                <div>
                    <AddressColumn address={place} />
                </div>
            </div>

        </>);
}
export default ActivePlacePresentation