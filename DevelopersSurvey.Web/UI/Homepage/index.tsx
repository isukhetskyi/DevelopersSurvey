import * as ReactDOM from 'react-dom';
import * as React from 'react';


export class Home extends React.Component<any,any> {
    render() {
        return <h1>Home, sweet home, motherfuckers</h1>;
    }
}

ReactDOM.render(
    <Home/>,
    document.getElementById('react-homepage-root'));

declare var module: any;
if (module.hot) {
    module.hot.accept();
}