import React from "react"
import { Link } from "react-router-dom"
import DropDownToLink from "./drop-down-to-link"
import { Navbar } from "react-bootstrap"
import { urlGetCategoryByIdPagePattern } from '../route/route-patterns'
import NavbarUserButotns from "./navbar-user-buttons"

const categories = [
  { id: 1, name: "Eatery" },
  { id: 2, name: "Cafe" },
]

const mainLinkName = "RF"

const NavigationContainer = () => {

  const things = categories.map((value, id) => {
    return {
      to: urlGetCategoryByIdPagePattern.getData(value.id),
      name: value.name
    }
  })

  return (
    <Navbar bg="dark" variant="dark">
      <Navbar.Brand as={Link} to="/">
        {mainLinkName}
      </Navbar.Brand>
      <DropDownToLink listOfLinks={things} />
      <NavbarUserButotns autorize={false} />
    </Navbar>
  )
}

export default NavigationContainer