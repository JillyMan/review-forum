import React from "react"
import { YMaps, Map, Placemark } from 'react-yandex-maps';

const styles = {
    height: "100%",
    width: "100%"
}

const zoom = 15;

const MapComponent = (props) => {

    const { coordinates } = props


    return (
        <YMaps>
            <div style={styles}>
                <Map defaultState={{ center: [coordinates.longitude, coordinates.latitude], zoom: zoom }} width={styles.width} height={styles.height} >
                    <Placemark geometry={[coordinates.longitude, coordinates.latitude]} />
                </Map>
            </div>
        </YMaps>
    )
}

export default MapComponent