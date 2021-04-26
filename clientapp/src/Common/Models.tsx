export class Customer{
    FullName: string;
    PhoneNumber: string;
    Reservations: Array<Reservation>;
}

export class Reservation{
    RoomNumber: number;
    Arrival: Date;
    Departure: Date;
}