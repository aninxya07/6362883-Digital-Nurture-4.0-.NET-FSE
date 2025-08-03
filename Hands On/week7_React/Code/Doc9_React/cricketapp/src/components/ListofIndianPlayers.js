import React from 'react';

const ListofIndianPlayers = ({ IndianPlayers }) => {
  const T20players = ["Virat", "Rohit", "Pant"];
  const RanjiPlayers = ["Pujara", "Rahane", "Ashwin"];

  // Merge using spread operator
  const allPlayers = [...T20players, ...RanjiPlayers, ...IndianPlayers];

  return (
    <ul>
      {allPlayers.map((player, index) => (
        <li key={index}>{player}</li>
      ))}
    </ul>
  );
};

export default ListofIndianPlayers;
