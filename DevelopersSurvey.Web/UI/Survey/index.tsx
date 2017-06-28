import * as React from "react";
import * as ReactDOM from "react-dom";
import { SurveyForm } from "./Components/SurveyForm";


ReactDOM.render(
    <SurveyForm />,
    document.getElementById('react-survey-root'));

declare var module: any;
if (module.hot) {
    module.hot.accept();
}