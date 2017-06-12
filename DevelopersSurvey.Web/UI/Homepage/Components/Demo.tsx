import * as React from "react";
import {Button} from "react-bootstrap";
import "./Demo.scss";

class Demo extends React.Component<any, any> {

    public render() {
        return (
            <div className="Demo">
                <p>ASP.NET + React</p>
                <Button>Click me please???</Button>
            </div>
        );
    }
}

export default Demo;