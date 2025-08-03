export default function UserGreeting() {
  return (
    <div>
      <h1>Welcome back</h1>
      <h3>Book Your Ticket</h3>
      <form>
        <label>From: </label>
        <input type="text" placeholder="Source City" />
        <br />
        <label>To: </label>
        <input type="text" placeholder="Destination City" />
        <br />
        <label>Date: </label>
        <input type="date" />
        <br />
        <button type="submit">Book Now</button>
      </form>
    </div>
  );
}
