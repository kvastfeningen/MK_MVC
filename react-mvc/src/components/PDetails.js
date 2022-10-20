import React, { Component } from 'react';   
import { Container, Col, Form, Row, FormGroup, Label, Input, Button } from 'reactstrap';  
import axios from 'axios';
import {useParams} from 'react-router-dom';


function deletePerson(id){
  
    axios.delete(`https://localhost:44308/api/delete/${id}`)
    .then(json => {  
      if(json.data.Status==='Delete'){  
      alert('Record deleted successfully!!');  
      }  
      })  
    }
    
class PDetails extends Component {
  
    constructor(props){  
        super(props)  
        
        

        this.state = {  
            PersonId:'',
            Name:'', 
            Phone:''  
            //CityId:'' 
            } 

            }

           
            componentDidMount() {  
             
      axios.get(`https://localhost:44308/api/people/${this.props.match.params.id}`) 
            //axios.get("https://localhost:44308/api/details?id="+this.props.match.params.id)
            
            //.then(json => {     
              
            .then(response => {  
              
                        this.setState({ 
                          
                         // PersonId: json.data.PersonId,
                         // Name: json.data.Name,   
                        // Phone: json.data.Phone
                          Name: response.data.Name,   
                          Phone: response.data.Phone 
                         // CityId: response.data.CityId
                         });  
            
                    })  
                    .catch(function (error) {  
                        console.log(error);  
                    })  
              }      


              render() {  
                return ( 

<div className="container">
                   
                   
                   <table>
                     <thead>
                       <tr>
                       <th>   </th>
                         
                         <th>PersonId</th>
                         <th>Name</th>
                         <th>Phone</th>
                         <th>City</th>
                       </tr>
                     </thead>
                     <tbody> 
     
                     
                 <tr >
                   <td></td>
                   <td>{this.props.PersonId}</td>
                   <td>{this.props.Name}</td>
                   <td>{this.props.Phone}</td>
                  {/*  <td>{this.props.CityId}</td>*/}
                  {/*  <td>{this.state.City.CityName}</td>*/}
                 
                   <td><button onClick={()=>deletePerson(this.state.PersonId)}>Delete</button> &nbsp;&nbsp; </td>
                   
                   </tr>
                            
                     </tbody>
                     
                   </table>
                 </div>




                    );  
                }  
}
export default PDetails; 

/*
key={this.state.PersonId}
*/