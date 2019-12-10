import React from 'react'
import Redux from 'redux'
import { connect } from 'react-redux'
import { ThingCardDetail } from './thing-detail'
import { Allert } from '../../../components/presentational/allerts/allert'
import { AppState } from 'store/types'

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
    onThingSelect: (id: number) => void
}

type Props = StateProps & DispatchProps

const ThingsContainer = ({ things, onThingSelect }: Props) => {

    const Details = things && things.length > 0 ? things.map((item, index) => {
        return (
            <div className='col-4 mb-4'>
                <ThingCardDetail
                    key={index}
                    id={item.id}
                    img={item.img}
                    rate={item.rate}
                    name={item.name}/>
            </div>
        )
    }) : <Allert type='info' text='Noting to show!' isHidden={false}/>

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

export default connect<StateProps>(mapStateToProps)(ThingsContainer)