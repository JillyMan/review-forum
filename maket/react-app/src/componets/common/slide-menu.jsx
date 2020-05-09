import React from "react"
import { Carousel } from "react-bootstrap"


const imgStyle = {
    width: "334px"
}

const imgContainerStyle = {
    width: "100%",
    height: "auto"
}

const SlideMenu = (props) => {

    const getItems = (images) => {
        let itemsArray = [];
        let imgCountainer = [];
        for (let i = 0; i < images.length; i++) {
            imgCountainer.push(
                <img
                    key={i}
                    style={imgStyle}
                    src={images[i]}
                    alt="..."
                />, ' '
            )
            if (imgCountainer.length === 10 || i === images.length - 1) {
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
            {getItems(props.images)}
        </Carousel>
    )

}

export default SlideMenu