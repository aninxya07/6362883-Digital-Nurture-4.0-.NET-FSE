import React, { useState } from "react";
import CurrencyConvertor from "./CurrencyConvertor";

export default function App() {
  const [count, setCount] = useState(1); 

  const increment = () => {
    setCount(count + 1);
  };

  const sayHello = () => {
    alert("Hello! Member1");
  };

  const handleIncrementClick = () => {
    increment();
    sayHello();
  };

  const decrement = () => {
    setCount(count - 1);
  };

  const sayWelcome = (msg) => {
    alert(msg);
  };

  const handleClickEvent = () => {
    alert("I was clicked");
  };

  return (
    <div>
      <h3>{count}</h3>

      <button onClick={handleIncrementClick}>Increment</button>
      <br />
      <button onClick={decrement}>Decrement</button>
      <br />
      <button onClick={() => sayWelcome("welcome")}>Say welcome</button>
      <br />
      <button onClick={handleClickEvent}>Click on me</button>
      <br />
      <CurrencyConvertor />
    </div>
  );
}
