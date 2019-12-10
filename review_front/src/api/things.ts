const STORAGE_KEY = "THINGS"

export interface CommentInfo {
    userId: number,
    userName: string,
    text: string 
}

export interface Thing {
    id: number,
    urlImage: string,
    rate: number,
    description: string,
    comments: CommentInfo[]
}

export const getThings = (): Thing[] => {
    return JSON.parse(localStorage.getItem('STORAGE_KEY') || '[]') as Thing[]
}

export const getThing = (id: number): Thing => {
    return getThings().find(x => x.id === id)
}

export const updateThing = (thing: Thing) => {
    const things = getThings()
    const index = things.findIndex(x => x.id === thing.id)
    things[index] = thing
    localStorage.setItem(STORAGE_KEY, JSON.stringify(things))
}
