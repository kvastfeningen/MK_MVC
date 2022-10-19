import React, { Component } from 'react';
import ReactDOM from 'react-dom';
import axios from 'axios';
import { Link } from 'react-router-dom'; 
//import Table from './Table';  
//import './App.css';  

function deletePerson(id){
  
    axios.delete(`https://localhost:44308/api/delete/${id}`)
    .then(json => {  
      if(json.data.Status==='Delete'){  
      alert('Record deleted successfully!!');  
      }  
      })  
    }

    class CityList extends Component {
    //export class PList extends Component {
      constructor(props) {
        super(props);
        this.state = {
          cities: [],
          
        };
      }

      componentDidMount() {
        fetch("https://localhost:44308/api/cities")
        
        .then(res => res.json())
        .then(
        (result) => {
            this.setState({
              cities:result
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
                    <th>City Name</th>
                    <th>City Id</th>
                    <th>Country</th>
                  </tr>
                </thead>
                <tbody> 

                {this.state.cities.map(p => (
            <tr key={p.cityId}>
              <td></td>
              <td>{p.cityName}</td>
              <td>{p.cityId}</td>
              <td>{p.countryId}</td>
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
    export default CityList;
   //export { default as PList } from './PList';