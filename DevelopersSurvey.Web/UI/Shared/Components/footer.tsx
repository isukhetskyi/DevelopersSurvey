import * as React from "react";
//import "./Styles/style.scss";

export interface IFooterProps {
    
}

export interface IFooterState {
    
}

export class Footer extends React.Component<IFooterProps, IFooterState> {
    render() {
        return <footer className="footer">
                   <div className="container">
                       <p className="text-muted">Place sticky footer content here.</p>
                   </div>
               </footer>;
    }
}