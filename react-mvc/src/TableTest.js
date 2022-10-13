import React from 'react';


const TableHeader = () => { 
    return (
        <thead>
            <tr>
                <th>Name</th>
                <th>City</th>
                
            </tr>
        </thead>
    );
}

const TableBody = props => { 
    const rows = props.personData.map((row, index) => {
        return (
            <tr key={index}>
                <td>{row.name}</td>
                <td>{row.city}</td>
                <td><button onClick={() => props.removePerson(index)}>Delete</button></td>
            </tr>
        );
    });

    return <tbody>{rows}</tbody>;
}

const Table = (props) => {
    const { personData, removePerson } = props;
        return (
            <table>
                <TableHeader />
                
                <TableBody personData={personData} removePerson={removePerson} />
            </table>
        );
}

export default Table;

/*
.map(person =>
              <li key={person.name}>{person.city}</li>
            )
            */