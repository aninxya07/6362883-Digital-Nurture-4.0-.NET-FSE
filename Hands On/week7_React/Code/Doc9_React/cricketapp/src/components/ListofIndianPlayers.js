import React from 'react';

const ListofIndianPlayers = ({ players }) => {
  const T20players = players.slice(0, 3);     // 1st, 2nd, 3rd
  const RanjiPlayers = players.slice(3, 6);  // 4th, 5th, 6th

  // Merge using spread operator
  const IndianPlayers = [...T20players, ...RanjiPlayers];

  return (
    <ul>
      {IndianPlayers.map((player, index) => (
        <li key={index}>{player.name}</li>
      ))}
    </ul>
  );
};

export default ListofIndianPlayers;
