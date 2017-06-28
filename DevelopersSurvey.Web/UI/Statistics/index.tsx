import * as React from "react";
import * as ReactDOM from "react-dom";

import { Charts } from "./Components/Charts";

ReactDOM.render(
    <Charts />,
    document.getElementById('react-statistics-root'));

declare var module: any;
if (module.hot) {
    module.hot.accept();
}