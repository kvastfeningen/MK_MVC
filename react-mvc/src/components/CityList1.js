import React from 'react';

var values;

class CityList1 extends React.Component {

    constructor(){
        super();
        this.state = {
            options: []
        }  
    }

    componentDidMount(){
        this.fetchOptions()
    }

    fetchOptions(){
        fetch('https://localhost:44308/api/people')
            .then((res) => {
                return res.json();
            }).then((json) => {
                values = json;
                this.setState({options: values.people})
                console.log(values);
            });
    }

    render(){
        return <div className="drop-down">
            <select>
                { this.state.options.map((option, key) => <option key={key} >{option}</option>) }
            </select>
            </div>;
    }
}

export default CityList1;