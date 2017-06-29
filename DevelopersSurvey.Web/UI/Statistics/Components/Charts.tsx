import * as React from "react";
import * as ReactDOM from "react-dom";
import { Chart } from "react-google-charts";

interface IChartsProps {
    
}

interface IChartsState {
    frameworksOptions?: any;
    programingLanguagesOptions?: any;
    databasesOptions?: any;
    agesOptions?: any;

    frameworksData?: any;
    programingLanguagesData?: any;
    databasesData?: any;
    agesData?: any;
}

export class Charts extends React.Component<IChartsProps, IChartsState> {
    constructor(props) {
        super(props);
        this.state = {
            frameworksOptions: {
                title: 'Frameworks'
            },
            programingLanguagesOptions: {
                title: 'Programming Languages'
            },
            databasesOptions: {
                title: "Databases"
            },
            agesOptions:{
                title: "Age of respondents"
            },
            frameworksData: [],
            programingLanguagesData:[],
            databasesData:[],
            agesData:[]
        };
    }

    loadStatisticData() {
        let xhr = new XMLHttpRequest();
        xhr.open('get', "Statistics/GetStatisticsData", true);
        xhr.onload = function() {
            let data = JSON.parse(xhr.responseText);
            let frameworsArray: Array<Array<any>>;
            let programmingLanguagesArray: Array<Array<any>>;
            let databasesArray: Array<Array<any>>;
            let agesArray: Array<Array<any>>;

            frameworsArray = new Array();
            programmingLanguagesArray = new Array();
            databasesArray = new Array();
            agesArray = new Array();
            frameworsArray.push(["Framework", "Number of people"]);
            programmingLanguagesArray.push(["Language", "Number of people"]);
            databasesArray.push(["Database", "Number of people"]);
            data.frameworkStatistics.forEach(element => {
                frameworsArray.push([element.framework, element.number]);
            });
            data.programmingLanguagesStatistics.forEach(element => {
                programmingLanguagesArray.push([element.programmingLanguage, element.number]);
            });
            data.databasesStatistics.forEach(element => {
                databasesArray.push([element.database, element.number]);
            });

            this.setState({ frameworksData: frameworsArray });
            this.setState({ programingLanguagesData: programmingLanguagesArray });
            this.setState({ databasesData: databasesArray });
            
        }.bind(this);
        xhr.send();
    }

    componentDidMount() {
    this.loadStatisticData();
}
    render() {
        return (
            <div>
                <Chart
                    chartType="PieChart"
                    data={this.state.frameworksData}
                    options={this.state.frameworksOptions}
                    graph_id="frameworks"
                    width="100%"
                    height="400px"
                    legend_toggle
                />
                <Chart
                    chartType="PieChart"
                    data={this.state.programingLanguagesData}
                    options={this.state.programingLanguagesOptions}
                    graph_id="programingLanguages"
                    width="100%"
                    height="400px"
                    legend_toggle
                />
                <Chart
                    chartType="PieChart"
                    data={this.state.databasesData}
                    options={this.state.databasesOptions}
                    graph_id="databases"
                    width="100%"
                    height="400px"
                    legend_toggle
                />
            </div>
            
        );
    }
}