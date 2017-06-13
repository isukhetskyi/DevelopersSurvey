import * as React from "react";

export interface IContentWrapperProps {
    
}

export interface IContentWrapperState {
    
}

export class ContentWrapper extends React.Component<IContentWrapperProps, IContentWrapperState> {
    render() {
        return <div className="container">
                    {this.props.children}
               </div>;
    }
}