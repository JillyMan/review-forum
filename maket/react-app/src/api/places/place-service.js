let row1 = {
  id: 1,
  categoryId: 1,
  name: "KfC",
  rate: 2.2,
  Address: {
    City: { name: "grodno" },
    Country: { name: "Belarus" },
    Street: {
      name: "soviet street",
    },
  },
  imgUrl: "https://s3-media0.fl.yelpcdn.com/bphoto/RQoplqo1XVrhhjDl3Uoo1w/l.jpg",
  telNumber: "+32211445568"

}

let row2 = {
  id: 2,
  categoryId: 2,
  name: "BURGER KING",
  rate: 3,
  Address: {
    City: { name: "grodno" },
    Country: { name: "Belarus" },
    Street: {
      name: "lenina",
    },
  },
  imgUrl: "https://s3-media0.fl.yelpcdn.com/bphoto/Shl8otIcJh3e2vffUq9g3g/300s.jpg",
  telNumber: "+32211445568"
}

let row3 = {
  id: 3,
  categoryId: 2,
  name: "MAC",
  rate: 2,
  Address: {
    City: { name: "grodno" },
    Country: { name: "Belarus" },
    Street: {
      name: "White rosy",
    },
  },
  imgUrl: "https://s3-media0.fl.yelpcdn.com/bphoto/XsXYGlTQL6rRBaLgDAA27A/300s.jpg",
  telNumber: "+32211445568"
}

let row5 = {
  id: 2,
  categoryId: 2,
  name: "Evroopt",
  rate: 3,
  Address: {
    City: { name: "grodno" },
    Country: { name: "Belarus" },
    Street: {
      name: "lenina",
    },
  },
  imgUrl: "https://s3-media0.fl.yelpcdn.com/bphoto/Shl8otIcJh3e2vffUq9g3g/300s.jpg",
  telNumber: "+32211445568"
}

let row4 = {
  id: 3,
  categoryId: 2,
  name: "Almi",
  rate: 2,
  Address: {
    City: { name: "grodno" },
    Country: { name: "Belarus" },
    Street: {
      name: "White rosy",
    },
  },
  imgUrl: "https://s3-media0.fl.yelpcdn.com/bphoto/XsXYGlTQL6rRBaLgDAA27A/300s.jpg",
  telNumber: "+32211445568"
}

function getPlaceByCategory(categoryId) {
  return [row1, row2, row3, row4, row5].filter((place) => place.categoryId == categoryId)

}

export default getPlaceByCategory;