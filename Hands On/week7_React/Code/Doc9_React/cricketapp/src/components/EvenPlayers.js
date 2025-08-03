import React from 'react';

const EvenPlayers = ({ team }) => {
  const evenPlayers = team.filter((_, index) => index % 2 !== 0);

  return (
    <ul>
      {evenPlayers.map((player, index) => (
        <li key={index}>{player}</li>
      ))}
    </ul>
  );
};

export default EvenPlayers;
