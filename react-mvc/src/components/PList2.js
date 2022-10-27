import React, { Component, useEffect } from 'react';   
import { Container, Col, Form, Row, FormGroup, Label, Input, Button } from 'reactstrap';  
import axios from 'axios'


        //}  
//}
//export default PList2; 

/*
export function PList2() { 
      
  personDetails(id){
    axios.get(`https://localhost:44308/api/details/${id}`)
    .then(res =>{
      console.log(res);
      console.log(res.data);
    })

  }
*/
  /*
const [name, setName] = useState({})
 const [id, setId] = useState(2)
     //componentDidMount() {  
      
useEffect (() => {
axios
.get(`https://localhost:44308/api/people/${id}`) 
     //axios.get("https://localhost:44308/api/details?id="+this.props.match.params.id)
     
     //.then(json => {     
       
     .then(response => {  
       console.log(response)
       setName(response.data)
     })
     .catch(err => {
       console.log(err)
     })
   }, [id])
       

       //render() {  
         return ( 

<div className="container">
            
            <input type ="text" value = {} onchange={e => setId(e.target.value)} />
            <div>{name.Name}</div>
          </div>

             );  
         }              
*/
     //   }