import React, { Component } from 'react';   
import { Container, Col, Form, Row, FormGroup, Label, Input, Button } from 'reactstrap';  
import axios from 'axios' 
import './App.css';  

class Details extends React.Component{  
    constructor(props){  
    super(props)  

    this.onChangeName = this.onChangeName.bind(this);  
    this.onChangePhone = this.onChangePhone.bind(this);  
    this.onChangeCity = this.onChangeCity.bind(this);  
    this.onChangeLanguage = this.onChangeLanguage.bind(this);  

    this.onSubmit = this.onSubmit.bind(this);  

    this.state = {  
    Name:'',  
    Phone:'',  
    City:'',
    Country:'',
    Language:''  
    }  
    }

    componentDidMount() {  
        axios.get('http://localhost:44308/Api/details?id='+this.props.match.params.id)  
            .then(response => {  
                this.setState({ 
                  //PersonId: response.data.PersonId,
                  Name: response.data.Name,   
                  Phone: response.data.Phone,  
                  City: response.data.City,
                  Phone: response.data.Country,
                  Phone: response.data.Language});  
    
            })  
            .catch(function (error) {  
                console.log(error);  
            })  
      } 

      onChangeName(e) {  
        this.setState({  
            Name: e.target.value  
        });  
      }  
      onChangePhone(e) {  
        this.setState({  
            Phone: e.target.value  
        });  
      }  
      onChangeCity(e) {  
        this.setState({  
            City: e.target.value  
        });  
      }  
      onChangeLanguage(e) {  
        this.setState({  
            Language: e.target.value  
        });  
      }  

      onSubmit(e) {  
        debugger;  
        e.preventDefault();  
        const obj = {  
            PersonId:this.props.match.params.id,  
          Name: this.state.Name,  
          Phone: this.state.Phone,  
          City: this.state.City,  
          Language: this.state.Language  
      
        };  
        axios.post('http://localhost:44308/api/details', obj)  
        .then(res => console.log(res.data));  
        debugger;  
        this.props.history.push('/Peoplelist')  

        function deletePerson(id){
        axios.delete(`https://localhost:44308/api/react/delete/${id}`)
  .then(json => {  
    if(json.data.Status==='Delete'){  
    alert('Record deleted successfully!!');  
    }  
    })  

  }  


      render() {  
        return ( 

<Container className="App">  
  
  <h4 className="PageHeading">Update Student Informations</h4>  
     <Form className="form" onSubmit={this.onSubmit}>  
         <Col>  
             <FormGroup row>  
                 <Label for="name" sm={2}>Name</Label>  
                 <Col sm={10}>  
                     <Input type="text" name="Name" value={this.state.Name} onChange={this.onChangeName}  
                     placeholder="Enter Name" />  
                 </Col>  
             </FormGroup>  
             <FormGroup row>  
                 <Label for="Password" sm={2}>Phone</Label>  
                 <Col sm={10}>  
                     <Input type="text" name="Phone" value={this.state.Phone} onChange={this.onChangePhone} placeholder="Enter Phone" />  
                 </Col>  
             </FormGroup>  
              <FormGroup row>  
                 <Label for="Password" sm={2}>City</Label>  
                 <Col sm={10}>  
                     <Input type="text" name="City" value={this.state.City} onChange={this.onChangeCity} placeholder="Enter City" />  
                 </Col>  
             </FormGroup>  
              <FormGroup row>  
                 <Label for="Password" sm={2}>Country</Label>  
                 <Col sm={10}>  
                     <Input type="text" name="Country"value={this.state.Country} onChange={this.onChangeCountry} placeholder="Enter Country" />  
                 </Col>  
             </FormGroup> 
             <FormGroup row>  
                 <Label for="Password" sm={2}>Language</Label>  
                 <Col sm={10}>  
                     <Input type="text" name="Language"value={this.state.Language} onChange={this.onChangeLanguage} placeholder="Enter Language" />  
                 </Col>  
             </FormGroup>  
         </Col>  
         <Col>  
             <FormGroup row>  
                 <Col sm={5}>  
                 </Col>  
                 <Col sm={1}>  
               <Button type="submit" color="success">Submit</Button>{' '}  
                 </Col>  
                 <Col sm={1}>  
                     <Button color="danger">Cancel</Button>{' '}  
                 </Col>  
                 <Col sm={5}>  
                 <Button onClick={()=>deletePerson(id)}>Delete</Button>
                 </Col>  
             </FormGroup>  
         </Col>  
     </Form>  
 </Container>  
            
        );  
    }  
  
}  
}
export default Details; 
/*

<td>  
          <Link to={"/edit/"+this.props.obj.Id} className="btn btn-success">Edit</Link>  
          </td>  


<tr>  
          <td>  
            {this.props.obj.Name}  
          </td>  
          <td>  
            {this.props.obj.Phone}  
          </td>  
          <td>  
            {this.props.obj.City}  
          </td>  
          
          <td>  
            <button type="button" onClick={this.DeletePerson} className="btn btn-danger">Delete</button>  
          </td>  
        </tr>  
*/