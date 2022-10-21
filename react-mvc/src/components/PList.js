import React, { Component, useState } from 'react';
import ReactDOM from 'react-dom';
import axios from 'axios';
import { Link } from 'react-router-dom'; 
//import Table from './Table';  
//import './App.css';  

function deletePerson(id){
  
  

    axios.delete(`https://localhost:44308/api/delete/${id}`)
    
    .then(json => {  
      
      })  
    }

    export default class PList extends Component {
    
      constructor(props) {
        super(props);
        this.state = {
          people: [],
          
        };
      }

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
                    <th>CityId</th>
                  </tr>
                </thead>
                <tbody> 

                {this.state.people.map(p => (
            <tr key={p.personId}>
              <td></td>
              <td>{p.name}</td>
              <td>{p.personId}</td>
              <td>{p.cityId}</td>
              <td><Link to={"/PDetails/"+p.personId} className="btn btn-success">Details</Link></td>
              <td><button onClick={()=>deletePerson(p.personId)}>Delete</button> &nbsp;&nbsp; </td>
             
              </tr>
                ))}        
                </tbody>
                
              </table>
            </div>
            );
    }
       
    }
   // export default PList;
  // export { default as PList } from './PList';

  //.then(()=>{
      //let list=this.state.people.filter((item)=>return (item.id===id))
      //this.setState({people:list})}
//.catch(err => console.log(err))

   /*
 constructor(props) {
            super(props);
            this.state = {
              people: [],
              
            };
          }

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
                  <td><Link to={"/PDetails/"+p.personId} className="btn btn-success">Details</Link></td>
                  <td><button onClick={()=>deletePerson(p.personId)}>Delete</button> &nbsp;&nbsp; </td>
                  
                  </tr>
                    ))}        
                    </tbody>
                    
                  </table>
                </div>
                );
        }
   */



   