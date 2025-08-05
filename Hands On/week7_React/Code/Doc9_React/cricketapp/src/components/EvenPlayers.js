import React from 'react';

const EvenPlayers = ({ players }) => {
  const evenPlayers = players.filter((_, index) => index % 2 !== 0);

  return (
    <ul>
      {evenPlayers.map((player, index) => (
        <li key={index}>{player.name}</li>
      ))}
    </ul>
  );
};

export default EvenPlayers;
