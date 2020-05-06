import React from "react"
import { Link } from "react-router-dom"
import DropDownToLink from "./drop-down-to-link"
import { Navbar, Button } from "react-bootstrap"
import { urlGetCategoryByIdPagePattern } from '../route/route-patterns'

const categories = [
  { id: 1, name: "Eatery" },
  { id: 2, name: "Cafe" },
]

const mainLinkName = "RF"

const signIn = {
  marginLeft: "auto",
  marginRight: "10px"
}

const signInBtnName = "Sign In"
const registrationBtnName = "Registration"

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
      <Button variant="light" style={ signIn }>{signInBtnName}</Button>
      <Button variant="light">{registrationBtnName}</Button>
    </Navbar>
  )
}

export default NavigationContainer