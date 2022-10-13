import React, { Component } from 'react';
import ReactDOM from 'react-dom';
import axios from 'axios';
import { Link } from 'react-router-dom'; 
import './App.css';  
/*
import CreatePerson from './components/CreatePerson';
*/
/*
https://localhost:44308/api/people
react: http://localhost:3000/
*/

// function deletePerson (personId)
// {
//   fetch('https://localhost:44308/api/delete/${id}',{
//     method:'DELETE'
//   }).then((result)=>{
//     result.json().then((res)=>{
//       console.warn(res)
//     })
//   })
// }
/*
function DeletePerson () {  
  axios.delete(`http://localhost:44308/Api/Delete?id=${this.props.obj.Id}`)  
 .then(json => {  
 if(json.data.Status==='Delete'){  
 alert('Record deleted successfully!!');  
 }  
 })  
 }  

 <td><button type="button" onClick={this.DeletePerson} className="btn btn-danger">Delete</button></td>
  */           

function deletePerson(id){
  console.log("bööös")
  
  axios.delete(`https://localhost:44308/api/delete/${id}`)
  .then(json => {  
    if(json.data.Status==='Delete'){  
    alert('Record deleted successfully!!');  
    }  
    })  

  /*.then(response =>{
      if(response.status === 204){
          console.log("removed")
      }
      
  })*/
 // get()
  }


class App extends Component {

    constructor(props) {
        super(props);
        this.state = {
          people: [],
          
        };
      }
      
/*
    state = {
        people: []
    };
*/

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


   
    render() {
        return (
         
            <div className="container">
               
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
              <td><button onClick={()=>deletePerson(p.personId)}>Delete</button> &nbsp;&nbsp; </td>
              
              </tr>
                ))}        
                </tbody>
                
              </table>
            </div>
            );
    }
}
export default App;