import React from 'react';

class DeletePerson extends React.Component {
    constructor(props) {
        super(props);

        this.state = { 
            status: null
        };
    }

    componentDidMount() {
        // Simple DELETE request with fetch
        fetch("https://localhost:44308/api/delete/1", { method: "DELETE" })
            .then(() => this.setState({ status: "Delete successful" }));
    }

    render() {
        const { status } = this.state;
        return (
            <div className="card text-center m-3">
                <h5 className="card-header">Simple DELETE Request</h5>
                <div className="card-body">
                    Status: {status}
                </div>
            </div>   
        );
    }
}

export default DeletePerson;