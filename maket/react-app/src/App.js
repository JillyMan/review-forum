import React from 'react';
import Navbar from './componets/common/navbar';
import { BrowserRouter as Router } from "react-router-dom";
import "bootstrap/dist/css/bootstrap.css"
import RouteContainer from "./componets/route/route"
import CommentContainer from "../src/componets/active-place/presentation/comment/comment-container"

function App() {
  return (
    <Router>
      <Navbar />
      <CommentContainer/>
      <RouteContainer />
    </Router>
  );
}

export default App;
