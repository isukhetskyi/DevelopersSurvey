import * as React from "react";

export interface IHeaderProps {
    
}

export interface IHeaderState {
    
}

export class Header extends React.Component<IHeaderProps, IHeaderState> {
    render() {
        return <nav className="navbar navbar-default navbar-fixed-top">
                   <div className="container">
                       <div className="navbar-header">
                           <a className="navbar-brand" href="#">Find you peace wiht Peaceful Dev</a>
                       </div>
                   </div>
               </nav>;
    }
}