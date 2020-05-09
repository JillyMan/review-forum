let row1 = {
  id: 1,
  categoryId: 1,
  name: "KfC",
  rate: 2.2,
  Address: {
    City: {
      name: "grodno",
      Country: {
        name: "Belarus"
      }
    },
    Street: {
      name: "soviet street",
    },
  },
  imgUrl: "https://s3-media0.fl.yelpcdn.com/bphoto/RQoplqo1XVrhhjDl3Uoo1w/l.jpg",
  phoneNumber: "+32211445568"

}

let row2 = {
  id: 2,
  categoryId: 2,
  name: "BURGER KING",
  rate: 3,
  Address: {
    City: {
      name: "grodno",
      Country: {
        name: "Belarus"
      }
    },
    Street: {
      name: "lenina",
    },
  },
  imgUrl: "https://s3-media0.fl.yelpcdn.com/bphoto/Shl8otIcJh3e2vffUq9g3g/300s.jpg",
  phoneNumber: "+32211445568"
}

let row3 = {
  id: 3,
  categoryId: 2,
  name: "MAC",
  rate: 2,
  Address: {
    City: {
      name: "grodno",
      Country: {
        name: "Belarus"
      }
    },

    Street: {
      name: "White rosy",
    },
  },
  imgUrl: "https://s3-media0.fl.yelpcdn.com/bphoto/XsXYGlTQL6rRBaLgDAA27A/300s.jpg",
  phoneNumber: "+32211445568"
}

let row5 = {
  id: 4,
  categoryId: 2,
  name: "Evroopt",
  rate: 3,
  Address: {
    City: {
      name: "grodno",
      Country: {
        name: "Belarus"
      }
    },

    Street: {
      name: "lenina",
    },
  },
  imgUrl: "https://s3-media0.fl.yelpcdn.com/bphoto/Shl8otIcJh3e2vffUq9g3g/300s.jpg",
  phoneNumber: "+32211445568"
}

let row4 = {
  id: 5,
  name: "KFC",
  rate: 5,
  imgUrl: "https://s3-media0.fl.yelpcdn.com/bphoto/Shl8otIcJh3e2vffUq9g3g/300s.jpg",
  phoneNumber: "37533888552",
  categoryId: 3,
  category: null,
  addressId: 2,
  Address: {
    id: 2,
    cityId: 1, 
    City: {
      name: "grodno",
      Country: {
        name: "Belarus"
      }
    },

    Street: {
      name: "lenina",
    },
    latitude: 1.0,
    longitude: 2.0
  },
  headerImages: [
    {
      id: 1002,
      imageUrl: "https://s3-media0.fl.yelpcdn.com/bphoto/Shl8otIcJh3e2vffUq9g3g/300s.jpg",
      placeId: 2
    },
    {
      id: 1003,
      imageUrl: "https://s3-media0.fl.yelpcdn.com/bphoto/Shl8otIcJh3e2vffUq9g3g/300s.jpg",
      placeId: 2
    }
  ],
  dishes: [
    {
      id: 1002,
      placeId: 2,
      name: "Draniki",
      imageUrl: "https://s3-media0.fl.yelpcdn.com/bphoto/Shl8otIcJh3e2vffUq9g3g/300s.jpg",
      rate: 0.0,
      cost: 545,
      rates: null
    },
    {
      id: 1003,
      placeId: 2,
      name: "Eggs",
      imageUrl: "https://s3-media0.fl.yelpcdn.com/bphoto/Shl8otIcJh3e2vffUq9g3g/300s.jpg",
      rate: 0.0,
      cost: 89,
      rates: null
    },
    {
      id: 1003,
      placeId: 2,
      name: "Eggs",
      imageUrl: "https://s3-media0.fl.yelpcdn.com/bphoto/Shl8otIcJh3e2vffUq9g3g/300s.jpg",
      rate: 0.0,
      cost: 89,
      rates: null
    },
    {
      id: 1003,
      placeId: 2,
      name: "Eggs",
      imageUrl: "https://s3-media0.fl.yelpcdn.com/bphoto/Shl8otIcJh3e2vffUq9g3g/300s.jpg",
      rate: 0.0,
      cost: 89,
      rates: null
    },
    {
      id: 1003,
      placeId: 2,
      name: "Eggs",
      imageUrl: "https://s3-media0.fl.yelpcdn.com/bphoto/Shl8otIcJh3e2vffUq9g3g/300s.jpg",
      rate: 0.0,
      cost: 89,
      rates: null
    },
    {
      id: 1003,
      placeId: 2,
      name: "Eggs",
      imageUrl: "https://s3-media0.fl.yelpcdn.com/bphoto/Shl8otIcJh3e2vffUq9g3g/300s.jpg",
      rate: 0.0,
      cost: 89,
      rates: null
    },
    {
      id: 1003,
      placeId: 2,
      name: "Eggs",
      imageUrl: "https://s3-media0.fl.yelpcdn.com/bphoto/Shl8otIcJh3e2vffUq9g3g/300s.jpg",
      rate: 0.0,
      cost: 89,
      rates: null
    }
  ],
  comments: null,
  createdAt: "2020-05-07T07:10:13.8724714Z",
  updatedAt: null

}

export const getPlaceByCategory = (categoryId) => {
  return [row1, row2, row3, row4, row5].filter((place) => place.categoryId == categoryId)
}

export const getPlaceByName = (name) => {
  return [row1, row2, row3, row4, row5].filter((place) => place.name.toLowerCase().indexOf(name.toLowerCase()) > -1)
}

export const getPlaceById = (id) => {
  return [row1, row2, row3, row4, row5].filter((place) => place.id == id)
}