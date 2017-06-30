import * as React from "react";
import * as ReactDOM from "react-dom";
import { BootstrapTable, TableHeaderColumn } from "react-bootstrap-table";

interface IRespondentsProps {

}

interface IRespondentsState {
    respondentsData: any;
}

export class Respondents extends React.Component<IRespondentsProps, IRespondentsState> {
    constructor(props) {
        super(props);
        this.state = {
            respondentsData: []
        }
    }
    loadRespondentsData() {
        let xhr = new XMLHttpRequest();
        xhr.open('get', "Respondents/GetRespondents", true);
        xhr.onload = function () {
            let data = JSON.parse(xhr.responseText);
            console.log(xhr.responseText);
            this.setState({ respondentsData: data.respondents });

        }.bind(this);
        xhr.send();
    }

    componentDidMount() {
        this.loadRespondentsData();
    }

    render() {
        return (
            <BootstrapTable data={this.state.respondentsData} options={{ noDataText: 'This is custom text for empty data' }}>
                <TableHeaderColumn ref='firstNameRef' dataField='firstName' filter={{ type: 'TextFilter', placeholder: 'Please enter a value' }}>Name</TableHeaderColumn>
                <TableHeaderColumn ref='lastNameRef' dataField='lastName' filter={{ type: 'TextFilter', placeholder: 'Please enter a value' }}>Surname</TableHeaderColumn>
                <TableHeaderColumn ref='ageRef' dataField='age' filter={{ type: 'NumberFilter', delay: 1000 }}>Age</TableHeaderColumn>
                <TableHeaderColumn dataField='address'>Address</TableHeaderColumn>
                <TableHeaderColumn dataField='isCurrentlyEmployed' isKey>Is employed?</TableHeaderColumn>
                <TableHeaderColumn dataField='phoneNumber'>Phone</TableHeaderColumn>
                <TableHeaderColumn dataField='mail'>Email</TableHeaderColumn>
                <TableHeaderColumn dataField='skype'>Skype</TableHeaderColumn>
            </BootstrapTable>
        );
    }
}