import * as React from "react";
import { Button, ButtonGroup, FormControl, InputGroup, Label } from "react-bootstrap";

interface ISurveyFormProps {

}

interface ISurveyFormState {

}

export class SurveyForm extends React.Component<ISurveyFormProps, ISurveyFormState> {
    render() {
        return <div className='panel panel-primary dialog-panel'>
            <div className='panel-heading'>
                <h5>NetLS Software Development</h5>
            </div>
            <div className='panel-body'>
                <form className='form-horizontal' role='form'>
                    <div className="form-group">

                    </div>
                </form>
            </div>
        </div>;
    }
}