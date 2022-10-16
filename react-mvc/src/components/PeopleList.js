import React, { Component } from 'react';  
import { Container, Col, Form, Row, FormGroup, Label, Input, Button } from 'reactstrap';  
import axios from 'axios' 
//import './App.css'; 
import { BrowserRouter as Router, Switch, Route, Link } from 'react-router-dom'; 


export default class PeopleList extends Component {

    constructor(props) {
        super(props);
        this.state = {
          people: [],
          
        };
      }

      componentDidMount() {
        fetch("https://localhost:44308/api/people")
        
        .then(res => res.json())
        .then(
        (result) => {
            this.setState({
              people:result
            });
        },
        (error) => {
            alert(error);
        }
        )
    }
/*
    tabRow(){  
        return this.state.people.map(function(object, i){  
            return <Table obj={object} key={i} />;  
        });  
      }  
*/
      render() { 
        return (
         
            <div>
               
              <h2>People</h2>
              <table>
                <thead>
                  <tr>
                  <th>   </th>
                    <th>Name</th>
                    <th>PersonId</th>
                    
                  </tr>
                </thead>
                <tbody> 

                {this.state.people.map(p => (
            <tr key={p.personId}>
              <td></td>
              <td>{p.name}</td>
              <td>{p.personId}</td>
              <td>  
          <Link to={"/Details/"+this.props.obj.Id} className="btn btn-success">Details</Link>  
          </td>
              </tr>
                ))}        
                </tbody>
                
              </table>
            </div>
            );
    }  

}
//export default PeopleList; 