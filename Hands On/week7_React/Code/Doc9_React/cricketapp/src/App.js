import React from "react";
import ListofPlayers from "./components/ListofPlayers";
import Scorebelow70 from "./components/Scorebelow70";
import OddPlayers from "./components/OddPlayers";
import EvenPlayers from "./components/EvenPlayers";
import ListofIndianPlayers from "./components/ListofIndianPlayers";

export default function App() {
  const flag = false; // change to true to see other view

  const players = [
    { name: "Virat Kohli", score: 85 },
    { name: "Rohit Sharma", score: 65 },
    { name: "Shubman Gill", score: 90 },
    { name: "KL Rahul", score: 45 },
    { name: "Rishabh Pant", score: 75 },
    { name: "Hardik Pandya", score: 55 },
    { name: "Ravindra Jadeja", score: 88 },
    { name: "Mohammed Shami", score: 60 },
    { name: "Jasprit Bumrah", score: 95 },
    { name: "Bhuvneshwar Kumar", score: 40 },
    { name: "Yuzvendra Chahal", score: 72 }
  ];

  if (flag === true) {
    return (
      <div>
        <h1>List of Players</h1>
        <ListofPlayers players={players} />

        <hr />
        <h1>List of Players having Scores Less than 70</h1>
        <Scorebelow70 players={players} />
      </div>
    );
  } else {
    return (
      <div>
        <h1>Indian Team</h1>
        <h2>Odd Players</h2>
        <OddPlayers players={players} />

        <hr />
        <h2>Even Players</h2>
        <EvenPlayers players={players} />

        <hr />
        <h2>List of Indian Players Merged:</h2>
        <ListofIndianPlayers players={players} />
      </div>
    );
  }
}
