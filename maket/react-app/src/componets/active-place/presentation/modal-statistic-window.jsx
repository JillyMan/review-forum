import React from "react"
import { Button, Modal } from "react-bootstrap";
import Chart from "react-google-charts";

const ModalStatisticWindow = (props) => {

    const data = props.data.map((rate, month_id) => (
        [month_id, rate]
    )) 

    return (
        <Modal
            {...props}
            size="lg"
            aria-labelledby="contained-modal-title-vcenter"
            centered
        >
            <Modal.Header closeButton>
                <Modal.Title id="contained-modal-title-vcenter">
                    Rate by months
          </Modal.Title>
            </Modal.Header>
            <Modal.Body>
                <Chart
                    width={'600px'}
                    height={'400px'}
                    chartType="LineChart"
                    loader={<div>Loading Chart</div>}
                    data={[
                        ['x', 'rate'],
                        ...data
                    ]}
                    options={{
                        hAxis: {
                            title: 'Month',
                        },
                        vAxis: {
                            title: 'Rating',
                        },
                    }}
                    rootProps={{ 'data-testid': '1' }}
                />
            </Modal.Body>
            <Modal.Footer>
                <Button onClick={props.onHide}>Close</Button>
            </Modal.Footer>
        </Modal>
    );
}

export default ModalStatisticWindow
