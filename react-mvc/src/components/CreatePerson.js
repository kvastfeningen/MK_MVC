import React, { Component, useState } from 'react';
import axios from 'axios';
import { Container, Col, Form, Row, FormGroup, Label, Input, Button } from 'reactstrap';
import Select from 'react-select';
//import {CreateForm} from './CForm';

//import './App.css';  

class CreatePerson extends React.Component{  
    constructor(props){  
    super(props)  
/*
    this.onChangeName = this.onChangeName.bind(this);  
    this.onChangePhone = this.onChangePhone.bind(this);  
    this.onChangeCity = this.onChangeCity.bind(this);  
    this.onSubmit = this.onSubmit.bind(this);  
*/
    this.state = { 
    Name:'',  
    Phone:'', 
    CityId:''  
    }  
    }
    CreatePerson=()=>{  
        axios.post("https://localhost:44308/api/people", '=' + JSON.stringify({ Name: 'this.state.Name',Phone:"this.state.Phone",CityId:"this.state.CityId"  })
        //({Name:this.state.Name,Phone:this.state.Phone,CityId:this.state.CityId}) 
        /*
         type= 'POST',
        contentType= 'application/json; charset=utf-8',
        data=JSON.stringify*/
     /* 
     .then(json => {  
      if(json.data.Status==='Success'){  
        console.log(json.data.Status);  
        alert("Data Save Successfully");  
      
        //this.props.history.push('/PList')  
      }  
      else{  
      alert('Data not Saved');  
      debugger;  
      //this.props.history.push('/PList')  
      }  
      })  */
      .then(res => {
        console.log(res);
        console.log(res.data);
      }))

      }  

      handleChange= (e)=> {  
        this.setState({[e.target.name]:e.target.value}); 
       // alert(`The name you entered was: ${Name}`) 
        } 

render() {
return (
<Container className="App">  
<h4 className="PageHeading">Enter New Person</h4>  
<Form className="form">  
  <Col>  
    <FormGroup Row>  
      <Label for="name" sm={2}>Name</Label>  
      <Col sm={10}>  
  <Input type="text" name="Name" onChange={this.handleChange} value={this.state.Name} placeholder="Enter Name" />
  </Col>  
</FormGroup>

<FormGroup Row>  
<Label for="Password" sm={2}>Phone</Label>  
<Col sm={10}>  
  <Input type="text" name="Phone" onChange={this.handleChange} value={this.state.Phone} placeholder="Enter Phone number" />
  </Col>  
</FormGroup>
<FormGroup Row>  
<Label for="Password" sm={2}>City</Label>  
<Col sm={10}>  
 
  
  <div className="drop-down" name="CityId">
                <Select
                value={this.state.CityId}
                onChange={this.handleChange}
                options={this.state.obj}
              />
              
              <br></br>
              <br></br>
              <br></br>
            </div>
  
  </Col>  
</FormGroup>

<Col>  
<FormGroup Row>  
<Col sm={5}>  
</Col>  
<Col sm={1}>  
<button type="button" onClick={this.CreatePerson} className="btn btn-success">Submit</button>  
</Col>  
<Col sm={1}>  
  <Button color="danger">Cancel</Button>{' '}  
</Col>  
<Col sm={5}>  
</Col>  
</FormGroup>
</Col>
</Col>
</Form>  
</Container> 
    
); 

}

}
 export default CreatePerson;


 // <Input type="text" name="CityId" onChange={this.handleChange} value={this.state.CityId} placeholder="Enter City" />
 /*
<Container className="App">  
          <h4 className="PageHeading">Enter New Person</h4>  
          <Form className="form">  
            <Col>  
              <FormGroup Row>  
                <Label for="name" sm={2}>Name</Label>  
                <Col sm={10}>  
            <Input type="text" name="Name" onChange={this.handleChange} value={this.state.Name} placeholder="Enter Name" />
            </Col>  
        </FormGroup>

        <FormGroup Row>  
          <Label for="Password" sm={2}>Phone</Label>  
          <Col sm={10}>  
            <Input type="text" name="Phone" onChange={this.handleChange} value={this.state.Phone} placeholder="Enter Phone number" />
            </Col>  
        </FormGroup>
        <FormGroup Row>  
          <Label for="Password" sm={2}>City</Label>  
          <Col sm={10}>  
            <Input type="text" name="CityId" onChange={this.handleChange} value={this.state.CityId} placeholder="Enter City" />
            </Col>  
        </FormGroup>
        <Col>  
        <FormGroup Row>  
          <Col sm={5}>  
          </Col>  
          <Col sm={1}>  
          <button type="button" onClick={this.CreatePerson} className="btn btn-success">Submit</button>  
          </Col>  
          <Col sm={1}>  
            <Button color="danger">Cancel</Button>{' '}  
          </Col>  
          <Col sm={5}>  
          </Col>  
        </FormGroup>
      </Col>
      </Col>
    </Form>  
  </Container>  
 */