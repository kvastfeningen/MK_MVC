import React, { Component } from 'react';  
import axios from 'axios';  
import { Link } from 'react-router-dom';  
import { Container, Col, Form, Row, FormGroup, Label, Input, Button } from 'reactstrap';  

class Table extends Component {  
  constructor(props) {  
    super(props);  
    }  
      
    
  render() {  
    return (  
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
            {this.props.obj.Country}  
          </td>
          <td>  
            {this.props.obj.Language}  
          </td>  
          <td>  
          <Link to={"/edit/"+this.props.obj.Id} className="btn btn-success">Edit</Link>  
          </td>  
           
        </tr>  
    );  
  }  
}  
  
export default Table; 