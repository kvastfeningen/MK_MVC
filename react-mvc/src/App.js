import React, { Component } from 'react';
import ReactDOM from 'react-dom';
import axios from 'axios'; 
import './App.css';  
import { Container, Col, Form, Row, FormGroup, Label, Input, Button } from 'reactstrap';  

import { BrowserRouter as Router, Switch, Route, Link, Routes } from 'react-router-dom'; 
//import {  BrowserRouter as Router,  Routes,  Route, Link} from "react-router-dom";
//import {Router, Link, Route, Switch} from 'react-router-dom';
//import {BrowserRouter as Router, Link, Switch} from "react-router-dom"
//import { Route, Routes} from "react-router";
/*
import {
  BrowserRouter,
  Routes,
  Route, 
  Link
} from "react-router-dom";
*/
import PList from './components/PList';

import PeopleList from './components/PeopleList';
import PDetails from './components/PDetails';
import CreatePerson from './components/CreatePerson';      

function App() {
  
    return (
      
<Router>

<div className="container"> 
<nav className="navbar navbar-expand-lg navheader">  
          <div className="collapse navbar-collapse" >  
            <ul className="navbar-nav mr-auto">  
              <li className="nav-item">  
                <Link to={'/PList'} className="nav-link">PList</Link>  
              </li>  
              
              <li className="nav-item">  
                <Link to={'/CreatePerson'} className="nav-link">CreatePerson</Link>  
              </li> 
            </ul>  
          </div>  
        </nav> <br /> 
      <Switch>
      <Route exact path='/PList' component={PList} />
      
      
      <Route path='/CreatePerson' component={CreatePerson} />
     </Switch>

      </div> 
   </Router>

    );
  
}
export default App;

/*

<Route exact path='/CreatePerson' component={CreatePerson} />  
              
              <Route path='/details/:id' component={Details} />  
              <Route path='/PeopleList' component={PeopleList} />  

<div className="container">  
            <nav className="navbar navbar-expand-lg navheader">  
              <div className="collapse navbar-collapse" >  
                <ul className="navbar-nav mr-auto">  
                  <li className="nav-item">  
                    <Link to={'/CreatePerson'} className="nav-link">New Person</Link>  
                  </li>  
                  <li className="nav-item">  
                    <Link to={'/PList'} className="nav-link">People</Link>  
                  </li>  
                </ul>  
              </div>  
            </nav> <br />  

            </div>


            funkar
            bara //<PList /> i return (utan router)
            eller tex //<Details />
            

class App extends Component {
  render() {
    return (
<Router>
      <Switch>
      <Route path='/PList' component={PList} /> 
      
      
      </Switch>
      </Router>

    );
  }
}
export default App;


              */