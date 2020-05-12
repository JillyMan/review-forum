let row1 = {
  id: 2,
  categoryId: 1,
  name: "KFC",
  image: {
    imageUrl: "data:image/png;base64,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"
  },
  phoneNumber: "37533888552",
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
    { image: { imageUrl: "https://vk.com" } },
    { image: { imageUrl: "https://vk.com" } }
  ],
  dishes: [
    { name: "Draniki", image: { imageUrl: "https://vk.com" }, price: 123 },
    { name: "Kebab", image: { imageUrl: "https://vk.com" }, price: 123 }
  ]
}

let row2 = {
  id: 2,
  categoryId: 3,
  name: "McDonald’s",
  image: {
    imageUrl: "data:image/jpeg;base64,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"
  },
  phoneNumber: "37533888552",
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
    { image: { imageUrl: "https://vk.com" } },
    { image: { imageUrl: "https://vk.com" } }
  ],
  dishes: [
    { name: "Draniki", image: { imageUrl: "https://vk.com" }, price: 123 },
    { name: "Kebab", image: { imageUrl: "https://vk.com" }, price: 123 }
  ]
}

let row3 = {
  id: 3,
  categoryId: 2,
  name: "Greenwich",
  image: {
    imageUrl: "https://s3-media0.fl.yelpcdn.com/bphoto/WsgUMMqxDlbPhU6aTurYjA/300s.jpg"
  },
  phoneNumber: "37533888552",
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
    { image: { imageUrl: "https://vk.com" } },
    { image: { imageUrl: "https://vk.com" } }
  ],
  dishes: [
    { name: "Draniki", image: { imageUrl: "https://vk.com" }, price: 123 },
    { name: "Kebab", image: { imageUrl: "https://vk.com" }, price: 123 }
  ]
}

let row5 = {
  id: 5,
  categoryId: 1,
  name: "KFC",
  image: {
    imageUrl: "https://s3-media0.fl.yelpcdn.com/bphoto/WsgUMMqxDlbPhU6aTurYjA/300s.jpg"
  },
  phoneNumber: "37533888552",
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
    { image: { imageUrl: "https://vk.com" } },
    { image: { imageUrl: "https://vk.com" } }
  ],
  dishes: [
    { name: "Draniki", image: { imageUrl: "https://vk.com" }, price: 123 },
    { name: "Kebab", image: { imageUrl: "https://vk.com" }, price: 123 }
  ]
}

let row4 = {
  id: 4,
  categoryId: 2,
  name: "KFC",
  image: {
    imageUrl: "https://s3-media0.fl.yelpcdn.com/bphoto/lzHGEUlhlRCxWJD7LacVEg/300s.jpg"
  },
  phoneNumber: "37533888552",
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
    { image: { imageUrl: "https://vk.com" } },
    { image: { imageUrl: "https://vk.com" } }
  ],
  dishes: [
    { name: "Draniki", image: { imageUrl: "https://vk.com" }, price: 123 },
    { name: "Kebab", image: { imageUrl: "https://vk.com" }, price: 123 }
  ],
  comments: null,
  createdAt: "2020-05-07T07:10:13.8724714Z",
  updatedAt: null

}

const row6 = {
  id: 6,
  categoryId: 1,
  name: "KFC",
  image: {
    imageUrl: "https://s3-media0.fl.yelpcdn.com/bphoto/F1zTm977oWGyfC9UcP8iKQ/300s.jpg"
  },
  phoneNumber: "37533888552",
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
    { image: { imageUrl: "https://vk.com" } },
    { image: { imageUrl: "https://vk.com" } }
  ],
  dishes: [
    { name: "Draniki", image: { imageUrl: "https://vk.com" }, price: 123 },
    { name: "Kebab", image: { imageUrl: "https://vk.com" }, price: 123 }
  ]
}

export const getPlaceByCategory = (categoryId) => {
  return [row1, row2, row3, row4, row5, row6].filter((place) => place.categoryId == categoryId)
}

export const getPlaceByName = (name) => {
  return [row1, row2, row3, row4, row5, row6].filter((place) => place.name.toLowerCase().indexOf(name.toLowerCase()) > -1)
}

export const getPlaceById = (id) => {
  return [row1, row2, row3, row4, row5, row6].filter((place) => place.id == id)
}