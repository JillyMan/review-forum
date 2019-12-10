import { ThingConfig } from "../types"
import { 
    ADD_COMMENT, 
    STORE_THING,
    CLEAR_THING
} from "./actions"

const defaultState: ThingConfig = {
    id: 1111,
    urlImage: 'https://cater.by/wp-content/uploads/2017/06/Makdonalds-kopiya.jpg',
    rate: 4,
    description: 'Макдо́налдс — американская корпорация, работающая в сфере общественного питания, до 2010 года крупнейшая в мире сеть ресторанов быстрого питания, работающая по системе франчайзинга. На конец 2018 года под торговой маркой McDonald’s работало 37 855 ресторанов, из них 35 085 на правах франчайзинга. Корпорация входит в список крупнейших компаний США Fortune 500 (в 2019 году 149-е место). Штаб-квартира компании расположена в пригороде Чикаго Оук-Бруке.',
    comments: [{
        userName: 'Sean',
        text: 'This is amazing place'
    },{
        userName: 'Bob',
        text: 'I love it'
    }]
}

export const activeThingReducer = (state: ThingConfig = defaultState, action: any): ThingConfig => {
    switch (action.type) {
        case ADD_COMMENT:
            return {
                ...state,
                comments: [action.payload, ...state.comments]
            }
        case STORE_THING:
            return {
                ...action.payload
            }
        case CLEAR_THING:
            return {
                ...defaultState
            }
    }

    return state
}