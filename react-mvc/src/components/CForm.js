import React, { Component, useState } from 'react';
import axios from 'axios';
import { Container, Col, Form, Row, FormGroup, Label, Input, Button } from 'reactstrap';


export function CreateForm() {
   /* 
    this.state = { 
        Name:'',  
        Phone:'',
        myCar:'Volvo'  
       //CityId:''  
        }  
        */
    //const [inputs, setInputs] = useState({});
    const [myCar, setMyCar] = useState("Volvo");

    const handleChange= (e)=> {  
        this.setState({[e.target.name]:e.target.value}); 
      
        } 
  /*
  handleChange = (event) => {
    this.setState  = event.target.name;
    this.setState = event.target.value;
    setInputs(values => ({...values, [name]: value}))
  }
*/

  //handleSubmit(async (data) => await fetchAPI(data))
          /*handleSubmit = (onClick) => {
            event.preventDefault();
            console.log(this.CreatePerson);
          }*/
  /*
          handleChange = event => {
            this.setState({ name: event.target.value });
          }
  */
            
          return (  
            <form onSubmit={this.CreatePerson}>
        <label>Enter your name:
        <input 
          type="text" 
          name="Name" 
          value={this.state.Name || ""} 
          onChange={this.handleChange}
        />
        </label>
        <label>Enter your phonenumber:
          <input 
            type="number" 
            name="Phone" 
            value={this.state.Phone || ""} 
            onChange={this.handleChange}
          />
          </label>
          <label>Enter your city:
          <select value={myCar} onChange={this.handleChange}>
        <option value="Ford">Ford</option>
        <option value="Volvo">Volvo</option>
        <option value="Fiat">Fiat</option>
      </select>
          </label>
          <input type="submit" />
      </form>
      );  
     
   }
   //export default {CreateForm};