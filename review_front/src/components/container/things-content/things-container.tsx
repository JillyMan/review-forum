import React, { useEffect } from 'react'
import Redux from 'redux'
import { connect } from 'react-redux'
import { AppState } from '../../../store/types'
import { ThingCardDetail } from './thing-detail'
import { Allert } from '../../../components/presentational/allerts/allert'
import { 
    ActiveThingAction, 
    ActiveThingConfig, 
    storeActiveThing 
} from '../../../store/active-thing/actions'
import { getThing, getThings } from '../../../api/things'
import { 
    ThingsConfig, 
    ThingsActions, 
    storeThings, 
    ThingConfig 
} from '../../../store/things/actions'

interface ThingInfo { 
    id: number,
    img: string,
    rate: number,
    name: string,
}

type StateProps = { 
    things: ThingInfo[]
}

type DispatchProps = {
    storeThings: (things: ThingsConfig) => void
    onThingSelect: (thingConfig: ActiveThingConfig) => void
}

type Props = StateProps & DispatchProps

const ThingsContainer = ({ 
    things, 
    storeThings,
    onThingSelect }: Props) => {
    
    useEffect(() => {
        if(!things.length) {
            const responce = getThings()
            if (responce) {
                const stored: ThingsConfig = {
                    configs: responce.map((item): ThingConfig  => ({
                        id: item.id,
                        name: item.name,
                        rate: item.rate,
                        urlImage: item.urlImage
                    }))
                } 

                storeThings(stored)
            }
        }
    }, [])

    const onCardClick = (id: number) => {
        const thing = getThing(id)

        if (thing) {
            onThingSelect({
                id: thing.id,
                rate: thing.rate,
                description: thing.description,
                urlImage: thing.urlImage,
                comments: thing.comments
            })
            // navigate to active things.
        } 
    }

    const Details = things && things.length > 0 ? things.map((item, index) => {
        return (
            <div key={index} 
                className='col-4 mb-4' 
                onClick={() => onCardClick(item.id)}>
                <ThingCardDetail
                    id={item.id}
                    img={item.img}
                    rate={item.rate}
                    name={item.name}/>
            </div>
        )
    }) : (
    <div className='col'>
        <Allert type='info' text='Noting to show!' isHidden={false}/>
    </div> 
    )
    return (
        <div className='container'>
            <div className='row'>
                {Details}
            </div>
        </div>
    )
}

const mapStateToProps = (state: AppState): StateProps => ({
    things: state.things.configs.map((item) => {
        return {
            id: item.id,
            img: item.urlImage,
            rate: item.rate,
            name: item.name            
        }
    })
})

type DispatchType = ActiveThingAction | ThingsActions;

const mapDispatchToProps = (dispatch: Redux.Dispatch<DispatchType>): DispatchProps => ({
    storeThings: (things: ThingsConfig) => dispatch(storeThings(things)),
    onThingSelect: (config: ActiveThingConfig) => dispatch(storeActiveThing(config))
})

export default connect<StateProps, DispatchProps>(mapStateToProps, mapDispatchToProps)(ThingsContainer)