import * as React from "react";
import { Button, Radio, FormControl, FormGroup, ControlLabel, Form, Col, Checkbox, HelpBlock } from "react-bootstrap";

interface ISurveyFormProps {

}

class Respondent {

    // personal info
    Id?: number;
    FirstName?: string;
    LastName?: string;
    Age?: number;
    Address?: string;
    IsCurrentlyEmployed?: boolean;
    CurrentPosition?: string;
    PhoneNumber?: string;
    Mail?: string;
    Skype?: string;

    // education
    PlaceOfStudying?: string;
    SpecialCources?: string;

    // work experiance
    ProgrammingLanguages?: string;
    Databases?: string;
    Frameworks?: string;

    // other info 
    OtherInfo?: string;
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
        this.setState({ firstName: event.target.value });
        console.log(event.target.value);
    };

    handleLastNameCange(event: any): void {
        this.setState({ lastName: event.target.value });
        console.log(event.target.value);
    };

    handleAgeCange(event: any): void {
        this.setState({ age: event.target.value });
        console.log(event.target.value);
    };

    handleAddressCange(event: any): void {
        this.setState({ address: event.target.value });
        console.log(event.target.value);
    };

    handleCurrentPositionCange(event: any): void {
        this.setState({ currentPosition: event.target.value });
        console.log(event.target.value);
    };

    handlePhoneCange(event: any): void {
        this.setState({ phone: event.target.value });
        console.log(event.target.value);
    };

    handleEmailCange(event: any): void {
        this.setState({ emailAddress: event.target.value });
        console.log(event.target.value);
    };

    handleSkypeCange(event: any): void {
        this.setState({ skype: event.target.value });
        console.log(event.target.value);
    };

    handlePlaceOfStudyingCange(event: any): void {
        this.setState({ placeOfStudying: event.target.value });
        console.log(event.target.value);
    };

    handleSpecialtyCange(event: any): void {
        this.setState({ specialty: event.target.value });
        console.log(event.target.value);
    };

    handleOtherInfoCange(event: any): void {
        this.setState({ otherInfo: event.target.value });
        console.log(event.target.value);
    };

    // TODO add checkboxes handling IS
    handleSubmit(event: any): void {

        let newRespondent: Respondent = new Respondent();
        newRespondent.FirstName = this.state.firstName;
        newRespondent.LastName = this.state.lastName;
        newRespondent.Age = this.state.age;
        newRespondent.Address = this.state.address;
        newRespondent.IsCurrentlyEmployed = false;
        newRespondent.CurrentPosition = this.state.currentPosition;
        newRespondent.PhoneNumber = this.state.phone;
        newRespondent.Mail = this.state.emailAddress;
        newRespondent.Skype = this.state.skype;
        newRespondent.PlaceOfStudying = this.state.placeOfStudying;
        newRespondent.SpecialCources = this.state.specialty;
        newRespondent.ProgrammingLanguages = "C#";
        newRespondent.Frameworks = "EF";
        newRespondent.Databases = "T-SQL";
        newRespondent.OtherInfo = this.state.otherInfo;
        let jsonRespondent = JSON.stringify(newRespondent);
        console.log(jsonRespondent);
    
        var data = new FormData();
        data.append("respondent", jsonRespondent);
        var xhr = new XMLHttpRequest();
        xhr.open("POST", "home/SubmitSurvey", true);
        xhr.onload = function() {
            debugger;
        };
        xhr.send(data);
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
                        <FormControl type="text" onChange={this.handleFirstNameCange.bind(this)} placeholder="John" />
                    </Col>
                </FormGroup>
                <FormGroup controlId="surveyFormLastName">
                    <Col componentClass={ControlLabel} sm={2}>
                        Last Name
                    </Col>
                    <Col sm={10}>
                        <FormControl type="text" onChange={this.handleLastNameCange.bind(this)} placeholder="Snow" />
                    </Col>
                </FormGroup>
                <FormGroup controlId="surveyFormAge">
                    <Col componentClass={ControlLabel} sm={2}>
                        Age
                    </Col>
                    <Col sm={10}>
                        <FormControl type="text" onChange={this.handleAgeCange.bind(this)} placeholder="18" />
                    </Col>
                </FormGroup>
                <FormGroup controlId="surveyFormAddress">
                    <Col componentClass={ControlLabel} sm={2}>
                        Address
                    </Col>
                    <Col sm={10}>
                        <FormControl type="text" onChange={this.handleAddressCange.bind(this)} placeholder="Ivano-Frankivsk city" />
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
                        <FormControl type="text" onChange={this.handleCurrentPositionCange.bind(this)} placeholder="Software Engeneer" />
                    </Col>
                </FormGroup>
                <FormGroup controlId="surveyFormPhone">
                    <Col componentClass={ControlLabel} sm={2}>
                        Phone
                    </Col>
                    <Col sm={10}>
                        <FormControl type="text" onChange={this.handlePhoneCange.bind(this)} placeholder="+380 66 666 6666" />
                    </Col>
                </FormGroup>
                <FormGroup controlId="surveyFormMail">
                    <Col componentClass={ControlLabel} sm={2}>
                        Email Address
                    </Col>
                    <Col sm={10}>
                        <FormControl type="text" onChange={this.handleEmailCange.bind(this)} placeholder="example@test.com" />
                    </Col>
                </FormGroup>
                <FormGroup controlId="surveyFormSkype">
                    <Col componentClass={ControlLabel} sm={2}>
                        Skype
                    </Col>
                    <Col sm={10}>
                        <FormControl type="text" onChange={this.handleSkypeCange.bind(this)} placeholder="johnystark" />
                    </Col>
                </FormGroup>
                <hr/>


                <h3>Education</h3>
                <FormGroup controlId="surveyFormPlaceOfStudying">
                    <Col componentClass={ControlLabel} sm={2}>
                        Place Of Studying
                    </Col>
                    <Col sm={10}>
                        <FormControl type="text" onChange={this.handlePlaceOfStudyingCange.bind(this)} placeholder="IFNTUOG" />
                    </Col>
                </FormGroup>
                <FormGroup controlId="surveyFormSpecialty">
                    <Col componentClass={ControlLabel} sm={2}>
                        Specialty
                    </Col>
                    <Col sm={10}>
                        <FormControl type="text" onChange={this.handleSpecialtyCange.bind(this)} placeholder="Army Runner" />
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
                    <FormControl componentClass="textarea" onChange={this.handleOtherInfoCange.bind(this)} placeholder="Some borring text" />
                </Col>
            </FormGroup>
            <hr/>
            <FormGroup>
                    <Col smOffset={2} sm={10}>
                        <Button type="submit" onClick={this.handleSubmit.bind(this)}>
                        Submit
                    </Button>
                </Col>
            </FormGroup>
            </Form>
        </div>;
    }
}

export default SurveyForm;