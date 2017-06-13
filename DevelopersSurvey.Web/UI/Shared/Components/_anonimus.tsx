import * as React from "react";
import { } from "react-bootstrap";
import { ContentWrapper } from "./contentWrapper";
import { Header } from "./header";
import { Footer } from "./footer";

export interface IAnonimusProps {

}

export interface IAnonimusState {

}

export class Anonimus extends React.Component<IAnonimusProps, IAnonimusState> {
    render() {
        return <ContentWrapper>
            <Header></Header>
                {this.props.children}
            <Footer></Footer>
        </ContentWrapper>;
    }
}