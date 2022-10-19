import React from 'react';

class CityList2 extends React.Component {
    state = {
        people: []
    }
    componentDidMount() {
       fetch('https://localhost:44308/api/people')
        .then(function(res) {
            return res.json();
        }).then((json)=> {
            this.setState({
               people: json
            })
        });
    }
    render(){
        return <div className="drop-down">
            <p>I would like to render a dropdown here from the values object</p>
              <select>{
                 this.state.values.map((obj) => {
                     return <option value={obj.id}>{obj.name}</option>
                 })
              }</select>
            </div>;
    }
}

export default CityList2;