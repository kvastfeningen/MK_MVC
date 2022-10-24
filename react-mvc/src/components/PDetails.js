import React, { Component } from 'react';   
import { Container, Col, Form, Row, FormGroup, Label, Input, Button } from 'reactstrap';  
import axios from 'axios';
import {useParams} from 'react-router-dom';
import { Link } from 'react-router-dom'; 

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
        
        
/*
        this.state = {  
            PersonId:'',
            Name:'', 
            Phone:''  
            //CityId:'' 
            } 
*/
            }

           
            componentDidMount() {  
             // console.log(this.state); 
        //axios.get("https://localhost:44308/api/details", this.state)
        axios.get("https://localhost:44308/api/details/${id}")
              //axios.get("https://localhost:44308/api/people?id")   
      //axios.get(`https://localhost:44308/api/people/${id}`) 
            //axios.get("https://localhost:44308/api/details?id="+this.props.match.params.id)
            
              
        .then(res => res.json())
        .then(
        (result) => {
            this.setState({
              person:result
            });
        },
        (error) => {
            alert(error);
        }
        )

            //.then(json => {     
             /* 
            .then(response => {  
              
                        this.setState({ 
                          
                         // PersonId: json.data.PersonId,
                         // Name: json.data.Name,   
                        // Phone: json.data.Phone
                        PersonId: response.data.PersonId,
                          Name: response.data.Name,   
                          Phone: response.data.Phone 
                         // CityId: response.data.CityId
                         });  
            
                    })  
                    .catch(function (error) {  
                        console.log(error);  
                    })  */
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
                        {/* <th>City</th>*/}
                       </tr>
                     </thead>
                     <tbody> 
     
                     <tr>
                     
                   <td></td>
                   <td>{this.props.PersonId}</td>
                   <td>{this.props.Name}</td>
                   <td>{this.props.Phone}</td>
                  {/*  <td>{this.props.CityId}</td>*/}
                  {/*  <td>{this.state.City.CityName}</td>*/}
                 
                   <td><Button onClick={()=>deletePerson(this.state.PersonId)}>Delete</Button> &nbsp;&nbsp; </td>
                   
                   </tr>
                            
                     </tbody>
                     
                   </table>
                 </div>




                    );  
                }  
}
export default PDetails; 

/*


*/