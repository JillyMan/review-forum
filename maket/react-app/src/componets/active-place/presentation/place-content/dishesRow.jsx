import React from "react"
import DishesSlideMenu from "../dishes-slide-menu"

const DishesRow = (props) => {

    return (
        <div className="dishesRow">
            <div className="dishesRowMenu">
                <DishesSlideMenu info={props.dishes} />
            </div>
        </div>

    )
}
export default DishesRow