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
        firstName?: string;
        lastName?: string;
        age?: number;
        address?: string;
        isEmployed?: boolean;
        currentPosition?: string;
        phone?: string;
        emailAddress?: string;
        skype?: string;

        // education
        placeOfStudying?: string;
        specialty?: string;

        // work experiance
        programmingLangages?: Array<string>;
        frameworks?: Array<string>;
        databases?: Array<string>;

        // other info 
        otherInfo?: string;    
}

export class SurveyForm extends React.Component<ISurveyFormProps, ISurveyFormState> {

    constructor(props: ISurveyFormProps) {
        super(props);
        this.state = {
            firstName: "",
            lastName: "",
            age: 0,
            address: "",
            isEmployed: false,
            currentPosition: "",
            phone: "",
            emailAddress: "",
            skype: "",
            placeOfStudying: "",
            specialty: "",
            programmingLangages: [],
            frameworks: [],
            databases: [],
            otherInfo: ""
        }
    }

    handleFirstNameChange(event: any): void {
        this.setState({ firstName: event.target.value });
    };

    handleLastNameChange(event: any): void {
        this.setState({ lastName: event.target.value });
    };

    handleAgeChange(event: any): void {
        this.setState({ age: event.target.value });
    };

    handleAddressChange(event: any): void {
        this.setState({ address: event.target.value });
    };

    handleIsEmployedTrue(event: any): void {
        this.setState({ isEmployed: true });
    }

    handleIsEmployedFalse(event: any): void {
        this.setState({ isEmployed: false });
    }

    handleCurrentPositionChange(event: any): void {
        this.setState({ currentPosition: event.target.value });
    };

    handlePhoneChange(event: any): void {
        this.setState({ phone: event.target.value });
    };

    handleEmailChange(event: any): void {
        this.setState({ emailAddress: event.target.value });
    };

    handleSkypeChange(event: any): void {
        this.setState({ skype: event.target.value });
    };

    handlePlaceOfStudyingChange(event: any): void {
        this.setState({ placeOfStudying: event.target.value });
    };

    handleSpecialtyChange(event: any): void {
        this.setState({ specialty: event.target.value });
    }

    handleOtherInfoChange(event: any): void {
        this.setState({ otherInfo: event.target.value });
    };

    handleProgrammingLanguagesChange(event: any): void {
        if (event.target.checked) {
            let newArray = this.state.programmingLangages;
            newArray.push(event.target.value);
            this.setState({ programmingLangages: newArray });
        } else {
            let newArray = this.state.programmingLangages;
            let index = this.state.programmingLangages.indexOf(event.target.value, 0);
            if (index > -1) {
                newArray.splice(index, 1);
            }
            this.setState({ programmingLangages: newArray});
        }
    }

    handleFrameworksChange(event: any): void {
        if (event.target.checked) {
            let newArray = this.state.frameworks;
            newArray.push(event.target.value);
            this.setState({ frameworks: newArray });
        } else {
            let newArray = this.state.frameworks;
            let index = this.state.frameworks.indexOf(event.target.value, 0);
            if (index > -1) {
                newArray.splice(index, 1);
            }
            this.setState({ frameworks: newArray });
        }
    }

    handleDatabasesChange(event: any): void {
        if (event.target.checked) {
            let newArray = this.state.databases;
            newArray.push(event.target.value);
            this.setState({ databases: newArray });
        } else {
            let newArray = this.state.databases;
            let index = this.state.databases.indexOf(event.target.value, 0);
            if (index > -1) {
                newArray.splice(index, 1);
            }
            this.setState({ databases: newArray });
        }
    }

    handleSubmit(event: any): void {

        let newRespondent: Respondent = new Respondent();
        newRespondent.FirstName = this.state.firstName;
        newRespondent.LastName = this.state.lastName;
        newRespondent.Age = this.state.age;
        newRespondent.Address = this.state.address;
        newRespondent.IsCurrentlyEmployed = this.state.isEmployed;
        newRespondent.CurrentPosition = this.state.currentPosition;
        newRespondent.PhoneNumber = this.state.phone;
        newRespondent.Mail = this.state.emailAddress;
        newRespondent.Skype = this.state.skype;
        newRespondent.PlaceOfStudying = this.state.placeOfStudying;
        newRespondent.SpecialCources = this.state.specialty;
        newRespondent.ProgrammingLanguages = this.state.programmingLangages.join(",");
        newRespondent.Frameworks = this.state.frameworks.join(",");
        newRespondent.Databases = this.state.databases.join(",");
        newRespondent.OtherInfo = this.state.otherInfo;
        let jsonRespondent = JSON.stringify(newRespondent);
    
        let data = new FormData();
        data.append("respondent", jsonRespondent);
        let xhr = new XMLHttpRequest();
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
                        <FormControl type="text" onChange={this.handleFirstNameChange.bind(this)} placeholder="John" />
                    </Col>
                </FormGroup>
                <FormGroup controlId="surveyFormLastName">
                    <Col componentClass={ControlLabel} sm={2}>
                        Last Name
                    </Col>
                    <Col sm={10}>
                        <FormControl type="text" onChange={this.handleLastNameChange.bind(this)} placeholder="Snow" />
                    </Col>
                </FormGroup>
                <FormGroup controlId="surveyFormAge">
                    <Col componentClass={ControlLabel} sm={2}>
                        Age
                    </Col>
                    <Col sm={10}>
                        <FormControl type="text" onChange={this.handleAgeChange.bind(this)} placeholder="18" />
                    </Col>
                </FormGroup>
                <FormGroup controlId="surveyFormAddress">
                    <Col componentClass={ControlLabel} sm={2}>
                        Address
                    </Col>
                    <Col sm={10}>
                        <FormControl type="text" onChange={this.handleAddressChange.bind(this)} placeholder="Ivano-Frankivsk city" />
                    </Col>
                </FormGroup>
                <FormGroup>
                    <Col componentClass={ControlLabel} sm={2}>
                        Are You Currently Employed?
                    </Col>
                    <Col sm={10}>
                        <Radio name="radioGroup" inline onClick={this.handleIsEmployedTrue.bind(this)}>
                            Fuck yeah!
                        </Radio>
                        {' '}
                        <Radio name="radioGroup" inline onClick={this.handleIsEmployedFalse.bind(this)}>
                            Nope, I'm homeless :(
                        </Radio>
                    </Col>
                </FormGroup>
                <FormGroup controlId="surveyFormCurrentPosition">
                    <Col componentClass={ControlLabel} sm={2}>
                        Current Position
                    </Col>
                    <Col sm={10}>
                        <FormControl type="text" onChange={this.handleCurrentPositionChange.bind(this)} placeholder="Software Engeneer" />
                    </Col>
                </FormGroup>
                <FormGroup controlId="surveyFormPhone">
                    <Col componentClass={ControlLabel} sm={2}>
                        Phone
                    </Col>
                    <Col sm={10}>
                        <FormControl type="text" onChange={this.handlePhoneChange.bind(this)} placeholder="+380 66 666 6666" />
                    </Col>
                </FormGroup>
                <FormGroup controlId="surveyFormMail">
                    <Col componentClass={ControlLabel} sm={2}>
                        Email Address
                    </Col>
                    <Col sm={10}>
                        <FormControl type="text" onChange={this.handleEmailChange.bind(this)} placeholder="example@test.com" />
                    </Col>
                </FormGroup>
                <FormGroup controlId="surveyFormSkype">
                    <Col componentClass={ControlLabel} sm={2}>
                        Skype
                    </Col>
                    <Col sm={10}>
                        <FormControl type="text" onChange={this.handleSkypeChange.bind(this)} placeholder="johnystark" />
                    </Col>
                </FormGroup>
                <hr/>


                <h3>Education</h3>
                <FormGroup controlId="surveyFormPlaceOfStudying">
                    <Col componentClass={ControlLabel} sm={2}>
                        Place Of Studying
                    </Col>
                    <Col sm={10}>
                        <FormControl type="text" onChange={this.handlePlaceOfStudyingChange.bind(this)} placeholder="IFNTUOG" />
                    </Col>
                </FormGroup>
                <FormGroup controlId="surveyFormSpecialty">
                    <Col componentClass={ControlLabel} sm={2}>
                        Specialty
                    </Col>
                    <Col sm={10}>
                        <FormControl type="text" onChange={this.handleSpecialtyChange.bind(this)} placeholder="Army Runner" />
                    </Col>
                </FormGroup>
                <hr/>
                <h3>Work Experiance</h3>
                <FormGroup>
                    <Col componentClass={ControlLabel} sm={2}>
                        Programming Languages
                    </Col>
                    <Col sm={10}>
                        <Checkbox value="C#" inline onChange={this.handleProgrammingLanguagesChange.bind(this)}>
                            C#
                        </Checkbox>
                        {' '}
                        <Checkbox value="JavaScript" inline onChange={this.handleProgrammingLanguagesChange.bind(this)}>
                            JavaScript
                        </Checkbox>
                        {' '}
                        <Checkbox value="SQL" inline onChange={this.handleProgrammingLanguagesChange.bind(this)}>
                            SQL
                        </Checkbox>
                        {' '}
                        <Checkbox value="C" inline onChange={this.handleProgrammingLanguagesChange.bind(this)}>
                            C
                        </Checkbox>
                        {' '}
                        <Checkbox value="C++" inline onChange={this.handleProgrammingLanguagesChange.bind(this)}>
                            C++
                        </Checkbox>
                        {' '}
                        <Checkbox value="PHP" inline onChange={this.handleProgrammingLanguagesChange.bind(this)}>
                            PHP
                        </Checkbox>
                        {' '}
                        <Checkbox value="Java" inline onChange={this.handleProgrammingLanguagesChange.bind(this)}>
                            Java
                        </Checkbox>
                        {' '}
                        <Checkbox value="Ruby" inline onChange={this.handleProgrammingLanguagesChange.bind(this)}>
                            Ruby
                        </Checkbox>
                        {' '}
                        <Checkbox value="Python" inline onChange={this.handleProgrammingLanguagesChange.bind(this)}>
                            Python
                        </Checkbox>
                        {' '}
                        <Checkbox value="ObjectiveC" inline onChange={this.handleProgrammingLanguagesChange.bind(this)}>
                            Objective C
                        </Checkbox>
                        {' '}
                        <Checkbox value="Swift" inline onChange={this.handleProgrammingLanguagesChange.bind(this)}>
                            Swift
                        </Checkbox>
                    </Col>
                </FormGroup>
            <FormGroup>
                <Col componentClass={ControlLabel} sm={2}>
                    Frameworks
                </Col>
                <Col sm={10}>
                        <Checkbox value="ASP.Net" inline onChange={this.handleFrameworksChange.bind(this)}>
                        ASP.Net 
                    </Checkbox>
                    {' '}
                    <Checkbox value="EntityFramework" inline onChange={this.handleFrameworksChange.bind(this)}>
                        Entity Framework
                    </Checkbox>
                    {' '}                    
                    <Checkbox value="NUnit" inline onChange={this.handleFrameworksChange.bind(this)}>
                        NUnit
                    </Checkbox>
                    {' '}
                    <Checkbox value="Angular" inline onChange={this.handleFrameworksChange.bind(this)}>
                        Angular
                    </Checkbox>
                    {' '}
                    <Checkbox value="AngularJS" inline onChange={this.handleFrameworksChange.bind(this)}>
                        AngularJS
                    </Checkbox>
                    {' '}
                    <Checkbox value="Xamarin" inline onChange={this.handleFrameworksChange.bind(this)}>
                        Xamarin
                    </Checkbox>
                    {' '}
                    <Checkbox value="Xamarin.Forms" inline onChange={this.handleFrameworksChange.bind(this)}>
                        Xamarin.Forms
                    </Checkbox>
                    {' '}
                    <Checkbox value="React" inline onChange={this.handleFrameworksChange.bind(this)}>
                        React
                    </Checkbox>
                </Col>
            </FormGroup>
            <FormGroup>
                <Col componentClass={ControlLabel} sm={2}>
                    Databases
                </Col>
                <Col sm={10}>
                    <Checkbox value="MSSQL" inline onChange={this.handleDatabasesChange.bind(this)}>
                        MS SQL
                    </Checkbox>
                    {' '}
                    <Checkbox value="SQLite" inline onChange={this.handleDatabasesChange.bind(this)}>
                        SQLite
                    </Checkbox>
                    {' '}
                    <Checkbox value="PostgreSQL" inline onChange={this.handleDatabasesChange.bind(this)}>
                        PostgreSQL
                    </Checkbox>
                    {' '}
                    <Checkbox value="MySQL" inline onChange={this.handleDatabasesChange.bind(this)}>
                        MySQL
                    </Checkbox>
                    {' '}
                    <Checkbox value="MongoDB" inline onChange={this.handleDatabasesChange.bind(this)}>
                        MongoDB
                    </Checkbox>
                    {' '}
                    <Checkbox value="Redis" inline onChange={this.handleDatabasesChange.bind(this)}>
                        Redis
                    </Checkbox>
                    {' '}
                    <Checkbox value="Xamarin" inline onChange={this.handleDatabasesChange.bind(this)}>
                        Xamarin
                    </Checkbox>
                    {' '}
                    <Checkbox value="Xamarin.Forms" inline onChange={this.handleDatabasesChange.bind(this)}>
                        Xamarin.Forms
                    </Checkbox>
                    {' '}
                    <Checkbox value="React" inline onChange={this.handleDatabasesChange.bind(this)}>
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
                    <FormControl componentClass="textarea" onChange={this.handleOtherInfoChange.bind(this)} placeholder="Some borring text" />
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