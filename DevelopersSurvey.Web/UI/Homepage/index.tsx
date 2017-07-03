import * as ReactDOM from 'react-dom';
import * as React from 'react';


export class Home extends React.Component<any, any> {
    render() {
        return <div className="text-center">
            <h1>Home, sweet home</h1>
            <img src="http://i1.kym-cdn.com/entries/icons/original/000/006/725/desk_flip.jpg"/>
        </div>;

    }
}

ReactDOM.render(
    <Home />,
    document.getElementById('react-homepage-root'));

declare var module: any;
if (module.hot) {
    module.hot.accept();
}