import React, { Component } from 'react';
import DeletePerson from './';
/*import Table from './Table';
import Form from './Form';*/
import axios from 'axios';

/*
https://localhost:44308/api/people
react: http://localhost:3000/
*/

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
        /*.then(res.header("Access-Control-Allow-Origin", "*"))*/
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
            <div>
              <h2>People</h2>
              <table>
                <thead>
                  <tr>
                  <th>   </th>
                    <th>Name</th>
                    
                    
                  </tr>
                </thead>
                <tbody> 

                {this.state.people.map(p => (
            <tr key={p.personId}>
              <td></td>
              <td>{p.name}</td>
              
              <td><button type="reset" onClick={this.detailsPerson}>Details</button> &nbsp;&nbsp; </td>
              <DeletePerson />
             
              </tr>
                ))}        
                </tbody>
                
              </table>
            </div>
            );
    }
}
export default App;