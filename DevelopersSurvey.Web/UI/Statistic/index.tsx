import * as React from "react";
import * as ReactDOM from "react-dom";

import { LanguagesChart } from "./Components/LanguagesChart";

ReactDOM.render(
    <LanguagesChart />,
    document.getElementById('react-homepage-root'));

declare var module: any;
if (module.hot) {
    module.hot.accept();
}