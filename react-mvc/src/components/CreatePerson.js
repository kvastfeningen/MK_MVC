import React, { Component, useState } from 'react';
import axios from 'axios';
import { Container, Col, Form, Row, FormGroup, Label, Input, Button } from 'reactstrap';
import Select from 'react-select';
import DDList from './DDList'
//import {CreateForm} from './CForm';




class CreatePerson extends React.Component{  
    constructor(props){  
    super(props)  

    this.state = { 
    
    Name:'',  
    Phone:'', 
    CityId:''  
    }  
    }

    CreatePerson=()=>{ 
      console.log(this.state); 
        axios.post("https://localhost:44308/api/react/create", this.state)// '=' + JSON.stringify({ Name: 'this.state.Name',Phone:"this.state.Phone",CityId:"this.state.CityId"  })
             .then(res => {
        console.log(res);
        console.log(res.datatoString);
      });

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
            <Input type="text" name="CityId" onChange={this.handleChange} value={this.state.CityId} placeholder="Enter City" />
            </Col>  
        </FormGroup>

  
<FormGroup Row>  
<Label for="Password" sm={2}>City</Label>  
<Col sm={10}>  

<DDList />
 
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

 

 
 
 /*
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
*/
/*
export const CustomDropdown = (props) => (
  <div className="form-group">
    <strong>{props.CityId}</strong>
    <select
      className="form-control"
      name="{props.CityId}"
      onChange={props.onChange}
    >
      <option defaultValue>Select {props.name}</option>
      {props.options.map((item, index) => (
        <option key={index} value={item.id}>
          {item.CityId}
        </option>
      ))}
    </select>
  </div>
)
*/

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

  /*
  /*
    constructor() {
      super()
      this.state = {
        collection: [],
        value: '',
      }
    }
*/
/*
    componentDidMount() {
      fetch('https://localhost:44308/api/cities')
        .then((response) => response.json())
        .then((res) => this.setState({ collection: res }))
    }
*/
