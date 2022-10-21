import React from 'react'

export const CustomDropdown = (props) => (
  <div className="form-group">
    <strong>{props.cityId}</strong>
    <select
      className="form-control"
      name="{props.cityId}"
      
      onChange={props.onChange}
    >
      <option defaultValue>Select {props.name}</option>
      {props.options.map((item, index) => (
        <option key={index} value={item.CityId}>
          {item.cityName}
        </option>
      ))}
    </select>
  </div>
)
export default class DDLIst extends React.Component {
  constructor() {
    super()
    this.state = {
      cities: [],
      value: '',
    }
  }
  componentDidMount() {
    fetch('https://localhost:44308/api/cities')
      .then((response) => response.json())
      .then((res) => this.setState({ cities: res }))
  }
  onChange = (event) => {
    this.setState({ value: event.target.value })
  }
  render() {
    return (
      <div className="container mt-4">
        
        <CustomDropdown
          name={this.state.cityId}

          options={this.state.cities}
           
          onChange={this.onChange}
        />
      </div>
    )
  }
}

/*
<option defaultValue>Select {props.name}</option>
      {props.options.map((item, index) => (
        <option key={index} value={item.id}>
          {item.username}
        </option>
*/