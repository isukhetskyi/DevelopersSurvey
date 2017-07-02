import * as React from "react";
import * as ReactDOM from "react-dom";
import { BootstrapTable, TableHeaderColumn } from "react-bootstrap-table";

interface IRespondentsProps {

}

interface IRespondentsState {
    respondentsData?: any;
    showModal?: boolean;
}

export class Respondents extends React.Component<IRespondentsProps, IRespondentsState> {
    constructor(props) {
        super(props);
        this.state = {
            respondentsData: [],
            showModal: false
        }
    }

    open() {
        this.setState({ showModal: true });
    }

    loadRespondentsData() {
        let xhr = new XMLHttpRequest();
        xhr.open('get', "Respondents/GetRespondents", true);
        xhr.onload = function() {
            let data = JSON.parse(xhr.responseText);
            console.log(xhr.responseText);
            this.setState({ respondentsData: data.respondents });

        }.bind(this);
        xhr.send();
    }

    componentDidMount() {
        this.loadRespondentsData();
    }

    options = {
        onRowDoubleClick: function(row) {
            console.log(`You double click row id: ${row.id}`);
            console.log(row);
            

        },
        noDataText: 'This is custom text for empty data',
    };

    render() {
        return (
            <BootstrapTable ref='table' data={this.state.respondentsData} width='100' options={this.options} pagination>
                <TableHeaderColumn dataField='id' isKey={true} width='60'>ID</TableHeaderColumn>
                <TableHeaderColumn ref='firstNameRef' dataField='firstName' width='210' filter={{ type: 'TextFilter', placeholder: 'Please enter a value' }}>First Name</TableHeaderColumn>
                <TableHeaderColumn ref='lastNameRef' dataField='lastName' width='210' filter={{ type: 'TextFilter', placeholder: 'Please enter a value' }}>Last Name</TableHeaderColumn>
                <TableHeaderColumn ref='ageRef' dataField='age' filter={{ type: 'NumberFilter', delay: 1000 }} >Age</TableHeaderColumn>
                <TableHeaderColumn dataField='isCurrentlyEmployed' width='91'>Is employed?</TableHeaderColumn>
                <TableHeaderColumn dataField='phoneNumber' width='120'>Phone</TableHeaderColumn>
                <TableHeaderColumn dataField='mail' width='150'>Email</TableHeaderColumn>
                <TableHeaderColumn dataField='skype' width='90'>Skype</TableHeaderColumn>
            </BootstrapTable>
        );
    }
}