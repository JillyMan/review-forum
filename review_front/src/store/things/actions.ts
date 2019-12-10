export const STORE_THINGS = 'STORE_THINGS'

export interface ThingConfig {
    id: number,
    rate: number,
    name: string,
    urlImage: string,
}

export interface ThingsConfig {
    configs: ThingConfig[]
}

type StoreThingsAction = { 
    type: typeof STORE_THINGS,
    payload: ThingsConfig
}

export type ThingsActions = StoreThingsAction

export const storeThings = (things: ThingsConfig): StoreThingsAction => ({
    type: STORE_THINGS,
    payload: things
})