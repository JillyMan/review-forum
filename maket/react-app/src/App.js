import React from 'react';
import Navbar from './componets/common/navbar';
import { BrowserRouter as Router } from "react-router-dom";
import "bootstrap/dist/css/bootstrap.css"
import Route from "./componets/route/route"
function App() {
  return (
    <Router>
      <Navbar />
      <Route/>
    </Router>
  );
}

export default App;
