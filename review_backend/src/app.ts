import * as express from 'express'
import { Application } from 'express-serve-static-core'

export interface Props {
    ip: string,
    port: string,
    controllers: any
}

export const App = ({
    ip, port
}: Props) => {

    const expressApp: Application = express()

    expressApp.listen(port, () => {
        console.log("Server start work, on port", port)
    })

}
 