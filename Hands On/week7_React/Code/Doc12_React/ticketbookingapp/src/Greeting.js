import UserGreeting from "./UserGreeting";
import GuestGreeting from "./GuestGreeting";

export default function Greeting(props) {
  const isLoggedIn = props.isLoggedIn;
  if (isLoggedIn) {
    return <UserGreeting />;
  }
  return <GuestGreeting />;
}
