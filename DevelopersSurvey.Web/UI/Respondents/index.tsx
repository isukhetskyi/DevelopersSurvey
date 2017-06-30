import * as React from "react";
import * as ReactDOM from "react-dom";

import { Respondents } from "./Components/Respondents";

ReactDOM.render(
    <Respondents />,
    document.getElementById('react-respondents-root'));

declare var module: any;
if (module.hot) {
    module.hot.accept();
}