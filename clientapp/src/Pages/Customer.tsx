import { useState } from "react";
import {
  FormControl,
  FormHelperText,
  Input,
  InputLabel,
} from "@material-ui/core";
import Button from 'react-bootstrap/Button';
import Form from 'react-bootstrap/Form';
import 'bootstrap/dist/css/bootstrap.min.css';
import { Reservation } from "../Common/Models";

const Customer = () => {
  const [enteredName, setEnteredName] = useState();

  const handleSubmit = (event:any) => {
    event.preventDefault();
    CheckIfRoomIsAvailable();
  };

  const fullNameChangeHandler = (event: any) => {
    setEnteredName(event.target.value);
  } 

  async function CheckIfRoomIsAvailable() {

    //mockup date
    let departure = new Date();
    departure.setDate(departure.getDate() + 10)

    const reservation: Reservation = {
      RoomNumber: 2,
      Arrival: new Date(),
      Departure: departure
    }
    
    const response = await fetch('https://localhost:5001/api/reservation', {
      method: 'POST', 
      body: JSON.stringify(reservation),
      headers: {
        'Content-Type': 'application/json'
      },
    });
  }

  return (
    <div>
      <h2>Customer</h2>
      <Form onSubmit={handleSubmit}>
        <FormControl>
          <InputLabel htmlFor="my-input">Full Name</InputLabel>
          <Input onChange={fullNameChangeHandler} id="my-input" aria-describedby="my-helper-text" />
        </FormControl>

        <Button variant="primary" type="submit">
          Submit
        </Button>
      </Form>
    </div>
  );
};

export default Customer;
