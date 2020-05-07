import React from "react"
import DelishesCard from "../../common/delishes-card";
import { Carousel } from "react-bootstrap";

const imgContainerStyle = {
    width: "100%",
    height: "100%",
    marginLeft : "0%"
}


const DishesSlideMenu = (props) => {

    const getItems = (info) => {
        let itemsArray = [];
        let imgCountainer = [];
        for (let i = 0; i < info.length; i++) {
            imgCountainer.push(
                <DelishesCard key={i} info={info[i]} />
            )
            if (imgCountainer.length === 3 || i === info.length - 1) {
                itemsArray.push(
                    <Carousel.Item key={i}>
                        <div style={imgContainerStyle}>
                            {imgCountainer.slice()}
                        </div>
                    </Carousel.Item>
                )
                imgCountainer.splice(0, imgCountainer.length);
            }
        }
        return itemsArray;
    }

    return (
        <Carousel>
            {getItems(props.info)}
        </Carousel>
    )
}

export default DishesSlideMenu