import React, { Component } from 'react';   
import { Container, Col, Form, Row, FormGroup, Label, Input, Button } from 'reactstrap';  
import axios from 'axios'

function deletePerson(id){
  
    axios.delete("https://localhost:44308/api/delete/${id}")
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
            
            Name:'', 
            Phone:'',  
            //CityId:'' 
            } 

            }

           
            componentDidMount() {  
              
      axios.get("https://localhost:44308/api/people/${id}") 
            //axios.get("https://localhost:44308/api/details?id="+this.props.match.params.id)
                    .then(response => {  
                        this.setState({ 
                          //PersonId: response.data.PersonId,
                          Name: response.data.Name,   
                          Phone: response.data.Phone,  
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
                         <th>Name</th>
                         <th>PersonId</th>
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