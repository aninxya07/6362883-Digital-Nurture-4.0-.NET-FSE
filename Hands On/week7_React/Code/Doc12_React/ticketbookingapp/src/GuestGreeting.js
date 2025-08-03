export default function GuestGreeting() {
  const flights = [
    { id: 1, from: "Chennai", to: "Bangalore", time: "10:00 AM" },
    { id: 2, from: "Mumbai", to: "Delhi", time: "2:00 PM" },
    { id: 3, from: "Kolkata", to: "Hyderabad", time: "6:30 PM" }
  ];

  return (
    <div>
      <h1>Please sign up.</h1>
      <h3>Available Flights</h3>
      <ul>
        {flights.map((flight) => (
          <li key={flight.id}>
            {flight.from} → {flight.to} at {flight.time}
          </li>
        ))}
      </ul>
    </div>
  );
}
