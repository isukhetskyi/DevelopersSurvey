import * as React from "react";
import * as ReactDOM from "react-dom";
import { Chart } from "react-google-charts";

interface IChartsProps {
    
}

interface IChartsState {
    options: any;
    data: any;
}

export class Charts extends React.Component<IChartsProps, IChartsState> {
    constructor(props) {
        super(props);
        this.state = {
            options: {
                title: 'Age vs. Weight comparison',
                hAxis: { title: 'Age', minValue: 0, maxValue: 15 },
                vAxis: { title: 'Number', minValue: 0, maxValue: 15 },
                legend: 'none'
            },
            data: [
                ['Age', 'Weight'],
                ["eight", 12],
                ["four", 5.5],
                ["eleven", 14],
                ["secondFour", 5],
                ["three", 3.5],
                ["six", 7]
            ]
        };
    }

    loadStatisticData() {
        var xhr = new XMLHttpRequest();
        xhr.open('get', "Statistics/GetStatisticsData", true);
        xhr.onload = function() {
            var data = JSON.parse(xhr.responseText);
            this.setState({ data: data.FrameworkStatistics });
        }.bind(this);
        xhr.send();
        console.log(this.state.data);
    }

    componentDidMount() {
    this.loadStatisticData();
}
    render() {
        return (
            <Chart
                chartType="PieChart"
                data={this.state.data}
                options={this.state.options}
                graph_id="ScatterChart"
                width="100%"
                height="400px"
                legend_toggle
            />
        );
    }
}