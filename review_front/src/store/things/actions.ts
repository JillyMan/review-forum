import { ThingConfig } from "../types"

export const STORE_THINGS = 'STORE_THINGS'

export interface ThingsConfig {
    configs: ThingConfig[]
}

export const storeThings = (things: ThingsConfig) => ({
    type: STORE_THINGS,
    payload: things
})