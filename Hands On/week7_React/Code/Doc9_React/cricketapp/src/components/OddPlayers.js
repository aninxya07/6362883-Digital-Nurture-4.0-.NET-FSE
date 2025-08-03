import React from 'react';

const OddPlayers = ({ team }) => {
  // Odd index means 1, 3, 5,... but in cricket "odd player" could also mean player number 1, 3, etc.
  // Here we'll take odd positions in the array (index starting from 0)
  const oddPlayers = team.filter((_, index) => index % 2 === 0);

  return (
    <ul>
      {oddPlayers.map((player, index) => (
        <li key={index}>{player}</li>
      ))}
    </ul>
  );
};

export default OddPlayers;
