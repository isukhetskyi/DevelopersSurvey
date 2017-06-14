import * as React from "react";
import { Button, Radio, FormControl, FormGroup, ControlLabel, Form, Col, Checkbox, HelpBlock } from "react-bootstrap";

interface ISurveyFormProps {

}

interface ISurveyFormState {
    // personal info
    firstName: string;
    lastName: string;
    age: number;
    address: string;
    isEmployed: boolean;
    currentPosition: string;
    phone: string; 
    emailAddress: string;
    skype: string;

    // education
    placeOfStudying: string;
    specialty: string;

    // work experiance
    programmingLangages: Array<string>;
    frameworks: Array<string>;

    // other info 
    otherInfo: string;
}

export class SurveyForm extends React.Component<ISurveyFormProps, ISurveyFormState> {
    handleFirstNameCange(event: any): void {
        //this.setState({ firstName: event.target.value});
    };

    render() {
        return <div className="container">
            <Form horizontal>
                <span className="text-center">
                    <h2>Developers Survey</h2>
                </span>
                <hr />
                <h3>Personal Info</h3>
                <FormGroup controlId="surveyFormFirstName">
                    <Col componentClass={ControlLabel} sm={2}>
                        First Name
                    </Col>
                    <Col sm={10}>
                        <FormControl type="text" placeholder="John" />
                    </Col>
                </FormGroup>
                <FormGroup controlId="surveyFormLastName">
                    <Col componentClass={ControlLabel} sm={2}>
                        Last Name
                    </Col>
                    <Col sm={10}>
                        <FormControl type="text" placeholder="Snow" />
                    </Col>
                </FormGroup>
                <FormGroup controlId="surveyFormAge">
                    <Col componentClass={ControlLabel} sm={2}>
                        Age
                    </Col>
                    <Col sm={10}>
                        <FormControl type="text" placeholder="18" />
                    </Col>
                </FormGroup>
                <FormGroup controlId="surveyFormAddress">
                    <Col componentClass={ControlLabel} sm={2}>
                        Address
                    </Col>
                    <Col sm={10}>
                        <FormControl type="text" placeholder="Ivano-Frankivsk city" />
                    </Col>
                </FormGroup>
                <FormGroup>
                    <Col componentClass={ControlLabel} sm={2}>
                        Are You Currently Employed?
                    </Col>
                    <Col sm={10}>
                        <Radio name="radioGroup" inline>
                            Fuck yeah!
                        </Radio>
                        {' '}
                        <Radio name="radioGroup" inline>
                            Nope, I'm homeless :(
                        </Radio>
                    </Col>
                </FormGroup>
                <FormGroup controlId="surveyFormCurrentPosition">
                    <Col componentClass={ControlLabel} sm={2}>
                        Current Position
                    </Col>
                    <Col sm={10}>
                        <FormControl type="text" placeholder="Software Engeneer" />
                    </Col>
                </FormGroup>
                <FormGroup controlId="surveyFormPhone">
                    <Col componentClass={ControlLabel} sm={2}>
                        Phone
                    </Col>
                    <Col sm={10}>
                        <FormControl type="text" placeholder="+380 66 666 6666" />
                    </Col>
                </FormGroup>
                <FormGroup controlId="surveyFormMail">
                    <Col componentClass={ControlLabel} sm={2}>
                        Email Address
                    </Col>
                    <Col sm={10}>
                        <FormControl type="text" placeholder="example@test.com" />
                    </Col>
                </FormGroup>
                <FormGroup controlId="surveyFormSkype">
                    <Col componentClass={ControlLabel} sm={2}>
                        Skype
                    </Col>
                    <Col sm={10}>
                        <FormControl type="text" placeholder="johnystark" />
                    </Col>
                </FormGroup>
                <hr/>


                <h3>Education</h3>
                <FormGroup controlId="surveyFormPlaceOfStudying">
                    <Col componentClass={ControlLabel} sm={2}>
                        Place Of Studying
                    </Col>
                    <Col sm={10}>
                        <FormControl type="text" placeholder="IFNTUOG" />
                    </Col>
                </FormGroup>
                <FormGroup controlId="surveyFormSpecialty">
                    <Col componentClass={ControlLabel} sm={2}>
                        Specialty
                    </Col>
                    <Col sm={10}>
                        <FormControl type="text" placeholder="Army Runner" />
                    </Col>
                </FormGroup>
                <hr/>
                <h3>Work Experiance</h3>
                <FormGroup>
                    <Col componentClass={ControlLabel} sm={2}>
                        Programming Languages
                    </Col>
                    <Col sm={10}>
                        <Checkbox value="C#" inline>
                            C#
                        </Checkbox>
                        {' '}
                        <Checkbox value="JavaScript" inline>
                            JavaScript
                        </Checkbox>
                        {' '}
                        <Checkbox value="SQL" inline>
                            SQL
                        </Checkbox>
                        {' '}
                        <Checkbox value="C" inline>
                            C
                        </Checkbox>
                        {' '}
                        <Checkbox value="C++" inline>
                            C++
                        </Checkbox>
                        {' '}
                        <Checkbox value="PHP" inline>
                            PHP
                        </Checkbox>
                        {' '}
                        <Checkbox value="Java" inline>
                            Java
                        </Checkbox>
                        {' '}
                        <Checkbox value="Ruby" inline>
                            Ruby
                        </Checkbox>
                        {' '}
                        <Checkbox value="Python" inline>
                            Python
                        </Checkbox>
                        {' '}
                        <Checkbox value="ObjectiveC" inline>
                            Objective C
                        </Checkbox>
                        {' '}
                        <Checkbox value="Swift" inline>
                            Swift
                        </Checkbox>
                    </Col>
                </FormGroup>
            <FormGroup>
                <Col componentClass={ControlLabel} sm={2}>
                    Frameworks
                </Col>
                <Col sm={10}>
                    <Checkbox value="ASP.Net" inline>
                        ASP.Net 
                    </Checkbox>
                    {' '}
                    <Checkbox value="EntityFramework" inline>
                        Entity Framework
                    </Checkbox>
                    {' '}                    
                    <Checkbox value="NUnit" inline>
                        NUnit
                    </Checkbox>
                    {' '}
                    <Checkbox value="Angular" inline>
                        Angular
                    </Checkbox>
                    {' '}
                    <Checkbox value="AngularJS" inline>
                        AngularJS
                    </Checkbox>
                    {' '}
                    <Checkbox value="Xamarin" inline>
                        Xamarin
                    </Checkbox>
                    {' '}
                    <Checkbox value="Xamarin.Forms" inline>
                        Xamarin.Forms
                    </Checkbox>
                    {' '}
                    <Checkbox value="React" inline>
                        React
                    </Checkbox>
                </Col>
            </FormGroup>
            <hr/>
            <h3>Other</h3>
            <FormGroup controlId="surveyFormOther">
                <Col componentClass={ControlLabel} sm={2}>
                    Tell me more
                </Col>
                <Col sm={10}>
                    <FormControl componentClass="textarea" placeholder="Some borring text" />
                </Col>
            </FormGroup>
            <hr/>
            <FormGroup>
                <Col smOffset={2} sm={10}>
                    <Button type="submit">
                        Submit
                    </Button>
                </Col>
            </FormGroup>
            </Form>
        </div>;
    }
}

export default SurveyForm;