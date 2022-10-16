import React, { Component } from 'react';
import axios from 'axios';
import { Container, Col, Form, Row, FormGroup, Label, Input, Button } from 'reactstrap';
//import './App.css';  

class CreatePerson extends React.Component{  
    constructor(props){  
    super(props)  
    this.state = {  
    Name:'',  
    Phone:'',  
    City:''  
    }  
    }
    CreatePerson=()=>{  
        axios.post('https://localhost:44308/api/react/create', {Name:this.state.Name,Phone:this.state.Phone,  
        City:this.state.City})  
      .then(json => {  
      if(json.data.Status==='Success'){  
        console.log(json.data.Status);  
        alert("Data Save Successfully");  
      
        //this.props.history.push('/People')  
      }  
      else{  
      alert('Data not Saved');  
      debugger;  
      //this.props.history.push('/People')  
      }  
      })  
      }  

      handleChange= (e)=> {  
        this.setState({[e.target.name]:e.target.value});  
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
            <Input type="text" name="City" onChange={this.handleChange} value={this.state.City} placeholder="Enter City" />
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