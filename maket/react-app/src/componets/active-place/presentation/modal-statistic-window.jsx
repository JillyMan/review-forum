import React from "react"
import { Button, Modal } from "react-bootstrap";

const ModalStatisticWindow = (props) => {
    return (
        <Modal
            {...props}
            size="lg"
            aria-labelledby="contained-modal-title-vcenter"
            centered
        >
            <Modal.Header closeButton>
                <Modal.Title id="contained-modal-title-vcenter">
                    Statistic Window
          </Modal.Title>
            </Modal.Header>
            <Modal.Body>
                <h4>Statistic Content</h4>
                content
            </Modal.Body>
            <Modal.Footer>
                <Button onClick={props.onHide}>Close</Button>
            </Modal.Footer>
        </Modal>
    );
}

export default ModalStatisticWindow
