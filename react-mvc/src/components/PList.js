import React, { Component, useState, useEffect } from 'react';
import ReactDOM from 'react-dom';
import axios from 'axios';
import { Link } from 'react-router-dom'; 
//import Table from './Table';  
//import './App.css';  

function deletePerson(id){
  
  //const people = this.state.people;
  //console.log(this.state); 
    axios.delete(`https://localhost:44308/api/delete/${id}`)
/*
    .then(res => {
      console.log(res);
      //console.log(res.datatoString);
    });
    */
    
    .then(json => {  
   //this.setState({
   // state: this.setState
   window.location.reload(true);
       //people: people.filter(p => p.personId !== id)
     });
    
      }  ;
   // }
   /*
   .then(res => res.json())
   .then(
     (result) => {
       this.setState({
         response: result,
         people: people.filter(p => p.personId !== id)
       });
     },
     (error) => {
       this.setState({ error });
     }
   )
   */
    


    export default class PList extends Component {
    
      constructor(props) {
        super(props);
        this.state = {
          people: [],
          
        };
      }

      state = {
        toggle: false
      }

      handleToggle = () => {
        this.setState(prevState => ({
          toggle : !prevState.toggle
        })
        )
      }

      // sort by name
      alphaSort = () => {
  
        return (
        [...this.state.people].sort(function(a, b) {
          let nameA = a.name.toUpperCase(); 
          let nameB = b.name.toUpperCase(); 
          if (nameA < nameB) {
            return -1;
          }
          if (nameA > nameB) {
            return 1;
          }
        
          // names must be equal
          return 0;
        }));
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
               
              <h2>People   <button onClick={this.handleToggle}>Sort by Name</button></h2>  
              <table>
                <thead>
                  <tr>
                  {/*<th>PersonId</th>*/}
                    <th>Name</th>
                    
                    <th>CityId</th>
                  </tr>
                </thead>
                <tbody> 
              
              {(this.state.toggle ? this.alphaSort() : this.state.people).map(p => (
            <tr key={p.personId}>
              {/*  <td>{p.personId}</td>*/}
              <td>{p.name}</td>
             
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



   