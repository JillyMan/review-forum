const country1 = {
    id: 1,
    name: "Belarus",
    cities: [
        {
            id: 1,
            name: "Hrodna",
        },
        {
            id: 2,
            name: "Brest"
        },
        {
            id: 3,
            name: "Minsk"
        }
    ]
}

const country2 = {
    id: 2,
    name: "USA",
    cities: [
        {
            id: 1,
            name: "New-York",
        },
        {
            id: 2,
            name: "Oklahoma"
        },
        {
            id: 3,
            name: "Kentucky"
        }
    ]
}

const country3 = {
    id: 3,
    name: "Poland",
    cities: [
        {
            id: 1,
            name: "Krakow",
        },
        {
            id: 2,
            name: "Bylastok"
        },
        {
            id: 3,
            name: "Warshaw"
        }
    ]
}

export const getAll = () => {
    return [country1, country2, country3]
}